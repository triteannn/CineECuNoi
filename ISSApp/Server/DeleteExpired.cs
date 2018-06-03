
using Server.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Timers;

namespace Server
{
    public class DeleteExpired
    {
        private static Timer timer = null;
        
        public static void StartTimer()
        {
            timer = new Timer(36000000);   // o data la o ora   
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            IDbConnection connection = Globals.GetDbConnection();
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = "DELETE FROM PSPlasme WHERE DataExpirare > @Data; " +
                                          "DELETE FROM PSGlobuleRosii WHERE DataExpirare > @Data; " +
                                          "DELETE FROM PSTrombocite WHERE DataExpirare > @Data;";

                    var paramDate = command.CreateParameter();
                    paramDate.ParameterName = "@Data";
                    paramDate.Value = DateTime.Now;
                    command.Parameters.Add(paramDate);

                    var result = command.ExecuteNonQuery();

                    Console.WriteLine("S-au sters produsele expirate --- " + DateTime.Now);

                    connection.Close();
                }
                catch (Exception)
                {
                    connection.Close();
                    throw new Exception("Eroare update automat");
                }
            }
        }
    }
}
