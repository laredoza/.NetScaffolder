using System;
using System.Data.Entity;
using Banking.Models.Accounts;
using Banking.Models.Customers;
using DotNetScaffolder.Test.Components.SourceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public class ContextUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            using (var context = new AccountContext("RepoTest"))
            {
                var config = new DropCreateDatabaseAlways<AccountContext>();
                
                Database.SetInitializer(config);
                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new CustomerContext("RepoTest"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
