// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateDbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Configuration;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;
    using System.Threading.Tasks;
    using Banking.Models.Context.NHibernate;

    using Configuration = System.Configuration.Configuration;

    /// <summary>
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateDbSqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        private static MsSqlConfiguration Config = null;

        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        #endregion

        #region Public Methods And Operators
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            Config =
                MsSqlConfiguration.MsSql2012.ConnectionString(
                    ConfigurationManager.ConnectionStrings[DbConfig].ConnectionString);
        }

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            using (var context = new SqlServerFullContext(Config))
            {
                context.DropDatabase();
                context.CreateDatabase();
            }
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(Config))
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
            using (var context = new SqlServerFullContext(Config))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}