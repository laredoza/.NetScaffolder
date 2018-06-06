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

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            Context = new MySqlFullContext(Config);

            ((MySqlFullContext)Context).DropSchema();
            ((MySqlFullContext)Context).CreateSchema();
        }

        #endregion
    }
}