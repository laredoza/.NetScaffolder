using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextEF6MySqlUnitTest : BaseContextUnitTests
    {
        [TestMethod]
        public void ContextUnitTest_AccountContext_CreateDb()
        {
            using (var context = new MySqlAccountContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_CustomerContext_CreateDb()
        {
            using (var context = new MySqlCustomerContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }

        [TestMethod]
        public void ContextUnitTest_FullContext_CreateDb()
        {
            using (var context = new MySqlFullContext("RepoTestMySql"))
            {
                BaseContextUnitTests_CreateDbTest(context);
            }
        }
    }
}
