using ISSApp.Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ISSApp.Repository
{
    public class SQLSpitalRepo : ISQLRepo<Spital>
    {
        public void Add(Spital entity)
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
            }
            catch (SqlException e)
            {
                Globals.getDBConnection().Close();
                throw new Exception("Database insert failed.");
            }
        }

        public Spital Delete(Spital entity)
        {
            string query = "DELETE FROM Spitale WHERE Id = @IdEntity";
            SqlCommand command = new SqlCommand(query, Globals.getDBConnection());
            command.Parameters.Add("@IdEntity", SqlDbType.Int);
            command.Parameters["@IdEntity"].Value = entity.Id;

            Globals.getDBConnection().Open();
            command.ExecuteNonQuery();
            return entity;
        }

        public List<Spital> FindAll()
        {
            throw new NotImplementedException();
        }

        public Spital FindEntity(Spital entity)
        {
            throw new NotImplementedException();
        }

        public Spital Update(Spital entity)
        {
            throw new NotImplementedException();
        }
    }
}
