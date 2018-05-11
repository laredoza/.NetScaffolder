using Banking.Models.Dto;
using Banking.Models.Interfaces;
using Banking.Models.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryEFDotnet.Library;
using System;
using System.Data;

namespace RepositoryEFDotnet.UnitTest
{
    [TestClass]
    public abstract class BaseRepositoryUnitTest
    {
        #region Members

        protected IDbConnection Connection { get; set; }

        #endregion

        #region Base Tests

        public void BaseRepositoryUnitTest_Customer_Add(ICustomerRepository repository)
        {           
            var dto = CreateCustomerDto();
            repository.Save(dto);

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            CheckEntityCount(1, result.Count, "Customers");

            var savedEntity = result[0];

            Test_Customer(savedEntity);
        }

        public void BaseRepositoryUnitTest_Country_Add(ICountryRepository repository)
        {
            var dto = CreateCountryDto();
            repository.Save(dto);

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            CheckEntityCount(1, result.Count, "Country");

            var savedEntity = result[0];

            Test_Country(savedEntity);
        }

        public void BaseRepositoryUnitTest_BankAccount_Add(IBankAccountRepository repository)
        {
            var dto = CreateBankAccountDto();
            repository.Save(dto);

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            CheckEntityCount(1, result.Count, "BankAccounts");

            var savedEntity = result[0];

            Test_BankAccount(savedEntity);
        }

        public void BaseRepositoryUnitTest_BankTransfers_Add(IBankTransfersRepository repository)
        {
            var dto = CreateBankTransfersDto();
            repository.Save(dto);

            // Load from db and check values
            var result = repository.LoadAll();

            // Test count
            CheckEntityCount(1, result.Count, "BankTransfers");

            var savedEntity = result[0];

            Test_BankTransfers(savedEntity);
        }

        #endregion

        #region Test Functions

        public void CheckEntityCount(int expected, int actual, string name)
        {
            Assert.AreEqual(expected, actual, $"Incorrect number of {name} found.");
        }

        private void Test_Customer(ICustomer savedEntity)
        {
            var dto = CreateCustomerDto();

            // Test Fields
            Assert.AreEqual(dto.Address, savedEntity.Address, $"Customer.Address incorrect.");
            Assert.AreEqual(dto.City, savedEntity.City, $"Customer.City incorrect. ");
            Assert.AreEqual(dto.CompanyName, savedEntity.CompanyName, $"Customer.CompanyName incorrect.");
            Assert.AreEqual(dto.ContactName, savedEntity.ContactName, $"Customer.ContactName incorrect.");
            Assert.AreEqual(dto.ContactTitle, savedEntity.ContactTitle, $"Customer.ContactTitle incorrect.");
            Assert.AreEqual(dto.CountryId, savedEntity.CountryId, $"Customer.CountryId incorrect.");
            Assert.AreEqual(dto.CustomerCode, savedEntity.CustomerCode, $"Customer.CustomerCode incorrect.");
            Assert.AreEqual(dto.IsEnabled, savedEntity.IsEnabled, $"Customer.IsEnabled incorrect.");
            Assert.AreEqual(dto.Photo, savedEntity.Photo, $"Customer.Photo incorrect.");
            Assert.AreEqual(dto.PostalCode, savedEntity.PostalCode, $"Customer.PostalCode incorrect.");
            Assert.AreEqual(dto.Telephone, savedEntity.Telephone, $"Customer.Telephone incorrect.");
            Assert.AreEqual(dto.Fax, savedEntity.Fax, $"Customer.Fax incorrect.");
        }

        private void Test_Country(ICountry savedEntity)
        {
            var dto = CreateCountryDto();

            // Test Fields
            Assert.AreEqual(dto.CountryName, savedEntity.CountryName, $"Country.CountryName incorrect.");
        }

        private void Test_BankAccount(IBankAccount savedEntity)
        {
            var dto = CreateBankAccountDto();

            // Test Fields
            Assert.AreEqual(1, savedEntity.BankAccountId, $"BankAccount.BankAccountId incorrect.");
            Assert.AreEqual(dto.Balance, savedEntity.Balance, $"BankAccount.Balance incorrect.");
            Assert.AreEqual(dto.BankAccountNumber, savedEntity.BankAccountNumber, $"BankAccount.BankAccountNumber incorrect.");
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"BankAccount.CustomerId incorrect.");
        }

        private void Test_BankTransfers(IBankTransfers savedEntity)
        {
            var dto = CreateBankTransfersDto();

            // Test Fields
            Assert.AreEqual(1, savedEntity.BankTransferId, $"BankAccount.BankTransferId incorrect.");
            Assert.AreEqual(dto.Amount, savedEntity.Amount, $"BankAccount.Amount incorrect.");
            Assert.AreEqual(dto.FromBankAccountId, savedEntity.FromBankAccountId, $"BankAccount.FromBankAccountId incorrect.");
            Assert.AreEqual(dto.ToBankAccountId, savedEntity.ToBankAccountId, $"BankAccount.ToBankAccountId incorrect.");
            Assert.AreEqual(dto.TransferDate, savedEntity.TransferDate, $"BankAccount.TransferDate incorrect.");
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
        public void BankAccountRepository_Add()
        {
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
            var repo = new CustomerRepository(Context);
            BaseRepositoryUnitTest_Customer_Add(repo);
        }

        [TestMethod]
        public void CountryRepository_Add()
        {
            var repo = new CountryRepository(Context);
            BaseRepositoryUnitTest_Country_Add(repo);
        }

        #endregion

        #region Helpers

        private CustomerDto CreateCustomerDto()
        {
            return new CustomerDto
            {
                Address = "Customer Address 1",
                City = "Test City",
                CompanyName = "Test Company",
                ContactName = "Test Contact",
                ContactTitle = "Test Title",
                CustomerCode = "12345",
                Fax = "Fax 123",
                IsEnabled = true,
                Photo = "Photo goes here",
                PostalCode = "1234567890",
                Telephone = "Test Phone number",
            };
        }

        private CountryDto CreateCountryDto()
        {
            return new CountryDto
            {
                CountryName = "South Africa"
            };
        }

        private BankAccountDto CreateBankAccountDto()
        {
            return new BankAccountDto
            {
                Balance = 100,
                BankAccountNumber = "BA-1230981",
//                CustomerId = 1,
                Locked = false
            };
        }

        private BankTransfersDto CreateBankTransfersDto()
        {
            return new BankTransfersDto
            {
                Amount = 50,
                FromBankAccountId = 1,
                ToBankAccountId = 1,
                TransferDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 10, 12)
            };
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public virtual void DisposeDb()
        {
            if(Connection != null)
            {
                if(Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
                Connection.Dispose();
            }

            Context?.Dispose();
        }

        #endregion
    }
}
