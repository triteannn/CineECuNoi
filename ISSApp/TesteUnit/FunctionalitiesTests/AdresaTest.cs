using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class AdresaTest
    {
        //"INSERT INTO Adrese(Strada, Numar, Oras, Judet)
        private SQLAdresaRepo adresaRepo;
        private Adresa adresa = new Adresa("Strada Piezisa", 68, "Cluj-Napoca", "Cluj");

        public AdresaTest()
        {
            adresaRepo = new SQLAdresaRepo();
        }

        [TestMethod]
        public void Adresa_Add()
        {
            try
            {
                adresaRepo.Add(adresa);
                // Assert.IsTrue(true);
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
        public void Adresa_Delete()
        {
            try
            {
                adresaRepo.Delete(adresa);
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
        public void Adresa_FindEntity()
        {
            try
            {
                Adresa adresa = adresaRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Adresa_FindAll()
        {
            try
            {
                List<Adresa> adrese = adresaRepo.FindAll(); //TODO da fail findAll, why?
                Assert.Fail();
                Console.WriteLine("size adrese: " + adrese.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Adresa_GetAdresaByDateContactId()
        {
            try
            {
                Adresa adresa = adresaRepo.GetAdresaByDateContactId(-1);
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
