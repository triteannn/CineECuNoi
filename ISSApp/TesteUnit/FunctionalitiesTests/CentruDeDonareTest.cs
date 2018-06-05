using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]


    public class CentruDeDonareTest
    {
        private SqlCentruDonareRepo centruDonareRepo = new SqlCentruDonareRepo();
        private SQLAdresaRepo adresaRepo;
        private CentruDonare centruDonare = new CentruDonare { Denumire = "Centru Marasti" };
        //(Strada, Numar, Oras, Judet)

        public CentruDeDonareTest()
        {

        }

        [TestMethod]
        public void CentruDonare_Add()
        {
            
            try
            {
                centruDonareRepo.Add(new CentruDonare());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void CentruDonare_Delete()
        {
            try
            {
                centruDonareRepo.Delete(centruDonare);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CentruDonare_Update()
        {
            try
            {
                centruDonareRepo.Update(new CentruDonare());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CentruDonare_FindEntity()
        {
            try
            {
                CentruDonare centru = centruDonareRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CentruDonare_FindAll()
        {
            try
            {
                List<CentruDonare> centre = centruDonareRepo.FindAll();
                Assert.IsTrue(centre.Count >= 0);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void CentruDonare_FindCentruDonareByDenumire()
        {
            try
            {
                CentruDonare centru = centruDonareRepo.FindCentruDonareByDenumire("blablabla");
                Assert.Fail();
            }
            catch (Exception)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }
    }
}
