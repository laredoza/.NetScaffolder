
// <copyright file="ProductStatusCounter.g.cs" company="MIT">
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
	/// The ProductStatusCounterRepository interface that defines database functions for the ProductStatusCounter table
	/// </summary>
	public partial interface IProductStatusCounterRepository : IRepository<IProductStatusCounter>
	{
		#region Load

        /// <summary>
        /// Load the ProductStatusCounter entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductStatusCounter</returns>
		IProductStatusCounter LoadById(int id);

        /// <summary>
        /// Load ProductStatusCounter entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ProductStatusCounter entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadByUserName(string username);

        /// <summary>
        /// Load ProductStatusCounter entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load ProductStatusCounter entities from the database using the Counter field
        /// </summary>
        /// <param name="counter">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadByCounter(Nullable<int> counter);

        /// <summary>
        /// Load ProductStatusCounter entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load all ProductStatusCounter entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductStatusCounter entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatusCounter></returns>
		IList<IProductStatusCounter> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusCounter entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusCounter</param>
        /// <returns>bool</returns>
		bool Save(IProductStatusCounter entity);
		
        /// <summary>
        /// Update the ProductStatusCounter entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusCounter</param>
        /// <returns>bool</returns>
		bool Update(IProductStatusCounter entity);
		
        /// <summary>
        /// Delete the ProductStatusCounter entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusCounter</param>
        /// <returns>bool</returns>
		bool Delete(IProductStatusCounter entity);
		
        /// <summary>
        /// Delete the ProductStatusCounter entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
