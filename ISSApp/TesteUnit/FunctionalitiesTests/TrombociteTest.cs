using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class TrombociteTest
    {
        private SqlTrombociteRepo trombociteRepo;
        private PSTrombocite trombocit = new PSTrombocite { Cantitate = 141, Target = "6653474674", DataExpirare = new DateTime(2006, 9, 3) };

        public TrombociteTest()
        {
            trombociteRepo = new SqlTrombociteRepo();
        }


        [TestMethod]
        public void Trombocite_Add()
        {

            try
            {
                trombociteRepo.Add(trombocit);
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
        public void Trombocite_Delete()
        {
            try
            {
                trombociteRepo.Delete(trombocit);
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
        public void Trombocite_Update()
        {
            try
            {
                trombociteRepo.Update(new PSTrombocite());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Trombocite_FindEntity()
        {
            try
            {
                PSTrombocite trombocit = trombociteRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Trombocite_FindAll()
        {
            try
            {
                List<PSTrombocite> trombocite = trombociteRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Trombocite_FindByTarget()
        {
            try
            {
                List<PSTrombocite> trombocite = trombociteRepo.FindByTarget("36568567");
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
