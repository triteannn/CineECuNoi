using ISSApp.Domain;
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
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO Medici(CNP, Nume, Prenume, Dob, IdA, IdS) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdA, @IdS)";

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

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    //paramIdA.Value = medic.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdS = command.CreateParameter();
                    paramIdA.ParameterName = "@IdS";
                    paramIdA.Value = medic.IdS;
                    command.Parameters.Add(paramIdS);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public Medic Delete(Medic medic)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Medici WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = medic.CNP;
                    command.Parameters.Add(paramCNP);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return medic;
                    }

                    return null;

                } catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public Medic Update(Medic medic)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE Medici SET Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdA=@IdA, IdS=@IdS WHERE CNP=@CNP";

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

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    //paramIdA.Value = medic.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdS = command.CreateParameter();
                    paramIdA.ParameterName = "@IdS";
                    paramIdA.Value = medic.IdS;
                    command.Parameters.Add(paramIdS);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return medic;
                    }

                    return null;
                } catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }
            }
        }

        public Medic FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
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
                            //medic.IdA = result.GetInt32(5);
                            medic.IdS = result.GetInt32(6);

                            return medic;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new Exception("Database getOne failed.");
                }

            }
        }

        public List<Medic> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Medic> toReturn = new List<Medic>();
                    command.CommandText = "SELECT * FROM Medici";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            Medic medic = new Medic {
                                Id = result.GetInt32(0),
                                CNP = result.GetString(1),
                                Nume = result.GetString(2),
                                Prenume = result.GetString(3),
                                Dob = result.GetDateTime(4),
                                //IdA = result.GetInt32(5),
                                IdS = result.GetInt32(6)
                            };

                            toReturn.Add(medic);
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new Exception("Database getAll failed.");
                }
            }
        }
    }
}