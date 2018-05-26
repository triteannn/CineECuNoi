using AnimatorNS;
using Bunifu.Framework.UI;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Networking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
    public partial class DonatorWindow : Form
    {

        private readonly LoginForm _loginForm;
        private readonly IServer _server;
        private readonly DonatorService _donatorService;
        private readonly Account _loggedAccount;
        private readonly List<string> _notifications;

        public DonatorWindow(LoginForm loginForm, IServer server, Account loggedAccount)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
            _donatorService = new DonatorService(_server);
            _loggedAccount = loggedAccount;
            _notifications = new List<string>();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to logout?", @"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _loginForm.EmptyFields();
                _loginForm.Visible = true;
            }
            else
                e.Cancel = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            if (!_toggleMenu)
                MenuToggle_Click(MenuToggle, null);
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void DonatorWindow_Load(object sender, EventArgs e)
        {
            Text = @"Donator Window";
            label2.Text = @"Logged in as " + _loggedAccount.Username;
            if (true)
            {
                _notifications.Add("Au trecut cel putin 6 luni de la ultima donare. Sunteti eligibil pentru a dona din nou! ☺");
                _notifications.Add("Pista e zeul zeilor");
            }

            var i = 1;
            var startPoint = new Point(6, 19);
            foreach (var notification in _notifications)
            {
                var label = new Label {
                    Name = "notification" + i,
                    Text = notification,
                    Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Italic),
                    AutoSize = true,
                    MaximumSize = new Size(250, 0),
                    Location = new Point(startPoint.X, startPoint.Y + 11)
                };
                NotificationsPanel.Controls.Add(label);
                var separator = new BunifuSeparator {
                    Location = new Point(startPoint.X + 3, label.Location.Y + label.Height + 5),
                    Size = new Size(287, 10)
                };
                NotificationsPanel.Controls.Add(separator);
                ++i;
                startPoint = new Point(startPoint.X, NotificationsPanel.Controls[NotificationsPanel.Controls.Count - 1].Location.Y);
            }
        }

        private bool _toggleMenu = true;

        private void MenuToggle_Click(object sender, EventArgs e)
        {
            if (_toggleMenu)
            {
                MainPanel.SendToBack();
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.ShowSync(MenuPanel);
                MainPanel.Enabled = false;
                _toggleMenu = false;
            }
            else
            {
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.HideSync(MenuPanel);
                MainPanel.BringToFront();
                if (NotificationsPanel.Visible)
                    NotificationsPanel.BringToFront();
                MainPanel.Enabled = true;
                _toggleMenu = true;
            }
        }

        private void MenuToggle_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(MenuToggle, "Toggle Menu");
        }

        private int _toggleBell;

        private void BellMovement_Tick(object sender, EventArgs e)
        {
            if (_toggleBell == 0)
            {
                Bell.Image = Properties.Resources.bellactive2;
                _toggleBell = 1;
            }
            else
            {
                Bell.Image = Properties.Resources.bellactive;
                _toggleBell = 0;
            }
        }

        private int _toggleNotif = 1;

        private void Bell_Click(object sender, EventArgs e)
        {
            if (BellMovement.Enabled)
                BellMovement.Stop();
            if (_toggleNotif == 1)
            {
                Bell.Image = Properties.Resources.bellinactive;
                animator1.AnimationType = AnimationType.VertSlide;
                MainPanel.SendToBack();
                animator1.ShowSync(NotificationsPanel);
                _toggleNotif = 0;
            }
            else
            {
                animator1.AnimationType = AnimationType.VertSlide;
                animator1.HideSync(NotificationsPanel);
                MainPanel.BringToFront();
                if (MenuPanel.Visible)
                    MenuPanel.BringToFront();
                _toggleNotif = 1;
            }
        }

        private void MenuButton1_Click(object sender, EventArgs e)
        {
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(MainPanel);
            MainPanel.Enabled = true;
        }

        private void BtnSubmit_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSubmit.BackColor = Color.White;
            BtnSubmit.ForeColor = Color.DarkRed;
        }

        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            BtnSubmit.BackColor = Color.DarkRed;
            BtnSubmit.ForeColor = Color.White;
        }

        private void MenuButton1_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton1.BackColor = Color.White;
            MenuButton1.ForeColor = Color.DarkRed;
        }

        private void MenuButton1_MouseLeave(object sender, EventArgs e)
        {
            MenuButton1.BackColor = Color.DarkRed;
            MenuButton1.ForeColor = Color.White;
        }

        private void MenuButton2_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton2.BackColor = Color.White;
            MenuButton2.ForeColor = Color.DarkRed;
        }

        private void MenuButton2_MouseLeave(object sender, EventArgs e)
        {
            MenuButton2.BackColor = Color.DarkRed;
            MenuButton2.ForeColor = Color.White;
        }
    }
}
