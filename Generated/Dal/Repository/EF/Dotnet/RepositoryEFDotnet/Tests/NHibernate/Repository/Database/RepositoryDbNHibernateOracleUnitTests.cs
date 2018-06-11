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

    using Oracle.ManagedDataAccess.Client;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryDbNHibernateOracleUnitTest : BaseRepositoryUnitTest
    {
        private static OracleDataClientConfiguration Config = null;

        #region Public Methods And Operators

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            DropCreateDatabase();
            Config = OracleDataClientConfiguration.Oracle10.ConnectionString(ConfigurationManager.ConnectionStrings["RepoTestOracle"].ConnectionString);
        }

        private static void DropCreateDatabase()
        {
            using (var con = new OracleConnection(
                @"DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=dbo;PASSWORD=Password123"))
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"IF EXISTS(SELECT * FROM user_tables WHERE  table_name = 'RepoTest'))
                                        BEGIN
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
            using (var uow = new OracleFullContext(Config))
            {
                this.Country_Add(uow);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.Book_Add(uow);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(Config))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(Config))
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
            using (var uow = new OracleFullContext(Config))
            {
                uow.DropSchema();
                uow.CreateSchema();
            }
        }

        #endregion
    }
}