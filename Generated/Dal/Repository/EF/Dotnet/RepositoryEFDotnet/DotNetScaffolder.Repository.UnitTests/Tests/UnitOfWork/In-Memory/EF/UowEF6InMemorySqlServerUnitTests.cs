// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System;
    using System.Threading.Tasks;

    using Banking.Models.Context;
    using Banking.Models.Context.Core;

    using Effort;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Core.Base;

    using SqlServerFullContext = Banking.Models.Context.SqlServerFullContext;

    /// <summary>
    /// The uow e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEF6InMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(DbConnectionFactory.CreateTransient()))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new SqlServerFullContext(DbConnectionFactory.CreateTransient()))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}