// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDbEF6SqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /*public class RepositoryDbEF6SqlServerUnitTests : BaseRepositoryUnitTest*/

    /// <summary>
    /// The repository db e f 6 sql server unit tests.
    /// </summary>
    [TestClass]
    public class RepositoryDbEF6SqlServerUnitTests : BaseRepositoryUnitTest
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

            if (Database.Exists("RepoTest"))
            {
                Database.Delete("RepoTest");
            }

            Database.SetInitializer(new CreateDatabaseIfNotExists<SqlServerFullContext>());
            ((SqlServerFullContext)Context).Database.Initialize(true);
        }

        #endregion
    }
}