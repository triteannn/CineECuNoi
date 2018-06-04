using AnimatorNS;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Networking;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
    public partial class EmployeeWindow : Form
    {
        private readonly LoginForm _loginForm;
        private readonly IServer _server;
        private readonly AngajatService _angajatService;
        private readonly Account _loggedAccount;

        public EmployeeWindow(LoginForm loginForm, IServer server, Account loggedAccount)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
            _angajatService = new AngajatService(_server);
            _loggedAccount = loggedAccount;
            DonationFormsList.FullRowSelect = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EmployeeWindow_Load(object sender, EventArgs e)
        {
            var employee = _server.AngajatFindEntity((int)_loggedAccount.IdAc);
            label1.Text = @"Logged in as " + employee.Nume + " " + employee.Prenume;
        }

        private void EmployeeWindow_FormClosing(object sender, FormClosingEventArgs e)
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

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void EmployeeWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (!_toggleMenu)
                MenuToggle_Click(MenuToggle, null);

            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
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

        private void MenuButton3_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton3.BackColor = Color.White;
            MenuButton3.ForeColor = Color.DarkRed;
        }

        private void MenuButton3_MouseLeave(object sender, EventArgs e)
        {
            MenuButton3.BackColor = Color.DarkRed;
            MenuButton3.ForeColor = Color.White;
        }

        private void MenuButton4_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton4.BackColor = Color.White;
            MenuButton4.ForeColor = Color.DarkRed;
        }

        private void MenuButton4_MouseLeave(object sender, EventArgs e)
        {
            MenuButton4.BackColor = Color.DarkRed;
            MenuButton4.ForeColor = Color.White;
        }

        private bool _toggleMenu = true;

        private void MenuToggle_Click(object sender, EventArgs e)
        {
            if (_toggleMenu)
            {
                Panel1.SendToBack();
                Panel2.SendToBack();
                Panel3.SendToBack();
                Panel4.SendToBack();
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.ShowSync(MenuPanel);
                if (Panel1.Visible)
                    Panel1.Enabled = false;
                else if (Panel2.Visible)
                    Panel2.Enabled = false;
                else if (Panel3.Visible)
                    Panel3.Enabled = false;
                else if (Panel4.Visible)
                    Panel4.Enabled = false;
                _toggleMenu = false;
            }
            else
            {
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.HideSync(MenuPanel);
                if (Panel1.Visible)
                {
                    if (Panel1.Enabled)
                    {
                        Panel1.BringToFront();
                        Panel1.Enabled = true;
                    }
                }
                else if (Panel2.Visible)
                {
                    Panel2.BringToFront();
                    Panel2.Enabled = true;
                }
                else if (Panel3.Visible)
                {
                    Panel3.BringToFront();
                    Panel3.Enabled = true;
                }
                else if (Panel4.Visible)
                {
                    Panel4.BringToFront();
                    Panel4.Enabled = true;
                }
                _toggleMenu = true;
            }
        }

        private void MenuToggle_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(MenuToggle, "Toggle Menu");
        }

        private void MenuButton1_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (Panel2.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel2);
            }
            else if (Panel3.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel3);
            }
            else if (Panel4.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel4);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel1);
            Panel1.Enabled = true;

            var donationForms = _server.FormularDonareFindAll();

            donationForms.ForEach(x => {
                var donator = _server.DonatorFindEntity((int)x.IdD);
                var item = new ListViewItem(new[] {
                    x.DataCreare.ToShortDateString(),
                    donator.Nume,
                    donator.Prenume
                });
                item.Tag = x;
                DonationFormsList.Items.Add(item);
            });


        }

        private void MenuButton2_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (Panel1.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel1);
            }
            else if (Panel3.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel3);
            }
            else if (Panel4.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel4);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel2);
            Panel2.Enabled = true;
        }

        private void MenuButton3_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (Panel1.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel1);
            }
            else if (Panel2.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel2);
            }
            else if (Panel4.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel4);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel3);
            Panel3.Enabled = true;
        }

        private void MenuButton4_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (Panel1.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel1);
            }
            else if (Panel2.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel2);
            }
            else if (Panel3.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel3);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel4);
            Panel4.Enabled = true;
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + e.ClipRectangle.Height - 4), new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + 1));
            base.OnPaint(e);
        }

        private void DonationFormsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DonationFormsList.SelectedIndices.Count > 0)
            {
                var formular = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].Tag;
                TxtCreationDate.Text = ((FormularDonare)formular).DataCreare.ToShortDateString();
                TxtFirstName.Text = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].SubItems[2].Text;
                TxtLastName.Text = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].SubItems[1].Text;
                TxtStatus.Text = ((FormularDonare)formular).Status;
            }
        }
    }
}
