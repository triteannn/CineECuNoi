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
        private SQLAdresaRepo adresaRepo = new SQLAdresaRepo();
        private Adresa adresa = new Adresa("Strada Piezisa", 68, "Cluj-Napoca", "Cluj");

        public AdresaTest()
        {
            
        }

        [TestMethod]
        public void Adresa_Add()
        {
            try
            {
                adresaRepo.Add(new Adresa()); //trebe sa dea fail
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Adresa_Delete()
        {
            try
            {
                adresaRepo.Delete(adresa);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Adresa_FindEntity()
        {
            try
            {
                Adresa adresa = adresaRepo.FindEntity(1);
                Assert.IsTrue(adresa.Strada == "Macilor"); // a nu se schimba in BD
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void Adresa_FindAll()
        {
            try
            {
                List<Adresa> adrese = adresaRepo.FindAll();
                Assert.IsTrue(adrese.Count >= 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

    }
}
