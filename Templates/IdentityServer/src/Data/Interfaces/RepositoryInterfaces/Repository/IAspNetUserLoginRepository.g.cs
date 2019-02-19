
// <copyright file="AspNetUserLogin.g.cs" company="MIT">
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
	/// The AspNetUserLoginRepository interface that defines database functions for the AspNetUserLogin table
	/// </summary>
	public partial interface IAspNetUserLoginRepository : IRepository<AspNetUserLogin>
	{
		#region Load

        /// <summary>
        /// Load AspNetUserLogin entities from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLogin</returns>
		AspNetUserLogin Load( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUserLogin entities async from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLogin</returns>
		Task<AspNetUserLogin> LoadAsync( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Load all AspNetUserLogin entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		IList<AspNetUserLogin> LoadAll( bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);
		
        /// <summary>
        /// Load all AspNetUserLogin entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		Task<IList<AspNetUserLogin>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUserLogin entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		IList<AspNetUserLogin> SearchByProviderDisplayName(string providerDisplayName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUserLogin entities async in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		Task<IList<AspNetUserLogin>> SearchByProviderDisplayNameAsync(string providerDisplayName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserLogin entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		IList<AspNetUserLogin> SearchByUserId(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUserLogin entities async in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLogin></returns>
		Task<IList<AspNetUserLogin>> SearchByUserIdAsync(string userId, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUserLogin, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUserLogin entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		bool Add(AspNetUserLogin entity);
		
        /// <summary>
        /// Add the AspNetUserLogin entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AspNetUserLogin entity);

        /// <summary>
        /// Update the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		bool Update(AspNetUserLogin entity);
		
        /// <summary>
        /// Update the AspNetUserLogin entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AspNetUserLogin entity);
		
        /// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		bool Delete(AspNetUserLogin entity);
		
        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUserLogin</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AspNetUserLogin entity);

		/// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		bool Delete( string loginProvider,  string providerKey, bool cache);

		/// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="loginProvider">string, bool cache</param>
        /// <param name="providerKey">string, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( string loginProvider,  string providerKey, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AspNetUserLogin> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AspNetUserLogin> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AspNetUserLogin> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AspNetUserLogin> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AspNetUserLogin> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AspNetUserLogin> items);

        #endregion
	}
}
