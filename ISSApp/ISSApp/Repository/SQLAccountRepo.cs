using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
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
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Accounts WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@CNP";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
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
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM Accounts WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {

                            Account account = new Account(result.GetString(1), result.GetString(2));
                            return account;
                        }

                        return null;
                    }

                }
                catch (SqlException)
                {
                    throw new Exception("Database getOne failed.");
                }

            }
        }

        public Account FindAccountByCredentials(string username, string password)
        {
            using (var connection = Globals.getDBConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select * from Accounts where Username=@username and Password=@password", connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
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
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Account> toReturn = new List<Account>();
                    command.CommandText = "SELECT * FROM Accounts";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            toReturn.Add(new Account(result.GetString(1), result.GetString(2)));
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new Exception("Database getAll failed.");
                }
            }
        }
    }
}
