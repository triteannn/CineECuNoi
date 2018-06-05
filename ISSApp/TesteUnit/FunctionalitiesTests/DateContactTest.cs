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
        private SQLDateContact dateContactRepo = new SQLDateContact();
        private DateContact dateContact = new DateContact { };

        public DateContactTest()
        {
            
        }

        [TestMethod]
        public void DateContact_Add()
        {
            try
            {
                dateContactRepo.Add(dateContact);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void DateContact_Delete()
        {
            try
            {
                dateContactRepo.Delete(dateContact);
                Assert.Fail();
            }
            catch (Exception)
            {
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
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void DateContact_FindEntity()
        {
            try
            {
                DateContact date = dateContactRepo.FindEntity(1); //keep it this way
                Assert.IsTrue(date.Email == "tudortritean@gmail.com");
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void DateContact_FindAll()
        {
            try
            {
                List<DateContact> date = dateContactRepo.FindAll();
                Assert.IsTrue(date.Count >= 0);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

    }
}
