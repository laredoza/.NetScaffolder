using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using MySql.Data.MySqlClient;

    [TestClass]
    public class ContextEF6MySqlUnitTest : BaseContextUnitTests<MySqlFullContext>
    {
        [TestInitialize]
        public override void SetupContext()
        {
            Context = new MySqlFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
