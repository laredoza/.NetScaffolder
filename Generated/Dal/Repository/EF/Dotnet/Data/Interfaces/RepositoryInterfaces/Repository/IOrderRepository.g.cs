
// <copyright file="Order.g.cs" company="MIT">
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
using RepositoryEFDotnet.Core.Base;
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The OrderRepository interface that defines database functions for the Order table
	/// </summary>
	public partial interface IOrderRepository : IRepository<IOrder>
	{
		#region Load

        /// <summary>
        /// Load Order entities from the database using the composite primary keys
        /// </summary
        /// <param name="orderId">int</param>
        /// <returns>IOrder</returns>
		IOrder LoadByOrderId(int orderId);

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerId">Nullable<int></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByCustomerId(Nullable<int> customerId);

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderDate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByOrderDate(Nullable<DateTime> orderDate);

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliveryDate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByDeliveryDate(Nullable<DateTime> deliveryDate);

        /// <summary>
        /// Load all Order entities from the database.
        /// </summary>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Order entities in the database by ShippingName
        /// </summary>
        /// <param name="shippingName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingName(string shippingName, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingAddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingAddress(string shippingAddress, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingCity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingCity(string shippingCity, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingZip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingZip(string shippingZip, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Order entity to the database.
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool Save(IOrder entity);

        /// <summary>
        /// Update the Order entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool Update(IOrder entity);
		
        /// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="entity">IOrder</param>
        /// <returns>bool</returns>
		bool Delete(IOrder entity);

		/// <summary>
        /// Delete the Order entity from the database
        /// </summary>
        /// <param name="orderId">int</param>
        /// <returns>bool</returns>
		bool Delete( int orderId);

		#endregion
	}
}
