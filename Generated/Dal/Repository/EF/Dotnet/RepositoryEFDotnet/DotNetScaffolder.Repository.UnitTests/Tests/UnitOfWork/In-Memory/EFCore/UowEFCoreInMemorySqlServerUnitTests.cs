// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context.Core;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow ef core in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests<EFCoreSqlServerFullContext>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The class init.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var options = new DbContextOptionsBuilder<EFCoreSqlServerFullContext>()
                .UseInMemoryDatabase("EFCORE_SqlServer").Options;
            Uow = new EFCoreSqlServerFullContext(options);
            Uow.Database.EnsureDeleted();
            Uow.Database.EnsureCreated();
        }

        /// <summary>
        /// The base unit of work unit tests_ bank account_ rollback.
        /// </summary>
        [TestMethod]
        public override void BaseUnitOfWorkUnitTests_BankAccount_Rollback()
        {
            // Transactions not supported by in-memory connections
        }

        /// <summary>
        ///     The base unit of work unit tests_ bank account_ rollback async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        [TestMethod]
        public override async Task BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync()
        {
            // Transactions not supported by in-memory connections
        }

        #endregion
    }
}