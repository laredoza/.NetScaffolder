
// <copyright file="CedantUserLoadingLimit.g.cs" company="MIT">
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
	/// The CedantUserLoadingLimitRepository interface that defines database functions for the CedantUserLoadingLimit table
	/// </summary>
	public partial interface ICedantUserLoadingLimitRepository : IRepository<ICedantUserLoadingLimit>
	{
		#region Load

        /// <summary>
        /// Load the CedantUserLoadingLimit entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantUserLoadingLimit</returns>
		ICedantUserLoadingLimit LoadById(int id);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByUserName(string username);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MinPercentage field
        /// </summary>
        /// <param name="minpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByMinPercentage(Nullable<decimal> minpercentage);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MaxPercentage field
        /// </summary>
        /// <param name="maxpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByMaxPercentage(Nullable<decimal> maxpercentage);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByPremiumProfileId(Nullable<int> premiumprofileid);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByCedantId(Nullable<int> cedantid);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MinUnit field
        /// </summary>
        /// <param name="minunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByMinUnit(Nullable<decimal> minunit);

        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MaxUnit field
        /// </summary>
        /// <param name="maxunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadByMaxUnit(Nullable<decimal> maxunit);

        /// <summary>
        /// Load all CedantUserLoadingLimit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CedantUserLoadingLimit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		IList<ICedantUserLoadingLimit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantUserLoadingLimit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		bool Save(ICedantUserLoadingLimit entity);
		
        /// <summary>
        /// Update the CedantUserLoadingLimit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		bool Update(ICedantUserLoadingLimit entity);
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit entity from the database
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		bool Delete(ICedantUserLoadingLimit entity);
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
