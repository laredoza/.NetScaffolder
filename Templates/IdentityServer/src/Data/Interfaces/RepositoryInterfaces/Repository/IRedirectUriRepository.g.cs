
// <copyright file="RedirectUri.g.cs" company="MIT">
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
	/// The RedirectUriRepository interface that defines database functions for the RedirectUri table
	/// </summary>
	public partial interface IRedirectUriRepository : IRepository<RedirectUri>
	{
		#region Load

        /// <summary>
        /// Load RedirectUri entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUri</returns>
		RedirectUri LoadById(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);
		
        /// <summary>
        /// Load RedirectUri entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUri</returns>
		Task<RedirectUri> LoadByIdAsync(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);

        /// <summary>
        /// Load RedirectUri entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		IList<RedirectUri> LoadByClientId(int clientId, bool cache,  params Expression<Func<IRedirectUri, object>>[] includes);
		
        /// <summary>
        /// Load RedirectUri entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		Task<IList<RedirectUri>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);

        /// <summary>
        /// Load all RedirectUri entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		IList<RedirectUri> LoadAll( bool cache, params Expression<Func<IRedirectUri, object>>[] includes);
		
        /// <summary>
        /// Load all RedirectUri entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<RedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		Task<IList<RedirectUri>> LoadAllAsync(bool cache, params Expression<Func<IRedirectUri, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for RedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		IList<RedirectUri> SearchByUri(string uri, bool cache, bool caseSensitive = false, params Expression<Func<IRedirectUri, object>>[] includes);
		
        /// <summary>
        /// Search for RedirectUri entities async in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUri></returns>
		Task<IList<RedirectUri>> SearchByUriAsync(string uri, bool cache, bool caseSensitive = false, params Expression<Func<IRedirectUri, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the RedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		bool Add(RedirectUri entity);
		
        /// <summary>
        /// Add the RedirectUri entity async to the database.
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(RedirectUri entity);

        /// <summary>
        /// Update the RedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		bool Update(RedirectUri entity);
		
        /// <summary>
        /// Update the RedirectUri entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(RedirectUri entity);
		
        /// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		bool Delete(RedirectUri entity);
		
        /// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="entity">RedirectUri</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(RedirectUri entity);

		/// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<RedirectUri> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<RedirectUri> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<RedirectUri> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<RedirectUri> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<RedirectUri> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<RedirectUri> items);

        #endregion
	}
}
