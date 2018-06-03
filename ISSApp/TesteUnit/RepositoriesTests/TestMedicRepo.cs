using System;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteUnit.RepositoriesTests
{
    [TestClass]
    public class TestMedicRepo
    {
        //INSERT INTO Medici(CNP, Nume, Prenume, Dob, IdS, IdA, IdDc)

        public TestMedicRepo()
        {
            //..
        }

        [TestMethod]
        public void TestAdaugareMedic()
        {
            Medic medic = new Medic { CNP = "1234567", Nume = "Ioan" }; // to be done later
        }
    }
}
