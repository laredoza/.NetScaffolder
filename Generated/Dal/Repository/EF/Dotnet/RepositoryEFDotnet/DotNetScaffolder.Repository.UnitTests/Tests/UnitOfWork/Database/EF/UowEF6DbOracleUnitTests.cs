// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbOracleUnitTests.cs" company="DotnetScaffolder">
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
    /// The uow e f 6 db oracle unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbOracleUnitTest : BaseUnitOfWorkUnitTests
    {
        private const string DbConfig = "RepoTestOracle";

        [TestInitialize]
        public void Init()
        {
            if (Database.Exists(DbConfig))
            {
                Database.Delete(DbConfig);
                Database.SetInitializer(new DropCreateDatabaseAlways<OracleFullContext>());
            }
        }


        [TestMethod]
        public override void RunAll()
        {
            using (var context = new OracleFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new OracleFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}