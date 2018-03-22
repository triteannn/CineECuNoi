using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSApp
{
    public partial class MainWindow : Form
    {

        private readonly LoginForm _loginForm;

        public MainWindow(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Dispose();
                _loginForm.EmptyFields();
                _loginForm.Show();
            }
            else e.Cancel = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
