// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemoryOracleUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository e f 6 in memory oracle unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEF6InMemoryOracleUnitTest : BaseRepositoryUnitTest
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
            Context = new OracleFullContext(DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}