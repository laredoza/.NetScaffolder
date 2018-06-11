// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EFCore;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEFCoreInMemoryMySqlUnitTest : BaseRepositoryUnitTest
    {
        private static string DbId = "EFCORE_MySql";
        private static DbContextOptions<MySqlFullContext> Options;

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
            Options = new DbContextOptionsBuilder<MySqlFullContext>().UseInMemoryDatabase("EFCORE_SqlServer").Options;

            using (var uow = new MySqlFullContext(Options))
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
            using (var uow = new MySqlFullContext(Options))
            {
                this.Country_Add(uow);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.Book_Add(uow);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Options))
            {
                this.BankTransfers_Add(uow);
            }
        }

        #endregion
    }
}