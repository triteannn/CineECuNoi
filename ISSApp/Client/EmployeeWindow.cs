using Client.Service;
using ISSApp.Domain;
using ISSApp.Networking;
using System;
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
    }
}
