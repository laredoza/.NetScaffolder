//using Banking.Models.Customers;
using Banking.Models.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System.Data.Entity;
using System.Linq;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseUnitOfWorkUnitTests<TUow> : BaseUnitTest where TUow : DbContext, IUnitOfWork
    {
        #region Fields

        protected TUow Uow = null;

        #endregion

        #region Setup

        public abstract void SetupUow();

        #endregion

        #region Tests

        [TestMethod]
        public void BaseUnitOfWorkUnitTests_CreateDbTest()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TUow>());
            Uow.Database.Initialize(true);
        }

        [TestMethod]
        public void BaseUnitOfWorkUnitTests_Add_Country()
        {
            var entity = new Country();
            PopulateCountry(entity);

            Uow.Add(entity);
            Uow.SaveChanges();

            var entities = Uow.GetAll<Country>();
            Check_EntityCount(1, entities.Count(), "Countries");
            Check_Country(entities.FirstOrDefault());
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void DisposeContext()
        {
            Uow?.Dispose();
        }

        #endregion
    }
}
