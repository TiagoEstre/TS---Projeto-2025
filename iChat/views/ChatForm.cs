using iChat.controller;
using iChat.Models;
using ProtoIP;
using System;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace iChat.views
{
    public partial class ChatForm : Form
    {
        private User selectUser;
        private RSACryptoServiceProvider rsa;
        private AesCryptoServiceProvider aes;
        private ProtoStream clientStream;
        private TcpClient tcp;

        public ChatForm()
        {
            InitializeComponent();
            SetupSession();
            User();
        }

        private void SetupSession()
        {
            try
            {
                tcp = new TcpClient("127.0.0.1", 10000);
                clientStream = new ProtoStream(tcp.GetStream());

                rsa = new RSACryptoServiceProvider(2048);
                string publicKeyXml = rsa.ToXmlString(false);
                clientStream.Transmit(publicKeyXml);

                clientStream.Receive();
                string encKeyB64 = clientStream.GetDataAs<string>();
                byte[] encKey = Convert.FromBase64String(encKeyB64);
                byte[] keyBytes = rsa.Decrypt(encKey, false);

                aes = new AesCryptoServiceProvider();
                aes.Key = keyBytes;

                sessionManager.CurrentUserPrivateKey = rsa.ToXmlString(true);

                AuthenticateUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao estabelecer sessão segura: " + ex.Message);
            }
        }

        private void AuthenticateUser()
        {
            try
            {
                var user = sessionManager.CurrentUser;
                if (user == null || string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password))
                {
                    MessageBox.Show("Usuário ou senha não definidos.");
                    Close();
                    return;
                }

                string encUser = EncryptString(user.Name, aes);
                string encPass = EncryptString(user.Password, aes);
                string credenciais = $"{encUser}||{encPass}";

                clientStream.Transmit(credenciais);

                clientStream.Receive();
                string replyEncrypted = clientStream.GetDataAs<string>();
                if (string.IsNullOrEmpty(replyEncrypted))
                {
                    MessageBox.Show("Resposta vazia do servidor.");
                    Close();
                    return;
                }

                string reply = DecryptString(replyEncrypted, aes);
                if (reply != "LOGIN_OK")
                {
                    MessageBox.Show("Falha no login.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na autenticação: " + ex.Message);
                Close();
            }
        }

        private void User()
        {
            var currencyManager = sessionManager.CurrentUser;
            b_User.Text = currencyManager.Name;

            using (var db = new iChatContext())
            {
                var listUser = db.Users
                    .Where(l => l.Id != currencyManager.Id)
                    .ToList();

                lb_Users.DataSource = listUser;
                lb_Users.DisplayMember = "Name";
                lb_Users.ValueMember = "Id";
                lb_Users.ClearSelected();
            }
        }

        private void lb_Users_DoubleClick(object sender, EventArgs e)
        {
            if (lb_Users.SelectedItem is User user)
            {
                selectUser = user;
                tb_Id.Text = selectUser.Id.ToString();
                tb_Name.Text = selectUser.Name;
                tb_Email.Text = selectUser.Email;

                LoadMessages();
            }
        }

        private void b_send_Click(object sender, EventArgs e)
        {
            if (selectUser == null || string.IsNullOrWhiteSpace(tb_Message.Text))
            {
                MessageBox.Show("Selecione um utilizador e escreva uma mensagem.");
                return;
            }

            string message = tb_Message.Text.Trim();

            try
            {
                var rsaSign = new RSACryptoServiceProvider();
                rsaSign.FromXmlString(sessionManager.CurrentUserPrivateKey);
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                byte[] signature = rsaSign.SignData(messageBytes, new SHA256CryptoServiceProvider());
                string signatureB64 = Convert.ToBase64String(signature);

                string encryptedMessage = EncryptString(message, aes);

                string pacote = $"{sessionManager.CurrentUser.Id}||{selectUser.Id}||{encryptedMessage}||{signatureB64}";
                clientStream.Transmit(pacote);

                tb_Message.Clear();
                LoadMessages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar: " + ex.Message);
            }
        }

        private void LoadMessages()
        {
            if (selectUser == null) return;

            using (var db = new iChatContext())
            {
                var myId = sessionManager.CurrentUser.Id;
                var msgs = db.Messagers
                    .Where(m => (m.SenderId == myId && m.ReceiverId == selectUser.Id)
                             || (m.SenderId == selectUser.Id && m.ReceiverId == myId))
                    .OrderBy(m => m.Timestamp)
                    .ToList();

                lb_Mensage.Items.Clear();
                foreach (var msg in msgs)
                {
                    try
                    {
                        string plain = DecryptString(msg.MessageEncrypted, aes);
                        string senderName = msg.SenderId == myId ? "Você" : selectUser.Name;
                        lb_Mensage.Items.Add($"{senderName}: {plain}");
                    }
                    catch
                    {
                        lb_Mensage.Items.Add("Mensagem inválida ou corrompida.");
                    }
                }
            }
        }

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
            byte[] cipher = Convert.FromBase64String(parts[1]);
            byte[] plain = aes.CreateDecryptor(aes.Key, iv)
                              .TransformFinalBlock(cipher, 0, cipher.Length);
            return Encoding.UTF8.GetString(plain);
        }
    }
}