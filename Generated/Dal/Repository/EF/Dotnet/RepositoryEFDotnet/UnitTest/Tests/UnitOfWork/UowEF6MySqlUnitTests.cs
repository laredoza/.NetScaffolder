using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using MySql.Data.MySqlClient;

    [TestClass]
    public class UowEF6MySqlUnitTest : BaseUnitOfWorkUnitTests<MySqlFullContext>
    {
        [TestInitialize]
        public override void SetupUow()
        {
            Uow = new MySqlFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
