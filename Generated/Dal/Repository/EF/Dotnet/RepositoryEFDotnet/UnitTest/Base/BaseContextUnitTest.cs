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

        #region CTOR

        protected BaseContextUnitTests(TContext context)
        {
            Context = context ?? throw new System.ArgumentNullException("Context", "The context cannot be null");
        }

        #endregion

        [TestMethod]
        protected void BaseContextUnitTests_CreateDbTest()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());
            Context.Database.Initialize(true);
        }

        #region Cleanup

        [TestCleanup]
        private void DisposeContext()
        {
            Context?.Dispose();
        }

        #endregion
    }
}
