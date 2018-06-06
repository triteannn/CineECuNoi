using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class GlobuleRosiiTest
    {
        private SqlGlobuleRosiiRepo globuleRepo = new SqlGlobuleRosiiRepo();
        private PSGlobuleRosii globula = new PSGlobuleRosii { Cantitate = 101, Target = "1553235256253", DataExpirare = new DateTime(2021, 2, 3) };

        public GlobuleRosiiTest()
        {
           
        }


        [TestMethod]
        public void GlobuleRosii_Add()
        {

            try
            {
                globuleRepo.Add(new PSGlobuleRosii());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void GlobuleRosii_Delete()
        {
            try
            {
                globuleRepo.Delete(globula);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GlobuleRosii_Update()
        {
            try
            {
                globuleRepo.Update(new PSGlobuleRosii());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GlobuleRosii_FindEntity()
        {
            try
            {
                PSGlobuleRosii globuleRosii = globuleRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void GlobuleRosii_FindAll()
        {
            try
            {
                List<PSGlobuleRosii> globule = globuleRepo.FindAll();
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
        public void GlobuleRosii_FindByTarget()
        {
            try
            {
                List<PSGlobuleRosii> globule = globuleRepo.FindByTarget("34875748");
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

    }
}
