using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlAngajatRepo : ISqlRepo<AngajatCentru>
    {
        public void Add(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "INSERT INTO AngajatiCentru(CNP, Nume, Prenume, Dob, IdA, IdCd) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdA, @IdCd)";

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

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = angajatCentru.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = angajatCentru.IdCd;
                    command.Parameters.Add(paramIdCd);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }
                
            }
        }

        public AngajatCentru Delete(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM AngajatiCentru WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = angajatCentru.CNP;
                    command.Parameters.Add(paramCNP);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }
                
            }
        }

        public AngajatCentru Update(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "UPDATE AngajatiCentru SET Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdA=@IdA, IdCd=@IdCd WHERE CNP=@CNP";

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

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = angajatCentru.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = angajatCentru.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }
                
            }
        }

        public AngajatCentru FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM AngajatiCentru WHERE Id=@Id";
                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@Id";
                    paramCNP.Value = id;
                    command.Parameters.Add(paramCNP);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            String cnp = result.GetString(1);
                            String nume = result.GetString(2);
                            String prenume = result.GetString(3);
                            DateTime date = result.GetDateTime(4);

                            AngajatCentru angajat = new AngajatCentru(cnp, nume, prenume, date);
                            return angajat;
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

        public List<AngajatCentru> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
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
                            toReturn.Add(new AngajatCentru(result.GetString(1), result.GetString(2), result.GetString(3), result.GetDateTime(4)));
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