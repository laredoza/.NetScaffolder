// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6InMemoryMySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 in memory my sql unit test.
    /// </summary>
    [TestClass]
    public class UowEF6InMemoryMySqlUnitTest : BaseUnitOfWorkUnitTests<MySqlFullContext>
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
            Uow = new MySqlFullContext(DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}