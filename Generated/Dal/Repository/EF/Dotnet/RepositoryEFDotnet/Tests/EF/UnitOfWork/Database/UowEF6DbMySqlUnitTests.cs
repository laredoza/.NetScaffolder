﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowEF6DbMySqlUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EF;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MySql.Data.EntityFramework;
    using RepositoryEFDotnet.UnitTest.Base;
    using System.Data.Entity;
    using System.Threading.Tasks;

    /// <summary>
    /// The uow e f 6 i db my sql unit test.
    /// </summary>
    [TestClass]
    public class UowEF6DbMySqlUnitTest : BaseUnitOfWorkUnitTests
    {
        #region Constants

        /// <summary>
        /// The db config.
        /// </summary>
        private const string DbConfig = "RepoTestMySql";

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The init.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
            if (Database.Exists(DbConfig))
            {
                Database.Delete(DbConfig);
                Database.SetInitializer(new DropCreateDatabaseAlways<MySqlFullContext>());
            }
        }

        /// <summary>
        /// The run all.
        /// </summary>
        [TestMethod]
        public override void RunAll()
        {
            using (var context = new MySqlFullContext(DbConfig))
            {
                this.BaseUnitOfWorkUnitTests_BankAccount_RunAll(context);
            }
        }

        /// <summary>
        /// The run all async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public override async Task RunAllAsync()
        {
            using (var context = new MySqlFullContext(DbConfig))
            {
                await this.BaseUnitOfWorkUnitTests_BankAccount_RunAllAsync(context);
            }
        }

        #endregion
    }
}