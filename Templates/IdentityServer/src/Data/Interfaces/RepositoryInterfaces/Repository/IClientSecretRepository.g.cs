
// <copyright file="ClientSecret.g.cs" company="MIT">
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
	/// The ClientSecretRepository interface that defines database functions for the ClientSecret table
	/// </summary>
	public partial interface IClientSecretRepository : IRepository<ClientSecret>
	{
		#region Load

        /// <summary>
        /// Load ClientSecret entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>ClientSecret</returns>
		ClientSecret LoadById(int id, bool cache, params Expression<Func<IClientSecret, object>>[] includes);
		
        /// <summary>
        /// Load ClientSecret entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>ClientSecret</returns>
		Task<ClientSecret> LoadByIdAsync(int id, bool cache, params Expression<Func<IClientSecret, object>>[] includes);

        /// <summary>
        /// Load ClientSecret entities from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		IList<ClientSecret> LoadByClientId(int clientId, bool cache,  params Expression<Func<IClientSecret, object>>[] includes);
		
        /// <summary>
        /// Load ClientSecret entities async from the database using the ClientId field
        /// </summary>
        /// <param name="clientId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		Task<IList<ClientSecret>> LoadByClientIdAsync(int clientId, bool cache, params Expression<Func<IClientSecret, object>>[] includes);

        /// <summary>
        /// Load all ClientSecret entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		IList<ClientSecret> LoadAll( bool cache, params Expression<Func<IClientSecret, object>>[] includes);
		
        /// <summary>
        /// Load all ClientSecret entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		Task<IList<ClientSecret>> LoadAllAsync(bool cache, params Expression<Func<IClientSecret, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ClientSecret entities in the database by Secret
        /// </summary>
        /// <param name="secret">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		IList<ClientSecret> SearchBySecret(string secret, bool cache, bool caseSensitive = false, params Expression<Func<IClientSecret, object>>[] includes);
		
        /// <summary>
        /// Search for ClientSecret entities async in the database by Secret
        /// </summary>
        /// <param name="secret">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClientSecret, object>>[]</param>
        /// <returns>IList<ClientSecret></returns>
		Task<IList<ClientSecret>> SearchBySecretAsync(string secret, bool cache, bool caseSensitive = false, params Expression<Func<IClientSecret, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ClientSecret entity to the database.
        /// </summary>
        /// <param name="entity">IClientSecret</param>
        /// <returns>bool</returns>
		bool Add(ClientSecret entity);
		
        /// <summary>
        /// Add the ClientSecret entity async to the database.
        /// </summary>
        /// <param name="entity">IClientSecret</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ClientSecret entity);

        /// <summary>
        /// Update the ClientSecret entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		bool Update(ClientSecret entity);
		
        /// <summary>
        /// Update the ClientSecret entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ClientSecret entity);
		
        /// <summary>
        /// Delete the ClientSecret entity from the database
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		bool Delete(ClientSecret entity);
		
        /// <summary>
        /// Delete the ClientSecret entity async from the database
        /// </summary>
        /// <param name="entity">ClientSecret</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ClientSecret entity);

		/// <summary>
        /// Delete the ClientSecret entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the ClientSecret entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IClientSecret, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<ClientSecret> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ClientSecret> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ClientSecret> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ClientSecret> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ClientSecret> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ClientSecret> items);

        #endregion
	}
}
