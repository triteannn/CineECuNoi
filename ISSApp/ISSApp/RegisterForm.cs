using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ISSApp
{
    public partial class RegisterForm : Form
    {

        private LoginForm _loginForm;

        public RegisterForm(LoginForm loginForm)
        {            
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void LblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _loginForm.EmptyFields();
            _loginForm.Enabled = true;
            Close();
        }

        private void TxtFullName_Enter(object sender, EventArgs e)
        {
            if (TxtFullName.Text == "Full name")
                TxtFullName.Text = "";
        }

        private void TxtFullName_Leave(object sender, EventArgs e)
        {
            if (TxtFullName.Text == "")
                TxtFullName.Text = "Full name";
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
                TxtUsername.Text = "";
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
                TxtUsername.Text = "Username";
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.isPassword = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                TxtPassword.isPassword = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtFullName.Text.Length > 0 && TxtUsername.Text.Length > 0 && TxtPassword.Text.Length > 0 && DOB.Value != null && TxtFullName.Text != "Full name" && TxtUsername.Text != "Username" && TxtPassword.Text != "Password")
            {

            }
            else MessageBox.Show(@"Fields can not be empty or left unchanged.", @"", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnRegister.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DropdownAS_KeyDown(object sender, KeyEventArgs e)
        {
            BtnRegister.Select();
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
    }
}
