using System;
using System.Data.Entity;
using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using DotNetScaffolder.Test.Components.SourceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextOracleUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AccountContext>());
            using (var context = new AccountContext("RepoTestOracle"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<AccountContext>());
                // BaseContextUnitTests_CreateDbTest(context);

                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new CustomerContext("RepoTestOracle"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new FullContext("RepoTestOracle"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
