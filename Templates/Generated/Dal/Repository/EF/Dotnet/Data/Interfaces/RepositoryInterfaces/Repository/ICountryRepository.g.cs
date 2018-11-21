
// <copyright file="Country.g.cs" company="MIT">
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
	/// The CountryRepository interface that defines database functions for the Country table
	/// </summary>
	public partial interface ICountryRepository : IRepository<ICountry>
	{
		#region Load

        /// <summary>
        /// Load Country entities from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>ICountry</returns>
		ICountry LoadByCountryId(int countryId, params Expression<Func<ICountry, object>>[] includes);
		
        /// <summary>
        /// Load Country entities async from the database using the composite primary keys
        /// </summary
        /// <param name="countryId">int</param>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>ICountry</returns>
		Task<ICountry> LoadByCountryIdAsync(int countryId, params Expression<Func<ICountry, object>>[] includes);

        /// <summary>
        /// Load all Country entities from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		IList<ICountry> LoadAll(params Expression<Func<ICountry, object>>[] includes);
		
        /// <summary>
        /// Load all Country entities async from the database.
        /// </summary>
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		Task<IList<ICountry>> LoadAllAsync(params Expression<Func<ICountry, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Country entities in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		IList<ICountry> SearchByCountryName(string countryName, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes);
		
        /// <summary>
        /// Search for Country entities async in the database by CountryName
        /// </summary>
        /// <param name="countryName">string</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<ICountry, object>>[]</param>
        /// <returns>IList<ICountry></returns>
		Task<IList<ICountry>> SearchByCountryNameAsync(string countryName, bool caseSensitive = false, params Expression<Func<ICountry, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the Country entity to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool Add(ICountry entity);
		
        /// <summary>
        /// Add the Country entity async to the database.
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(ICountry entity);

        /// <summary>
        /// Update the Country entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool Update(ICountry entity);
		
        /// <summary>
        /// Update the Country entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(ICountry entity);
		
        /// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		bool Delete(ICountry entity);
		
        /// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="entity">ICountry</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(ICountry entity);

		/// <summary>
        /// Delete the Country entity from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		bool Delete( int countryId);

		/// <summary>
        /// Delete the Country entity async from the database
        /// </summary>
        /// <param name="countryId">int</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( int countryId);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
		TResult Min<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<ICountry, TResult>> maxExpression);
		
		#endregion
	}
}
