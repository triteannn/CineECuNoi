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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dispose();
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full name")
                txtFullName.Text = "";
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
                txtFullName.Text = "Full name";
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.isPassword = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text.Length > 0 && txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && DOB.Value != null && dropdownAS.selectedIndex > 0 && txtFullName.Text != "Full name" && txtUsername.Text != "Username" && txtPassword.Text != "Password")
            {

            }
            else MessageBox.Show("Fields can not be empty or left unchanged.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dropdownAS_KeyDown(object sender, KeyEventArgs e)
        {
            btnRegister.Select();
        }
    }
}
