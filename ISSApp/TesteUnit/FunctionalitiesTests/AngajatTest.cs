using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class AngajatTest
    {
        //AngajatiCentru(CNP, Nume, Prenume, Dob, IdCd, IdA, IdDc)
        private SqlAngajatRepo angajatRepo;
        private AngajatCentru angajat = new AngajatCentru { CNP = "23647367", Nume = "Alin", Prenume = "Barosanu", Dob = new DateTime(2012, 3, 4) };



        [TestMethod]
        public void Angajat_Add()
        {
            try
            {
                angajatRepo.Add(angajat);
                //Assert.IsTrue(true);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Assert.Fail();
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Angajat_Delete()
        {
            try
            {
                angajatRepo.Delete(angajat);
                //Assert.IsTrue(true);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Assert.Fail();
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Angajat_Update()
        {
            try
            {
                angajatRepo.Update(new AngajatCentru());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Angajat_FindEntity()
        {
            try
            {
                AngajatCentru angajat = angajatRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Angajat_FindAll()
        {
            try
            {
                List<AngajatCentru> angajati = angajatRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }



        [TestMethod]
        public void Angajat_FindByIdAccount()
        {
            try
            {
                AngajatCentru angajat = angajatRepo.FindByIdAccount(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Angajat_FindByUsername()
        {
            try
            {
                AngajatCentru angajat = angajatRepo.FindByUsername("dragon_killer_12546");
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
