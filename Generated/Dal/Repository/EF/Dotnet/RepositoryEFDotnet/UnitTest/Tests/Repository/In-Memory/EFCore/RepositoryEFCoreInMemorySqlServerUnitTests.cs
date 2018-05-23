// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.Core;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEFCoreInMemorySqlServerUnitTest : BaseRepositoryUnitTest
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
            var options = new DbContextOptionsBuilder<EFCoreSqlServerFullContext>().UseInMemoryDatabase("EFCORE_SqlServer").Options;
            Context = new EFCoreSqlServerFullContext(options);

            ((EFCoreSqlServerFullContext)Context).Database.EnsureCreated();
        }
        #endregion
    }
}