
// <copyright file="IdentityResource.g.cs" company="MIT">
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
	/// The IdentityResourceRepository interface that defines database functions for the IdentityResource table
	/// </summary>
	public partial interface IIdentityResourceRepository : IRepository<IdentityResource>
	{
		#region Load

        /// <summary>
        /// Load IdentityResource entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResource</returns>
		IdentityResource LoadById(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResource</returns>
		Task<IdentityResource> LoadByIdAsync(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load IdentityResource entities from the database using the ShowInDiscoveryDocument field
        /// </summary>
        /// <param name="showInDiscoveryDocument">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> LoadByShowInDiscoveryDocument(bool showInDiscoveryDocument, bool cache,  params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the ShowInDiscoveryDocument field
        /// </summary>
        /// <param name="showInDiscoveryDocument">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> LoadByShowInDiscoveryDocumentAsync(bool showInDiscoveryDocument, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load IdentityResource entities from the database using the Required field
        /// </summary>
        /// <param name="required">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> LoadByRequired(bool required, bool cache,  params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the Required field
        /// </summary>
        /// <param name="required">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> LoadByRequiredAsync(bool required, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load IdentityResource entities from the database using the Emphasize field
        /// </summary>
        /// <param name="emphasize">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> LoadByEmphasize(bool emphasize, bool cache,  params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Load IdentityResource entities async from the database using the Emphasize field
        /// </summary>
        /// <param name="emphasize">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> LoadByEmphasizeAsync(bool emphasize, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load all IdentityResource entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> LoadAll( bool cache, params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Load all IdentityResource entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> LoadAllAsync(bool cache, params Expression<Func<IIdentityResource, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for IdentityResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> SearchByName(string name, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Search for IdentityResource entities async in the database by Name
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> SearchByNameAsync(string name, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Search for IdentityResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		IList<IdentityResource> SearchByDisplayName(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes);
		
        /// <summary>
        /// Search for IdentityResource entities async in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResource></returns>
		Task<IList<IdentityResource>> SearchByDisplayNameAsync(string displayName, bool cache, bool caseSensitive = false, params Expression<Func<IIdentityResource, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the IdentityResource entity to the database.
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		bool Add(IdentityResource entity);
		
        /// <summary>
        /// Add the IdentityResource entity async to the database.
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(IdentityResource entity);

        /// <summary>
        /// Update the IdentityResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		bool Update(IdentityResource entity);
		
        /// <summary>
        /// Update the IdentityResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(IdentityResource entity);
		
        /// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		bool Delete(IdentityResource entity);
		
        /// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="entity">IdentityResource</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(IdentityResource entity);

		/// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<IdentityResource> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<IdentityResource> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<IdentityResource> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<IdentityResource> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<IdentityResource> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<IdentityResource> items);

        #endregion
	}
}
