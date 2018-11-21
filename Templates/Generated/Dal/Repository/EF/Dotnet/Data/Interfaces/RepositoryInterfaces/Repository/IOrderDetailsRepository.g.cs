﻿
// <copyright file="OrderDetails.g.cs" company="MIT">
//  Copyright (c) 2018 MIT
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
using Banking.Models.Interfaces;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Interfaces
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
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		IOrderDetails LoadByOrderDetailsId(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderDetailsId">int</param>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IOrderDetails</returns>
		Task<IOrderDetails> LoadByOrderDetailsIdAsync(int orderDetailsId, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByOrderId(int orderId, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the OrderId field
        /// </summary>
        /// <param name="orderId">int</param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByOrderIdAsync(int orderId, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByProductId(int productId, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the ProductId field
        /// </summary>
        /// <param name="productId">int</param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByProductIdAsync(int productId, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByUnitPrice(Nullable<decimal> unitPrice, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByAmount(Nullable<short> amount, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Amount field
        /// </summary>
        /// <param name="amount">Nullable<short></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByAmountAsync(Nullable<short> amount, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByDiscount(Nullable<float> discount, params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load OrderDetails entities async from the database using the Discount field
        /// </summary>
        /// <param name="discount">Nullable<float></param
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadByDiscountAsync(Nullable<float> discount, params Expression<Func<IOrderDetails, object>>[] includes);

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadAll(params Expression<Func<IOrderDetails, object>>[] includes);
		
        /// <summary>
        /// Load all OrderDetails entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IOrderDetails, object>>[]</param>
        /// <returns>IList<IOrderDetails></returns>
		Task<IList<IOrderDetails>> LoadAllAsync(params Expression<Func<IOrderDetails, object>>[] includes);
		
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
		bool Delete( int orderDetailsId);

		/// <summary>
        /// Delete the OrderDetails entity async from the database
        /// </summary>
        /// <param name="orderDetailsId">int</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int orderDetailsId);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
		TResult Min<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IOrderDetails, TResult>> maxExpression);
		
		#endregion
	}
}
