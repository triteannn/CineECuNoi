using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlGlobuleRosiiRepo : ISqlRepo<PSGlobuleRosii>
    {
        public void Add(PSGlobuleRosii psGlobuleRosii)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PSGlobuleRosii(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD) VALUES (@Cantitate, @Target, @DataExpirare, @Grupa, @Rh, @IdCD)";

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psGlobuleRosii.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psGlobuleRosii.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psGlobuleRosii.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psGlobuleRosii.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psGlobuleRosii.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psGlobuleRosii.IdCD;
                    command.Parameters.Add(paramIdCD);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public PSGlobuleRosii Delete(PSGlobuleRosii psGlobuleRosii)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                    connection.Close();
                    if (result != 0)
                    {
                        return psGlobuleRosii;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public PSGlobuleRosii Update(PSGlobuleRosii psGlobuleRosii)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PSGlobuleRosii SET Cantitate=@Cantitate, Target=@Target, DataExpirare=@DataExpirare, Grupa=@Grupa, @Rh=@Rh, IdCD=@IdCD WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psGlobuleRosii.Id;
                    command.Parameters.Add(paramId);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psGlobuleRosii.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psGlobuleRosii.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psGlobuleRosii.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psGlobuleRosii.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psGlobuleRosii.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psGlobuleRosii.IdCD;
                    command.Parameters.Add(paramIdCD);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return psGlobuleRosii;
                    }

                    return null;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public PSGlobuleRosii FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
            
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
                            psGlobuleRosii.Cantitate = result.GetFloat(1);
                            psGlobuleRosii.Target = result.GetString(2);
                            psGlobuleRosii.DataExpirare = result.GetDateTime(3);
                            psGlobuleRosii.Grupa = result.GetString(4);
                            psGlobuleRosii.Rh = result.GetString(5);
                            psGlobuleRosii.IdCD = result.GetInt32(6);

                            return psGlobuleRosii;
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

        public List<PSGlobuleRosii> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSGlobuleRosii> toReturn = new List<PSGlobuleRosii>();
                    command.CommandText = "SELECT * FROM PSGlobuleRosii";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSGlobuleRosii psGlobuleRosii = new PSGlobuleRosii {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psGlobuleRosii);
                        }
                    }

                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea globulelor rosii din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public List<PSGlobuleRosii> FindByTarget(string target)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PSGlobuleRosii> toReturn = new List<PSGlobuleRosii>();
                    command.CommandText = "SELECT * FROM PSGlobuleRosii WHERE Target=@Target";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = target;
                    command.Parameters.Add(paramTarget);

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            PSGlobuleRosii psGlobuleRosii = new PSGlobuleRosii {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psGlobuleRosii);
                        }
                    }
                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea globulelor rosii pentru un target din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}