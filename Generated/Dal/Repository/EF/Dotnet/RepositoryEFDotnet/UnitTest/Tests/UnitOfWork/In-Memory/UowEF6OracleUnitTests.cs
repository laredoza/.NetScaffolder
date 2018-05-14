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
    public class UowEF6OracleUnitTest : BaseUnitOfWorkUnitTests<OracleFullContext>
    {
        [TestInitialize]
        public override void SetupUow()
        {
            Uow = new OracleFullContext(Effort.DbConnectionFactory.CreateTransient());
        }
    }
}
