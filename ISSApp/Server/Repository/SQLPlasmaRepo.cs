using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlPlasmaRepo : ISqlRepo<PSPlasma>
    {
        public void Add(PSPlasma psPlasma)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PSPlasme(Id, DataRecoltare, Cantitate, Target, IdFc) VALUES (@Id, @DataRecoltare, @Cantitate, @Target, @IdFc)";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psPlasma.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psPlasma.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psPlasma.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psPlasma.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psPlasma.IdFc;
                    command.Parameters.Add(paramIdFc);

                    command.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public PSPlasma Delete(PSPlasma psPlasma)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM PSPlasme WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psPlasma.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psPlasma;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public PSPlasma Update(PSPlasma psPlasma)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PSPlasme SET DataRecoltare=@DataRecoltare, Cantitate=@Cantitate, Target=@Target, IdFc=@IdFc WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psPlasma.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psPlasma.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psPlasma.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psPlasma.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psPlasma.IdFc;
                    command.Parameters.Add(paramIdFc);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psPlasma;
                    }

                    return null;
                }
                catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }
            }
        }

        public PSPlasma FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM PSPlasme WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            PSPlasma psPlasma = new PSPlasma();
                            psPlasma.Id = result.GetInt32(0);
                            psPlasma.DataRecoltare = result.GetDateTime(1);
                            psPlasma.Cantitate = result.GetFloat(2);
                            psPlasma.Target = result.GetString(3);
                            psPlasma.IdFc = result.GetInt32(4);

                            return psPlasma;
                        }

                        return null;
                    }

                }
                catch (SqlException)
                {
                    throw new Exception("Database getOne failed.");
                }

            }
        }

        public List<PSPlasma> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSPlasma> toReturn = new List<PSPlasma>();
                    command.CommandText = "SELECT * FROM PSPlasme";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSPlasma psPlasma = new PSPlasma
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psPlasma);
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

        public List<PSPlasma> FindByTarget(string target)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSPlasma> toReturn = new List<PSPlasma>();
                    command.CommandText = "SELECT * FROM PSPlasme WHERE Target=@Target";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = target;
                    command.Parameters.Add(paramTarget);

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSPlasma psPlasma = new PSPlasma
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psPlasma);
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