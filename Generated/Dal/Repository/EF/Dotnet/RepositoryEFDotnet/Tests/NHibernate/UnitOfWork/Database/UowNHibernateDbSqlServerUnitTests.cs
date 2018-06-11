// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowNHibernateDbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.NHibernate;
    using FluentNHibernate.Cfg.Db;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowNHibernateDbSqlServerUnitTest : BaseUnitOfWorkUnitTests
    {
        private static MsSqlConfiguration Configuration = null;

        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTest";

        #endregion

        #region Public Methods And Operators
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            DropCreateDatabase();
            Configuration =
                MsSqlConfiguration.MsSql2012.ConnectionString(
                    ConfigurationManager.ConnectionStrings[DbConfig].ConnectionString);
        }

        private static void DropCreateDatabase()
        {
            using (var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Pooling=False"))
            {
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"IF (db_id('RepoTest') IS NOT NULL)
                                        BEGIN
                                            ALTER DATABASE [RepoTest] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                            DROP DATABASE [RepoTest];
                                        END;
                                        
                                        CREATE DATABASE [RepoTest];";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            using (var context = new SqlServerFullContext(Configuration))
            {
                context.DropSchema();
                context.CreateSchema();
            }
        }

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
    }
}