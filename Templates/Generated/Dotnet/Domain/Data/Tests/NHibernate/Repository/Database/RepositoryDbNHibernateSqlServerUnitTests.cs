﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEFCoreSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHib;
    using FluentNHibernate.Cfg.Db;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RepositoryEFDotnet.UnitTest.Base;
    using System.Configuration;
    using System.Data.SqlClient;
    using DatabaseContext = Banking.Models.Context.NHib.SqlServerFullContext;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryDbNHibernateSqlServerUnitTest : BaseRepositoryUnitTest
    {
        private static MsSqlConfiguration Config = null;

        #region Public Methods And Operators

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            DropCreateDatabase();
            Config =
                MsSqlConfiguration.MsSql2012.ConnectionString(
                    ConfigurationManager.ConnectionStrings["RepoTest"].ConnectionString).ShowSql();
        }

        private static void DropCreateDatabase()
        {
            using (var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Pooling=False"))
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"IF (db_id('RepoTest') IS NOT NULL)
                                        BEGIN
                                            ALTER DATABASE [RepoTest] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                            DROP DATABASE [RepoTest];
                                        END;
                                        
                                        CREATE DATABASE [RepoTest];";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
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
            //this.DeleteTests();
        }

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            using (var uow = new DatabaseContext(Config))
            {
                uow.DropSchema();
                uow.CreateSchema();
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The add tests.
        /// </summary>
        /// <param name="Config">
        /// The db id.
        /// </param>
        private void AddTests()
        {
            using (var uow = new DatabaseContext(Config))
            {
                this.Country_Add(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Book_Add(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Software_Add(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankTransfers_Add(uow);
            }
        }

        /// <summary>
        /// The delete tests.
        /// </summary>
        /// <param name="Config">
        /// The db id.
        /// </param>
        private void DeleteTests()
        {
            using (var uow = new DatabaseContext(Config))
            {
                this.BankTransfers_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankAccount_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.OrderDetails_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Order_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Software_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Book_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Product_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Customer_Delete(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Country_Delete(uow);
            }
        }

        /// <summary>
        /// The load tests.
        /// </summary>
        /// <param name="Config">
        /// The db id.
        /// </param>
        private void LoadTests()
        {
            using (var uow = new DatabaseContext(Config))
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
        /// <param name="Config">
        /// The db id.
        /// </param>
        private void SearchTests()
        {
            using (var uow = new DatabaseContext(Config))
            {
                this.Country_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Customer_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Product_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Book_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Software_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Order_SearchTests(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankAccount_SearchTests(uow);
            }
        }

        /// <summary>
        /// The update tests.
        /// </summary>
        /// <param name="Config">
        /// The db id.
        /// </param>
        private void UpdateTests()
        {
            // Updates
            using (var uow = new DatabaseContext(Config))
            {
                this.Country_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Customer_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Product_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Book_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Software_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.Order_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.OrderDetails_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankAccount_Update(uow);
            }

            using (var uow = new DatabaseContext(Config))
            {
                this.BankTransfers_Update(uow);
            }
        }

        #endregion
    }
}