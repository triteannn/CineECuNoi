﻿using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;
using Domain;
using System.Data.Entity.Validation;

namespace ISSApp
{
    public partial class LoginForm : Form
    {

        private bool _closingfade = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            /*using (var db = new DatabaseContext())
            {
                
                var spital = new Spital() { Denumire = "Da" };
                var medic1 = new Medic() { CNP="123", Nume = "Tritean" };
                var medic2 = new Medic() { CNP="321", Nume = "Adi" };
                spital.Medici.Add(medic1);
                spital.Medici.Add(medic2);
                db.Spital.Add(spital);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException exc)
                {
                    foreach (var msg in exc.EntityValidationErrors)
                    {
                        Console.WriteLine(msg.Entry.State);
                        foreach (var nume in msg.ValidationErrors)
                        {
                            Console.WriteLine(nume.PropertyName);
                            Console.WriteLine(nume.ErrorMessage);
                        }
                    }
                }
            }*/
            Fade.Start();           
            TxtUsername.Text = "Username";
            TxtPassword.Text = "Password";
            TxtPassword.isPassword = false;
            var serializer = new XmlSerializer(typeof(string));
            if (File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
            {
                using (var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Open, FileAccess.Read))
                {
                    TxtUsername.Text = serializer.Deserialize(fs) as string;
                }
                RememberMe.Checked = true;
            }
            Label5.ForeColor = RememberMe.Checked ? Color.DarkRed : Color.Gray;
            swfLogin.Movie = Environment.CurrentDirectory.Replace(@"bin\x86\Debug", @"Resources\LoginImage.swf");
        }

        private void Fade_Tick(object sender, EventArgs e)
        {
            if (!_closingfade)
            {
                if (Opacity < 1.0)
                    Opacity += 0.05;
                else
                {
                    Fade.Stop();
                    Enabled = true;                                   
                }
            }
            else
            {
                if (Opacity > 0.0)
                    Opacity -= 0.05;
                else
                {
                    Fade.Stop();
                    Dispose();
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to exit the application?", @"", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            _closingfade = true;
            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
                Enabled = false;
                Fade.Start();
            }
            else e.Cancel = true;
        }

        private void BtnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            BtnLogin.BackColor = Color.White;
            BtnLogin.ForeColor = Color.DarkRed;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            BtnLogin.BackColor = Color.DarkRed;
            BtnLogin.ForeColor = Color.White;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.isPassword = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                TxtPassword.isPassword = false;
            }
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
                TxtUsername.Text = "";
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
                TxtUsername.Text = "Username";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Length > 0 && TxtPassword.Text.Length > 0 && DropdownAS.selectedIndex > 0 && TxtUsername.Text != "Username" && TxtPassword.Text != "Password")
            {               
                if(RememberMe.Checked)
                {
                    var serializer = new XmlSerializer(typeof(string));
                    if(File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
                    {
                        using (var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Open, FileAccess.Write))
                        {
                            serializer.Serialize(fs, TxtUsername.Text);
                        }
                    }
                    else
                    {
                        using(var fs = new FileStream(Environment.CurrentDirectory + @"\RememberedUser.xml", FileMode.Create, FileAccess.Write))
                        {
                            serializer.Serialize(fs, TxtUsername.Text);
                        }
                    }
                }
                else
                {
                    var serializer = new XmlSerializer(typeof(string));
                    if (File.Exists(Environment.CurrentDirectory + @"\RememberedUser.xml"))
                    {
                        File.Delete(Environment.CurrentDirectory + @"\RememberedUser.xml");
                    }
                }
                string username = "";
                string password = "";
                using (var connection = Globals.getDBConnection())
                {
                    try
                    {
                        connection.Open();
                        var cmd = new SqlCommand(@"select * from Accounts", connection);
                        var reader = cmd.ExecuteReader();
                        while(reader.Read())
                        {
                            username = reader.GetString(1);
                            password = reader.GetString(2);
                        }
                    }
                    catch (SqlException exc)
                    {
                        MessageBox.Show(exc.Message, @"Database related error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (username.Length > 0 && password.Length > 0 && username.Equals(TxtUsername.Text) && password.Equals(TxtPassword.Text))
                {
                    var mainWindow = new MainWindow(this);
                    mainWindow.Show();
                    Hide();
                }
                else MessageBox.Show(@"Invalid username or password.", @"Please check your credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(@"Fields can not be empty or left unchanged.", @"", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void EmptyFields()
        {          
            if (!RememberMe.Checked)
                TxtUsername.Text = "Username";
            RememberMe.Checked = TxtUsername.Text != "Username" ? true : false;
            TxtPassword.Text = "Password";
            TxtPassword.isPassword = false;
            DropdownAS.selectedIndex = 0;
        }

        private void LblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var _registerForm = new RegisterForm(this);
            _registerForm.Show();
            Enabled = false;
        }

        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DropdownAS_onItemSelected(object sender, EventArgs e)
        {
            BtnLogin.Select();
        }

        private void RememberMe_OnChange(object sender, EventArgs e)
        {
            Label5.ForeColor = RememberMe.Checked ? Color.DarkRed : Color.Gray;
        }
    }
}
