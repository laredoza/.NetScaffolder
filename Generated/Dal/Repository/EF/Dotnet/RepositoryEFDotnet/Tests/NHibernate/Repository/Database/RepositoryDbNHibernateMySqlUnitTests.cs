// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEFCoreSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Configuration;

    using Banking.Models.Context.NHibernate;

    using FluentNHibernate.Cfg.Db;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MySql.Data.MySqlClient;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryDbNHibernateMySqlUnitTest : BaseRepositoryUnitTest
    {
        private static MySQLConfiguration Config = null;

        #region Public Methods And Operators

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            DropCreateDatabase();

            Config =
                MySQLConfiguration.Standard.ConnectionString(
                    ConfigurationManager.ConnectionStrings["RepoTestMySql"].ConnectionString);
        }

        private static void DropCreateDatabase()
        {
            using (var con = new MySqlConnection(@"server=localhost;userid=root;password=password;SslMode=none;"))
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"CREATE DATABASE IF NOT EXISTS Test;";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }


        [TestMethod]
        public void RunAll()
        {
            using (var uow = new MySqlFullContext(Config))
            {
                this.Country_Add(uow);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.Book_Add(uow);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Config))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new MySqlFullContext(Config))
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
            using (var uow = new MySqlFullContext(Config))
            {
                uow.DropSchema();
                uow.CreateSchema();
            }
        }

        #endregion
    }
}