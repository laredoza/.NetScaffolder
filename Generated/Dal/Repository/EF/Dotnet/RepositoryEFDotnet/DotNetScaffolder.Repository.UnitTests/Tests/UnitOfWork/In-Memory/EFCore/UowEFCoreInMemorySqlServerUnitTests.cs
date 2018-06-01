// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context.EFCore;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Diagnostics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Core.Base;

    /// <summary>
    /// The uow ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Public Methods And Operators

        /// <summary>
        /// The base unit of work unit tests_ bank account_ rollback.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        public override void BaseUnitOfWorkUnitTests_BankAccount_Rollback(IUnitOfWork uow)
        {
            // Transactions not supported by in-memory connections
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ rollback async.
        /// </summary>
        /// <param name="uow">
        /// The uow.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override async Task BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(IUnitOfWork uow)
        {
            // Transactions not supported by in-memory connections
            await Task.CompletedTask;
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            string dbInstance = "EFCORE_Sql";
            var options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;
            using (var context = new SqlServerFullContext(options))
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
            string dbInstance = "EFCORE_SqlAsync";
            var options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;

            using (var context = new SqlServerFullContext(options))
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}