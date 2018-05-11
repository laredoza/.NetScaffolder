using Banking.Models.Dto;
using Banking.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.UnitTest
{
    public abstract class BaseUnitTest
    {
        #region Helpers

        protected virtual void PopulateCustomer(ICustomer item)
        {
            item.Address = "Customer Address 1";
            item.City = "Test City";
            item.CompanyName = "Test Company";
            item.ContactName = "Test Contact";
            item.ContactTitle = "Test Title";
            item.CustomerCode = "12345";
            item.Fax = "Fax 123";
            item.IsEnabled = true;
            item.Photo = "Photo goes here";
            item.PostalCode = "1234567890";
            item.Telephone = "Test Phone number";
        }

        protected virtual void PopulateCountry(ICountry item)
        {
            item.CountryName = "South Africa";
        }

        protected virtual void PopulateFromBankAccount(IBankAccount item)
        {
            item.Balance = 100;
            item.BankAccountNumber = "BA-1230981";
            item.Locked = false;
        }

        protected virtual void PopulateToBankAccount(IBankAccount item)
        {
            item.Balance = 200;
            item.BankAccountNumber = "BA-987981";
            item.Locked = false;
        }

        protected virtual void PopulateBankTransfers(IBankTransfers item)
        {
            item.Amount = 50;
            item.FromBankAccountId = 1;
            item.ToBankAccountId = 2;
            item.TransferDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 10, 12);
        }

        protected void Check_EntityCount(int expected, int actual, string name)
        {
            Assert.AreEqual(expected, actual, $"Incorrect number of {name} found.");
        }

        protected void Check_Customer(ICustomer savedEntity)
        { 
            Assert.IsNotNull(savedEntity);

            var dto = new CustomerDto();
            PopulateCustomer(dto);

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

        protected void Check_Country(ICountry savedEntity)
        {
            Assert.IsNotNull(savedEntity);

            var dto = new CountryDto();
            PopulateCountry(dto);

            // Test Fields
            Assert.AreEqual(dto.CountryName, savedEntity.CountryName, $"Country.CountryName incorrect.");
        }

        protected void Check_FromBankAccount(IBankAccount savedEntity)
        {
            Assert.IsNotNull(savedEntity);

            var dto = new BankAccountDto();
            PopulateFromBankAccount(dto);

            // Test Fields
            Assert.AreEqual(1, savedEntity.BankAccountId, $"BankAccount.BankAccountId incorrect.");
            Assert.AreEqual(dto.Balance, savedEntity.Balance, $"BankAccount.Balance incorrect.");
            Assert.AreEqual(dto.BankAccountNumber, savedEntity.BankAccountNumber, $"BankAccount.BankAccountNumber incorrect.");
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"BankAccount.CustomerId incorrect.");
        }

        protected void Check_ToBankAccount(IBankAccount savedEntity)
        {
            Assert.IsNotNull(savedEntity);

            var dto = new BankAccountDto();
            PopulateToBankAccount(dto);

            // Test Fields
            Assert.AreEqual(2, savedEntity.BankAccountId, $"BankAccount.BankAccountId incorrect.");
            Assert.AreEqual(dto.Balance, savedEntity.Balance, $"BankAccount.Balance incorrect.");
            Assert.AreEqual(dto.BankAccountNumber, savedEntity.BankAccountNumber, $"BankAccount.BankAccountNumber incorrect.");
            Assert.AreEqual(dto.CustomerId, savedEntity.CustomerId, $"BankAccount.CustomerId incorrect.");
        }

        protected void Check_BankTransfers(IBankTransfers savedEntity)
        {
            Assert.IsNotNull(savedEntity);

            var dto = new BankTransfersDto();
            PopulateBankTransfers(dto);

            // Test Fields
            Assert.AreEqual(1, savedEntity.BankTransferId, $"BankAccount.BankTransferId incorrect.");
            Assert.AreEqual(dto.Amount, savedEntity.Amount, $"BankAccount.Amount incorrect.");
            Assert.AreEqual(dto.FromBankAccountId, savedEntity.FromBankAccountId, $"BankAccount.FromBankAccountId incorrect.");
            Assert.AreEqual(dto.ToBankAccountId, savedEntity.ToBankAccountId, $"BankAccount.ToBankAccountId incorrect.");
            Assert.AreEqual(dto.TransferDate, savedEntity.TransferDate, $"BankAccount.TransferDate incorrect.");
        }

        #endregion
    }
}
