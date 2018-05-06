
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
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The OrderDetailsRepository interface that defines database functions for the OrderDetails table
	/// </summary>
	public partial interface IOrderDetailsRepository
	{
		#region Load

        /// <summary>
        /// Load the OrderDetails entity from the database using the OrderDetailsId primary key
        /// </summary>
        /// <param name="orderdetailsid">int</param>
        /// <returns>IOrderDetails</returns>
		IOrderDetails LoadByOrderDetailsId(int orderdetailsid);

        /// <summary>
        /// Load OrderDetails entities from the database using the OrderId field
        /// </summary>
        /// <param name="orderid">int</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByOrderId(int orderid);

        /// <summary>
        /// Load OrderDetails entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByProductId(int productid);

        /// <summary>
        /// Load OrderDetails entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitprice">decimal</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByUnitPrice(decimal unitprice);

        /// <summary>
        /// Load OrderDetails entities from the database using the Amount field
        /// </summary>
        /// <param name="amount">short</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByAmount(short amount);

        /// <summary>
        /// Load OrderDetails entities from the database using the Discount field
        /// </summary>
        /// <param name="discount">float</param>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadByDiscount(float discount);

        /// <summary>
        /// Load all OrderDetails entities from the database.
        /// </summary>
        /// <returns>IList<IOrderDetails></returns>
		IList<IOrderDetails> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OrderDetails entity to the database.
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Save(IOrderDetails entity);
		
        /// <summary>
        /// Update the OrderDetails entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Update(IOrderDetails entity);
		
        /// <summary>
        /// Delete the OrderDetails entity from the database
        /// </summary>
        /// <param name="entity">IOrderDetails</param>
        /// <returns>bool</returns>
		bool Delete(IOrderDetails entity);
		
        /// <summary>
        /// Delete the OrderDetails entity from the database using the OrderDetailsId
        /// </summary>
        /// <param name="orderdetailsid">int</param>
        /// <returns>bool</returns>
		bool DeleteByOrderDetailsId(int orderdetailsid);

		#endregion
	}
}
