// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEFCoreDbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.Core;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow ef core db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEFCoreDbSqlServerUnitTest : BaseUnitOfWorkUnitTests<EFCoreSqlServerFullContext>
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
            Uow = new EFCoreSqlServerFullContext("RepoTest");
            Uow.Database.EnsureDeleted();
            Uow.Database.EnsureCreated();
        }

        #endregion
    }
}