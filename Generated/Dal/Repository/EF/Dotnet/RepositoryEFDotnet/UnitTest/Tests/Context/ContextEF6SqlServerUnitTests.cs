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
    public class ContextEF6SqlServerUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            using (var context = new AccountContext("RepoTest"))
            {
                BaseContextUnitTests_CreateDbTest(context);
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

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new FullContext("RepoTest"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
