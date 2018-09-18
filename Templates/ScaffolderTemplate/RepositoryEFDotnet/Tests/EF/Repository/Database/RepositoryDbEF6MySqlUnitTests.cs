// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEF6MySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context.EF;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;
    using DatabaseContext = Banking.Models.Context.EF.MySqlFullContext;

    /// <summary>
    /// The repository db e f 6 my sql unit tests.
    /// </summary>
    [TestClass]
    public class RepositoryDbEF6MySqlUnitTests : BaseRepositoryUnitTest
    {
        private static string DbConfig = "RepoTestMySql";

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
            using (var uow = new DatabaseContext(DbConfig))
            {
                if (Database.Exists(DbConfig))
                {
                    Database.Delete(DbConfig);
                }

                Database.SetInitializer(new CreateDatabaseIfNotExists<DatabaseContext>());
                uow.Database.Initialize(true);
            }
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public void RunAll()
        {
            this.AddTests(DbConfig);
            this.SearchTests(DbConfig);
            this.UpdateTests(DbConfig);
            this.LoadTests(DbConfig);
            this.DeleteTests(DbConfig);
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The add tests.
        /// </summary>
        /// <param name="dbId">
        /// The db id.
        /// </param>
        private void AddTests(string dbId)
        {
            using (var uow = new DatabaseContext(dbId))
            {
                this.Country_Add(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Book_Add(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Software_Add(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(dbId))
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
        private void DeleteTests(string dbId)
        {
            using (var uow = new DatabaseContext(dbId))
            {
                this.BankTransfers_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.BankAccount_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.OrderDetails_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Order_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Software_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Book_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Product_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Customer_Delete(uow);
            }

            using (var uow = new DatabaseContext(dbId))
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
        private void LoadTests(string dbId)
        {
            using (var uow = new DatabaseContext(dbId))
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
        private void SearchTests(string dbId)
        {
            using (var uow = new DatabaseContext(dbId))
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
        private void UpdateTests(string dbId)
        {
            // Updates
            using (var uow = new DatabaseContext(dbId))
            {
                this.Country_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Customer_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Product_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Book_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Software_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.Order_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.OrderDetails_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.BankAccount_Update(uow);
            }

            using (var uow = new DatabaseContext(dbId))
            {
                this.BankTransfers_Update(uow);
            }
        }

        #endregion
    }
}