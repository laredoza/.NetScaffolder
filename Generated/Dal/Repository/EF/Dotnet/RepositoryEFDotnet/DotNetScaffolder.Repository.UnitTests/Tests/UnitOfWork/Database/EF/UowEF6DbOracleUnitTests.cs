// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbOracleUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 db oracle unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbOracleUnitTest : BaseUnitOfWorkUnitTests<OracleFullContext>
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
            Uow = new OracleFullContext("RepoTestOracle");
        }

        #endregion
    }
}