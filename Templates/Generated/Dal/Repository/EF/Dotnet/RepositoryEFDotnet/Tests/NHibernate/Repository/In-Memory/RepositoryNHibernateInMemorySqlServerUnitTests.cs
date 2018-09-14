// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHib;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NHibernate.Cfg;

    using RepositoryEFDotnet.UnitTest.Base;
    using DatabaseContext = Banking.Models.Context.NHib.SqlServerFullContext;

    /// <summary>
    /// The repository ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryNHibernateInMemorySqlServerUnitTest : BaseRepositoryUnitTest
    {
        private static Configuration Configuration = null;
        private static DatabaseContext OpenContext = null;

        [ClassInitialize]
        public static void TestInit(TestContext tstContext)
        {
            Configuration = Fluently.Configure().Database(MsSqliteConfiguration.Standard.ConnectionString("Data Source=:memory:;cache=shared;mode=memory")).Mappings(
                o => o.FluentMappings
                    .AddFromAssemblyOf<Banking.Models.Context.Mappings.NHib.SqlServer.BankAccountMap>()).BuildConfiguration();

            // Keep connection to in-memory db alive for duration of test
            // otherwise the db gets discarded when all connections are closed
            OpenContext = new DatabaseContext(Configuration);
            OpenContext.CreateSchema();
        }

        #region Public Methods And Operators

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
        /// <param name="Configuration">
        /// The db id.
        /// </param>
        private void AddTests()
        {
            using (var uow = new DatabaseContext(Configuration))
            {
                this.Country_Add(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Book_Add(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Software_Add(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankTransfers_Add(uow);
            }
        }

        /// <summary>
        /// The delete tests.
        /// </summary>
        /// <param name="Configuration">
        /// The db id.
        /// </param>
        private void DeleteTests()
        {
            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankTransfers_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankAccount_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.OrderDetails_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Order_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Software_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Book_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Product_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Customer_Delete(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Country_Delete(uow);
            }
        }

        /// <summary>
        /// The load tests.
        /// </summary>
        /// <param name="Configuration">
        /// The db id.
        /// </param>
        private void LoadTests()
        {
            using (var uow = new DatabaseContext(Configuration))
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
        /// <param name="Configuration">
        /// The db id.
        /// </param>
        private void SearchTests()
        {
            using (var uow = new DatabaseContext(Configuration))
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
        /// <param name="Configuration">
        /// The db id.
        /// </param>
        private void UpdateTests()
        {
            // Updates
            using (var uow = new DatabaseContext(Configuration))
            {
                this.Country_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Customer_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Product_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Book_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Software_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.Order_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.OrderDetails_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankAccount_Update(uow);
            }

            using (var uow = new DatabaseContext(Configuration))
            {
                this.BankTransfers_Update(uow);
            }
        }

        #endregion

        [ClassCleanup]
        public static void Cleanup()
        {
            Configuration = null;
            OpenContext?.Dispose();
            OpenContext = null;
        }
    }
}