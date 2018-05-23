// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbSqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using System.Data.Entity;

    using Banking.Models.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The uow e f 6 db sql server unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbSqlServerUnitTest : BaseUnitOfWorkUnitTests<SqlServerFullContext>
    {
        #region Public Methods And Operators

        /// <summary>
        /// The recreate db.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        [ClassInitialize]
        public static void RecreateDb(TestContext context)
        {
            if (Database.Exists("RepoTest"))
            {
                Database.Delete("RepoTest");
                Database.SetInitializer(new DropCreateDatabaseAlways<SqlServerFullContext>());
            }

            Uow = new SqlServerFullContext("RepoTest");
            Uow.Database.Initialize(true);
        }

        #endregion
    }
}