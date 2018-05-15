using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using MySql.Data.MySqlClient;

    [TestClass]
    public class UowEF6IDbMySqlUnitTest : BaseUnitOfWorkUnitTests<MySqlFullContext>
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Uow = new MySqlFullContext("RepoTestMySql");
        }
    }
}
