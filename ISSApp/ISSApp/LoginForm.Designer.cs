namespace ISSApp
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
            this.Fade = new System.Windows.Forms.Timer(this.components);
            this.TxtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.DropdownAS = new Bunifu.Framework.UI.BunifuDropdown();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.RememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fade
            // 
            this.Fade.Interval = 20;
            this.Fade.Tick += new System.EventHandler(this.Fade_Tick);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUsername.HintText = "";
            this.TxtUsername.isPassword = false;
            this.TxtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineThickness = 3;
            this.TxtUsername.Location = new System.Drawing.Point(25, 119);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(251, 27);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Maiandra GD", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 7);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 36);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Login";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(22, 54);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(261, 14);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Don\'t have an account? Create one right now, it only";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(22, 69);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 14);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "takes a minute!";
            // 
            // LblCreateAcc
            // 
            this.LblCreateAcc.AutoSize = true;
            this.LblCreateAcc.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAcc.Location = new System.Drawing.Point(104, 68);
            this.LblCreateAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreateAcc.Name = "LblCreateAcc";
            this.LblCreateAcc.Size = new System.Drawing.Size(95, 14);
            this.LblCreateAcc.TabIndex = 0;
            this.LblCreateAcc.TabStop = true;
            this.LblCreateAcc.Text = "Create an account!";
            this.LblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreateAcc_LinkClicked);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineThickness = 3;
            this.TxtPassword.Location = new System.Drawing.Point(25, 188);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(251, 27);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(274, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(21, 352);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(196, 273);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(80, 33);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            this.BtnLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnLogin_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.RememberMe);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.DropdownAS);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.LblCreateAcc);
            this.panel1.Location = new System.Drawing.Point(298, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 317);
            this.panel1.TabIndex = 14;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DarkRed;
            this.Label1.Location = new System.Drawing.Point(22, 241);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 14);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Login as:";
            // 
            // DropdownAS
            // 
            this.DropdownAS.BackColor = System.Drawing.Color.Transparent;
            this.DropdownAS.BorderRadius = 3;
            this.DropdownAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DropdownAS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropdownAS.DisabledColor = System.Drawing.Color.Gray;
            this.DropdownAS.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownAS.ForeColor = System.Drawing.Color.DarkRed;
            this.DropdownAS.Items = new string[] {
        "Choose option...",
        "Admin",
        "Doctor",
        "Angajat centru recoltare",
        "Donator"};
            this.DropdownAS.Location = new System.Drawing.Point(81, 236);
            this.DropdownAS.Name = "DropdownAS";
            this.DropdownAS.NomalColor = System.Drawing.Color.White;
            this.DropdownAS.onHoverColor = System.Drawing.Color.White;
            this.DropdownAS.selectedIndex = 0;
            this.DropdownAS.Size = new System.Drawing.Size(196, 24);
            this.DropdownAS.TabIndex = 12;
            this.DropdownAS.onItemSelected += new System.EventHandler(this.DropdownAS_onItemSelected);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::ISSApp.Properties.Resources.minimize;
            this.PictureBox3.Location = new System.Drawing.Point(562, 8);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(15, 18);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 13;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::ISSApp.Properties.Resources.exitBtn;
            this.PictureBox2.Location = new System.Drawing.Point(586, 10);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(19, 20);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ISSApp.Properties.Resources.bloodBackground;
            this.PictureBox1.Location = new System.Drawing.Point(-1, 11);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(270, 327);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // RememberMe
            // 
            this.RememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberMe.Checked = false;
            this.RememberMe.CheckedOnColor = System.Drawing.Color.DarkRed;
            this.RememberMe.ForeColor = System.Drawing.Color.White;
            this.RememberMe.Location = new System.Drawing.Point(25, 281);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(20, 20);
            this.RememberMe.TabIndex = 3;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.DarkRed;
            this.Label5.Location = new System.Drawing.Point(49, 284);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(81, 13);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Remember me?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Fade;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel Label2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel Label3;
        private Bunifu.Framework.UI.BunifuCustomLabel Label4;
        private System.Windows.Forms.LinkLabel LblCreateAcc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown DropdownAS;
        private System.Windows.Forms.Label Label1;
        private Bunifu.Framework.UI.BunifuCheckbox RememberMe;
        private System.Windows.Forms.Label Label5;
    }
}

