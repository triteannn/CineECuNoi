using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class PlasmaTest
    {
        private SqlPlasmaRepo plasmaRepo = new SqlPlasmaRepo();
        private PSPlasma plasma = new PSPlasma { Cantitate = 100, Target = "1553253", DataExpirare = new DateTime(2011, 2, 3) };
        //PSPlasme(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD)

        public PlasmaTest()
        {
            
        }


        [TestMethod]
        public void Plasma_Add()
        {

            try
            {
                plasmaRepo.Add(new PSPlasma());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Plasma_Delete()
        {
            try
            {
                plasmaRepo.Delete(plasma);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_Update()
        {
            try
            {
                plasmaRepo.Update(new PSPlasma());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_FindEntity()
        {
            try
            {
                PSPlasma plasma = plasmaRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_FindAll()
        {
            try
            {
                List<PSPlasma> plasme = plasmaRepo.FindAll();
                //Assert.IsTrue(true);
                Assert.Fail();
            }
            catch (Exception)
            {
                //Assert.Fail();
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_FindByTarget()
        {
            try
            {
                List<PSPlasma> plasme = plasmaRepo.FindByTarget("325432543");
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

    }
}
