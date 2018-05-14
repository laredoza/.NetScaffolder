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
    public abstract partial class BaseUnitTest
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

        protected virtual void PopulateBook(IBook item)
        {
            throw new NotImplementedException("PopulateBook");
        }

        protected virtual void PopulateOrder(IOrder item)
        {
            throw new NotImplementedException("PopulateOrder");
        }

        protected virtual void PopulateOrderDetails(IOrderDetails item)
        {
            throw new NotImplementedException("PopulateOrderDetails");
        }

        protected virtual void PopulateProduct(IProduct item)
        {
            throw new NotImplementedException("PopulateProduct");
        }

        protected virtual void PopulateSoftware(ISoftware item)
        {
            throw new NotImplementedException("PopulateSoftware");
        }

        protected virtual void PopulateBankAccount(IBankAccount item)
        {
            item.Balance = 200;
            item.BankAccountNumber = "BA-987999";
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

        #endregion
    }
}
