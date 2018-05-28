using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSApp.Domain;
using ISSApp.Exceptions;

namespace Server.Repository
{
    class SQLDateContact : ISqlRepo<DateContact>
    {
        public void Add(DateContact entity)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO DateContact(Telefon, Email, IdAdr) VALUES (@Telefon, @Email, @IdAdr)";

                    var paramTelefon = command.CreateParameter();
                    paramTelefon.ParameterName = "@Telefon";
                    paramTelefon.Value = entity.Telefon;
                    command.Parameters.Add(paramTelefon);

                    var paramEmail = command.CreateParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = entity.Email;
                    command.Parameters.Add(paramEmail);

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
        }

        public DateContact Delete(DateContact entity)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM DateContact WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public DateContact Update(DateContact entity)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE DateContact SET Telefon=@Telefon, Email=@Email, IdAdr=@IdAdr WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = entity.Id;
                    command.Parameters.Add(paramId);

                    var paramTelefon = command.CreateParameter();
                    paramTelefon.ParameterName = "@Telefon";
                    paramTelefon.Value = entity.Telefon;
                    command.Parameters.Add(paramTelefon);

                    var paramEmail = command.CreateParameter();
                    paramEmail.ParameterName = "@Email";
                    paramEmail.Value = entity.Email;
                    command.Parameters.Add(paramEmail);

                    var paramIdAdr = command.CreateParameter();
                    paramIdAdr.ParameterName = "@IdAdr";
                    paramIdAdr.Value = entity.IdAdr;
                    command.Parameters.Add(paramIdAdr);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public DateContact FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM DateContact WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int idData = result.GetInt32(0);
                            String telefon = result.GetString(1);
                            String email = result.GetString(2);
                            int idAdresa = result.GetInt32(3);

                            DateContact dataContact = new DateContact(idData, telefon, email, idAdresa);
                            return dataContact;
                        }

                        return null;
                    }

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<DateContact> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<DateContact> toReturn = new List<DateContact>();
                    command.CommandText = "SELECT * FROM DateContact";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            toReturn.Add(new DateContact(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetInt32(3)));
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Returnarea datelor de contact din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}
