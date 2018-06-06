namespace Client
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicWindow));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuButton2 = new System.Windows.Forms.Button();
            this.MenuButton1 = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.RequestsPanel = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnReceived = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblReceived = new System.Windows.Forms.Label();
            this.LblSent = new System.Windows.Forms.Label();
            this.LblRequested = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ImageProgress = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtTransfusionCenter = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPlatelets1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtErythrocytes1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtPlasma1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtBloodType1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtRh1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
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
            this.MenuToggle = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.RequestsPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProgress)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuButton2);
            this.MenuPanel.Controls.Add(this.MenuButton1);
            this.animator1.SetDecoration(this.MenuPanel, AnimatorNS.DecorationType.None);
            this.MenuPanel.Location = new System.Drawing.Point(15, 113);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(284, 500);
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
            this.MenuButton2.Location = new System.Drawing.Point(5, 76);
            this.MenuButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuButton2.Name = "MenuButton2";
            this.MenuButton2.Size = new System.Drawing.Size(264, 57);
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
            this.MenuButton1.Location = new System.Drawing.Point(5, 5);
            this.MenuButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuButton1.Name = "MenuButton1";
            this.MenuButton1.Size = new System.Drawing.Size(264, 57);
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
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            // 
            // RequestsPanel
            // 
            this.RequestsPanel.BackColor = System.Drawing.Color.White;
            this.RequestsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RequestsPanel.Controls.Add(this.LblMessage);
            this.RequestsPanel.Controls.Add(this.groupBox6);
            this.RequestsPanel.Controls.Add(this.LblReceived);
            this.RequestsPanel.Controls.Add(this.LblSent);
            this.RequestsPanel.Controls.Add(this.LblRequested);
            this.RequestsPanel.Controls.Add(this.label17);
            this.RequestsPanel.Controls.Add(this.ImageProgress);
            this.RequestsPanel.Controls.Add(this.label16);
            this.RequestsPanel.Controls.Add(this.TxtTransfusionCenter);
            this.RequestsPanel.Controls.Add(this.groupBox4);
            this.RequestsPanel.Controls.Add(this.groupBox5);
            this.RequestsPanel.Controls.Add(this.BtnNext);
            this.RequestsPanel.Controls.Add(this.BtnPrevious);
            this.RequestsPanel.Controls.Add(this.bunifuSeparator2);
            this.animator1.SetDecoration(this.RequestsPanel, AnimatorNS.DecorationType.None);
            this.RequestsPanel.Location = new System.Drawing.Point(15, 113);
            this.RequestsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RequestsPanel.Name = "RequestsPanel";
            this.RequestsPanel.Size = new System.Drawing.Size(1244, 499);
            this.RequestsPanel.TabIndex = 20;
            this.RequestsPanel.Visible = false;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.animator1.SetDecoration(this.LblMessage, AnimatorNS.DecorationType.None);
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.LblMessage.Location = new System.Drawing.Point(829, 415);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 24);
            this.LblMessage.TabIndex = 23;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnReceived);
            this.groupBox6.Controls.Add(this.BtnCancel);
            this.animator1.SetDecoration(this.groupBox6, AnimatorNS.DecorationType.None);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox6.Location = new System.Drawing.Point(829, 240);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(381, 159);
            this.groupBox6.TabIndex = 53;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // BtnReceived
            // 
            this.BtnReceived.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnReceived, AnimatorNS.DecorationType.None);
            this.BtnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceived.ForeColor = System.Drawing.Color.White;
            this.BtnReceived.Location = new System.Drawing.Point(23, 57);
            this.BtnReceived.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReceived.Name = "BtnReceived";
            this.BtnReceived.Size = new System.Drawing.Size(151, 59);
            this.BtnReceived.TabIndex = 1;
            this.BtnReceived.Text = "Confirm receiveing";
            this.BtnReceived.UseVisualStyleBackColor = false;
            this.BtnReceived.Click += new System.EventHandler(this.BtnReceived_Click);
            this.BtnReceived.MouseLeave += new System.EventHandler(this.BtnReceived_MouseLeave);
            this.BtnReceived.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnReceived_MouseMove);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnCancel, AnimatorNS.DecorationType.None);
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(215, 57);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 59);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.BtnCancel.MouseLeave += new System.EventHandler(this.BtnCancel_MouseLeave);
            this.BtnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnCancel_MouseMove);
            // 
            // LblReceived
            // 
            this.LblReceived.AutoSize = true;
            this.animator1.SetDecoration(this.LblReceived, AnimatorNS.DecorationType.None);
            this.LblReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReceived.ForeColor = System.Drawing.Color.DimGray;
            this.LblReceived.Location = new System.Drawing.Point(1111, 143);
            this.LblReceived.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReceived.Name = "LblReceived";
            this.LblReceived.Size = new System.Drawing.Size(78, 20);
            this.LblReceived.TabIndex = 52;
            this.LblReceived.Text = "Received";
            // 
            // LblSent
            // 
            this.LblSent.AutoSize = true;
            this.animator1.SetDecoration(this.LblSent, AnimatorNS.DecorationType.None);
            this.LblSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSent.ForeColor = System.Drawing.Color.DimGray;
            this.LblSent.Location = new System.Drawing.Point(995, 143);
            this.LblSent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSent.Name = "LblSent";
            this.LblSent.Size = new System.Drawing.Size(43, 20);
            this.LblSent.TabIndex = 51;
            this.LblSent.Text = "Sent";
            // 
            // LblRequested
            // 
            this.LblRequested.AutoSize = true;
            this.animator1.SetDecoration(this.LblRequested, AnimatorNS.DecorationType.None);
            this.LblRequested.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequested.ForeColor = System.Drawing.Color.DimGray;
            this.LblRequested.Location = new System.Drawing.Point(836, 143);
            this.LblRequested.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRequested.Name = "LblRequested";
            this.LblRequested.Size = new System.Drawing.Size(89, 20);
            this.LblRequested.TabIndex = 50;
            this.LblRequested.Text = "Requested";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.animator1.SetDecoration(this.label17, AnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(829, 21);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 36);
            this.label17.TabIndex = 49;
            this.label17.Text = "Progress:";
            // 
            // ImageProgress
            // 
            this.animator1.SetDecoration(this.ImageProgress, AnimatorNS.DecorationType.None);
            this.ImageProgress.Image = global::Client.Properties.Resources.progress0;
            this.ImageProgress.Location = new System.Drawing.Point(809, 64);
            this.ImageProgress.Margin = new System.Windows.Forms.Padding(4);
            this.ImageProgress.Name = "ImageProgress";
            this.ImageProgress.Size = new System.Drawing.Size(427, 102);
            this.ImageProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageProgress.TabIndex = 48;
            this.ImageProgress.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.animator1.SetDecoration(this.label16, AnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(32, 399);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 24);
            this.label16.TabIndex = 47;
            this.label16.Text = "Transfusion center:";
            // 
            // TxtTransfusionCenter
            // 
            this.TxtTransfusionCenter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtTransfusionCenter, AnimatorNS.DecorationType.None);
            this.TxtTransfusionCenter.Enabled = false;
            this.TxtTransfusionCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTransfusionCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTransfusionCenter.HintForeColor = System.Drawing.Color.Empty;
            this.TxtTransfusionCenter.HintText = "";
            this.TxtTransfusionCenter.isPassword = false;
            this.TxtTransfusionCenter.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtTransfusionCenter.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtTransfusionCenter.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtTransfusionCenter.LineThickness = 2;
            this.TxtTransfusionCenter.Location = new System.Drawing.Point(36, 431);
            this.TxtTransfusionCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTransfusionCenter.Name = "TxtTransfusionCenter";
            this.TxtTransfusionCenter.Size = new System.Drawing.Size(716, 36);
            this.TxtTransfusionCenter.TabIndex = 46;
            this.TxtTransfusionCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TxtPlatelets1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TxtErythrocytes1);
            this.groupBox4.Controls.Add(this.TxtPlasma1);
            this.groupBox4.Controls.Add(this.label12);
            this.animator1.SetDecoration(this.groupBox4, AnimatorNS.DecorationType.None);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(397, 74);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(381, 302);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Blood products:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.animator1.SetDecoration(this.label10, AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(55, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "Platelets quantity:";
            // 
            // TxtPlatelets1
            // 
            this.TxtPlatelets1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtPlatelets1, AnimatorNS.DecorationType.None);
            this.TxtPlatelets1.Enabled = false;
            this.TxtPlatelets1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlatelets1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPlatelets1.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPlatelets1.HintText = "";
            this.TxtPlatelets1.isPassword = false;
            this.TxtPlatelets1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtPlatelets1.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtPlatelets1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtPlatelets1.LineThickness = 2;
            this.TxtPlatelets1.Location = new System.Drawing.Point(224, 57);
            this.TxtPlatelets1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlatelets1.Name = "TxtPlatelets1";
            this.TxtPlatelets1.Size = new System.Drawing.Size(131, 36);
            this.TxtPlatelets1.TabIndex = 4;
            this.TxtPlatelets1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.animator1.SetDecoration(this.label11, AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(63, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Plasma quantity:";
            // 
            // TxtErythrocytes1
            // 
            this.TxtErythrocytes1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtErythrocytes1, AnimatorNS.DecorationType.None);
            this.TxtErythrocytes1.Enabled = false;
            this.TxtErythrocytes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtErythrocytes1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtErythrocytes1.HintForeColor = System.Drawing.Color.Empty;
            this.TxtErythrocytes1.HintText = "";
            this.TxtErythrocytes1.isPassword = false;
            this.TxtErythrocytes1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtErythrocytes1.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtErythrocytes1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtErythrocytes1.LineThickness = 2;
            this.TxtErythrocytes1.Location = new System.Drawing.Point(224, 223);
            this.TxtErythrocytes1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtErythrocytes1.Name = "TxtErythrocytes1";
            this.TxtErythrocytes1.Size = new System.Drawing.Size(131, 36);
            this.TxtErythrocytes1.TabIndex = 6;
            this.TxtErythrocytes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtPlasma1
            // 
            this.TxtPlasma1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtPlasma1, AnimatorNS.DecorationType.None);
            this.TxtPlasma1.Enabled = false;
            this.TxtPlasma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlasma1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPlasma1.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPlasma1.HintText = "";
            this.TxtPlasma1.isPassword = false;
            this.TxtPlasma1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtPlasma1.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtPlasma1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtPlasma1.LineThickness = 2;
            this.TxtPlasma1.Location = new System.Drawing.Point(224, 139);
            this.TxtPlasma1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlasma1.Name = "TxtPlasma1";
            this.TxtPlasma1.Size = new System.Drawing.Size(131, 36);
            this.TxtPlasma1.TabIndex = 5;
            this.TxtPlasma1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.animator1.SetDecoration(this.label12, AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(19, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "Erythrocytes quantity:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.TxtName);
            this.groupBox5.Controls.Add(this.TxtBloodType1);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.TxtRh1);
            this.animator1.SetDecoration(this.groupBox5, AnimatorNS.DecorationType.None);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Location = new System.Drawing.Point(7, 74);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(383, 302);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pacient";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.animator1.SetDecoration(this.label13, AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(32, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtName, AnimatorNS.DecorationType.None);
            this.TxtName.Enabled = false;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtName.HintText = "";
            this.TxtName.isPassword = false;
            this.TxtName.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtName.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtName.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtName.LineThickness = 2;
            this.TxtName.Location = new System.Drawing.Point(36, 81);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(289, 36);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtBloodType1
            // 
            this.TxtBloodType1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtBloodType1, AnimatorNS.DecorationType.None);
            this.TxtBloodType1.Enabled = false;
            this.TxtBloodType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBloodType1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBloodType1.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBloodType1.HintText = "";
            this.TxtBloodType1.isPassword = false;
            this.TxtBloodType1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType1.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtBloodType1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType1.LineThickness = 2;
            this.TxtBloodType1.Location = new System.Drawing.Point(36, 164);
            this.TxtBloodType1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBloodType1.Name = "TxtBloodType1";
            this.TxtBloodType1.Size = new System.Drawing.Size(289, 36);
            this.TxtBloodType1.TabIndex = 2;
            this.TxtBloodType1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.animator1.SetDecoration(this.label14, AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(32, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "Rh:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.animator1.SetDecoration(this.label15, AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(32, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Blood type:";
            // 
            // TxtRh1
            // 
            this.TxtRh1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtRh1, AnimatorNS.DecorationType.None);
            this.TxtRh1.Enabled = false;
            this.TxtRh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRh1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRh1.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRh1.HintText = "";
            this.TxtRh1.isPassword = false;
            this.TxtRh1.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtRh1.LineIdleColor = System.Drawing.Color.DimGray;
            this.TxtRh1.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtRh1.LineThickness = 2;
            this.TxtRh1.Location = new System.Drawing.Point(36, 247);
            this.TxtRh1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRh1.Name = "TxtRh1";
            this.TxtRh1.Size = new System.Drawing.Size(289, 36);
            this.TxtRh1.TabIndex = 3;
            this.TxtRh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnNext
            // 
            this.BtnNext.BackgroundImage = global::Client.Properties.Resources.rightarrow;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.BtnNext, AnimatorNS.DecorationType.None);
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(476, 21);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(41, 39);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackgroundImage = global::Client.Properties.Resources.leftarrow;
            this.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.BtnPrevious, AnimatorNS.DecorationType.None);
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(284, 21);
            this.BtnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(41, 39);
            this.BtnPrevious.TabIndex = 5;
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(787, -2);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(35, 487);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
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
            this.MainPanel.Location = new System.Drawing.Point(15, 113);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1244, 499);
            this.MainPanel.TabIndex = 21;
            this.MainPanel.Visible = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnSubmit, AnimatorNS.DecorationType.None);
            this.BtnSubmit.Enabled = false;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(1123, 442);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(113, 49);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            this.BtnSubmit.MouseLeave += new System.EventHandler(this.BtnSubmit_MouseLeave);
            this.BtnSubmit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSubmit_MouseMove);
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
            this.groupBox3.Location = new System.Drawing.Point(7, 342);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(576, 149);
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
            this.TxtSearchResult.Location = new System.Drawing.Point(144, 103);
            this.TxtSearchResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearchResult.Name = "TxtSearchResult";
            this.TxtSearchResult.Size = new System.Drawing.Size(401, 36);
            this.TxtSearchResult.TabIndex = 31;
            this.TxtSearchResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.animator1.SetDecoration(this.Radio2, AnimatorNS.DecorationType.None);
            this.Radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio2.Location = new System.Drawing.Point(9, 68);
            this.Radio2.Margin = new System.Windows.Forms.Padding(4);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(361, 24);
            this.Radio2.TabIndex = 8;
            this.Radio2.Text = "Nearest center with available blood products";
            this.Radio2.UseVisualStyleBackColor = true;
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.Checked = true;
            this.animator1.SetDecoration(this.Radio1, AnimatorNS.DecorationType.None);
            this.Radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio1.Location = new System.Drawing.Point(9, 32);
            this.Radio1.Margin = new System.Windows.Forms.Padding(4);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(325, 24);
            this.Radio1.TabIndex = 7;
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
            this.BtnSearch.Location = new System.Drawing.Point(12, 103);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 38);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            this.BtnSearch.MouseLeave += new System.EventHandler(this.BtnSearch_MouseLeave);
            this.BtnSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSearch_MouseMove);
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
            this.groupBox2.Location = new System.Drawing.Point(834, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 302);
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
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
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
            this.TxtPlatelets.Location = new System.Drawing.Point(224, 57);
            this.TxtPlatelets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlatelets.Name = "TxtPlatelets";
            this.TxtPlatelets.Size = new System.Drawing.Size(131, 36);
            this.TxtPlatelets.TabIndex = 4;
            this.TxtPlatelets.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.animator1.SetDecoration(this.label6, AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(63, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
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
            this.TxtErythrocytes.Location = new System.Drawing.Point(224, 223);
            this.TxtErythrocytes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtErythrocytes.Name = "TxtErythrocytes";
            this.TxtErythrocytes.Size = new System.Drawing.Size(131, 36);
            this.TxtErythrocytes.TabIndex = 6;
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
            this.TxtPlasma.Location = new System.Drawing.Point(224, 139);
            this.TxtPlasma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlasma.Name = "TxtPlasma";
            this.TxtPlasma.Size = new System.Drawing.Size(131, 36);
            this.TxtPlasma.TabIndex = 5;
            this.TxtPlasma.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.animator1.SetDecoration(this.label7, AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(19, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(427, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(383, 302);
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
            this.label5.Location = new System.Drawing.Point(32, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
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
            this.TxtPacient.Location = new System.Drawing.Point(36, 81);
            this.TxtPacient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPacient.Name = "TxtPacient";
            this.TxtPacient.Size = new System.Drawing.Size(289, 36);
            this.TxtPacient.TabIndex = 1;
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
            this.TxtBloodType.Location = new System.Drawing.Point(36, 164);
            this.TxtBloodType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBloodType.Name = "TxtBloodType";
            this.TxtBloodType.Size = new System.Drawing.Size(289, 36);
            this.TxtBloodType.TabIndex = 2;
            this.TxtBloodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.animator1.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(32, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Rh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.animator1.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(32, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
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
            this.TxtRh.Location = new System.Drawing.Point(36, 247);
            this.TxtRh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRh.Name = "TxtRh";
            this.TxtRh.Size = new System.Drawing.Size(289, 36);
            this.TxtRh.TabIndex = 3;
            this.TxtRh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 313);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1232, 43);
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
            this.TxtHospital.Location = new System.Drawing.Point(35, 135);
            this.TxtHospital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHospital.Name = "TxtHospital";
            this.TxtHospital.Size = new System.Drawing.Size(371, 36);
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
            this.TxtDoctor.Location = new System.Drawing.Point(35, 53);
            this.TxtDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(371, 36);
            this.TxtDoctor.TabIndex = 27;
            this.TxtDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(31, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 22;
            // 
            // MenuToggle
            // 
            this.animator1.SetDecoration(this.MenuToggle, AnimatorNS.DecorationType.None);
            this.MenuToggle.Image = global::Client.Properties.Resources.menuicon;
            this.MenuToggle.Location = new System.Drawing.Point(15, 64);
            this.MenuToggle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuToggle.Name = "MenuToggle";
            this.MenuToggle.Size = new System.Drawing.Size(45, 44);
            this.MenuToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuToggle.TabIndex = 17;
            this.MenuToggle.TabStop = false;
            this.MenuToggle.Click += new System.EventHandler(this.MenuToggle_Click);
            this.MenuToggle.MouseHover += new System.EventHandler(this.MenuToggle_MouseHover);
            // 
            // PictureBox3
            // 
            this.animator1.SetDecoration(this.PictureBox3, AnimatorNS.DecorationType.None);
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(1208, 10);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 16;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // PictureBox2
            // 
            this.animator1.SetDecoration(this.PictureBox2, AnimatorNS.DecorationType.None);
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1235, 14);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(25, 25);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // MedicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 626);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RequestsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuToggle);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.MenuPanel);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MedicWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medic Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicWindow_FormClosing);
            this.Load += new System.EventHandler(this.MedicWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MedicWindow_MouseDown);
            this.MenuPanel.ResumeLayout(false);
            this.RequestsPanel.ResumeLayout(false);
            this.RequestsPanel.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageProgress)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
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
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPlatelets1;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtErythrocytes1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPlasma1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBloodType1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRh1;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtTransfusionCenter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox ImageProgress;
        private System.Windows.Forms.Label LblReceived;
        private System.Windows.Forms.Label LblSent;
        private System.Windows.Forms.Label LblRequested;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnReceived;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblMessage;
    }
}