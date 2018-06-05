namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHibernate;
    using FluentNHibernate.Cfg.Db;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Configuration;
    using System.Threading.Tasks;

    using MySql.Data.MySqlClient;

    using RepositoryEFDotnet.UnitTest.Base;

    [TestClass]
    public class UowNHibernateDbMySqlUnitTest : BaseUnitOfWorkUnitTests
    {
        private static MySQLConfiguration Config = null;

        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTestMySql";

        #endregion

        #region Public Methods And Operators
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            DropCreateDatabase();

            Config =
                MySQLConfiguration.Standard.ConnectionString(
                    ConfigurationManager.ConnectionStrings[DbConfig].ConnectionString);
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
            using (var context = new MySqlFullContext(Config))
            {
                context.DropSchema();
                context.CreateSchema();
            }
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new MySqlFullContext(Config))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        /// <summary>
        /// The run all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new MySqlFullContext(Config))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}