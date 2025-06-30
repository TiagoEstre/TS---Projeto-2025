using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ProtoIP;
using iChat.Models;
using iChat.controller;
using iChat.views;

namespace iChat
{
    public partial class LoginForm : Form
    {
        private RSACryptoServiceProvider rsa;
        private AesCryptoServiceProvider aes;
        private ProtoStream clientStream;

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Decide se mostra login ou registo
            bool hasUsers = UsersExist();
            p_Login.Visible = hasUsers;
            p_Register.Visible = !hasUsers;

            var creds = LoadCredentials();
            if (creds.HasValue)
            {
                tb_Username.Text = creds.Value.username;
                tb_Password.Text = creds.Value.password;
                tb_Password.UseSystemPasswordChar = true;
                ts_Remember.Checked = true;
            }
        }

        private void b_Login_Click(object sender, EventArgs e)
        {
            string user = tb_Username.Text;
            string pass = tb_Password.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) ||
                user == "Username" || pass == "Password")
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            try
            {
                TcpClient tcp = new TcpClient("127.0.0.1", 10000);
                clientStream = new ProtoStream(tcp.GetStream());

                // RSA handshake
                rsa = new RSACryptoServiceProvider(2048);
                string pubXml = rsa.ToXmlString(false);
                clientStream.Transmit(pubXml);

                clientStream.Receive();
                string encKeyB64 = clientStream.GetDataAs<string>();
                byte[] encKey = Convert.FromBase64String(encKeyB64);
                byte[] keyBytes = rsa.Decrypt(encKey, false);
                aes = new AesCryptoServiceProvider();
                aes.Key = keyBytes;

                // Envia credenciais cifradas
                clientStream.Transmit(EncryptString(user, aes));
                clientStream.Transmit(EncryptString(pass, aes));

                // Lê resposta
                clientStream.Receive();
                string resp = DecryptString(clientStream.GetDataAs<string>(), aes);
                if (resp != "LOGIN_OK")
                {
                    MessageBox.Show("Utilizador ou senha inválidos.");
                    tcp.Close();
                    return;
                }

                // Guarda sessão e abre chat
                if (ts_Remember.Checked) SaveCredentials(user, pass);
                else ClearSavedCredentials();

                sessionManager.Login(new User { Name = user, Email = "" });
                var chat = new ChatForm();
                this.Hide();
                chat.FormClosed += (s, a) => this.Close();
                chat.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: " + ex.Message);
            }
        }

        private void b_Register_Click(object sender, EventArgs e)
        {
            string u = tb_RegisterUsername.Text;
            string eMail = tb_RegisterEmail.Text;
            string p1 = tb_RegisterPassword.Text;
            string p2 = tb_RegisterConfirmPassword.Text;
            if (p1 != p2)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Hash sem salt (pode adicionar salt igual ao servidor se quiser)
            string h = HashSHA256(p1);
            using (var db = new iChatContext())
            {
                db.Users.Add(new User { Name = u, Email = eMail, Password = h });
                db.SaveChanges();
            }

            p_Register.Visible = false;
            p_Login.Visible = true;
        }

        // — Helpers de criptografia e de sessão —

        private static string EncryptString(string plain, AesCryptoServiceProvider aes)
        {
            aes.GenerateIV();
            byte[] iv = aes.IV;
            byte[] ct = aes.CreateEncryptor(aes.Key, iv)
                           .TransformFinalBlock(Encoding.UTF8.GetBytes(plain), 0, plain.Length);
            return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(ct);
        }

        private static string DecryptString(string data, AesCryptoServiceProvider aes)
        {
            var parts = data.Split('|');
            byte[] iv = Convert.FromBase64String(parts[0]);
            byte[] ct = Convert.FromBase64String(parts[1]);
            byte[] pt = aes.CreateDecryptor(aes.Key, iv)
                           .TransformFinalBlock(ct, 0, ct.Length);
            return Encoding.UTF8.GetString(pt);
        }

        private (string username, string password)? LoadCredentials()
        {
            if (File.Exists("username.dat") && File.Exists("password.dat"))
            {
                string u = File.ReadAllText("username.dat");
                byte[] blob = File.ReadAllBytes("password.dat");
                byte[] dp = ProtectedData.Unprotect(blob, null, DataProtectionScope.CurrentUser);
                return (u, Encoding.UTF8.GetString(dp));
            }
            return null;
        }

        private void SaveCredentials(string u, string p)
        {
            File.WriteAllText("username.dat", u);
            byte[] b = Encoding.UTF8.GetBytes(p);
            File.WriteAllBytes("password.dat", ProtectedData.Protect(b, null, DataProtectionScope.CurrentUser));
        }

        private void ClearSavedCredentials()
        {
            if (File.Exists("username.dat")) File.Delete("username.dat");
            if (File.Exists("password.dat")) File.Delete("password.dat");
        }

        private bool UsersExist()
        {
            using (var db = new iChatContext())
                return db.Users.Any();
        }

        private static string HashSHA256(string input)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] h = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                foreach (byte b in h) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
