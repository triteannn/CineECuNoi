namespace Client
{
    partial class EmployeeWindow
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
            AnimatorNS.Animation animation4 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeWindow));
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuToggle = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuButton4 = new System.Windows.Forms.Button();
            this.MenuButton3 = new System.Windows.Forms.Button();
            this.MenuButton2 = new System.Windows.Forms.Button();
            this.MenuButton1 = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCollectionDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtTarget = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtBloodType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtRh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCreationDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnReject = new System.Windows.Forms.Button();
            this.DonationFormsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox3
            // 
            this.animator1.SetDecoration(this.PictureBox3, AnimatorNS.DecorationType.None);
            this.PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox3.Image")));
            this.PictureBox3.Location = new System.Drawing.Point(965, 8);
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
            this.PictureBox2.Location = new System.Drawing.Point(985, 11);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(19, 20);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 15;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // MenuToggle
            // 
            this.animator1.SetDecoration(this.MenuToggle, AnimatorNS.DecorationType.None);
            this.MenuToggle.Image = global::Client.Properties.Resources.menuicon;
            this.MenuToggle.Location = new System.Drawing.Point(15, 51);
            this.MenuToggle.Margin = new System.Windows.Forms.Padding(2);
            this.MenuToggle.Name = "MenuToggle";
            this.MenuToggle.Size = new System.Drawing.Size(34, 36);
            this.MenuToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuToggle.TabIndex = 18;
            this.MenuToggle.TabStop = false;
            this.MenuToggle.Click += new System.EventHandler(this.MenuToggle_Click);
            this.MenuToggle.MouseHover += new System.EventHandler(this.MenuToggle_MouseHover);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuButton4);
            this.MenuPanel.Controls.Add(this.MenuButton3);
            this.MenuPanel.Controls.Add(this.MenuButton2);
            this.MenuPanel.Controls.Add(this.MenuButton1);
            this.animator1.SetDecoration(this.MenuPanel, AnimatorNS.DecorationType.None);
            this.MenuPanel.Location = new System.Drawing.Point(15, 91);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(213, 539);
            this.MenuPanel.TabIndex = 19;
            this.MenuPanel.Visible = false;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // MenuButton4
            // 
            this.MenuButton4.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.MenuButton4, AnimatorNS.DecorationType.None);
            this.MenuButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton4.ForeColor = System.Drawing.Color.White;
            this.MenuButton4.Location = new System.Drawing.Point(4, 180);
            this.MenuButton4.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton4.Name = "MenuButton4";
            this.MenuButton4.Size = new System.Drawing.Size(198, 46);
            this.MenuButton4.TabIndex = 29;
            this.MenuButton4.Text = "Convert blood to products";
            this.MenuButton4.UseVisualStyleBackColor = false;
            this.MenuButton4.Click += new System.EventHandler(this.MenuButton4_Click);
            this.MenuButton4.MouseLeave += new System.EventHandler(this.MenuButton4_MouseLeave);
            this.MenuButton4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuButton4_MouseMove);
            // 
            // MenuButton3
            // 
            this.MenuButton3.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.MenuButton3, AnimatorNS.DecorationType.None);
            this.MenuButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton3.ForeColor = System.Drawing.Color.White;
            this.MenuButton3.Location = new System.Drawing.Point(4, 121);
            this.MenuButton3.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton3.Name = "MenuButton3";
            this.MenuButton3.Size = new System.Drawing.Size(198, 46);
            this.MenuButton3.TabIndex = 28;
            this.MenuButton3.Text = "View hospital requests";
            this.MenuButton3.UseVisualStyleBackColor = false;
            this.MenuButton3.Click += new System.EventHandler(this.MenuButton3_Click);
            this.MenuButton3.MouseLeave += new System.EventHandler(this.MenuButton3_MouseLeave);
            this.MenuButton3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuButton3_MouseMove);
            // 
            // MenuButton2
            // 
            this.MenuButton2.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.MenuButton2, AnimatorNS.DecorationType.None);
            this.MenuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton2.ForeColor = System.Drawing.Color.White;
            this.MenuButton2.Location = new System.Drawing.Point(4, 62);
            this.MenuButton2.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton2.Name = "MenuButton2";
            this.MenuButton2.Size = new System.Drawing.Size(198, 46);
            this.MenuButton2.TabIndex = 27;
            this.MenuButton2.Text = "Send blood results";
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
            this.MenuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton1.ForeColor = System.Drawing.Color.White;
            this.MenuButton1.Location = new System.Drawing.Point(4, 4);
            this.MenuButton1.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButton1.Name = "MenuButton1";
            this.MenuButton1.Size = new System.Drawing.Size(198, 46);
            this.MenuButton1.TabIndex = 27;
            this.MenuButton1.Text = "View donation forms";
            this.MenuButton1.UseVisualStyleBackColor = false;
            this.MenuButton1.Click += new System.EventHandler(this.MenuButton1_Click);
            this.MenuButton1.MouseLeave += new System.EventHandler(this.MenuButton1_MouseLeave);
            this.MenuButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuButton1_MouseMove);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation4;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.DonationFormsList);
            this.Panel1.Controls.Add(this.groupBox3);
            this.Panel1.Controls.Add(this.groupBox2);
            this.Panel1.Controls.Add(this.groupBox1);
            this.Panel1.Controls.Add(this.label2);
            this.animator1.SetDecoration(this.Panel1, AnimatorNS.DecorationType.None);
            this.Panel1.Location = new System.Drawing.Point(15, 91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(987, 539);
            this.Panel1.TabIndex = 20;
            this.Panel1.Visible = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.animator1.SetDecoration(this.Panel2, AnimatorNS.DecorationType.None);
            this.Panel2.Location = new System.Drawing.Point(15, 91);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(987, 539);
            this.Panel2.TabIndex = 21;
            this.Panel2.Visible = false;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.animator1.SetDecoration(this.Panel3, AnimatorNS.DecorationType.None);
            this.Panel3.Location = new System.Drawing.Point(15, 91);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(987, 539);
            this.Panel3.TabIndex = 22;
            this.Panel3.Visible = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.White;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.animator1.SetDecoration(this.Panel4, AnimatorNS.DecorationType.None);
            this.Panel4.Location = new System.Drawing.Point(15, 91);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(987, 539);
            this.Panel4.TabIndex = 23;
            this.Panel4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator1.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Submitted donation forms:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.TxtRh);
            this.groupBox1.Controls.Add(this.TxtBloodType);
            this.groupBox1.Controls.Add(this.TxtTarget);
            this.groupBox1.Controls.Add(this.TxtCollectionDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.animator1.SetDecoration(this.groupBox1, AnimatorNS.DecorationType.None);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(692, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add blood bag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator1.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(17, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Collection date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator1.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Target:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator1.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Blood type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.animator1.SetDecoration(this.label6, AnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(17, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rh:";
            // 
            // TxtCollectionDate
            // 
            this.TxtCollectionDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtCollectionDate, AnimatorNS.DecorationType.None);
            this.TxtCollectionDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCollectionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCollectionDate.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCollectionDate.HintText = "";
            this.TxtCollectionDate.isPassword = false;
            this.TxtCollectionDate.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtCollectionDate.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCollectionDate.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtCollectionDate.LineThickness = 3;
            this.TxtCollectionDate.Location = new System.Drawing.Point(21, 64);
            this.TxtCollectionDate.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCollectionDate.Name = "TxtCollectionDate";
            this.TxtCollectionDate.Size = new System.Drawing.Size(230, 33);
            this.TxtCollectionDate.TabIndex = 4;
            this.TxtCollectionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtTarget
            // 
            this.TxtTarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtTarget, AnimatorNS.DecorationType.None);
            this.TxtTarget.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTarget.HintForeColor = System.Drawing.Color.Empty;
            this.TxtTarget.HintText = "";
            this.TxtTarget.isPassword = false;
            this.TxtTarget.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtTarget.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtTarget.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtTarget.LineThickness = 3;
            this.TxtTarget.Location = new System.Drawing.Point(21, 136);
            this.TxtTarget.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(230, 33);
            this.TxtTarget.TabIndex = 5;
            this.TxtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtBloodType
            // 
            this.TxtBloodType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtBloodType, AnimatorNS.DecorationType.None);
            this.TxtBloodType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBloodType.HintForeColor = System.Drawing.Color.Empty;
            this.TxtBloodType.HintText = "";
            this.TxtBloodType.isPassword = false;
            this.TxtBloodType.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtBloodType.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtBloodType.LineThickness = 3;
            this.TxtBloodType.Location = new System.Drawing.Point(21, 208);
            this.TxtBloodType.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBloodType.Name = "TxtBloodType";
            this.TxtBloodType.Size = new System.Drawing.Size(230, 33);
            this.TxtBloodType.TabIndex = 6;
            this.TxtBloodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtRh
            // 
            this.TxtRh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtRh, AnimatorNS.DecorationType.None);
            this.TxtRh.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtRh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtRh.HintForeColor = System.Drawing.Color.Empty;
            this.TxtRh.HintText = "";
            this.TxtRh.isPassword = false;
            this.TxtRh.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtRh.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtRh.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtRh.LineThickness = 3;
            this.TxtRh.Location = new System.Drawing.Point(21, 278);
            this.TxtRh.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRh.Name = "TxtRh";
            this.TxtRh.Size = new System.Drawing.Size(230, 33);
            this.TxtRh.TabIndex = 7;
            this.TxtRh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnAdd, AnimatorNS.DecorationType.None);
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(166, 318);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 42);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtCreationDate);
            this.groupBox2.Controls.Add(this.TxtLastName);
            this.groupBox2.Controls.Add(this.TxtFirstName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.animator1.SetDecoration(this.groupBox2, AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(343, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 366);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donation form";
            // 
            // TxtCreationDate
            // 
            this.TxtCreationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtCreationDate, AnimatorNS.DecorationType.None);
            this.TxtCreationDate.Enabled = false;
            this.TxtCreationDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCreationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCreationDate.HintForeColor = System.Drawing.Color.Empty;
            this.TxtCreationDate.HintText = "";
            this.TxtCreationDate.isPassword = false;
            this.TxtCreationDate.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtCreationDate.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCreationDate.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtCreationDate.LineThickness = 3;
            this.TxtCreationDate.Location = new System.Drawing.Point(21, 208);
            this.TxtCreationDate.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCreationDate.Name = "TxtCreationDate";
            this.TxtCreationDate.Size = new System.Drawing.Size(230, 33);
            this.TxtCreationDate.TabIndex = 6;
            this.TxtCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtLastName, AnimatorNS.DecorationType.None);
            this.TxtLastName.Enabled = false;
            this.TxtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtLastName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtLastName.HintText = "";
            this.TxtLastName.isPassword = false;
            this.TxtLastName.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtLastName.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtLastName.LineThickness = 3;
            this.TxtLastName.Location = new System.Drawing.Point(21, 136);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(230, 33);
            this.TxtLastName.TabIndex = 5;
            this.TxtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtFirstName, AnimatorNS.DecorationType.None);
            this.TxtFirstName.Enabled = false;
            this.TxtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtFirstName.HintText = "";
            this.TxtFirstName.isPassword = false;
            this.TxtFirstName.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtFirstName.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtFirstName.LineThickness = 3;
            this.TxtFirstName.Location = new System.Drawing.Point(21, 64);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(230, 33);
            this.TxtFirstName.TabIndex = 4;
            this.TxtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.animator1.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(17, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Creation date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.animator1.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(17, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.animator1.SetDecoration(this.label10, AnimatorNS.DecorationType.None);
            this.label10.Location = new System.Drawing.Point(17, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "First name:";
            // 
            // TxtStatus
            // 
            this.TxtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator1.SetDecoration(this.TxtStatus, AnimatorNS.DecorationType.None);
            this.TxtStatus.Enabled = false;
            this.TxtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtStatus.HintForeColor = System.Drawing.Color.Empty;
            this.TxtStatus.HintText = "";
            this.TxtStatus.isPassword = false;
            this.TxtStatus.LineFocusedColor = System.Drawing.Color.DarkRed;
            this.TxtStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtStatus.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.TxtStatus.LineThickness = 3;
            this.TxtStatus.Location = new System.Drawing.Point(21, 278);
            this.TxtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(230, 33);
            this.TxtStatus.TabIndex = 8;
            this.TxtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.animator1.SetDecoration(this.label7, AnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(17, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnReject);
            this.groupBox3.Controls.Add(this.BtnAccept);
            this.animator1.SetDecoration(this.groupBox3, AnimatorNS.DecorationType.None);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(535, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnAccept, AnimatorNS.DecorationType.None);
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(6, 41);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(85, 42);
            this.BtnAccept.TabIndex = 9;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = false;
            // 
            // BtnReject
            // 
            this.BtnReject.BackColor = System.Drawing.Color.DarkRed;
            this.animator1.SetDecoration(this.BtnReject, AnimatorNS.DecorationType.None);
            this.BtnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReject.ForeColor = System.Drawing.Color.White;
            this.BtnReject.Location = new System.Drawing.Point(147, 41);
            this.BtnReject.Name = "BtnReject";
            this.BtnReject.Size = new System.Drawing.Size(85, 42);
            this.BtnReject.TabIndex = 10;
            this.BtnReject.Text = "Reject";
            this.BtnReject.UseVisualStyleBackColor = false;
            // 
            // DonationFormsList
            // 
            this.DonationFormsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.animator1.SetDecoration(this.DonationFormsList, AnimatorNS.DecorationType.None);
            this.DonationFormsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationFormsList.ForeColor = System.Drawing.Color.DarkRed;
            this.DonationFormsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DonationFormsList.Location = new System.Drawing.Point(12, 39);
            this.DonationFormsList.MultiSelect = false;
            this.DonationFormsList.Name = "DonationFormsList";
            this.DonationFormsList.Size = new System.Drawing.Size(265, 493);
            this.DonationFormsList.TabIndex = 24;
            this.DonationFormsList.UseCompatibleStateImageBehavior = false;
            this.DonationFormsList.View = System.Windows.Forms.View.Details;
            this.DonationFormsList.SelectedIndexChanged += new System.EventHandler(this.DonationFormsList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 88;
            // 
            // EmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 641);
            this.ControlBox = false;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MenuToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmployeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeWindow_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox3;
        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuToggle;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button MenuButton2;
        private System.Windows.Forms.Button MenuButton1;
        private System.Windows.Forms.Button MenuButton3;
        private System.Windows.Forms.Button MenuButton4;
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCollectionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtRh;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtBloodType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtTarget;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCreationDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnReject;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.ListView DonationFormsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}