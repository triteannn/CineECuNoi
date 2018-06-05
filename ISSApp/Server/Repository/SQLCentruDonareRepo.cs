using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
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

                    if (entity.IdAdr != null)
                        paramIdAdr.Value = entity.IdAdr;
                    else
                        paramIdAdr.Value = DBNull.Value;

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
                        "UPDATE CentreDonare SET Denumire=@Denumire, IdAdr=@IdAdr, NeedBlood=@NeedBlood WHERE Id=@Id";

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

                    var paramNeed = command.CreateParameter();
                    paramNeed.ParameterName = "@NeedBlood";
                    paramNeed.Value = entity.NeedBlood;
                    command.Parameters.Add(paramNeed);

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
                            var centruDonare = new CentruDonare();
                            centruDonare.Id = result.GetInt32(0);
                            centruDonare.Denumire = result.GetString(1);
                            int? idAdr = null;
                            if (result[2] != DBNull.Value)
                                idAdr = result.GetInt32(2);
                            centruDonare.IdAdr = idAdr;
                            centruDonare.NeedBlood = result.GetInt32(3);

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
                            int? idAdr = null;
                            if (result[2] != DBNull.Value)
                                idAdr = result.GetInt32(2);
                            CentruDonare centru = new CentruDonare {
                                Id = result.GetInt32(0),
                                Denumire = result.GetString(1),
                                IdAdr = idAdr
                            };

                            toReturn.Add(centru);
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
                            int? idAdr = null;
                            if (result[2] != DBNull.Value)
                                idAdr = result.GetInt32(2);
                            var centruDonare = new CentruDonare {
                                Id = result.GetInt32(0),
                                Denumire = result.GetString(1),
                                IdAdr = idAdr
                            };

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

        public int AdminUpdateDataBase(DataSet dataSet)
        {
            try
            {
                int rowsAffected;
                using (var connection = Globals.GetDbConnection())
                {
                    connection.Open();
                    var da = new SqlDataAdapter("SELECT * FROM CentreDonare", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    rowsAffected = da.Update(dataSet.Tables["CentreDonare"]);
                }
                return rowsAffected;
            } catch (SqlException)
            {

                throw new RepositoryException("Unable to update the database. Please check your changes.");

            }
        }

        public DataSet AdminGetDataSet()
        {
            try
            {
                using (var connection = Globals.GetDbConnection())
                {
                    connection.Open();
                    var ds = new DataSet();
                    var da = new SqlDataAdapter("SELECT * FROM CentreDonare", connection);
                    var cb = new SqlCommandBuilder(da);
                    da.DeleteCommand = cb.GetDeleteCommand();
                    da.InsertCommand = cb.GetInsertCommand();
                    da.UpdateCommand = cb.GetUpdateCommand();
                    var dt = new DataTable("CentreDonare");
                    ds.Tables.Add(dt);
                    da.Fill(ds, "CentreDonare");
                    return ds;
                }
            } catch (SqlException)
            {
                throw new RepositoryException("Unable to get data set from the database.");
            }
        }
    }
}