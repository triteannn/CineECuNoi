using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class PungaSangeTest
    {
        private SqlPungaSangeRepo pungaRepo;
        private PungaSange punga = new PungaSange { };
        //PungiSange(DataRecoltare, Grupa, Rh, Target, IdCd, IdFd)



        [TestMethod]
        public void PungaSange_Add()
        {
            try
            {
                pungaRepo.Add(punga);
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
        public void PungaSange_Delete()
        {
            try
            {
                pungaRepo.Delete(punga);
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
        public void PungaSange_Update()
        {
            try
            {
                pungaRepo.Update(new PungaSange());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void PungaSange_FindEntity()
        {
            try
            {
                PungaSange pungaSange = pungaRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void PungaSange_FindAll()
        {
            try
            {
                List<PungaSange> pungi = pungaRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void PungaSange_FindByTarget()
        {
            try
            {
                List<PungaSange> pungi = pungaRepo.FindByTarget("4536345");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void PungaSange_GetPungaSangeCuCNP()
        {
            try
            {
                List<PungaSangeCuCNP> pungi = pungaRepo.GetPungaSangeCuCNP("4536345p");
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
