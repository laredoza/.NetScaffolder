
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
	/// The CustomerApplication Service interface that defines database functions for the Customer application service
	/// </summary>
	public partial interface ICustomerApplicationService 
	{

        #region Load

        /// <summary>
        /// Load Customer entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		ICustomer LoadByCustomerCustomerId(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Load Customer Async entities from the database using the primary key
        /// </summary
        /// <param name="customerId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>ICustomer</returns>
		Task<ICustomer> LoadByCustomerCustomerIdAsync(int customerId, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load all Customer entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerLoadAll(bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Load all Customer Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerLoadAllAsync(bool cache, params Expression<Func<ICustomer, object>>[] includes);


        #endregion

        #region Search

        /// <summary>
        /// Search for Customer entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCustomerCode(string customerCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CustomerCode
        /// </summary>
        /// <param name="customerCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCustomerCodeAsync(string customerCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCompanyName(string companyName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by CompanyName
        /// </summary>
        /// <param name="companyName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCompanyNameAsync(string companyName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByContactName(string contactName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactName
        /// </summary>
        /// <param name="contactName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByContactNameAsync(string contactName,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByContactTitle(string contactTitle,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by ContactTitle
        /// </summary>
        /// <param name="contactTitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByContactTitleAsync(string contactTitle,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByAddress(string address,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Address
        /// </summary>
        /// <param name="address">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByAddressAsync(string address,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByCity(string city,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByCityAsync(string city,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByPostalCode(string postalCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by PostalCode
        /// </summary>
        /// <param name="postalCode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByPostalCodeAsync(string postalCode,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByTelephone(string telephone,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Telephone
        /// </summary>
        /// <param name="telephone">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByTelephoneAsync(string telephone,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByFax(string fax,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Fax
        /// </summary>
        /// <param name="fax">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByFaxAsync(string fax,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);


        /// <summary>
        /// Search for Customer entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		IList<ICustomer> CustomerSearchByPhoto(string photo,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

        /// <summary>
        /// Search for Customer  Async entities in the database by Photo
        /// </summary>
        /// <param name="photo">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<ICustomer, object>>[]</param>
        /// <returns>IList<ICustomer></returns>
		Task<IList<ICustomer>> CustomerSearchByPhotoAsync(string photo,bool caseSensitive, bool cache, params Expression<Func<ICustomer, object>>[] includes);

		#endregion

		#region Modifiers
		
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
		bool CustomerDelete( int customerId, bool cache);

		#endregion

        #region Aggregates

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

		#endregion

        #region Bulk
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkDelete(IEnumerable<ICustomer> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkDeleteAsync(IEnumerable<ICustomer> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkInsert(IEnumerable<ICustomer> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkInsertAsync(IEnumerable<ICustomer> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  CustomerBulkUpdate(IEnumerable<ICustomer> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  CustomerBulkUpdateAsync(IEnumerable<ICustomer> items);

        #endregion
    }
}

