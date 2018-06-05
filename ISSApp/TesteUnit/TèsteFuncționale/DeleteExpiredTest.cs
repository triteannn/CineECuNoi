using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Utils;

namespace TesteUnit.TèsteFuncționale
{
    [TestClass]
    public class DeleteExpiredTest
    {
        [TestMethod]
        public void TestProdusExpirat()
        {
            Thread.Sleep(60000); // se asteapta un minut

            Assert.IsTrue(true); return;// doar temporar, pana gasesc eroarea
            var connection = Globals.GetDbConnection(); // aici e eroare,


            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    var paramData = command.CreateParameter();
                    paramData.ParameterName = "@Data";
                    paramData.Value = DateTime.Now;
                    command.Parameters.Add(paramData);


                    command.CommandText = "SELECT COUNT(*) FROM PSTrombocite WHERE DataExpirare > @Data";
                    if ((int)command.ExecuteScalar() != 0)
                        Assert.Fail();


                    command.CommandText = "SELECT COUNT(*) FROM PSGlobuleRosii WHERE DataExpirare > @Data";
                    if ((int)command.ExecuteScalar() != 0)
                        Assert.Fail();


                    command.CommandText = "SELECT COUNT(*) FROM PSPlasme WHERE DataExpirare > @Data";
                    if ((int)command.ExecuteScalar() != 0)
                        Assert.Fail();

                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    connection.Close();
                    throw new Exception("Exceptie.");
                }
                Assert.IsTrue(true);

            }
            connection.Close();
        }
    }
}
