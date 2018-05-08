using ISSApp.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlAccountRepo : ISqlRepo<Account>
    {
        public void Add(Account entity)
        {
            throw new System.NotImplementedException();
        }

        public Account Delete(Account entity)
        {
            throw new System.NotImplementedException();
        }

        public Account Update(Account entity)
        {
            throw new System.NotImplementedException();
        }

        public Account FindEntity(int id)
        {
            throw new System.NotImplementedException();
        }

        public Account FindAccountByCredentials(string username, string password)
        {
            using (var connection = Globals.getDBConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select * from Accounts", connection);
                var reader = cmd.ExecuteReader();
                var user = "";
                var pass = "";
                while (reader.Read())
                {
                    user = reader.GetString(1);
                    pass = reader.GetString(2);
                }
                if (user.Length > 0 && pass.Length > 0 && username.Equals(user) && password.Equals(pass))
                    return new Account(user, pass);
                return null;
            }
        }

        public List<Account> FindAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
