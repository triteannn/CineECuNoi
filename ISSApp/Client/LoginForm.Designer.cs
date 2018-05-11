namespace Client
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
            this.LblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.swfLogin = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.Label5 = new System.Windows.Forms.Label();
            this.RememberMe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Label1 = new System.Windows.Forms.Label();
            this.DropdownAS = new Bunifu.Framework.UI.BunifuDropdown();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swfLogin)).BeginInit();
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
            this.TxtUsername.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUsername.HintText = "";
            this.TxtUsername.isPassword = false;
            this.TxtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtUsername.LineThickness = 3;
            this.TxtUsername.Location = new System.Drawing.Point(33, 146);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(335, 33);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // LblCreateAcc
            // 
            this.LblCreateAcc.AutoSize = true;
            this.LblCreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.LblCreateAcc.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCreateAcc.Location = new System.Drawing.Point(125, 84);
            this.LblCreateAcc.Margin = new System.Windows.Forms.Padding(0);
            this.LblCreateAcc.Name = "LblCreateAcc";
            this.LblCreateAcc.Size = new System.Drawing.Size(125, 17);
            this.LblCreateAcc.TabIndex = 0;
            this.LblCreateAcc.TabStop = true;
            this.LblCreateAcc.Text = "Create an account!";
            this.LblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCreateAcc_LinkClicked);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineThickness = 3;
            this.TxtPassword.Location = new System.Drawing.Point(33, 231);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(335, 33);
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(365, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(28, 433);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(261, 336);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(107, 41);
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
            this.panel1.Controls.Add(this.swfLogin);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.RememberMe);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.DropdownAS);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.LblCreateAcc);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Location = new System.Drawing.Point(397, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 390);
            this.panel1.TabIndex = 14;
            // 
            // swfLogin
            // 
            this.swfLogin.Enabled = true;
            this.swfLogin.Location = new System.Drawing.Point(28, 3);
            this.swfLogin.MaximumSize = new System.Drawing.Size(240, 62);
            this.swfLogin.MinimumSize = new System.Drawing.Size(240, 62);
            this.swfLogin.Name = "swfLogin";
            this.swfLogin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("swfLogin.OcxState")));
            this.swfLogin.Size = new System.Drawing.Size(240, 62);
            this.swfLogin.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(65, 350);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 17);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Remember me?";
            // 
            // RememberMe
            // 
            this.RememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberMe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.RememberMe.Checked = false;
            this.RememberMe.CheckedOnColor = System.Drawing.Color.DarkRed;
            this.RememberMe.ForeColor = System.Drawing.Color.White;
            this.RememberMe.Location = new System.Drawing.Point(33, 346);
            this.RememberMe.Margin = new System.Windows.Forms.Padding(5);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(20, 20);
            this.RememberMe.TabIndex = 3;
            this.RememberMe.OnChange += new System.EventHandler(this.RememberMe_OnChange);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DarkRed;
            this.Label1.Location = new System.Drawing.Point(29, 297);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 17);
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
            this.DropdownAS.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropdownAS.ForeColor = System.Drawing.Color.DarkRed;
            this.DropdownAS.Items = new string[] {
        "Choose option...",
        "Admin",
        "Doctor",
        "Angajat centru recoltare",
        "Donator"};
            this.DropdownAS.Location = new System.Drawing.Point(108, 290);
            this.DropdownAS.Margin = new System.Windows.Forms.Padding(5);
            this.DropdownAS.Name = "DropdownAS";
            this.DropdownAS.NomalColor = System.Drawing.Color.White;
            this.DropdownAS.onHoverColor = System.Drawing.Color.White;
            this.DropdownAS.selectedIndex = 0;
            this.DropdownAS.Size = new System.Drawing.Size(261, 29);
            this.DropdownAS.TabIndex = 12;
            this.DropdownAS.onItemSelected += new System.EventHandler(this.DropdownAS_onItemSelected);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(29, 68);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(332, 17);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Don\'t have an account? Create one right now, it only";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(30, 84);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 17);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "takes a minute!";
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::ISSApp.Properties.Resources.minimize;
            this.PictureBox3.Location = new System.Drawing.Point(724, 9);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 13;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::ISSApp.Properties.Resources.exitBtn;
            this.PictureBox2.Location = new System.Drawing.Point(756, 11);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(25, 25);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::ISSApp.Properties.Resources.bloodBackground;
            this.PictureBox1.Location = new System.Drawing.Point(-1, 14);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(360, 402);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(792, 433);
            this.MinimumSize = new System.Drawing.Size(792, 433);
            this.Name = "LoginForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Donation - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swfLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Fade;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUsername;
        private System.Windows.Forms.PictureBox PictureBox1;
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
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private AxShockwaveFlashObjects.AxShockwaveFlash swfLogin;
    }
}

