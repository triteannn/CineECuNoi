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
        private readonly SqlAccountRepo accountRepo = new SqlAccountRepo();
        private Account account = new Account { Username="tiesto", Password = "paroala"};


        public AccountTest()
        {
            
        }

        [TestMethod]
        public void Account_Add()
        {
            try
            {
                accountRepo.Add(new Account());
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }


        [TestMethod]
        public void Account_Delete()
        {
            try
            {
                accountRepo.Delete(account);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Account_Update()
        {
            try
            {
                accountRepo.Update(new Account());
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Account_FindEntity()
        {
            try
            {
                Account account = accountRepo.FindEntity(1);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Account_FindAll()
        {
            try
            {
                List<Account> accounts = accountRepo.FindAll();
                Assert.IsTrue(accounts.Count >= 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
            }
        }


        [TestMethod]
        public void Account_FindAccountByCredentials()
        {
            try
            {
                Account account = accountRepo.FindAccountByCredentials("admin", "nimda");
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail();
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
