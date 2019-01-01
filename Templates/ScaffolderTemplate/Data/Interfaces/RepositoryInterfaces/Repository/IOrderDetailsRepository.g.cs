
// <copyright file="OrderDetails.g.cs" company="MIT">
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
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces
{
	/// <summary>
	/// The OrderDetailsRepository interface that defines database functions for the OrderDetails table
	/// </summary>
	public partial interface IOrderDetailsRepository : IRepository<IOrderDetails>
	{
		#region Load

        /// <summary>
        /// Load OrderDetails entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		IOrderDetails LoadByOrderDetailsId(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		Task<IOrderDetails> LoadByOrderDetailsIdAsync(int orderDetailsId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByOrderId(int orderId, bool cache,  params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByProductId(int productId, bool cache,  params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice, bool cache,  params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByAmount(Nullable<short> amount, bool cache,  params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByAmountAsync(Nullable<short> amount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByDiscount(Nullable<float> discount, bool cache,  params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByDiscountAsync(Nullable<float> discount, bool cache, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadAll( bool cache, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load all OrderDetails entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadAllAsync(bool cache, params Expression<Func<IOrderDetails, object>>[] includes);
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Add(IOrderDetails entity);
		
        /// <summary>
        /// Add the OrderDetails entity async to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(IOrderDetails entity);

        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Update(IOrderDetails entity);
		
        /// <summary>
        /// Update the OrderDetails entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(IOrderDetails entity);
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Delete(IOrderDetails entity);
		
        /// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(IOrderDetails entity);

		/// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		bool Delete( int orderDetailsId, bool cache);

		/// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="orderDetailsId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int orderDetailsId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<IOrderDetails> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<IOrderDetails> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<IOrderDetails> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<IOrderDetails> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<IOrderDetails> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<IOrderDetails> items);

        #endregion
	}
}
