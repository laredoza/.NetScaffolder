
// <copyright file="AllowedScope.g.cs" company="MIT">
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
	/// The AllowedScopeRepository interface that defines database functions for the AllowedScope table
	/// </summary>
	public partial interface IAllowedScopeRepository : IRepository<AllowedScope>
	{
		#region Load

        /// <summary>
        /// Load AllowedScope entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScope</returns>
		AllowedScope LoadById(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);
		
        /// <summary>
        /// Load AllowedScope entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScope</returns>
		Task<AllowedScope> LoadByIdAsync(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);

        /// <summary>
        /// Load AllowedScope entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		IList<AllowedScope> LoadByClientId(int clientId, bool cache,  params Expression<Func<IAllowedScope, object>>[] includes);
		
        /// <summary>
        /// Load AllowedScope entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		Task<IList<AllowedScope>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);

        /// <summary>
        /// Load all AllowedScope entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		IList<AllowedScope> LoadAll( bool cache, params Expression<Func<IAllowedScope, object>>[] includes);
		
        /// <summary>
        /// Load all AllowedScope entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		Task<IList<AllowedScope>> LoadAllAsync(bool cache, params Expression<Func<IAllowedScope, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AllowedScope entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		IList<AllowedScope> SearchByResourceName(string resourceName, bool cache, bool caseSensitive = false, params Expression<Func<IAllowedScope, object>>[] includes);
		
        /// <summary>
        /// Search for AllowedScope entities async in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScope></returns>
		Task<IList<AllowedScope>> SearchByResourceNameAsync(string resourceName, bool cache, bool caseSensitive = false, params Expression<Func<IAllowedScope, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AllowedScope entity to the database.
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		bool Add(AllowedScope entity);
		
        /// <summary>
        /// Add the AllowedScope entity async to the database.
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AllowedScope entity);

        /// <summary>
        /// Update the AllowedScope entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		bool Update(AllowedScope entity);
		
        /// <summary>
        /// Update the AllowedScope entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AllowedScope entity);
		
        /// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		bool Delete(AllowedScope entity);
		
        /// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="entity">AllowedScope</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AllowedScope entity);

		/// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AllowedScope> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AllowedScope> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AllowedScope> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AllowedScope> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AllowedScope> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AllowedScope> items);

        #endregion
	}
}
