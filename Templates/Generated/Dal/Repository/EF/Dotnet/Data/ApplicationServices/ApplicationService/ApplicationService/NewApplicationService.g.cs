
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
using RepositoryEFDotnet.Data.Interfaces;

namespace RepositoryEFDotnet.Data.ApplicationService
{
    /// <summary>
	/// The NewApplication Service 
	/// </summary>
	public partial class NewApplicationService  : INewApplicationService
	{


        protected IBankAccountRepository BankAccountRepository { get; set; }

        protected IBankTransfersRepository BankTransfersRepository { get; set; }

        protected IBookRepository BookRepository { get; set; }

        protected ICountryRepository CountryRepository { get; set; }

        protected ICustomerRepository CustomerRepository { get; set; }

        protected IOrderRepository OrderRepository { get; set; }

        protected IOrderDetailsRepository OrderDetailsRepository { get; set; }

        protected IProductRepository ProductRepository { get; set; }

        protected ISoftwareRepository SoftwareRepository { get; set; }

        public NewApplicationService (
                                          IBankAccountRepository bankAccountRepository,
                                                              IBankTransfersRepository bankTransfersRepository,
                                                              IBookRepository bookRepository,
                                                              ICountryRepository countryRepository,
                                                              ICustomerRepository customerRepository,
                                                              IOrderRepository orderRepository,
                                                              IOrderDetailsRepository orderDetailsRepository,
                                                              IProductRepository productRepository,
                                          ISoftwareRepository softwareRepository
                                     )
        {
            this.BankAccountRepository = bankAccountRepository;
            this.BankTransfersRepository = bankTransfersRepository;
            this.BookRepository = bookRepository;
            this.CountryRepository = countryRepository;
            this.CustomerRepository = customerRepository;
            this.OrderRepository = orderRepository;
            this.OrderDetailsRepository = orderDetailsRepository;
            this.ProductRepository = productRepository;
            this.SoftwareRepository = softwareRepository;
        }

        #region Load

