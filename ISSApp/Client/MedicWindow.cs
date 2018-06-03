using AnimatorNS;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
    public partial class MedicWindow : Form
    {
        private readonly LoginForm _loginForm;
        private readonly IServer _server;
        private readonly Account _loggedAccount;
        private readonly MedicService _medicService;

        public MedicWindow(LoginForm loginForm, IServer server, Account account)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _loggedAccount = account;
            _server = server;
            _medicService = new MedicService(_server);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MedicWindow_FormClosing(object sender, FormClosingEventArgs e)
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

        private bool _toggleMenu = true;

        private void MenuToggle_Click(object sender, EventArgs e)
        {
            if (_toggleMenu)
            {
                RequestsPanel.SendToBack();
                MainPanel.SendToBack();
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.ShowSync(MenuPanel);
                if (RequestsPanel.Visible)
                    RequestsPanel.Enabled = false;
                else if (MainPanel.Visible)
                    MainPanel.Enabled = false;
                _toggleMenu = false;
            }
            else
            {
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.HideSync(MenuPanel);
                if (RequestsPanel.Visible)
                {
                    RequestsPanel.BringToFront();
                    RequestsPanel.Enabled = true;
                }
                else if (MainPanel.Visible)
                {
                    MainPanel.BringToFront();
                    MainPanel.Enabled = true;
                }
                _toggleMenu = true;
            }
        }

        private void MenuToggle_MouseHover(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(MenuToggle, "Toggle Menu");
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

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + e.ClipRectangle.Height - 4), new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + 4));
            base.OnPaint(e);
        }

        private void MenuButton1_Click(object sender, EventArgs e)
        {
            _toggleMenu = true;
            if (RequestsPanel.Visible)
            {
                animator1.AnimationType = AnimationType.Scale;
                animator1.HideSync(RequestsPanel);
            }
            animator1.AnimationType = AnimationType.HorizSlide;
            animator1.HideSync(MenuPanel);
            animator1.AnimationType = AnimationType.Scale;
            animator1.ShowSync(MainPanel);
            MainPanel.Enabled = true;
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
            animator1.ShowSync(RequestsPanel);
            RequestsPanel.Enabled = true;
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MedicWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (!_toggleMenu)
                MenuToggle_Click(MenuToggle, null);

            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void MedicWindow_Load(object sender, EventArgs e)
        {
            //var doctor = _server.MedicFindByIdAccount(_loggedAccount.Id);
            label1.Text = @"Logged in as " + _loggedAccount.Username;//+ doctor.Nume + " " + doctor.Prenume;
        }

        private CentruDonare centruDonare;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BtnSubmit.Enabled = false;
            if (Radio1.Checked)
            {
                centruDonare = null;
                var globuleRosii = _server.GlobuleRosiiFindByTarget(TxtPacient.Text);
                var plasma = _server.PlasmaFindByTarget(TxtPacient.Text);
                var trombocite = _server.TrombociteFindByTarget(TxtPacient.Text);
                var tupluGlobuleRosii = new List<Tuple<CentruDonare, double>>();
                var tupluPlasma = new List<Tuple<CentruDonare, double>>();
                var tupluTrombocite = new List<Tuple<CentruDonare, double>>();

                foreach (var gr in globuleRosii)
                {
                    var centru = _server.CentruDonareFindEntity((int)gr.IdCD);
                    Tuple<CentruDonare, double> found = null;
                    foreach (var tup in tupluGlobuleRosii)
                    {
                        if (tup.Item1.Id == centru.Id)
                        {
                            found = tup;
                            break;
                        }
                    }
                    double item = new double();
                    if (found == null)
                        tupluGlobuleRosii.Add(new Tuple<CentruDonare, double>(centru, gr.Cantitate));
                    else
                    {
                        item = found.Item2;
                        item += gr.Cantitate;
                        tupluGlobuleRosii.Remove(found);
                        tupluGlobuleRosii.Add(new Tuple<CentruDonare, double>(centru, item));
                    }
                }
                foreach (var p in plasma)
                {
                    var centru = _server.CentruDonareFindEntity((int)p.IdCD);
                    Tuple<CentruDonare, double> found = null;
                    foreach (var tup in tupluPlasma)
                    {
                        if (tup.Item1.Id == centru.Id)
                        {
                            found = tup;
                            break;
                        }
                    }
                    double item = new double();
                    if (found == null)
                        tupluPlasma.Add(new Tuple<CentruDonare, double>(centru, p.Cantitate));
                    else
                    {
                        item = found.Item2;
                        item += p.Cantitate;
                        tupluPlasma.Remove(found);
                        tupluPlasma.Add(new Tuple<CentruDonare, double>(centru, item));
                    }
                }
                foreach (var t in trombocite)
                {
                    var centru = _server.CentruDonareFindEntity((int)t.IdCD);
                    Tuple<CentruDonare, double> found = null;
                    foreach (var tup in tupluTrombocite)
                    {
                        if (tup.Item1.Id == centru.Id)
                        {
                            found = tup;
                            break;
                        }
                    }
                    double item = new double();
                    if (found == null)
                        tupluTrombocite.Add(new Tuple<CentruDonare, double>(centru, t.Cantitate));
                    else
                    {
                        item = found.Item2;
                        item += t.Cantitate;
                        tupluTrombocite.Remove(found);
                        tupluTrombocite.Add(new Tuple<CentruDonare, double>(centru, item));
                    }
                }
                tupluGlobuleRosii.Sort((x, y) => {
                    return x.Item1.Id.CompareTo(y.Item1.Id);
                });
                tupluPlasma.Sort((x, y) => {
                    return x.Item1.Id.CompareTo(y.Item1.Id);
                });
                tupluTrombocite.Sort((x, y) => {
                    return x.Item1.Id.CompareTo(y.Item1.Id);
                });
                for (var i = 0; i < tupluGlobuleRosii.Count; i++)
                {
                    if (tupluGlobuleRosii[i].Item2.CompareTo(double.Parse(TxtErythrocytes.Text)) > -1 && tupluPlasma[i].Item2.CompareTo(double.Parse(TxtPlasma.Text)) > -1 && tupluTrombocite[i].Item2.CompareTo(double.Parse(TxtPlatelets.Text)) > -1)
                    {
                        centruDonare = tupluGlobuleRosii[i].Item1;
                        TxtSearchResult.Text = centruDonare.Denumire;
                        break;
                    }
                }
                if (centruDonare == null)
                {
                    TxtSearchResult.Text = "No results found.";
                    BtnSubmit.Enabled = false;
                }
                else
                    BtnSubmit.Enabled = true;
            }
            else if (Radio2.Checked)
            {
                var spital = _server.SpitalFindEntity(_server.MedicFindEntity((int)_loggedAccount.IdM).Id);
                var spitalAdr = _server.AdresaFindEntity(spital.IdAdr);
                var centre = _server.CentruDonareFindAll();
                centre.Sort((x, y) => {
                    return Adresa.DistantaIntreAdrese(_server.AdresaFindEntity((int)x.IdAdr), spitalAdr).CompareTo(Adresa.DistantaIntreAdrese(_server.AdresaFindEntity((int)y.IdAdr), spitalAdr));
                });
                CentruDonare found = null;

                foreach (var c in centre)
                {
                    double sumaGR = 0;
                    foreach (var ps in _server.GlobuleRosiiFindAllByCentru(c.Id))
                    {
                        sumaGR += ps.Cantitate;
                    }
                    double sumaP = 0;
                    foreach (var ps in _server.PlasmaFindAllByCentru(c.Id))
                    {
                        sumaP += ps.Cantitate;
                    }
                    double sumaT = 0;
                    foreach (var ps in _server.TrombociteFindAllByCentru(c.Id))
                    {
                        sumaT += ps.Cantitate;
                    }
                    if (double.Parse(TxtErythrocytes.Text).CompareTo(sumaGR) <= 0 && double.Parse(TxtPlasma.Text).CompareTo(sumaP) <= 0 && double.Parse(TxtPlatelets.Text).CompareTo(sumaT) <= 0)
                    {
                        found = c;
                        break;
                    }
                }
                if (found == null)
                {
                    TxtSearchResult.Text = "No results found.";
                    BtnSubmit.Enabled = false;
                }
                else
                {
                    TxtSearchResult.Text = found.Denumire;
                    centruDonare = found;
                    BtnSubmit.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("You haven't selected a search criteria.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnSearch_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSearch.BackColor = Color.White;
            BtnSearch.ForeColor = Color.DarkRed;
        }

        private void BtnSearch_MouseLeave(object sender, EventArgs e)
        {
            BtnSearch.BackColor = Color.DarkRed;
            BtnSearch.ForeColor = Color.White;
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Status: Requested, Sent, Received, Cancelled, Rejected
            try
            {
                var formularCerere = new FormularCerere(TxtPacient.Text, double.Parse(TxtPlatelets.Text), double.Parse(TxtPlasma.Text), double.Parse(TxtErythrocytes.Text), (int)_loggedAccount.IdM, "Requested", TxtBloodType.Text, TxtRh.Text, centruDonare.Id);
                _server.FormularCerereAdd(formularCerere);
                MessageBox.Show("Your request has been submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}