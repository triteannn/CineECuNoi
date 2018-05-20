using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ISSApp.Exceptions;

namespace Server.Repository
{
    public class SqlTrombociteRepo : ISqlRepo<PSTrombocite>
    {
        public void Add(PSTrombocite psTrombocite)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PSTrombocite(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD) VALUES (@Cantitate, @Target, @DataExpirare, @Grupa, @Rh, @IdCD)";

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psTrombocite.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psTrombocite.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psTrombocite.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psTrombocite.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psTrombocite.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psTrombocite.IdCD;
                    command.Parameters.Add(paramIdCD);

                    command.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
        }


        public PSTrombocite Delete(PSTrombocite psTrombocite)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM PSTrombocite WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psTrombocite.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psTrombocite;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public PSTrombocite Update(PSTrombocite psTrombocite)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PSTrombocite SET Cantitate=@Cantitate, Target=@Target, DataExpirare=@DataExpirare, Grupa=@Grupa, @Rh=@Rh, IdCD=@IdCD WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psTrombocite.Id;
                    command.Parameters.Add(paramId);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psTrombocite.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psTrombocite.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psTrombocite.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psTrombocite.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psTrombocite.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psTrombocite.IdCD;
                    command.Parameters.Add(paramIdCD);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psTrombocite;
                    }

                    return null;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public PSTrombocite FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM PSTrombocite WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            PSTrombocite psTrombocite = new PSTrombocite();
                            psTrombocite.Id = result.GetInt32(0);
                            psTrombocite.Cantitate = result.GetFloat(1);
                            psTrombocite.Target = result.GetString(2);
                            psTrombocite.DataExpirare = result.GetDateTime(3);
                            psTrombocite.Grupa = result.GetString(4);
                            psTrombocite.Rh = result.GetString(5);
                            psTrombocite.IdCD = result.GetInt32(6);

                            return psTrombocite;
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

        public List<PSTrombocite> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSTrombocite> toReturn = new List<PSTrombocite>();
                    command.CommandText = "SELECT * FROM PSTrombocite";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSTrombocite psTrombocite = new PSTrombocite
                            {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psTrombocite);
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Returnarea trombocitelor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public List<PSTrombocite> FindByTarget(string target)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSTrombocite> toReturn = new List<PSTrombocite>();
                    command.CommandText = "SELECT * FROM PSTrombocite WHERE Target=@Target";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = target;
                    command.Parameters.Add(paramTarget);

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSTrombocite psTrombocite = new PSTrombocite
                            {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psTrombocite);
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Returnarea trombocitelor pentru un target din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}