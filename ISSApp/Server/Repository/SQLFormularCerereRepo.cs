using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlFormularCerereRepo : ISqlRepo<FormularCerere>
    {
        public void Add(FormularCerere formularCerere)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO FormulareCerere(Target, CantTrombocite, CantPlasma, CantGlobuleRosii, IdM) VALUES (@Target, @CantTrombocite, @CantPlasma, @CantGlobuleRosii, @IdM)";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = formularCerere.Target;
                    command.Parameters.Add(paramTarget);

                    var paramCantTrombocite = command.CreateParameter();
                    paramCantTrombocite.ParameterName = "@CantTrombocite";
                    paramCantTrombocite.Value = formularCerere.CantTrombocite;
                    command.Parameters.Add(paramCantTrombocite);

                    var paramCantPlasma = command.CreateParameter();
                    paramCantPlasma.ParameterName = "@CantPlasma";
                    paramCantPlasma.Value = formularCerere.CantTrombocite;
                    command.Parameters.Add(paramCantPlasma);

                    var paramCantGlobuleRosii = command.CreateParameter();
                    paramCantGlobuleRosii.ParameterName = "@CantGlobuleRosii";
                    paramCantGlobuleRosii.Value = formularCerere.CantGlobuleRosii;
                    command.Parameters.Add(paramCantGlobuleRosii);

                    var paramIdM = command.CreateParameter();
                    paramIdM.ParameterName = "@IdM";
                    paramIdM.Value = formularCerere.IdM;
                    command.Parameters.Add(paramIdM);

                    command.ExecuteNonQuery();
                } catch (RepositoryException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();

        }

        public FormularCerere Delete(FormularCerere formularCerere)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM FormulareCerere WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = formularCerere.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return formularCerere;
                    }

                    return null;

                } catch (RepositoryException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public FormularCerere Update(FormularCerere formularCerere)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE FormulareCerere SET Target=@Target, CantTrombocite=@CantTrombocite, CantPlasma=@CantPlasma, CantGlobuleRosii=@CantGlobuleRosii, IdM=@IdM WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = formularCerere.Id;
                    command.Parameters.Add(paramId);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    paramTarget.Value = formularCerere.Target;
                    command.Parameters.Add(paramTarget);

                    var paramCantTrombocite = command.CreateParameter();
                    paramCantTrombocite.ParameterName = "@CantTrombocite";
                    paramCantTrombocite.Value = formularCerere.CantTrombocite;
                    command.Parameters.Add(paramCantTrombocite);

                    var paramCantPlasma = command.CreateParameter();
                    paramCantPlasma.ParameterName = "@CantPlasma";
                    paramCantPlasma.Value = formularCerere.CantTrombocite;
                    command.Parameters.Add(paramCantPlasma);

                    var paramCantGlobuleRosii = command.CreateParameter();
                    paramCantGlobuleRosii.ParameterName = "@CantGlobuleRosii";
                    paramCantGlobuleRosii.Value = formularCerere.CantGlobuleRosii;
                    command.Parameters.Add(paramCantGlobuleRosii);

                    var paramIdM = command.CreateParameter();
                    paramIdM.ParameterName = "@IdM";
                    paramIdM.Value = formularCerere.IdM;
                    command.Parameters.Add(paramIdM);

                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return formularCerere;
                    }

                    return null;
                } catch (RepositoryException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public FormularCerere FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                try
                {
                    command.CommandText = "SELECT * FROM FormulareCerere WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int Id = result.GetInt32(0);
                            string target = result.GetString(1);
                            double cantTrombocite = result.GetDouble(2);
                            double cantPlasma = result.GetDouble(3);
                            double cantGlobuleRosi = result.GetDouble(4);
                            int idM = result.GetInt32(5);

                            FormularCerere formularCerere = new FormularCerere(Id, target, cantTrombocite, cantPlasma, cantGlobuleRosi, idM);
                            return formularCerere;
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

        public List<FormularCerere> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<FormularCerere> toReturn = new List<FormularCerere>();
                    command.CommandText = "SELECT * FROM FormulareCerere";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            //toReturn.Add(new Donator(result.GetString(0), result.GetString(1), result.GetString(2), result.GetDateTime(3)));
                            // toReturn.Add(new FormularCerere(result.GetInt32(0), result.GetDateTime(1), result.GetString(2), result.GetInt32(3), result.GetInt32(4)));
                            toReturn.Add(new FormularCerere(result.GetInt32(0), result.GetString(1), result.GetDouble(2), result.GetDouble(3), result.GetDouble(4), result.GetInt32(5)));
                        }
                    }
                    connection.Close();
                    return toReturn;
                } catch (RepositoryException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea donatorilor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public bool ExistaCNP(string cnp)
        {
            using (var connection = Globals.GetDbConnection())
            {
                connection.Open();
                var cmd = new SqlCommand(@"select * from FormularCerere where Target=@cnp", connection);
                cmd.Parameters.AddWithValue("@cnp", cnp);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
            }
            return false;
        }
    }
}