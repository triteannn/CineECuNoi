using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSApp
{
    public partial class LoginForm : Form
    {

        private bool _closingfade = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Fade.Start();
        }

        private void Fade_Tick(object sender, EventArgs e)
        {
            if (!_closingfade)
            {
                if (Opacity < 1.0)
                    Opacity += 0.05;
                else
                {
                    Fade.Stop();
                    Enabled = true;                                   
                }
            }
            else
            {
                if (Opacity > 0.0)
                    Opacity -= 0.05;
                else
                {
                    Fade.Stop();
                    Dispose();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Doriti intr-adevar sa iesiti din aplicatie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _closingfade = true;
            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
                Enabled = false;
                Fade.Start();
            }
            else e.Cancel = true;
        }
    }
}
