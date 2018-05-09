using System;
using System.Data.Entity;
using Banking.Models.Accounts;
//using Banking.Models.Context;
//using Banking.Models.Customers;
using DotNetScaffolder.Test.Components.SourceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryEFDotnet.UnitTest
{
    using Banking.Models.Context;
    using Banking.Models.Customers;
    using Banking.Models.Interfaces;
    using Banking.Models.Repository;
    using System.Configuration;
    using System.Data.Common;

    [TestClass]
    public class RepositoryEF6SqlServerUnitTest : BaseRepositoryUnitTest
    {
        #region Privates

        private FullContext Context;

        #endregion

        #region Init

        [TestInitialize]
        public override void SetupDb()
        {
            Connection = Effort.DbConnectionFactory.CreateTransient();
            Context = new FullContext(Connection as DbConnection);
        }

        #endregion

        #region Tests

        [TestMethod]
        public void BankAccountRepository_Add()
        {
            CustomerRepository_Add();

            var repo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_BankAccount_Add(repo);
        }

        [TestMethod]
        public void BankTransfersRepository_Add()
        {
            BankAccountRepository_Add();

            var repo = new BankTransfersRepository(Context);
            BaseRepositoryUnitTest_BankTransfers_Add(repo);
        }

        [TestMethod]
        public void CustomerRepository_Add()
        {
            //CountryRepository_Add();

            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_Add(repo);
        }

        [TestMethod]
        public void CountryRepository_Add()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_Add(repo);
        }

        [TestMethod]
        public void CountryRepository_Add_Rollback()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_Add(repo, true);
        }

        #endregion

        #region Clean up

        [TestCleanup]
        public override void DisposeDb()
        {
            Context?.Dispose();
            base.DisposeDb();
        }

        #endregion
    }
}
