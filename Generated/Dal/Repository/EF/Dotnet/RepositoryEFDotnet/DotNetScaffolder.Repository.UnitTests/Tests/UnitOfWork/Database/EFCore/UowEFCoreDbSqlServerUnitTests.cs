// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreDbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreDbSqlServerUnitTest : BaseUnitOfWorkUnitTests
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
            using (var context = new SqlServerFullContext(DbConfig))
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
            using (var context = new SqlServerFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}