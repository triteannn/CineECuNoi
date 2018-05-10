using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlDonatorRepo : ISqlRepo<Donator>
    {
        public void Add(Donator donator)
        {
            var connection = Globals.getDBConnection();
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
                    paramDob.Value = donator.Dob;
                    command.Parameters.Add(paramDob);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = donator.IdA;
                    command.Parameters.Add(paramIdA);

                    command.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    throw new Exception("Database insert failed.");
                }

            }

        }

        public Donator Delete(Donator donator)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Donator WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = donator.CNP;
                    command.Parameters.Add(paramCNP);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return donator;
                    }

                    return null;

                }
                catch (SqlException e)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public Donator Update(Donator donator)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE Donator SET Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdA=@IdA WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = donator.CNP;
                    command.Parameters.Add(paramCNP);

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
                    paramDob.Value = donator.Dob;
                    command.Parameters.Add(paramDob);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = donator.IdA;
                    command.Parameters.Add(paramIdA);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return donator;
                    }

                    return null;
                }
                catch (SqlException e)
                {
                    throw new Exception("Database update failed.");
                }
            }
        }

        public Donator FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM Donator WHERE Id=@Id";
                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@Id";
                    paramCNP.Value = id;
                    command.Parameters.Add(paramCNP);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            String cnp = result.GetString(0);
                            String nume = result.GetString(1);
                            String prenume = result.GetString(2);
                            DateTime date = result.GetDateTime(3);

                            Donator donator = new Donator(cnp, nume, prenume, date);
                            return donator;
                        }

                        return null;
                    }

                }
                catch (SqlException e)
                {
                    throw new Exception("Database getOne failed.");
                }

            }
        }

        public List<Donator> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Donator> toReturn = new List<Donator>();
                    command.CommandText = "SELECT * FROM Donator";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            toReturn.Add(new Donator(result.GetString(0), result.GetString(1), result.GetString(2), result.GetDateTime(3)));
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new Exception("Database get failed.");
                }
            }
        }
    }
}