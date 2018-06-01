using Client.Service;
using ISSApp.Domain;
using ISSApp.Exceptions;
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
        private DataSet _dataSet;
        private BindingSource _bindingSource;
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
            _dataSet = _adminService.AccountAdminGetDataSet();
            _bindingSource.DataSource = _dataSet.Tables["Accounts"];
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
            AccountsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountsTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountsTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AccountsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = TabControl.SelectedIndex;
            _bindingSource = new BindingSource();
            if (index == 0)
            {
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.AccountAdminGetDataSet();
                _bindingSource.DataSource = _dataSet.Tables["Accounts"];
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
                AccountsTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                AccountsTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                AccountsTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                AccountsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (index == 1)
            {
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.DonatorAdminGetDataSet();
                var childDataSet = _adminService.AccountAdminGetDataSet();
                var tab = childDataSet.Tables["Accounts"];
                childDataSet.Tables.Clear();
                _dataSet.Tables.Add(tab);
                var parentCol = _dataSet.Tables["Donatori"].Columns[0];
                var childCol = _dataSet.Tables["Accounts"].Columns["IdD"];
                var fk = new ForeignKeyConstraint(parentCol, childCol);
                fk.DeleteRule = Rule.Cascade;
                _dataSet.Tables["Accounts"].Constraints.Add(fk);
                _dataSet.EnforceConstraints = true;
                _bindingSource.DataSource = _dataSet.Tables["Donatori"];
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
                DonatorsTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DonatorsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DonatorsTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DonatorsTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DonatorsTable.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DonatorsTable.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (index == 2)
            {
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.AngajatAdminGetDataSet();
                var childDataSet = _adminService.AccountAdminGetDataSet();
                var tab = childDataSet.Tables["Accounts"];
                childDataSet.Tables.Clear();
                _dataSet.Tables.Add(tab);
                var parentCol = _dataSet.Tables["AngajatiCentru"].Columns[0];
                var childCol = _dataSet.Tables["Accounts"].Columns["IdAc"];
                var fk = new ForeignKeyConstraint(parentCol, childCol);
                fk.DeleteRule = Rule.Cascade;
                _dataSet.Tables["Accounts"].Constraints.Add(fk);
                _dataSet.EnforceConstraints = true;
                _bindingSource.DataSource = _dataSet.Tables["AngajatiCentru"];
                EmployeesTable.DataSource = _bindingSource;
                bindingNavigator3.BindingSource = _bindingSource;
                foreach (DataGridViewColumn col in EmployeesTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in EmployeesTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                EmployeesTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                EmployeesTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                EmployeesTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                EmployeesTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (index == 3)
            {
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.MedicAdminGetDataSet();
                var childDataSet = _adminService.AccountAdminGetDataSet();
                var tab = childDataSet.Tables["Accounts"];
                childDataSet.Tables.Clear();
                _dataSet.Tables.Add(tab);
                var parentCol = _dataSet.Tables["Medici"].Columns[0];
                var childCol = _dataSet.Tables["Accounts"].Columns["IdM"];
                var fk = new ForeignKeyConstraint(parentCol, childCol);
                fk.DeleteRule = Rule.Cascade;
                _dataSet.Tables["Accounts"].Constraints.Add(fk);
                _dataSet.EnforceConstraints = true;
                _bindingSource.DataSource = _dataSet.Tables["Medici"];
                DoctorsTable.DataSource = _bindingSource;
                bindingNavigator4.BindingSource = _bindingSource;
                foreach (DataGridViewColumn col in DoctorsTable.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                foreach (DataGridViewColumn col in DoctorsTable.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                DoctorsTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DoctorsTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DoctorsTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DoctorsTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (index == 4)
            {
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.SpitalAdminGetDataSet();
                _bindingSource.DataSource = _dataSet.Tables["Spitale"];
                HospitalsTable.DataSource = _bindingSource;
                bindingNavigator5.BindingSource = _bindingSource;
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
                foreach (DataTable table in _dataSet.Tables)
                    table.Constraints.Clear();
                _dataSet.Tables.Clear();
                _dataSet = _adminService.CentruDonareAdminGetDataSet();
                _bindingSource.DataSource = _dataSet.Tables["CentreDonare"];
                TransfusionCentersTable.DataSource = _bindingSource;
                bindingNavigator6.BindingSource = _bindingSource;
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
            try
            {
                var rowsAffected = _adminService.DonatorAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb2, null);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateDb1_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsAffected = _adminService.AccountAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb1, null);

            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateDb4_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsAffected = _adminService.MedicAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb4, null);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateDb3_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsAffected = _adminService.AngajatAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb3, null);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateDb5_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsAffected = _adminService.SpitalAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb5, null);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateDb6_Click(object sender, EventArgs e)
        {
            try
            {
                var rowsAffected = _adminService.CentruDonareAdminUpdateDataBase(_dataSet);
                MessageBox.Show(rowsAffected + @" row(s) affected.", @"Update successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                TabControl_SelectedIndexChanged(BtnUpdateDb6, null);
            } catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, @"Error occured", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
