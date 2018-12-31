
// <copyright file="Software.g.cs" company="MIT">
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
	/// The SoftwareRepository interface that defines database functions for the Software table
	/// </summary>
	public partial interface ISoftwareRepository : IRepository<ISoftware>
	{
		#region Load

        /// <summary>
        /// Load Software entities from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>ISoftware</returns>
		ISoftware LoadByProductId(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes);
		
        /// <summary>
        /// Load Software entities async from the database using the composite primary keys
        /// </summary
        /// <param name="productId">int</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>ISoftware</returns>
		Task<ISoftware> LoadByProductIdAsync(int productId, bool cache, params Expression<Func<ISoftware, object>>[] includes);

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> LoadAll( bool cache, params Expression<Func<ISoftware, object>>[] includes);
		
        /// <summary>
        /// Load all Software entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		Task<IList<ISoftware>> LoadAllAsync(bool cache, params Expression<Func<ISoftware, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> SearchByLicenseCode(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes);
		
        /// <summary>
        /// Search for Software entities async in the database by LicenseCode
        /// </summary>
        /// <param name="licenseCode">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ISoftware, object>>[]</param>
        /// <returns>IList<ISoftware></returns>
		Task<IList<ISoftware>> SearchByLicenseCodeAsync(string licenseCode, bool cache, bool caseSensitive = false, params Expression<Func<ISoftware, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Add(ISoftware entity);
		
        /// <summary>
        /// Add the Software entity async to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ISoftware entity);

        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Update(ISoftware entity);
		
        /// <summary>
        /// Update the Software entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ISoftware entity);
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Delete(ISoftware entity);
		
        /// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ISoftware entity);

		/// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="productId">int</param>
        /// <returns>bool</returns>
		bool Delete( int productId, bool cache);

		/// <summary>
        /// Delete the Software entity async from the database
        /// </summary>
        /// <param name="productId">int, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int productId, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<ISoftware, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<ISoftware> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<ISoftware> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<ISoftware> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<ISoftware> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<ISoftware> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<ISoftware> items);

        #endregion
	}
}
