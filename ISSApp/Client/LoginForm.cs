using ISSApp.Networking;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client
{
    public partial class LoginForm : Form
    {

        private bool _closingfade;
        private readonly IServer _server;

        public LoginForm(IServer server)
        {
            InitializeComponent();
            _server = server;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Fade.Start();
            TxtUsername.Text = @"Username";
            TxtPassword.Text = @"Password";
            TxtPassword.isPassword = false;
            var serializer = new XmlSerializer(typeof(string));
            if (File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
            {
                using (var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Open, FileAccess.Read))
                {
                    TxtUsername.Text = serializer.Deserialize(fs) as string;
                }
                RememberMe.Checked = true;
            }
            Label5.ForeColor = RememberMe.Checked ? Color.DarkRed : Color.Gray;
            swfLogin.Movie = Environment.CurrentDirectory.Replace(@"bin\Debug", @"Resources\LoginImage.swf");
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
            var result = MessageBox.Show(@"Are you sure you want to exit the application?", @"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _closingfade = true;
            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
                Enabled = false;
                Fade.Start();
            }
            else
                e.Cancel = true;
        }

        private void BtnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            BtnLogin.BackColor = Color.White;
            BtnLogin.ForeColor = Color.DarkRed;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.DarkRed;
            BtnLogin.ForeColor = Color.White;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Length > 0 && TxtPassword.Text.Length > 0 && DropdownAS.selectedIndex > 0 && TxtUsername.Text != @"Username" && TxtPassword.Text != @"Password")
            {
                if (RememberMe.Checked)
                {
                    var serializer = new XmlSerializer(typeof(string));
                    if (File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
                    {
                        using (var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Open, FileAccess.Write))
                        {
                            serializer.Serialize(fs, TxtUsername.Text);
                        }
                    }
                    else
                    {
                        using (var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Create, FileAccess.Write))
                        {
                            serializer.Serialize(fs, TxtUsername.Text);
                        }
                    }
                }
                else
                {
                    if (File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
                    {
                        File.Delete(Environment.CurrentDirectory + @"\RememberedUser.xml");
                    }
                }

                var acc = _server.AccountFindAccountByCredentials(TxtUsername.Text, TxtPassword.Text);
                if (acc != null)
                {
                    if (acc.IdD != null && DropdownAS.selectedValue.Equals("Donator"))
                    {
                        var mainWindow = new DonatorWindow(this, _server);
                        mainWindow.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show(@"This account doesn't have the rights to login as " + DropdownAS.selectedValue,
                            @"Insufficient permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show(@"Invalid username or password.", @"Please check your credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show(@"Fields can not be empty or left unchanged.", @"", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void EmptyFields()
        {
            if (!RememberMe.Checked)
                TxtUsername.Text = @"Username";
            RememberMe.Checked = TxtUsername.Text != @"Username";
            TxtPassword.Text = @"Password";
            TxtPassword.isPassword = false;
            DropdownAS.selectedIndex = 0;
        }

        private void LblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm(this, _server);
            registerForm.Show();
            Enabled = false;
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DropdownAS_onItemSelected(object sender, EventArgs e)
        {
            BtnLogin.Select();
        }

        private void RememberMe_OnChange(object sender, EventArgs e)
        {
            Label5.ForeColor = RememberMe.Checked ? Color.DarkRed : Color.Gray;
        }
    }
}
