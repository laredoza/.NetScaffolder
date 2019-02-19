
// <copyright file="ResourceClaimType.g.cs" company="MIT">
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
	/// The ResourceClaimTypeRepository interface that defines database functions for the ResourceClaimType table
	/// </summary>
	public partial interface IResourceClaimTypeRepository : IRepository<ResourceClaimType>
	{
		#region Load

        /// <summary>
        /// Load ResourceClaimType entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimType</returns>
		ResourceClaimType LoadById(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);
		
        /// <summary>
        /// Load ResourceClaimType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimType</returns>
		Task<ResourceClaimType> LoadByIdAsync(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);

        /// <summary>
        /// Load all ResourceClaimType entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		IList<ResourceClaimType> LoadAll( bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);
		
        /// <summary>
        /// Load all ResourceClaimType entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		Task<IList<ResourceClaimType>> LoadAllAsync(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ResourceClaimType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		IList<ResourceClaimType> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IResourceClaimType, object>>[] includes);
		
        /// <summary>
        /// Search for ResourceClaimType entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimType></returns>
		Task<IList<ResourceClaimType>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IResourceClaimType, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		bool Add(ResourceClaimType entity);
		
        /// <summary>
        /// Add the ResourceClaimType entity async to the database.
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ResourceClaimType entity);

        /// <summary>
        /// Update the ResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		bool Update(ResourceClaimType entity);
		
        /// <summary>
        /// Update the ResourceClaimType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ResourceClaimType entity);
		
        /// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		bool Delete(ResourceClaimType entity);
		
        /// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="entity">ResourceClaimType</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ResourceClaimType entity);

		/// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<ResourceClaimType> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ResourceClaimType> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ResourceClaimType> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ResourceClaimType> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ResourceClaimType> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ResourceClaimType> items);

        #endregion
	}
}
