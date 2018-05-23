// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemoryMySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MySql.Data.MySqlClient;

    /// <summary>
    /// The repository e f 6 in memory my sql unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEF6InMemoryMySqlUnitTest : BaseRepositoryUnitTest
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
            Context = new MySqlFullContext(DbConnectionFactory.CreateTransient());
        }

        #endregion
    }
}