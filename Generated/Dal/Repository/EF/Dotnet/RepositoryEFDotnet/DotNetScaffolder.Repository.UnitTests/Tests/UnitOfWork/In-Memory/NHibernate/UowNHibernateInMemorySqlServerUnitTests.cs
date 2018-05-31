// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context.NHibernate;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;

    using RepositoryEFDotnet.Contexts.NHibernate.SqlServer.Mappings;

    /// <summary>
    /// The uow n hibernate in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        #endregion

        #region Fields

        /// <summary>
        /// The factory.
        /// </summary>
        private ISessionFactory factory;

        /// <summary>
        /// The session.
        /// </summary>
        private ISession session;

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The cleanup.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            if (this.session != null && this.session.IsOpen)
            {
                this.session.Close();
                this.session.Dispose();
            }

            if (this.factory != null && !this.factory.IsClosed)
            {
                this.factory.Close();
                this.factory.Dispose();
            }
        }

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            Configuration config = null;
            this.factory = Fluently.Configure().Database(SQLiteConfiguration.Standard.InMemory().ShowSql())
                .Mappings(m => m.FluentMappings.Add<BankAccountMap>()).ExposeConfiguration(cfg => config = cfg)
                .BuildSessionFactory();

            this.session = this.factory.OpenSession();

            var export = new SchemaExport(config);
            // Create database
            export.Execute(false, true, false, this.session.Connection, null);
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerNHibernateContext(this.session))
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
            using (var context = new SqlServerNHibernateContext(this.session))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}