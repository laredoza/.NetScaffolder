// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEF6InMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Public Methods And Operators

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(DbConnectionFactory.CreateTransient()))
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
            using (var context = new SqlServerFullContext(DbConnectionFactory.CreateTransient()))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}