
// <copyright file="AspNetRoleClaim.g.cs" company="MIT">
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
	/// The AspNetRoleClaimRepository interface that defines database functions for the AspNetRoleClaim table
	/// </summary>
	public partial interface IAspNetRoleClaimRepository : IRepository<AspNetRoleClaim>
	{
		#region Load

        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaim</returns>
		AspNetRoleClaim LoadById(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
        /// <summary>
        /// Load AspNetRoleClaim entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaim</returns>
		Task<AspNetRoleClaim> LoadByIdAsync(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Load all AspNetRoleClaim entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		IList<AspNetRoleClaim> LoadAll( bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
        /// <summary>
        /// Load all AspNetRoleClaim entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		Task<IList<AspNetRoleClaim>> LoadAllAsync(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		IList<AspNetRoleClaim> SearchByRoleId(string roleId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRoleClaim entities async in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		Task<IList<AspNetRoleClaim>> SearchByRoleIdAsync(string roleId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		IList<AspNetRoleClaim> SearchByClaimType(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRoleClaim entities async in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		Task<IList<AspNetRoleClaim>> SearchByClaimTypeAsync(string claimType, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		IList<AspNetRoleClaim> SearchByClaimValue(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRoleClaim entities async in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaim></returns>
		Task<IList<AspNetRoleClaim>> SearchByClaimValueAsync(string claimValue, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetRoleClaim entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		bool Add(AspNetRoleClaim entity);
		
        /// <summary>
        /// Add the AspNetRoleClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AspNetRoleClaim entity);

        /// <summary>
        /// Update the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		bool Update(AspNetRoleClaim entity);
		
        /// <summary>
        /// Update the AspNetRoleClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AspNetRoleClaim entity);
		
        /// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		bool Delete(AspNetRoleClaim entity);
		
        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaim</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AspNetRoleClaim entity);

		/// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AspNetRoleClaim> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AspNetRoleClaim> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AspNetRoleClaim> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AspNetRoleClaim> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AspNetRoleClaim> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AspNetRoleClaim> items);

        #endregion
	}
}
