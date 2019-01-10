
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
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

namespace DotNetScaffolder.Domain.ApplicationService
{
    /// <summary>
	/// The ProductApplication Service 
	/// </summary>
	public partial class ProductApplicationService  : IProductApplicationService
	{

        /// <summary>
        /// Gets or sets the BankAccount Repository 
        /// </summary>
        protected IBankAccountRepository BankAccountRepository { get; set; }
        /// <summary>
        /// Gets or sets the BankTransfers Repository 
        /// </summary>
        protected IBankTransfersRepository BankTransfersRepository { get; set; }
        /// <summary>
        /// Gets or sets the Book Repository 
        /// </summary>
        protected IBookRepository BookRepository { get; set; }
        /// <summary>
        /// Gets or sets the Country Repository 
        /// </summary>
        protected ICountryRepository CountryRepository { get; set; }
        /// <summary>
        /// Gets or sets the Customer Repository 
        /// </summary>
        protected ICustomerRepository CustomerRepository { get; set; }
        /// <summary>
        /// Gets or sets the Order Repository 
        /// </summary>
        protected IOrderRepository OrderRepository { get; set; }
        /// <summary>
        /// Gets or sets the OrderDetails Repository 
        /// </summary>
        protected IOrderDetailsRepository OrderDetailsRepository { get; set; }
        /// <summary>
        /// Gets or sets the Product Repository 
        /// </summary>
        protected IProductRepository ProductRepository { get; set; }
        /// <summary>
        /// Gets or sets the Software Repository 
        /// </summary>
        protected ISoftwareRepository SoftwareRepository { get; set; }

        public ProductApplicationService (
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
        /// <returns>BankAccountDto</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public BankAccountDto LoadByBankAccountBankAccountId(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return new BankAccountDto(this.BankAccountRepository.LoadByBankAccountId(bankAccountId, cache, includes), true);
        }

