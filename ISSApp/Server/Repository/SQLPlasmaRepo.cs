using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlPlasmaRepo : ISqlRepo<PSPlasma>
    {
        public void Add(PSPlasma psPlasma)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO PSPlasme(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD) VALUES (@Cantitate, @Target, @DataExpirare, @Grupa, @Rh, @IdCD)";

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psPlasma.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psPlasma.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psPlasma.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psPlasma.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psPlasma.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psPlasma.IdCD;
                    command.Parameters.Add(paramIdCD);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public PSPlasma Delete(PSPlasma psPlasma)
        {
            IDbConnection connection = Globals.GetDbConnection();
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

                } catch (SqlException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public PSPlasma Update(PSPlasma psPlasma)
        {
            IDbConnection connection = Globals.GetDbConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PSPlasme SET Cantitate=@Cantitate, Target=@Target, DataExpirare=@DataExpirare, Grupa=@Grupa, @Rh=@Rh, IdCD=@IdCD WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = psPlasma.Id;
                    command.Parameters.Add(paramId);

                    var paramCantitate = command.CreateParameter();
                    paramCantitate.ParameterName = "@Cantitate";
                    paramCantitate.Value = psPlasma.Cantitate;
                    command.Parameters.Add(paramCantitate);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = psPlasma.Target;
                    command.Parameters.Add(paramTarget);

                    var paramDataExpirare = command.CreateParameter();
                    paramDataExpirare.ParameterName = "@DataExpirare";
                    paramDataExpirare.Value = psPlasma.DataExpirare;
                    command.Parameters.Add(paramDataExpirare);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    paramGrupa.Value = psPlasma.Grupa;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    paramRh.Value = psPlasma.Rh;
                    command.Parameters.Add(paramRh);

                    var paramIdCD = command.CreateParameter();
                    paramIdCD.ParameterName = "@IdCD";
                    paramIdCD.Value = psPlasma.IdCD;
                    command.Parameters.Add(paramIdCD);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return psPlasma;
                    }

                    return null;
                } catch (SqlException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public PSPlasma FindEntity(int id)
        {
            IDbConnection connection = Globals.GetDbConnection();
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
                            psPlasma.Cantitate = result.GetFloat(1);
                            psPlasma.Target = result.GetString(2);
                            psPlasma.DataExpirare = result.GetDateTime(3);
                            psPlasma.Grupa = result.GetString(4);
                            psPlasma.Rh = result.GetString(5);
                            psPlasma.IdCD = result.GetInt32(6);

                            return psPlasma;
                        }

                        return null;
                    }

                } catch (SqlException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<PSPlasma> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
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
                            PSPlasma psPlasma = new PSPlasma {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psPlasma);
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new RepositoryException("Returnarea plasmei din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public List<PSPlasma> FindByTarget(string target)
        {
            IDbConnection connection = Globals.GetDbConnection();
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
                            PSPlasma psPlasma = new PSPlasma {
                                Id = result.GetInt32(0),
                                Cantitate = result.GetFloat(1),
                                Target = result.GetString(2),
                                DataExpirare = result.GetDateTime(3),
                                Grupa = result.GetString(4),
                                Rh = result.GetString(5),
                                IdCD = result.GetInt32(6)
                            };

                            toReturn.Add(psPlasma);
                        }
                    }

                    return toReturn;
                } catch (SqlException)
                {
                    throw new RepositoryException("Returnarea plasmei pentru un target din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}