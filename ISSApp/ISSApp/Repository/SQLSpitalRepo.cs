using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
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
                    command.CommandText = "INSERT INTO Spitale(Denumire) VALUES(@Denumire)";

                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = entity.Denumire;
                    command.Parameters.Add(paramDenumire);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new Exception("Database insert failed.");
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
                catch(SqlException)
                {
                    connection.Close();
                    throw new Exception("Database delete failed.");
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
                    command.CommandText = "UPDATE Spitale SET Denumire=@Denumire WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = entity.Id;
                    command.Parameters.Add(paramDenumire);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new Exception("Database update failed.");
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
                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new Exception("Database get failed.");
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
                    List<Spital> toReturn = new List<Spital>();
                    Spital spital = null;
                    command.CommandText = "SELECT * FROM Spitale";
                    
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        toReturn.Add(new Spital(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    reader.Close();
                    connection.Close();
                    return toReturn;
                }
                catch (SqlException)
                {
                    connection.Close();
                    throw new Exception("Database get failed.");
                }
            }
        }
    }
}
