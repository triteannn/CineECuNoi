namespace ISSApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::ISSApp.Properties.Resources.exitBtn;
            this.PictureBox2.Location = new System.Drawing.Point(763, 12);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(25, 25);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 13;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::ISSApp.Properties.Resources.minimize;
            this.PictureBox3.Location = new System.Drawing.Point(737, 9);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(20, 22);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 14;
            this.PictureBox3.TabStop = false;
            this.PictureBox3.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox PictureBox3;
    }
}