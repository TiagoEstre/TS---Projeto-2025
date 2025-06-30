using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using ProtoIP;
using iChat.Models; // Namespace com o teu DbContext e entidades

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ajustado para .NET Framework 4.8, sem using declarations
            TcpListener listener = new TcpListener(IPAddress.Any, 10000);
            listener.Start();
            Console.WriteLine("Servidor à escuta na porta 10000...");

            while (true)
            {
                // Abrir cliente
                TcpClient tcp = listener.AcceptTcpClient();
                Console.WriteLine("Novo cliente conectado.");

                // Stream de rede e wrapper ProtoStream
                NetworkStream netStream = tcp.GetStream();
                ProtoStream stream = new ProtoStream(netStream);

                // 1) RSA handshake: receber XML público, gerar AES e enviar chave cifrada
                stream.Receive();
                string clientPubXml = stream.GetDataAs<string>();
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(clientPubXml);

                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.GenerateKey();
                byte[] encKey = rsa.Encrypt(aes.Key, false);
                stream.Transmit(Convert.ToBase64String(encKey));

                // 2) Receber credenciais cifradas e descifrar
                stream.Receive();
                string encUser = stream.GetDataAs<string>();
                stream.Receive();
                string encPass = stream.GetDataAs<string>();

                string username = DecryptString(encUser, aes);
                string password = DecryptString(encPass, aes);

                // 3) Autenticação com Entity Framework      
                string pwdHash = HashSHA256(password);
                bool ok;
                using (var db = new iChatContext())
                {
                    ok = db.Users.Any(u => u.Name == username && u.Password == pwdHash);
                }

                // 4) Responder ao cliente
                string reply = ok ? "LOGIN_OK" : "LOGIN_FAIL";
                stream.Transmit(EncryptString(reply, aes));

                // Fechar sessão cliente
                tcp.Close();
                Console.WriteLine($"Sessão ({username}) terminada: {(ok ? "sucesso" : "falha")}.");
            }
        }

        // — Helpers criptográficos —
        private static string EncryptString(string plain, SymmetricAlgorithm aes)
        {
            aes.GenerateIV();
            byte[] iv = aes.IV;
            byte[] cipher = aes.CreateEncryptor(aes.Key, iv)
                               .TransformFinalBlock(Encoding.UTF8.GetBytes(plain), 0, plain.Length);
            return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(cipher);
        }

        private static string DecryptString(string data, SymmetricAlgorithm aes)
        {
            string[] parts = data.Split('|');
            byte[] iv = Convert.FromBase64String(parts[0]);
            byte[] cipher = Convert.FromBase64String(parts[1]);
            byte[] plain = aes.CreateDecryptor(aes.Key, iv)
                                .TransformFinalBlock(cipher, 0, cipher.Length);
            return Encoding.UTF8.GetString(plain);
        }

        private static string HashSHA256(string input)
        {
            using (var sha = SHA256.Create())
            {
                byte[] h = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in h)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}