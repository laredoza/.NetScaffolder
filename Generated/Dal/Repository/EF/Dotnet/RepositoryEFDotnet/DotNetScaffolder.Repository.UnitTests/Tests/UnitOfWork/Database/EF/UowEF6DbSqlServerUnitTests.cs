// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;
    using System.Threading.Tasks;

    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.Core.Base;

    /// <summary>
    /// The uow e f 6 db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbSqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        private const string DbConfig = "RepoTest";

        [TestInitialize]
        public void Init()
        {
            if (Database.Exists(DbConfig))
            {
                Database.Delete(DbConfig);
                Database.SetInitializer(new DropCreateDatabaseAlways<SqlServerFullContext>());
            }

            using (var context = new SqlServerFullContext(DbConfig))
            {
                context.Database.Initialize(true);
            }
        }


        [TestMethod]
        public override void RunAll()
        {
            using (var context = new SqlServerFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new SqlServerFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}