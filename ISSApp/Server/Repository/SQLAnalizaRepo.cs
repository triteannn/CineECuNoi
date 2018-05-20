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
                    command.CommandText = "INSERT INTO Analize(Id, DataRecoltarii, Eritrocite, Hemoglobina, Hematocrit, VEM, HEM, CHEM, LatimeDistribEritrocit, Trombocite, VolumMediuTrombocitar, Trombocrit, LatimeDistribTrombocit, Leucocite, Granulocite, Limfocite, MID, NumarLimfocite, NumarMID, Glicemie, ALT_TGP, Colesterol) VALUES(@Id, @DataRecoltarii, @Eritrocite, @Hemoglobina, @Hematocrit, @VEM, @HEM, @CHEM, @LatimeDistribEritrocit, @Trombocite, @VolumMediuTrombocitar, @Trombocrit, @LatimeDistribTrombocit, @Leucocite, @Granulocite, @Limfocite, @MID, @NumarLimfocite, @NumarMID, @Glicemie, @ALT_TGP, @Colesterol)";

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

                    var paramGranulocite = command.CreateParameter();
                    paramGranulocite.ParameterName = "@Granulocite";
                    paramGranulocite.Value = analiza.Granulocite;
                    command.Parameters.Add(paramGranulocite);

                    var paramLimfocite = command.CreateParameter();
                    paramLimfocite.ParameterName = "@Limfocite";
                    paramLimfocite.Value = analiza.Limfocite;
                    command.Parameters.Add(paramLimfocite);

                    var paramMID = command.CreateParameter();
                    paramMID.ParameterName = "@MID";
                    paramMID.Value = analiza.MID;
                    command.Parameters.Add(paramMID);

                    var paramNumarGranulocite = command.CreateParameter();
                    paramNumarGranulocite.ParameterName = "@NumarGranulocite";
                    paramNumarGranulocite.Value = analiza.NumarGranulocite;
                    command.Parameters.Add(paramNumarGranulocite);

                    var paramNumarLimfocite = command.CreateParameter();
                    paramNumarLimfocite.ParameterName = "@NumarLimfocite";
                    paramNumarLimfocite.Value = analiza.NumarLimfocite;
                    command.Parameters.Add(paramNumarLimfocite);

                    var paramNumarMID = command.CreateParameter();
                    paramNumarMID.ParameterName = "@NumarMID";
                    paramNumarMID.Value = analiza.NumarMID;
                    command.Parameters.Add(paramNumarMID);

                    var paramGlicemie = command.CreateParameter();
                    paramGlicemie.ParameterName = "@Glicemie";
                    paramGlicemie.Value = analiza.Glicemie;
                    command.Parameters.Add(paramGlicemie);

                    var paramALT_TGP = command.CreateParameter();
                    paramALT_TGP.ParameterName = "@ALT_TGP";
                    paramALT_TGP.Value = analiza.ALT_TGP;
                    command.Parameters.Add(paramALT_TGP);

                    var paramColesterol = command.CreateParameter();
                    paramColesterol.ParameterName = "@Colesterol";
                    paramColesterol.Value = analiza.Colesterol;
                    command.Parameters.Add(paramColesterol);

                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new Exception("Database insert failed.");
                }

            }
        }

        public Analiza Delete(Analiza analiza)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Analize WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@CNP";
                    paramId.Value = analiza.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return analiza;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database delete failed.");
                }

            }
        }

        public Analiza Update(Analiza analiza)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "UPDATE Analize SET DataRecoltarii=@DataRecoltarii, Eritrocite=@Eritrocite, Hemoglobina=@Hemoglobina, Hematocrit=@Hematocrit, VEM=@VEM, HEM=@HEM, CHEM=@CHEM, LatimeDistribEritrocit=@LatimeDistribEritrocit, Trombocite=@Trombocite, VolumMediuTrombocitar=@VolumMediuTrombocitar, Trombocrit=@Trombocrit, LatimeDistribTrombocit=@LatimeDistribTrombocit, Leucocite=@Leucocite, Granulocite=@Granulocite, Limfocite=@Lmfocite, MID=@MID, NumarGranulocite=@NumarGranulocite, NumarLimfocite=@NumarLimfocite, NumarMID=@NumarMID, Glicemie=@Glicemie, ALT_TGP=@ALT_TGP, Colesterol=@Colesterol WHERE Id=@Id";  //WTF ???
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

                    var paramGranulocite = command.CreateParameter();
                    paramGranulocite.ParameterName = "@Granulocite";
                    paramGranulocite.Value = analiza.Granulocite;
                    command.Parameters.Add(paramGranulocite);

                    var paramLimfocite = command.CreateParameter();
                    paramLimfocite.ParameterName = "@Limfocite";
                    paramLimfocite.Value = analiza.Limfocite;
                    command.Parameters.Add(paramLimfocite);

                    var paramMID = command.CreateParameter();
                    paramMID.ParameterName = "@MID";
                    paramMID.Value = analiza.MID;
                    command.Parameters.Add(paramMID);

                    var paramNumarGranulocite = command.CreateParameter();
                    paramNumarGranulocite.ParameterName = "@NumarGranulocite";
                    paramNumarGranulocite.Value = analiza.NumarGranulocite;
                    command.Parameters.Add(paramNumarGranulocite);

                    var paramNumarLimfocite = command.CreateParameter();
                    paramNumarLimfocite.ParameterName = "@NumarLimfocite";
                    paramNumarLimfocite.Value = analiza.NumarLimfocite;
                    command.Parameters.Add(paramNumarLimfocite);

                    var paramNumarMID = command.CreateParameter();
                    paramNumarMID.ParameterName = "@NumarMID";
                    paramNumarMID.Value = analiza.NumarMID;
                    command.Parameters.Add(paramNumarMID);

                    var paramGlicemie = command.CreateParameter();
                    paramGlicemie.ParameterName = "@Glicemie";
                    paramGlicemie.Value = analiza.Glicemie;
                    command.Parameters.Add(paramGlicemie);

                    var paramALT_TGP = command.CreateParameter();
                    paramALT_TGP.ParameterName = "@ALT_TGP";
                    paramALT_TGP.Value = analiza.ALT_TGP;
                    command.Parameters.Add(paramALT_TGP);

                    var paramColesterol = command.CreateParameter();
                    paramColesterol.ParameterName = "@Colesterol";
                    paramColesterol.Value = analiza.Colesterol;
                    command.Parameters.Add(paramColesterol);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return analiza;
                    }

                    return null;

                }
                catch (SqlException)
                {
                    throw new Exception("Database update failed.");
                }

            }
        }

        public Analiza FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM Analize WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
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
                            return analiza;
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

        public List<Analiza> FindAll()
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<Analiza> toReturn = new List<Analiza>();
                    command.CommandText = "SELECT * FROM Analize";
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