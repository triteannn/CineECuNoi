using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ISSApp.Exceptions;

namespace Server.Repository
{
    public class SqlSpitalRepo : ISqlRepo<Spital>
    {
        public void Add(Spital entity)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "INSERT INTO Spitale(Denumire, IdAdr) VALUES(@Denumire, @IdAdr)";

                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = entity.Denumire;
                    command.Parameters.Add(paramDenumire);

                    var paramIdAdr = command.CreateParameter();
                    paramIdAdr.ParameterName = "@IdAdr";
                    paramIdAdr.Value = entity.IdAdr;
                    command.Parameters.Add(paramIdAdr);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }
            }
            connection.Close();
        }

        public Spital Delete(Spital entity)
        {

            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Spitale WHERE Id = @IdEntity";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@IdEntity";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }
            }
            connection.Close();
            return entity;
        }

        public Spital Update(Spital entity)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "UPDATE Spitale SET Denumire=@Denumire, IdAdr=@IdAdr WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = entity.Denumire;
                    command.Parameters.Add(paramDenumire);

                    var paramIdAdr = command.CreateParameter();
                    paramIdAdr.ParameterName = "@IdAdr";
                    paramIdAdr.Value = entity.IdAdr;
                    command.Parameters.Add(paramIdAdr);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
            connection.Close();
            return entity;
        }

        public Spital FindEntity(int id)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    Spital spital = null;
                    command.CommandText = "SELECT * FROM Spitale WHERE Id = @Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spital = new Spital(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                    }
                    reader.Close();
                    connection.Close();
                    return spital;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }
            }
        }

        public List<Spital> FindAll()
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    var toReturn = new List<Spital>();
                    command.CommandText = "SELECT * FROM Spitale";

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        toReturn.Add(new Spital(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    reader.Close();
                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea spitalelor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}
