// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NHibernate;
    using System.Threading.Tasks;
    using Banking.Models.Context.NHibernate;

    using FluentNHibernate.Cfg.Db;

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

        #region Public Methods And Operators

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(MsSqliteConfiguration.Standard.InMemory()))
            {
                context.CreateDatabase();
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
            using (var context = new SqlServerFullContext(MsSqliteConfiguration.Standard.InMemory()))
            {
                context.CreateDatabase();
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}