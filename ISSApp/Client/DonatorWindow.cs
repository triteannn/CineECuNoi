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
            foreach (DataGridViewColumn col in BloodResultsTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            BloodResultsTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            BloodResultsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            BloodResultsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            BloodResultsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            BloodResultsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BloodResultsTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
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

            var centreDonare = _server.CentruDonareFindAll();
            centreDonare.ForEach(x => { DropdownCD.AddItem(x.Denumire); });
            BloodResultsTable.Rows.Clear();
            for (var j = 0; j < 21; ++j)
                BloodResultsTable.Rows.Add();
            BloodResultsTable.Rows[0].Cells[0].Value = "Erythrocytes";
            BloodResultsTable.Rows[0].Cells[3].Value = "4.00 - 5.80";
            BloodResultsTable.Rows[1].Cells[0].Value = "Haemoglobin";
            BloodResultsTable.Rows[1].Cells[3].Value = "11.00 - 17.00";
            BloodResultsTable.Rows[2].Cells[0].Value = "Hematocrit";
            BloodResultsTable.Rows[2].Cells[3].Value = "35.00 - 52.00";
            BloodResultsTable.Rows[3].Cells[0].Value = "VEM";
            BloodResultsTable.Rows[3].Cells[3].Value = "75.00 - 100.00";
            BloodResultsTable.Rows[4].Cells[0].Value = "HEM";
            BloodResultsTable.Rows[4].Cells[3].Value = "25.00 - 33.00";
            BloodResultsTable.Rows[5].Cells[0].Value = "CHEM";
            BloodResultsTable.Rows[5].Cells[3].Value = "31.00 - 36.00";
            BloodResultsTable.Rows[6].Cells[0].Value = "Erythrocytes distribution width";
            BloodResultsTable.Rows[6].Cells[3].Value = "10.00 - 20.00";
            BloodResultsTable.Rows[7].Cells[0].Value = "Platelets";
            BloodResultsTable.Rows[7].Cells[3].Value = "120.00 - 400.00";
            BloodResultsTable.Rows[8].Cells[0].Value = "Average platelets volume";
            BloodResultsTable.Rows[8].Cells[3].Value = "6.00 - 10.00";
            BloodResultsTable.Rows[9].Cells[0].Value = "Trombocrit";
            BloodResultsTable.Rows[9].Cells[3].Value = "0.00 - 0.60";
            BloodResultsTable.Rows[10].Cells[0].Value = "Trmbocrit distribution width";
            BloodResultsTable.Rows[10].Cells[3].Value = "0.00 - 25.00";
            BloodResultsTable.Rows[11].Cells[0].Value = "Leukocytes";
            BloodResultsTable.Rows[11].Cells[3].Value = "4.00 - 10.50";
            BloodResultsTable.Rows[12].Cells[0].Value = "Granulocytes (%)";
            BloodResultsTable.Rows[12].Cells[3].Value = "42.00 - 75.00";
            BloodResultsTable.Rows[13].Cells[0].Value = "Lymphocytes (%)";
            BloodResultsTable.Rows[13].Cells[3].Value = "11.00 - 50.00";
            BloodResultsTable.Rows[14].Cells[0].Value = "MID (EO + MO + BA) %";
            BloodResultsTable.Rows[14].Cells[3].Value = "2.00 - 12.00";
            BloodResultsTable.Rows[15].Cells[0].Value = "Number of granulocytes";
            BloodResultsTable.Rows[15].Cells[3].Value = "2.00 - 8.00";
            BloodResultsTable.Rows[16].Cells[0].Value = "Number of lymphocytes";
            BloodResultsTable.Rows[16].Cells[3].Value = "1.00 - 5.00";
            BloodResultsTable.Rows[17].Cells[0].Value = "Number of MID (EO + MO + BA)";
            BloodResultsTable.Rows[17].Cells[3].Value = "0.00 - 1.40";
            BloodResultsTable.Rows[18].Cells[0].Value = "Glucose";
            BloodResultsTable.Rows[18].Cells[3].Value = "60.00 - 120.00";
            BloodResultsTable.Rows[19].Cells[0].Value = "ALT/TGP";
            BloodResultsTable.Rows[19].Cells[3].Value = "5.00 - 65.00";
            BloodResultsTable.Rows[20].Cells[0].Value = "Cholesterol";
            BloodResultsTable.Rows[20].Cells[3].Value = "110.00 - 220.00";
            BloodResultsTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BloodResultsTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BloodResultsTable.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BloodResultsTable.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private bool _toggleMenu = true;

        private void MenuToggle_Click(object sender, EventArgs e)
        {
            if (_toggleMenu)
            {
                MainPanel.SendToBack();
                BloodTestsPanel.SendToBack();
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.ShowSync(MenuPanel);
                if (MainPanel.Visible)
                    MainPanel.Enabled = false;
                else if (BloodTestsPanel.Visible)
                    BloodTestsPanel.Enabled = false;
                _toggleMenu = false;
            }
            else
            {
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.HideSync(MenuPanel);
                if (MainPanel.Visible)
                {
                    MainPanel.BringToFront();
                    MainPanel.Enabled = true;
                }
                else if (BloodTestsPanel.Visible)
                {
                    BloodTestsPanel.BringToFront();
                    BloodTestsPanel.Enabled = true;
                }
                if (NotificationsPanel.Visible)
                    NotificationsPanel.BringToFront();
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
            _toggleMenu = true;
            if (BloodTestsPanel.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(BloodTestsPanel);
            }
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var boli = "";
            foreach (Control control in DiseasesGb.Controls)
            {
                if (control is BunifuCheckbox aux)
                {
                    if (aux.Checked)
                    {
                        var name = aux.Name;
                        boli += DiseasesGb.Controls["Lbl" + name.Split('k')[1]].Text;
                        boli += ", ";
                    }
                }
            }

            boli = boli.Substring(0, boli.Length - 2);
            if (_loggedAccount.IdD != null)
            {
                //var formularDonare = new FormularDonare(DateTime.Now, boli, (int)_loggedAccount.IdD, TxtDonateFor.Text);
                //_server.FormularDonareAdd(formularDonare);
            }
        }

        private void MenuButton2_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (MainPanel.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(MainPanel);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(BloodTestsPanel);
            BloodTestsPanel.Enabled = true;
        }
    }
}
