
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
using Core.Base;
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The OrderRepository interface that defines database functions for the Order table
	/// </summary>
	public partial interface IOrderRepository : IRepository
	{
		#region Load

        /// <summary>
        /// Load the Order entity from the database using the OrderId primary key
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>IOrder</returns>
		IOrder LoadByOrderId(int orderid);

        /// <summary>
        /// Load Order entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByCustomerId(Nullable<int> customerid);

        /// <summary>
        /// Load Order entities from the database using the OrderDate field
        /// </summary>
        /// <param name="orderdate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByOrderDate(Nullable<DateTime> orderdate);

        /// <summary>
        /// Load Order entities from the database using the DeliveryDate field
        /// </summary>
        /// <param name="deliverydate">Nullable<DateTime></param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByDeliveryDate(Nullable<DateTime> deliverydate);

        /// <summary>
        /// Load Order entities from the database using the ShippingName field
        /// </summary>
        /// <param name="shippingname">string</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByShippingName(string shippingname);

        /// <summary>
        /// Load Order entities from the database using the ShippingAddress field
        /// </summary>
        /// <param name="shippingaddress">string</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByShippingAddress(string shippingaddress);

        /// <summary>
        /// Load Order entities from the database using the ShippingCity field
        /// </summary>
        /// <param name="shippingcity">string</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByShippingCity(string shippingcity);

        /// <summary>
        /// Load Order entities from the database using the ShippingZip field
        /// </summary>
        /// <param name="shippingzip">string</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> LoadByShippingZip(string shippingzip);

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
        /// <param name="shippingname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingName(string shippingname, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingAddress
        /// </summary>
        /// <param name="shippingaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingAddress(string shippingaddress, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingCity
        /// </summary>
        /// <param name="shippingcity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingCity(string shippingcity, bool caseSensitive = false);

        /// <summary>
        /// Search for Order entities in the database by ShippingZip
        /// </summary>
        /// <param name="shippingzip">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOrder></returns>
		IList<IOrder> SearchByShippingZip(string shippingzip, bool caseSensitive = false);

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
        /// Delete the Order entity from the database using the OrderId
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>bool</returns>
		bool DeleteByOrderId(int orderid);

		#endregion
	}
}
