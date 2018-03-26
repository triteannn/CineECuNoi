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
            return new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ToString());
        }

        public static void SetFont(int _fontSize, FontStyle _fontStyle, params Control[] _controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath.Replace(@"bin\Debug", "Resources"), "MAIAN.TTF"));
            foreach (var _control in _controls)
                _control.Font = new Font(pfc.Families[0], _fontSize, _fontStyle);
        }
    }
}
