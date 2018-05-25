// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System;
    using System.Threading.Tasks;

    using Banking.Models.Context.Core;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Core.Base;

    /// <summary>
    /// The uow ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {

        #region Public Methods And Operators

        [TestMethod]
        public override void RunAll()
        {
            string dbInstance = "EFCORE_Sql";
            var options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).Options;
            using (var context = new SqlServerFullContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            string dbInstance = "EFCORE_SqlAsync";
            var options = new DbContextOptionsBuilder<SqlServerFullContext>().UseInMemoryDatabase(dbInstance).Options;
            
            using (var context = new SqlServerFullContext(options))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ rollback.
        /// </summary>
        public override void BaseUnitOfWorkUnitTests_BankAccount_Rollback(IUnitOfWork uow)
        {
            // Transactions not supported by in-memory connections
        }

        /// <summary>
        ///     The base unit of work unit tests_ bank account_ rollback async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public override async Task BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(IUnitOfWork uow)
        {
            // Transactions not supported by in-memory connections
            await Task.CompletedTask;
        }

        #endregion
    }
}