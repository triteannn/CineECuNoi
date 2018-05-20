using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ISSApp.Exceptions;

namespace Server.Repository
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
                    paramDob.Value = donator.Dob;
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

                } catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
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
                    command.CommandText = "DELETE FROM Donatori WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = donator.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return donator;
                    }

                    return null;

                } catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
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
                        "UPDATE Donatori SET CNP=@CNP, Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdCd=@IdCd, IdA=@IdA, IdDc=@IdDc WHERE Id=@Id";


                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = donator.Id;
                    command.Parameters.Add(paramId);

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

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return donator;
                    }

                    return null;
                } catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
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
                    command.CommandText = "SELECT * FROM Donatori WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int idDonator = result.GetInt32(0);
                            String cnp = result.GetString(1);
                            String nume = result.GetString(2);
                            String prenume = result.GetString(3);
                            DateTime date = result.GetDateTime(4);

                            Donator donator = new Donator(cnp, nume, prenume, date);
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
            IDbConnection connection = Globals.getDBConnection();
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
                            toReturn.Add(new Donator(result.GetString(1), result.GetString(2), result.GetString(3), result.GetDateTime(4)));
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new RepositoryException("Returnarea donatorilor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public int GetLastId()
        {
            var id = 0;
            using (var connection = Globals.getDBConnection())
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
    }
}