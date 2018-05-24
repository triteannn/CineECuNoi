using ISSApp.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlFormularCerereRepo : ISqlRepo<FormularCerere>
    {
        public void Add(FormularCerere formular)
        {
            // TODO implement here
        }

        public FormularCerere Delete(FormularCerere formular)
        {
            // TODO implement here
            return null;
        }

        public FormularCerere Update(FormularCerere formular)
        {
            // TODO implement here
            return null;
        }

        public FormularCerere FindEntity(int id)
        {
            // TODO implement here
            return null;
        }

        public List<FormularCerere> FindAll()
        {
            // TODO implement here
            return null;
        }

        public bool ExistaCNP(string cnp)
        {
            using (var connection = Globals.getDBConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select * from FormularCerere where Target=@cnp", connection);
                cmd.Parameters.AddWithValue("@cnp", cnp);
              
                var reader = cmd.ExecuteReader();
               
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;

        }
    }
}