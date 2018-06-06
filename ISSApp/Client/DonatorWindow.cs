using AnimatorNS;
using Bunifu.Framework.UI;
using Client.Service;
using ISSApp.Domain;
using ISSApp.Exceptions;
using ISSApp.Networking;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class DonatorWindow : Form
    {

        private readonly LoginForm _loginForm;
        private readonly IServer _server;
        private readonly DonatorService _donatorService;
        private readonly Account _loggedAccount;
        private List<string> _notifications;
        private List<Analiza> _analize;
        private int _pagAnaliza;
        private readonly List<string> _picList;

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

            BtnPrevious.FlatAppearance.BorderSize = 0;
            BtnNext.FlatAppearance.BorderSize = 0;

            _picList = new List<string> {
                Environment.CurrentDirectory.Replace(@"bin\Debug", @"Resources\bg1.png"),
                Environment.CurrentDirectory.Replace(@"bin\Debug", @"Resources\bg2.png"),
                Environment.CurrentDirectory.Replace(@"bin\Debug", @"Resources\bg3.png")
            };
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

        private void DonatorWindow_MouseDown(object sender, MouseEventArgs e)
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
            pictureBox1.LoadAsync(_picList[0]);
            Text = @"Donator Window";
            var donator = _server.DonatorFindByIdAccount(_loggedAccount.Id);
            label2.Text = @"Logged in as " + donator.Nume + " " + donator.Prenume;

            try
            {
                if (!_donatorService.PoateCreaFormular((int)_loggedAccount.IdD))
                {
                    LblDonate.Text = "*You can not donate yet.";
                    BtnSubmit.BackColor = Color.DimGray;
                }
                else
                {
                    BtnSubmit.BackColor = Color.DarkRed;
                    LblDonate.Text = "";
                }
            } catch (ServiceException)
            {
                BtnSubmit.BackColor = Color.DarkRed;
                LblDonate.Text = "";
            }

            try
            {
                if (_donatorService.poateDona((int)_loggedAccount.IdD))
                {
                    _notifications.Add("Au trecut cel putin 6 luni de la ultima donare. Sunteti eligibil pentru a dona din nou! ☺");
                }
            } catch (ServiceException)
            {

            }
            if (_donatorService.NevoieSangeCentru((int)_loggedAccount.IdD))
            {
                _notifications.Add("Centrul de donare la care ati donat ultima data are mare nevoie de sange!");
            }
            if (_notifications.Count > 0)
            {
                BellMovement.Enabled = true;
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
                    MaximumSize = new Size(240, 0),
                    Location = new Point(startPoint.X, startPoint.Y + 11)
                };
                NotificationsPanel.Controls.Add(label);
                var separator = new BunifuSeparator {
                    Location = new Point(startPoint.X + 3, label.Location.Y + label.Height + 5),
                    Size = new Size(220, 10),
                    BorderStyle = BorderStyle.None
                };
                var pen = new Pen(SystemColors.Control);
                separator.Paint += (sender1, e1) => {
                    e1.Graphics.DrawRectangle(pen,
                    e1.ClipRectangle.Left,
                    e1.ClipRectangle.Top,
                    e1.ClipRectangle.Width - 1,
                    e1.ClipRectangle.Height - 1);
                    base.OnPaint(e1);
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
                Screensaver.Stop();
                if (pictureBox1.Visible)
                {
                    animator2.HideSync(pictureBox1);
                    pictureBox1.SendToBack();
                }
                MainPanel.SendToBack();
                BloodTestsPanel.SendToBack();
                animator1.AnimationType = AnimationType.HorizSlide;
                animator1.WaitAllAnimations();
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
                    if (MainPanel.Enabled)
                    {
                        MainPanel.BringToFront();
                        MainPanel.Enabled = true;
                    }
                }
                else if (BloodTestsPanel.Visible)
                {
                    BloodTestsPanel.BringToFront();
                    BloodTestsPanel.Enabled = true;
                }
                if (NotificationsPanel.Visible)
                    NotificationsPanel.BringToFront();
                _toggleMenu = true;
                if (_toggleNotif == 1)
                {
                    pictureBox1.LoadAsync(_picList[0]);
                }
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
                Screensaver.Stop();
                if (pictureBox1.Visible)
                {
                    animator2.HideSync(pictureBox1);
                    pictureBox1.SendToBack();
                }
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
                if (_toggleMenu)
                {
                    pictureBox1.LoadAsync(_picList[0]);
                }
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
            try
            {
                if (!_donatorService.PoateCreaFormular((int)_loggedAccount.IdD))
                    MainPanel.Enabled = false;
                else
                    MainPanel.Enabled = true;
            } catch (ServiceException)
            {
                MainPanel.Enabled = true;
            }
            var donator = _server.DonatorFindByUsername(_loggedAccount.Username);
            TxtFirstName.Text = donator.Prenume;
            TxtLastName.Text = donator.Nume;
            TxtDob.Text = donator.Dob.ToShortDateString();
            var dateContact = _server.DateContactGetDateByIdDonator((int)_loggedAccount.IdD);
            if (dateContact != null)
            {
                TxtPhone.Text = dateContact.Telefon;
                TxtEmail.Text = dateContact.Email;
                var adresa = _server.AdresaGetAdresaByDateContactId(dateContact.Id);
                if (adresa != null)
                {
                    TxtAddress.Text = adresa.Strada + " " + adresa.Numar;
                    TxtCity.Text = adresa.Oras;
                    TxtCounty.Text = adresa.Judet;
                }
            }
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

        private async Task<Tuple<double, double>> GetLatAndLng(Adresa adresa)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(new Uri("https://maps.googleapis.com/maps/api/geocode/json?address=" + adresa.Strada + "+" + adresa.Numar + "+" + adresa.Oras + "+" + adresa.Judet + "&key=AIzaSyDzrWge-cBKSAeDF23KQq28tMAhtFSJOeo"));
            var jsonObject = (JObject)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            var results = (JArray)(jsonObject.Property("results").Value);
            JObject geometryObject = new JObject();
            foreach (JObject parsedObject in results.Children<JObject>())
            {
                foreach (JProperty parsedProperty in parsedObject.Properties())
                {
                    var propertyName = parsedProperty.Name;
                    if (propertyName.Equals("geometry"))
                    {
                        geometryObject = (JObject)parsedProperty.Value;
                    }
                }
            }
            var locationObject = (JObject)(geometryObject.Property("location").Value);
            var latitude = (JValue)(locationObject.Property("lat").Value);
            var longitutde = (JValue)(locationObject.Property("lng").Value);
            return new Tuple<double, double>(double.Parse(latitude.ToString()), double.Parse(longitutde.ToString()));
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
            if (boli.Length > 0)
            {
                boli = boli.Substring(0, boli.Length - 2);
            }
            if (_loggedAccount.IdD != null)
            {
                try
                {
                    var formularDonare = new FormularDonare(DateTime.Now, boli, null, (int)_loggedAccount.IdD, TxtDonateFor.Text);
                    _donatorService.SubmitFormularDonare(formularDonare);
                    var dateContact = _server.DateContactGetDateByIdDonator((int)_loggedAccount.IdD);
                    Adresa newAdr = null;
                    if (dateContact != null)
                    {
                        dateContact.Telefon = TxtPhone.Text;
                        dateContact.Email = TxtEmail.Text;
                        var adresa = _server.AdresaGetAdresaByDateContactId(dateContact.Id);
                        if (adresa != null)
                        {
                            var str = TxtAddress.Text.Split(' ');

                            adresa.Numar = int.Parse(str[str.Length - 1]);
                            adresa.Strada = "";
                            for (var i = 0; i < str.Length - 1; ++i)
                                adresa.Strada += str[i];
                            adresa.Oras = TxtCity.Text;
                            adresa.Judet = TxtCounty.Text;

                            TaskCompletionSource<Tuple<double, double>> result = new TaskCompletionSource<Tuple<double, double>>();
                            Func<Task> action = async () => { result.SetResult(await GetLatAndLng(adresa)); };

                            TaskEx.Run(action);
                            adresa.Latitude = result.Task.Result.Item1;
                            adresa.Longitude = result.Task.Result.Item2;

                            _server.AdresaUpdate(adresa);
                            newAdr = adresa;
                        }
                        else
                        {
                            var str = TxtAddress.Text.Split(' ');

                            var numar = int.Parse(str[str.Length - 1]);
                            var strada = "";
                            for (var i = 0; i < str.Length - 1; ++i)
                                strada += str[i];
                            var newAdresa = new Adresa {
                                Strada = strada,
                                Numar = numar,
                                Oras = TxtCity.Text,
                                Judet = TxtCounty.Text
                            };

                            TaskCompletionSource<Tuple<double, double>> result = new TaskCompletionSource<Tuple<double, double>>();
                            Func<Task> action = async () => { result.SetResult(await GetLatAndLng(newAdresa)); };

                            TaskEx.Run(action);
                            newAdresa.Latitude = result.Task.Result.Item1;
                            newAdresa.Longitude = result.Task.Result.Item2;

                            _server.AdresaAdd(newAdresa);

                            newAdr = newAdresa;
                        }
                        _server.DateContactUpdate(dateContact);
                    }
                    else
                    {
                        var newDateContact = new DateContact(TxtPhone.Text, TxtEmail.Text, newAdr.Id);
                        _server.DateContactAdd(newDateContact);
                        var donatorr = _server.DonatorFindEntity((int)_loggedAccount.IdD);
                        donatorr.IdDc = _server.DateContactFindLastEntity().Id;
                        _server.DonatorUpdate(donatorr);
                    }

                    var donator = _server.DonatorFindEntity((int)_loggedAccount.IdD);
                    var cd = DropdownCD.selectedValue;
                    if (!cd.Equals("Choose institution..."))
                    {
                        cd = cd.TrimEnd();
                        cd = cd.TrimStart();
                        donator.IdCd = _server.CentruDonareFindByDenumire(cd).Id;
                        _server.DonatorUpdate(donator);
                    }
                    MessageBox.Show(@"Your request has been registerd.", @"Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSubmit.Enabled = false;
                    LblDonate.Text = "*You have just submitted a request.";
                } catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            BtnPrevious.Enabled = BtnNext.Enabled = true;

            _analize = _server.AnalizaFindByDonator((int)_loggedAccount.IdD);

            if (_analize.Count > 0)
            {
                _analize.Sort((x, y) => {
                    return x.DataRecoltarii.CompareTo(y.DataRecoltarii);
                });
                LoadAnaliza(_analize[_analize.Count - 1]);
                _pagAnaliza = _analize.Count - 1;

                if (_pagAnaliza == 0)
                    BtnPrevious.Enabled = false;
                BtnNext.Enabled = false;
            }
            else
            {
                LblDate.Text = "There are no blood tests in the database.";
                BtnPrevious.Enabled = BtnNext.Enabled = false;
            }
        }

        private void LoadAnaliza(Analiza analiza)
        {
            LblDate.Text = "Date: " + analiza.DataRecoltarii.ToString("dd-MM-yyyy");
            BloodResultsTable.Rows[0].Cells[1].Value = analiza.Eritrocite;
            BloodResultsTable.Rows[0].Cells[2].Value = (analiza.Eritrocite >= 4.0 && analiza.Eritrocite <= 5.8) ? "" : "Yes";
            BloodResultsTable.Rows[1].Cells[1].Value = analiza.Hemoglobina;
            BloodResultsTable.Rows[1].Cells[2].Value = (analiza.Hemoglobina >= 11.0 && analiza.Hemoglobina <= 17.0) ? "" : "Yes";
            BloodResultsTable.Rows[2].Cells[1].Value = analiza.Hematocrit;
            BloodResultsTable.Rows[2].Cells[2].Value = (analiza.Hematocrit >= 35.0 && analiza.Hematocrit <= 52.0) ? "" : "Yes";
            BloodResultsTable.Rows[3].Cells[1].Value = analiza.VEM;
            BloodResultsTable.Rows[3].Cells[2].Value = (analiza.VEM >= 75.0 && analiza.VEM <= 100.0) ? "" : "Yes";
            BloodResultsTable.Rows[4].Cells[1].Value = analiza.HEM;
            BloodResultsTable.Rows[4].Cells[2].Value = (analiza.HEM >= 25.0 && analiza.HEM <= 33.0) ? "" : "Yes";
            BloodResultsTable.Rows[5].Cells[1].Value = analiza.CHEM;
            BloodResultsTable.Rows[5].Cells[2].Value = (analiza.CHEM >= 31.0 && analiza.CHEM <= 36.0) ? "" : "Yes";
            BloodResultsTable.Rows[6].Cells[1].Value = analiza.LatimeDistribEritrocit;
            BloodResultsTable.Rows[6].Cells[2].Value = (analiza.LatimeDistribEritrocit >= 10.0 && analiza.LatimeDistribEritrocit <= 20.0) ? "" : "Yes";
            BloodResultsTable.Rows[7].Cells[1].Value = analiza.Trombocite;
            BloodResultsTable.Rows[7].Cells[2].Value = (analiza.Trombocite >= 120.0 && analiza.Trombocite <= 400.0) ? "" : "Yes";
            BloodResultsTable.Rows[8].Cells[1].Value = analiza.VolumMediuTrombocitar;
            BloodResultsTable.Rows[8].Cells[2].Value = (analiza.VolumMediuTrombocitar >= 6.0 && analiza.VolumMediuTrombocitar <= 10.0) ? "" : "Yes";
            BloodResultsTable.Rows[9].Cells[1].Value = analiza.Trombocrit;
            BloodResultsTable.Rows[9].Cells[2].Value = (analiza.Trombocrit >= 0.0 && analiza.Trombocrit <= 0.6) ? "" : "Yes";
            BloodResultsTable.Rows[10].Cells[1].Value = analiza.LatimeDistribTrombocit;
            BloodResultsTable.Rows[10].Cells[2].Value = (analiza.LatimeDistribTrombocit >= 0.0 && analiza.LatimeDistribTrombocit <= 25.0) ? "" : "Yes";
            BloodResultsTable.Rows[11].Cells[1].Value = analiza.Leucocite;
            BloodResultsTable.Rows[11].Cells[2].Value = (analiza.Leucocite >= 4.0 && analiza.Leucocite <= 10.5) ? "" : "Yes";
            BloodResultsTable.Rows[12].Cells[1].Value = analiza.Granulocite;
            BloodResultsTable.Rows[12].Cells[2].Value = (analiza.Granulocite >= 42.0 && analiza.Granulocite <= 75.0) ? "" : "Yes";
            BloodResultsTable.Rows[13].Cells[1].Value = analiza.Limfocite;
            BloodResultsTable.Rows[13].Cells[2].Value = (analiza.Limfocite >= 11.0 && analiza.Limfocite <= 50.0) ? "" : "Yes";
            BloodResultsTable.Rows[14].Cells[1].Value = analiza.MID;
            BloodResultsTable.Rows[14].Cells[2].Value = (analiza.MID >= 2.0 && analiza.MID <= 12.0) ? "" : "Yes";
            BloodResultsTable.Rows[15].Cells[1].Value = analiza.NumarGranulocite;
            BloodResultsTable.Rows[15].Cells[2].Value = (analiza.NumarGranulocite >= 2.0 && analiza.NumarGranulocite <= 8.0) ? "" : "Yes";
            BloodResultsTable.Rows[16].Cells[1].Value = analiza.NumarLimfocite;
            BloodResultsTable.Rows[16].Cells[2].Value = (analiza.NumarLimfocite >= 1.0 && analiza.NumarLimfocite <= 5.0) ? "" : "Yes";
            BloodResultsTable.Rows[17].Cells[1].Value = analiza.NumarMID;
            BloodResultsTable.Rows[17].Cells[2].Value = (analiza.NumarMID >= 0.0 && analiza.NumarMID <= 1.4) ? "" : "Yes";
            BloodResultsTable.Rows[18].Cells[1].Value = analiza.Glicemie;
            BloodResultsTable.Rows[18].Cells[2].Value = (analiza.Glicemie >= 60.0 && analiza.Glicemie <= 120.0) ? "" : "Yes";
            BloodResultsTable.Rows[19].Cells[1].Value = analiza.ALT_TGP;
            BloodResultsTable.Rows[19].Cells[2].Value = (analiza.ALT_TGP >= 5.0 && analiza.ALT_TGP <= 65.0) ? "" : "Yes";
            BloodResultsTable.Rows[20].Cells[1].Value = analiza.Colesterol;
            BloodResultsTable.Rows[20].Cells[2].Value = (analiza.Colesterol >= 110.0 && analiza.Colesterol <= 220.0) ? "" : "Yes";
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            _pagAnaliza = _pagAnaliza - 1;
            LoadAnaliza(_analize[_pagAnaliza]);
            if (_pagAnaliza == 0)
                BtnPrevious.Enabled = false;
            else
                BtnPrevious.Enabled = true;
            if (_pagAnaliza == _analize.Count - 1)
                BtnNext.Enabled = false;
            else
                BtnNext.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            _pagAnaliza = _pagAnaliza + 1;
            LoadAnaliza(_analize[_pagAnaliza]);
            if (_pagAnaliza == 0)
                BtnPrevious.Enabled = false;
            else
                BtnPrevious.Enabled = true;
            if (_pagAnaliza == _analize.Count - 1)
                BtnNext.Enabled = false;
            else
                BtnNext.Enabled = true;
        }

        private void NotificationsPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left, e.ClipRectangle.Top + e.ClipRectangle.Height - 2), new Point(e.ClipRectangle.Left, e.ClipRectangle.Top + 4));
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left, e.ClipRectangle.Top + e.ClipRectangle.Height - 1), new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 4, e.ClipRectangle.Top + e.ClipRectangle.Height - 1));
            base.OnPaint(e);
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + e.ClipRectangle.Height - 4), new Point(e.ClipRectangle.Left + e.ClipRectangle.Width - 1, e.ClipRectangle.Top + 4));
            base.OnPaint(e);
        }

        int ind = 1;

        private void Screensaver_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
                animator2.HideSync(pictureBox1);
            if (_toggleMenu && _toggleNotif == 1)
            {
                pictureBox1.LoadAsync(_picList[ind++]);
                ind %= 3;
                Screensaver.Stop();
            }
        }

        private void pictureBox1_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            animator2.ShowSync(pictureBox1);
            Screensaver.Start();
        }
    }
}
