namespace ISSApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTudor = new System.Windows.Forms.Label();
            this.labelAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTudor
            // 
            this.labelTudor.AutoSize = true;
            this.labelTudor.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTudor.ForeColor = System.Drawing.Color.White;
            this.labelTudor.Location = new System.Drawing.Point(6, 49);
            this.labelTudor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTudor.Name = "labelTudor";
            this.labelTudor.Size = new System.Drawing.Size(207, 41);
            this.labelTudor.TabIndex = 0;
            this.labelTudor.Text = "labelTudor";
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(339, 85);
            this.labelAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(58, 17);
            this.labelAdi.TabIndex = 0;
            this.labelAdi.Text = "labelAdi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 242);
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.labelTudor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 289);
            this.MinimumSize = new System.Drawing.Size(454, 289);
            this.Name = "Form1";
            this.Text = "Centru donare sange - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdi;

        private System.Windows.Forms.Label labelTudor;
    }
}

