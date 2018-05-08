using ISSApp.Domain;
using System;
using System.Collections.Generic;
using System.Data;

namespace ISSApp.Repository
{
    public class SqlDonatorRepo : ISqlRepo<Donator>
    {
        public void Add(Donator donator)
        {
            var connection = Globals.getDBConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Donatori(CNP, Nume, Prenume, Dob, IdA) VALUES (@CNP, @Nume, @Prenume, @Dob, @IdA)";

                var paramCnp = command.CreateParameter();
                paramCnp.ParameterName = "@CNP";
                paramCnp.Value = donator.CNP;
                command.Parameters.Add(paramCnp);

                var paramNume = command.CreateParameter();
                paramNume.ParameterName = "@Nume";
                paramNume.Value = donator.Nume;
                command.Parameters.Add(paramNume);

                var paramPrenume = command.CreateParameter();
                paramPrenume.ParameterName = "@Prenume";
                paramPrenume.Value = donator.Prenume;
                command.Parameters.Add(paramPrenume);

                var paramDob = command.CreateParameter();
                paramDob.ParameterName = "@Dob";
                paramDob.Value = donator.Dob;
                command.Parameters.Add(paramDob);

                var paramIdA = command.CreateParameter();
                paramIdA.ParameterName = "@IdA";
                paramIdA.Value = donator.IdA;
                command.Parameters.Add(paramIdA);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public Donator Delete(Donator donator)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Donator WHERE CNP=@CNP";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = donator.CNP;
                command.Parameters.Add(paramCNP);

                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return donator;
                }
            }
            return null;
        }

        public Donator Update(Donator donator)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Donator SET Nume=@Nume, Prenume=@Prenume, Dob=@Dob, CentruDonare_IdCD1=@CentruDonare, DateContact=@DateContact WHERE CNP=@CNP";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = donator.CNP;
                command.Parameters.Add(paramCNP);

                var paramNume = command.CreateParameter();
                paramNume.ParameterName = "@Nume";
                paramNume.Value = donator.Nume;
                command.Parameters.Add(paramNume);

                var paramPrenume = command.CreateParameter();
                paramPrenume.ParameterName = "@Prenume";
                paramPrenume.Value = donator.Prenume;
                command.Parameters.Add(paramPrenume);

                var paramDob = command.CreateParameter();
                paramDob.ParameterName = "@Dob";
                paramDob.Value = donator.Dob;
                command.Parameters.Add(paramDob);

                var paramCentruDonare = command.CreateParameter();
                paramCentruDonare.ParameterName = "@CentruDonare";
                paramCentruDonare.Value = donator.CentruDonare.Id;
                command.Parameters.Add(paramCentruDonare);

                var paramDateContact = command.CreateParameter();
                paramDateContact.ParameterName = "@DateContact";
                paramDateContact.Value = donator.DateContact.Id;
                command.Parameters.Add(paramDateContact);

                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return donator;
                }
            }
            return null;
        }

        public Donator FindEntity(int id)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Donator WHERE CNP=@CNP";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = id;
                command.Parameters.Add(paramCNP);

                using (var result = command.ExecuteReader())
                {
                    if (result.Read())
                    {
                        String cnp = result.GetString(0);
                        String nume = result.GetString(1);
                        String prenume = result.GetString(2);
                        DateTime date = result.GetDateTime(3);
                        int centruDonare = result.GetInt32(4);
                        int dateContact = result.GetInt32(5);


                        //De continuat
                        //return donator;
                    }
                }


            }

            return null;
        }

        public List<Donator> FindAll()
        {
            // TODO implement here
            return null;
        }
    }
}