using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using MySql.Data.MySqlClient;

    [TestClass]
    public class UowEF6InMemoryMySqlUnitTest : BaseUnitOfWorkUnitTests<MySqlFullContext>
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            
        }

        [TestInitialize]
        public void TestInit()
        {
            Uow = new MySqlFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Uow?.Dispose();
        }
    }
}
