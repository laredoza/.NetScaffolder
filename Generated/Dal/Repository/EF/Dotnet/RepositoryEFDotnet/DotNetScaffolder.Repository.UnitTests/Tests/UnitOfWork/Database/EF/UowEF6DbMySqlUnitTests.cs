// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbMySqlUnitTests.cs" company="DotnetScaffolder">
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
    /// The uow e f 6 i db my sql unit test.
    /// </summary>
    [TestClass]
    public class UowEF6IDbMySqlUnitTest : BaseUnitOfWorkUnitTests
    {
        private const string DbConfig = "RepoTestMySql";

        [TestInitialize]
        public void Init()
        {
            if (Database.Exists(DbConfig))
            {
                Database.Delete(DbConfig);
                Database.SetInitializer(new DropCreateDatabaseAlways<MySqlFullContext>());
            }
        }


        [TestMethod]
        public override void RunAll()
        {
            using (var context = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }
    }
}