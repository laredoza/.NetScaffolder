
// <copyright file="AspNetUserClaim.g.cs" company="MIT">
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
	/// The AspNetUserClaimRepository interface that defines database functions for the AspNetUserClaim table
	/// </summary>
	public partial interface IAspNetUserClaimRepository : IRepository<AspNetUserClaim>
	{
		#region Load

        /// <summary>
        /// Load AspNetUserClaim entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaim</returns>
		AspNetUserClaim LoadById(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUserClaim entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaim</returns>
		Task<AspNetUserClaim> LoadByIdAsync(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Load all AspNetUserClaim entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		IList<AspNetUserClaim> LoadAll( bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
        /// <summary>
        /// Load all AspNetUserClaim entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		Task<IList<AspNetUserClaim>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUserClaim entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		IList<AspNetUserClaim> SearchByUserId(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUserClaim entities async in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		Task<IList<AspNetUserClaim>> SearchByUserIdAsync(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		IList<AspNetUserClaim> SearchByClaimType(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUserClaim entities async in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		Task<IList<AspNetUserClaim>> SearchByClaimTypeAsync(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		IList<AspNetUserClaim> SearchByClaimValue(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUserClaim entities async in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaim></returns>
		Task<IList<AspNetUserClaim>> SearchByClaimValueAsync(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserClaim, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserClaim entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		bool Add(AspNetUserClaim entity);
		
        /// <summary>
        /// Add the AspNetUserClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AspNetUserClaim entity);

        /// <summary>
        /// Update the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		bool Update(AspNetUserClaim entity);
		
        /// <summary>
        /// Update the AspNetUserClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AspNetUserClaim entity);
		
        /// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		bool Delete(AspNetUserClaim entity);
		
        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaim</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AspNetUserClaim entity);

		/// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AspNetUserClaim> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AspNetUserClaim> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AspNetUserClaim> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AspNetUserClaim> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AspNetUserClaim> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AspNetUserClaim> items);

        #endregion
	}
}
