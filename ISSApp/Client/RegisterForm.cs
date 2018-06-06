using Client.Validator;
using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form
    {

        private readonly LoginForm _loginForm;
        private readonly IServer _server;

        public RegisterForm(LoginForm loginForm, IServer server)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
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
            BtnRegister.Enabled = false;
            var worker = new BackgroundWorker {
                WorkerSupportsCancellation = true
            };
            if (TxtCnp.Text.Length > 0 && TxtFirstName.Text.Length > 0 && TxtLastName.Text.Length > 0 && TxtUsername.Text.Length > 0 && TxtPassword.Text.Length > 0 && !TxtCnp.Text.Equals("CNP") && !TxtFirstName.Text.Equals("First name") && !TxtLastName.Text.Equals("Last name") && !TxtUsername.Text.Equals("Username") && !TxtPassword.Text.Equals("Password"))
            {
                try
                {
                    RegisterValidator.ValidateCnp(TxtCnp.Text);
                    RegisterValidator.ValidateFirstName(TxtFirstName.Text);
                    RegisterValidator.ValidateLastName(TxtLastName.Text);
                    RegisterValidator.ValidateUsername(TxtUsername.Text);
                    RegisterValidator.ValidatePassword(TxtPassword.Text);
                    RegisterValidator.ValidateAge(DOB.Value);
                    var donator = new Donator(TxtCnp.Text, TxtLastName.Text, TxtFirstName.Text, DOB.Value);
                    var account = new Account(TxtUsername.Text, TxtPassword.Text);
                    var created = false;
                    worker.DoWork += (obj, ea) => {
                        if (_server.AccountFindByUsername(account.Username) == null)
                        {
                            created = true;
                            _server.AccountAdd(account);

                            donator.IdA = _server.AccountGetLastId();
                            account.Id = (int)donator.IdA;

                            _server.DonatorAdd(donator);

                            donator.Id = _server.DonatorGetLastId();
                            account.IdD = donator.Id;
                            _server.AccountUpdate(account);
                        }
                        else
                        {
                            MessageBox.Show(@"There is already an account with that username.", @"Error occured", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                            worker.CancelAsync();
                        }
                    };

                    worker.RunWorkerAsync();

                    worker.RunWorkerCompleted += (obj, ea) => {
                        BtnRegister.Enabled = true;
                        if (created)
                        {
                            MessageBox.Show(@"Account created successfully!", @"Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            _loginForm.EmptyFields();
                            _loginForm.Enabled = true;
                            worker.Dispose();
                            Close();
                        }
                    };
                } catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, @"Validation error occured", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    BtnRegister.Enabled = true;
                } catch (NetworkingException ex)
                {
                    MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    BtnRegister.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(@"Fields can not be empty or left unchanged.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnRegister.Enabled = true;
            }
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
            swfRegister.Movie = Environment.CurrentDirectory.Replace(@"bin\Debug", @"Resources\RegisterImage.swf");
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
