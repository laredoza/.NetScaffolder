
// <copyright file="Order.g.cs" company="MIT">
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
	/// The OrderRepository interface that defines database functions for the Order table
	/// </summary>
	public partial interface IOrderRepository : IRepository<Order>
	{
		#region Load

        /// <summary>
        /// Load Order entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>Order</returns>
		Order LoadByOrderId(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Load Order entities async from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>Order</returns>
		Task<Order> LoadByOrderIdAsync(int orderId, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> LoadByCustomerId(int customerId, bool cache,  params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Load Order entities async from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> LoadByCustomerIdAsync(int customerId, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> LoadByOrderDate(Nullable<DateTime> orderDate, bool cache,  params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Load Order entities async from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> LoadByOrderDateAsync(Nullable<DateTime> orderDate, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> LoadByDeliveryDate(Nullable<DateTime> deliveryDate, bool cache,  params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Load Order entities async from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> LoadByDeliveryDateAsync(Nullable<DateTime> deliveryDate, bool cache, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> LoadAll( bool cache, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Load all Order entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<Order, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> LoadAllAsync(bool cache, params Expression<Func<IOrder, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> SearchByShippingName(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> SearchByShippingNameAsync(string shippingName, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> SearchByShippingAddress(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> SearchByShippingAddressAsync(string shippingAddress, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> SearchByShippingCity(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> SearchByShippingCityAsync(string shippingCity, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		IList<Order> SearchByShippingZip(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);
		
        /// <summary>
        /// Search for Order entities async in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IOrder, object>>[]</param>
        /// <returns>IList<Order></returns>
		Task<IList<Order>> SearchByShippingZipAsync(string shippingZip, bool cache, bool caseSensitive = false, params Expression<Func<IOrder, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool Add(Order entity);
		
        /// <summary>
        /// Add the Order entity async to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(Order entity);

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		bool Update(Order entity);
		
        /// <summary>
        /// Update the Order entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(Order entity);
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		bool Delete(Order entity);
		
        /// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="entity">Order</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(Order entity);

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		bool Delete( int orderId, bool cache);

		/// <summary>
        /// Delete the Order entity async from the database
        /// </summary>
        /// <param name="orderId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int orderId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IOrder, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<Order> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<Order> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<Order> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<Order> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<Order> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<Order> items);

        #endregion
	}
}
