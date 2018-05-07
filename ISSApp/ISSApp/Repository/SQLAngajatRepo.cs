using Domain;
using ISSApp;
using System.Collections.Generic;
using System.Data;
using ISSApp.Domain;

namespace Repository
{
    /**
     * 
     */
    public class SQLAngajatRepo : ISQLRepo<AngajatCentru>
    {

        /**
         * 
         */
        public SQLAngajatRepo()
        {
        }

        /**
         * @param angajatCentru 
         * @return
         */
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

        /**
         * @param angajatCentru 
         * @return
         */
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

        /**
         * @param angajatCentru 
         * @return
         */
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

        /**
         * @param id 
         * @return
         */
        public AngajatCentru FindEntity(AngajatCentru entity)
        {
            return null;
        }

        /**
         * @return
         */
        public List<AngajatCentru> FindAll()
        {
            // TODO implement here
            return null;
        }

    }
}