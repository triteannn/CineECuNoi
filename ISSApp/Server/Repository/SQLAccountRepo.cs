﻿using ISSApp.Domain;
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
            if (FindAccountByUsername(entity.Username) == null)
            {
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
            }
            else
                throw new RepositoryException("There is already an account registered with that username.");
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
                            var user = "";
                            var pass = "";
                            int? idD = null;
                            int? idM = null;
                            int? idAc = null;

                            user = result.GetString(1);
                            pass = result.GetString(2);
                            if (result[3] != DBNull.Value)
                                idD = result.GetInt32(3);
                            if (result[4] != DBNull.Value)
                                idM = result.GetInt32(4);
                            if (result[5] != DBNull.Value)
                                idAc = result.GetInt32(5);

                            Account account = new Account(id, user, pass, idD, idM, idAc);
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
                    var id = new int();
                    var user = "";
                    var pass = "";
                    var idD = new int();
                    var idM = new int();
                    var idAc = new int();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
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
                        return new Account(id, user, pass, idD, idM, idAc);
                    return null;
                } catch (SqlException e)
                {
                    throw new RepositoryException(e.Message);
                }
            }
        }

        public Account FindAccountByUsername(string username)
        {
            using (var connection = Globals.GetDbConnection())
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand(@"select * from Accounts where Username=@username", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    var reader = cmd.ExecuteReader();
                    var id = new int();
                    var user = "";
                    var pass = "";
                    var idD = new int();
                    var idM = new int();
                    var idAc = new int();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        user = reader.GetString(1);
                        pass = reader.GetString(2);
                        if (reader[3] != DBNull.Value)
                            idD = reader.GetInt32(3);
                        if (reader[4] != DBNull.Value)
                            idM = reader.GetInt32(4);
                        if (reader[5] != DBNull.Value)
                            idAc = reader.GetInt32(5);
                    }
                    if (user.Length > 0 && pass.Length > 0 && username.Equals(user))
                        return new Account(id, user, pass, idD, idM, idAc);
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
                    var toReturn = new List<Account>();
                    command.CommandText = "SELECT * FROM Accounts";
                    using (var result = command.ExecuteReader())
                    {
                        int? idD = null;
                        int? idM = null;
                        int? idAc = null;
                        while (result.Read())
                        {
                            if (result[3] != DBNull.Value)
                                idD = result.GetInt32(3);
                            if (result[4] != DBNull.Value)
                                idM = result.GetInt32(4);
                            if (result[5] != DBNull.Value)
                                idAc = result.GetInt32(5);
                            toReturn.Add(new Account(result.GetInt32(0), result.GetString(1), result.GetString(2), idD, idM, idAc));
                        }
                    }
                    connection.Close();
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

        public int AdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                int rowsAffected;
                using (var connection = Globals.GetDbConnection())
                {

                    connection.Open();
                    var da = new SqlDataAdapter("SELECT * FROM Accounts", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    rowsAffected = da.Update(dataSet.Tables["Accounts"]);

                }
                return rowsAffected;
            } catch (SqlException)
            {

                throw new RepositoryException("Unable to update the database. Please check your changes.");
            }
        }

        public DataSet AdminGetDataSet()
        {

            try
            {
                using (var connection = Globals.GetDbConnection())
                {
                    var ds = new DataSet();
                    var da = new SqlDataAdapter("SELECT * FROM Accounts", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    var dt = new DataTable("Accounts");
                    ds.Tables.Add(dt);
                    da.Fill(ds, "Accounts");
                    return ds;
                }
            } catch (SqlException)
            {
                throw new RepositoryException("Unable to get data set from the database.");
            }
        }
    }
}
