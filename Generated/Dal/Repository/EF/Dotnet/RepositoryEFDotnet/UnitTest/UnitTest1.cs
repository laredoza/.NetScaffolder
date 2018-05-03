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
                var config = new DropCreateDatabaseAlways<AccountContext>();
                
                Database.SetInitializer(config);
                context.Database.Initialize(true);
            }

            using (var context = new CustomerContext("RepoTest"))
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerContext>());
                context.Database.Initialize(true);
            }
        }
    }
}
