
// <copyright file="ProductStatusReason.g.cs" company="MIT">
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
	/// The ProductStatusReasonRepository interface that defines database functions for the ProductStatusReason table
	/// </summary>
	public partial interface IProductStatusReasonRepository : IRepository<IProductStatusReason>
	{
		#region Load

        /// <summary>
        /// Load the ProductStatusReason entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductStatusReason</returns>
		IProductStatusReason LoadById(int id);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByUserName(string username);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the DateFrom field
        /// </summary>
        /// <param name="datefrom">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByDateFrom(Nullable<DateTime> datefrom);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the DateTo field
        /// </summary>
        /// <param name="dateto">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByDateTo(Nullable<DateTime> dateto);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load ProductStatusReason entities from the database using the ReasonId field
        /// </summary>
        /// <param name="reasonid">Nullable<int></param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadByReasonId(Nullable<int> reasonid);

        /// <summary>
        /// Load all ProductStatusReason entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductStatusReason entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatusReason></returns>
		IList<IProductStatusReason> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusReason entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusReason</param>
        /// <returns>bool</returns>
		bool Save(IProductStatusReason entity);
		
        /// <summary>
        /// Update the ProductStatusReason entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusReason</param>
        /// <returns>bool</returns>
		bool Update(IProductStatusReason entity);
		
        /// <summary>
        /// Delete the ProductStatusReason entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusReason</param>
        /// <returns>bool</returns>
		bool Delete(IProductStatusReason entity);
		
        /// <summary>
        /// Delete the ProductStatusReason entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
