using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ISSApp
{
    public sealed class Globals
    {
        private static readonly Globals _globals = new Globals();

        static Globals() { }

        private Globals() { }

        public static Globals Instance
        {
            get => _globals;
        }

        public static SqlConnection getDBConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseContext"].ToString());
        }
    }
}
