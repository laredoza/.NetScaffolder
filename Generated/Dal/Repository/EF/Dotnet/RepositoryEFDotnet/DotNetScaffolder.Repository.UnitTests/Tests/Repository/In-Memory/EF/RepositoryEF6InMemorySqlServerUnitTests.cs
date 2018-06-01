// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EF;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEF6InMemorySqlServerUnitTest : BaseRepositoryUnitTest
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
            Context = new SqlServerFullContext(DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}