        /// <summary>
        /// Load BankAccount Async entities from the database using the primary key
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <returns>BankAccountDto</returns>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
		public async Task<BankAccountDto> LoadByBankAccountBankAccountIdAsync(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return new BankAccountDto(await this.BankAccountRepository.LoadByBankAccountIdAsync(bankAccountId, cache, includes), true);
        }

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public IList<BankAccountDto> BankAccountLoadAll(bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(this.BankAccountRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all BankAccount Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public async Task<IList<BankAccountDto>> BankAccountLoadAllAsync(bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto( await this.BankAccountRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <returns>BankTransfersDto</returns>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
		public BankTransfersDto LoadByBankTransfersBankTransferId(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return new BankTransfersDto(this.BankTransfersRepository.LoadByBankTransferId(bankTransferId, cache, includes), true);
        }

        /// <summary>
        /// Load BankTransfers Async entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <returns>BankTransfersDto</returns>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
		public async Task<BankTransfersDto> LoadByBankTransfersBankTransferIdAsync(int bankTransferId, bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return new BankTransfersDto(await this.BankTransfersRepository.LoadByBankTransferIdAsync(bankTransferId, cache, includes), true);
        }

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfersDto></returns>
		public IList<BankTransfersDto> BankTransfersLoadAll(bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return this.ConvertBankTransfersEntityToDto(this.BankTransfersRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all BankTransfers Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<BankTransfersDto></returns>
		public async Task<IList<BankTransfersDto>> BankTransfersLoadAllAsync(bool cache, params Expression<Func<IBankTransfers, object>>[] includes)
        {
            return this.ConvertBankTransfersEntityToDto( await this.BankTransfersRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>BookDto</returns>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
		public BookDto LoadByBookProductId(int productId, bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return new BookDto(this.BookRepository.LoadByProductId(productId, cache, includes), true);
        }

        /// <summary>
        /// Load Book Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>BookDto</returns>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
		public async Task<BookDto> LoadByBookProductIdAsync(int productId, bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return new BookDto(await this.BookRepository.LoadByProductIdAsync(productId, cache, includes), true);
        }

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		public IList<BookDto> BookLoadAll(bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return this.ConvertBookEntityToDto(this.BookRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Book Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		public async Task<IList<BookDto>> BookLoadAllAsync(bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return this.ConvertBookEntityToDto( await this.BookRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>CountryDto</returns>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
		public CountryDto LoadByCountryCountryId(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return new CountryDto(this.CountryRepository.LoadByCountryId(countryId, cache, includes), true);
        }

        /// <summary>
        /// Load Country Async entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>CountryDto</returns>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
		public async Task<CountryDto> LoadByCountryCountryIdAsync(int countryId, bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return new CountryDto(await this.CountryRepository.LoadByCountryIdAsync(countryId, cache, includes), true);
        }

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		public IList<CountryDto> CountryLoadAll(bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.ConvertCountryEntityToDto(this.CountryRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Country Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		public async Task<IList<CountryDto>> CountryLoadAllAsync(bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.ConvertCountryEntityToDto( await this.CountryRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>CustomerDto</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public CustomerDto LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return new CustomerDto(this.CustomerRepository.LoadByCustomerId(customerId, cache, includes), true);
        }

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>CustomerDto</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public async Task<CustomerDto> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return new CustomerDto(await this.CustomerRepository.LoadByCustomerIdAsync(customerId, cache, includes), true);
        }

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto( await this.CustomerRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>OrderDto</returns>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
		public OrderDto LoadByOrderOrderId(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return new OrderDto(this.OrderRepository.LoadByOrderId(orderId, cache, includes), true);
        }

        /// <summary>
        /// Load Order Async entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>OrderDto</returns>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
		public async Task<OrderDto> LoadByOrderOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return new OrderDto(await this.OrderRepository.LoadByOrderIdAsync(orderId, cache, includes), true);
        }

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public IList<OrderDto> OrderLoadAll(bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(this.OrderRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Order Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public async Task<IList<OrderDto>> OrderLoadAllAsync(bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto( await this.OrderRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>OrderDetailsDto</returns>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
		public OrderDetailsDto LoadByOrderDetailsOrderDetailsId(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return new OrderDetailsDto(this.OrderDetailsRepository.LoadByOrderDetailsId(orderDetailsId, cache, includes), true);
        }

        /// <summary>
        /// Load OrderDetails Async entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>OrderDetailsDto</returns>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
		public async Task<OrderDetailsDto> LoadByOrderDetailsOrderDetailsIdAsync(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return new OrderDetailsDto(await this.OrderDetailsRepository.LoadByOrderDetailsIdAsync(orderDetailsId, cache, includes), true);
        }

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetailsDto></returns>
		public IList<OrderDetailsDto> OrderDetailsLoadAll(bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return this.ConvertOrderDetailsEntityToDto(this.OrderDetailsRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all OrderDetails Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<OrderDetailsDto></returns>
		public async Task<IList<OrderDetailsDto>> OrderDetailsLoadAllAsync(bool cache, params Expression<Func<IOrderDetails, object>>[] includes)
        {
            return this.ConvertOrderDetailsEntityToDto( await this.OrderDetailsRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ProductDto</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public ProductDto LoadByProductProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return new ProductDto(this.ProductRepository.LoadByProductId(productId, cache, includes), true);
        }

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ProductDto</returns>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
		public async Task<ProductDto> LoadByProductProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return new ProductDto(await this.ProductRepository.LoadByProductIdAsync(productId, cache, includes), true);
        }

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		public IList<ProductDto> ProductLoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ConvertProductEntityToDto(this.ProductRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		public async Task<IList<ProductDto>> ProductLoadAllAsync(bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ConvertProductEntityToDto( await this.ProductRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>SoftwareDto</returns>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
		public SoftwareDto LoadBySoftwareProductId(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return new SoftwareDto(this.SoftwareRepository.LoadByProductId(productId, cache, includes), true);
        }

        /// <summary>
        /// Load Software Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>SoftwareDto</returns>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
		public async Task<SoftwareDto> LoadBySoftwareProductIdAsync(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return new SoftwareDto(await this.SoftwareRepository.LoadByProductIdAsync(productId, cache, includes), true);
        }

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		public IList<SoftwareDto> SoftwareLoadAll(bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.ConvertSoftwareEntityToDto(this.SoftwareRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all Software Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		public async Task<IList<SoftwareDto>> SoftwareLoadAllAsync(bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.ConvertSoftwareEntityToDto( await this.SoftwareRepository.LoadAllAsync(cache, includes));
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public IList<BankAccountDto> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(this.BankAccountRepository.SearchByBankAccountNumber(bankAccountNumber,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for BankAccount Async entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccountDto></returns>
		public async Task<IList<BankAccountDto>> BankAccountSearchByBankAccountNumberAsync(string bankAccountNumber, bool caseSensitive, bool cache, params Expression<Func<IBankAccount, object>>[] includes)
        {
            return this.ConvertBankAccountEntityToDto(await this.BankAccountRepository.SearchByBankAccountNumberAsync(bankAccountNumber,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		public IList<BookDto> BookSearchByPublisher(string publisher, bool caseSensitive, bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return this.ConvertBookEntityToDto(this.BookRepository.SearchByPublisher(publisher,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Book Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<BookDto></returns>
		public async Task<IList<BookDto>> BookSearchByPublisherAsync(string publisher, bool caseSensitive, bool cache, params Expression<Func<IBook, object>>[] includes)
        {
            return this.ConvertBookEntityToDto(await this.BookRepository.SearchByPublisherAsync(publisher,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		public IList<CountryDto> CountrySearchByCountryName(string countryName, bool caseSensitive, bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.ConvertCountryEntityToDto(this.CountryRepository.SearchByCountryName(countryName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Country Async entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<CountryDto></returns>
		public async Task<IList<CountryDto>> CountrySearchByCountryNameAsync(string countryName, bool caseSensitive, bool cache, params Expression<Func<ICountry, object>>[] includes)
        {
            return this.ConvertCountryEntityToDto(await this.CountryRepository.SearchByCountryNameAsync(countryName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByCustomerCode(customerCode,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByCustomerCodeAsync(customerCode,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByCompanyName(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByCompanyName(companyName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByCompanyNameAsync(companyName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByContactName(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByContactName(contactName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByContactNameAsync(contactName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByContactTitle(contactTitle,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByContactTitleAsync(contactTitle,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByAddress(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByAddress(address,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByAddressAsync(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByAddressAsync(address,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByCity(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByCity(city,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByCityAsync(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByCityAsync(city,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByPostalCode(postalCode,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByPostalCodeAsync(postalCode,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByTelephone(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByTelephone(telephone,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByTelephoneAsync(telephone,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByFax(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByFax(fax,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByFaxAsync(fax,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public IList<CustomerDto> CustomerSearchByPhoto(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(this.CustomerRepository.SearchByPhoto(photo,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<CustomerDto></returns>
		public async Task<IList<CustomerDto>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.ConvertCustomerEntityToDto(await this.CustomerRepository.SearchByPhotoAsync(photo,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public IList<OrderDto> OrderSearchByShippingName(string shippingName, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(this.OrderRepository.SearchByShippingName(shippingName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public async Task<IList<OrderDto>> OrderSearchByShippingNameAsync(string shippingName, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(await this.OrderRepository.SearchByShippingNameAsync(shippingName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public IList<OrderDto> OrderSearchByShippingAddress(string shippingAddress, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(this.OrderRepository.SearchByShippingAddress(shippingAddress,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public async Task<IList<OrderDto>> OrderSearchByShippingAddressAsync(string shippingAddress, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(await this.OrderRepository.SearchByShippingAddressAsync(shippingAddress,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public IList<OrderDto> OrderSearchByShippingCity(string shippingCity, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(this.OrderRepository.SearchByShippingCity(shippingCity,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public async Task<IList<OrderDto>> OrderSearchByShippingCityAsync(string shippingCity, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(await this.OrderRepository.SearchByShippingCityAsync(shippingCity,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public IList<OrderDto> OrderSearchByShippingZip(string shippingZip, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(this.OrderRepository.SearchByShippingZip(shippingZip,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Order Async entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<OrderDto></returns>
		public async Task<IList<OrderDto>> OrderSearchByShippingZipAsync(string shippingZip, bool caseSensitive, bool cache, params Expression<Func<IOrder, object>>[] includes)
        {
            return this.ConvertOrderEntityToDto(await this.OrderRepository.SearchByShippingZipAsync(shippingZip,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		public IList<ProductDto> ProductSearchByProductDescription(string productDescription, bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ConvertProductEntityToDto(this.ProductRepository.SearchByProductDescription(productDescription,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Product Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<ProductDto></returns>
		public async Task<IList<ProductDto>> ProductSearchByProductDescriptionAsync(string productDescription, bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes)
        {
            return this.ConvertProductEntityToDto(await this.ProductRepository.SearchByProductDescriptionAsync(productDescription,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		public IList<SoftwareDto> SoftwareSearchByLicenseCode(string licenseCode, bool caseSensitive, bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.ConvertSoftwareEntityToDto(this.SoftwareRepository.SearchByLicenseCode(licenseCode,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Software Async entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<SoftwareDto></returns>
		public async Task<IList<SoftwareDto>> SoftwareSearchByLicenseCodeAsync(string licenseCode, bool caseSensitive, bool cache, params Expression<Func<ISoftware, object>>[] includes)
        {
            return this.ConvertSoftwareEntityToDto(await this.SoftwareRepository.SearchByLicenseCodeAsync(licenseCode,caseSensitive, cache, includes));
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountAdd(BankAccountDto entity)
        {
            return this.BankAccountRepository.Update(new BankAccount(entity, true));
        }

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountUpdate(BankAccountDto entity)
        {
            return this.BankAccountRepository.Update(new BankAccount(entity, true));
        }
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete(BankAccountDto entity)
        {
            return this.BankAccountRepository.Delete(new BankAccount(entity, true));
        }

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		public bool BankAccountDelete( int bankAccountId, bool cache)
        {
            return this.BankAccountRepository.Delete( bankAccountId, cache);
        }

		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersAdd(BankTransfersDto entity)
        {
            return this.BankTransfersRepository.Update(new BankTransfers(entity, true));
        }

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersUpdate(BankTransfersDto entity)
        {
            return this.BankTransfersRepository.Update(new BankTransfers(entity, true));
        }
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersDelete(BankTransfersDto entity)
        {
            return this.BankTransfersRepository.Delete(new BankTransfers(entity, true));
        }

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		public bool BankTransfersDelete( int bankTransferId, bool cache)
        {
            return this.BankTransfersRepository.Delete( bankTransferId, cache);
        }

		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookAdd(BookDto entity)
        {
            return this.BookRepository.Update(new Book(entity, true));
        }

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookUpdate(BookDto entity)
        {
            return this.BookRepository.Update(new Book(entity, true));
        }
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookDelete(BookDto entity)
        {
            return this.BookRepository.Delete(new Book(entity, true));
        }

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool BookDelete( int productId, bool cache)
        {
            return this.BookRepository.Delete( productId, cache);
        }

		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryAdd(CountryDto entity)
        {
            return this.CountryRepository.Update(new Country(entity, true));
        }

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryUpdate(CountryDto entity)
        {
            return this.CountryRepository.Update(new Country(entity, true));
        }
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountryDelete(CountryDto entity)
        {
            return this.CountryRepository.Delete(new Country(entity, true));
        }

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		public bool CountryDelete( int countryId, bool cache)
        {
            return this.CountryRepository.Delete( countryId, cache);
        }

		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerAdd(CustomerDto entity)
        {
            return this.CustomerRepository.Update(new Customer(entity, true));
        }

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerUpdate(CustomerDto entity)
        {
            return this.CustomerRepository.Update(new Customer(entity, true));
        }
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerDelete(CustomerDto entity)
        {
            return this.CustomerRepository.Delete(new Customer(entity, true));
        }

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public bool CustomerDelete( int customerId, bool cache)
        {
            return this.CustomerRepository.Delete( customerId, cache);
        }

		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderAdd(OrderDto entity)
        {
            return this.OrderRepository.Update(new Order(entity, true));
        }

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderUpdate(OrderDto entity)
        {
            return this.OrderRepository.Update(new Order(entity, true));
        }
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderDelete(OrderDto entity)
        {
            return this.OrderRepository.Delete(new Order(entity, true));
        }

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		public bool OrderDelete( int orderId, bool cache)
        {
            return this.OrderRepository.Delete( orderId, cache);
        }

		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsAdd(OrderDetailsDto entity)
        {
            return this.OrderDetailsRepository.Update(new OrderDetails(entity, true));
        }

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsUpdate(OrderDetailsDto entity)
        {
            return this.OrderDetailsRepository.Update(new OrderDetails(entity, true));
        }
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsDelete(OrderDetailsDto entity)
        {
            return this.OrderDetailsRepository.Delete(new OrderDetails(entity, true));
        }

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		public bool OrderDetailsDelete( int orderDetailsId, bool cache)
        {
            return this.OrderDetailsRepository.Delete( orderDetailsId, cache);
        }

		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductAdd(ProductDto entity)
        {
            return this.ProductRepository.Update(new Product(entity, true));
        }

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductUpdate(ProductDto entity)
        {
            return this.ProductRepository.Update(new Product(entity, true));
        }
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductDelete(ProductDto entity)
        {
            return this.ProductRepository.Delete(new Product(entity, true));
        }

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool ProductDelete( int productId, bool cache)
        {
            return this.ProductRepository.Delete( productId, cache);
        }

		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareAdd(SoftwareDto entity)
        {
            return this.SoftwareRepository.Update(new Software(entity, true));
        }

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareUpdate(SoftwareDto entity)
        {
            return this.SoftwareRepository.Update(new Software(entity, true));
        }
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareDelete(SoftwareDto entity)
        {
            return this.SoftwareRepository.Delete(new Software(entity, true));
        }

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		public bool SoftwareDelete( int productId, bool cache)
        {
            return this.SoftwareRepository.Delete( productId, cache);
        }


		#endregion

        #region Aggregates
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BankAccountMax<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return this.BankAccountRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankAccountMaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return await this.BankAccountRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BankAccountMin<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return this.BankAccountRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankAccount, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> BankAccountMinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache)
        {
		    return await this.BankAccountRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BankTransfersMax<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
        {
		    return this.BankTransfersRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BankTransfersMaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
        {
		    return await this.BankTransfersRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BankTransfersMin<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
        {
		    return this.BankTransfersRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBankTransfers, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> BankTransfersMinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression, bool cache)
        {
		    return await this.BankTransfersRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult BookMax<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
        {
		    return this.BookRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> BookMaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
        {
		    return await this.BookRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult BookMin<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
        {
		    return this.BookRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IBook, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> BookMinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache)
        {
		    return await this.BookRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult CountryMax<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
        {
		    return this.CountryRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CountryMaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
        {
		    return await this.CountryRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult CountryMin<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
        {
		    return this.CountryRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICountry, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> CountryMinAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression, bool cache)
        {
		    return await this.CountryRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult CustomerMax<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
		    return this.CustomerRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CustomerMaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
		    return await this.CustomerRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult CustomerMin<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
		    return this.CustomerRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
		    return await this.CustomerRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult OrderMax<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
        {
		    return this.OrderRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderMaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
        {
		    return await this.OrderRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult OrderMin<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
        {
		    return this.OrderRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrder, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> OrderMinAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache)
        {
		    return await this.OrderRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult OrderDetailsMax<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
        {
		    return this.OrderDetailsRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> OrderDetailsMaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
        {
		    return await this.OrderDetailsRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult OrderDetailsMin<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
        {
		    return this.OrderDetailsRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IOrderDetails, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> OrderDetailsMinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache)
        {
		    return await this.OrderDetailsRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ProductMax<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
        {
		    return this.ProductRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ProductMaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
        {
		    return await this.ProductRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ProductMin<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
        {
		    return this.ProductRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> ProductMinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache)
        {
		    return await this.ProductRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult SoftwareMax<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
        {
		    return this.SoftwareRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> SoftwareMaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
        {
		    return await this.SoftwareRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult SoftwareMin<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
        {
		    return this.SoftwareRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<ISoftware, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> SoftwareMinAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache)
        {
		    return await this.SoftwareRepository.MinAsync(maxExpression, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        /// Converts a BankAccountDto list to BankAccount list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankAccount> ConvertBankAccountDtoToEntity(IEnumerable<BankAccountDto> items)
	    {
            List<BankAccount> results = new List<BankAccount>();

	        foreach (var item in items)
	        {
	            results.Add(new BankAccount(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a BankAccount list to BankAccountDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankAccountDto> ConvertBankAccountEntityToDto(IEnumerable<BankAccount> items)
	    {
            List<BankAccountDto> results = new List<BankAccountDto>();

	        foreach (var item in items)
	        {
	            results.Add(new BankAccountDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void BankAccountBulkDelete(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkDelete(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BankAccountBulkDeleteAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkDeleteAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  BankAccountBulkInsert(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkInsert(this.ConvertBankAccountDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankAccountBulkInsertAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkInsertAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  BankAccountBulkUpdate(IEnumerable<BankAccountDto> items)
		{
			this.BankAccountRepository.BulkUpdate(this.ConvertBankAccountDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankAccountBulkUpdateAsync(IEnumerable<BankAccountDto> items)
		{
			await this.BankAccountRepository.BulkUpdateAsync(this.ConvertBankAccountDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a BankTransfersDto list to BankTransfers list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankTransfers> ConvertBankTransfersDtoToEntity(IEnumerable<BankTransfersDto> items)
	    {
            List<BankTransfers> results = new List<BankTransfers>();

	        foreach (var item in items)
	        {
	            results.Add(new BankTransfers(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a BankTransfers list to BankTransfersDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BankTransfersDto> ConvertBankTransfersEntityToDto(IEnumerable<BankTransfers> items)
	    {
            List<BankTransfersDto> results = new List<BankTransfersDto>();

	        foreach (var item in items)
	        {
	            results.Add(new BankTransfersDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void BankTransfersBulkDelete(IEnumerable<BankTransfersDto> items)
		{
			this.BankTransfersRepository.BulkDelete(this.ConvertBankTransfersDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BankTransfersBulkDeleteAsync(IEnumerable<BankTransfersDto> items)
		{
			await this.BankTransfersRepository.BulkDeleteAsync(this.ConvertBankTransfersDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  BankTransfersBulkInsert(IEnumerable<BankTransfersDto> items)
		{
			this.BankTransfersRepository.BulkInsert(this.ConvertBankTransfersDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankTransfersBulkInsertAsync(IEnumerable<BankTransfersDto> items)
		{
			await this.BankTransfersRepository.BulkInsertAsync(this.ConvertBankTransfersDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  BankTransfersBulkUpdate(IEnumerable<BankTransfersDto> items)
		{
			this.BankTransfersRepository.BulkUpdate(this.ConvertBankTransfersDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BankTransfersBulkUpdateAsync(IEnumerable<BankTransfersDto> items)
		{
			await this.BankTransfersRepository.BulkUpdateAsync(this.ConvertBankTransfersDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a BookDto list to Book list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Book> ConvertBookDtoToEntity(IEnumerable<BookDto> items)
	    {
            List<Book> results = new List<Book>();

	        foreach (var item in items)
	        {
	            results.Add(new Book(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Book list to BookDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<BookDto> ConvertBookEntityToDto(IEnumerable<Book> items)
	    {
            List<BookDto> results = new List<BookDto>();

	        foreach (var item in items)
	        {
	            results.Add(new BookDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void BookBulkDelete(IEnumerable<BookDto> items)
		{
			this.BookRepository.BulkDelete(this.ConvertBookDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task BookBulkDeleteAsync(IEnumerable<BookDto> items)
		{
			await this.BookRepository.BulkDeleteAsync(this.ConvertBookDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  BookBulkInsert(IEnumerable<BookDto> items)
		{
			this.BookRepository.BulkInsert(this.ConvertBookDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BookBulkInsertAsync(IEnumerable<BookDto> items)
		{
			await this.BookRepository.BulkInsertAsync(this.ConvertBookDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  BookBulkUpdate(IEnumerable<BookDto> items)
		{
			this.BookRepository.BulkUpdate(this.ConvertBookDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  BookBulkUpdateAsync(IEnumerable<BookDto> items)
		{
			await this.BookRepository.BulkUpdateAsync(this.ConvertBookDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a CountryDto list to Country list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Country> ConvertCountryDtoToEntity(IEnumerable<CountryDto> items)
	    {
            List<Country> results = new List<Country>();

	        foreach (var item in items)
	        {
	            results.Add(new Country(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Country list to CountryDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<CountryDto> ConvertCountryEntityToDto(IEnumerable<Country> items)
	    {
            List<CountryDto> results = new List<CountryDto>();

	        foreach (var item in items)
	        {
	            results.Add(new CountryDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void CountryBulkDelete(IEnumerable<CountryDto> items)
		{
			this.CountryRepository.BulkDelete(this.ConvertCountryDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CountryBulkDeleteAsync(IEnumerable<CountryDto> items)
		{
			await this.CountryRepository.BulkDeleteAsync(this.ConvertCountryDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  CountryBulkInsert(IEnumerable<CountryDto> items)
		{
			this.CountryRepository.BulkInsert(this.ConvertCountryDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CountryBulkInsertAsync(IEnumerable<CountryDto> items)
		{
			await this.CountryRepository.BulkInsertAsync(this.ConvertCountryDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  CountryBulkUpdate(IEnumerable<CountryDto> items)
		{
			this.CountryRepository.BulkUpdate(this.ConvertCountryDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CountryBulkUpdateAsync(IEnumerable<CountryDto> items)
		{
			await this.CountryRepository.BulkUpdateAsync(this.ConvertCountryDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a CustomerDto list to Customer list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Customer> ConvertCustomerDtoToEntity(IEnumerable<CustomerDto> items)
	    {
            List<Customer> results = new List<Customer>();

	        foreach (var item in items)
	        {
	            results.Add(new Customer(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Customer list to CustomerDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<CustomerDto> ConvertCustomerEntityToDto(IEnumerable<Customer> items)
	    {
            List<CustomerDto> results = new List<CustomerDto>();

	        foreach (var item in items)
	        {
	            results.Add(new CustomerDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void CustomerBulkDelete(IEnumerable<CustomerDto> items)
		{
			this.CustomerRepository.BulkDelete(this.ConvertCustomerDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CustomerBulkDeleteAsync(IEnumerable<CustomerDto> items)
		{
			await this.CustomerRepository.BulkDeleteAsync(this.ConvertCustomerDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  CustomerBulkInsert(IEnumerable<CustomerDto> items)
		{
			this.CustomerRepository.BulkInsert(this.ConvertCustomerDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CustomerBulkInsertAsync(IEnumerable<CustomerDto> items)
		{
			await this.CustomerRepository.BulkInsertAsync(this.ConvertCustomerDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  CustomerBulkUpdate(IEnumerable<CustomerDto> items)
		{
			this.CustomerRepository.BulkUpdate(this.ConvertCustomerDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CustomerBulkUpdateAsync(IEnumerable<CustomerDto> items)
		{
			await this.CustomerRepository.BulkUpdateAsync(this.ConvertCustomerDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a OrderDto list to Order list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Order> ConvertOrderDtoToEntity(IEnumerable<OrderDto> items)
	    {
            List<Order> results = new List<Order>();

	        foreach (var item in items)
	        {
	            results.Add(new Order(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Order list to OrderDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<OrderDto> ConvertOrderEntityToDto(IEnumerable<Order> items)
	    {
            List<OrderDto> results = new List<OrderDto>();

	        foreach (var item in items)
	        {
	            results.Add(new OrderDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void OrderBulkDelete(IEnumerable<OrderDto> items)
		{
			this.OrderRepository.BulkDelete(this.ConvertOrderDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task OrderBulkDeleteAsync(IEnumerable<OrderDto> items)
		{
			await this.OrderRepository.BulkDeleteAsync(this.ConvertOrderDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  OrderBulkInsert(IEnumerable<OrderDto> items)
		{
			this.OrderRepository.BulkInsert(this.ConvertOrderDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  OrderBulkInsertAsync(IEnumerable<OrderDto> items)
		{
			await this.OrderRepository.BulkInsertAsync(this.ConvertOrderDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  OrderBulkUpdate(IEnumerable<OrderDto> items)
		{
			this.OrderRepository.BulkUpdate(this.ConvertOrderDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  OrderBulkUpdateAsync(IEnumerable<OrderDto> items)
		{
			await this.OrderRepository.BulkUpdateAsync(this.ConvertOrderDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a OrderDetailsDto list to OrderDetails list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<OrderDetails> ConvertOrderDetailsDtoToEntity(IEnumerable<OrderDetailsDto> items)
	    {
            List<OrderDetails> results = new List<OrderDetails>();

	        foreach (var item in items)
	        {
	            results.Add(new OrderDetails(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a OrderDetails list to OrderDetailsDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<OrderDetailsDto> ConvertOrderDetailsEntityToDto(IEnumerable<OrderDetails> items)
	    {
            List<OrderDetailsDto> results = new List<OrderDetailsDto>();

	        foreach (var item in items)
	        {
	            results.Add(new OrderDetailsDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void OrderDetailsBulkDelete(IEnumerable<OrderDetailsDto> items)
		{
			this.OrderDetailsRepository.BulkDelete(this.ConvertOrderDetailsDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task OrderDetailsBulkDeleteAsync(IEnumerable<OrderDetailsDto> items)
		{
			await this.OrderDetailsRepository.BulkDeleteAsync(this.ConvertOrderDetailsDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  OrderDetailsBulkInsert(IEnumerable<OrderDetailsDto> items)
		{
			this.OrderDetailsRepository.BulkInsert(this.ConvertOrderDetailsDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  OrderDetailsBulkInsertAsync(IEnumerable<OrderDetailsDto> items)
		{
			await this.OrderDetailsRepository.BulkInsertAsync(this.ConvertOrderDetailsDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  OrderDetailsBulkUpdate(IEnumerable<OrderDetailsDto> items)
		{
			this.OrderDetailsRepository.BulkUpdate(this.ConvertOrderDetailsDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  OrderDetailsBulkUpdateAsync(IEnumerable<OrderDetailsDto> items)
		{
			await this.OrderDetailsRepository.BulkUpdateAsync(this.ConvertOrderDetailsDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a ProductDto list to Product list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Product> ConvertProductDtoToEntity(IEnumerable<ProductDto> items)
	    {
            List<Product> results = new List<Product>();

	        foreach (var item in items)
	        {
	            results.Add(new Product(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Product list to ProductDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ProductDto> ConvertProductEntityToDto(IEnumerable<Product> items)
	    {
            List<ProductDto> results = new List<ProductDto>();

	        foreach (var item in items)
	        {
	            results.Add(new ProductDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ProductBulkDelete(IEnumerable<ProductDto> items)
		{
			this.ProductRepository.BulkDelete(this.ConvertProductDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ProductBulkDeleteAsync(IEnumerable<ProductDto> items)
		{
			await this.ProductRepository.BulkDeleteAsync(this.ConvertProductDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ProductBulkInsert(IEnumerable<ProductDto> items)
		{
			this.ProductRepository.BulkInsert(this.ConvertProductDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ProductBulkInsertAsync(IEnumerable<ProductDto> items)
		{
			await this.ProductRepository.BulkInsertAsync(this.ConvertProductDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  ProductBulkUpdate(IEnumerable<ProductDto> items)
		{
			this.ProductRepository.BulkUpdate(this.ConvertProductDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ProductBulkUpdateAsync(IEnumerable<ProductDto> items)
		{
			await this.ProductRepository.BulkUpdateAsync(this.ConvertProductDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a SoftwareDto list to Software list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Software> ConvertSoftwareDtoToEntity(IEnumerable<SoftwareDto> items)
	    {
            List<Software> results = new List<Software>();

	        foreach (var item in items)
	        {
	            results.Add(new Software(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Software list to SoftwareDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<SoftwareDto> ConvertSoftwareEntityToDto(IEnumerable<Software> items)
	    {
            List<SoftwareDto> results = new List<SoftwareDto>();

	        foreach (var item in items)
	        {
	            results.Add(new SoftwareDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void SoftwareBulkDelete(IEnumerable<SoftwareDto> items)
		{
			this.SoftwareRepository.BulkDelete(this.ConvertSoftwareDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task SoftwareBulkDeleteAsync(IEnumerable<SoftwareDto> items)
		{
			await this.SoftwareRepository.BulkDeleteAsync(this.ConvertSoftwareDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  SoftwareBulkInsert(IEnumerable<SoftwareDto> items)
		{
			this.SoftwareRepository.BulkInsert(this.ConvertSoftwareDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  SoftwareBulkInsertAsync(IEnumerable<SoftwareDto> items)
		{
			await this.SoftwareRepository.BulkInsertAsync(this.ConvertSoftwareDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  SoftwareBulkUpdate(IEnumerable<SoftwareDto> items)
		{
			this.SoftwareRepository.BulkUpdate(this.ConvertSoftwareDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  SoftwareBulkUpdateAsync(IEnumerable<SoftwareDto> items)
		{
			await this.SoftwareRepository.BulkUpdateAsync(this.ConvertSoftwareDtoToEntity(items));
		}

        #endregion

    }
}

