//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseContextUnitTests
    {
        [TestMethod]
        public void BaseContextUnitTests_CreateDbTest<TContext>(TContext context) where TContext : DbContext
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TContext>());
            context.Database.Initialize(true);
        }
    }
}
