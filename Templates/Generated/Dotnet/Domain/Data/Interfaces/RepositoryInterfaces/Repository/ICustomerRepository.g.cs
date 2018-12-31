
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
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces
{
	/// <summary>
	/// The CustomerRepository interface that defines database functions for the Customer table
	/// </summary>
	public partial interface ICustomerRepository : IRepository<ICustomer>
	{
		#region Load

        /// <summary>
        /// Load Customer entities from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		ICustomer LoadByCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the composite primary keys
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		Task<ICustomer> LoadByCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadByCountryId(Nullable<int> countryId, bool cache,  params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the CountryId field
        /// </summary>
        /// <param name="countryId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> LoadByCountryIdAsync(Nullable<int> countryId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer entities from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadByIsEnabled(bool isEnabled, bool cache,  params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load Customer entities async from the database using the IsEnabled field
        /// </summary>
        /// <param name="isEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> LoadByIsEnabledAsync(bool isEnabled, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> LoadAll( bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Load all Customer entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> LoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCustomerCode(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByCustomerCodeAsync(string customerCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCompanyName(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByCompanyNameAsync(string companyName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByContactName(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByContactNameAsync(string contactName, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByContactTitle(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByContactTitleAsync(string contactTitle, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByAddress(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Address
        /// </summary>
        /// <param name="address">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByAddressAsync(string address, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByCity(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by City
        /// </summary>
        /// <param name="city">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByCityAsync(string city, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByPostalCode(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByPostalCodeAsync(string postalCode, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByTelephone(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByTelephoneAsync(string telephone, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByFax(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByFaxAsync(string fax, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> SearchByPhoto(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);
		
        /// <summary>
        /// Search for Customer entities async in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> SearchByPhotoAsync(string photo, bool cache, bool caseSensitive = false, params Expression<Func<ICustomer, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Customer entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Add(ICustomer entity);
		
        /// <summary>
        /// Add the Customer entity async to the database.
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ICustomer entity);

        /// <summary>
        /// Update the Customer entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Update(ICustomer entity);
		
        /// <summary>
        /// Update the Customer entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ICustomer entity);
		
        /// <summary>
        /// Delete the Customer entity from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		bool Delete(ICustomer entity);
		
        /// <summary>
        /// Delete the Customer entity async from the database
        /// </summary>
        /// <param name="entity">ICustomer</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ICustomer entity);

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
        void BulkDelete(IEnumerable<ICustomer> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ICustomer> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ICustomer> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ICustomer> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ICustomer> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ICustomer> items);

        #endregion
	}
}
