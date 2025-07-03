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


        /* ---------- Função de inicialização ---------- */
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


        /* ---------- Formatação do texto ---------- */

        /* ---------- Registo ---------- */
        private void tb_RegisterUsername_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterUsername.Text == "Username")
            {
                tb_RegisterUsername.Text = "";
                tb_RegisterUsername.ForeColor = Color.Black;
            }
        }
        private void tb_RegisterUsername_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterUsername.Text == "")
            {
                tb_RegisterUsername.Text = "Username";
                tb_RegisterUsername.ForeColor = Color.Silver;
            }
        }
        private void tb_RegisterEmail_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterEmail.Text == "Email")
            {
                tb_RegisterEmail.Text = "";
                tb_RegisterEmail.ForeColor = Color.Black;
            }
        }
        private void tb_RegisterEmail_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterEmail.Text == "")
            {
                tb_RegisterEmail.Text = "Email";
                tb_RegisterEmail.ForeColor = Color.Silver;
            }
        }
        private void tb_RegisterPassword_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterPassword.Text == "Password")
            {
                tb_RegisterPassword.Text = "";
                tb_RegisterPassword.UseSystemPasswordChar = true;
                tb_RegisterPassword.ForeColor = Color.Black;
            }
        }
        private void tb_RegisterPassword_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterPassword.Text == "")
            {
                tb_RegisterPassword.Text = "Password";
                tb_RegisterPassword.UseSystemPasswordChar = false;
                tb_RegisterPassword.ForeColor = Color.Silver;
            }
        }
        private void tb_RegisterConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterConfirmPassword.Text == "")
            {
                tb_RegisterConfirmPassword.Text = "Confirm Password";
                tb_RegisterConfirmPassword.UseSystemPasswordChar = false;
                tb_RegisterConfirmPassword.ForeColor = Color.Silver;
            }
        }
        private void tb_RegisterConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterConfirmPassword.Text == "Confirm Password")
            {
                tb_RegisterConfirmPassword.Text = "";
                tb_RegisterConfirmPassword.UseSystemPasswordChar = true;
                tb_RegisterConfirmPassword.ForeColor = Color.Black;
            }
        }

        /* ---------- Login ---------- */
        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Username")
            {
                tb_Username.Text = "";            
                tb_Username.ForeColor = Color.Black;     
            }
        }
        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";          
                tb_Username.ForeColor = Color.Silver;    
            }
        }
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Password")
            {
                tb_Password.Text = "";                     
                tb_Password.UseSystemPasswordChar = true;  
                tb_Password.ForeColor = Color.Black;      
            }
        }
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Password";              
                tb_Password.UseSystemPasswordChar = false; 
                tb_Password.ForeColor = Color.Silver;    
            }
        }


        /* ---------- Funções do Register/Login ---------- */
        private void b_Login_Click(object sender, EventArgs e)
        {
            string user = tb_Username.Text;
            string pass = tb_Password.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            try
            {
                TcpClient tcp = new TcpClient("127.0.0.1", 10000);
                clientStream = new ProtoStream(tcp.GetStream());

                // 1. RSA Handshake
                rsa = new RSACryptoServiceProvider(2048);
                string pubXml = rsa.ToXmlString(false);
                clientStream.Transmit(pubXml);

                clientStream.Receive();
                string encKeyB64 = clientStream.GetDataAs<string>();
                byte[] encKey = Convert.FromBase64String(encKeyB64);
                byte[] keyBytes = rsa.Decrypt(encKey, false);

                // 2. AES com chave recebida
                aes = new AesCryptoServiceProvider();
                aes.Key = keyBytes;

                // 3. Envia credenciais cifradas num só pacote!
                string userEncrypted = EncryptString(user, aes);
                string passEncrypted = EncryptString(pass, aes);
                string pacote = userEncrypted + "||" + passEncrypted;
                clientStream.Transmit(pacote);

                // Debug (podes remover)
                Console.WriteLine("Enviado pacote credenciais: " + pacote);

                // 4. Resposta do servidor
                clientStream.Receive();
                string resp = DecryptString(clientStream.GetDataAs<string>(), aes);

                if (resp != "LOGIN_OK")
                {
                    MessageBox.Show("Utilizador ou senha inválidos.");
                    tcp.Close();
                    return;
                }

                // 5. Guarda sessão
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

        private static string EncryptString(string plain, AesCryptoServiceProvider aes)
        {
            if (aes == null || aes.Key == null)
                throw new ArgumentNullException("AES está nulo ou não tem chave definida.");

            aes.GenerateIV();
            byte[] iv = aes.IV;
            byte[] ct = aes.CreateEncryptor(aes.Key, iv)
                           .TransformFinalBlock(Encoding.UTF8.GetBytes(plain), 0, plain.Length);
            return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(ct);
        }
        private static string DecryptString(string data, SymmetricAlgorithm aes)
        {
            if (string.IsNullOrWhiteSpace(data) || !data.Contains("|"))
                throw new FormatException("Dados recebidos não contêm o separador '|'");

            string[] parts = data.Split('|');
            if (parts.Length != 2)
                throw new FormatException("Formato inválido: deve conter IV|Cipher");

            byte[] iv = Convert.FromBase64String(parts[0]);
            byte[] cipher = Convert.FromBase64String(parts[1]);
            byte[] plain = aes.CreateDecryptor(aes.Key, iv)
                                .TransformFinalBlock(cipher, 0, cipher.Length);
            return Encoding.UTF8.GetString(plain);
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

        private void l_Login_Click(object sender, EventArgs e)
        {
            l_Login.Visible = true;
            l_Register.Visible = false;
        }

        private void l_Register_Click(object sender, EventArgs e)
        {
            l_Register.Visible = true;
            l_Login.Visible = false;
        }
    }
}
