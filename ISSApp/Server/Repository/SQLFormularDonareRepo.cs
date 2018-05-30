using ISSApp.Domain;
using ISSApp.Exceptions;
using Server.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace Server.Repository
{
    public class SqlFormularDonareRepo : ISqlRepo<FormularDonare>
    {
        public void Add(FormularDonare formularDonare)
        {
            var connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "INSERT INTO FormulareDonare(DataCreare, ListaBoli, IdAn, IdD) VALUES (@DataCreare, @ListaBoli, @IdAn, @IdD)";

                    var paramDataCreare = command.CreateParameter();
                    paramDataCreare.ParameterName = "@DataCreare";
                    paramDataCreare.Value = formularDonare.DataCreare;
                    command.Parameters.Add(paramDataCreare);

                    var paramListaBoli = command.CreateParameter();
                    paramListaBoli.ParameterName = "@ListaBoli";
                    paramListaBoli.Value = formularDonare.ListaBoli;
                    command.Parameters.Add(paramListaBoli);

                    var paramIdAn = command.CreateParameter();
                    paramIdAn.ParameterName = "@IdAn";
                    paramIdAn.Value = formularDonare.IdAn;
                    command.Parameters.Add(paramIdAn);

                    var paramIdD = command.CreateParameter();
                    paramIdD.ParameterName = "@IdD";
                    paramIdD.Value = formularDonare.IdD;
                    command.Parameters.Add(paramIdD);

                    command.ExecuteNonQuery();

                } catch (RepositoryException)
                {
                    throw new RepositoryException("Inserarea in baza de date nu s-a putut realiza cu succes.");
                }

            }

        }

        public FormularDonare Delete(FormularDonare formularDonare)
        {
            IDbConnection connection = Globals.GetDbConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM Donatori WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = formularDonare.Id;
                    command.Parameters.Add(paramId);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return formularDonare;
                    }

                    return null;

                } catch (RepositoryException)
                {
                    throw new RepositoryException("Stergerea din baza de date nu s-a putut realiza cu succes.");
                }

            }
        }

        public FormularDonare Update(FormularDonare formularDonare)
        {
            IDbConnection connection = Globals.GetDbConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText =
                        "UPDATE Donatori SET DataCreare=@DataCreare, ListaBoli=@ListaBoli, IdAn=@IdAn, IdD=@IdD WHERE Id=@Id";

                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = formularDonare.Id;
                    command.Parameters.Add(paramId);

                    var paramDataCreare = command.CreateParameter();
                    paramDataCreare.ParameterName = "@DataCreare";
                    paramDataCreare.Value = formularDonare.DataCreare;
                    command.Parameters.Add(paramDataCreare);

                    var paramListaBoli = command.CreateParameter();
                    paramListaBoli.ParameterName = "@ListaBoli";
                    paramListaBoli.Value = formularDonare.ListaBoli;
                    command.Parameters.Add(paramListaBoli);

                    var paramIdAn = command.CreateParameter();
                    paramIdAn.ParameterName = "@IdAn";
                    paramIdAn.Value = formularDonare.IdAn;
                    command.Parameters.Add(paramIdAn);

                    var paramIdD = command.CreateParameter();
                    paramIdD.ParameterName = "@IdD";
                    paramIdD.Value = formularDonare.IdD;
                    command.Parameters.Add(paramIdD);

                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return formularDonare;
                    }

                    return null;
                } catch (RepositoryException)
                {
                    throw new RepositoryException("Update-ul din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }

        public FormularDonare FindEntity(int id)
        {
            IDbConnection connection = Globals.GetDbConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "SELECT * FROM FormulareDonare WHERE Id=@Id";
                    var paramId = command.CreateParameter();
                    paramId.ParameterName = "@Id";
                    paramId.Value = id;
                    command.Parameters.Add(paramId);

                    using (var result = command.ExecuteReader())
                    {
                        if (result.Read())
                        {
                            int ID = result.GetInt32(0);
                            DateTime dataCreare = result.GetDateTime(1);
                            string listaBoli = result.GetString(2);
                            int idD = result.GetInt32(3);
                            string target = result.GetString(4);

                            FormularDonare formularDonare = new FormularDonare(ID, dataCreare, listaBoli, idD, target);
                            return formularDonare;
                        }

                        return null;
                    }

                } catch (RepositoryException)
                {
                    throw new RepositoryException("Gasirea entitatii in baza de date nu s-a putut realiza cu susces.");
                }

            }
        }

        public List<FormularDonare> FindAll()
        {
            IDbConnection connection = Globals.GetDbConnection();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    List<FormularDonare> toReturn = new List<FormularDonare>();
                    command.CommandText = "SELECT * FROM FormulareDonare";
                    using (var result = command.ExecuteReader())
                    {
                        while (result.Read())
                        {
                            // la momentul crearii functiei, in BD nu exista campul target(pozitia 4); am presupus ca se va face ulterior
                            toReturn.Add(new FormularDonare(result.GetInt32(0), result.GetDateTime(1), result.GetString(2), result.GetInt32(3), result.GetString(4)));
                        }
                    }

                    return toReturn;
                } catch (RepositoryException)
                {
                    throw new RepositoryException("Returnarea donatorilor din baza de date nu s-a putut realiza cu succes.");
                }
            }
        }
    }
}