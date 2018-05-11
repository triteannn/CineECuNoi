using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
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
                        "INSERT INTO PSTrombocite(Id, DataRecoltare, Cantitate, Target, IdFc) VALUES (@Id, @DataRecoltare, @Cantitate, @Target, @IdFc)";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psTrombocite.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psTrombocite.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psTrombocite.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psTrombocite.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psTrombocite.IdFc;
                    command.Parameters.Add(paramIdFc);

                    command.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    throw new Exception("Database insert failed.");
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
                catch (SqlException e)
                {
                    throw new Exception("Database delete failed.");
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
                        "UPDATE PSTrombocite SET DataRecoltare=@DataRecoltare, Cantitate=@Cantitate, Target=@Target, IdFc=@IdFc WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psTrombocite.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psTrombocite.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psTrombocite.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psTrombocite.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psTrombocite.IdFc;
                    command.Parameters.Add(paramIdFc);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psTrombocite;
                    }

                    return null;
                }
                catch (SqlException e)
                {
                    throw new Exception("Database update failed.");
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
                            psTrombocite.DataRecoltare = result.GetDateTime(1);
                            psTrombocite.Cantitate = result.GetFloat(2);
                            psTrombocite.Target = result.GetString(3);
                            psTrombocite.IdFc = result.GetInt32(4);

                            return psTrombocite;
                        }

                        return null;
                    }

                }
                catch (SqlException e)
                {
                    throw new Exception("Database getOne failed.");
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
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psTrombocite);
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new Exception("Database getAll failed.");
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
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psTrombocite);
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new Exception("Database getTarget failed.");
                }
            }
        }
    }
}