using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ISSApp.Repository
{
    public class SqlGlobuleRosiiRepo : ISqlRepo<PSGlobuleRosii>
    {
        public void Add(PSGlobuleRosii psGlobuleRosii)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PSGlobuleRosii(Id, DataRecoltare, Cantitate, Target, IdFc) VALUES (@Id, @DataRecoltare, @Cantitate, @Target, @IdFc)";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psGlobuleRosii.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psGlobuleRosii.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psGlobuleRosii.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psGlobuleRosii.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psGlobuleRosii.IdFc;
                    command.Parameters.Add(paramIdFc);
                    
                    command.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public PSGlobuleRosii Delete(PSGlobuleRosii psGlobuleRosii)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM PSGlobuleRosii WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psGlobuleRosii.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psGlobuleRosii;
                    }

                    return null;

                }
                catch (SqlException e)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public PSGlobuleRosii Update(PSGlobuleRosii psGlobuleRosii)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PSGlobuleRosii SET DataRecoltare=@DataRecoltare, Cantitate=@Cantitate, Target=@Target, IdFc=@IdFc WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psGlobuleRosii.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = psGlobuleRosii.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psGlobuleRosii.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psGlobuleRosii.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdFc = command.CreateParameter();
                    paramIdFc.ParameterName = "@IdFc";
                    paramIdFc.Value = psGlobuleRosii.IdFc;
                    command.Parameters.Add(paramIdFc);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psGlobuleRosii;
                    }

                    return null;
                }
                catch (SqlException e)
                {
                    throw new Exception("Database update failed.");
                }
            }
        }

        public PSGlobuleRosii FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM PSGlobuleRosii WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            PSGlobuleRosii psGlobuleRosii = new PSGlobuleRosii();
                            psGlobuleRosii.Id = result.GetInt32(0);
                            psGlobuleRosii.DataRecoltare = result.GetDateTime(1);
                            psGlobuleRosii.Cantitate = result.GetFloat(2);
                            psGlobuleRosii.Target = result.GetString(3);
                            psGlobuleRosii.IdFc = result.GetInt32(4);

                            return psGlobuleRosii;
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

        public List<PSGlobuleRosii> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSGlobuleRosii> toReturn = new List<PSGlobuleRosii>();
                    command.CommandText = "SELECT * FROM Donator";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSGlobuleRosii psGlobuleRosii = new PSGlobuleRosii
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psGlobuleRosii);
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

        public List<PSGlobuleRosii> FindByTarget(string target)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSGlobuleRosii> toReturn = new List<PSGlobuleRosii>();
                    command.CommandText = "SELECT * FROM Donator WHERE Target=@Target";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = target;
                    command.Parameters.Add(paramTarget);

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSGlobuleRosii psGlobuleRosii = new PSGlobuleRosii
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Cantitate = result.GetFloat(2),
                                Target = result.GetString(3),
                                IdFc = result.GetInt32(4)
                            };

                            toReturn.Add(psGlobuleRosii);
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
    }
}