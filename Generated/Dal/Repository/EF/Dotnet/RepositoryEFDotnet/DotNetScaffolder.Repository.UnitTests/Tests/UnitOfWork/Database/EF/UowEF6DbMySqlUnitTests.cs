// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbMySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 i db my sql unit test.
    /// </summary>
    [TestClass]
    public class UowEF6IDbMySqlUnitTest : BaseUnitOfWorkUnitTests<MySqlFullContext>
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
            Uow = new MySqlFullContext("RepoTestMySql");
        }

        #endregion
    }
}