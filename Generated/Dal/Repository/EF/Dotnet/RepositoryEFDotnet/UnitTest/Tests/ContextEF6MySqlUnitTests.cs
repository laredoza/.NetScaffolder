using System;
using System.Data.Entity;
using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using DotNetScaffolder.Test.Components.SourceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using WindowsFormsApp1;

    using MySql.Data.MySqlClient;
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextEF6MySqlUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            using (var context = new AccountContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new CustomerContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new FullContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
