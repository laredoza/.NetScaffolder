using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;
    using System.Data.Entity;

    [TestClass]
    public class UowEF6DbSqlServerUnitTest : BaseUnitOfWorkUnitTests<SqlServerFullContext>
    {
        [ClassInitialize]
        public static void RecreateDb(TestContext context)
        {
            if (Database.Exists("RepoTest"))
            {
                Database.Delete("RepoTest");
                Database.SetInitializer(new DropCreateDatabaseAlways<SqlServerFullContext>());             
            }

            Uow = new SqlServerFullContext("RepoTest");
            Uow.Database.Initialize(true);
        }
    }
}
