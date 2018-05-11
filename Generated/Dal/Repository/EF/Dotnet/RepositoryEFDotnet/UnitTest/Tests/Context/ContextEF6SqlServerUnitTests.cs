using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class ContextEF6SqlServerUnitTest : BaseContextUnitTests<SqlServerFullContext>
    {
        [TestInitialize]
        public override void SetupContext()
        {
            Context = new SqlServerFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
