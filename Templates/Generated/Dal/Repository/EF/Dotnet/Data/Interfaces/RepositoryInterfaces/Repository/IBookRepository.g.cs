
// <copyright file="Book.g.cs" company="MIT">
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
	/// The BookRepository interface that defines database functions for the Book table
	/// </summary>
	public partial interface IBookRepository : IRepository<IBook>
	{
		#region Load

        /// <summary>
        /// Load Book entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		IBook LoadByProductId(int productId, params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Load Book entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IBook</returns>
		Task<IBook> LoadByProductIdAsync(int productId, params Expression<Func<IBook, object>>[] includes);

        /// <summary>
        /// Load all Book entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> LoadAll(params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Load all Book entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> LoadAllAsync(params Expression<Func<IBook, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Book entities in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		IList<IBook> SearchByPublisher(string publisher, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes);
		
        /// <summary>
        /// Search for Book entities async in the database by Publisher
        /// </summary>
        /// <param name="publisher">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IBook, object>>[]</param>
        /// <returns>IList<IBook></returns>
		Task<IList<IBook>> SearchByPublisherAsync(string publisher, bool caseSensitive = false, params Expression<Func<IBook, object>>[] includes);

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
		bool Delete( int productId);

		/// <summary>
        /// Delete the Book entity async from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int productId);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
		TResult Min<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IBook, TResult>> maxExpression);
		
		#endregion
	}
}
