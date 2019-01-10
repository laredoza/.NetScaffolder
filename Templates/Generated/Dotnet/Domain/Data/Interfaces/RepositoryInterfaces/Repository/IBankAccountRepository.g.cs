
// <copyright file="BankAccount.g.cs" company="MIT">
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
	/// The BankAccountRepository interface that defines database functions for the BankAccount table
	/// </summary>
	public partial interface IBankAccountRepository : IRepository<BankAccount>
	{
		#region Load

        /// <summary>
        /// Load BankAccount entities from the database using the composite primary keys
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>BankAccount</returns>
		BankAccount LoadByBankAccountId(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Load BankAccount entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankAccountId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>BankAccount</returns>
		Task<BankAccount> LoadByBankAccountIdAsync(int bankAccountId, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load BankAccount entities from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		IList<BankAccount> LoadByBalance(decimal balance, bool cache,  params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Load BankAccount entities async from the database using the Balance field
        /// </summary>
        /// <param name="balance">decimal</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		Task<IList<BankAccount>> LoadByBalanceAsync(decimal balance, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load BankAccount entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		IList<BankAccount> LoadByCustomerId(Nullable<int> customerId, bool cache,  params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Load BankAccount entities async from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		Task<IList<BankAccount>> LoadByCustomerIdAsync(Nullable<int> customerId, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load BankAccount entities from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		IList<BankAccount> LoadByLocked(bool locked, bool cache,  params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Load BankAccount entities async from the database using the Locked field
        /// </summary>
        /// <param name="locked">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		Task<IList<BankAccount>> LoadByLockedAsync(bool locked, bool cache, params Expression<Func<IBankAccount, object>>[] includes);

        /// <summary>
        /// Load all BankAccount entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		IList<BankAccount> LoadAll( bool cache, params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Load all BankAccount entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<BankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		Task<IList<BankAccount>> LoadAllAsync(bool cache, params Expression<Func<IBankAccount, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for BankAccount entities in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		IList<BankAccount> SearchByBankAccountNumber(string bankAccountNumber, bool cache, bool caseSensitive = false, params Expression<Func<IBankAccount, object>>[] includes);
		
        /// <summary>
        /// Search for BankAccount entities async in the database by BankAccountNumber
        /// </summary>
        /// <param name="bankAccountNumber">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBankAccount, object>>[]</param>
        /// <returns>IList<BankAccount></returns>
		Task<IList<BankAccount>> SearchByBankAccountNumberAsync(string bankAccountNumber, bool cache, bool caseSensitive = false, params Expression<Func<IBankAccount, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the BankAccount entity to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		bool Add(BankAccount entity);
		
        /// <summary>
        /// Add the BankAccount entity async to the database.
        /// </summary>
        /// <param name="entity">IBankAccount</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(BankAccount entity);

        /// <summary>
        /// Update the BankAccount entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccount</param>
        /// <returns>bool</returns>
		bool Update(BankAccount entity);
		
        /// <summary>
        /// Update the BankAccount entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">BankAccount</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(BankAccount entity);
		
        /// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="entity">BankAccount</param>
        /// <returns>bool</returns>
		bool Delete(BankAccount entity);
		
        /// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="entity">BankAccount</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(BankAccount entity);

		/// <summary>
        /// Delete the BankAccount entity from the database
        /// </summary>
        /// <param name="bankAccountId">int</param>
        /// <returns>bool</returns>
		bool Delete( int bankAccountId, bool cache);

		/// <summary>
        /// Delete the BankAccount entity async from the database
        /// </summary>
        /// <param name="bankAccountId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int bankAccountId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IBankAccount, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<BankAccount> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<BankAccount> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<BankAccount> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<BankAccount> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<BankAccount> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<BankAccount> items);

        #endregion
	}
}
