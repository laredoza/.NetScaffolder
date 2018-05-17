
// <copyright file="WCFLog.g.cs" company="MIT">
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
	/// The WCFLogRepository interface that defines database functions for the WCFLog table
	/// </summary>
	public partial interface IWCFLogRepository : IRepository<IWCFLog>
	{
		#region Load

        /// <summary>
        /// Load the WCFLog entity from the database using the id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IWCFLog</returns>
		IWCFLog LoadByid(int id);

        /// <summary>
        /// Load WCFLog entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> LoadByDescription(string description);

        /// <summary>
        /// Load WCFLog entities from the database using the AdditionalDetails field
        /// </summary>
        /// <param name="additionaldetails">string</param>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> LoadByAdditionalDetails(string additionaldetails);

        /// <summary>
        /// Load WCFLog entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load all WCFLog entities from the database.
        /// </summary>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for WCFLog entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> SearchByDescription(string description, bool caseSensitive = false);

        /// <summary>
        /// Search for WCFLog entities in the database by AdditionalDetails
        /// </summary>
        /// <param name="additionaldetails">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog></returns>
		IList<IWCFLog> SearchByAdditionalDetails(string additionaldetails, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the WCFLog entity to the database.
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		bool Save(IWCFLog entity);
		
        /// <summary>
        /// Update the WCFLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		bool Update(IWCFLog entity);
		
        /// <summary>
        /// Delete the WCFLog entity from the database
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		bool Delete(IWCFLog entity);
		
        /// <summary>
        /// Delete the WCFLog entity from the database using the id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteByid(int id);

		#endregion
	}
}
