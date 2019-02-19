
// <copyright file="ApiResource.g.cs" company="MIT">
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
	/// The ApiResourceRepository interface that defines database functions for the ApiResource table
	/// </summary>
	public partial interface IApiResourceRepository : IRepository<ApiResource>
	{
		#region Load

        /// <summary>
        /// Load ApiResource entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResource</returns>
		ApiResource LoadById(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes);
		
        /// <summary>
        /// Load ApiResource entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResource</returns>
		Task<ApiResource> LoadByIdAsync(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes);

        /// <summary>
        /// Load all ApiResource entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		IList<ApiResource> LoadAll( bool cache, params Expression<Func<IApiResource, object>>[] includes);
		
        /// <summary>
        /// Load all ApiResource entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		Task<IList<ApiResource>> LoadAllAsync(bool cache, params Expression<Func<IApiResource, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ApiResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		IList<ApiResource> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes);
		
        /// <summary>
        /// Search for ApiResource entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		Task<IList<ApiResource>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes);

        /// <summary>
        /// Search for ApiResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		IList<ApiResource> SearchByDisplayName(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes);
		
        /// <summary>
        /// Search for ApiResource entities async in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResource></returns>
		Task<IList<ApiResource>> SearchByDisplayNameAsync(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IApiResource, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ApiResource entity to the database.
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		bool Add(ApiResource entity);
		
        /// <summary>
        /// Add the ApiResource entity async to the database.
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ApiResource entity);

        /// <summary>
        /// Update the ApiResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		bool Update(ApiResource entity);
		
        /// <summary>
        /// Update the ApiResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ApiResource entity);
		
        /// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		bool Delete(ApiResource entity);
		
        /// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="entity">ApiResource</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ApiResource entity);

		/// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<ApiResource> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ApiResource> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ApiResource> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ApiResource> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ApiResource> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ApiResource> items);

        #endregion
	}
}
