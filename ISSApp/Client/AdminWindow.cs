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

        public AdminWindow(LoginForm loginForm, IServer server, Account account)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _server = server;
            _account = account;
            _dataSet = new DataSet();
            _bindingSource = new BindingSource();
            foreach (DataGridViewColumn col in AccountsTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in DonatorsTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in EmployeesTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in DoctorsTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in HospitalsTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn col in TransfusionCentersTable.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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
                DonatorsTable.Rows.Clear();
                EmployeesTable.Rows.Clear();
                DoctorsTable.Rows.Clear();
                HospitalsTable.Rows.Clear();
                TransfusionCentersTable.Rows.Clear();
                var dt = ToDataTable(_server.AccountFindAll(), "Accounts");
                _bindingSource.DataSource = dt;
                AccountsTable.DataSource = _bindingSource;
                bindingNavigator1.BindingSource = _bindingSource;
                foreach (DataGridViewColumn col in AccountsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            if (index == 1)
            {
                AccountsTable.Rows.Clear();
                EmployeesTable.Rows.Clear();
                DoctorsTable.Rows.Clear();
                HospitalsTable.Rows.Clear();
                TransfusionCentersTable.Rows.Clear();
            }
            if (index == 2)
            {
                DonatorsTable.Rows.Clear();
                AccountsTable.Rows.Clear();
                DoctorsTable.Rows.Clear();
                HospitalsTable.Rows.Clear();
                TransfusionCentersTable.Rows.Clear();
            }
            if (index == 3)
            {
                DonatorsTable.Rows.Clear();
                EmployeesTable.Rows.Clear();
                AccountsTable.Rows.Clear();
                HospitalsTable.Rows.Clear();
                TransfusionCentersTable.Rows.Clear();
            }
            if (index == 4)
            {
                DonatorsTable.Rows.Clear();
                EmployeesTable.Rows.Clear();
                DoctorsTable.Rows.Clear();
                AccountsTable.Rows.Clear();
                TransfusionCentersTable.Rows.Clear();
            }
            if (index == 5)
            {
                DonatorsTable.Rows.Clear();
                EmployeesTable.Rows.Clear();
                DoctorsTable.Rows.Clear();
                HospitalsTable.Rows.Clear();
                AccountsTable.Rows.Clear();
            }
        }
    }
}
