
// <copyright file=".g.cs" company="MIT">
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

namespace RepositoryEFDotnet.Data.ApplicationService
{
    /// <summary>
	/// The ProductApplication Service interface that defines database functions for the Product application service
	/// </summary>
	public partial interface IProductApplicationService 
	{

        #region Load

        /// <summary>
        /// Load Product entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		IProduct LoadByProductProductId(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Load Product Async entities from the database using the primary key
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IProduct</returns>
		Task<IProduct> LoadByProductProductIdAsync(int productId, bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load all Product entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductLoadAll(bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Load all Product Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductLoadAllAsync(bool cache, params Expression<Func<IProduct, object>>[] includes);


        #endregion

        #region Search

        /// <summary>
        /// Search for Product entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByProductDescription(string productDescription,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by ProductDescription
        /// </summary>
        /// <param name="productDescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByProductDescriptionAsync(string productDescription,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByUnitAmount(string unitAmount,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by UnitAmount
        /// </summary>
        /// <param name="unitAmount">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByUnitAmountAsync(string unitAmount,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);


        /// <summary>
        /// Search for Product entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		IList<IProduct> ProductSearchByPublisher(string publisher,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);

        /// <summary>
        /// Search for Product  Async entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IProduct, object>>[]</param>
        /// <returns>IList<IProduct></returns>
		Task<IList<IProduct>> ProductSearchByPublisherAsync(string publisher,bool caseSensitive, bool cache, params Expression<Func<IProduct, object>>[] includes);

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the Product entity to the database.
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductAdd(IProduct entity);

        /// <summary>
        /// Update the Product entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductUpdate(IProduct entity);
		
        /// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="entity">IProduct</param>
        /// <returns>bool</returns>
		bool ProductDelete(IProduct entity);

		/// <summary>
        /// Delete the Product entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool ProductDelete( int productId, bool cache);

		#endregion

        #region Aggregates

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ProductMax<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ProductMaxAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ProductMin<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IProduct, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ProductMinAsync<TResult>(Expression<Func<IProduct, TResult>> maxExpression, bool cache);

		#endregion

        #region Bulk
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkDelete(IEnumerable<IProduct> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkDeleteAsync(IEnumerable<IProduct> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkInsert(IEnumerable<IProduct> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkInsertAsync(IEnumerable<IProduct> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ProductBulkUpdate(IEnumerable<IProduct> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ProductBulkUpdateAsync(IEnumerable<IProduct> items);

        #endregion
    }
}

