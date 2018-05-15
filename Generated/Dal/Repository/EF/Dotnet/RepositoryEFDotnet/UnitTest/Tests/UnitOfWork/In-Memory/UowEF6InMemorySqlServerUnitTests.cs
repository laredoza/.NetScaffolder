using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class UowEF6InMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests<SqlServerFullContext>
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            Uow = new SqlServerFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Uow?.Dispose();
        }
    }
}
