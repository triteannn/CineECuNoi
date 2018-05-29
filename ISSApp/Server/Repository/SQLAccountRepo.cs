using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlAccountRepo : ISqlRepo<Account>
    {
        public void Add(Account entity)
        {
            var connection = Globals.GetDbConnection();
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
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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

                } catch (SqlException)
                {
                    throw new RepositoryException("Database delete failed.");
                }

            }

        }

        public Account Update(Account entity)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Accounts SET Username=@Username, Password=@Password, IdD=@IdD WHERE Id=@Id";

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
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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

                            Account account = new Account(result.GetString(1), result.GetString(2), result.GetInt32(3), result.GetInt32(4), result.GetInt32(5));
                            return account;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Database getOne failed.");
                }

            }

        }

        public Account FindAccountByCredentials(string username, string password)
        {
            using (var connection = Globals.GetDbConnection())
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(@"select * from Accounts where Username=@username and Password=@password", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    var reader = cmd.ExecuteReader();
                    var user = "";
                    var pass = "";
                    var idD = new int();
                    var idM = new int();
                    var idAc = new int();
                    while (reader.Read())
                    {
                        user = reader.GetString(1);
                        pass = reader.GetString(2);
                        if (reader[3] != DBNull.Value)
                            idD = reader.GetInt32(3);
                        if (reader[4] != DBNull.Value)
                            idM = reader.GetInt32(4);
                        if (reader[5] != DBNull.Value)
                            idAc = reader.GetInt32(5);
                    }
                    if (user.Length > 0 && pass.Length > 0 && username.Equals(user) && password.Equals(pass))
                        return new Account(user, pass, idD, idM, idAc);
                    return null;
                } catch (SqlException e)
                {
                    throw new RepositoryException(e.Message);
                }
            }
        }

        public List<Account> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                } catch (SqlException)
                {
                    throw new RepositoryException("Database getAll failed.");
                }
            }
        }

        public int GetLastId()
        {
            var id = 0;
            using (var connection = Globals.GetDbConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select max(Id) from Accounts", connection);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            return id;
        }
    }
}
