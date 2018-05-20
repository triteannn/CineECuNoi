using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ISSApp.Exceptions;

namespace Server.Repository
{
    public class SqlCentruDonareRepo : ISqlRepo<CentruDonare>
    {
        public void Add(CentruDonare entity)
        {
            var connection = Globals.getDBConnection();
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

                }
                catch (RepositoryException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public CentruDonare Delete(CentruDonare entity)
        {
            IDbConnection connection = Globals.getDBConnection();
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

                }
                catch (RepositoryException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public CentruDonare Update(CentruDonare entity)
        {
            IDbConnection connection = Globals.getDBConnection();
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
                }
                catch (RepositoryException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public CentruDonare FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
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
    
                            return centruDonare;
                        }

                        return null;
                    }

                }
                catch (RepositoryException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<CentruDonare> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
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
                            CentruDonare psPlasma = new CentruDonare
                            {
                                Id = result.GetInt32(0),
                                Denumire = result.GetString(1),
                            };

                            toReturn.Add(psPlasma);
                        }
                    }

                    return toReturn;
                }
                catch (RepositoryException)
                {
                    throw new RepositoryException("Returnarea centrelor de donare din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
        
}
