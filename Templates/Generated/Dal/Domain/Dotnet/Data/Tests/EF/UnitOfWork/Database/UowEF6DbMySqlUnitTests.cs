// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbMySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EF;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MySql.Data.EntityFramework;
    using RepositoryEFDotnet.UnitTest.Base;
    using System.Data.Entity;
    using System.Threading.Tasks;

    /// <summary>
    /// The uow e f 6 i db my sql unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbMySqlUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTestMySql";

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            if (Database.Exists(DbConfig))
            {
                Database.Delete(DbConfig);
                Database.SetInitializer(new DropCreateDatabaseAlways<MySqlFullContext>());
            }
        }


        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Add(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Get(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Modify(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Remove(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AddRange(uow, 100, 2);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged(uow, 2);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Max(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRange(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
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
            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AnyAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(uow, 100, 2);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_MaxAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync(uow);
            }

            using (var uow = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(uow);
            }
        }

        #endregion
    }
}