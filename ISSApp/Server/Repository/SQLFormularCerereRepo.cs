using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
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
                        "INSERT INTO FormulareCerere(Target, CantTrombocite, CantPlasma, CantGlobuleRosii, IdM, Status, Grupa, Rh, IdCd) VALUES (@Target, @CantTrombocite, @CantPlasma, @CantGlobuleRosii, @IdM, @Status, @Grupa, @Rh, @IdCd)";

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    if (formularCerere.Target != null)
                        paramTarget.Value = formularCerere.Target;
                    else
                        paramTarget.Value = DBNull.Value;
                    command.Parameters.Add(paramTarget);

                    var paramCantTrombocite = command.CreateParameter();
                    paramCantTrombocite.ParameterName = "@CantTrombocite";
                    if (!formularCerere.CantTrombocite.Equals(0))
                        paramCantTrombocite.Value = formularCerere.CantTrombocite;
                    else
                        paramCantTrombocite.Value = DBNull.Value;
                    command.Parameters.Add(paramCantTrombocite);

                    var paramCantPlasma = command.CreateParameter();
                    paramCantPlasma.ParameterName = "@CantPlasma";
                    if (!formularCerere.CantPlasma.Equals(0))
                        paramCantPlasma.Value = formularCerere.CantPlasma;
                    else
                        paramCantPlasma.Value = DBNull.Value;
                    command.Parameters.Add(paramCantPlasma);

                    var paramCantGlobuleRosii = command.CreateParameter();
                    paramCantGlobuleRosii.ParameterName = "@CantGlobuleRosii";
                    if (!formularCerere.CantGlobuleRosii.Equals(0))
                        paramCantGlobuleRosii.Value = formularCerere.CantGlobuleRosii;
                    else
                        paramCantGlobuleRosii.Value = DBNull.Value;
                    command.Parameters.Add(paramCantGlobuleRosii);

                    var paramIdM = command.CreateParameter();
                    paramIdM.ParameterName = "@IdM";
                    if (!formularCerere.IdM.Equals(0))
                        paramIdM.Value = formularCerere.IdM;
                    else
                        paramIdM.Value = DBNull.Value;
                    command.Parameters.Add(paramIdM);

                    var paramStatus = command.CreateParameter();
                    paramStatus.ParameterName = "@Status";
                    if (formularCerere.Status != null)
                        paramStatus.Value = formularCerere.Status;
                    else
                        paramStatus.Value = DBNull.Value;
                    command.Parameters.Add(paramStatus);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    if (formularCerere.Grupa != null)
                        paramGrupa.Value = formularCerere.Grupa;
                    else
                        paramGrupa.Value = DBNull.Value;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    if (formularCerere.Rh != null)
                        paramRh.Value = formularCerere.Rh;
                    else
                        paramRh.Value = DBNull.Value;
                    command.Parameters.Add(paramRh);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    if (!formularCerere.IdCd.Equals(0))
                        paramIdCd.Value = formularCerere.IdCd;
                    else
                        paramIdCd.Value = DBNull.Value;
                    command.Parameters.Add(paramIdCd);

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
                        "UPDATE FormulareCerere SET Target=@Target, CantTrombocite=@CantTrombocite, CantPlasma=@CantPlasma, CantGlobuleRosii=@CantGlobuleRosii, IdM=@IdM, Status=@Status, Grupa=@Grupa, Rh=@Rh, IdCd=@IdCd WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = formularCerere.Id;
                    command.Parameters.Add(paramId);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    if (formularCerere.Target != null)
                        paramTarget.Value = formularCerere.Target;
                    else
                        paramTarget.Value = DBNull.Value;
                    command.Parameters.Add(paramTarget);

                    var paramCantTrombocite = command.CreateParameter();
                    paramCantTrombocite.ParameterName = "@CantTrombocite";
                    if (!formularCerere.CantTrombocite.Equals(0))
                        paramCantTrombocite.Value = formularCerere.CantTrombocite;
                    else
                        paramCantTrombocite.Value = DBNull.Value;
                    command.Parameters.Add(paramCantTrombocite);

                    var paramCantPlasma = command.CreateParameter();
                    paramCantPlasma.ParameterName = "@CantPlasma";
                    if (!formularCerere.CantPlasma.Equals(0))
                        paramCantPlasma.Value = formularCerere.CantPlasma;
                    else
                        paramCantPlasma.Value = DBNull.Value;
                    command.Parameters.Add(paramCantPlasma);

                    var paramCantGlobuleRosii = command.CreateParameter();
                    paramCantGlobuleRosii.ParameterName = "@CantGlobuleRosii";
                    if (!formularCerere.CantGlobuleRosii.Equals(0))
                        paramCantGlobuleRosii.Value = formularCerere.CantGlobuleRosii;
                    else
                        paramCantGlobuleRosii.Value = DBNull.Value;
                    command.Parameters.Add(paramCantGlobuleRosii);

                    var paramIdM = command.CreateParameter();
                    paramIdM.ParameterName = "@IdM";
                    if (!formularCerere.IdM.Equals(0))
                        paramIdM.Value = formularCerere.IdM;
                    else
                        paramIdM.Value = DBNull.Value;
                    command.Parameters.Add(paramIdM);

                    var paramStatus = command.CreateParameter();
                    paramStatus.ParameterName = "@Status";
                    if (formularCerere.Status != null)
                        paramStatus.Value = formularCerere.Status;
                    else
                        paramStatus.Value = DBNull.Value;
                    command.Parameters.Add(paramStatus);

                    var paramGrupa = command.CreateParameter();
                    paramGrupa.ParameterName = "@Grupa";
                    if (formularCerere.Grupa != null)
                        paramGrupa.Value = formularCerere.Grupa;
                    else
                        paramGrupa.Value = DBNull.Value;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    if (formularCerere.Rh != null)
                        paramRh.Value = formularCerere.Rh;
                    else
                        paramRh.Value = DBNull.Value;
                    command.Parameters.Add(paramRh);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    if (!formularCerere.IdCd.Equals(0))
                        paramIdCd.Value = formularCerere.IdCd;
                    else
                        paramIdCd.Value = DBNull.Value;
                    command.Parameters.Add(paramIdCd);


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
                            int idFromCerere = result.GetInt32(0);
                            string target = "";
                            if (result[1] != DBNull.Value)
                                target = result.GetString(1);
                            double? cantTrombocite = null;
                            if (result[2] != DBNull.Value)
                                cantTrombocite = result.GetDouble(2);
                            double? cantPlasma = null;
                            if (result[3] != DBNull.Value)
                                cantPlasma = result.GetDouble(3);
                            double? cantGlobuleRosi = null;
                            if (result[4] != DBNull.Value)
                                cantGlobuleRosi = result.GetDouble(4);
                            int? idM = null;
                            if (result[5] != null)
                                idM = result.GetInt32(5);
                            string status = "";
                            if (result[6] != DBNull.Value)
                                status = result.GetString(6);
                            string grupa = "";
                            if (result[7] != DBNull.Value)
                                grupa = result.GetString(7);
                            string rh = "";
                            if (result[8] != DBNull.Value)
                                rh = result.GetString(8);
                            int? idCd = null;
                            if (result[9] != null)
                                idCd = result.GetInt32(5);
                            FormularCerere formularCerere = new FormularCerere(idFromCerere, target, cantTrombocite, cantPlasma, cantGlobuleRosi, idM, status, grupa, rh, idCd);
                            return formularCerere;
                        }

                        return null;
                    }

                } catch (RepositoryException)
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
                            int idFromCerere = result.GetInt32(0);
                            string target = "";
                            if (result[1] != DBNull.Value)
                                target = result.GetString(1);
                            double? cantTrombocite = null;
                            if (result[2] != DBNull.Value)
                                cantTrombocite = result.GetDouble(2);
                            double? cantPlasma = null;
                            if (result[3] != DBNull.Value)
                                cantPlasma = result.GetDouble(3);
                            double? cantGlobuleRosi = null;
                            if (result[4] != DBNull.Value)
                                cantGlobuleRosi = result.GetDouble(4);
                            int? idM = null;
                            if (result[5] != null)
                                idM = result.GetInt32(5);
                            string status = "";
                            if (result[6] != DBNull.Value)
                                status = result.GetString(6);
                            string grupa = "";
                            if (result[7] != DBNull.Value)
                                grupa = result.GetString(7);
                            string rh = "";
                            if (result[8] != DBNull.Value)
                                rh = result.GetString(8);
                            int? idCd = null;
                            if (result[9] != null)
                                idCd = result.GetInt32(5);
                            FormularCerere formularCerere = new FormularCerere(idFromCerere, target, cantTrombocite, cantPlasma, cantGlobuleRosi, idM, status, grupa, rh, idCd);

                            toReturn.Add(formularCerere);
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