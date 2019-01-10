
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


        #endregion

        #region Search

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

		#endregion

		#region Modifiers
		
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

        #endregion
    }
}

