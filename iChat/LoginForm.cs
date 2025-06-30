using iChat.controller;
using iChat.models;
using iChat.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iChat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Load += LoginForm_Load;
        }
        private (string username, string password)? LoadCredentials()
        {
            try
            {
                // Verifica se os ficheiros existem
                if (File.Exists("username.dat") && File.Exists("password.dat"))
                {
                    // Lê o username
                    string username = File.ReadAllText("username.dat");

                    // Lê e desencripta a palavra-passe
                    byte[] encryptedPassword = File.ReadAllBytes("password.dat");
                    byte[] decryptedPassword = ProtectedData.Unprotect(encryptedPassword, null, DataProtectionScope.CurrentUser);
                    string password = Encoding.UTF8.GetString(decryptedPassword);

                    return (username, password);
                }
            }
            catch
            {
                // Silenciosamente ignora erros
            }

            return null;
        }
        private bool UsersExist()
        {
            try
            {
                // Abre uma ligação a base de dados
                using (var db = new iChatContext())
                {
                    // Verifica se existe algum registo na tabela Users
                    return db.Users.Any();
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostra uma mensagem ao utilizador
                MessageBox.Show("Erro ao aceder à base de dados: " + ex.Message);
                return false; // Retorna false se ocorrer uma exceção
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Verifica se já existem utilizadores registados na base de dados
            if (UsersExist())
            {
                // Se existirem  utilizadores, mostra o painel de login
                p_Login.Visible = true;
                // Esconde o painel de registo
                p_Register.Visible = false;

                // Tenta carregar credenciais guadadas anteriormente (se esistirem)
                var credenciais = LoadCredentials();
                if (credenciais.HasValue)
                {
                    tb_Username.Text = credenciais.Value.username;  // Preenche automaticamente o campo do nome utilizador com o valor guardado
                    tb_Username.ForeColor = Color.Black;            // Define a cor do texto como preto (em vez do cinzento do placeholder)

                    tb_Password.Text = credenciais.Value.password;  // Preenche o campo da palavra-passe com a palavra-passe recuperada
                    tb_Password.UseSystemPasswordChar = true;       // Mostra os caracteres como "•" (modo de palavra-passe)
                    tb_Password.ForeColor = Color.Black;

                    ts_Remember.Checked = true;                   // Marca a ToggleSwitch "Lembra-me como ativa"
                }
            }
            else
            {
                // Se não existirem utilizadores, esconde o painel de login
                p_Login.Visible = false;
                // Mostra o painel de registo, Permitindo a criação do primeiro utilizador
                p_Register.Visible = true;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void p_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                               
            SendMessage(this.Handle, 0x112, 0xf012, 0);     
        }
        private void p_Register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                               
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /* ---------- Login ---------- */

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text  == "Username")
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
                tb_Username.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Password")
            {
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
                tb_Password.UseSystemPasswordChar = true;
            }
        }
        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Password";
                tb_Password.ForeColor = Color.FromArgb(125, 137, 149);
                tb_Password.UseSystemPasswordChar = false;
            }
        }
        private void SaveCredentials(string username, string password)
        {
            try
            {
                // Guarda o username em texto simples
                File.WriteAllText("username.dat", username);

                // encripta a palavra e guarda-a em ficheiro
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] encryptedPassword = ProtectedData.Protect(passwordBytes, null, DataProtectionScope.CurrentUser);
                File.WriteAllBytes("password.dat", encryptedPassword);
            }
            catch
            {
                // Mostra erro caso não seja possivel guardar as credenciais
                MessageBox.Show("Erro ao guardar as credenciais.");
            }
        }
        private void ClearSavedCredentials()
        {
            try
            {
                // Verifica se o ficheiro onde esta guardado o nome do utilizador e a palavra-passe
                if (File.Exists("username.dat")) File.Delete("username.dat");   // Se existir, apaga-o
                if (File.Exists("password.dat")) File.Delete("password.dat");   // Se existir, apaga-o
            }
            catch
            {
                // Em caso de erro, a exceção é ignorada silenciosamente
            }
        }
        private string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);   
                byte[] hash = sha256.ComputeHash(bytes);            
                StringBuilder result = new StringBuilder();         

                foreach (byte b in hash)
                    result.Append(b.ToString("x2"));                

                return result.ToString();                           
            }
        }
        private void Closed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
        private void b_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;

            if (username == "Username" || password == "Password")
            {
                MessageBox.Show("Todos os campos são de prencimento obrigadorio.");
                return;
            }

            string hashedPassword = HashPasswordSHA256(password);

            using (var db = new iChatContext())
            {
                var utilizador = db.Users.FirstOrDefault(x => x.Name == username);

                if (utilizador != null && utilizador.Password == hashedPassword)
                {
                    if(ts_Remember.Checked)
                        SaveCredentials(username, password);
                    else
                        ClearSavedCredentials();

                    sessionManager.Login(utilizador);

                    ChatForm chat = new ChatForm();

                    Hide();
                    chat.FormClosed += Closed_FormClosed;
                    chat.Show();
                }
            }
        }
        private void l_Register_Click(object sender, EventArgs e)
        {
            p_Login.Visible = false;
            p_Register.Visible = true;
        }
        

        /* ---------- Register ---------- */

        private void RegisterUsername_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterUsername.Text == "Username")
            {
                tb_RegisterUsername.Text = "";
                tb_RegisterUsername.ForeColor = Color.Black;
            }
        }

        private void RegisterUsername_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterUsername.Text == "")
            {
                tb_RegisterUsername.Text = "Username";
                tb_RegisterUsername.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void RegisterEmail_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterEmail.Text == "Email")
            {
                tb_RegisterEmail.Text = "";
                tb_RegisterEmail.ForeColor = Color.Black;
            }
        }

        private void RegisterEmail_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterEmail.Text == "")
            {
                tb_RegisterEmail.Text = "Email";
                tb_RegisterEmail.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void RegisterPassword_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterPassword.Text == "Password")
            {
                tb_RegisterPassword.Text = "";
                tb_RegisterPassword.ForeColor = Color.Black;
                tb_RegisterPassword.UseSystemPasswordChar = true;
            }
        }

        private void RegisterPassword_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterPassword.Text == "")
            {
                tb_RegisterPassword.Text = "Password";
                tb_RegisterPassword.ForeColor = Color.FromArgb(125, 137, 149);
                tb_RegisterPassword.UseSystemPasswordChar = false;
            }
        }

        private void RegisterConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (tb_RegisterConfirmPassword.Text == "Confirm Password")
            {
                tb_RegisterConfirmPassword.Text = "";
                tb_RegisterConfirmPassword.ForeColor = Color.Black;
                tb_RegisterConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void RegisterConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (tb_RegisterConfirmPassword.Text == "")
            {
                tb_RegisterConfirmPassword.Text = "Confirm Password";
                tb_RegisterConfirmPassword.ForeColor = Color.FromArgb(125, 137, 149);
                tb_RegisterConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void b_Register_Click(object sender, EventArgs e)
        {
            // Captura os valores dos campos de texto do formulario
            string Username = tb_RegisterUsername.Text;
            string Email = tb_RegisterEmail.Text;
            string Password = tb_RegisterPassword.Text;
            string ConfirmPassword = tb_RegisterConfirmPassword.Text;

            // Validação: verifica se as senhas coincidem
            if (Password != ConfirmPassword)
            {
                MessageBox.Show("As senhas não coincidem.");        // Mostra mensagem de aviso
                return;                                             // Interrompe a execução do metedo
            }

            // Cria uma instancia do contexto da base de dados
            using (var db = new iChatContext())
            {
                try
                {
                    // Cria um novo objeto de utilizador do tipo (Maneger)
                    var newUser = new User()
                    {
                        Name = Username,                                
                        Email = Email,                        
                        Password = HashPasswordSHA256(Password)                
                    };

                    // Adiciona o novo utilizador a base de dados
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    // Esconde o painel de registo e mostra o painel de login
                    p_Register.Visible = false;
                    p_Login.Visible = true;
                }
                catch
                {
                    // Caso ocorra um erro ao aceder a base de dados, mostra uma mensagem de erro
                    MessageBox.Show("Não Foi Possivel Aceder a Base de Dados");
                    return;
                }
            }
        }
        private void l_Login_Click(object sender, EventArgs e)
        {
            p_Register.Visible = false;
            p_Login.Visible = true;
        }

    }
}
