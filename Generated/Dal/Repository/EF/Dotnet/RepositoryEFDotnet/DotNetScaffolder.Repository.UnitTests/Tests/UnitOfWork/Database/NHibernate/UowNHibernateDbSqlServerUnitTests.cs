// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreDbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context.Core;
    using Banking.Models.Context.NHibernate;

    using DotNetScaffolder.Repository.UnitTests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Contexts.NHibernate.SqlServer.Mappings;

    /// <summary>
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateDbSqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            using (var context = new SqlServerFullContext(DbConfig))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            var session = NHibernateSqlHelper<BankAccountMap>.OpenSession(DbConfig);
            using (var context = new SqlServerNHibernateContext(session))
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
            var session = NHibernateSqlHelper<BankAccountMap>.OpenSession(DbConfig);
            using (var context = new SqlServerNHibernateContext(session))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}