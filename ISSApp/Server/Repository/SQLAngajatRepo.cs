using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlAngajatRepo : ISqlRepo<AngajatCentru>
    {
        public void Add(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "INSERT INTO AngajatiCentru(CNP, Nume, Prenume, Dob, IdCd, IdA, IdDc) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdCd, @IdA, @IdDc)";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = angajatCentru.CNP;
                    command.Parameters.Add(paramCNP);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = angajatCentru.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = angajatCentru.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = new DateTime(angajatCentru.Dob.Year, angajatCentru.Dob.Month, angajatCentru.Dob.Day, 0, 0, 0);
                    ;
                    command.Parameters.Add(paramDob);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = angajatCentru.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = angajatCentru.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdDc = command.CreateParameter();
                    paramIdDc.ParameterName = "@IdDc";
                    paramIdDc.Value = angajatCentru.IdDc;
                    command.Parameters.Add(paramIdDc);

                    command.ExecuteNonQuery();
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public AngajatCentru Delete(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM AngajatiCentru WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = angajatCentru.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public AngajatCentru Update(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "UPDATE AngajatiCentru SET CNP=@CNP, Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdCd=@IdCd, IdA=@IdA, IdDc=@IdDc WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = angajatCentru.Id;
                    command.Parameters.Add(paramId);

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = angajatCentru.CNP;
                    command.Parameters.Add(paramCNP);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = angajatCentru.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = angajatCentru.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = angajatCentru.Dob;
                    command.Parameters.Add(paramDob);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = angajatCentru.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = angajatCentru.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdDc = command.CreateParameter();
                    paramIdDc.ParameterName = "@IdDc";
                    paramIdDc.Value = angajatCentru.IdDc;
                    command.Parameters.Add(paramIdDc);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public AngajatCentru FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "SELECT * FROM AngajatiCentru WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            String cnp = "";
                            if (result[1] != DBNull.Value)
                                cnp = result.GetString(1);

                            String nume = "";
                            if (result[2] != DBNull.Value)
                                nume = result.GetString(2);

                            String prenume = "";
                            if (result[3] != DBNull.Value)
                                result.GetString(3);

                            DateTime date = result.GetDateTime(4);



                            AngajatCentru angajat = new AngajatCentru(cnp, nume, prenume, date);
                            return angajat;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public AngajatCentru FindByUsername(string username)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select ang.* from Angajati ang, Accounts a where a.Username = @Username and a.IdAc = ang.Id";
                    var paramUsername = command.CreateParameter();
                    paramUsername.ParameterName = "@Username";
                    paramUsername.Value = username;
                    command.Parameters.Add(paramUsername);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {

                            String cnp = "";
                            if (result[1] != DBNull.Value)
                                cnp = result.GetString(1);

                            String nume = "";
                            if (result[2] != DBNull.Value)
                                nume = result.GetString(2);

                            String prenume = "";
                            if (result[3] != DBNull.Value)
                                result.GetString(3);

                            DateTime date = result.GetDateTime(4);



                            AngajatCentru angajat = new AngajatCentru(cnp, nume, prenume, date);
                            return angajat;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public AngajatCentru FindByIdAccount(int idAccount)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select ang.* from Angajati ang inner join Accounts a on a.IdAc = ang.Id where a.Id = @IdAcc";
                    var paramIdAcc = command.CreateParameter();
                    paramIdAcc.ParameterName = "@IdAcc";
                    paramIdAcc.Value = idAccount;
                    command.Parameters.Add(paramIdAcc);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            var cnp = "";
                            if (result[1] != DBNull.Value)
                                cnp = result.GetString(1);

                            var nume = "";
                            if (result[2] != DBNull.Value)
                                nume = result.GetString(2);

                            var prenume = "";
                            if (result[3] != DBNull.Value)
                                prenume = result.GetString(3);

                            var date = new DateTime();
                            if (result[4] != DBNull.Value)
                                date = result.GetDateTime(4);


                            AngajatCentru angajat = new AngajatCentru(cnp, nume, prenume, date);
                            return angajat;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public List<AngajatCentru> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<AngajatCentru> toReturn = new List<AngajatCentru>();
                    command.CommandText = "SELECT * FROM AngajatiCentru";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            String cnp = "";
                            if (result[1] != DBNull.Value)
                                cnp = result.GetString(1);

                            String nume = "";
                            if (result[2] != DBNull.Value)
                                nume = result.GetString(2);

                            String prenume = "";
                            if (result[3] != DBNull.Value)
                                result.GetString(3);

                            DateTime date = result.GetDateTime(4);

                            toReturn.Add(new AngajatCentru(cnp, nume, prenume, date));
                        }
                    }
                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea angajatilor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public int AdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                int rowsAffected;
                using (var connection = Globals.GetDbConnection())
                {
                    try
                    {
                        connection.Open();
                        var da = new SqlDataAdapter("SELECT * FROM AngajatiCentru", connection);
                        var cb = new SqlCommandBuilder(da);
                        da.DeleteCommand = cb.GetDeleteCommand();
                        da.InsertCommand = cb.GetInsertCommand();
                        da.UpdateCommand = cb.GetUpdateCommand();
                        rowsAffected = da.Update(dataSet.Tables["AngajatiCentru"]);
                    } catch (SqlException e)
                    {
                        throw new RepositoryException(e.Message);
                    }
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
                    var da = new SqlDataAdapter("SELECT * FROM AngajatiCentru", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    var dt = new DataTable("AngajatiCentru");
                    ds.Tables.Add(dt);
                    da.Fill(ds, "AngajatiCentru");
                    return ds;
                }
            } catch (SqlException)
            {

                throw new RepositoryException("Unable to get data set from the database.");
            }
        }
    }
}