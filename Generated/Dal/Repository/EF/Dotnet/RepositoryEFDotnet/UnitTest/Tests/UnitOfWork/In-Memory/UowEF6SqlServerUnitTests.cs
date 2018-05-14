using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;

    [TestClass]
    public class UowEF6SqlServerUnitTest : BaseUnitOfWorkUnitTests<SqlServerFullContext>
    {
        [TestInitialize]
        public override void SetupUow()
        {
            Uow = new SqlServerFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
