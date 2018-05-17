
// <copyright file="ProductSumAssuredOutcome.g.cs" company="MIT">
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
	/// The ProductSumAssuredOutcomeRepository interface that defines database functions for the ProductSumAssuredOutcome table
	/// </summary>
	public partial interface IProductSumAssuredOutcomeRepository : IRepository<IProductSumAssuredOutcome>
	{
		#region Load

        /// <summary>
        /// Load the ProductSumAssuredOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductSumAssuredOutcome</returns>
		IProductSumAssuredOutcome LoadById(int id);

        /// <summary>
        /// Load ProductSumAssuredOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">int</param>
        /// <returns>IList<IProductSumAssuredOutcome></returns>
		IList<IProductSumAssuredOutcome> LoadByProductProfileId(int productprofileid);

        /// <summary>
        /// Load all ProductSumAssuredOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IProductSumAssuredOutcome></returns>
		IList<IProductSumAssuredOutcome> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductSumAssuredOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		bool Save(IProductSumAssuredOutcome entity);
		
        /// <summary>
        /// Update the ProductSumAssuredOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		bool Update(IProductSumAssuredOutcome entity);
		
        /// <summary>
        /// Delete the ProductSumAssuredOutcome entity from the database
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		bool Delete(IProductSumAssuredOutcome entity);
		
        /// <summary>
        /// Delete the ProductSumAssuredOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
