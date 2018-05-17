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

        protected virtual void PopulateCustomer(ICustomer item, bool isUpdate = false, int seed = 1)
        {
            item.Address = $"Customer Address {seed}";
            item.City = $"Test City {seed}";
            item.CompanyName = $"Test Company {seed}";
            item.ContactName = $"Test Contact {seed}";
            item.ContactTitle = $"Test Title {seed}";
            item.CustomerCode = $"12345 {seed}";
            item.Fax = $"Fax 123 {seed}";
            item.IsEnabled = true;
            item.Photo = $"Photo goes here {seed}";
            item.PostalCode = $"1234567890 {seed}";
            item.Telephone = $"Test Phone number {seed}";

            if(isUpdate)
            {
                string updateString = " updated";

                item.Address = $"{item.Address} {updateString}";
                item.City = $"{item.Address} {updateString}";
                item.CompanyName = $"{item.Address} {updateString}";
                item.ContactName = $"{item.Address} {updateString}";
                item.ContactTitle = $"{item.Address} {updateString}";
                item.CustomerCode = $"{item.Address} {updateString}";
                item.Fax = $"{item.Address} {updateString}";
                item.IsEnabled = false;
                item.Photo = $"{item.Address} {updateString}";
                item.PostalCode = $"{item.Address} {updateString}";
                item.Telephone = $"{item.Address} {updateString}";
            }
        }

        protected virtual void PopulateCountry(ICountry item, bool isUpdate = false, int seed = 1)
        {
            item.CountryName = $"Country {seed}";

            if (isUpdate)
            {
                string updateString = " updated";

                item.CountryName = $"{item.CountryName} {updateString}";
            }
        }

        protected virtual void PopulateCompositeKeyTest(ICompositeKeyTest item, bool isUpdate = false)
        {
            item.PrimaryCol1 = 1;
            item.PrimaryCol2 = 2;

            if (isUpdate)
            {
                item.PrimaryCol1 = 3;
                item.PrimaryCol2 = 4;
            }
        }

        protected virtual void PopulateBook(IBook item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("PopulateBook");
        }

        protected virtual void PopulateOrder(IOrder item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("PopulateOrder");
        }

        protected virtual void PopulateOrderDetails(IOrderDetails item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("PopulateOrderDetails");
        }

        protected virtual void PopulateProduct(IProduct item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("PopulateProduct");
        }

        protected virtual void PopulateSoftware(ISoftware item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("PopulateSoftware");
        }

        protected virtual void PopulateBankAccount(IBankAccount item, bool isUpdate = false, int seed = 1)
        {
            item.Balance = 100 + seed;
            item.BankAccountNumber = $"BA1234-{seed}";
            item.Locked = false;

            if (isUpdate)
            {
                item.Balance = item.Balance - 10;
                item.BankAccountNumber = $"{item.BankAccountNumber}-1";
                item.Locked = true;
            }
        }

        protected virtual void PopulateBankTransfers(IBankTransfers item, bool isUpdate = false, int seed = 1)
        {
            item.Amount = 50 + seed;
            item.FromBankAccountId = 1;
            item.ToBankAccountId = 2;
            item.TransferDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 10, 12);

            if (isUpdate)
            {
                item.Amount = item.Amount - 10;
                item.TransferDate = new DateTime(DateTime.Now.Year - seed, DateTime.Now.Month - seed, DateTime.Now.Day - seed, 14, 10, 12);
            }
        }

        #endregion
    }
}
