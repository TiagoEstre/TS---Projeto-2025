using ProtoIP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace ServidorSeguro
{
    class ClientSession
    {
        public TcpClient TcpClient;                  // Guarda o TcpClient para fechar depois
        public ProtoStream Stream;                   // ProtoStream para comunicações
        public AesCryptoServiceProvider Aes;         // Chave AES do cliente
        public string Username;
    }

    class Program
    {
        const int PORT = 10000;
        const string LOG_FILE = "chat.log";

        static readonly List<ClientSession> sessions = new List<ClientSession>();
        static readonly object sessionsLock = new object();

        static void Main()
        {
            // Limpa log antigo
            if (File.Exists(LOG_FILE)) File.Delete(LOG_FILE);

            var listener = new TcpListener(IPAddress.Any, PORT);
            listener.Start();
            Console.WriteLine($"Servidor à escuta na porta {PORT}...");

            while (true)
            {
                var tcp = listener.AcceptTcpClient();
                Console.WriteLine("Novo cliente conectado.");
                var ps = new ProtoStream(tcp.GetStream());

                var session = new ClientSession { TcpClient = tcp, Stream = ps };
                lock (sessionsLock) sessions.Add(session);

                new Thread(() => HandleClient(session)) { IsBackground = true }.Start();
            }
        }

        static void HandleClient(ClientSession sess)
        {
            try
            {
                var stream = sess.Stream;

                // 1) Handshake RSA → AES
                stream.Receive();
                string clientPubXml = stream.GetDataAs<string>();
                var rsaClient = new RSACryptoServiceProvider();
                rsaClient.FromXmlString(clientPubXml);

                var aes = new AesCryptoServiceProvider();
                aes.GenerateKey();
                sess.Aes = aes;

                byte[] encAesKey = rsaClient.Encrypt(aes.Key, false);
                string encAesKeyB64 = Convert.ToBase64String(encAesKey);
                stream.Transmit(encAesKeyB64);

                // 2) Autenticação
                stream.Receive();
                string username = DecryptString(stream.GetDataAs<string>(), aes);
                stream.Receive();
                string password = DecryptString(stream.GetDataAs<string>(), aes);
                sess.Username = username;
                Console.WriteLine($"[{username}] login: {password}");

                stream.Transmit(EncryptString("LOGIN_OK", aes));
                Broadcast($"{username} entrou no chat.", sess);

                // 3) Loop de mensagens
                while (true)
                {
                    stream.Receive();
                    string data = stream.GetDataAs<string>();
                    string msg = DecryptString(data, aes);

                    string line = $"[{username}] {msg}";
                    Console.WriteLine(line);
                    File.AppendAllText(LOG_FILE, line + Environment.NewLine);

                    Broadcast(line, sess);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sessão {sess.Username ?? "(desconhecido)"} terminou: {ex.Message}");
            }
            finally
            {
                lock (sessionsLock) sessions.Remove(sess);
                Broadcast($"{sess.Username ?? "Um cliente"} saiu.", null);
                try { sess.TcpClient.Close(); } catch { }
            }
        }

        static void Broadcast(string message, ClientSession except)
        {
            lock (sessionsLock)
            {
                foreach (var s in sessions)
                {
                    if (s == except) continue;
                    try
                    {
                        s.Stream.Transmit(EncryptString(message, s.Aes));
                    }
                    catch { }
                }
            }
        }

        // Helpers AES
        static string EncryptString(string plain, AesCryptoServiceProvider aes)
        {
            byte[] iv = aes.IV;
            var encryptor = aes.CreateEncryptor(aes.Key, iv);
            byte[] cipher = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plain), 0, plain.Length);
            return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(cipher);
        }

        static string DecryptString(string data, AesCryptoServiceProvider aes)
        {
            var parts = data.Split('|');
            byte[] iv = Convert.FromBase64String(parts[0]);
            byte[] cipher = Convert.FromBase64String(parts[1]);
            var decryptor = aes.CreateDecryptor(aes.Key, iv);
            byte[] plain = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
            return Encoding.UTF8.GetString(plain);
        }
    }
}
