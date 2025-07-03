namespace iChat.views
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.ElipseChat = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.b_User = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_Users = new System.Windows.Forms.ListBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.p_Bar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_Mensage = new System.Windows.Forms.ListBox();
            this.b_send = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tb_Message = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Id = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.p_Bar.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_send)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseChat
            // 
            this.ElipseChat.BorderRadius = 20;
            this.ElipseChat.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Controls.Add(this.b_User);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 32);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 45);
            this.guna2Panel1.TabIndex = 2;
            // 
            // b_User
            // 
            this.b_User.AutoRoundedCorners = true;
            this.b_User.BackColor = System.Drawing.Color.Transparent;
            this.b_User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_User.FillColor = System.Drawing.Color.Transparent;
            this.b_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_User.ForeColor = System.Drawing.Color.White;
            this.b_User.Image = ((System.Drawing.Image)(resources.GetObject("b_User.Image")));
            this.b_User.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.b_User.ImageOffset = new System.Drawing.Point(10, 0);
            this.b_User.Location = new System.Drawing.Point(747, 3);
            this.b_User.Name = "b_User";
            this.b_User.Size = new System.Drawing.Size(253, 39);
            this.b_User.TabIndex = 0;
            this.b_User.Text = "Username";
            this.b_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.b_User.TextOffset = new System.Drawing.Point(-10, 0);
            this.b_User.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.lb_Users);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 77);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 523);
            this.guna2Panel2.TabIndex = 3;
            // 
            // lb_Users
            // 
            this.lb_Users.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Users.FormattingEnabled = true;
            this.lb_Users.ItemHeight = 25;
            this.lb_Users.Location = new System.Drawing.Point(0, 0);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(200, 523);
            this.lb_Users.TabIndex = 0;
            this.lb_Users.DoubleClick += new System.EventHandler(this.lb_Users_DoubleClick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(971, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(945, 7);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.ForeColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(919, 7);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // p_Bar
            // 
            this.p_Bar.BackColor = System.Drawing.Color.Black;
            this.p_Bar.Controls.Add(this.guna2ControlBox3);
            this.p_Bar.Controls.Add(this.guna2ControlBox2);
            this.p_Bar.Controls.Add(this.guna2ControlBox1);
            this.p_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Bar.Location = new System.Drawing.Point(0, 0);
            this.p_Bar.Name = "p_Bar";
            this.p_Bar.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.p_Bar.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.p_Bar.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.p_Bar.ShadowDecoration.Enabled = true;
            this.p_Bar.Size = new System.Drawing.Size(1000, 32);
            this.p_Bar.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.lb_Mensage);
            this.guna2Panel3.Controls.Add(this.b_send);
            this.guna2Panel3.Controls.Add(this.tb_Message);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(200, 77);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(800, 523);
            this.guna2Panel3.TabIndex = 5;
            // 
            // lb_Mensage
            // 
            this.lb_Mensage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Mensage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mensage.FormattingEnabled = true;
            this.lb_Mensage.ItemHeight = 29;
            this.lb_Mensage.Location = new System.Drawing.Point(21, 9);
            this.lb_Mensage.Name = "lb_Mensage";
            this.lb_Mensage.Size = new System.Drawing.Size(506, 410);
            this.lb_Mensage.TabIndex = 2;
            // 
            // b_send
            // 
            this.b_send.BackColor = System.Drawing.Color.Transparent;
            this.b_send.FillColor = System.Drawing.Color.Transparent;
            this.b_send.Image = ((System.Drawing.Image)(resources.GetObject("b_send.Image")));
            this.b_send.ImageRotate = 0F;
            this.b_send.Location = new System.Drawing.Point(497, 462);
            this.b_send.Name = "b_send";
            this.b_send.Size = new System.Drawing.Size(30, 30);
            this.b_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_send.TabIndex = 1;
            this.b_send.TabStop = false;
            this.b_send.UseTransparentBackground = true;
            this.b_send.Click += new System.EventHandler(this.b_send_Click);
            // 
            // tb_Message
            // 
            this.tb_Message.AutoRoundedCorners = true;
            this.tb_Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Message.DefaultText = "";
            this.tb_Message.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Message.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Message.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Message.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Message.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Message.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Message.Location = new System.Drawing.Point(21, 460);
            this.tb_Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.PlaceholderText = "Escreve aqui";
            this.tb_Message.SelectedText = "";
            this.tb_Message.Size = new System.Drawing.Size(465, 36);
            this.tb_Message.TabIndex = 0;
            this.tb_Message.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Controls.Add(this.tb_Email);
            this.guna2Panel4.Controls.Add(this.tb_Id);
            this.guna2Panel4.Controls.Add(this.tb_Name);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(547, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(253, 523);
            this.guna2Panel4.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.AutoRoundedCorners = true;
            this.tb_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Email.DefaultText = "EMAIL";
            this.tb_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.Enabled = false;
            this.tb_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Location = new System.Drawing.Point(16, 124);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.PlaceholderText = "";
            this.tb_Email.SelectedText = "";
            this.tb_Email.Size = new System.Drawing.Size(224, 39);
            this.tb_Email.TabIndex = 1;
            this.tb_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Email.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tb_Id
            // 
            this.tb_Id.AutoRoundedCorners = true;
            this.tb_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Id.DefaultText = "ID";
            this.tb_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Id.Enabled = false;
            this.tb_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Id.Location = new System.Drawing.Point(186, 33);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.PlaceholderText = "";
            this.tb_Id.SelectedText = "";
            this.tb_Id.Size = new System.Drawing.Size(53, 39);
            this.tb_Id.TabIndex = 0;
            this.tb_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Id.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // tb_Name
            // 
            this.tb_Name.AutoRoundedCorners = true;
            this.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Name.DefaultText = "NOME";
            this.tb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Name.Enabled = false;
            this.tb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Name.Location = new System.Drawing.Point(16, 78);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PlaceholderText = "";
            this.tb_Name.SelectedText = "";
            this.tb_Name.Size = new System.Drawing.Size(224, 39);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Name.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.p_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.p_Bar.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.b_send)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseChat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button b_User;
        private Guna.UI2.WinForms.Guna2Panel p_Bar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ListBox lb_Users;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.ListBox lb_Mensage;
        private Guna.UI2.WinForms.Guna2PictureBox b_send;
        private Guna.UI2.WinForms.Guna2TextBox tb_Message;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox tb_Email;
        private Guna.UI2.WinForms.Guna2TextBox tb_Name;
        private Guna.UI2.WinForms.Guna2TextBox tb_Id;
    }
}