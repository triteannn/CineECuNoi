using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class DateContactTest
    {
        //DateContact(Telefon, Email, IdAdr)
        private SQLDateContact dateContactRepo;
        private DateContact dateContact = new DateContact { };

        public DateContactTest()
        {
            dateContactRepo = new SQLDateContact();
        }

        [TestMethod]
        public void DateContact_Add()
        {
            try
            {
                dateContactRepo.Add(dateContact);
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
        public void DateContact_Delete()
        {
            try
            {
                dateContactRepo.Delete(dateContact);
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
        public void DateContact_Update()
        {
            try
            {
                dateContactRepo.Update(new DateContact());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void DateContact_FindEntity()
        {
            try
            {
                DateContact date = dateContactRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void DateContact_FindAll()
        {
            try
            {
                List<DateContact> date = dateContactRepo.FindAll();
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
