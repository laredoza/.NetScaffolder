using System;
using System.Data.Entity;
using Banking.Models.Accounts;
using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateDbTest()
        {
            using (var context = new AccountContext("RepoTest"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<AccountContext>());
                context.Database.Initialize(true);
            }

            using (var context = new CustomerContext("RepoTest"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<AccountContext>());
                context.Database.Initialize(true);
            }
        }
    }
}
