//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Accounts;
    using Banking.Models.Context;
    using Banking.Models.Repository;
    using System.Data.Common;

    [TestClass]
    public class RepositoryEF6InMemorySqlServerUnitTest : BaseRepositoryUnitTest
    {
        #region Init

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Context = new SqlServerFullContext(Effort.DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}
