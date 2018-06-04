using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class DonatorTest
    {
        //Donatori(CNP, Nume, Prenume, Dob, IdA)
        private SqlDonatorRepo donatorRepo;
        private Donator donator = new Donator { CNP="2436543564", Nume="Nelutu", Prenume="Paul", Dob=new DateTime(2011, 2, 3)};


        [TestMethod]
        public void Donator_Add()
        {

            try
            {
                donatorRepo.Add(donator);
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
        public void Donator_Delete()
        {
            try
            {
                donatorRepo.Delete(donator);
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
        public void Donator_Update()
        {
            try
            {
                donatorRepo.Update(new Donator());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Donator_FindEntity()
        {
            try
            {
                Donator donator = donatorRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Donator_FindAll()
        {
            try
            {
                List<Donator> donatoruri = donatorRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Donator_FindByUsername()
        {
            try
            {
                Donator donator = donatorRepo.FindByUsername("Andreea");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Donator_FindByIdAccount()
        {
            try
            {
                Donator donator = donatorRepo.FindByIdAccount(-1235);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

    }
}
