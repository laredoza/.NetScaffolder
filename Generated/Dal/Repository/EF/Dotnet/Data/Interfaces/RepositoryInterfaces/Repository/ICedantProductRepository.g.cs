﻿
// <copyright file="CedantProduct.g.cs" company="MIT">
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
	/// The CedantProductRepository interface that defines database functions for the CedantProduct table
	/// </summary>
	public partial interface ICedantProductRepository : IRepository<ICedantProduct>
	{
		#region Load

        /// <summary>
        /// Load the CedantProduct entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantProduct</returns>
		ICedantProduct LoadById(int id);

        /// <summary>
        /// Load CedantProduct entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load CedantProduct entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByUserName(string username);

        /// <summary>
        /// Load CedantProduct entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load CedantProduct entities from the database using the Flexibility field
        /// </summary>
        /// <param name="flexibility">Nullable<int></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByFlexibility(Nullable<int> flexibility);

        /// <summary>
        /// Load CedantProduct entities from the database using the MaximumPercentage field
        /// </summary>
        /// <param name="maximumpercentage">Nullable<int></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByMaximumPercentage(Nullable<int> maximumpercentage);

        /// <summary>
        /// Load CedantProduct entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByCedantId(Nullable<int> cedantid);

        /// <summary>
        /// Load CedantProduct entities from the database using the MaximumUnit field
        /// </summary>
        /// <param name="maximumunit">Nullable<decimal></param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadByMaximumUnit(Nullable<decimal> maximumunit);

        /// <summary>
        /// Load all CedantProduct entities from the database.
        /// </summary>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CedantProduct entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantProduct></returns>
		IList<ICedantProduct> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantProduct entity to the database.
        /// </summary>
        /// <param name="entity">ICedantProduct</param>
        /// <returns>bool</returns>
		bool Save(ICedantProduct entity);
		
        /// <summary>
        /// Update the CedantProduct entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantProduct</param>
        /// <returns>bool</returns>
		bool Update(ICedantProduct entity);
		
        /// <summary>
        /// Delete the CedantProduct entity from the database
        /// </summary>
        /// <param name="entity">ICedantProduct</param>
        /// <returns>bool</returns>
		bool Delete(ICedantProduct entity);
		
        /// <summary>
        /// Delete the CedantProduct entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}