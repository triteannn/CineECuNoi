using System;
using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Server.Repository
{
    public class SQLAnalizaRepo : ISqlRepo<Analiza>
    {
        public void Add(Analiza analiza)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "INSERT INTO (Id, DataRecoltarii, Eritrocite, Hemoglobina, Hematocrit, VEM, HEM, CHEM, LatimeDistribEritrocit, Trombocite, VolumMediuTrombocitar, Trombocrit, LatimeDistribTrombocit, Leucocite, Granulocite, Limfocite, MID, NumarLimfocite, NumarMID, Glicemie, ALT_TGP, Colesterol) VALUES(@Id, @DataRecoltarii, @Eritrocite, @Hemoglobina, @Hematocrit, @VEM, @HEM, @CHEM, @LatimeDistribEritrocit, @Trombocite, @VolumMediuTrombocitar, @Trombocrit, @LatimeDistribTrombocit, @Leucocite, @Granulocite, @Limfocite, @MID, @NumarLimfocite, @NumarMID, @Glicemie, @ALT_TGP, @Colesterol)";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = analiza.Id;
                    command.Parameters.Add(paramId);

                    var paramDataRecoltarii = command.CreateParameter();
                    paramDataRecoltarii.ParameterName = "@DataRecoltarii";
                    paramDataRecoltarii.Value = analiza.DataRecoltarii;
                    command.Parameters.Add(paramDataRecoltarii);

                    var paramEritrocite = command.CreateParameter();
                    paramEritrocite.ParameterName = "@Eritrocite";
                    paramEritrocite.Value = analiza.Eritrocite;
                    command.Parameters.Add(paramEritrocite);

                    var paramHemoglobina = command.CreateParameter();
                    paramHemoglobina.ParameterName = "@Hemoglobina";
                    paramHemoglobina.Value = analiza.Hemoglobina;
                    command.Parameters.Add(paramHemoglobina);

                    var paramHematocrit = command.CreateParameter();
                    paramHematocrit.ParameterName = "@Hematocrit";
                    paramEritrocite.Value = analiza.Hematocrit;
                    command.Parameters.Add(paramHematocrit);

                    var paramVEM = command.CreateParameter();
                    paramVEM.ParameterName = "@VEM";
                    paramVEM.Value = analiza.VEM;
                    command.Parameters.Add(paramVEM);

                    var paramHEM = command.CreateParameter();
                    paramHEM.ParameterName = "@HEM";
                    paramHEM.Value = analiza.HEM;
                    command.Parameters.Add(paramHEM);

                    var paramCHEM = command.CreateParameter();
                    paramCHEM.ParameterName = "@CHEM";
                    paramCHEM.Value = analiza.CHEM;
                    command.Parameters.Add(paramCHEM);

                    var paramLatimeDistribEritrocit = command.CreateParameter();
                    paramLatimeDistribEritrocit.ParameterName = "@LatimeDistribEritrocit";
                    paramLatimeDistribEritrocit.Value = analiza.LatimeDistribEritrocit;
                    command.Parameters.Add(paramLatimeDistribEritrocit);

                    var paramTrombocite = command.CreateParameter();
                    paramTrombocite.ParameterName = "@Trombocite";
                    paramTrombocite.Value = analiza.Trombocite;
                    command.Parameters.Add(paramTrombocite);

                    var paramVolumMediuTrombocitar = command.CreateParameter();
                    paramVolumMediuTrombocitar.ParameterName = "@VolumMediuTrombocitar";
                    paramVolumMediuTrombocitar.Value = analiza.VolumMediuTrombocitar;
                    command.Parameters.Add(paramVolumMediuTrombocitar);

                    var paramTrombocrit = command.CreateParameter();
                    paramTrombocrit.ParameterName = "@Trombocrit";
                    paramTrombocrit.Value = analiza.Trombocrit;
                    command.Parameters.Add(paramTrombocrit);

                    var paramLatimeDistribTrombocit = command.CreateParameter();
                    paramLatimeDistribTrombocit.ParameterName = "@LatimeDistribTrombocit";
                    paramLatimeDistribTrombocit.Value = analiza.LatimeDistribTrombocit;
                    command.Parameters.Add(paramLatimeDistribTrombocit);

                    var paramLeucocite = command.CreateParameter();
                    paramLeucocite.ParameterName = "@Leucocite";
                    paramLeucocite.Value = analiza.Leucocite;
                    command.Parameters.Add(paramLeucocite);

                    var paramLeucocite = command.CreateParameter();
                    paramLeucocite.ParameterName = "@Leucocite";
                    paramLeucocite.Value = analiza.Leucocite;
                    command.Parameters.Add(paramLeucocite);




                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public AngajatCentru Delete(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM AngajatiCentru WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = angajatCentru.CNP;
                    command.Parameters.Add(paramCNP);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public AngajatCentru Update(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "UPDATE AngajatiCentru SET Nume=@Nume, Prenume=@Prenume, Dob=@Dob, IdA=@IdA, IdCd=@IdCd WHERE CNP=@CNP";

                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@CNP";
                    paramCNP.Value = angajatCentru.CNP;
                    command.Parameters.Add(paramCNP);

                    var paramNume = command.CreateParameter();
                    paramNume.ParameterName = "@Nume";
                    paramNume.Value = angajatCentru.Nume;
                    command.Parameters.Add(paramNume);

                    var paramPrenume = command.CreateParameter();
                    paramPrenume.ParameterName = "@Prenume";
                    paramPrenume.Value = angajatCentru.Prenume;
                    command.Parameters.Add(paramPrenume);

                    var paramDob = command.CreateParameter();
                    paramDob.ParameterName = "@Dob";
                    paramDob.Value = angajatCentru.Dob;
                    command.Parameters.Add(paramDob);

                    var paramIdA = command.CreateParameter();
                    paramIdA.ParameterName = "@IdA";
                    paramIdA.Value = angajatCentru.IdA;
                    command.Parameters.Add(paramIdA);

                    var paramIdCd = command.CreateParameter();
                    paramIdCd.ParameterName = "@IdCd";
                    paramIdCd.Value = angajatCentru.IdCd;
                    command.Parameters.Add(paramIdCd);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return angajatCentru;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }

            }
        }

        public AngajatCentru FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM AngajatiCentru WHERE Id=@Id";
                    var paramCNP = command.CreateParameter();
                    paramCNP.ParameterName = "@Id";
                    paramCNP.Value = id;
                    command.Parameters.Add(paramCNP);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            String cnp = result.GetString(1);
                            String nume = result.GetString(2);
                            String prenume = result.GetString(3);
                            DateTime date = result.GetDateTime(4);

                            AngajatCentru angajat = new AngajatCentru(cnp, nume, prenume, date);
                            return angajat;
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

        public List<AngajatCentru> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<AngajatCentru> toReturn = new List<AngajatCentru>();
                    command.CommandText = "SELECT * FROM AngajatiCentru";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            toReturn.Add(new AngajatCentru(result.GetString(1), result.GetString(2), result.GetString(3), result.GetDateTime(4)));
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


        public List<Analiza> FindByDonator(int idDonator)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Analiza> toReturn = new List<Analiza>();
                    command.CommandText = "SELECT a.* " +
                                          "FROM FormulareDonare fd INNER JOIN Analize a " +
                                          "ON a.Id = fd.IdAn " +
                                          "where fd.IdD = @IdD";

                    var paramIdD = command.CreateParameter();
                    paramIdD.ParameterName = "@IdD";
                    paramIdD.Value = idDonator;
                    command.Parameters.Add(paramIdD);

                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            Analiza analiza = new Analiza
                            {
                                Id = result.GetInt32(0),
                                DataRecoltarii = result.GetDateTime(1),
                                Eritrocite = result.GetDouble(2),
                                Hemoglobina = result.GetDouble(3),
                                Hematocrit = result.GetDouble(4),
                                VEM = result.GetDouble(5),
                                HEM = result.GetDouble(6),
                                CHEM = result.GetDouble(7),
                                LatimeDistribEritrocit = result.GetDouble(8),
                                Trombocite = result.GetDouble(9),
                                VolumMediuTrombocitar = result.GetDouble(10),
                                Trombocrit = result.GetDouble(11),
                                LatimeDistribTrombocit = result.GetDouble(12),
                                Leucocite = result.GetDouble(13),
                                Granulocite = result.GetDouble(14),
                                Limfocite = result.GetDouble(15),
                                MID = result.GetDouble(16),
                                NumarGranulocite = result.GetDouble(17),
                                NumarLimfocite = result.GetDouble(18),
                                NumarMID = result.GetDouble(19),
                                Glicemie = result.GetDouble(20),
                                ALT_TGP = result.GetDouble(21),
                                Colesterol = result.GetDouble(22)

                            };

                            toReturn.Add(analiza);
                        }
                    }

                    return toReturn;
                }
                catch (SqlException)
                {
                    throw new Exception("Database FindByDonator failed.");
                }
            }
        }
    }
}