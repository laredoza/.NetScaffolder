//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Repository;
    using System.Data.Common;

    [TestClass]
    public class RepositoryEF6InMemoryOracleUnitTest : BaseRepositoryUnitTest
    {
        #region Init

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Context = new OracleFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}
