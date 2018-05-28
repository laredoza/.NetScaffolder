// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEFCoreSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryDbEFCoreSqlServerUnitTest : BaseRepositoryUnitTest
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
            Context = new SqlServerFullContext("RepoTest");
            ((SqlServerFullContext)Context).Database.EnsureDeleted();
            ((SqlServerFullContext)Context).Database.EnsureCreated();
        }

        #endregion
    }
}