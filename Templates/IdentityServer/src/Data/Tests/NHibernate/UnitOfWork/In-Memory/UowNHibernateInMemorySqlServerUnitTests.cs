// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Runtime.CompilerServices;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NHibernate;
    using System.Threading.Tasks;
    using Banking.Models.Context.NHib;

    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;

    using NHibernate.Cfg;
    using NHibernate.Mapping;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The uow n hibernate in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateInMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        private static Configuration Configuration = null;
        private static SqlServerFullContext Context = null;

        #endregion

        [ClassInitialize]
        public static void Init(TestContext tstContext)
        {
            Configuration = Fluently.Configure().Database(MsSqliteConfiguration.Standard.ConnectionString("Data Source=:memory:;cache=shared;mode=memory")).Mappings(
                o => o.FluentMappings
                    .AddFromAssemblyOf<Banking.Models.Context.Mappings.NHib.SqlServer.BankAccountMap>()).BuildConfiguration();

            // Keep connection to in-memory db alive for duration of test
            // otherwise the db gets discarded when all connections are closed
            Context = new SqlServerFullContext(Configuration);
            Context.CreateSchema();
        }

        #region Public Methods And Operators

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Add(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Get(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_WithFilter_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_WithFilter_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Modify(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Remove(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Any_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefault_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AddRange(uow, 100);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAll(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching(uow, 50);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_AllMatching_NothingFound(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_GetAllPaged(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_Max(uow, 100);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRange(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
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
            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AnyAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_FirstOrDefaultAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AddRangeAsync(uow, 100);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_GetAllAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_AllMatchingAsync(uow, 50);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_MaxAsync(uow, 100);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RemoveRangeAsync(uow);
            }

            using (var uow = new SqlServerFullContext(Configuration))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RollbackAsync(uow);
            }
        }

        #endregion

        [ClassCleanup]
        public static void Cleanup()
        {
            Context?.Dispose();
            Context = null;
            Configuration = null;
        }
    }
}