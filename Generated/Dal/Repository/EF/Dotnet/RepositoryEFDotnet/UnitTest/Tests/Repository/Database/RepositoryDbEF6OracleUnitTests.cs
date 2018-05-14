//using Banking.Models.Context;
//using Banking.Models.Customers;

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Common;
    using System.Data.Entity;
    using System.Runtime.Remoting.Contexts;

    using Banking.Models.Context;
    using Banking.Models.Repository;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryDbEF6OracleUnitTests 
    {
        #region Init

        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_CreateDbTest()
        {
            var Context = new OracleFullContext("RepoTestOracle");
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleFullContext>());
            Context.Database.Initialize(true);
        }

        #endregion
    }
}