        /// <summary>
        /// Load BankAccount entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>IBankAccount</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public IBankAccount LoadByBankAccountBankAccountId(int bankAccountId, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.BankAccountRepository.LoadByBankAccountId(bankAccountId, includes);
        }

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>IBankAccount</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public async Task<IBankAccount> LoadByBankAccountBankAccountIdAsync(int bankAccountId, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return await this.BankAccountRepository.LoadByBankAccountIdAsync(bankAccountId, includes);
        }

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountLoadAll(params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.BankAccountRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public Task<IList<IBankAccount>> BankAccountLoadAllAsync(params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.BankAccountRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <returns>IBankTransfers</returns>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
		public IBankTransfers LoadByBankTransfersBankTransferId(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return this.BankTransfersRepository.LoadByBankTransferId(bankTransferId, includes);
        }

        /// <summary>
        /// Load BankTransfers Async entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <returns>IBankTransfers</returns>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
		public async Task<IBankTransfers> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return await this.BankTransfersRepository.LoadByBankTransferIdAsync(bankTransferId, includes);
        }

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> BankTransfersLoadAll(params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return this.BankTransfersRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all BankTransfers Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		public Task<IList<IBankTransfers>> BankTransfersLoadAllAsync(params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return this.BankTransfersRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IBook</returns>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
		public IBook LoadByBookProductId(int productId, params Expression<Func<IBook, object>>[] includes)
        {
            return this.BookRepository.LoadByProductId(productId, includes);
        }

        /// <summary>
        /// Load Book Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IBook</returns>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
		public async Task<IBook> LoadByBookProductIdAsync(int productId, params Expression<Func<IBook, object>>[] includes)
        {
            return await this.BookRepository.LoadByProductIdAsync(productId, includes);
        }

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public IList<IBook> BookLoadAll(params Expression<Func<IBook, object>>[] includes)
        {
            return this.BookRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Book Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public Task<IList<IBook>> BookLoadAllAsync(params Expression<Func<IBook, object>>[] includes)
        {
            return this.BookRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>ICountry</returns>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
		public ICountry LoadByCountryCountryId(int countryId, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.CountryRepository.LoadByCountryId(countryId, includes);
        }

        /// <summary>
        /// Load Country Async entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>ICountry</returns>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
		public async Task<ICountry> LoadByCountryCountryIdAsync(int countryId, params Expression<Func<ICountry, object>>[] includes)
        {
            return await this.CountryRepository.LoadByCountryIdAsync(countryId, includes);
        }

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountryLoadAll(params Expression<Func<ICountry, object>>[] includes)
        {
            return this.CountryRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Country Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public Task<IList<ICountry>> CountryLoadAllAsync(params Expression<Func<ICountry, object>>[] includes)
        {
            return this.CountryRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public ICustomer LoadByCustomerCustomerId(int customerId, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadByCustomerId(customerId, includes);
        }

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public async Task<ICustomer> LoadByCustomerCustomerIdAsync(int customerId, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.LoadByCustomerIdAsync(customerId, includes);
        }

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerLoadAll(params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public Task<IList<ICustomer>> CustomerLoadAllAsync(params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>IOrder</returns>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
		public IOrder LoadByOrderOrderId(int orderId, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.LoadByOrderId(orderId, includes);
        }

        /// <summary>
        /// Load Order Async entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>IOrder</returns>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
		public async Task<IOrder> LoadByOrderOrderIdAsync(int orderId, params Expression<Func<IOrder, object>>[] includes)
        {
            return await this.OrderRepository.LoadByOrderIdAsync(orderId, includes);
        }

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderLoadAll(params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Order Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public Task<IList<IOrder>> OrderLoadAllAsync(params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>IOrderDetails</returns>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
		public IOrderDetails LoadByOrderDetailsOrderDetailsId(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return this.OrderDetailsRepository.LoadByOrderDetailsId(orderDetailsId, includes);
        }

        /// <summary>
        /// Load OrderDetails Async entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>IOrderDetails</returns>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
		public async Task<IOrderDetails> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return await this.OrderDetailsRepository.LoadByOrderDetailsIdAsync(orderDetailsId, includes);
        }

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> OrderDetailsLoadAll(params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return this.OrderDetailsRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all OrderDetails Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		public Task<IList<IOrderDetails>> OrderDetailsLoadAllAsync(params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return this.OrderDetailsRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public IProduct LoadByProductProductId(int productId, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadByProductId(productId, includes);
        }

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public async Task<IProduct> LoadByProductProductIdAsync(int productId, params Expression<Func<IProduct, object>>[] includes)
        {
            return await this.ProductRepository.LoadByProductIdAsync(productId, includes);
        }

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductLoadAll(params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public Task<IList<IProduct>> ProductLoadAllAsync(params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.LoadAllAsync(includes);
        }


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ISoftware</returns>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
		public ISoftware LoadBySoftwareProductId(int productId, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.SoftwareRepository.LoadByProductId(productId, includes);
        }

        /// <summary>
        /// Load Software Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ISoftware</returns>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
		public async Task<ISoftware> LoadBySoftwareProductIdAsync(int productId, params Expression<Func<ISoftware, object>>[] includes)
        {
            return await this.SoftwareRepository.LoadByProductIdAsync(productId, includes);
        }

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> SoftwareLoadAll(params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.SoftwareRepository.LoadAll(includes);
        }

        /// <summary>
        /// Load all Software Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public Task<IList<ISoftware>> SoftwareLoadAllAsync(params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.SoftwareRepository.LoadAllAsync(includes);
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.BankAccountRepository.SearchByBankAccountNumber(bankAccountNumber,caseSensitive, includes);
        }

        /// <summary>
        /// Search for BankAccount Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<IBankAccount></returns>
		public async Task<IList<IBankAccount>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return await this.BankAccountRepository.SearchByBankAccountNumberAsync(bankAccountNumber,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public IList<IBook> BookSearchByPublisher(string publisher, bool caseSensitive, params Expression<Func<IBook, object>>[] includes)
        {
            return this.BookRepository.SearchByPublisher(publisher,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Book Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		public async Task<IList<IBook>> BookSearchByPublisherAsync(string publisher, bool caseSensitive, params Expression<Func<IBook, object>>[] includes)
        {
            return await this.BookRepository.SearchByPublisherAsync(publisher,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountrySearchByCountryName(string countryName, bool caseSensitive, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.CountryRepository.SearchByCountryName(countryName,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Country Async entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		public async Task<IList<ICountry>> CountrySearchByCountryNameAsync(string countryName, bool caseSensitive, params Expression<Func<ICountry, object>>[] includes)
        {
            return await this.CountryRepository.SearchByCountryNameAsync(countryName,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCustomerCode(customerCode,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCustomerCodeAsync(customerCode,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCompanyName(string companyName, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCompanyName(companyName,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCompanyNameAsync(companyName,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactName(string contactName, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByContactName(contactName,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByContactNameAsync(contactName,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByContactTitle(contactTitle,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByContactTitleAsync(contactTitle,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByAddress(string address, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByAddress(address,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByAddressAsync(string address, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByAddressAsync(address,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCity(string city, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCity(city,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCityAsync(string city, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCityAsync(city,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByPostalCode(postalCode,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByPostalCodeAsync(postalCode,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByTelephone(string telephone, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByTelephone(telephone,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByTelephoneAsync(telephone,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByFax(string fax, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByFax(fax,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByFaxAsync(fax,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPhoto(string photo, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByPhoto(photo,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByPhotoAsync(photo,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingName(string shippingName, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.SearchByShippingName(shippingName,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public async Task<IList<IOrder>> OrderSearchByShippingNameAsync(string shippingName, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return await this.OrderRepository.SearchByShippingNameAsync(shippingName,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingAddress(string shippingAddress, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.SearchByShippingAddress(shippingAddress,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public async Task<IList<IOrder>> OrderSearchByShippingAddressAsync(string shippingAddress, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return await this.OrderRepository.SearchByShippingAddressAsync(shippingAddress,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingCity(string shippingCity, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.SearchByShippingCity(shippingCity,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public async Task<IList<IOrder>> OrderSearchByShippingCityAsync(string shippingCity, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return await this.OrderRepository.SearchByShippingCityAsync(shippingCity,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingZip(string shippingZip, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.OrderRepository.SearchByShippingZip(shippingZip,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<IOrder></returns>
		public async Task<IList<IOrder>> OrderSearchByShippingZipAsync(string shippingZip, bool caseSensitive, params Expression<Func<IOrder, object>>[] includes)
        {
            return await this.OrderRepository.SearchByShippingZipAsync(shippingZip,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByProductDescription(string productDescription, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.SearchByProductDescription(productDescription,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public async Task<IList<IProduct>> ProductSearchByProductDescriptionAsync(string productDescription, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return await this.ProductRepository.SearchByProductDescriptionAsync(productDescription,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByUnitAmount(string unitAmount, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.SearchByUnitAmount(unitAmount,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public async Task<IList<IProduct>> ProductSearchByUnitAmountAsync(string unitAmount, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return await this.ProductRepository.SearchByUnitAmountAsync(unitAmount,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByPublisher(string publisher, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ProductRepository.SearchByPublisher(publisher,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Product Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		public async Task<IList<IProduct>> ProductSearchByPublisherAsync(string publisher, bool caseSensitive, params Expression<Func<IProduct, object>>[] includes)
        {
            return await this.ProductRepository.SearchByPublisherAsync(publisher,caseSensitive, includes);
        }


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> SoftwareSearchByLicenseCode(string licenseCode, bool caseSensitive, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.SoftwareRepository.SearchByLicenseCode(licenseCode,caseSensitive, includes);
        }

        /// <summary>
        /// Search for Software Async entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		public async Task<IList<ISoftware>> SoftwareSearchByLicenseCodeAsync(string licenseCode, bool caseSensitive, params Expression<Func<ISoftware, object>>[] includes)
        {
            return await this.SoftwareRepository.SearchByLicenseCodeAsync(licenseCode,caseSensitive, includes);
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountAdd(IBankAccount entity)
        {
            return this.BankAccountRepository.Update(entity);
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountUpdate(IBankAccount entity)
        {
            return this.BankAccountRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete(IBankAccount entity)
        {
            return this.BankAccountRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete( int bankAccountId)
        {
            return this.BankAccountRepository.Delete( bankAccountId);
        }

		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersAdd(IBankTransfers entity)
        {
            return this.BankTransfersRepository.Update(entity);
        }

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersUpdate(IBankTransfers entity)
        {
            return this.BankTransfersRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersDelete(IBankTransfers entity)
        {
            return this.BankTransfersRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		public bool BankTransfersDelete( int bankTransferId)
        {
            return this.BankTransfersRepository.Delete( bankTransferId);
        }

		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookAdd(IBook entity)
        {
            return this.BookRepository.Update(entity);
        }

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookUpdate(IBook entity)
        {
            return this.BookRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookDelete(IBook entity)
        {
            return this.BookRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool BookDelete( int productId)
        {
            return this.BookRepository.Delete( productId);
        }

		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryAdd(ICountry entity)
        {
            return this.CountryRepository.Update(entity);
        }

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryUpdate(ICountry entity)
        {
            return this.CountryRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryDelete(ICountry entity)
        {
            return this.CountryRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public bool CountryDelete( int countryId)
        {
            return this.CountryRepository.Delete( countryId);
        }

		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerAdd(ICustomer entity)
        {
            return this.CustomerRepository.Update(entity);
        }

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerUpdate(ICustomer entity)
        {
            return this.CustomerRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerDelete(ICustomer entity)
        {
            return this.CustomerRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public bool CustomerDelete( int customerId)
        {
            return this.CustomerRepository.Delete( customerId);
        }

		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderAdd(IOrder entity)
        {
            return this.OrderRepository.Update(entity);
        }

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderUpdate(IOrder entity)
        {
            return this.OrderRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderDelete(IOrder entity)
        {
            return this.OrderRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		public bool OrderDelete( int orderId)
        {
            return this.OrderRepository.Delete( orderId);
        }

		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsAdd(IOrderDetails entity)
        {
            return this.OrderDetailsRepository.Update(entity);
        }

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsUpdate(IOrderDetails entity)
        {
            return this.OrderDetailsRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsDelete(IOrderDetails entity)
        {
            return this.OrderDetailsRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		public bool OrderDetailsDelete( int orderDetailsId)
        {
            return this.OrderDetailsRepository.Delete( orderDetailsId);
        }

		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductAdd(IProduct entity)
        {
            return this.ProductRepository.Update(entity);
        }

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductUpdate(IProduct entity)
        {
            return this.ProductRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductDelete(IProduct entity)
        {
            return this.ProductRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool ProductDelete( int productId)
        {
            return this.ProductRepository.Delete( productId);
        }

		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareAdd(ISoftware entity)
        {
            return this.SoftwareRepository.Update(entity);
        }

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareUpdate(ISoftware entity)
        {
            return this.SoftwareRepository.Update(entity);
        }
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareDelete(ISoftware entity)
        {
            return this.SoftwareRepository.Delete(entity);
        }

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool SoftwareDelete( int productId)
        {
            return this.SoftwareRepository.Delete( productId);
        }


		#endregion

        #region Aggregates
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BankAccountMax<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression)
        {
		    return this.BankAccountRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankAccountMaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression)
        {
		    return await this.BankAccountRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BankAccountMin<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression)
        {
		    return this.BankAccountRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankAccountMinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression)
        {
		    return await this.BankAccountRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BankTransfersMax<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
        {
		    return this.BankTransfersRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankTransfersMaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
        {
		    return await this.BankTransfersRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BankTransfersMin<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
        {
		    return this.BankTransfersRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankTransfersMinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression)
        {
		    return await this.BankTransfersRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BookMax<TResult>(Expression<Func<IBook, TResult>> maxExpression)
        {
		    return this.BookRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BookMaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression)
        {
		    return await this.BookRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BookMin<TResult>(Expression<Func<IBook, TResult>> maxExpression)
        {
		    return this.BookRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BookMinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression)
        {
		    return await this.BookRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult CountryMax<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
        {
		    return this.CountryRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CountryMaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
        {
		    return await this.CountryRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult CountryMin<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
        {
		    return this.CountryRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CountryMinAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression)
        {
		    return await this.CountryRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult CustomerMax<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
        {
		    return this.CustomerRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CustomerMaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
        {
		    return await this.CustomerRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult CustomerMin<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
        {
		    return this.CustomerRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression)
        {
		    return await this.CustomerRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult OrderMax<TResult>(Expression<Func<IOrder, TResult>> maxExpression)
        {
		    return this.OrderRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderMaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression)
        {
		    return await this.OrderRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult OrderMin<TResult>(Expression<Func<IOrder, TResult>> maxExpression)
        {
		    return this.OrderRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderMinAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression)
        {
		    return await this.OrderRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult OrderDetailsMax<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
        {
		    return this.OrderDetailsRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderDetailsMaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
        {
		    return await this.OrderDetailsRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult OrderDetailsMin<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
        {
		    return this.OrderDetailsRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderDetailsMinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression)
        {
		    return await this.OrderDetailsRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ProductMax<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
        {
		    return this.ProductRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ProductMaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
        {
		    return await this.ProductRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ProductMin<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
        {
		    return this.ProductRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ProductMinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression)
        {
		    return await this.ProductRepository.MinAsync(maxExpression);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult SoftwareMax<TResult>(Expression<Func<ISoftware, TResult>> maxExpression)
        {
		    return this.SoftwareRepository.Max(maxExpression);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> SoftwareMaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression)
        {
		    return await this.SoftwareRepository.MaxAsync(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult SoftwareMin<TResult>(Expression<Func<ISoftware, TResult>> maxExpression)
        {
		    return this.SoftwareRepository.Min(maxExpression);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> SoftwareMinAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression)
        {
		    return await this.SoftwareRepository.MinAsync(maxExpression);
        }

		#endregion

    }
}

