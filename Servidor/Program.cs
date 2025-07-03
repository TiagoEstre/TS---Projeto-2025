using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

                // ✅ Cria uma thread para esse cliente
                Thread clientThread = new Thread(() => HandleClient(tcp));
                clientThread.Start();
            }
        }

        // ✅ Lógica original do cliente, agora num método separado
        private static void HandleClient(TcpClient tcp)
        {
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
                int userId = 0;

                using (var db = new iChatContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Name == username && u.Password == pwdHash);
                    ok = user != null;
                    if (ok) userId = user.Id;
                }

                // 4) Resposta
                string reply = ok ? "LOGIN_OK" : "LOGIN_FAIL";
                stream.Transmit(EncryptString(reply, aes));
                Console.WriteLine($"Sessão ({username}) terminada: {(ok ? "sucesso" : "falha")}.");

                // 5) Se autenticado, processar mensagens
                if (ok)
                {
                    while (true)
                    {
                        // Espera novo pacote: Envio de mensagem (idRemetente||idDestinatario||msgCifrada||assinatura)
                        stream.Receive();
                        string msgPacote = stream.GetDataAs<string>();
                        string[] parts = msgPacote.Split(new[] { "||" }, StringSplitOptions.None);
                        if (parts.Length != 4)
                        {
                            Console.WriteLine("Formato inválido de mensagem.");
                            continue;
                        }

                        int senderId = int.Parse(parts[0]);
                        int receiverId = int.Parse(parts[1]);
                        string encryptedMessage = parts[2];
                        string signatureB64 = parts[3];

                        // 6) Obter chave pública do remetente
                        string publicKey;
                        using (var db = new iChatContext())
                        {
                            var user = db.Users.FirstOrDefault(u => u.Id == senderId);
                            if (user == null)
                            {
                                Console.WriteLine("Remetente não encontrado.");
                                continue;
                            }
                            publicKey = user.PublicKey;
                        }

                        // 7) Validar assinatura
                        string plainMessage = DecryptString(encryptedMessage, aes);
                        var rsaVerify = new RSACryptoServiceProvider();
                        rsaVerify.FromXmlString(publicKey);
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainMessage);
                        byte[] signature = Convert.FromBase64String(signatureB64);

                        bool valid = rsaVerify.VerifyData(plainBytes, new SHA256CryptoServiceProvider(), signature);

                        if (!valid)
                        {
                            Console.WriteLine("Assinatura digital inválida.");
                            continue;
                        }

                        // 8) Grava no banco de dados
                        using (var db = new iChatContext())
                        {
                            db.Messagers.Add(new Messager
                            {
                                SenderId = senderId,
                                ReceiverId = receiverId,
                                MessageEncrypted = encryptedMessage,
                                Signature = signatureB64,
                                Timestamp = DateTime.Now
                            });
                            db.SaveChanges();
                        }

                        // 9) Grava no log
                        string log = $"[{DateTime.Now}] {senderId} => {receiverId} :: {plainMessage}";
                        File.AppendAllText("log.txt", log + Environment.NewLine);
                        Console.WriteLine("Mensagem recebida e armazenada.");
                    }
                }
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