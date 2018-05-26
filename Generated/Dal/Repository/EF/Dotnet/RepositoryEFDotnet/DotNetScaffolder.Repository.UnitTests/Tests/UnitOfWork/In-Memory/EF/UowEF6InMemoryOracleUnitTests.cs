// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6InMemoryOracleUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Threading.Tasks;

    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Core.Base;

    /// <summary>
    /// The uow e f 6 in memory oracle unit test.
    /// </summary>
    [TestClass]
    public class UowEF6InMemoryOracleUnitTest : BaseUnitOfWorkUnitTests
    {
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new OracleFullContext(DbConnectionFactory.CreateTransient()))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new OracleFullContext(DbConnectionFactory.CreateTransient()))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}