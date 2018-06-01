// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEF6OracleUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context.EF;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository db e f 6 oracle unit tests.
    /// </summary>
    [TestClass]
    public class RepositoryDbEF6OracleUnitTests : BaseRepositoryUnitTest
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
            Context = new OracleFullContext("RepoTestOracle");

            if (Database.Exists("RepoTestOracle"))
            {
                Database.Delete("RepoTestOracle");
            }

            Database.SetInitializer(new CreateDatabaseIfNotExists<OracleFullContext>());
            ((OracleFullContext)Context).Database.Initialize(true);
        }

        #endregion
    }
}