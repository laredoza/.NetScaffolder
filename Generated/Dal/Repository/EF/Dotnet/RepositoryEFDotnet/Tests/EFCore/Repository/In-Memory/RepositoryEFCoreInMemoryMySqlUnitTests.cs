﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEFCoreInMemorySqlServerUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EFCore;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory sql server unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEFCoreInMemoryMySqlUnitTest : BaseRepositoryUnitTest
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
            var options = new DbContextOptionsBuilder<MySqlFullContext>().UseInMemoryDatabase("EFCORE_MySql").Options;
            Context = new MySqlFullContext(options);

            ((MySqlFullContext)Context).Database.EnsureCreated();
        }

        [TestInitialize]
        public void DisableTransactions()
        {
            this.UseTransactions = false;
        }
        #endregion
    }
}