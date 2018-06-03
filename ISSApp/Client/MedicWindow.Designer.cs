﻿namespace Client
{
    partial class MedicWindow
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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicWindow));
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuToggle = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuButton2 = new System.Windows.Forms.Button();
            this.MenuButton1 = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.RequestsPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtSearchResult = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlatelets = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtErythrocytes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtPlasma = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPacient = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtBloodType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtRh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TxtHospital = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtDoctor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox3
            // 
            this.animator1.SetDecoration(this.PictureBox3, AnimatorNS.DecorationType.None);
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(906, 8);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(15, 18);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 16;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox2
            // 
            this.animator1.SetDecoration(this.PictureBox2, AnimatorNS.DecorationType.None);
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(926, 11);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(19, 20);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // MenuToggle
            // 
            this.animator1.SetDecoration(this.MenuToggle, AnimatorNS.DecorationType.None);
            this.MenuToggle.Image = global::Client.Properties.Resources.menuicon;
            this.MenuToggle.Location = new System.Drawing.Point(11, 52);
            this.MenuToggle.Margin = new System.Windows.Forms.Padding(2);
            this.MenuToggle.Name = "MenuToggle";
            this.MenuToggle.Size = new System.Drawing.Size(34, 36);
            this.MenuToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuToggle.TabIndex = 17;
            this.MenuToggle.TabStop = false;
            this.MenuToggle.Click += new System.EventHandler(this.MenuToggle_Click);
            this.MenuToggle.MouseHover += new System.EventHandler(this.MenuToggle_MouseHover);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuButton2);
            this.MenuPanel.Controls.Add(this.MenuButton1);
            this.animator1.SetDecoration(this.MenuPanel, AnimatorNS.DecorationType.None);
            this.MenuPanel.Location = new System.Drawing.Point(11, 92);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(213, 406);
            this.MenuPanel.TabIndex = 19;
            this.MenuPanel.Visible = false;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // MenuButton2
            // 
            this.MenuButton2.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.MenuButton2, AnimatorNS.DecorationType.None);
            this.MenuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton2.ForeColor = System.Drawing.Color.White;
            this.MenuButton2.Location = new System.Drawing.Point(4, 62);
            this.MenuButton2.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton2.Name = "MenuButton2";
            this.MenuButton2.Size = new System.Drawing.Size(198, 46);
            this.MenuButton2.TabIndex = 27;
            this.MenuButton2.Text = "View requests";
            this.MenuButton2.UseVisualStyleBackColor = false;
            this.MenuButton2.Click += new System.EventHandler(this.MenuButton2_Click);
            this.MenuButton2.MouseLeave += new System.EventHandler(this.MenuButton2_MouseLeave);
            this.MenuButton2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuButton2_MouseMove);
            // 
            // MenuButton1
            // 
            this.MenuButton1.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.MenuButton1, AnimatorNS.DecorationType.None);
            this.MenuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton1.ForeColor = System.Drawing.Color.White;
            this.MenuButton1.Location = new System.Drawing.Point(4, 4);
            this.MenuButton1.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton1.Name = "MenuButton1";
            this.MenuButton1.Size = new System.Drawing.Size(198, 46);
            this.MenuButton1.TabIndex = 27;
            this.MenuButton1.Text = "Request blood";
            this.MenuButton1.UseVisualStyleBackColor = false;
            this.MenuButton1.Click += new System.EventHandler(this.MenuButton1_Click);
            this.MenuButton1.MouseLeave += new System.EventHandler(this.MenuButton1_MouseLeave);
            this.MenuButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuButton1_MouseMove);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation3;
            // 
            // RequestsPanel
            // 
            this.RequestsPanel.BackColor = System.Drawing.Color.White;
            this.RequestsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.animator1.SetDecoration(this.RequestsPanel, AnimatorNS.DecorationType.None);
            this.RequestsPanel.Location = new System.Drawing.Point(11, 92);
            this.RequestsPanel.Name = "RequestsPanel";
            this.RequestsPanel.Size = new System.Drawing.Size(934, 406);
            this.RequestsPanel.TabIndex = 20;
            this.RequestsPanel.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.BtnSubmit);
            this.MainPanel.Controls.Add(this.groupBox3);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.bunifuSeparator1);
            this.MainPanel.Controls.Add(this.TxtHospital);
            this.MainPanel.Controls.Add(this.TxtDoctor);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label4);
            this.animator1.SetDecoration(this.MainPanel, AnimatorNS.DecorationType.None);
            this.MainPanel.Location = new System.Drawing.Point(11, 92);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(934, 406);
            this.MainPanel.TabIndex = 21;
            this.MainPanel.Visible = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnSubmit, AnimatorNS.DecorationType.None);
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(842, 359);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(85, 40);
            this.BtnSubmit.TabIndex = 47;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtSearchResult);
            this.groupBox3.Controls.Add(this.Radio2);
            this.groupBox3.Controls.Add(this.Radio1);
            this.groupBox3.Controls.Add(this.BtnSearch);
            this.animator1.SetDecoration(this.groupBox3, AnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(5, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 121);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search transfusion center";
            // 
            // TxtSearchResult
            // 
            this.TxtSearchResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtSearchResult, AnimatorNS.DecorationType.None);
            this.TxtSearchResult.Enabled = false;
            this.TxtSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSearchResult.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSearchResult.HintText = "Result";
            this.TxtSearchResult.isPassword = false;
            this.TxtSearchResult.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtSearchResult.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtSearchResult.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtSearchResult.LineThickness = 2;
            this.TxtSearchResult.Location = new System.Drawing.Point(108, 84);
            this.TxtSearchResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearchResult.Name = "TxtSearchResult";
            this.TxtSearchResult.Size = new System.Drawing.Size(217, 29);
            this.TxtSearchResult.TabIndex = 31;
            this.TxtSearchResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.animator1.SetDecoration(this.Radio2, AnimatorNS.DecorationType.None);
            this.Radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio2.Location = new System.Drawing.Point(7, 55);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(291, 20);
            this.Radio2.TabIndex = 46;
            this.Radio2.TabStop = true;
            this.Radio2.Text = "Nearest center with available blood products";
            this.Radio2.UseVisualStyleBackColor = true;
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.animator1.SetDecoration(this.Radio1, AnimatorNS.DecorationType.None);
            this.Radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio1.Location = new System.Drawing.Point(7, 26);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(255, 20);
            this.Radio1.TabIndex = 45;
            this.Radio1.TabStop = true;
            this.Radio1.Text = "With a donation for this specific pacient";
            this.Radio1.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnSearch, AnimatorNS.DecorationType.None);
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(9, 84);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 31);
            this.BtnSearch.TabIndex = 44;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtPlatelets);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtErythrocytes);
            this.groupBox2.Controls.Add(this.TxtPlasma);
            this.groupBox2.Controls.Add(this.label7);
            this.animator1.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(622, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 245);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blood products:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Platelets quantity:";
            // 
            // TxtPlatelets
            // 
            this.TxtPlatelets.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtPlatelets, AnimatorNS.DecorationType.None);
            this.TxtPlatelets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlatelets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPlatelets.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPlatelets.HintText = "";
            this.TxtPlatelets.isPassword = false;
            this.TxtPlatelets.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtPlatelets.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtPlatelets.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtPlatelets.LineThickness = 2;
            this.TxtPlatelets.Location = new System.Drawing.Point(168, 46);
            this.TxtPlatelets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPlatelets.Name = "TxtPlatelets";
            this.TxtPlatelets.Size = new System.Drawing.Size(98, 29);
            this.TxtPlatelets.TabIndex = 32;
            this.TxtPlatelets.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.animator1.SetDecoration(this.label6, AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(47, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Plasma quantity:";
            // 
            // TxtErythrocytes
            // 
            this.TxtErythrocytes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtErythrocytes, AnimatorNS.DecorationType.None);
            this.TxtErythrocytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtErythrocytes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtErythrocytes.HintForeColor = System.Drawing.Color.Empty;
            this.TxtErythrocytes.HintText = "";
            this.TxtErythrocytes.isPassword = false;
            this.TxtErythrocytes.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtErythrocytes.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtErythrocytes.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtErythrocytes.LineThickness = 2;
            this.TxtErythrocytes.Location = new System.Drawing.Point(168, 181);
            this.TxtErythrocytes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtErythrocytes.Name = "TxtErythrocytes";
            this.TxtErythrocytes.Size = new System.Drawing.Size(98, 29);
            this.TxtErythrocytes.TabIndex = 36;
            this.TxtErythrocytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtPlasma
            // 
            this.TxtPlasma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtPlasma, AnimatorNS.DecorationType.None);
            this.TxtPlasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlasma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPlasma.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPlasma.HintText = "";
            this.TxtPlasma.isPassword = false;
            this.TxtPlasma.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtPlasma.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtPlasma.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtPlasma.LineThickness = 2;
            this.TxtPlasma.Location = new System.Drawing.Point(168, 113);
            this.TxtPlasma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPlasma.Name = "TxtPlasma";
            this.TxtPlasma.Size = new System.Drawing.Size(98, 29);
            this.TxtPlasma.TabIndex = 34;
            this.TxtPlasma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.animator1.SetDecoration(this.label7, AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(14, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Erythrocytes quantity:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPacient);
            this.groupBox1.Controls.Add(this.TxtBloodType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtRh);
            this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(291, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 245);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(24, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name:";
            // 
            // TxtPacient
            // 
            this.TxtPacient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtPacient, AnimatorNS.DecorationType.None);
            this.TxtPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPacient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPacient.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPacient.HintText = "";
            this.TxtPacient.isPassword = false;
            this.TxtPacient.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtPacient.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtPacient.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtPacient.LineThickness = 2;
            this.TxtPacient.Location = new System.Drawing.Point(27, 66);
            this.TxtPacient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPacient.Name = "TxtPacient";
            this.TxtPacient.Size = new System.Drawing.Size(217, 29);
            this.TxtPacient.TabIndex = 30;
            this.TxtPacient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtBloodType
            // 
            this.TxtBloodType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtBloodType, AnimatorNS.DecorationType.None);
            this.TxtBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBloodType.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBloodType.HintText = "";
            this.TxtBloodType.isPassword = false;
            this.TxtBloodType.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType.LineThickness = 2;
            this.TxtBloodType.Location = new System.Drawing.Point(27, 133);
            this.TxtBloodType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBloodType.Name = "TxtBloodType";
            this.TxtBloodType.Size = new System.Drawing.Size(217, 29);
            this.TxtBloodType.TabIndex = 40;
            this.TxtBloodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.animator1.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(24, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Rh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.animator1.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(24, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Blood type:";
            // 
            // TxtRh
            // 
            this.TxtRh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtRh, AnimatorNS.DecorationType.None);
            this.TxtRh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRh.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRh.HintText = "";
            this.TxtRh.isPassword = false;
            this.TxtRh.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtRh.LineIdleColor = System.Drawing.Color.DarkRed;
            this.TxtRh.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtRh.LineThickness = 2;
            this.TxtRh.Location = new System.Drawing.Point(27, 201);
            this.TxtRh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtRh.Name = "TxtRh";
            this.TxtRh.Size = new System.Drawing.Size(217, 29);
            this.TxtRh.TabIndex = 38;
            this.TxtRh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 254);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(924, 35);
            this.bunifuSeparator1.TabIndex = 41;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // TxtHospital
            // 
            this.TxtHospital.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtHospital, AnimatorNS.DecorationType.None);
            this.TxtHospital.Enabled = false;
            this.TxtHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHospital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtHospital.HintForeColor = System.Drawing.Color.Empty;
            this.TxtHospital.HintText = "";
            this.TxtHospital.isPassword = false;
            this.TxtHospital.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtHospital.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtHospital.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtHospital.LineThickness = 2;
            this.TxtHospital.Location = new System.Drawing.Point(26, 110);
            this.TxtHospital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtHospital.Name = "TxtHospital";
            this.TxtHospital.Size = new System.Drawing.Size(217, 29);
            this.TxtHospital.TabIndex = 28;
            this.TxtHospital.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtDoctor, AnimatorNS.DecorationType.None);
            this.TxtDoctor.Enabled = false;
            this.TxtDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDoctor.HintForeColor = System.Drawing.Color.Empty;
            this.TxtDoctor.HintText = "";
            this.TxtDoctor.isPassword = false;
            this.TxtDoctor.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtDoctor.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtDoctor.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtDoctor.LineThickness = 2;
            this.TxtDoctor.Location = new System.Drawing.Point(26, 43);
            this.TxtDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(217, 29);
            this.TxtDoctor.TabIndex = 27;
            this.TxtDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // MedicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 509);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RequestsPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MenuToggle);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MedicWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medic Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicWindow_FormClosing);
            this.Load += new System.EventHandler(this.MedicWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MedicWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox MenuToggle;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button MenuButton2;
        private System.Windows.Forms.Button MenuButton1;
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.Panel RequestsPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtHospital;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBloodType;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRh;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtErythrocytes;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPlasma;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPlatelets;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPacient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSearchResult;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.RadioButton Radio1;
    }
}