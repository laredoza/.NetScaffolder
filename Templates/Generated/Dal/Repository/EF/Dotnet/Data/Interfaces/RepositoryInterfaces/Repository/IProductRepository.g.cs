
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
using System.Linq.Expressions;
using System.Threading.Tasks;
using RepositoryEFDotnet.Data.Interfaces;
using RepositoryEFDotnet.Core.Base;

namespace RepositoryEFDotnet.Data.Interfaces
{
	/// <summary>
	/// The ProductRepository interface that defines database functions for the Product table
	/// </summary>
	public partial interface IProductRepository : IRepository<IProduct>
	{
		#region Load

        /// <summary>
        /// Load Product entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		IProduct LoadByProductId(int productId, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Load Product entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		Task<IProduct> LoadByProductIdAsync(int productId, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load Product entities from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByUnitPrice(Nullable<decimal> unitPrice, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Load Product entities async from the database using the UnitPrice field
        /// </summary>
        /// <param name="unitPrice">Nullable<decimal></param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> LoadByUnitPriceAsync(Nullable<decimal> unitPrice, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load Product entities from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadByAmountInStock(Nullable<short> amountInStock, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Load Product entities async from the database using the AmountInStock field
        /// </summary>
        /// <param name="amountInStock">Nullable<short></param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> LoadByAmountInStockAsync(Nullable<short> amountInStock, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> LoadAll(params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Load all Product entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> LoadAllAsync(params Expression<Func<IProduct, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByProductDescription(string productDescription, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Search for Product entities async in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> SearchByProductDescriptionAsync(string productDescription, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByUnitAmount(string unitAmount, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Search for Product entities async in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> SearchByUnitAmountAsync(string unitAmount, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> SearchByPublisher(string publisher, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);
		
        /// <summary>
        /// Search for Product entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> SearchByPublisherAsync(string publisher, bool caseSensitive = false, params Expression<Func<IProduct, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Add(IProduct entity);
		
        /// <summary>
        /// Add the Product entity async to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(IProduct entity);

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Update(IProduct entity);
		
        /// <summary>
        /// Update the Product entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool Delete(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(IProduct entity);

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool Delete( int productId);

		/// <summary>
        /// Delete the Product entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int productId);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
		TResult Min<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression);
		
		#endregion
	}
}
