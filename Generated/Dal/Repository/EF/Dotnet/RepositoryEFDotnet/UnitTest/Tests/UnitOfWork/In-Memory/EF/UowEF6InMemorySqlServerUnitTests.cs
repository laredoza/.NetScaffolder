// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEF6InMemorySqlServerUnitTest : BaseUnitOfWorkUnitTests<SqlServerFullContext>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The class init.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
        }

        /// <summary>
        /// The base unit of work unit tests_ create db test.
        /// </summary>
        [TestMethod]
        public virtual void BaseUnitOfWorkUnitTests_CreateDbTest()
        {
            Uow.Database.Initialize(true);
        }

        /// <summary>
        /// The test cleanup.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Uow?.Dispose();
        }

        /// <summary>
        /// The test init.
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            Uow = new SqlServerFullContext(DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}