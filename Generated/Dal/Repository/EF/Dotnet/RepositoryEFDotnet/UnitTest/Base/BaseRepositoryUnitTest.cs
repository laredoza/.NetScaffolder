using Banking.Models.Dto;
using Banking.Models.Interfaces;
using Banking.Models.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System;
using System.Data;
using System.Linq;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseRepositoryUnitTest : BaseUnitTest
    {
        #region Base Tests

        public void BaseRepositoryUnitTest_Customer_Add(ICustomerRepository repository)
        {
            var dto = new CustomerDto();
            PopulateCustomer(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Customers");
            Check_Customer(result[0]);
        }

        public void BaseRepositoryUnitTest_Country_Add(ICountryRepository repository)
        {
            var dto = new CountryDto();
            PopulateCountry(dto);
            repository.Save(dto);
            Context.Commit();

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "Country");
            Check_Country(result[0]);
        }

        public void BaseRepositoryUnitTest_BankAccountAndBankTransfers_Add(IBankAccountRepository bankAccountRepository, IBankTransfersRepository repository)
        {
            var fromAcc = new BankAccountDto();
            PopulateFromBankAccount(fromAcc);
            bankAccountRepository.Save(fromAcc);

            var toAcc = new BankAccountDto();
            PopulateToBankAccount(toAcc);
            bankAccountRepository.Save(toAcc);

            var dto = new BankTransfersDto();
            PopulateBankTransfers(dto);
            repository.Save(dto);

            Context.Commit();

            // Load from db and check values
            var accounts = bankAccountRepository.LoadAll();
            // Test count
            Check_EntityCount(2, accounts.Count, "BankAccounts");

            Check_FromBankAccount(accounts.FirstOrDefault(o=> o.BankAccountId == 1));
            Check_ToBankAccount(accounts.FirstOrDefault(o => o.BankAccountId == 2));

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            Check_EntityCount(1, result.Count, "BankTransfers");
            Check_BankTransfers(result[0]);
        }

        #endregion

        #region Privates

        protected IUnitOfWork Context = null;

        #endregion

        #region SetupDb

        public abstract void SetupDb();

        #endregion

        #region Tests

        [TestMethod]
        public void BankAccountAndBankTransfers_Add()
        {
            var repo = new BankTransfersRepository(Context);
            var accountRepo = new BankAccountRepository(Context);
            BaseRepositoryUnitTest_BankAccountAndBankTransfers_Add(accountRepo, repo);
        }

        [TestMethod]
        public void Customer_Add()
        {
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_Add(repo);
        }

        [TestMethod]
        public void Country_Add()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_Add(repo);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public virtual void DisposeDb()
        {
            Context?.Dispose();
        }

        #endregion
    }
}
