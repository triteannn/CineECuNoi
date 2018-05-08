using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlCentruDonareRepo : ISqlRepo<CentruDonare>
    {
        public void Add(CentruDonare entity)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    string querry = "INSERT INTO CentreDonare(Denumire,IdAdr) VALUES(@Denumire,@IdAdresa)";
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

        public CentruDonare Delete(CentruDonare entity)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    string query = "DELETE FROM CentreDonare WHERE Id = @IdEntity";
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

        public List<CentruDonare> FindAll()
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    List<CentruDonare> toReturn = new List<CentruDonare>();
                    string query = "SELECT * FROM CentreDonare";
                    SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        toReturn.Add(new CentruDonare(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    reader.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    throw new Exception("Database get failed.");
                }
            }
        }

        public CentruDonare FindEntity(int id)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    CentruDonare CentruDonare = null;
                    List<CentruDonare> toReturn = new List<CentruDonare>();
                    string query = "SELECT * FROM CentreDonare WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = id;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CentruDonare = new CentruDonare(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                    }
                    reader.Close();
                    return CentruDonare;
                } catch (SqlException)
                {
                    throw new Exception("Database get failed.");
                }
            }
        }

        public CentruDonare Update(CentruDonare entity)
        {
            using (Globals.getDBConnection())
            {
                try
                {
                    string querry = "UPDATE CentreDonare SET Denumire=@Denumire, IdAdr=@IdAdr WHERE Id=@Id";
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
