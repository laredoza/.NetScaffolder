
// <copyright file="Product.g.cs" company="MIT">
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
	/// The ProductRepository interface that defines database functions for the Product table
	/// </summary>
	public partial interface IProductRepository
	{
		#region Load

        /// <summary>
        /// Load the Product entity from the database using the ProductId primary key
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>IProduct</returns>
		IProduct LoadByProductId(int productid);

        /// <summary>
        /// Load Product entities from the database using the ProductDescription field
        /// </summary>
        /// <param name="productdescription">string</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByProductDescription(string productdescription);

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitprice">decimal</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByUnitPrice(decimal unitprice);

        /// <summary>
        /// Load Product entities from the database using the UnitAmount field
        /// </summary>
        /// <param name="unitamount">string</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByUnitAmount(string unitamount);

        /// <summary>
        /// Load Product entities from the database using the Publisher field
        /// </summary>
        /// <param name="publisher">string</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByPublisher(string publisher);

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountinstock">short</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByAmountInStock(short amountinstock);

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productdescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByProductDescription(string productdescription, bool caseSensitive = false);

        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitamount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByUnitAmount(string unitamount, bool caseSensitive = false);

        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByPublisher(string publisher, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Save(IProduct entity);
		
        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Update(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Delete(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity from the database using the ProductId
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>bool</returns>
		bool DeleteByProductId(int productid);

		#endregion
	}
}
