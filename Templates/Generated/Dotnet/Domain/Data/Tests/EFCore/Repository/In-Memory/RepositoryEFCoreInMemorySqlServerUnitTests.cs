// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Runtime.CompilerServices;

    using Banking.Models.Context.EFCore;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;
    using DatabaseContext = Banking.Models.Context.EFCore.SqlServerFullContext;

    /// <summary>
    /// The repository ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEFCoreInMemorySqlServerUnitTest : BaseRepositoryUnitTest
    {
        private static string DbId = "EFCORE_SqlServer";
        private static DbContextOptions<DatabaseContext> Options;

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
            Options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(DbId).Options;

            using (var uow = new DatabaseContext(Options))
            {
                uow.Database.EnsureCreated();
            }
        }

        [TestInitialize]
        public void DisableTransactions()
        {
            this.UseTransactions = false;
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public void RunAll()
        {
            this.AddTests();
            this.SearchTests();
            this.UpdateTests();
            this.LoadTests();
            this.DeleteTests();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The add tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void AddTests()
        {
            using (var uow = new DatabaseContext(Options))
            {
                this.Country_Add(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Book_Add(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Software_Add(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.BankTransfers_Add(uow);
            }
        }

        /// <summary>
        /// The delete tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void DeleteTests()
        {
            using (var uow = new DatabaseContext(Options))
            {
                this.BankTransfers_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.BankAccount_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.OrderDetails_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Order_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Software_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Book_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Product_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Customer_Delete(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Country_Delete(uow);
            }
        }

        /// <summary>
        /// The load tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void LoadTests()
        {
            using (var uow = new DatabaseContext(Options))
            {
                this.Country_LoadTests(uow);
                this.Customer_LoadTests(uow);
                this.Product_LoadTests(uow);
                this.Book_LoadTests(uow);
                this.Software_LoadTests(uow);
                this.Order_LoadTests(uow);
                this.OrderDetails_LoadTests(uow);
                this.BankAccount_LoadTests(uow);
                this.BankTransfers_LoadTests(uow);
            }
        }

        /// <summary>
        /// The search tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void SearchTests()
        {
            using (var uow = new DatabaseContext(Options))
            {
                this.Country_SearchTests(uow);
                this.Customer_SearchTests(uow);
                this.Product_SearchTests(uow);
                this.Book_SearchTests(uow);
                this.Software_SearchTests(uow);
                this.Order_SearchTests(uow);
                this.BankAccount_SearchTests(uow);
            }
        }

        /// <summary>
        /// The update tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void UpdateTests()
        {
            // Updates
            using (var uow = new DatabaseContext(Options))
            {
                this.Country_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Customer_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Product_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Book_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Software_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.Order_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.OrderDetails_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.BankAccount_Update(uow);
            }

            using (var uow = new DatabaseContext(Options))
            {
                this.BankTransfers_Update(uow);
            }
        }

        #endregion
    }
}