using AnimatorNS;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using System;
using System.Collections.Generic;
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
        private bool _searchForDonators;

        public EmployeeWindow(LoginForm loginForm, IServer server, Account loggedAccount)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
            _angajatService = new AngajatService(_server);
            _loggedAccount = loggedAccount;
            DonationFormsList.FullRowSelect = true;
            DonationFormsList.HideSelection = false;
            DonationFormsList1.FullRowSelect = true;
            DonationFormsList1.HideSelection = false;
            _searchForDonators = false;
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


            if (_server.CentruDonareFindEntity((int)_server.AngajatFindEntity((int)_loggedAccount.IdAc).IdCd).NeedBlood == 0)
            {
                _searchForDonators = false;
                SwitchSearchDonators.BackColor = Color.DimGray;
                SwitchSearchDonators.Text = "Off";
            }
            else
            {
                _searchForDonators = true;
                SwitchSearchDonators.BackColor = Color.Green;
                SwitchSearchDonators.Text = "On";
            }
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

        private void BtnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            BtnDelete.BackColor = Color.White;
            BtnDelete.ForeColor = Color.DarkRed;
        }

        private void BtnDelete_MouseLeave(object sender, EventArgs e)
        {
            BtnDelete.BackColor = Color.DarkRed;
            BtnDelete.ForeColor = Color.White;
        }

        private void BtnReject_MouseMove(object sender, MouseEventArgs e)
        {
            BtnReject.BackColor = Color.White;
            BtnReject.ForeColor = Color.DarkRed;
        }

        private void BtnReject_MouseLeave(object sender, EventArgs e)
        {
            BtnReject.BackColor = Color.DarkRed;
            BtnReject.ForeColor = Color.White;
        }

        private void BtnAccept_MouseMove(object sender, MouseEventArgs e)
        {
            BtnAccept.BackColor = Color.White;
            BtnAccept.ForeColor = Color.DarkRed;
        }

        private void BtnAccept_MouseLeave(object sender, EventArgs e)
        {
            BtnAccept.BackColor = Color.DarkRed;
            BtnAccept.ForeColor = Color.White;
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

            var donationForms = _server.FormularDonareFindAll();

            DonationFormsList1.Items.Clear();

            donationForms.ForEach(x => {
                if (x.IdAn == null)
                {
                    var donator = _server.DonatorFindEntity((int)x.IdD);
                    var item = new ListViewItem(new[] {
                        x.DataCreare.ToShortDateString(),
                        donator.Nume,
                        donator.Prenume
                    });
                    item.Tag = x;

                    DonationFormsList1.Items.Add(item);
                }
            });

            BloodResultsTable.Rows.Clear();
            for (var j = 0; j < 21; ++j)
                BloodResultsTable.Rows.Add();
            BloodResultsTable.Rows[0].Cells[0].Value = "Erythrocytes";
            BloodResultsTable.Rows[1].Cells[0].Value = "Haemoglobin";
            BloodResultsTable.Rows[2].Cells[0].Value = "Hematocrit";
            BloodResultsTable.Rows[3].Cells[0].Value = "VEM";
            BloodResultsTable.Rows[4].Cells[0].Value = "HEM";
            BloodResultsTable.Rows[5].Cells[0].Value = "CHEM";
            BloodResultsTable.Rows[6].Cells[0].Value = "Erythrocytes distribution width";
            BloodResultsTable.Rows[7].Cells[0].Value = "Platelets";
            BloodResultsTable.Rows[8].Cells[0].Value = "Average platelets volume";
            BloodResultsTable.Rows[9].Cells[0].Value = "Trombocrit";
            BloodResultsTable.Rows[10].Cells[0].Value = "Trmbocrit distribution width";
            BloodResultsTable.Rows[11].Cells[0].Value = "Leukocytes";
            BloodResultsTable.Rows[12].Cells[0].Value = "Granulocytes (%)";
            BloodResultsTable.Rows[13].Cells[0].Value = "Lymphocytes (%)";
            BloodResultsTable.Rows[14].Cells[0].Value = "MID (EO + MO + BA) %";
            BloodResultsTable.Rows[15].Cells[0].Value = "Number of granulocytes";
            BloodResultsTable.Rows[16].Cells[0].Value = "Number of lymphocytes";
            BloodResultsTable.Rows[17].Cells[0].Value = "Number of MID (EO + MO + BA)";
            BloodResultsTable.Rows[18].Cells[0].Value = "Glucose";
            BloodResultsTable.Rows[19].Cells[0].Value = "ALT/TGP";
            BloodResultsTable.Rows[20].Cells[0].Value = "Cholesterol";
            BloodResultsTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BloodResultsTable.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void LoadBloodBags()
        {
            TxtCollectionDate2.Text = TxtTarget2.Text = TxtBloodType2.Text = TxtRh2.Text = "";
            BloodBagsTable.Rows.Clear();
            var i = 0;
            foreach (var bloodBag in _server.PungaSangeFindAll())
            {
                BloodBagsTable.Rows.Add();
                BloodBagsTable.Rows[i].Cells[0].Value = bloodBag.Id;
                BloodBagsTable.Rows[i].Cells[1].Value = bloodBag.DataRecoltare.ToShortDateString();
                BloodBagsTable.Rows[i].Cells[2].Value = bloodBag.Target;
                BloodBagsTable.Rows[i].Cells[3].Value = bloodBag.Grupa;
                BloodBagsTable.Rows[i++].Cells[4].Value = bloodBag.Rh;
            }
            BloodBagsTable.ClearSelection();
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

            LoadBloodBags();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + e.ClipRectangle.Height - 4), new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + 4));
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
                        BtnDelete.Enabled = true;
                    }
                    else if (((FormularDonare)formular).Status.Equals("Accepted"))
                    {
                        BtnReject.Enabled = true;
                        BtnAccept.Enabled = false;
                        BtnDelete.Enabled = false;
                    }
                    else
                    {
                        BtnAccept.Enabled = BtnReject.Enabled = false;
                        BtnDelete.Enabled = false;
                    }

                    var pungi = _server.GetPungaSangeCuCNP(_server.DonatorFindEntity((int)((FormularDonare)formular).IdD).CNP);
                    foreach (var p in pungi)
                    {
                        var actualPunga = _server.PungaSangeFindEntity(p.Id);
                        if (((FormularDonare)formular).Id == _server.FormularDonareFindEntity((int)actualPunga.IdFd).Id)
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

        private void BtnConfirm_MouseLeave(object sender, EventArgs e)
        {
            BtnConfirm.BackColor = Color.DarkRed;
            BtnConfirm.ForeColor = Color.White;
        }

        private void BtnConfirm_MouseMove(object sender, MouseEventArgs e)
        {
            BtnConfirm.BackColor = Color.White;
            BtnConfirm.ForeColor = Color.DarkRed;
        }

        private void UpdateAnalizaUI()
        {
            TxtDiseases.Text = "";

            var donationForms = _server.FormularDonareFindAll();

            DonationFormsList1.Items.Clear();

            donationForms.ForEach(x => {
                if (x.IdAn == null)
                {
                    var donator = _server.DonatorFindEntity((int)x.IdD);
                    var item = new ListViewItem(new[] {
                        x.DataCreare.ToShortDateString(),
                        donator.Nume,
                        donator.Prenume
                    });
                    item.Tag = x;

                    DonationFormsList1.Items.Add(item);
                }
            });

            BloodResultsTable.Rows.Clear();
            for (var j = 0; j < 21; ++j)
                BloodResultsTable.Rows.Add();
            BloodResultsTable.Rows[0].Cells[0].Value = "Erythrocytes";
            BloodResultsTable.Rows[1].Cells[0].Value = "Haemoglobin";
            BloodResultsTable.Rows[2].Cells[0].Value = "Hematocrit";
            BloodResultsTable.Rows[3].Cells[0].Value = "VEM";
            BloodResultsTable.Rows[4].Cells[0].Value = "HEM";
            BloodResultsTable.Rows[5].Cells[0].Value = "CHEM";
            BloodResultsTable.Rows[6].Cells[0].Value = "Erythrocytes distribution width";
            BloodResultsTable.Rows[7].Cells[0].Value = "Platelets";
            BloodResultsTable.Rows[8].Cells[0].Value = "Average platelets volume";
            BloodResultsTable.Rows[9].Cells[0].Value = "Trombocrit";
            BloodResultsTable.Rows[10].Cells[0].Value = "Trmbocrit distribution width";
            BloodResultsTable.Rows[11].Cells[0].Value = "Leukocytes";
            BloodResultsTable.Rows[12].Cells[0].Value = "Granulocytes (%)";
            BloodResultsTable.Rows[13].Cells[0].Value = "Lymphocytes (%)";
            BloodResultsTable.Rows[14].Cells[0].Value = "MID (EO + MO + BA) %";
            BloodResultsTable.Rows[15].Cells[0].Value = "Number of granulocytes";
            BloodResultsTable.Rows[16].Cells[0].Value = "Number of lymphocytes";
            BloodResultsTable.Rows[17].Cells[0].Value = "Number of MID (EO + MO + BA)";
            BloodResultsTable.Rows[18].Cells[0].Value = "Glucose";
            BloodResultsTable.Rows[19].Cells[0].Value = "ALT/TGP";
            BloodResultsTable.Rows[20].Cells[0].Value = "Cholesterol";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (DonationFormsList1.SelectedIndices.Count < 1)
            {
                //Message
            }
            else
            {
                var count = 0;
                FormularDonare formular;
                var boli = "";
                var dt = new DateTime();
                List<PungaSange> ps = new List<PungaSange>();
                foreach (DataGridViewRow row in BloodResultsTable.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "")
                    {
                        count++;
                        break;
                    }
                }
                if (count > 0)
                    count = 2;
                //Message
                else
                {
                    try
                    {
                        formular = (FormularDonare)DonationFormsList1.SelectedItems[0].Tag;
                        boli = TxtDiseases.Text;
                        ps = _server.PungaSangeFindAll();
                        foreach (var p in ps)
                        {
                            if (p.IdFd == formular.Id)
                            {
                                dt = p.DataRecoltare;
                                break;
                            }
                        }

                        _server.AnalizaAdd(new Analiza(dt, double.Parse(BloodResultsTable.Rows[0].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[1].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[2].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[3].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[4].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[5].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[6].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[7].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[8].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[9].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[10].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[11].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[12].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[13].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[14].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[15].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[16].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[17].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[18].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[19].Cells[1].Value.ToString()), double.Parse(BloodResultsTable.Rows[20].Cells[1].Value.ToString()), boli));
                        formular.IdAn = _server.AnalizaFindLastEntity().Id;
                        _server.FormularDonareUpdate(formular);
                        UpdateAnalizaUI();
                        MessageBox.Show("Your action has been completed successfully.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } catch (NetworkingException)
                    {
                        MessageBox.Show("Could not perform action.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var toDelete = (FormularDonare)DonationFormsList.SelectedItems[0].Tag;
                DialogResult ask = MessageBox.Show("Do you really want to delete this donation form?", "Are you sure?", MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    _server.FormularDonareDelete(toDelete);
                    UpdateList();
                }
            } catch
            {
                MessageBox.Show("Could not perform action.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SwitchSearchDonators_Click(object sender, EventArgs e)
        {
            if (_searchForDonators)
            {
                try
                {
                    _searchForDonators = false;
                    SwitchSearchDonators.BackColor = Color.DimGray;
                    SwitchSearchDonators.Text = "Off";
                    CentruDonare centru = _server.CentruDonareFindEntity((int)_server.AngajatFindEntity((int)_loggedAccount.IdAc).IdCd);
                    centru.NeedBlood = 0;
                    _server.CentruDonareUpdate(centru);
                } catch (NetworkingException)
                {
                    _searchForDonators = true;
                    SwitchSearchDonators.BackColor = Color.Green;
                    SwitchSearchDonators.Text = "On";
                    MessageBox.Show("Can't search right now.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    _searchForDonators = true;
                    SwitchSearchDonators.BackColor = Color.Green;
                    SwitchSearchDonators.Text = "On";
                    CentruDonare centru = _server.CentruDonareFindEntity((int)_server.AngajatFindEntity((int)_loggedAccount.IdAc).IdCd);
                    centru.NeedBlood = 1;
                    _server.CentruDonareUpdate(centru);
                } catch (NetworkingException)
                {
                    _searchForDonators = false;
                    SwitchSearchDonators.BackColor = Color.DimGray;
                    SwitchSearchDonators.Text = "Off";
                    MessageBox.Show("Can't search right now.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BloodBagsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = BloodBagsTable.SelectedRows[0];
            TxtCollectionDate2.Text = row.Cells[1].Value.ToString();
            TxtTarget2.Text = row.Cells[2].Value.ToString();
            TxtBloodType2.Text = row.Cells[3].Value.ToString();
            TxtRh2.Text = row.Cells[4].Value.ToString();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (TxtPlatelets.Text.Length > 0 && TxtPlasma.Text.Length > 0 && TxtErythrocytes.Text.Length > 0)
            {
                if (float.TryParse(TxtPlatelets.Text, out float plateletsQty) && float.TryParse(TxtPlasma.Text, out float plasmaQty) && float.TryParse(TxtErythrocytes.Text, out float erythrocytesQty))
                {
                    var punga = _server.PungaSangeFindEntity(int.Parse(BloodBagsTable.SelectedRows[0].Cells[0].Value.ToString()));
                    var erythrocytes = new PSGlobuleRosii(erythrocytesQty, TxtTarget2.Text, punga.DataRecoltare.AddDays(42), TxtBloodType2.Text, TxtRh2.Text, punga.IdCd);
                    var plasma = new PSPlasma(plasmaQty, TxtTarget2.Text, punga.DataRecoltare.AddMonths(12), TxtBloodType2.Text, TxtRh2.Text, punga.IdCd);
                    var platelets = new PSTrombocite(plateletsQty, TxtTarget2.Text, punga.DataRecoltare.AddDays(5), TxtBloodType2.Text, TxtRh2.Text, punga.IdCd);
                    _server.GlobuleRosiiAdd(erythrocytes);
                    _server.PlasmaAdd(plasma);
                    _server.TrombociteAdd(platelets);
                    _server.PungaSangeDelete(punga);
                    LoadBloodBags();
                    TxtPlatelets.Text = TxtPlasma.Text = TxtErythrocytes.Text = "";
                    MessageBox.Show("Action completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("All quantities must be floating point numbers.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("All quantities must be filled.", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
