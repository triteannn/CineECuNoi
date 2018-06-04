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
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuToggle)).BeginInit();
            this.MenuPanel.SuspendLayout();
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation5;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
    }
}