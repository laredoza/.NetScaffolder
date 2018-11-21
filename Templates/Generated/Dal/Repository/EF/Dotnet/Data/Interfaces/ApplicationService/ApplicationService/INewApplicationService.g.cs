
// <copyright file=".g.cs" company="MIT">
//  Copyright (c) 2018 MIT
// </copyright>  

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
// IN THE SOFTWARE.


// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Banking.Models.Interfaces;

namespace Banking.Models.ApplicationService
{
    /// <summary>
	/// The NewApplication Service interface that defines database functions for the New application service
	/// </summary>
	public partial interface INewApplicationService 
	{

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IBankAccount</returns>
		IBankAccount LoadByBankAccountBankAccountId(int bankAccountId, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IBankAccount</returns>
		Task<IBankAccount> LoadByBankAccountBankAccountIdAsync(int bankAccountId, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> BankAccountLoadAll(params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		Task<IList<IBankAccount>> BankAccountLoadAllAsync(params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		IBankTransfers LoadByBankTransfersBankTransferId(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers Async entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		Task<IBankTransfers> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes);


        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> BankTransfersLoadAll(params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load all BankTransfers Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> BankTransfersLoadAllAsync(params Expression<Func<IBankTransfers, object>>[] includes);


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		IBook LoadByBookProductId(int productId, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Load Book Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		Task<IBook> LoadByBookProductIdAsync(int productId, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> BookLoadAll(params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Load all Book Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> BookLoadAllAsync(params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>ICountry</returns>
		ICountry LoadByCountryCountryId(int countryId, params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Load Country Async entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>ICountry</returns>
		Task<ICountry> LoadByCountryCountryIdAsync(int countryId, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		IList<ICountry> CountryLoadAll(params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Load all Country Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		Task<IList<ICountry>> CountryLoadAllAsync(params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		ICustomer LoadByCustomerCustomerId(int customerId, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		Task<ICustomer> LoadByCustomerCustomerIdAsync(int customerId, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerLoadAll(params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerLoadAllAsync(params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IOrder</returns>
		IOrder LoadByOrderOrderId(int orderId, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load Order Async entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IOrder</returns>
		Task<IOrder> LoadByOrderOrderIdAsync(int orderId, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> OrderLoadAll(params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load all Order Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		Task<IList<IOrder>> OrderLoadAllAsync(params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		IOrderDetails LoadByOrderDetailsOrderDetailsId(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails Async entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		Task<IOrderDetails> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes);


        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> OrderDetailsLoadAll(params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load all OrderDetails Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> OrderDetailsLoadAllAsync(params Expression<Func<IOrderDetails, object>>[] includes);


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		IProduct LoadByProductProductId(int productId, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		Task<IProduct> LoadByProductProductIdAsync(int productId, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductLoadAll(params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductLoadAllAsync(params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>ISoftware</returns>
		ISoftware LoadBySoftwareProductId(int productId, params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Load Software Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>ISoftware</returns>
		Task<ISoftware> LoadBySoftwareProductIdAsync(int productId, params Expression<Func<ISoftware, object>>[] includes);


        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> SoftwareLoadAll(params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Load all Software Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		Task<IList<ISoftware>> SoftwareLoadAllAsync(params Expression<Func<ISoftware, object>>[] includes);


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		IList<IBankAccount> BankAccountSearchByBankAccountNumber(string bankAccountNumber,bool caseSensitive, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Search for BankAccount  Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		Task<IList<IBankAccount>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber,bool caseSensitive, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> BookSearchByPublisher(string publisher,bool caseSensitive, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Search for Book  Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> BookSearchByPublisherAsync(string publisher,bool caseSensitive, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		IList<ICountry> CountrySearchByCountryName(string countryName,bool caseSensitive, params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Search for Country  Async entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		Task<IList<ICountry>> CountrySearchByCountryNameAsync(string countryName,bool caseSensitive, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCustomerCode(string customerCode,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCustomerCodeAsync(string customerCode,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCompanyName(string companyName,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCompanyNameAsync(string companyName,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByContactName(string contactName,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByContactNameAsync(string contactName,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByContactTitle(string contactTitle,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByContactTitleAsync(string contactTitle,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByAddress(string address,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByAddressAsync(string address,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCity(string city,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCityAsync(string city,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByPostalCode(string postalCode,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByPostalCodeAsync(string postalCode,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByTelephone(string telephone,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByTelephoneAsync(string telephone,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByFax(string fax,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByFaxAsync(string fax,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByPhoto(string photo,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByPhotoAsync(string photo,bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> OrderSearchByShippingName(string shippingName,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		Task<IList<IOrder>> OrderSearchByShippingNameAsync(string shippingName,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> OrderSearchByShippingAddress(string shippingAddress,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		Task<IList<IOrder>> OrderSearchByShippingAddressAsync(string shippingAddress,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> OrderSearchByShippingCity(string shippingCity,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		Task<IList<IOrder>> OrderSearchByShippingCityAsync(string shippingCity,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> OrderSearchByShippingZip(string shippingZip,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		Task<IList<IOrder>> OrderSearchByShippingZipAsync(string shippingZip,bool caseSensitive, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByProductDescription(string productDescription,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByProductDescriptionAsync(string productDescription,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByUnitAmount(string unitAmount,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByUnitAmountAsync(string unitAmount,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByPublisher(string publisher,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByPublisherAsync(string publisher,bool caseSensitive, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> SoftwareSearchByLicenseCode(string licenseCode,bool caseSensitive, params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Search for Software  Async entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		Task<IList<ISoftware>> SoftwareSearchByLicenseCodeAsync(string licenseCode,bool caseSensitive, params Expression<Func<ISoftware, object>>[] includes);

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool BankAccountAdd(IBankAccount entity);

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool BankAccountUpdate(IBankAccount entity);
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool BankAccountDelete(IBankAccount entity);

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		bool BankAccountDelete( int bankAccountId);
		
        /// <summary>
        /// Save the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool BankTransfersAdd(IBankTransfers entity);

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool BankTransfersUpdate(IBankTransfers entity);
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool BankTransfersDelete(IBankTransfers entity);

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		bool BankTransfersDelete( int bankTransferId);
		
        /// <summary>
        /// Save the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool BookAdd(IBook entity);

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool BookUpdate(IBook entity);
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool BookDelete(IBook entity);

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool BookDelete( int productId);
		
        /// <summary>
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool CountryAdd(ICountry entity);

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool CountryUpdate(ICountry entity);
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool CountryDelete(ICountry entity);

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		bool CountryDelete( int countryId);
		
        /// <summary>
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool CustomerAdd(ICustomer entity);

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool CustomerUpdate(ICustomer entity);
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool CustomerDelete(ICustomer entity);

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		bool CustomerDelete( int customerId);
		
        /// <summary>
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool OrderAdd(IOrder entity);

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool OrderUpdate(IOrder entity);
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool OrderDelete(IOrder entity);

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		bool OrderDelete( int orderId);
		
        /// <summary>
        /// Save the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool OrderDetailsAdd(IOrderDetails entity);

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool OrderDetailsUpdate(IOrderDetails entity);
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool OrderDetailsDelete(IOrderDetails entity);

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		bool OrderDetailsDelete( int orderDetailsId);
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductAdd(IProduct entity);

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductUpdate(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductDelete(IProduct entity);

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool ProductDelete( int productId);
		
        /// <summary>
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool SoftwareAdd(ISoftware entity);

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool SoftwareUpdate(ISoftware entity);
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool SoftwareDelete(ISoftware entity);

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool SoftwareDelete( int productId);

		#endregion

        #region Aggregates

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult BankAccountMax<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BankAccountMaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult BankAccountMin<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BankAccountMinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult BankTransfersMax<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BankTransfersMaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult BankTransfersMin<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BankTransfersMinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult BookMax<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BookMaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult BookMin<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> BookMinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult CountryMax<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> CountryMaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult CountryMin<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> CountryMinAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult CustomerMax<TResult>(Expression<Func<ICustomer, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> CustomerMaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult CustomerMin<TResult>(Expression<Func<ICustomer, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult OrderMax<TResult>(Expression<Func<IOrder, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> OrderMaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult OrderMin<TResult>(Expression<Func<IOrder, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> OrderMinAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult OrderDetailsMax<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> OrderDetailsMaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult OrderDetailsMin<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> OrderDetailsMinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult ProductMax<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> ProductMaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult ProductMin<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> ProductMinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
        TResult SoftwareMax<TResult>(Expression<Func<ISoftware, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> SoftwareMaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		TResult SoftwareMin<TResult>(Expression<Func<ISoftware, TResult>> maxExpression);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		Task<TResult> SoftwareMinAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression);

		#endregion

    }
}

