using ISSApp.Domain;
using ISSApp.Repository;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ISSApp
{
    public partial class RegisterForm : Form
    {

        private readonly LoginForm _loginForm;
        private readonly SqlDonatorRepo _donatorRepo;
        private readonly SqlAccountRepo _accountRepo;

        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _donatorRepo = new SqlDonatorRepo();
            _accountRepo = new SqlAccountRepo();
        }

        private void LblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _loginForm.EmptyFields();
            _loginForm.Enabled = true;
            Close();
        }

        private void TxtFirstName_Enter(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == @"First name")
                TxtFirstName.Text = "";
        }

        private void TxtFirstName_Leave(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "")
                TxtFirstName.Text = @"First name";
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == @"Username")
                TxtUsername.Text = "";
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
                TxtUsername.Text = @"Username";
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == @"Password")
            {
                TxtPassword.Text = "";
                TxtPassword.isPassword = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = @"Password";
                TxtPassword.isPassword = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtCnp.Text.Length > 0 && TxtFirstName.Text.Length > 0 && TxtLastName.Text.Length > 0 && TxtUsername.Text.Length > 0 && TxtPassword.Text.Length > 0 && !TxtFirstName.Text.Equals("Full name") && !TxtUsername.Text.Equals("Username") && !TxtPassword.Text.Equals("Password"))
            {
                var donator = new Donator(TxtCnp.Text, TxtLastName.Text, TxtFirstName.Text, DOB.Value);
                var account = new Account(TxtUsername.Text, TxtPassword.Text);
                _donatorRepo.Add(donator);
                using (var connection = Globals.getDBConnection())
                {
                    connection.Open();
                    var cmd = new SqlCommand(@"select max(Id) from Donatori", connection);
                    var reader = cmd.ExecuteReader();
                    var id = 0;
                    if (reader.Read())
                    {
                        id = reader.GetInt16(0);
                    }
                    account.IdD = id;
                }
                _accountRepo.Add(account);
                MessageBox.Show(@"Account created successfully!", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(@"Fields can not be empty or left unchanged.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            swfRegister.Movie = Environment.CurrentDirectory.Replace(@"bin\x86\Debug", @"Resources\RegisterImage.swf");
        }

        private void TxtLastName_Enter(object sender, EventArgs e)
        {
            if (TxtLastName.Text == @"Last name")
                TxtLastName.Text = "";
        }

        private void TxtLastName_Leave(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "")
                TxtLastName.Text = @"Last name";
        }

        private void TxtCnp_Enter(object sender, EventArgs e)
        {
            if (TxtCnp.Text == @"CNP")
                TxtCnp.Text = "";
        }

        private void TxtCnp_Leave(object sender, EventArgs e)
        {
            if (TxtCnp.Text == "")
                TxtCnp.Text = @"CNP";
        }
    }
}
