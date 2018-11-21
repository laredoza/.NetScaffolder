
// <copyright file="BankTransfers.g.cs" company="MIT">
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
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Interfaces
{
	/// <summary>
	/// The BankTransfersRepository interface that defines database functions for the BankTransfers table
	/// </summary>
	public partial interface IBankTransfersRepository : IRepository<IBankTransfers>
	{
		#region Load

        /// <summary>
        /// Load BankTransfers entities from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		IBankTransfers LoadByBankTransferId(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the composite primary keys
        /// </summary
        /// <param name="bankTransferId">int</param>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IBankTransfers</returns>
		Task<IBankTransfers> LoadByBankTransferIdAsync(int bankTransferId, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers entities from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByFromBankAccountId(int fromBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the FromBankAccountId field
        /// </summary>
        /// <param name="fromBankAccountId">int</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> LoadByFromBankAccountIdAsync(int fromBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers entities from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByToBankAccountId(int toBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the ToBankAccountId field
        /// </summary>
        /// <param name="toBankAccountId">int</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> LoadByToBankAccountIdAsync(int toBankAccountId, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByAmount(decimal amount, params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">decimal</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> LoadByAmountAsync(decimal amount, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load BankTransfers entities from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadByTransferDate(DateTime transferDate, params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load BankTransfers entities async from the database using the TransferDate field
        /// </summary>
        /// <param name="transferDate">DateTime</param
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> LoadByTransferDateAsync(DateTime transferDate, params Expression<Func<IBankTransfers, object>>[] includes);

        /// <summary>
        /// Load all BankTransfers entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		IList<IBankTransfers> LoadAll(params Expression<Func<IBankTransfers, object>>[] includes);
		
        /// <summary>
        /// Load all BankTransfers entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBankTransfers, object>>[]</param>
        /// <returns>IList<IBankTransfers></returns>
		Task<IList<IBankTransfers>> LoadAllAsync(params Expression<Func<IBankTransfers, object>>[] includes);
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the BankTransfers entity to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Add(IBankTransfers entity);
		
        /// <summary>
        /// Add the BankTransfers entity async to the database.
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(IBankTransfers entity);

        /// <summary>
        /// Update the BankTransfers entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Update(IBankTransfers entity);
		
        /// <summary>
        /// Update the BankTransfers entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(IBankTransfers entity);
		
        /// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		bool Delete(IBankTransfers entity);
		
        /// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="entity">IBankTransfers</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(IBankTransfers entity);

		/// <summary>
        /// Delete the BankTransfers entity from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		bool Delete( int bankTransferId);

		/// <summary>
        /// Delete the BankTransfers entity async from the database
        /// </summary>
        /// <param name="bankTransferId">int</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int bankTransferId);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
		TResult Min<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IBankTransfers, TResult>> maxExpression);
		
		#endregion
	}
}
