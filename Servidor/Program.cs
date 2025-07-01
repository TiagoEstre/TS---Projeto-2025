using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using ProtoIP;
using iChat.Models;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 10000);
            listener.Start();
            Console.WriteLine("Servidor à escuta na porta 10000...");

            while (true)
            {
                TcpClient tcp = listener.AcceptTcpClient();
                Console.WriteLine("Novo cliente conectado.");

                NetworkStream netStream = tcp.GetStream();
                ProtoStream stream = new ProtoStream(netStream);

                try
                {
                    // 1) Handshake
                    stream.Receive();
                    string clientPubXml = stream.GetDataAs<string>();
                    RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(clientPubXml);

                    AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                    aes.GenerateKey();
                    byte[] encKey = rsa.Encrypt(aes.Key, false);
                    stream.Transmit(Convert.ToBase64String(encKey));

                    // 2) Recebe credenciais cifradas num só pacote
                    stream.Receive();
                    string encCreds = stream.GetDataAs<string>();
                    string[] creds = encCreds.Split(new[] { "||" }, StringSplitOptions.None);
                    if (creds.Length != 2) throw new Exception("Erro ao separar credenciais!");

                    string encUser = creds[0];
                    string encPass = creds[1];

                    Console.WriteLine($"Recebido encUser: {encUser}");
                    Console.WriteLine($"Recebido encPass: {encPass}");

                    string username = DecryptString(encUser, aes);
                    string password = DecryptString(encPass, aes);

                    // 3) Autenticação EF
                    string pwdHash = HashSHA256(password);
                    bool ok;
                    using (var db = new iChatContext())
                    {
                        ok = db.Users.Any(u => u.Name == username && u.Password == pwdHash);
                    }

                    // 4) Resposta
                    string reply = ok ? "LOGIN_OK" : "LOGIN_FAIL";
                    stream.Transmit(EncryptString(reply, aes));
                    Console.WriteLine($"Sessão ({username}) terminada: {(ok ? "sucesso" : "falha")}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERRO: " + ex.Message);
                }
                finally
                {
                    tcp.Close();
                }
            }
        }

        // Encriptação AES com IV incluído
        private static string EncryptString(string plain, SymmetricAlgorithm aes)
        {
            aes.GenerateIV();
            byte[] iv = aes.IV;
            byte[] cipher = aes.CreateEncryptor(aes.Key, iv)
                               .TransformFinalBlock(Encoding.UTF8.GetBytes(plain), 0, plain.Length);
            return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(cipher);
        }

        // Desencriptação com proteção contra erro de Base64
        private static string DecryptString(string data, SymmetricAlgorithm aes)
        {
            if (!data.Contains("|"))
                throw new FormatException("Dados recebidos não contêm o separador '|'");

            string[] parts = data.Split('|');
            if (parts.Length != 2)
                throw new FormatException("Formato inválido: não há duas partes após split");

            try
            {
                byte[] iv = Convert.FromBase64String(parts[0]);
                byte[] cipher = Convert.FromBase64String(parts[1]);
                byte[] plain = aes.CreateDecryptor(aes.Key, iv)
                                  .TransformFinalBlock(cipher, 0, cipher.Length);
                return Encoding.UTF8.GetString(plain);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro ao converter Base64:");
                Console.WriteLine("Parte IV: " + parts[0]);
                Console.WriteLine("Parte Cifra: " + parts[1]);
                throw new FormatException("Base64 inválido: " + ex.Message);
            }
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
