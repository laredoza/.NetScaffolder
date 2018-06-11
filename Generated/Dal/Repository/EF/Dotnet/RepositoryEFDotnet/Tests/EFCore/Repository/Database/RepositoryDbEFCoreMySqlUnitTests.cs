// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEFCoreSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EFCore;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryDbEFCoreMySqlUnitTest : BaseRepositoryUnitTest
    {
        private static string DbId = "RepoTestMySql";

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
            using (var uow = new MySqlFullContext(DbId))
            {
                uow.Database.EnsureCreated();
            }
        }

        [TestInitialize]
        public void DisableTransactions()
        {
            this.UseTransactions = false;
        }

        [TestMethod]
        public void RunAll()
        {
            using (var uow = new MySqlFullContext(DbId))
            {
                this.Country_Add(uow);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.Book_Add(uow);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(DbId))
            {
                this.BankTransfers_Add(uow);
            }
        }

        #endregion
    }
}