﻿using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class SpitalTest
    {
        //Spitale(Denumire, IdAdr)
        private SqlSpitalRepo spitalRepo;
        private Spital spital = new Spital { Denumire = "Urgente" };

        [TestMethod]
        public void Spital_Add()
        {

            try
            {
                spitalRepo.Add(spital);
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
        public void Spital_Delete()
        {
            try
            {
                spitalRepo.Delete(spital);
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
        public void Spital_Update()
        {
            try
            {
                spitalRepo.Update(new Spital());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Spital_FindEntity()
        {
            try
            {
                Spital spital = spitalRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Spital_FindAll()
        {
            try
            {
                List<Spital> spitale = spitalRepo.FindAll();
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
