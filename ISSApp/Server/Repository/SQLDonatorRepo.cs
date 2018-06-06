using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Server.Repository
{
    public class SqlDonatorRepo : ISqlRepo<Donator>
    {
        public void Add(Donator donator)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO Donatori(CNP, Nume, Prenume, Dob, IdA) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdA)";

                    var paramCnp = command.CreateParameter();
                    paramCnp.ParameterName = "@CNP";
                    paramCnp.Value = donator.CNP;
                    command.Parameters.Add(paramCnp);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = donator.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = donator.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = new DateTime(donator.Dob.Year, donator.Dob.Month, donator.Dob.Day, 0, 0, 0);
                    command.Parameters.Add(paramDob);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = donator.IdA;
                    command.Parameters.Add(paramIdA);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public void AddFull(Donator donator)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO Donatori(CNP, Nume, Prenume, Dob, IdCd, IdA, IdDc) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdCd, @IdA, @IdDc)";

                    var paramCnp = command.CreateParameter();
                    paramCnp.ParameterName = "@CNP";
                    paramCnp.Value = donator.CNP;
                    command.Parameters.Add(paramCnp);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = donator.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = donator.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    var dob = new DateTime(donator.Dob.Year, donator.Dob.Month, donator.Dob.Day, 0, 0, 0);
                    paramDob.Value = dob;
                    command.Parameters.Add(paramDob);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = donator.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = donator.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdDc = command.CreateParameter();
                    paramIdDc.ParameterName = "@IdDc";
                    paramIdDc.Value = donator.IdDc;
                    command.Parameters.Add(paramIdDc);

                    command.ExecuteNonQuery();
                    connection.Close();

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public Donator Delete(Donator donator)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Donatori WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = donator.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return donator;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public Donator Update(Donator donator)
        {
            using (var connection = Globals.GetDbConnection())
            {
                try
                {
                    connection.Open();
                    var cmd = new SqlCommand {
                        Connection = connection,
                        CommandText =
                        "UPDATE Donatori SET CNP=@CNP, Nume=@Nume, Prenume=@Prenume, @Dob=@Dob, IdCd=@IdCd, IdA=@IdA, IdDc=@IdDc WHERE Id=@Id"
                    };
                    cmd.Parameters.AddWithValue("@CNP", donator.CNP);
                    cmd.Parameters.AddWithValue("@Nume", donator.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", donator.Prenume);
                    cmd.Parameters.AddWithValue("@Dob", donator.Dob);
                    if (donator.IdCd == null)
                        cmd.Parameters.AddWithValue("@IdCd", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@IdCd", donator.IdCd);
                    if (donator.IdA == null)
                        cmd.Parameters.AddWithValue("@IdA", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@IdA", donator.IdA);
                    if (donator.IdDc == null)
                        cmd.Parameters.AddWithValue("@IdDc", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@IdDc", donator.IdDc);

                    cmd.Parameters.AddWithValue("@Id", donator.Id);

                    var result = cmd.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return donator;
                    }
                    return null;
                } catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public Donator FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();

                try
                {
                    command.CommandText = "SELECT * FROM Donatori WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int? idA = null;
                            int? idDc = null;
                            int? idCd = null;
                            string grupa = "";
                            string rh = "";
                            var idDonator = result.GetInt32(0);
                            var cnp = result.GetString(1);
                            var nume = result.GetString(2);
                            var prenume = result.GetString(3);
                            var date = result.GetDateTime(4);
                            if (result[5] != DBNull.Value)
                                idCd = result.GetInt32(5);
                            if (result[6] != DBNull.Value)
                                idA = result.GetInt32(6);
                            if (result[7] != DBNull.Value)
                                idDc = result.GetInt32(7);
                            if (result[8] != DBNull.Value)
                                grupa = result.GetString(8);
                            if (result[9] != DBNull.Value)
                                rh = result.GetString(9);

                            Donator donator = new Donator(idDonator, cnp, nume, prenume, date, idA, idDc, idCd, grupa, rh);
                            return donator;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public Donator FindByUsername(string username)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select d.* from Donatori d, Accounts a where a.Username = @Username and a.IdD = d.Id";
                    var paramUsername = command.CreateParameter();
                    paramUsername.ParameterName = "@Username";
                    paramUsername.Value = username;
                    command.Parameters.Add(paramUsername);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int? idA = null;
                            int? idDc = null;
                            int? idCd = null;
                            string grupa = "";
                            string rh = "";
                            var idDonator = result.GetInt32(0);
                            var cnp = result.GetString(1);
                            var nume = result.GetString(2);
                            var prenume = result.GetString(3);
                            var date = result.GetDateTime(4);
                            if (result[5] != DBNull.Value)
                                idCd = result.GetInt32(5);
                            if (result[6] != DBNull.Value)
                                idA = result.GetInt32(6);
                            if (result[7] != DBNull.Value)
                                idDc = result.GetInt32(7);
                            if (result[8] != DBNull.Value)
                                grupa = result.GetString(8);
                            if (result[9] != DBNull.Value)
                                rh = result.GetString(9);

                            Donator donator = new Donator(idDonator, cnp, nume, prenume, date, idA, idDc, idCd, grupa, rh);

                            return donator;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public Donator FindByIdAccount(int idAccount)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select d.* from Donatori d, Accounts a where a.Id = @IdAcc and a.IdD = d.Id";
                    var paramIdAcc = command.CreateParameter();
                    paramIdAcc.ParameterName = "@IdAcc";
                    paramIdAcc.Value = idAccount;
                    command.Parameters.Add(paramIdAcc);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int? idA = null;
                            int? idDc = null;
                            int? idCd = null;
                            string grupa = "";
                            string rh = "";
                            var idDonator = result.GetInt32(0);
                            var cnp = result.GetString(1);
                            var nume = result.GetString(2);
                            var prenume = result.GetString(3);
                            var date = result.GetDateTime(4);
                            if (result[5] != DBNull.Value)
                                idCd = result.GetInt32(5);
                            if (result[6] != DBNull.Value)
                                idA = result.GetInt32(6);
                            if (result[7] != DBNull.Value)
                                idDc = result.GetInt32(7);
                            if (result[8] != DBNull.Value)
                                grupa = result.GetString(8);
                            if (result[9] != DBNull.Value)
                                rh = result.GetString(9);

                            Donator donator = new Donator(idDonator, cnp, nume, prenume, date, idA, idDc, idCd, grupa, rh);

                            return donator;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public List<Donator> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Donator> toReturn = new List<Donator>();
                    command.CommandText = "SELECT * FROM Donatori";
                    using (var result = command.ExecuteReader())
                    {

                        while (result.Read())
                        {
                            int? idA = null;
                            int? idDc = null;
                            int? idCd = null;
                            if (result[5] != DBNull.Value)
                                idCd = result.GetInt32(5);
                            if (result[6] != DBNull.Value)
                                idA = result.GetInt32(6);
                            if (result[7] != DBNull.Value)
                                idDc = result.GetInt32(7);
                            toReturn.Add(new Donator(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetString(3),
                                    result.GetDateTime(4).Date, idA, idDc, idCd));
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new RepositoryException(
                        "Returnarea donatorilor din baza de date nu s-a putut realiza cu succes.");
                } finally
                {
                    connection.Close();
                }
            }
        }

        public int GetLastId()
        {
            var id = 0;
            using (var connection = Globals.GetDbConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select max(Id) from Donatori", connection);
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
                    var da = new SqlDataAdapter("SELECT * FROM Donatori", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    rowsAffected = da.Update(dataSet.Tables["Donatori"]);
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
                    connection.Open();
                    var ds = new DataSet();
                    var da = new SqlDataAdapter("SELECT * FROM Donatori", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    var dt = new DataTable("Donatori");
                    ds.Tables.Add(dt);
                    da.Fill(ds, "Donatori");
                    return ds;
                }
            } catch (SqlException)
            {
                throw new RepositoryException("Unable to get data set from the database.");
            }
        }

        public Donator FindEntityByName(string numeComplet)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();

                try
                {
                    command.CommandText = "SELECT * FROM Donatori WHERE Nume=@Nume AND Prenume=@Prenume";

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = numeComplet.Split(' ').First();
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    var enumerable = numeComplet.Split(' ').Skip(1);
                    var str = "";
                    foreach (var s in enumerable)
                    {
                        str += s;
                        str += " ";
                    }
                    paramPrenume.Value = str;
                    command.Parameters.Add(paramPrenume);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int? idA = null;
                            int? idDc = null;
                            int? idCd = null;
                            string grupa = "";
                            string rh = "";
                            var idDonator = result.GetInt32(0);
                            var cnp = result.GetString(1);
                            var nume = result.GetString(2);
                            var prenume = result.GetString(3);
                            var date = result.GetDateTime(4);
                            if (result[5] != DBNull.Value)
                                idCd = result.GetInt32(5);
                            if (result[6] != DBNull.Value)
                                idA = result.GetInt32(6);
                            if (result[7] != DBNull.Value)
                                idDc = result.GetInt32(7);
                            if (result[8] != DBNull.Value)
                                grupa = result.GetString(8);
                            if (result[9] != DBNull.Value)
                                rh = result.GetString(9);

                            Donator donator = new Donator(idDonator, cnp, nume, prenume, date, idA, idDc, idCd, grupa, rh);
                            return donator;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }
    }
}