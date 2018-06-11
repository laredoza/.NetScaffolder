// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEFCoreSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHibernate;
    using FluentNHibernate.Cfg.Db;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using RepositoryEFDotnet.UnitTest.Base;
    using System.Configuration;
    using System.Data.SqlClient;

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
                    ConfigurationManager.ConnectionStrings["RepoTest"].ConnectionString);
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

        [TestMethod]
        public void RunAll()
        {
            using (var uow = new SqlServerFullContext(Config))
            {
                this.Country_Add(uow);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.Book_Add(uow);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new SqlServerFullContext(Config))
            {
                this.BankTransfers_Add(uow);
            }
        }

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            using (var uow = new SqlServerFullContext(Config))
            {
                uow.DropSchema();
                uow.CreateSchema();
            }
        }

        #endregion
    }
}