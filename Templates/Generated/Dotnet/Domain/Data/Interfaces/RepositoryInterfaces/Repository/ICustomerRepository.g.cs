﻿
// <copyright file="Customer.g.cs" company="MIT">
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
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces
{
	/// <summary>
	/// The CustomerRepository interface that defines database functions for the Customer table
	/// </summary>
	public partial interface ICustomerRepository : IRepository<Customer>
	{
		#region Load

        /// <summary>
        /// Load Customer entities from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>Customer</returns>
		Customer LoadByCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>Customer</returns>
		Task<Customer> LoadByCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> LoadByCountryId(Nullable<int> countryId, bool cache,  params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> LoadByCountryIdAsync(Nullable<int> countryId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> LoadByIsEnabled(bool isEnabled, bool cache,  params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> LoadByIsEnabledAsync(bool isEnabled, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> LoadAll( bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load all Customer entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<Customer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> LoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByCustomerCode(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByCustomerCodeAsync(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByCompanyName(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByCompanyNameAsync(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByContactName(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByContactNameAsync(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByContactTitle(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByContactTitleAsync(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByAddress(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Address
        /// </summary>
        /// <param name="address">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByAddressAsync(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByCity(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by City
        /// </summary>
        /// <param name="city">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByCityAsync(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByPostalCode(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByPostalCodeAsync(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByTelephone(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByTelephoneAsync(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByFax(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByFaxAsync(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		IList<Customer> SearchByPhoto(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<Customer></returns>
		Task<IList<Customer>> SearchByPhotoAsync(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Add(Customer entity);
		
        /// <summary>
        /// Add the Customer entity async to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(Customer entity);

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Customer</param>
        /// <returns>bool</returns>
		bool Update(Customer entity);
		
        /// <summary>
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Customer</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(Customer entity);
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">Customer</param>
        /// <returns>bool</returns>
		bool Delete(Customer entity);
		
        /// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">Customer</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(Customer entity);

		/// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="customerId">int</param>
        /// <returns>bool</returns>
		bool Delete( int customerId, bool cache);

		/// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="customerId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int customerId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<ICustomer, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<Customer> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<Customer> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<Customer> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<Customer> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<Customer> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<Customer> items);

        #endregion
	}
}
