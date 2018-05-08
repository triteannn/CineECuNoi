using ISSApp.Domain;
using System.Collections.Generic;
using System.Data;

namespace ISSApp.Repository
{
    public class SqlAngajatRepo : ISqlRepo<AngajatCentru>
    {
        public void Add(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Angajat(CNP, CentruDonare_IdCD) VALUES (@CNP, @IDCD)";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = angajatCentru.CNP;
                command.Parameters.Add(paramCNP);

                var paramIDCD = command.CreateParameter();
                paramIDCD.ParameterName = "@IDCD";
                paramIDCD.Value = angajatCentru.CentruDonare.Id;
                command.Parameters.Add(paramIDCD);

                command.ExecuteNonQuery();
            }
        }

        public AngajatCentru Delete(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Angajat WHERE CNP=@CNP";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = angajatCentru.CNP;
                command.Parameters.Add(paramCNP);

                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return angajatCentru;
                }
            }
            return null;
        }

        public AngajatCentru Update(AngajatCentru angajatCentru)
        {
            IDbConnection connection = Globals.getDBConnection();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Angajat SET CentruDonate_IdCD=@IDCD WHERE CNP=@CNP";

                var paramCNP = command.CreateParameter();
                paramCNP.ParameterName = "@CNP";
                paramCNP.Value = angajatCentru.CNP;
                command.Parameters.Add(paramCNP);

                var paramIDCD = command.CreateParameter();
                paramIDCD.ParameterName = "@IDCD";
                paramIDCD.Value = angajatCentru.CentruDonare.Id;
                command.Parameters.Add(paramIDCD);

                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return angajatCentru;
                }
            }
            return null;
        }

        public AngajatCentru FindEntity(int id)
        {
            return null;
        }

        public List<AngajatCentru> FindAll()
        {
            // TODO implement here
            return null;
        }
    }
}