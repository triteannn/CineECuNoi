using ISSApp.Networking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        IServer Server;

        public Form1(IServer server)
        {
            InitializeComponent();
            Server = server;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Server.AccountFindAccountByCredentials("betmeniibaza","123")!=null)
            {
                labele.Text = "Da";
            }
            else
            {
                labele.Text = "Nu";
            }
        }
    }
}
