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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.p_Bar.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            this.lb_Users.ItemHeight = 20;
            this.lb_Users.Location = new System.Drawing.Point(0, 0);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(200, 523);
            this.lb_Users.TabIndex = 0;
            this.lb_Users.SelectedIndexChanged += new System.EventHandler(this.lb_Users_SelectedIndexChanged);
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
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
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
            this.lb_Mensage.ItemHeight = 25;
            this.lb_Mensage.Location = new System.Drawing.Point(21, 9);
            this.lb_Mensage.Name = "lb_Mensage";
            this.lb_Mensage.Size = new System.Drawing.Size(506, 429);
            this.lb_Mensage.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(497, 462);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(21, 460);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Escreve aqui";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(465, 36);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(547, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(253, 523);
            this.guna2Panel4.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
    }
}