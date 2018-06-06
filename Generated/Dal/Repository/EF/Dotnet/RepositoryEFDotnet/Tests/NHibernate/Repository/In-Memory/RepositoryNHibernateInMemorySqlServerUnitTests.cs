// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHibernate;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using NHibernate.Cfg;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryNHibernateInMemorySqlServerUnitTest : BaseRepositoryUnitTest
    {
        private static Configuration Configuration = null;
        private static SqlServerFullContext OpenContext = null;

        [ClassInitialize]
        public static void TestInit(TestContext tstContext)
        {
            Configuration = Fluently.Configure().Database(MsSqliteConfiguration.Standard.ConnectionString("Data Source=:memory:;cache=shared;mode=memory")).Mappings(
                o => o.FluentMappings
                    .AddFromAssemblyOf<Banking.Models.Context.Mappings.NHibernate.SqlServer.BankAccountMap>()).BuildConfiguration();

            // Keep connection to in-memory db alive for duration of test
            // otherwise the db gets discarded when all connections are closed
            OpenContext = new SqlServerFullContext(Configuration);
            OpenContext.CreateSchema();
        }

        #region Public Methods And Operators

        /// <summary>
        /// The class init.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        [TestInitialize]
        public void Init()
        {
            Context = new SqlServerFullContext(Configuration);
        }

        #endregion

        [ClassCleanup]
        public static void Cleanup()
        {
            Context?.Dispose();
            Context = null;
            Configuration = null;
            OpenContext?.Dispose();
            OpenContext = null;
        }
    }
}