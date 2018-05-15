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
    public class UowEF6DbOracleUnitTest : BaseUnitOfWorkUnitTests<OracleFullContext>
    {
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Uow = new OracleFullContext("RepoTestOracle");
        }
    }
}
