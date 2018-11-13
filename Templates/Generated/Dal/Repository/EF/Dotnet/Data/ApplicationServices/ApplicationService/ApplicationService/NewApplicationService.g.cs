
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
using Banking.Models.Interfaces;

namespace Banking.Models.ApplicationService
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
		public IBankAccount LoadByBankAccountBankAccountId(int bankAccountId)
        {
            return this.BankAccountRepository.LoadByBankAccountId(bankAccountId);
        }


        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountLoadAll()
        {
            return this.BankAccountRepository.LoadAll();
        }


        /// <summary>
        /// Load BankTransfers entities from the database using the primary key
        /// </summary
        /// <param name="bankTransferId">int</param>
        /// <returns>IBankTransfers</returns>
		public IBankTransfers LoadByBankTransfersBankTransferId(int bankTransferId)
        {
            return this.BankTransfersRepository.LoadByBankTransferId(bankTransferId);
        }


        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
        /// <returns>IList<IBankTransfers></returns>
		public IList<IBankTransfers> BankTransfersLoadAll()
        {
            return this.BankTransfersRepository.LoadAll();
        }


        /// <summary>
        /// Load Book entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IBook</returns>
		public IBook LoadByBookProductId(int productId)
        {
            return this.BookRepository.LoadByProductId(productId);
        }


        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <returns>IList<IBook></returns>
		public IList<IBook> BookLoadAll()
        {
            return this.BookRepository.LoadAll();
        }


        /// <summary>
        /// Load Country entities from the database using the primary key
        /// </summary
        /// <param name="countryId">int</param>
        /// <returns>ICountry</returns>
		public ICountry LoadByCountryCountryId(int countryId)
        {
            return this.CountryRepository.LoadByCountryId(countryId);
        }


        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountryLoadAll()
        {
            return this.CountryRepository.LoadAll();
        }


        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
		public ICustomer LoadByCustomerCustomerId(int customerId)
        {
            return this.CustomerRepository.LoadByCustomerId(customerId);
        }


        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerLoadAll()
        {
            return this.CustomerRepository.LoadAll();
        }


        /// <summary>
        /// Load Order entities from the database using the primary key
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>IOrder</returns>
		public IOrder LoadByOrderOrderId(int orderId)
        {
            return this.OrderRepository.LoadByOrderId(orderId);
        }


        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderLoadAll()
        {
            return this.OrderRepository.LoadAll();
        }


        /// <summary>
        /// Load OrderDetails entities from the database using the primary key
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <returns>IOrderDetails</returns>
		public IOrderDetails LoadByOrderDetailsOrderDetailsId(int orderDetailsId)
        {
            return this.OrderDetailsRepository.LoadByOrderDetailsId(orderDetailsId);
        }


        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <returns>IList<IOrderDetails></returns>
		public IList<IOrderDetails> OrderDetailsLoadAll()
        {
            return this.OrderDetailsRepository.LoadAll();
        }


        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>IProduct</returns>
		public IProduct LoadByProductProductId(int productId)
        {
            return this.ProductRepository.LoadByProductId(productId);
        }


        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductLoadAll()
        {
            return this.ProductRepository.LoadAll();
        }


        /// <summary>
        /// Load Software entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <returns>ISoftware</returns>
		public ISoftware LoadBySoftwareProductId(int productId)
        {
            return this.SoftwareRepository.LoadByProductId(productId);
        }


        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> SoftwareLoadAll()
        {
            return this.SoftwareRepository.LoadAll();
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBankAccount></returns>
		public IList<IBankAccount> BankAccountSearchByBankAccountNumber(string bankAccountNumber, bool caseSensitive = false)
        {
            return this.BankAccountRepository.SearchByBankAccountNumber(bankAccountNumber,caseSensitive);
        }


        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBook></returns>
		public IList<IBook> BookSearchByPublisher(string publisher, bool caseSensitive = false)
        {
            return this.BookRepository.SearchByPublisher(publisher,caseSensitive);
        }


        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountry></returns>
		public IList<ICountry> CountrySearchByCountryName(string countryName, bool caseSensitive = false)
        {
            return this.CountryRepository.SearchByCountryName(countryName,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByCustomerCode(customerCode,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCompanyName(string companyName, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByCompanyName(companyName,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactName(string contactName, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByContactName(contactName,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByContactTitle(contactTitle,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByAddress(string address, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByAddress(address,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCity(string city, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByCity(city,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPostalCode(string postalCode, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByPostalCode(postalCode,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByTelephone(string telephone, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByTelephone(telephone,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByFax(string fax, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByFax(fax,caseSensitive);
        }


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPhoto(string photo, bool caseSensitive = false)
        {
            return this.CustomerRepository.SearchByPhoto(photo,caseSensitive);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingName(string shippingName, bool caseSensitive = false)
        {
            return this.OrderRepository.SearchByShippingName(shippingName,caseSensitive);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingAddress(string shippingAddress, bool caseSensitive = false)
        {
            return this.OrderRepository.SearchByShippingAddress(shippingAddress,caseSensitive);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingCity(string shippingCity, bool caseSensitive = false)
        {
            return this.OrderRepository.SearchByShippingCity(shippingCity,caseSensitive);
        }


        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		public IList<IOrder> OrderSearchByShippingZip(string shippingZip, bool caseSensitive = false)
        {
            return this.OrderRepository.SearchByShippingZip(shippingZip,caseSensitive);
        }


        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByProductDescription(string productDescription, bool caseSensitive = false)
        {
            return this.ProductRepository.SearchByProductDescription(productDescription,caseSensitive);
        }


        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByUnitAmount(string unitAmount, bool caseSensitive = false)
        {
            return this.ProductRepository.SearchByUnitAmount(unitAmount,caseSensitive);
        }


        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		public IList<IProduct> ProductSearchByPublisher(string publisher, bool caseSensitive = false)
        {
            return this.ProductRepository.SearchByPublisher(publisher,caseSensitive);
        }


        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISoftware></returns>
		public IList<ISoftware> SoftwareSearchByLicenseCode(string licenseCode, bool caseSensitive = false)
        {
            return this.SoftwareRepository.SearchByLicenseCode(licenseCode,caseSensitive);
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		public bool BankAccountSave(IBankAccount entity)
        {
            return this.BankAccountRepository.Save(entity);
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
        /// Save the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		public bool BankTransfersSave(IBankTransfers entity)
        {
            return this.BankTransfersRepository.Save(entity);
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
        /// Save the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		public bool BookSave(IBook entity)
        {
            return this.BookRepository.Save(entity);
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
        /// Save the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		public bool CountrySave(ICountry entity)
        {
            return this.CountryRepository.Save(entity);
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
        /// Save the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerSave(ICustomer entity)
        {
            return this.CustomerRepository.Save(entity);
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
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		public bool OrderSave(IOrder entity)
        {
            return this.OrderRepository.Save(entity);
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
        /// Save the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		public bool OrderDetailsSave(IOrderDetails entity)
        {
            return this.OrderDetailsRepository.Save(entity);
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
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		public bool ProductSave(IProduct entity)
        {
            return this.ProductRepository.Save(entity);
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
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		public bool SoftwareSave(ISoftware entity)
        {
            return this.SoftwareRepository.Save(entity);
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

    }
}

