//using Banking.Models.Context;
//using Banking.Models.Customers;

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Common;
    using System.Data.Entity;

    using Banking.Models.Context;
    using Banking.Models.Repository;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryDbEF6MySqlUnitTests : BaseRepositoryUnitTest
    {
        #region Init

        [ClassInitialize]
        public static void SetupDb()
        {
            //Context = new MySqlFullContext("RepoTestMySql");
            //Database.SetInitializer(new DropCreateDatabaseAlways<MySqlFullContext>());
        }

        #endregion
    }
}
