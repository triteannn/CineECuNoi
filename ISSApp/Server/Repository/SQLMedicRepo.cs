using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlMedicRepo : ISqlRepo<Medic>
    {
        public void Add(Medic medic)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO Medici(CNP, Nume, Prenume, Dob, IdS, IdA, IdDc) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdS, @IdA, @IdDc)";

                    var paramCnp = command.CreateParameter();
                    paramCnp.ParameterName = "@CNP";
                    paramCnp.Value = medic.CNP;
                    command.Parameters.Add(paramCnp);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = medic.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = medic.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = new DateTime(medic.Dob.Year, medic.Dob.Month, medic.Dob.Day, 0, 0, 0);
                    command.Parameters.Add(paramDob);

                    var paramIdS = command.CreateParameter();
                    paramIdS.ParameterName = "@IdS";
                    paramIdS.Value = medic.IdS;
                    command.Parameters.Add(paramIdS);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = medic.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdDc = command.CreateParameter();
                    paramIdDc.ParameterName = "@IdDc";
                    paramIdDc.Value = medic.IdDc;
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

        public Medic Delete(Medic medic)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Medici WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = medic.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return medic;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public Medic Update(Medic medic)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE Medici SET CNP=@CNP, Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdCd=@IdCd, IdA=@IdA, IdDc=@IdDc WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = medic.Id;
                    command.Parameters.Add(paramId);

                    var paramCnp = command.CreateParameter();
                    paramCnp.ParameterName = "@CNP";
                    paramCnp.Value = medic.CNP;
                    command.Parameters.Add(paramCnp);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = medic.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = medic.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = medic.Dob;
                    command.Parameters.Add(paramDob);

                    var paramIdS = command.CreateParameter();
                    paramIdS.ParameterName = "@IdS";
                    paramIdS.Value = medic.IdS;
                    command.Parameters.Add(paramIdS);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = medic.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdDc = command.CreateParameter();
                    paramIdDc.ParameterName = "@IdDc";
                    paramIdDc.Value = medic.IdDc;
                    command.Parameters.Add(paramIdDc);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return medic;
                    }

                    return null;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public Medic FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "SELECT * FROM Medici WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            var medic = new Medic();
                            medic.Id = result.GetInt32(0);
                            medic.CNP = result.GetString(1);
                            medic.Nume = result.GetString(2);
                            medic.Prenume = result.GetString(3);
                            medic.Dob = result.GetDateTime(4);
                            medic.IdS = result.GetInt32(5);
                            medic.IdA = result.GetInt32(6);
                            medic.IdDc = result.GetInt32(7);

                            return medic;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public Medic FindByUsername(string username)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select med.* from Medici med, Accounts a where a.Username = @Username and a.IdM = med.Id";
                    var paramUsername = command.CreateParameter();
                    paramUsername.ParameterName = "@Username";
                    paramUsername.Value = username;
                    command.Parameters.Add(paramUsername);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            var medic = new Medic();
                            medic.Id = result.GetInt32(0);
                            medic.CNP = result.GetString(1);
                            medic.Nume = result.GetString(2);
                            medic.Prenume = result.GetString(3);
                            medic.Dob = result.GetDateTime(4);
                            medic.IdS = result.GetInt32(5);
                            medic.IdA = result.GetInt32(6);
                            medic.IdDc = result.GetInt32(7);

                            return medic;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public Medic FindByIdAccount(int idAccount)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "select med.* from Medici med, Accounts a where a.Id = @IdAcc and a.IdM = med.Id";
                    var paramIdAcc = command.CreateParameter();
                    paramIdAcc.ParameterName = "@IdAcc";
                    paramIdAcc.Value = idAccount;
                    command.Parameters.Add(paramIdAcc);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            var medic = new Medic();
                            medic.Id = result.GetInt32(0);
                            medic.CNP = result.GetString(1);
                            medic.Nume = result.GetString(2);
                            medic.Prenume = result.GetString(3);
                            medic.Dob = result.GetDateTime(4);
                            medic.IdS = result.GetInt32(5);
                            medic.IdA = result.GetInt32(6);
                            medic.IdDc = result.GetInt32(7);

                            return medic;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }

        }

        public List<Medic> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Medic> toReturn = new List<Medic>();
                    command.CommandText = "SELECT * FROM Medici"; //TODO doesnt work
                    using (var result = command.ExecuteReader())
                    {
                        Console.WriteLine("si aici");
                        while (result.Read())
                        {
                            Console.WriteLine("chiar si aici");
                            Medic medic = new Medic {
                                Id = result.GetInt32(0),
                                CNP = result.GetString(1),
                                Nume = result.GetString(2),
                                Prenume = result.GetString(3),
                                Dob = result.GetDateTime(4),
                                IdS = result.GetInt32(5),
                                IdA = result.GetInt32(6),
                                IdDc = result.GetInt32(7)
                            };

                            toReturn.Add(medic);
                        }

                        foreach (var m in toReturn)
                        {
                            Console.WriteLine("m-- " + m.CNP);
                        }

                    }
                    connection.Close();
                    return toReturn;
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    connection.Close();
                    throw new RepositoryException("Returnarea medicilor din baza de date nu s-a putut realiza cu succes.");
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
                    connection.Open();
                    var da = new SqlDataAdapter("SELECT * FROM Medici", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    rowsAffected = da.Update(dataSet.Tables["Medici"]);
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
                    var da = new SqlDataAdapter("SELECT * FROM Medici", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    var dt = new DataTable("Medici");
                    ds.Tables.Add(dt);
                    da.Fill(ds, "Medici");
                    return ds;
                }
            } catch (Exception)
            {
                throw new RepositoryException("Unable to get data set from the database.");
            }
        }
    }
}