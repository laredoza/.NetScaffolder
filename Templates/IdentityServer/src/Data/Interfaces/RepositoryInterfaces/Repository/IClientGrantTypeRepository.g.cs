
// <copyright file="ClientGrantType.g.cs" company="MIT">
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
	/// The ClientGrantTypeRepository interface that defines database functions for the ClientGrantType table
	/// </summary>
	public partial interface IClientGrantTypeRepository : IRepository<ClientGrantType>
	{
		#region Load

        /// <summary>
        /// Load ClientGrantType entities from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantType</returns>
		ClientGrantType Load( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes);
		
        /// <summary>
        /// Load ClientGrantType entities async from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantType</returns>
		Task<ClientGrantType> LoadAsync( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes);

        /// <summary>
        /// Load all ClientGrantType entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantType></returns>
		IList<ClientGrantType> LoadAll( bool cache, params Expression<Func<IClientGrantType, object>>[] includes);
		
        /// <summary>
        /// Load all ClientGrantType entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantType></returns>
		Task<IList<ClientGrantType>> LoadAllAsync(bool cache, params Expression<Func<IClientGrantType, object>>[] includes);
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the ClientGrantType entity to the database.
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		bool Add(ClientGrantType entity);
		
        /// <summary>
        /// Add the ClientGrantType entity async to the database.
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ClientGrantType entity);

        /// <summary>
        /// Update the ClientGrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		bool Update(ClientGrantType entity);
		
        /// <summary>
        /// Update the ClientGrantType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ClientGrantType entity);
		
        /// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		bool Delete(ClientGrantType entity);
		
        /// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="entity">ClientGrantType</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ClientGrantType entity);

		/// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		bool Delete( int clientId,  int grantTypeId, bool cache);

		/// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="clientId">int, bool cache</param>
        /// <param name="grantTypeId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int clientId,  int grantTypeId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<ClientGrantType> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ClientGrantType> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ClientGrantType> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ClientGrantType> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ClientGrantType> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ClientGrantType> items);

        #endregion
	}
}
