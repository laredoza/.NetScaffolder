﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryEF6InMemoryOracleUnitTests.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context.EF;

    using Effort;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RepositoryEFDotnet.UnitTest.Base;

    /// <summary>
    /// The repository e f 6 in memory oracle unit test.
    /// </summary>
    [TestClass]
    public class RepositoryEF6InMemoryOracleUnitTest : BaseRepositoryUnitTest
    {
        #region Public Methods And Operators

        [TestMethod]
        public void RunAll()
        {
            string dbId = "EFRepoTestOracle";

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Country_Add(uow);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Customer_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Product_Add(uow, 5, 1, 5);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Book_Add(uow);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Software_Add(uow, 1, 2);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.Order_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.OrderDetails_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankAccount_Add(uow, 2, 1, 2);
            }

            using (var uow = new OracleFullContext(DbConnectionFactory.CreatePersistent(dbId)))
            {
                this.BankTransfers_Add(uow);
            }
        }

        #endregion
    }
}