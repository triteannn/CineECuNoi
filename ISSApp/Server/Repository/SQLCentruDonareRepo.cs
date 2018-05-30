using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlCentruDonareRepo : ISqlRepo<CentruDonare>
    {
        public void Add(CentruDonare entity)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO CentreDonare(Denumire, IdAdr) VALUES (@Denumire, @IdAdr)";

                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = entity.Denumire;
                    command.Parameters.Add(paramDenumire);

                    var paramIdAdr = command.CreateParameter();
                    paramIdAdr.ParameterName = "@IdAdr";
                    paramIdAdr.Value = entity.IdAdr;
                    command.Parameters.Add(paramIdAdr);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                } finally
                {
                    connection.Close();
                }

            }
        }

        public CentruDonare Delete(CentruDonare entity)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM CentreDonare WHERE Id=@Id";

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

                } catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                } finally
                {
                    connection.Close();
                }
            }
        }

        public CentruDonare Update(CentruDonare entity)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE CentreDonare SET Denumire=@Denumire, IdAdr=@IdAdr WHERE Id=@Id";

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

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return entity;
                    }

                    return null;
                } catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                } finally
                {
                    connection.Close();
                }
            }
        }

        public CentruDonare FindEntity(int id)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM CentreDonare WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            CentruDonare centruDonare = new CentruDonare();
                            centruDonare.Id = result.GetInt32(0);
                            centruDonare.Denumire = result.GetString(1);
                            centruDonare.IdAdr = result.GetInt32(2);

                            return centruDonare;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                } finally
                {
                    connection.Close();
                }

            }
        }

        public List<CentruDonare> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<CentruDonare> toReturn = new List<CentruDonare>();
                    command.CommandText = "SELECT * FROM CentreDonare";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            CentruDonare psPlasma = new CentruDonare {
                                Id = result.GetInt32(0),
                                Denumire = result.GetString(1),
                                IdAdr = result.GetInt32(2)
                            };

                            toReturn.Add(psPlasma);
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new RepositoryException("Returnarea centrelor de donare din baza de date nu s-a putut realiza cu succes.");
                } finally
                {
                    connection.Close();
                }
            }
        }

        public CentruDonare FindCentruDonareByDenumire(string denumire)
        {

            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM CentreDonare WHERE Denumire=@Denumire";
                    var paramDenumire = command.CreateParameter();
                    paramDenumire.ParameterName = "@Denumire";
                    paramDenumire.Value = denumire;
                    command.Parameters.Add(paramDenumire);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            CentruDonare centruDonare = new CentruDonare();
                            centruDonare.Id = result.GetInt32(0);
                            centruDonare.Denumire = result.GetString(1);
                            centruDonare.IdAdr = result.GetInt32(2);

                            return centruDonare;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                } finally
                {
                    connection.Close();
                }

            }

        }
    }

}
