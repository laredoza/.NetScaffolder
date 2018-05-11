//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System.Data.Entity;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseContextUnitTests<TContext> where TContext : DbContext, IUnitOfWork
    {
        #region Fields

        protected TContext Context = null;

        #endregion

        #region Setup

        public abstract void SetupContext();

        #endregion

        #region Tests

        [TestMethod]
        public void BaseContextUnitTests_CreateDbTest()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());
            Context.Database.Initialize(true);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void DisposeContext()
        {
            Context?.Dispose();
        }

        #endregion
    }
}
