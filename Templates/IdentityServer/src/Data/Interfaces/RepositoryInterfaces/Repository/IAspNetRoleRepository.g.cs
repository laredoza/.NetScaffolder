
// <copyright file="AspNetRole.g.cs" company="MIT">
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
	/// The AspNetRoleRepository interface that defines database functions for the AspNetRole table
	/// </summary>
	public partial interface IAspNetRoleRepository : IRepository<AspNetRole>
	{
		#region Load

        /// <summary>
        /// Load AspNetRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRole</returns>
		AspNetRole LoadById(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);
		
        /// <summary>
        /// Load AspNetRole entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRole</returns>
		Task<AspNetRole> LoadByIdAsync(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Load all AspNetRole entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		IList<AspNetRole> LoadAll( bool cache, params Expression<Func<IAspNetRole, object>>[] includes);
		
        /// <summary>
        /// Load all AspNetRole entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		Task<IList<AspNetRole>> LoadAllAsync(bool cache, params Expression<Func<IAspNetRole, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetRole entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		IList<AspNetRole> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		Task<IList<AspNetRole>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Search for AspNetRole entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		IList<AspNetRole> SearchByNormalizedName(string normalizedName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		Task<IList<AspNetRole>> SearchByNormalizedNameAsync(string normalizedName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Search for AspNetRole entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		IList<AspNetRole> SearchByConcurrencyStamp(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetRole entities async in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRole></returns>
		Task<IList<AspNetRole>> SearchByConcurrencyStampAsync(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetRole, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		bool Add(AspNetRole entity);
		
        /// <summary>
        /// Add the AspNetRole entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AspNetRole entity);

        /// <summary>
        /// Update the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		bool Update(AspNetRole entity);
		
        /// <summary>
        /// Update the AspNetRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AspNetRole entity);
		
        /// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		bool Delete(AspNetRole entity);
		
        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="entity">AspNetRole</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AspNetRole entity);

		/// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		bool Delete( string id, bool cache);

		/// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="id">string, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( string id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AspNetRole> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AspNetRole> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AspNetRole> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AspNetRole> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AspNetRole> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AspNetRole> items);

        #endregion
	}
}
