// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEF6MySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The repository db e f 6 my sql unit tests.
    /// </summary>
    [TestClass]
    public class RepositoryDbEF6MySqlUnitTests : BaseRepositoryUnitTest
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
            Context = new MySqlFullContext("RepoTestMySql");

            if (Database.Exists("RepoTestMySql"))
            {
                Database.Delete("RepoTestMySql");
            }

            Database.SetInitializer(new CreateDatabaseIfNotExists<MySqlFullContext>());
            ((MySqlFullContext)Context).Database.Initialize(true);
        }

        #endregion
    }
}