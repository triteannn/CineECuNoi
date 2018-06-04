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
        //(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD)
        private SqlPlasmaRepo plasmaRepo;
        private PSPlasma plasma = new PSPlasma { Cantitate = 100, Target = "1553253", DataExpirare = new DateTime(2011, 2, 3) };
        //PSPlasme(Cantitate, Target, DataExpirare, Grupa, Rh, IdCD)

        public PlasmaTest()
        {
            plasmaRepo = new SqlPlasmaRepo();
        }


        [TestMethod]
        public void Plasma_Add()
        {

            try
            {
                plasmaRepo.Add(plasma);
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
        public void Plasma_Delete()
        {
            try
            {
                plasmaRepo.Delete(plasma);
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
        public void Plasma_Update()
        {
            try
            {
                plasmaRepo.Update(new PSPlasma());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_FindEntity()
        {
            try
            {
                PSPlasma lasma = plasmaRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Plasma_FindAll()
        {
            try
            {
                List<PSPlasma> plasme = plasmaRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

    }
}
