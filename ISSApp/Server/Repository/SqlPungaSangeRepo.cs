using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlPungaSangeRepo : ISqlRepo<PungaSange>
    {
        public void Add(PungaSange pungaSange)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PungiSange(Id, DataRecoltare, Grupa, Rh, Target, IdCd) VALUES (@Id, @DataRecoltare, @Grupa, @Rh, @Target, @IdCd)";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = pungaSange.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = pungaSange.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = pungaSange.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = pungaSange.Rh;
                    command.Parameters.Add(paramRh);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = pungaSange.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = pungaSange.IdCd;
                    command.Parameters.Add(paramIdCd);
                
                    command.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public PungaSange Delete(PungaSange pungaSange)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM PungiSange WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = pungaSange.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return pungaSange;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public PungaSange Update(PungaSange pungaSange)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PungiSange SET DataRecoltare=@DataRecoltare, Grupa=@Grupa, Rh=@Rh, Target=@Target, IdCd=@IdCd WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = pungaSange.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = pungaSange.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = pungaSange.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = pungaSange.Rh;
                    command.Parameters.Add(paramRh);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = pungaSange.Target;
                    command.Parameters.Add(paramTarget);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = pungaSange.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return pungaSange;
                    }

                    return null;
                }
                catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }
            }
        }

        public PungaSange FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM PungiSange WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {

                            PungaSange pungaSange = new PungaSange
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Grupa = result.GetString(2),
                                Rh = result.GetString(3),
                                Target = result.GetString(4),
                                IdCd = result.GetInt32(5)

                            };

                            return pungaSange;
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

        public List<PungaSange> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PungaSange> toReturn = new List<PungaSange>();
                    command.CommandText = "SELECT * FROM PungiSange";


                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {

                            PungaSange pungaSange = new PungaSange
                            {
                                Id = result.GetInt32(0),
                                DataRecoltare = result.GetDateTime(1),
                                Grupa = result.GetString(2),
                                Rh = result.GetString(3),
                                Target = result.GetString(4),
                                IdCd = result.GetInt32(5)

                            };

                            toReturn.Add(pungaSange);
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

        public List<PungaSange> FindByTarget(string target)
        {
            //TO IMPLEMET
            return null;
        }
    }
}
