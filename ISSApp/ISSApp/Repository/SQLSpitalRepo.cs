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
            using (Globals.getDBConnection())
            {
                try
                {
                    string querry = "INSERT INTO Spitale(Denumire,IdAdr) VALUES(@Denumire,@IdAdresa)";
                    SqlCommand command = new SqlCommand(querry, Globals.getDBConnection());
                    command.Parameters.Add("@IdAdresa", SqlDbType.Int);
                    command.Parameters["@IdAdresa"].Value = entity.IdAdr;
                    command.Parameters.AddWithValue("@Denumire", entity.Denumire);

                    Globals.getDBConnection().Open();
                    command.ExecuteNonQuery();
                } catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }
            }
        }

        public Spital Delete(Spital entity)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    string query = "DELETE FROM Spitale WHERE Id = @IdEntity";
                    SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
                    command.Parameters.Add("@IdEntity", SqlDbType.Int);
                    command.Parameters["@IdEntity"].Value = entity.Id;

                    Globals.getDBConnection().Open();
                    command.ExecuteNonQuery();
                    return entity;
                } catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }
            }
        }

        public List<Spital> FindAll()
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    List<Spital> toReturn = new List<Spital>();
                    string query = "SELECT * FROM Spitale";
                    SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        toReturn.Add(new Spital(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    reader.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    throw new Exception("Database get failed.");
                }
            }
        }

        public Spital FindEntity(int id)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    Spital spital = null;
                    List<Spital> toReturn = new List<Spital>();
                    string query = "SELECT * FROM Spitale WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = id;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spital = new Spital(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                    }
                    reader.Close();
                    return spital;
                } catch (SqlException)
                {
                    throw new Exception("Database get failed.");
                }
            }
        }

        public Spital Update(Spital entity)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    string querry = "UPDATE Spitale SET Denumire=@Denumire, IdAdr=@IdAdr WHERE Id=@Id";
                    SqlCommand command = new SqlCommand(querry, Globals.getDBConnection());
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = entity.Id;
                    command.Parameters.Add("@IdAdr", SqlDbType.Int);
                    command.Parameters["@IdAdr"].Value = entity.IdAdr;
                    command.Parameters.AddWithValue("@Denumire", entity.Denumire);

                    Globals.getDBConnection().Open();
                    command.ExecuteNonQuery();
                    return entity;
                } catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }
            }
        }
    }
}
