using Client.Service;
using ISSApp.Domain;
using ISSApp.Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
    public sealed partial class AdminWindow : Form
    {
        private readonly LoginForm _loginForm;
        private readonly IServer _server;
        private readonly Account _account;
        private readonly DataSet _dataSet;
        private readonly BindingSource _bindingSource;
        private readonly AdminService _adminService;

        public AdminWindow(LoginForm loginForm, IServer server, Account account)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
            _account = account;
            _dataSet = new DataSet();
            _bindingSource = new BindingSource();
            _adminService = new AdminService(_server);

            AccountsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            AccountsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DonatorsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DonatorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EmployeesTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DoctorsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DoctorsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            HospitalsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HospitalsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TransfusionCentersTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TransfusionCentersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AccountsTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            AccountsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            AccountsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            AccountsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            AccountsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AccountsTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            DonatorsTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            DonatorsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            DonatorsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DonatorsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            DonatorsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DonatorsTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            EmployeesTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            EmployeesTable.DefaultCellStyle.SelectionForeColor = Color.White;
            EmployeesTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            EmployeesTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            EmployeesTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EmployeesTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            HospitalsTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            HospitalsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            HospitalsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            HospitalsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            HospitalsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            HospitalsTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            TransfusionCentersTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            TransfusionCentersTable.DefaultCellStyle.SelectionForeColor = Color.White;
            TransfusionCentersTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            TransfusionCentersTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            TransfusionCentersTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TransfusionCentersTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);

            DoctorsTable.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            DoctorsTable.DefaultCellStyle.SelectionForeColor = Color.White;
            DoctorsTable.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DoctorsTable.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            DoctorsTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DoctorsTable.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AdminWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void AdminWindow_Load(object sender, System.EventArgs e)
        {
            label1.Text = @"Logged in as " + _account.Username;
            var dt = ToDataTable(_server.AccountFindAll(), "Accounts");
            dt.Columns.Remove("Donator");
            dt.Columns.Remove("Medic");
            dt.Columns.Remove("AngajatCentru");
            _bindingSource.DataSource = dt;
            AccountsTable.DataSource = _bindingSource;
            bindingNavigator1.BindingSource = _bindingSource;
            foreach (DataGridViewColumn col in AccountsTable.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in AccountsTable.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void PictureBox3_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
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

        public static DataTable ToDataTable<T>(IList<T> data, string name)
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var dt = new DataTable(name);
            for (var i = 0; i < properties.Count; i++)
            {
                var property = properties[i];
                dt.Columns.Add(property.Name, Nullable.GetUnderlyingType(
                                                  property.PropertyType) ?? property.PropertyType);
            }
            var values = new object[properties.Count];
            foreach (var item in data)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var index = TabControl.SelectedIndex;
            if (index == 0)
            {
                _dataSet.Tables.Clear();
                var dt = ToDataTable(_server.AccountFindAll(), "Accounts");
                dt.Columns.Remove("Donator");
                dt.Columns.Remove("Medic");
                dt.Columns.Remove("AngajatCentru");
                _dataSet.Tables.Add(dt);
                _bindingSource.DataSource = dt;
                AccountsTable.DataSource = _bindingSource;
                bindingNavigator1.BindingSource = _bindingSource;
                foreach (DataGridViewColumn col in AccountsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in AccountsTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            if (index == 1)
            {
                _dataSet.Tables.Clear();
                var dt = ToDataTable(_server.DonatorFindAll(), "Donators");
                dt.Columns.Remove("DateContact");
                dt.Columns.Remove("CentruDonare");
                dt.Columns.Remove("FormularDonare");
                dt.Columns.Remove("Account");
                _dataSet.Tables.Add(dt);
                _bindingSource.DataSource = dt;
                DonatorsTable.DataSource = _bindingSource;
                bindingNavigator2.BindingSource = _bindingSource;
                foreach (DataGridViewColumn col in DonatorsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in DonatorsTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                DonatorsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            if (index == 2)
            {
                _dataSet.Tables.Clear();
                foreach (DataGridViewColumn col in EmployeesTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in EmployeesTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            if (index == 3)
            {
                _dataSet.Tables.Clear();
                foreach (DataGridViewColumn col in DoctorsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in DoctorsTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            if (index == 4)
            {
                _dataSet.Tables.Clear();
                foreach (DataGridViewColumn col in HospitalsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in HospitalsTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            if (index == 5)
            {
                _dataSet.Tables.Clear();
                foreach (DataGridViewColumn col in TransfusionCentersTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in TransfusionCentersTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void BtnUpdateDb2_Click(object sender, EventArgs e)
        {
            var rowsAffected = _adminService.DonatorAdminUpdateDataBase(_dataSet);
            MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
