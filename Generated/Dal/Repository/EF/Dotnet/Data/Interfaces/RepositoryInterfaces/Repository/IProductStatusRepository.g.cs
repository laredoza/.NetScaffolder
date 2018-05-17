
// <copyright file="ProductStatus.g.cs" company="MIT">
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
	/// The ProductStatusRepository interface that defines database functions for the ProductStatus table
	/// </summary>
	public partial interface IProductStatusRepository : IRepository<IProductStatus>
	{
		#region Load

        /// <summary>
        /// Load the ProductStatus entity from the database using the ProductStatusID primary key
        /// </summary>
        /// <param name="productstatusid">int</param>
        /// <returns>IProductStatus</returns>
		IProductStatus LoadByProductStatusID(int productstatusid);

        /// <summary>
        /// Load ProductStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IProductStatus></returns>
		IList<IProductStatus> LoadByDescription(string description);

        /// <summary>
        /// Load all ProductStatus entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatus></returns>
		IList<IProductStatus> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatus></returns>
		IList<IProductStatus> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatus entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		bool Save(IProductStatus entity);
		
        /// <summary>
        /// Update the ProductStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		bool Update(IProductStatus entity);
		
        /// <summary>
        /// Delete the ProductStatus entity from the database
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		bool Delete(IProductStatus entity);
		
        /// <summary>
        /// Delete the ProductStatus entity from the database using the ProductStatusID
        /// </summary>
        /// <param name="productstatusid">int</param>
        /// <returns>bool</returns>
		bool DeleteByProductStatusID(int productstatusid);

		#endregion
	}
}
