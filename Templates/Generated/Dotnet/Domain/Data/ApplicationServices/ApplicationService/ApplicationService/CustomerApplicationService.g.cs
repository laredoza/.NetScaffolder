
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
        /// <returns>ICustomer</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public ICustomer LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadByCustomerId(customerId, cache, includes);
        }

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <returns>ICustomer</returns>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
		public async Task<ICustomer> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.LoadByCustomerIdAsync(customerId, cache, includes);
        }

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadAll(cache, includes);
        }

        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public Task<IList<ICustomer>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.LoadAllAsync(cache, includes);
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCustomerCode(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCustomerCode(customerCode,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCustomerCodeAsync(string customerCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCustomerCodeAsync(customerCode,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCompanyName(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCompanyName(companyName,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCompanyNameAsync(string companyName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCompanyNameAsync(companyName,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactName(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByContactName(contactName,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByContactNameAsync(string contactName, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByContactNameAsync(contactName,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByContactTitle(string contactTitle, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByContactTitle(contactTitle,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByContactTitleAsync(string contactTitle, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByContactTitleAsync(contactTitle,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByAddress(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByAddress(address,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByAddressAsync(string address, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByAddressAsync(address,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByCity(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByCity(city,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByCityAsync(string city, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByCityAsync(city,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPostalCode(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByPostalCode(postalCode,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByPostalCodeAsync(string postalCode, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByPostalCodeAsync(postalCode,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByTelephone(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByTelephone(telephone,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByTelephoneAsync(string telephone, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByTelephoneAsync(telephone,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByFax(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByFax(fax,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByFaxAsync(string fax, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByFaxAsync(fax,caseSensitive, cache, includes);
        }


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public IList<ICustomer> CustomerSearchByPhoto(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return this.CustomerRepository.SearchByPhoto(photo,caseSensitive, cache, includes);
        }

        /// <summary>
        /// Search for Customer Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		public async Task<IList<ICustomer>> CustomerSearchByPhotoAsync(string photo, bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes)
        {
            return await this.CustomerRepository.SearchByPhotoAsync(photo,caseSensitive, cache, includes);
        }

		#endregion

		#region Modifiers
		
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
		public bool CustomerDelete( int customerId, bool cache)
        {
            return this.CustomerRepository.Delete( customerId, cache);
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
        /// <param name="maxExpression">Expression<Func<ICustomer, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> CustomerMinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache)
        {
		    return await this.CustomerRepository.MinAsync(maxExpression, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void CustomerBulkDelete(IEnumerable<ICustomer> items)
		{
			this.CustomerRepository.BulkDelete(items);
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CustomerBulkDeleteAsync(IEnumerable<ICustomer> items)
		{
			await this.CustomerRepository.BulkDeleteAsync(items);
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  CustomerBulkInsert(IEnumerable<ICustomer> items)
		{
			this.CustomerRepository.BulkInsert(items);
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CustomerBulkInsertAsync(IEnumerable<ICustomer> items)
		{
			await this.CustomerRepository.BulkInsertAsync(items);
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  CustomerBulkUpdate(IEnumerable<ICustomer> items)
		{
			this.CustomerRepository.BulkUpdate(items);
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  CustomerBulkUpdateAsync(IEnumerable<ICustomer> items)
		{
			await this.CustomerRepository.BulkUpdateAsync(items);
		}

        #endregion

    }
}

