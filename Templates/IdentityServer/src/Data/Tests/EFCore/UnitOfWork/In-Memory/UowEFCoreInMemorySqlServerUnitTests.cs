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
    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The uow ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        private DbContextOptions<SqlServerFullContext> Options;

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
            this.Options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Add(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Get(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Modify(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Remove(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AddRange(uow, 100, 2);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged(uow, 2);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Max(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRange(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Rollback(uow);
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
            this.Options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning)).Options;

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AnyAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(uow, 100, 2);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_MaxAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync(uow);
            }

            using (var uow = new SqlServerFullContext(this.Options))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(uow);
            }
        }

        #endregion
    }
}