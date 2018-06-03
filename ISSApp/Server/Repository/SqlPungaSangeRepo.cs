using System;
using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SqlPungaSangeRepo : ISqlRepo<PungaSange>
    {
 
        public void Add(PungaSange pungaSange)
        {

            var connection = Globals.GetDbConnection();
            connection.Open();
            var cmd = new SqlCommand("INSERT INTO PungiSange(DataRecoltare, Grupa, Rh, Target, IdCd, IdFd) VALUES (@DataRecoltare, @Grupa, @Rh, @Target, @IdCd, @IdFd)");
            cmd.Parameters.AddWithValue("@DataRecoltare", pungaSange.DataRecoltare);
            if (pungaSange.Grupa != null)
                cmd.Parameters.AddWithValue("@Grupa", pungaSange.Grupa);
            else
                cmd.Parameters.AddWithValue("@Grupa", DBNull.Value);
            if (pungaSange.Rh != null)
                cmd.Parameters.AddWithValue("@Rh", pungaSange.Rh);
            else
                cmd.Parameters.AddWithValue("@Rh", DBNull.Value);
            if (pungaSange.Target != null)
                cmd.Parameters.AddWithValue("@Target", pungaSange.Target);
            else
                cmd.Parameters.AddWithValue("@Target", DBNull.Value);
            cmd.Parameters.AddWithValue("@IdCd", pungaSange.IdCd);
            cmd.Parameters.AddWithValue("@IdFd", pungaSange.IdFd);
            try
            {
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new RepositoryException(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            //            var connection = Globals.GetDbConnection();
            //            connection.Open();
            //            using (var command = connection.CreateCommand())
            //            {
            //                try
            //                {
            //                    command.CommandText =
            //                        "INSERT INTO PungiSange(DataRecoltare, Grupa, Rh, Target, IdCd, IdFd) VALUES (@DataRecoltare, @Grupa, @Rh, @Target, @IdCd, @IdFd)";
            //
            //
            //                    var paramDataRecoltare = command.CreateParameter();
            //                    paramDataRecoltare.ParameterName = "@DataRecoltare";
            //                    paramDataRecoltare.Value = pungaSange.DataRecoltare;
            //                    command.Parameters.Add(paramDataRecoltare);
            //
            //                    var paramGrupa = command.CreateParameter();
            //                    paramGrupa.ParameterName = "@Grupa";
            //                    paramGrupa.Value = pungaSange.Grupa;
            //                    command.Parameters.Add(paramGrupa);
            //
            //                    var paramRh = command.CreateParameter();
            //                    paramRh.ParameterName = "@Rh";
            //                    paramRh.Value = pungaSange.Rh;
            //                    command.Parameters.Add(paramRh);
            //
            //                    var paramTarget = command.CreateParameter();
            //                    paramTarget.ParameterName = "@Target";
            //                    paramTarget.Value = pungaSange.Target;
            //                    command.Parameters.Add(paramTarget);
            //
            //                    var paramIdCd = command.CreateParameter();
            //                    paramIdCd.ParameterName = "@IdCd";
            //                    paramIdCd.Value = pungaSange.IdCd;
            //                    command.Parameters.Add(paramIdCd);
            //
            //                    var paramIdFd = command.CreateParameter();
            //                    paramIdFd.ParameterName = "@IdFd";
            //                    paramIdFd.Value = pungaSange.IdFd;
            //                    command.Parameters.Add(paramIdFd);
            //
            //                    command.ExecuteNonQuery();
            //
            //                } catch (SqlException)
            //                {
            //                    connection.Close();
            //                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
            //                }
            //
            //            }
            //            connection.Close();
        }

        public void AddInitial(PungaSange pungaSange)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {

                    if (pungaSange.Target != null)
                    {
                        command.CommandText =
                            "INSERT INTO PungiSange( DataRecoltare, Target, IdCd, IdFd) VALUES (@DataRecoltare, @Target, @IdCd, @IdFd)";

                        var paramTarget = command.CreateParameter();
                        paramTarget.ParameterName = "@Target";
                        paramTarget.Value = pungaSange.Target;
                        command.Parameters.Add(paramTarget);
                    }
                    else
                    {
                        command.CommandText =
                            "INSERT INTO PungiSange( DataRecoltare, IdCd, IdFd) VALUES (@DataRecoltare, @IdCd, @IdFd)";

                    }



                    var paramDataRecoltare = command.CreateParameter();
                    paramDataRecoltare.ParameterName = "@DataRecoltare";
                    paramDataRecoltare.Value = pungaSange.DataRecoltare;
                    command.Parameters.Add(paramDataRecoltare);



                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = pungaSange.IdCd;
                    command.Parameters.Add(paramIdCd);


                    var paramIdFd = command.CreateParameter();
                    paramIdFd.ParameterName = "@IdFd";
                    paramIdFd.Value = pungaSange.IdFd;
                    command.Parameters.Add(paramIdFd);

                    command.ExecuteNonQuery();

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }
            connection.Close();
        }

        public PungaSange Delete(PungaSange pungaSange)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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
                    connection.Close();
                    if (result != 0)
                    {
                        return pungaSange;
                    }

                    return null;

                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public PungaSange Update(PungaSange pungaSange)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE PungiSange SET DataRecoltare=@DataRecoltare, Grupa=@Grupa, Rh=@Rh, Target=@Target, IdCd=@IdCd, IdFd=@IdFd WHERE Id=@Id";

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
                    if (pungaSange.Grupa != null)
                        paramGrupa.Value = pungaSange.Grupa;
                    else
                        paramGrupa.Value = DBNull.Value;
                    command.Parameters.Add(paramGrupa);

                    var paramRh = command.CreateParameter();
                    paramRh.ParameterName = "@Rh";
                    if (pungaSange.Rh != null)
                        paramRh.Value = pungaSange.Rh;
                    else
                        paramRh.Value = DBNull.Value;   
                    command.Parameters.Add(paramRh);

                    var paramTarget = command.CreateParameter();
                    paramTarget.ParameterName = "@Target";
                    if (pungaSange.Target != null)
                        paramTarget.Value = pungaSange.Target;
                    else
                        paramTarget.Value = DBNull.Value;
                    command.Parameters.Add(paramTarget);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = pungaSange.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var paramIdFd = command.CreateParameter();
                    paramIdFd.ParameterName = "@IdFd";
                    paramIdFd.Value = pungaSange.IdFd;
                    command.Parameters.Add(paramIdFd);


                    var result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return pungaSange;
                    }

                    return null;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public PungaSange FindEntity(int id)
        {
            using (IDbConnection connection = Globals.GetDbConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
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
                            int idPunga = result.GetInt32(0);
                            DateTime dataRecoltare = result.GetDateTime(1);
                            string grupa = "";
                            if (result[2] != DBNull.Value)
                                grupa = result.GetString(2);
                            string rh = "";
                            if (result[3] != DBNull.Value)
                                rh = result.GetString(3);
                            string target = "";
                            if (result[4] != DBNull.Value)
                                target = result.GetString(4);
                            int idCd = result.GetInt32(5);
                            int idFd = result.GetInt32(6);

                            PungaSange pungaSange = new PungaSange(idPunga, dataRecoltare, grupa, rh, target, idCd, idFd);
                            return pungaSange;
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

        public List<PungaSange> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
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

                            int idPunga = result.GetInt32(0);
                            DateTime dataRecoltare = result.GetDateTime(1);
                            string grupa = "";
                            if (result[2] != DBNull.Value)
                                grupa = result.GetString(2);
                            string rh = "";
                            if (result[3] != DBNull.Value)
                                rh = result.GetString(3);
                            string target = "";
                            if (result[4] != DBNull.Value)
                                target = result.GetString(4);
                            int idCd = result.GetInt32(5);
                            int idFd = result.GetInt32(6);

                            PungaSange pungaSange = new PungaSange(idPunga, dataRecoltare, grupa, rh, target, idCd, idFd);

                            toReturn.Add(pungaSange);
                        }
                    }
                    connection.Close();
                    return toReturn;
                } catch (SqlException)
                {
                    connection.Close();
                    throw new RepositoryException("Returnarea pungii de sange din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public List<PungaSange> FindByTarget(string target)
        {
            //TO IMPLEMET
            return null;
        }


        /*
         * Returneaza toate pungile de sange care apartin Donatorului cu cnp-ul dat.
         */
        public List<PungaSangeCuCNP> GetPungaSangeCuCNP(string cnp)
        {

            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<PungaSangeCuCNP> pungiSange = new List<PungaSangeCuCNP>();
                    command.CommandText = "SELECT D.CNP, PS.Id, PS.DataRecoltare, PS.Grupa, PS.Rh, PS.Target " +
                                          "FROM Donatori D " + 
                                          "     INNER JOIN FormulareDonare FD ON D.Id=FD.IdD " +
                                          "     INNER JOIN PungiSange PS ON FD.Id=PS.IdFd " + 
                                          "WHERE D.CNP='" + cnp + "'";

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            string cnpDonator = result.GetString(0);
                            int idPunga = result.GetInt32(1);
                            DateTime dataRecoltare = result.GetDateTime(2);
                            string grupa = "";
                            if (result[3] != DBNull.Value)
                                grupa = result.GetString(3);
                            string rh = "";
                            if (result[4] != DBNull.Value)
                                rh = result.GetString(4);
                            string target = "";
                            if (result[5] != DBNull.Value)
                                target = result.GetString(5);

                            PungaSangeCuCNP pungaSange = new PungaSangeCuCNP(cnpDonator, idPunga, dataRecoltare, grupa, rh, target);

                            pungiSange.Add(pungaSange);
                        }
                    }
                    return pungiSange;
                }
                catch (SqlException)
                {
                    throw new RepositoryException("Returnarea pungii de sange din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}
