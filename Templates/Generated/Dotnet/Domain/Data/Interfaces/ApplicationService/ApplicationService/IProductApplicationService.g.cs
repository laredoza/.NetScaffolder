
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
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		Task<bool> BankAccountDeleteAsync( int bankAccountId, bool cache);


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

        #endregion
    }
}

