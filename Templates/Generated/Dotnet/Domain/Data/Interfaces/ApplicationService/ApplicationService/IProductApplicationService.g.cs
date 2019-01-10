
// <copyright file=".g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.ApplicationService
{
    /// <summary>
	/// The ProductApplication Service interface that defines database functions for the Product application service
	/// </summary>
	public partial interface IProductApplicationService 
	{

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>BankAccountDto</returns>
		BankAccountDto LoadByBankAccountBankAccountId(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>BankAccountDto</returns>
		Task<BankAccountDto> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		IList<BankAccountDto> BankAccountLoadAll(bool cache, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		Task<IList<BankAccountDto>> BankAccountLoadAllAsync(bool cache, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>BankTransfersDto</returns>
		BankTransfersDto LoadByBankTransfersBankTransferId(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers Async entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>BankTransfersDto</returns>
		Task<BankTransfersDto> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes);


        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfersDto></returns>
		IList<BankTransfersDto> BankTransfersLoadAll(bool cache, params Expression<Func<IBankTransfers, object>>[] includes);


        /// <summary>
        /// Load all BankTransfers Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfersDto></returns>
		Task<IList<BankTransfersDto>> BankTransfersLoadAllAsync(bool cache, params Expression<Func<IBankTransfers, object>>[] includes);


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>BookDto</returns>
		BookDto LoadByBookProductId(int productId, bool cache, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Load Book Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>BookDto</returns>
		Task<BookDto> LoadByBookProductIdAsync(int productId, bool cache, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		IList<BookDto> BookLoadAll(bool cache, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Load all Book Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		Task<IList<BookDto>> BookLoadAllAsync(bool cache, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>CountryDto</returns>
		CountryDto LoadByCountryCountryId(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Load Country Async entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>CountryDto</returns>
		Task<CountryDto> LoadByCountryCountryIdAsync(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		IList<CountryDto> CountryLoadAll(bool cache, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Load all Country Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		Task<IList<CountryDto>> CountryLoadAllAsync(bool cache, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>CustomerDto</returns>
		CustomerDto LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>CustomerDto</returns>
		Task<CustomerDto> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>OrderDto</returns>
		OrderDto LoadByOrderOrderId(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load Order Async entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>OrderDto</returns>
		Task<OrderDto> LoadByOrderOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		IList<OrderDto> OrderLoadAll(bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Load all Order Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		Task<IList<OrderDto>> OrderLoadAllAsync(bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>OrderDetailsDto</returns>
		OrderDetailsDto LoadByOrderDetailsOrderDetailsId(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails Async entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>OrderDetailsDto</returns>
		Task<OrderDetailsDto> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);


        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetailsDto></returns>
		IList<OrderDetailsDto> OrderDetailsLoadAll(bool cache, params Expression<Func<IOrderDetails, object>>[] includes);


        /// <summary>
        /// Load all OrderDetails Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetailsDto></returns>
		Task<IList<OrderDetailsDto>> OrderDetailsLoadAllAsync(bool cache, params Expression<Func<IOrderDetails, object>>[] includes);


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>ProductDto</returns>
		ProductDto LoadByProductProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>ProductDto</returns>
		Task<ProductDto> LoadByProductProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		IList<ProductDto> ProductLoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		Task<IList<ProductDto>> ProductLoadAllAsync(bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>SoftwareDto</returns>
		SoftwareDto LoadBySoftwareProductId(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Load Software Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>SoftwareDto</returns>
		Task<SoftwareDto> LoadBySoftwareProductIdAsync(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes);


        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		IList<SoftwareDto> SoftwareLoadAll(bool cache, params Expression<Func<ISoftware, object>>[] includes);


        /// <summary>
        /// Load all Software Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		Task<IList<SoftwareDto>> SoftwareLoadAllAsync(bool cache, params Expression<Func<ISoftware, object>>[] includes);


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		IList<BankAccountDto> BankAccountSearchByBankAccountNumber(string bankAccountNumber,bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Search for BankAccount  Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		Task<IList<BankAccountDto>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber,bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes);


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		IList<BookDto> BookSearchByPublisher(string publisher,bool caseSensitive, bool cache, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Search for Book  Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		Task<IList<BookDto>> BookSearchByPublisherAsync(string publisher,bool caseSensitive, bool cache, params Expression<Func<IBook, object>>[] includes);


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		IList<CountryDto> CountrySearchByCountryName(string countryName,bool caseSensitive, bool cache, params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Search for Country  Async entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		Task<IList<CountryDto>> CountrySearchByCountryNameAsync(string countryName,bool caseSensitive, bool cache, params Expression<Func<ICountry, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByCustomerCode(string customerCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByCustomerCodeAsync(string customerCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByCompanyName(string companyName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByCompanyNameAsync(string companyName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByContactName(string contactName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByContactNameAsync(string contactName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByContactTitle(string contactTitle,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByContactTitleAsync(string contactTitle,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByAddress(string address,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByAddressAsync(string address,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByCity(string city,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByCityAsync(string city,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByPostalCode(string postalCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByPostalCodeAsync(string postalCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByTelephone(string telephone,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByTelephoneAsync(string telephone,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByFax(string fax,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByFaxAsync(string fax,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		IList<CustomerDto> CustomerSearchByPhoto(string photo,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		Task<IList<CustomerDto>> CustomerSearchByPhotoAsync(string photo,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		IList<OrderDto> OrderSearchByShippingName(string shippingName,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		Task<IList<OrderDto>> OrderSearchByShippingNameAsync(string shippingName,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		IList<OrderDto> OrderSearchByShippingAddress(string shippingAddress,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		Task<IList<OrderDto>> OrderSearchByShippingAddressAsync(string shippingAddress,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		IList<OrderDto> OrderSearchByShippingCity(string shippingCity,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		Task<IList<OrderDto>> OrderSearchByShippingCityAsync(string shippingCity,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		IList<OrderDto> OrderSearchByShippingZip(string shippingZip,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order  Async entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		Task<IList<OrderDto>> OrderSearchByShippingZipAsync(string shippingZip,bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		IList<ProductDto> ProductSearchByProductDescription(string productDescription,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		Task<IList<ProductDto>> ProductSearchByProductDescriptionAsync(string productDescription,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		IList<SoftwareDto> SoftwareSearchByLicenseCode(string licenseCode,bool caseSensitive, bool cache, params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Search for Software  Async entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		Task<IList<SoftwareDto>> SoftwareSearchByLicenseCodeAsync(string licenseCode,bool caseSensitive, bool cache, params Expression<Func<ISoftware, object>>[] includes);

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		bool BankAccountAdd(BankAccountDto entity);

        /// <summary>
        /// Save async the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		Task<bool> BankAccountAddAsync(BankAccountDto entity);

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		bool BankAccountUpdate(BankAccountDto entity);

        //// <summary>
        /// Update async the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		Task<bool> BankAccountUpdateAsync(BankAccountDto entity);
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		bool BankAccountDelete(BankAccountDto entity);

        /// <summary>
        /// Delete async the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">BankAccountDto</param>
        /// <returns>bool</returns>
		Task<bool> BankAccountDeleteAsync(BankAccountDto entity);

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		bool BankAccountDelete( int bankAccountId, bool cache);
		
        /// <summary>
        /// Save the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		bool BankTransfersAdd(BankTransfersDto entity);

        /// <summary>
        /// Save async the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		Task<bool> BankTransfersAddAsync(BankTransfersDto entity);

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		bool BankTransfersUpdate(BankTransfersDto entity);

        //// <summary>
        /// Update async the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		Task<bool> BankTransfersUpdateAsync(BankTransfersDto entity);
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		bool BankTransfersDelete(BankTransfersDto entity);

        /// <summary>
        /// Delete async the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">BankTransfersDto</param>
        /// <returns>bool</returns>
		Task<bool> BankTransfersDeleteAsync(BankTransfersDto entity);

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		bool BankTransfersDelete( int bankTransferId, bool cache);
		
        /// <summary>
        /// Save the Book entity to the database.
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		bool BookAdd(BookDto entity);

        /// <summary>
        /// Save async the Book entity to the database.
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		Task<bool> BookAddAsync(BookDto entity);

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		bool BookUpdate(BookDto entity);

        //// <summary>
        /// Update async the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		Task<bool> BookUpdateAsync(BookDto entity);
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		bool BookDelete(BookDto entity);

        /// <summary>
        /// Delete async the Book entity from the database
        /// </summary>
        /// <param name="entity">BookDto</param>
        /// <returns>bool</returns>
		Task<bool> BookDeleteAsync(BookDto entity);

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool BookDelete( int productId, bool cache);
		
        /// <summary>
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		bool CountryAdd(CountryDto entity);

        /// <summary>
        /// Save async the Country entity to the database.
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		Task<bool> CountryAddAsync(CountryDto entity);

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		bool CountryUpdate(CountryDto entity);

        //// <summary>
        /// Update async the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		Task<bool> CountryUpdateAsync(CountryDto entity);
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		bool CountryDelete(CountryDto entity);

        /// <summary>
        /// Delete async the Country entity from the database
        /// </summary>
        /// <param name="entity">CountryDto</param>
        /// <returns>bool</returns>
		Task<bool> CountryDeleteAsync(CountryDto entity);

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		bool CountryDelete( int countryId, bool cache);
		
        /// <summary>
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		bool CustomerAdd(CustomerDto entity);

        /// <summary>
        /// Save async the Customer entity to the database.
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		Task<bool> CustomerAddAsync(CustomerDto entity);

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		bool CustomerUpdate(CustomerDto entity);

        //// <summary>
        /// Update async the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		Task<bool> CustomerUpdateAsync(CustomerDto entity);
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		bool CustomerDelete(CustomerDto entity);

        /// <summary>
        /// Delete async the Customer entity from the database
        /// </summary>
        /// <param name="entity">CustomerDto</param>
        /// <returns>bool</returns>
		Task<bool> CustomerDeleteAsync(CustomerDto entity);

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		bool CustomerDelete( int customerId, bool cache);
		
        /// <summary>
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		bool OrderAdd(OrderDto entity);

        /// <summary>
        /// Save async the Order entity to the database.
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderAddAsync(OrderDto entity);

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		bool OrderUpdate(OrderDto entity);

        //// <summary>
        /// Update async the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderUpdateAsync(OrderDto entity);
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		bool OrderDelete(OrderDto entity);

        /// <summary>
        /// Delete async the Order entity from the database
        /// </summary>
        /// <param name="entity">OrderDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderDeleteAsync(OrderDto entity);

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		bool OrderDelete( int orderId, bool cache);
		
        /// <summary>
        /// Save the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		bool OrderDetailsAdd(OrderDetailsDto entity);

        /// <summary>
        /// Save async the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderDetailsAddAsync(OrderDetailsDto entity);

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		bool OrderDetailsUpdate(OrderDetailsDto entity);

        //// <summary>
        /// Update async the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderDetailsUpdateAsync(OrderDetailsDto entity);
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		bool OrderDetailsDelete(OrderDetailsDto entity);

        /// <summary>
        /// Delete async the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">OrderDetailsDto</param>
        /// <returns>bool</returns>
		Task<bool> OrderDetailsDeleteAsync(OrderDetailsDto entity);

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		bool OrderDetailsDelete( int orderDetailsId, bool cache);
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		bool ProductAdd(ProductDto entity);

        /// <summary>
        /// Save async the Product entity to the database.
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		Task<bool> ProductAddAsync(ProductDto entity);

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		bool ProductUpdate(ProductDto entity);

        //// <summary>
        /// Update async the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		Task<bool> ProductUpdateAsync(ProductDto entity);
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		bool ProductDelete(ProductDto entity);

        /// <summary>
        /// Delete async the Product entity from the database
        /// </summary>
        /// <param name="entity">ProductDto</param>
        /// <returns>bool</returns>
		Task<bool> ProductDeleteAsync(ProductDto entity);

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool ProductDelete( int productId, bool cache);
		
        /// <summary>
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		bool SoftwareAdd(SoftwareDto entity);

        /// <summary>
        /// Save async the Software entity to the database.
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		Task<bool> SoftwareAddAsync(SoftwareDto entity);

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		bool SoftwareUpdate(SoftwareDto entity);

        //// <summary>
        /// Update async the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		Task<bool> SoftwareUpdateAsync(SoftwareDto entity);
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		bool SoftwareDelete(SoftwareDto entity);

        /// <summary>
        /// Delete async the Software entity from the database
        /// </summary>
        /// <param name="entity">SoftwareDto</param>
        /// <returns>bool</returns>
		Task<bool> SoftwareDeleteAsync(SoftwareDto entity);

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool SoftwareDelete( int productId, bool cache);

		#endregion

        #region Aggregates

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult BankAccountMax<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BankAccountMaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult BankAccountMin<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BankAccountMinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult BankTransfersMax<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BankTransfersMaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult BankTransfersMin<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BankTransfersMinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult BookMax<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BookMaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult BookMin<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> BookMinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult CountryMax<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> CountryMaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult CountryMin<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> CountryMinAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult CustomerMax<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> CustomerMaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult CustomerMin<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult OrderMax<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> OrderMaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult OrderMin<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> OrderMinAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult OrderDetailsMax<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> OrderDetailsMaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult OrderDetailsMin<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> OrderDetailsMinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ProductMax<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ProductMaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ProductMin<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ProductMinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult SoftwareMax<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> SoftwareMaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult SoftwareMin<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> SoftwareMinAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);

		#endregion

        #region Bulk
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  BankAccountBulkDelete(IEnumerable<BankAccountDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankAccountBulkDeleteAsync(IEnumerable<BankAccountDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  BankAccountBulkInsert(IEnumerable<BankAccountDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankAccountBulkInsertAsync(IEnumerable<BankAccountDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  BankAccountBulkUpdate(IEnumerable<BankAccountDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankAccountBulkUpdateAsync(IEnumerable<BankAccountDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  BankTransfersBulkDelete(IEnumerable<BankTransfersDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankTransfersBulkDeleteAsync(IEnumerable<BankTransfersDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  BankTransfersBulkInsert(IEnumerable<BankTransfersDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankTransfersBulkInsertAsync(IEnumerable<BankTransfersDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  BankTransfersBulkUpdate(IEnumerable<BankTransfersDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BankTransfersBulkUpdateAsync(IEnumerable<BankTransfersDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  BookBulkDelete(IEnumerable<BookDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BookBulkDeleteAsync(IEnumerable<BookDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  BookBulkInsert(IEnumerable<BookDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BookBulkInsertAsync(IEnumerable<BookDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  BookBulkUpdate(IEnumerable<BookDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  BookBulkUpdateAsync(IEnumerable<BookDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  CountryBulkDelete(IEnumerable<CountryDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CountryBulkDeleteAsync(IEnumerable<CountryDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  CountryBulkInsert(IEnumerable<CountryDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CountryBulkInsertAsync(IEnumerable<CountryDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  CountryBulkUpdate(IEnumerable<CountryDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CountryBulkUpdateAsync(IEnumerable<CountryDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkDelete(IEnumerable<CustomerDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkDeleteAsync(IEnumerable<CustomerDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkInsert(IEnumerable<CustomerDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkInsertAsync(IEnumerable<CustomerDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkUpdate(IEnumerable<CustomerDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkUpdateAsync(IEnumerable<CustomerDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  OrderBulkDelete(IEnumerable<OrderDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderBulkDeleteAsync(IEnumerable<OrderDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  OrderBulkInsert(IEnumerable<OrderDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderBulkInsertAsync(IEnumerable<OrderDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  OrderBulkUpdate(IEnumerable<OrderDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderBulkUpdateAsync(IEnumerable<OrderDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  OrderDetailsBulkDelete(IEnumerable<OrderDetailsDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderDetailsBulkDeleteAsync(IEnumerable<OrderDetailsDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  OrderDetailsBulkInsert(IEnumerable<OrderDetailsDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderDetailsBulkInsertAsync(IEnumerable<OrderDetailsDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  OrderDetailsBulkUpdate(IEnumerable<OrderDetailsDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  OrderDetailsBulkUpdateAsync(IEnumerable<OrderDetailsDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkDelete(IEnumerable<ProductDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkDeleteAsync(IEnumerable<ProductDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkInsert(IEnumerable<ProductDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkInsertAsync(IEnumerable<ProductDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkUpdate(IEnumerable<ProductDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkUpdateAsync(IEnumerable<ProductDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  SoftwareBulkDelete(IEnumerable<SoftwareDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  SoftwareBulkDeleteAsync(IEnumerable<SoftwareDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  SoftwareBulkInsert(IEnumerable<SoftwareDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  SoftwareBulkInsertAsync(IEnumerable<SoftwareDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  SoftwareBulkUpdate(IEnumerable<SoftwareDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  SoftwareBulkUpdateAsync(IEnumerable<SoftwareDto> items);

        #endregion
    }
}

