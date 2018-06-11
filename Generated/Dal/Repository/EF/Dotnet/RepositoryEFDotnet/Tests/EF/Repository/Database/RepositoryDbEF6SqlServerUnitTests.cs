// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEF6SqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context.EF;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /*public class RepositoryDbEF6SqlServerUnitTests : BaseRepositoryUnitTest*/

    /// <summary>
    /// The repository db e f 6 sql server unit tests.
    /// </summary>
    [TestClass]
    public class RepositoryDbEF6SqlServerUnitTests : BaseRepositoryUnitTest
    {
        private static string DbConfig = "RepoTest";

        #region Public Methods And Operators

        /// <summary>
        /// The class init.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            using (var uow = new SqlServerFullContext(DbConfig))
            {
                if (Database.Exists(DbConfig))
                {
                    Database.Delete(DbConfig);
                }

                Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerFullContext>());
                uow.Database.Initialize(true);
            }
        }

        [TestMethod]
        public void RunAll()
        {
            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Country_Add(uow);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Book_Add(uow);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(DbConfig))
            {
                this.BankTransfers_Add(uow);
            }
        }

        #endregion
    }
}