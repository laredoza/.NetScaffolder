
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
	/// The CustomerApplication Service 
	/// </summary>
	public partial class CustomerApplicationService  : ICustomerApplicationService
	{

        /// <summary>
        /// Gets or sets the Customer Repository 
        /// </summary>
        protected ICustomerRepository CustomerRepository { get; set; }

        public CustomerApplicationService (
                      ICustomerRepository customerRepository
                                     )
        {
            this.CustomerRepository = customerRepository;
        }

        #region Load

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


        #endregion

        #region Search

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

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public bool CustomerAdd(CustomerDto entity)
        {
            return this.CustomerRepository.Add(new Customer(entity, true));
        }

        /// <summary>
        /// Add the Customer entity async to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public async Task<bool> CustomerAddAsync(CustomerDto entity)
        {
            return await this.CustomerRepository.AddAsync(new Customer(entity, true));
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
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public async Task<bool> CustomerUpdateAsync(CustomerDto entity)
        {
            return await this.CustomerRepository.UpdateAsync(new Customer(entity, true));
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
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		public async Task<bool> CustomerDeleteAsync(CustomerDto entity)
        {
            return await this.CustomerRepository.DeleteAsync(new Customer(entity, true));
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
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		public async Task<bool> CustomerDeleteAsync( int customerId, bool cache)
        {
            return await this.CustomerRepository.DeleteAsync( customerId, cache);
        }


		#endregion

        #region Aggregates
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

		#endregion

		#region Bulk

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

        #endregion

    }
}

