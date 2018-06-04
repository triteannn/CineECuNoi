using AnimatorNS;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using System;
using System.ComponentModel;
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
            DonationFormsList.HideSelection = false;
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
                Panel5.SendToBack();
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
                else if (Panel5.Visible)
                    Panel5.Enabled = false;
                _toggleMenu = false;
            }
            else
            {
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.HideSync(MenuPanel);
                if (Panel1.Visible)
                {
                    Panel1.BringToFront();
                    Panel1.Enabled = true;
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
                else if (Panel5.Visible)
                {
                    Panel5.BringToFront();
                    Panel5.Enabled = true;
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
            else if (Panel5.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel5);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel1);
            Panel1.Enabled = true;

            UpdateList();
        }

        private void UpdateList()
        {
            var donationForms = _server.FormularDonareFindAll();

            DonationFormsList.Items.Clear();

            donationForms.ForEach(x => {
                var donator = _server.DonatorFindEntity((int)x.IdD);
                var item = new ListViewItem(new[] {
                    x.DataCreare.ToShortDateString(),
                    donator.Nume,
                    donator.Prenume
                });
                item.Tag = x;
                item.ForeColor = Color.White;
                if (x.Status.Equals("Received"))
                    item.BackColor = Color.DimGray;
                else if (x.Status.Equals("Accepted"))
                    item.BackColor = Color.Green;
                else
                    item.BackColor = Color.DarkRed;
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
            else if (Panel5.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel5);
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
            else if (Panel5.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel5);
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
            else if (Panel5.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel5);
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
            var worker = new BackgroundWorker();

            if (DonationFormsList.SelectedIndices.Count > 0)
            {
                PungaSange punga = null;
                worker.DoWork += (obj, ea) => {
                    var formular = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].Tag;
                    TxtCreationDate.Text = ((FormularDonare)formular).DataCreare.ToShortDateString();
                    TxtFirstName.Text = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].SubItems[2].Text;
                    TxtLastName.Text = DonationFormsList.Items[DonationFormsList.SelectedIndices[0]].SubItems[1].Text;
                    TxtStatus.Text = ((FormularDonare)formular).Status;

                    groupBox3.Enabled = true;

                    if (((FormularDonare)formular).Status.Equals("Received"))
                    {
                        BtnAccept.Enabled = BtnReject.Enabled = true;
                    }
                    else if (((FormularDonare)formular).Status.Equals("Accepted"))
                    {
                        BtnReject.Enabled = true;
                        BtnAccept.Enabled = false;
                    }
                    else
                    {
                        BtnAccept.Enabled = BtnReject.Enabled = false;
                    }

                    var pungi = _server.GetPungaSangeCuCNP(_server.DonatorFindEntity((int)((FormularDonare)formular).IdD).CNP);
                    foreach (var p in pungi)
                    {
                        var actualPunga = _server.PungaSangeFindEntity(p.Id);
                        if (((FormularDonare)formular).Id == _server.FormularDonareFindEntity(actualPunga.IdFd).Id)
                        {
                            punga = actualPunga;
                            break;
                        }
                    }
                };
                worker.RunWorkerAsync();
                worker.RunWorkerCompleted += (obj, ea) => {
                    if (punga == null)
                    {
                        groupBox1.Enabled = true;
                        TxtCollectionDate.Text = "";
                        TxtTarget.Text = "";
                        TxtBloodType.Text = "";
                        TxtRh.Text = "";
                    }
                    else
                    {
                        TxtCollectionDate.Text = punga.DataRecoltare.ToShortDateString();
                        TxtTarget.Text = punga.Target;
                        TxtBloodType.Text = punga.Grupa;
                        TxtRh.Text = punga.Rh;
                        groupBox1.Enabled = false;
                    }
                };
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PungaSange punga = null;
            if (TxtRh.Text.Equals("Positive") || TxtRh.Text.Equals("Negative"))
                if (TxtBloodType.Text.Equals("A") || TxtBloodType.Text.Equals("B") || TxtBloodType.Text.Equals("0") || TxtBloodType.Text.Equals("AB"))
                    if (TxtTarget.Text.Length > 0)
                        if (DateTime.TryParse(TxtCollectionDate.Text, out DateTime date))
                        {
                            var idCd = _server.AngajatFindEntity((int)_loggedAccount.IdAc).IdCd;
                            punga = new PungaSange(date, TxtBloodType.Text, TxtRh.Text, TxtTarget.Text, (int)idCd, ((FormularDonare)DonationFormsList.SelectedItems[0].Tag).Id);
                            _server.PungaSangeAdd(punga);
                        }
            if (punga != null)
            {
                MessageBox.Show("Blood bag added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Enabled = false;
            }
            else
                MessageBox.Show("Blood bag was not added successfully.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            var formular = ((FormularDonare)DonationFormsList.SelectedItems[0].Tag);
            formular.Status = "Accepted";
            try
            {
                var index = DonationFormsList.SelectedIndices[0];
                _server.FormularDonareUpdate(formular);
                UpdateList();
                DonationFormsList.SelectedIndices.Add(index);
            } catch (NetworkingException ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            var formular = ((FormularDonare)DonationFormsList.SelectedItems[0].Tag);
            formular.Status = "Rejected";
            try
            {
                var index = DonationFormsList.SelectedIndices[0];
                _server.FormularDonareUpdate(formular);
                UpdateList();
                DonationFormsList.SelectedIndices.Add(index);
            } catch (NetworkingException ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuButton5_Click(object sender, EventArgs e)
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
            else if (Panel4.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(Panel4);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(Panel5);
            Panel5.Enabled = true;
        }

        private void MenuButton5_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton5.BackColor = Color.White;
            MenuButton5.ForeColor = Color.DarkRed;
        }

        private void MenuButton5_MouseLeave(object sender, EventArgs e)
        {
            MenuButton5.BackColor = Color.DarkRed;
            MenuButton5.ForeColor = Color.White;
        }

        private void BtnAdd1_MouseLeave(object sender, EventArgs e)
        {
            BtnAdd1.BackColor = Color.DarkRed;
            BtnAdd1.ForeColor = Color.White;
        }

        private void BtnAdd1_MouseMove(object sender, MouseEventArgs e)
        {
            BtnAdd1.BackColor = Color.White;
            BtnAdd1.ForeColor = Color.DarkRed;
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DropdownComponents.selectedIndex != 0)
                {
                    if (DateTime.TryParse(TxtExpirationDate.Text, out DateTime date))
                    {
                        if (float.TryParse(TxtQuantity.Text, out float quantity))
                        {
                            if (TxtBloodType1.Text.Equals("A") || TxtBloodType1.Text.Equals("B") || TxtBloodType1.Text.Equals("0") || TxtBloodType1.Text.Equals("AB"))
                            {
                                if (TxtRh1.Text.Equals("Negative") || TxtRh1.Text.Equals("Positive"))
                                {
                                    var idCd = _server.AngajatFindEntity((int)_loggedAccount.IdAc).IdCd;
                                    if (DropdownComponents.selectedIndex == 1)
                                    {
                                        if (TxtTarget.Text != "")
                                            _server.TrombociteAdd(new PSTrombocite(quantity, TxtTarget.Text, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        else
                                            _server.TrombociteAdd(new PSTrombocite(quantity, null, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        MessageBox.Show("Blood product added successfully.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else if (DropdownComponents.selectedIndex == 2)
                                    {
                                        if (TxtTarget.Text != "")
                                            _server.PlasmaAdd(new PSPlasma(quantity, TxtTarget.Text, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        else
                                            _server.PlasmaAdd(new PSPlasma(quantity, null, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        MessageBox.Show("Blood product added successfully.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if (TxtTarget.Text != "")
                                            _server.GlobuleRosiiAdd(new PSGlobuleRosii(quantity, TxtTarget.Text, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        else
                                            _server.GlobuleRosiiAdd(new PSGlobuleRosii(quantity, null, date, TxtBloodType1.Text, TxtRh1.Text, idCd));
                                        MessageBox.Show("Blood product added successfully.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                    MessageBox.Show("Incorrect Rh.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Incorrect Blood Type.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Incorrect Quantity.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Incorrect Date.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please select a blood product.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (NetworkingException)
            {
                MessageBox.Show("Could not add the product.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
