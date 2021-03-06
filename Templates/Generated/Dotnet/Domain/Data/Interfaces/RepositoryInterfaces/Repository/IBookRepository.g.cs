﻿
// <copyright file="Book.g.cs" company="MIT">
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
	/// The BookRepository interface that defines database functions for the Book table
	/// </summary>
	public partial interface IBookRepository : IRepository<IBook>
	{
		#region Load

        /// <summary>
        /// Load Book entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		IBook LoadByProductId(int productId, bool cache, params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Load Book entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		Task<IBook> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> LoadAll( bool cache, params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Load all Book entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> LoadAllAsync(bool cache, params Expression<Func<IBook, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> SearchByPublisher(string publisher, bool cache, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Search for Book entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> SearchByPublisherAsync(string publisher, bool cache, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Book entity to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool Add(IBook entity);
		
        /// <summary>
        /// Add the Book entity async to the database.
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(IBook entity);

        /// <summary>
        /// Update the Book entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool Update(IBook entity);
		
        /// <summary>
        /// Update the Book entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(IBook entity);
		
        /// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		bool Delete(IBook entity);
		
        /// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="entity">IBook</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(IBook entity);

		/// <summary>
        /// Delete the Book entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool Delete( int productId, bool cache);

		/// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="productId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int productId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<IBook> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<IBook> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<IBook> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<IBook> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<IBook> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<IBook> items);

        #endregion
	}
}
