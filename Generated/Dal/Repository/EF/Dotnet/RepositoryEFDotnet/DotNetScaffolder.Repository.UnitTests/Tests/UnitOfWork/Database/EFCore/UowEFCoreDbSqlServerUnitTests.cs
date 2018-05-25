// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreDbSqlServerUnitTests.cs" company="DotnetScaffolder">
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
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreDbSqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        private const string DbConfig = "RepoTest";

        [TestInitialize]
        public void Init()
        {
            using (var context = new EFCoreSqlServerFullContext(DbConfig))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        [TestMethod]
        public override void RunAll()
        {
            using (var context = new EFCoreSqlServerFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new EFCoreSqlServerFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}