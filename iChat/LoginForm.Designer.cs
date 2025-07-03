namespace iChat
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tb_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.p_Login = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ts_Remember = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.l_Register = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.p_Register = new Guna.UI2.WinForms.Guna2Panel();
            this.l_Login = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_Register = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tb_RegisterConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_RegisterEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_RegisterPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_RegisterUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowFormLogin = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.p_Login.SuspendLayout();
            this.p_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.AutoRoundedCorners = true;
            this.tb_Username.BackColor = System.Drawing.Color.Transparent;
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Username.DefaultText = "Username";
            this.tb_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Username.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_Username.IconLeft")));
            this.tb_Username.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_Username.Location = new System.Drawing.Point(56, 146);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PlaceholderText = "";
            this.tb_Username.SelectedText = "";
            this.tb_Username.Size = new System.Drawing.Size(313, 49);
            this.tb_Username.TabIndex = 2;
            this.tb_Username.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_Username.Enter += new System.EventHandler(this.tb_Username_Enter);
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // ElipseLogin
            // 
            this.ElipseLogin.BorderRadius = 20;
            this.ElipseLogin.TargetControl = this;
            // 
            // p_Login
            // 
            this.p_Login.Controls.Add(this.label2);
            this.p_Login.Controls.Add(this.ts_Remember);
            this.p_Login.Controls.Add(this.l_Register);
            this.p_Login.Controls.Add(this.label3);
            this.p_Login.Controls.Add(this.label1);
            this.p_Login.Controls.Add(this.b_Login);
            this.p_Login.Controls.Add(this.tb_Password);
            this.p_Login.Controls.Add(this.tb_Username);
            this.p_Login.Location = new System.Drawing.Point(0, 0);
            this.p_Login.Margin = new System.Windows.Forms.Padding(4);
            this.p_Login.Name = "p_Login";
            this.p_Login.Size = new System.Drawing.Size(429, 554);
            this.p_Login.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remember Me";
            // 
            // ts_Remember
            // 
            this.ts_Remember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_Remember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ts_Remember.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_Remember.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ts_Remember.Location = new System.Drawing.Point(56, 330);
            this.ts_Remember.Margin = new System.Windows.Forms.Padding(4);
            this.ts_Remember.Name = "ts_Remember";
            this.ts_Remember.Size = new System.Drawing.Size(47, 25);
            this.ts_Remember.TabIndex = 9;
            this.ts_Remember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_Remember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ts_Remember.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ts_Remember.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // l_Register
            // 
            this.l_Register.AutoSize = true;
            this.l_Register.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.l_Register.Location = new System.Drawing.Point(257, 479);
            this.l_Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Register.Name = "l_Register";
            this.l_Register.Size = new System.Drawing.Size(70, 17);
            this.l_Register.TabIndex = 8;
            this.l_Register.Text = "Register";
            this.l_Register.Click += new System.EventHandler(this.l_Register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.label3.Location = new System.Drawing.Point(87, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t have a account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // b_Login
            // 
            this.b_Login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_Login.Animated = true;
            this.b_Login.AutoRoundedCorners = true;
            this.b_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.b_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.b_Login.ForeColor = System.Drawing.Color.White;
            this.b_Login.Location = new System.Drawing.Point(53, 396);
            this.b_Login.Margin = new System.Windows.Forms.Padding(4);
            this.b_Login.Name = "b_Login";
            this.b_Login.PressedColor = System.Drawing.Color.Empty;
            this.b_Login.Size = new System.Drawing.Size(313, 49);
            this.b_Login.TabIndex = 4;
            this.b_Login.Text = "LOGIN";
            this.b_Login.Click += new System.EventHandler(this.b_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.AutoRoundedCorners = true;
            this.tb_Password.BackColor = System.Drawing.Color.Transparent;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.DefaultText = "Password";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_Password.IconLeft")));
            this.tb_Password.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_Password.Location = new System.Drawing.Point(56, 239);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PlaceholderText = "";
            this.tb_Password.SelectedText = "";
            this.tb_Password.Size = new System.Drawing.Size(313, 49);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_Password.Enter += new System.EventHandler(this.tb_Password_Enter);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // p_Register
            // 
            this.p_Register.Controls.Add(this.l_Login);
            this.p_Register.Controls.Add(this.label7);
            this.p_Register.Controls.Add(this.label8);
            this.p_Register.Controls.Add(this.b_Register);
            this.p_Register.Controls.Add(this.tb_RegisterConfirmPassword);
            this.p_Register.Controls.Add(this.tb_RegisterEmail);
            this.p_Register.Controls.Add(this.tb_RegisterPassword);
            this.p_Register.Controls.Add(this.tb_RegisterUsername);
            this.p_Register.Location = new System.Drawing.Point(0, 0);
            this.p_Register.Margin = new System.Windows.Forms.Padding(4);
            this.p_Register.Name = "p_Register";
            this.p_Register.Size = new System.Drawing.Size(432, 554);
            this.p_Register.TabIndex = 11;
            this.p_Register.Visible = false;
            // 
            // l_Login
            // 
            this.l_Login.AutoSize = true;
            this.l_Login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.l_Login.Location = new System.Drawing.Point(284, 479);
            this.l_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Login.Name = "l_Login";
            this.l_Login.Size = new System.Drawing.Size(48, 17);
            this.l_Login.TabIndex = 8;
            this.l_Login.Text = "Login";
            this.l_Login.Click += new System.EventHandler(this.l_Login_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.label7.Location = new System.Drawing.Point(88, 479);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "I already have an account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 46);
            this.label8.TabIndex = 1;
            this.label8.Text = "Register";
            // 
            // b_Register
            // 
            this.b_Register.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.b_Register.Animated = true;
            this.b_Register.AutoRoundedCorners = true;
            this.b_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Register.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.b_Register.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.b_Register.ForeColor = System.Drawing.Color.White;
            this.b_Register.Location = new System.Drawing.Point(56, 396);
            this.b_Register.Margin = new System.Windows.Forms.Padding(4);
            this.b_Register.Name = "b_Register";
            this.b_Register.PressedColor = System.Drawing.Color.Empty;
            this.b_Register.Size = new System.Drawing.Size(313, 49);
            this.b_Register.TabIndex = 4;
            this.b_Register.Text = "REGISTER";
            this.b_Register.Click += new System.EventHandler(this.b_Register_Click);
            // 
            // tb_RegisterConfirmPassword
            // 
            this.tb_RegisterConfirmPassword.AutoRoundedCorners = true;
            this.tb_RegisterConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.tb_RegisterConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RegisterConfirmPassword.DefaultText = "Confirm Password";
            this.tb_RegisterConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_RegisterConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_RegisterConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_RegisterConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_RegisterConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterConfirmPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_RegisterConfirmPassword.IconLeft")));
            this.tb_RegisterConfirmPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_RegisterConfirmPassword.Location = new System.Drawing.Point(56, 316);
            this.tb_RegisterConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RegisterConfirmPassword.Name = "tb_RegisterConfirmPassword";
            this.tb_RegisterConfirmPassword.PlaceholderText = "";
            this.tb_RegisterConfirmPassword.SelectedText = "";
            this.tb_RegisterConfirmPassword.Size = new System.Drawing.Size(313, 49);
            this.tb_RegisterConfirmPassword.TabIndex = 3;
            this.tb_RegisterConfirmPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_RegisterConfirmPassword.Enter += new System.EventHandler(this.tb_RegisterConfirmPassword_Enter);
            this.tb_RegisterConfirmPassword.Leave += new System.EventHandler(this.tb_RegisterConfirmPassword_Leave);
            // 
            // tb_RegisterEmail
            // 
            this.tb_RegisterEmail.AutoRoundedCorners = true;
            this.tb_RegisterEmail.BackColor = System.Drawing.Color.Transparent;
            this.tb_RegisterEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RegisterEmail.DefaultText = "Email";
            this.tb_RegisterEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_RegisterEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_RegisterEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_RegisterEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_RegisterEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_RegisterEmail.IconLeft")));
            this.tb_RegisterEmail.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_RegisterEmail.Location = new System.Drawing.Point(56, 193);
            this.tb_RegisterEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RegisterEmail.Name = "tb_RegisterEmail";
            this.tb_RegisterEmail.PlaceholderText = "";
            this.tb_RegisterEmail.SelectedText = "";
            this.tb_RegisterEmail.Size = new System.Drawing.Size(313, 49);
            this.tb_RegisterEmail.TabIndex = 3;
            this.tb_RegisterEmail.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_RegisterEmail.Enter += new System.EventHandler(this.tb_RegisterEmail_Enter);
            this.tb_RegisterEmail.Leave += new System.EventHandler(this.tb_RegisterEmail_Leave);
            // 
            // tb_RegisterPassword
            // 
            this.tb_RegisterPassword.AutoRoundedCorners = true;
            this.tb_RegisterPassword.BackColor = System.Drawing.Color.Transparent;
            this.tb_RegisterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RegisterPassword.DefaultText = "Password";
            this.tb_RegisterPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_RegisterPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_RegisterPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_RegisterPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_RegisterPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_RegisterPassword.IconLeft")));
            this.tb_RegisterPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_RegisterPassword.Location = new System.Drawing.Point(56, 255);
            this.tb_RegisterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RegisterPassword.Name = "tb_RegisterPassword";
            this.tb_RegisterPassword.PlaceholderText = "";
            this.tb_RegisterPassword.SelectedText = "";
            this.tb_RegisterPassword.Size = new System.Drawing.Size(313, 49);
            this.tb_RegisterPassword.TabIndex = 3;
            this.tb_RegisterPassword.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_RegisterPassword.Enter += new System.EventHandler(this.tb_RegisterPassword_Enter);
            this.tb_RegisterPassword.Leave += new System.EventHandler(this.tb_RegisterPassword_Leave);
            // 
            // tb_RegisterUsername
            // 
            this.tb_RegisterUsername.AutoRoundedCorners = true;
            this.tb_RegisterUsername.BackColor = System.Drawing.Color.Transparent;
            this.tb_RegisterUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RegisterUsername.DefaultText = "Username";
            this.tb_RegisterUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_RegisterUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_RegisterUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RegisterUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_RegisterUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_RegisterUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RegisterUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("tb_RegisterUsername.IconLeft")));
            this.tb_RegisterUsername.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tb_RegisterUsername.Location = new System.Drawing.Point(56, 132);
            this.tb_RegisterUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RegisterUsername.Name = "tb_RegisterUsername";
            this.tb_RegisterUsername.PlaceholderText = "";
            this.tb_RegisterUsername.SelectedText = "";
            this.tb_RegisterUsername.Size = new System.Drawing.Size(313, 49);
            this.tb_RegisterUsername.TabIndex = 2;
            this.tb_RegisterUsername.TextOffset = new System.Drawing.Point(10, 0);
            this.tb_RegisterUsername.Enter += new System.EventHandler(this.tb_RegisterUsername_Enter);
            this.tb_RegisterUsername.Leave += new System.EventHandler(this.tb_RegisterUsername_Leave);
            // 
            // ShadowFormLogin
            // 
            this.ShadowFormLogin.TargetForm = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 554);
            this.Controls.Add(this.p_Register);
            this.Controls.Add(this.p_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.p_Login.ResumeLayout(false);
            this.p_Login.PerformLayout();
            this.p_Register.ResumeLayout(false);
            this.p_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tb_Username;
        private Guna.UI2.WinForms.Guna2Elipse ElipseLogin;
        private Guna.UI2.WinForms.Guna2Panel p_Login;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2GradientButton b_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ts_Remember;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowFormLogin;
        private System.Windows.Forms.Label l_Register;
        private Guna.UI2.WinForms.Guna2Panel p_Register;
        private System.Windows.Forms.Label l_Login;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton b_Register;
        private Guna.UI2.WinForms.Guna2TextBox tb_RegisterConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_RegisterEmail;
        private Guna.UI2.WinForms.Guna2TextBox tb_RegisterPassword;
        private Guna.UI2.WinForms.Guna2TextBox tb_RegisterUsername;
    }
}

