//using Banking.Models.Context;
//using Banking.Models.Customers;
using Banking.Models.Accounts;
using Banking.Models.Context;
using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public class ContextOracleUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleAccountContext>());
            using (var context = new OracleAccountContext("RepoTestOracle"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<OracleAccountContext>());
                // BaseContextUnitTests_CreateDbTest(context);

                context.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new OracleCustomerContext("RepoTestOracle"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new OracleFullContext("RepoTestOracle"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
