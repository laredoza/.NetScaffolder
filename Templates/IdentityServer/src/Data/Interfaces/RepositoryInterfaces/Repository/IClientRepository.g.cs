
// <copyright file="Client.g.cs" company="MIT">
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
	/// The ClientRepository interface that defines database functions for the Client table
	/// </summary>
	public partial interface IClientRepository : IRepository<Client>
	{
		#region Load

        /// <summary>
        /// Load Client entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>Client</returns>
		Client LoadById(int id, bool cache, params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Load Client entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>Client</returns>
		Task<Client> LoadByIdAsync(int id, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Load Client entities from the database using the AlwaysSendClientClaims field
        /// </summary>
        /// <param name="alwaysSendClientClaims">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		IList<Client> LoadByAlwaysSendClientClaims(bool alwaysSendClientClaims, bool cache,  params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Load Client entities async from the database using the AlwaysSendClientClaims field
        /// </summary>
        /// <param name="alwaysSendClientClaims">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		Task<IList<Client>> LoadByAlwaysSendClientClaimsAsync(bool alwaysSendClientClaims, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Load Client entities from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		IList<Client> LoadByActive(bool active, bool cache,  params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Load Client entities async from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		Task<IList<Client>> LoadByActiveAsync(bool active, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Load all Client entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		IList<Client> LoadAll( bool cache, params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Load all Client entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<Client, object>>[]</param>
        /// <returns>IList<Client></returns>
		Task<IList<Client>> LoadAllAsync(bool cache, params Expression<Func<IClient, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Client entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		IList<Client> SearchByClientId(string clientId, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Search for Client entities async in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		Task<IList<Client>> SearchByClientIdAsync(string clientId, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Search for Client entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		IList<Client> SearchByClientName(string clientName, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes);
		
        /// <summary>
        /// Search for Client entities async in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<Client></returns>
		Task<IList<Client>> SearchByClientNameAsync(string clientName, bool cache, bool caseSensitive = false, params Expression<Func<IClient, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Client entity to the database.
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		bool Add(Client entity);
		
        /// <summary>
        /// Add the Client entity async to the database.
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(Client entity);

        /// <summary>
        /// Update the Client entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		bool Update(Client entity);
		
        /// <summary>
        /// Update the Client entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(Client entity);
		
        /// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		bool Delete(Client entity);
		
        /// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="entity">Client</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(Client entity);

		/// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id, bool cache);

		/// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="id">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<Client> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<Client> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<Client> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<Client> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<Client> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<Client> items);

        #endregion
	}
}
