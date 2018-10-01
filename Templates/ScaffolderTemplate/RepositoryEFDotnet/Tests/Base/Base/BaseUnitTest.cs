// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseUnitTest.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.UnitTest.Base
{
    using System;

    using Banking.Models.Interfaces;

    /// <summary>
    /// The base unit test.
    /// </summary>
    public abstract partial class BaseUnitTest
    {
        #region Other Methods

        /// <summary>
        /// The populate bank account.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        protected virtual void PopulateBankAccount(IBankAccount item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                item.Balance = item.Balance - 10;
                item.BankAccountNumber = $"{item.BankAccountNumber}-1";
                item.Locked = true;
            }
            else
            {
                item.Balance = 100 + seed;
                item.BankAccountNumber = $"BA1234-{seed}";
                item.Locked = false;
            }
        }

        /// <summary>
        /// The populate bank transfers.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        protected virtual void PopulateBankTransfers(IBankTransfers item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                item.Amount = item.Amount - 10;
                item.TransferDate = new DateTime(
                    DateTime.Now.Year - seed,
                    DateTime.Now.Month - seed,
                    DateTime.Now.Day - seed,
                    14,
                    10,
                    12);
            }
            else
            {
                item.Amount = 50 + seed;
                item.FromBankAccountId = seed;
                item.ToBankAccountId = seed + 1;
                item.TransferDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 10, 12);
            }
        }

        /// <summary>
        /// The populate book.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected virtual void PopulateBook(IBook item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                item.Publisher = $"Publisher {seed} updated";
            }
            else
            {
                item.ProductId = seed;
                item.Publisher = $"Publisher {seed}";
            }
        }

        /// <summary>
        /// The populate composite key test.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        //protected virtual void PopulateCompositeKeyTest(ICompositeKeyTest item, bool isUpdate = false, int seed = 1)
        //{
        //    item.PrimaryCol1 = seed;
        //    item.PrimaryCol2 = seed + 1;

        //    if (isUpdate)
        //    {
        //        item.PrimaryCol1 = seed + 2;
        //        item.PrimaryCol2 = seed + 3;
        //    }
        //}

        /// <summary>
        /// The populate country.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        protected virtual void PopulateCountry(ICountry item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                var updateString = " updated";
                item.CountryName = $"{item.CountryName} {updateString}";
            }
            else
            {
                item.CountryName = $"Country {seed}";
            }
        }

        /// <summary>
        /// The populate customer.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        protected virtual void PopulateCustomer(ICustomer item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                var updateString = " new";

                item.Address = $"{item.Address} {updateString}";
                item.City = $"{item.City} {updateString}";
                item.CompanyName = $"{item.CompanyName} {updateString}";
                item.ContactName = $"{item.ContactName} {updateString}";
                item.ContactTitle = $"{item.ContactTitle} {updateString}";
                item.CustomerCode = $"{updateString}{item.CustomerId}";
                item.Fax = $"{item.Fax} {updateString}";
                item.IsEnabled = false;
                item.Photo = $"{item.Photo} {updateString}";
                item.PostalCode = $"{updateString}-{seed}";
                item.Telephone = $"{item.Telephone} {updateString}";
            }
            else
            {
                item.Address = $"Customer Address {seed}";
                item.City = $"Test City {seed}";
                item.CompanyName = $"Test Company {seed}";
                item.ContactName = $"Test Contact {seed}";
                item.ContactTitle = $"Test Title {seed}";
                item.CustomerCode = $"12-{seed}";
                item.Fax = $"Fax 123 {seed}";
                item.IsEnabled = true;
                item.Photo = $"Photo goes here {seed}";
                item.PostalCode = $"12345-{seed}";
                item.Telephone = $"Test Phone number {seed}";
            }
        }

        /// <summary>
        /// The populate order.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected virtual void PopulateOrder(IOrder item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                var updateString = " updated";

                item.DeliveryDate = new DateTime(
                    item.DeliveryDate.GetValueOrDefault().Year,
                    item.DeliveryDate.GetValueOrDefault().Month,
                    item.DeliveryDate.GetValueOrDefault().Day - seed,
                    8,
                    50,
                    20);
                item.OrderDate = new DateTime(
                    item.OrderDate.GetValueOrDefault().Year,
                    item.OrderDate.GetValueOrDefault().Month,
                    item.OrderDate.GetValueOrDefault().Day - seed,
                    10,
                    30,
                    10);
                item.ShippingAddress = $"{item.ShippingAddress} {updateString}";
                item.ShippingCity = $"{item.ShippingCity} {updateString}";
                item.ShippingName = $"{item.ShippingName} {updateString}";
                item.ShippingZip = $"11-{seed}";
            }
            else
            {
                item.CustomerId = 2;
                item.DeliveryDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 50, 20);
                item.OrderDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day - seed, 10, 30, 10);
                item.ShippingAddress = $"Shipping Address {seed}";
                item.ShippingCity = $"Shipping city {seed}";
                item.ShippingName = $"Shipping name {seed}";
                item.ShippingZip = $"12-{seed}";
            }
        }

        /// <summary>
        /// The populate order details.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected virtual void PopulateOrderDetails(IOrderDetails item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                item.UnitPrice = seed * seed;
                item.Amount = Convert.ToInt16(seed * seed);
                item.Discount = seed * seed;
            }
            else
            {
                item.UnitPrice = seed;
                item.Amount = Convert.ToInt16(seed);
                item.Discount = seed;
                item.OrderId = seed;
                item.ProductId = seed + 1;
            }
        }

        /// <summary>
        /// The populate product.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        protected virtual void PopulateProduct(IProduct item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                var updateString = " updated";
                item.AmountInStock = Convert.ToInt16(item.AmountInStock * seed);
                item.ProductDescription = $"Product description {seed} {updateString}";
                item.Publisher = $"Publisher {seed} {updateString}";
                item.UnitAmount = $"Unit amount {seed} {updateString}";
                item.UnitPrice = item.UnitPrice * item.UnitPrice;
            }
            else
            {
                item.AmountInStock = 1;
                item.ProductDescription = $"Product description {seed}";
                item.Publisher = $"Publisher {seed}";
                item.UnitAmount = $"Unit amount {seed}";
                item.UnitPrice = seed;
            }
        }

        /// <summary>
        /// The populate software.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="isUpdate">
        /// The is update.
        /// </param>
        /// <param name="seed">
        /// The seed.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        protected virtual void PopulateSoftware(ISoftware item, bool isUpdate = false, int seed = 1)
        {
            if (isUpdate)
            {
                item.LicenseCode = $"{item.LicenseCode} updated";
            }
            else
            {
                item.ProductId = seed;
                item.LicenseCode = $"License code {seed}";
            }
        }


        protected virtual void PopulateSelfRefTAble(ISelfRefTAble item, bool isUpdate = false, int seed = 1)
        {
            throw new NotImplementedException("when implementing move the method to your own partial class.");
        }


        #endregion
    }
}