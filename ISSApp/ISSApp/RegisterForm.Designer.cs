namespace ISSApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCnp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.swfRegister = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Rh = new Bunifu.Framework.UI.BunifuDropdown();
            this.BloodType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.LinkLabel();
            this.DOB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swfRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCnp);
            this.panel1.Controls.Add(this.TxtLastName);
            this.panel1.Controls.Add(this.swfRegister);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Rh);
            this.panel1.Controls.Add(this.BloodType);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.LblLogin);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.TxtUsername);
            this.panel1.Controls.Add(this.TxtFirstName);
            this.panel1.Controls.Add(this.BtnRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 706);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // TxtCnp
            // 
            this.TxtCnp.BackColor = System.Drawing.Color.White;
            this.TxtCnp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCnp.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCnp.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCnp.HintText = "";
            this.TxtCnp.isPassword = false;
            this.TxtCnp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtCnp.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtCnp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtCnp.LineThickness = 3;
            this.TxtCnp.Location = new System.Drawing.Point(19, 144);
            this.TxtCnp.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCnp.Name = "TxtCnp";
            this.TxtCnp.Size = new System.Drawing.Size(356, 33);
            this.TxtCnp.TabIndex = 1;
            this.TxtCnp.Text = "CNP";
            this.TxtCnp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCnp.Enter += new System.EventHandler(this.TxtCnp_Enter);
            this.TxtCnp.Leave += new System.EventHandler(this.TxtCnp_Leave);
            // 
            // TxtLastName
            // 
            this.TxtLastName.BackColor = System.Drawing.Color.White;
            this.TxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtLastName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtLastName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtLastName.HintText = "";
            this.TxtLastName.isPassword = false;
            this.TxtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtLastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtLastName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtLastName.LineThickness = 3;
            this.TxtLastName.Location = new System.Drawing.Point(20, 256);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(356, 33);
            this.TxtLastName.TabIndex = 3;
            this.TxtLastName.Text = "Last name";
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLastName.Enter += new System.EventHandler(this.TxtLastName_Enter);
            this.TxtLastName.Leave += new System.EventHandler(this.TxtLastName_Leave);
            // 
            // swfRegister
            // 
            this.swfRegister.Enabled = true;
            this.swfRegister.Location = new System.Drawing.Point(22, 12);
            this.swfRegister.MaximumSize = new System.Drawing.Size(266, 66);
            this.swfRegister.MinimumSize = new System.Drawing.Size(266, 66);
            this.swfRegister.Name = "swfRegister";
            this.swfRegister.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("swfRegister.OcxState")));
            this.swfRegister.Size = new System.Drawing.Size(266, 66);
            this.swfRegister.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Already have an account created? Click";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(18, 616);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(357, 21);
            this.bunifuSeparator2.TabIndex = 28;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.DarkRed;
            this.Label8.Location = new System.Drawing.Point(24, 585);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(81, 17);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "(optional)";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.DarkRed;
            this.Label7.Location = new System.Drawing.Point(24, 536);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(81, 17);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "(optional)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DarkRed;
            this.Label6.Location = new System.Drawing.Point(72, 567);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(34, 17);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "Rh:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DarkRed;
            this.Label5.Location = new System.Drawing.Point(20, 516);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(91, 17);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Blood type:";
            // 
            // Rh
            // 
            this.Rh.BackColor = System.Drawing.Color.Transparent;
            this.Rh.BorderRadius = 3;
            this.Rh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rh.DisabledColor = System.Drawing.Color.Gray;
            this.Rh.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rh.ForeColor = System.Drawing.Color.DarkRed;
            this.Rh.Items = new string[] {
        "Choose option...",
        "Positive",
        "Negative"};
            this.Rh.Location = new System.Drawing.Point(122, 562);
            this.Rh.Margin = new System.Windows.Forms.Padding(5);
            this.Rh.Name = "Rh";
            this.Rh.NomalColor = System.Drawing.Color.White;
            this.Rh.onHoverColor = System.Drawing.Color.White;
            this.Rh.selectedIndex = 0;
            this.Rh.Size = new System.Drawing.Size(254, 43);
            this.Rh.TabIndex = 12;
            // 
            // BloodType
            // 
            this.BloodType.BackColor = System.Drawing.Color.Transparent;
            this.BloodType.BorderRadius = 3;
            this.BloodType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BloodType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BloodType.DisabledColor = System.Drawing.Color.Gray;
            this.BloodType.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodType.ForeColor = System.Drawing.Color.DarkRed;
            this.BloodType.Items = new string[] {
        "Choose option...",
        "0",
        "A",
        "B",
        "AB"};
            this.BloodType.Location = new System.Drawing.Point(122, 512);
            this.BloodType.Margin = new System.Windows.Forms.Padding(5);
            this.BloodType.Name = "BloodType";
            this.BloodType.NomalColor = System.Drawing.Color.White;
            this.BloodType.onHoverColor = System.Drawing.Color.White;
            this.BloodType.selectedIndex = 0;
            this.BloodType.Size = new System.Drawing.Size(254, 43);
            this.BloodType.TabIndex = 11;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 484);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(357, 21);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DarkRed;
            this.Label4.Location = new System.Drawing.Point(20, 457);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 17);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "birth:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DarkRed;
            this.Label3.Location = new System.Drawing.Point(20, 440);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(23, 17);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "of";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DarkRed;
            this.Label2.Location = new System.Drawing.Point(20, 422);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 17);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Date";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLogin.Location = new System.Drawing.Point(253, 100);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(36, 17);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.TabStop = true;
            this.LblLogin.Text = "here";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLogin_LinkClicked);
            // 
            // DOB
            // 
            this.DOB.BackColor = System.Drawing.Color.DarkRed;
            this.DOB.BorderRadius = 0;
            this.DOB.ForeColor = System.Drawing.Color.White;
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOB.FormatCustom = null;
            this.DOB.Location = new System.Drawing.Point(72, 424);
            this.DOB.Margin = new System.Windows.Forms.Padding(5);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(304, 50);
            this.DOB.TabIndex = 10;
            this.DOB.Value = new System.DateTime(2018, 3, 22, 22, 34, 40, 474);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.White;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.HintText = "";
            this.TxtPassword.isPassword = false;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPassword.LineThickness = 3;
            this.TxtPassword.Location = new System.Drawing.Point(20, 368);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(356, 33);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.Text = "Password";
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.White;
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
            this.TxtUsername.Location = new System.Drawing.Point(20, 312);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(356, 33);
            this.TxtUsername.TabIndex = 4;
            this.TxtUsername.Text = "Username";
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.BackColor = System.Drawing.Color.White;
            this.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFirstName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtFirstName.HintText = "";
            this.TxtFirstName.isPassword = false;
            this.TxtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtFirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtFirstName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtFirstName.LineThickness = 3;
            this.TxtFirstName.Location = new System.Drawing.Point(20, 201);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(356, 33);
            this.TxtFirstName.TabIndex = 2;
            this.TxtFirstName.Text = "First name";
            this.TxtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFirstName.Enter += new System.EventHandler(this.TxtFirstName_Enter);
            this.TxtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            this.TxtFirstName.Leave += new System.EventHandler(this.TxtFirstName_Leave);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkRed;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(256, 645);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(120, 50);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.BtnRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Controls_KeyDown);
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 706);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Donation - Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swfRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.LinkLabel LblLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFirstName;
        private Bunifu.Framework.UI.BunifuDatepicker DOB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUsername;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private Bunifu.Framework.UI.BunifuDropdown Rh;
        private Bunifu.Framework.UI.BunifuDropdown BloodType;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label9;
        private AxShockwaveFlashObjects.AxShockwaveFlash swfRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCnp;
    }
}