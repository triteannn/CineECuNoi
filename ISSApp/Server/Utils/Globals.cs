using System.Configuration;
using System.Data.SqlClient;

namespace Server.Utils
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

        public static SqlConnection GetDbConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseContext"].ToString());
        }
    }
}
