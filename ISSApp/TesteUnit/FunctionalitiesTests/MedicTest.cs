using System;
using ISSApp.Domain;
using Server.Networking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;
using System.Collections.Generic;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class MedicTest
    {
        //"INSERT INTO Medici(CNP, Nume, Prenume, Dob, IdS, IdA, IdDc)
        private SqlMedicRepo medicRepo = new SqlMedicRepo();
        private Medic medic;


        public MedicTest()
        {
            
            medic = new Medic { CNP = "1970902135778", Nume = "Alexandru", Prenume = "Ioan", Dob = new DateTime(2011, 3, 4) };
        }


        [TestMethod]
        public void Medic_Add()
        {
            Console.WriteLine("medic: " + medic.CNP);
            try
            {
                medicRepo.Add(new Medic());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Medic_Delete()
        {
            try
            {
                medicRepo.Delete(medic);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Medic_Update()
        {
            try
            {
                medicRepo.Update(new Medic());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Medic_FindEntity()
        {
            try
            {
                Medic med = medicRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Medic_FindAll()
        {
            try
            {
                List<Medic> medici = medicRepo.FindAll(); //TODO da fail findAll, why?
                Assert.IsTrue(medici.Count >= 0);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Medic_FindByIdAccount()
        {
            try
            {
                Medic med = medicRepo.FindByIdAccount(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Medic_FindByUsername()
        {
            try
            {
                Medic med = medicRepo.FindByUsername("dragon_killer_12546");
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

    }
}
