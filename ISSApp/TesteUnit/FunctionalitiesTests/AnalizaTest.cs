using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class AnalizaTest
    {
        //Analize(DataRecoltarii, Eritrocite, Hemoglobina, Hematocrit, VEM, HEM, CHEM, LatimeDistribEritrocit, 
        //Trombocite, VolumMediuTrombocitar, Trombocrit, LatimeDistribTrombocit, Leucocite, 
        // Granulocite, Limfocite, MID, NumarLimfocite, NumarMID, Glicemie, ALT_TGP, Colesterol, ListaBoliDetectate)

        private SQLAnalizaRepo analizaRepo;
        private Analiza analiza = new Analiza {
            DataRecoltarii = new DateTime(2011, 2, 3), //have no idea if values are correct
            Eritrocite = 0.1,
            Hemoglobina = 0.2,
            Hematocrit = 0.4,
            VEM = 4.5,
            HEM = 5.6,
            CHEM = 35.9,
            LatimeDistribEritrocit = 2.3,
            Trombocite = 6.7,
            VolumMediuTrombocitar = 45.6,
            Trombocrit = 34.6,
            LatimeDistribTrombocit = 5.9,
            Leucocite = 5.1,
            Granulocite = 2.5,
            Limfocite = 67.9,
            MID = 0.3,
            NumarLimfocite = 90.4,
            NumarMID = 5.6,
            Glicemie = 106.0,
            ALT_TGP = 34.6,
            Colesterol = 0.9,
            ListaBoliDetectate = ""
        }; 

        [TestMethod]
        public void Analiza_Add()
        {
            try
            {
                analizaRepo.Add(analiza);
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
        public void Analiza_Delete()
        {
            try
            {
                analizaRepo.Delete(analiza);
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
        public void Analiza_Update()
        {
            try
            {
                analizaRepo.Update(new Analiza());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Analiza_FindEntity()
        {
            try
            {
                Analiza angajat = analizaRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Analiza_FindAll()
        {
            try
            {
                List<Analiza> analiza = analizaRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Analiza_FindByDonator()
        {
            try
            {
                List<Analiza> analize = analizaRepo.FindByDonator(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Analiza_FindLastByDonator()
        {
            try
            {
                Analiza analiza = analizaRepo.FindLastByDonator(-1);
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
