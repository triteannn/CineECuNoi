using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    class SQLDateContact : ISqlRepo<DateContact>
    {
        public void Add(DateContact entity)
        {
            var connection = Globals.GetDbConnection();
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

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public DateContact Delete(DateContact entity)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                    connection.Close();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public DateContact Update(DateContact entity)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                    connection.Close();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public DateContact FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
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

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<DateContact> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea datelor de contact din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public DateContact GetDateByIdDonator(int idDonator)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            DateContact dateContact = null;
            var cmd = new SqlCommand("SELECT dc.* FROM Donatori d INNER JOIN DateContact dc ON d.IdDC=dc.Id WHERE d.Id = @id");
            cmd.Parameters.AddWithValue("@id", idDonator);

            try
            {
                cmd.Connection = connection;
                using (var result = cmd.ExecuteReader())
                {
                    if (result.Read())
                    {
                        int idData = result.GetInt32(0);
                        String telefon = result.GetString(1);
                        String email = result.GetString(2);
                        int idAdresa = result.GetInt32(3);

                        dateContact = new DateContact(idData, telefon, email, idAdresa);
                    }
                }
                return dateContact;
            } catch (SqlException ex)
            {
                throw new RepositoryException(ex.Message);
            } finally
            {
                connection.Close();
            }
        }

        public DateContact FindLastEntity()
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "SELECT * FROM DateContact WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = "(SELECT MAX(Id) FROM DateContact)";
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int idData = result.GetInt32(0);
                            String telefon = result.GetString(1);
                            String email = result.GetString(2);
                            int? idAdresa = null;
                            if (result[3] != DBNull.Value)
                                idAdresa = result.GetInt32(3);

                            DateContact dataContact = new DateContact(idData, telefon, email, idAdresa);
                            return dataContact;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }
    }
}
