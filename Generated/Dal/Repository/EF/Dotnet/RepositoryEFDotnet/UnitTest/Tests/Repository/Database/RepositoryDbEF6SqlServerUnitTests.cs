//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Accounts;
    using Banking.Models.Context;
    using Banking.Models.Repository;
    using System.Data.Common;
    using System.Data.Entity;

    /*public class RepositoryDbEF6SqlServerUnitTests : BaseRepositoryUnitTest*/
    [TestClass]
    public class RepositoryDbEF6SqlServerUnitTests
    {
        #region Init

        //[TestInitialize]
        [TestMethod]
        public void SetupDb()
        {
            var Context = new SqlServerFullContext("RepoTest");
            Database.SetInitializer(new DropCreateDatabaseAlways<SqlServerFullContext>());
            Context.Database.Initialize(true);
        }

        #endregion
    }
}
