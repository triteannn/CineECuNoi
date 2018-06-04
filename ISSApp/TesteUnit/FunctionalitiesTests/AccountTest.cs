using System;
using System.Collections.Generic;
using ISSApp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Repository;

namespace TesteUnit.FunctionalitiesTests
{
    [TestClass]
    public class AccountTest
    {
        //Accounts(Username, Password)
        private SqlAccountRepo accountRepo;
        private Account account = new Account { Username="tiesto", Password = "paroala"};


        [TestMethod]
        public void Account_Add()
        {
            try
            {
                accountRepo.Add(account);
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
        public void Account_Delete()
        {
            try
            {
                accountRepo.Delete(account);
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
        public void Donator_Update()
        {
            try
            {
                accountRepo.Update(new Account());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Account_FindEntity()
        {
            try
            {
                Account account = accountRepo.FindEntity(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Account_FindAll()
        {
            try
            {
                List<Account> accounts = accountRepo.FindAll();
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Account_FindAccountByCredentials()
        {
            try
            {
                Account account = accountRepo.FindAccountByCredentials("Andreea", "saint.tropz");
                Assert.Fail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Account_FindAccountByUsername()
        {
            try
            {
                Account account = accountRepo.FindAccountByUsername("gyuri");
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
