using ISSApp.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlAccountRepo : ISqlRepo<Account>
    {
        public void Add(Account entity)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Accounts(Username, Password) VALUES (@Username, @Password)";

                var paramUsername = command.CreateParameter();
                paramUsername.ParameterName = "@Username";
                paramUsername.Value = entity.Username;
                command.Parameters.Add(paramUsername);

                var paramPassword = command.CreateParameter();
                paramPassword.ParameterName = "@Password";
                paramPassword.Value = entity.Password;
                command.Parameters.Add(paramPassword);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public Account Delete(Account entity)
        {
            throw new System.NotImplementedException();
        }

        public Account Update(Account entity)
        {
            var connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Accounts SET Username=@Username, Password=@Password, IdD=@IdD WHERE Id=@Id";

                connection.Open();

                var paramId = command.CreateParameter();
                paramId.ParameterName = "@Id";
                paramId.Value = entity.Id;
                command.Parameters.Add(paramId);

                var paramUsername = command.CreateParameter();
                paramUsername.ParameterName = "@Username";
                paramUsername.Value = entity.Username;
                command.Parameters.Add(paramUsername);

                var paramPassword = command.CreateParameter();
                paramPassword.ParameterName = "@Password";
                paramPassword.Value = entity.Password;
                command.Parameters.Add(paramPassword);

                var paramIdD = command.CreateParameter();
                paramIdD.ParameterName = "@IdD";
                paramIdD.Value = entity.IdD;
                command.Parameters.Add(paramIdD);

                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return entity;
                }
            }
            connection.Close();
            return null;
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
