
// <copyright file="SystemLog.g.cs" company="MIT">
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
	/// The SystemLogRepository interface that defines database functions for the SystemLog table
	/// </summary>
	public partial interface ISystemLogRepository : IRepository<ISystemLog>
	{
		#region Load

        /// <summary>
        /// Load the SystemLog entity from the database using the LogID primary key
        /// </summary>
        /// <param name="logid">int</param>
        /// <returns>ISystemLog</returns>
		ISystemLog LoadByLogID(int logid);

        /// <summary>
        /// Load SystemLog entities from the database using the LogTypeID field
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadByLogTypeID(int logtypeid);

        /// <summary>
        /// Load SystemLog entities from the database using the IsRead field
        /// </summary>
        /// <param name="isread">bool</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadByIsRead(bool isread);

        /// <summary>
        /// Load SystemLog entities from the database using the PrimaryID field
        /// </summary>
        /// <param name="primaryid">int</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadByPrimaryID(int primaryid);

        /// <summary>
        /// Load SystemLog entities from the database using the SecondaryID field
        /// </summary>
        /// <param name="secondaryid">Nullable<int></param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadBySecondaryID(Nullable<int> secondaryid);

        /// <summary>
        /// Load SystemLog entities from the database using the DateUpdated field
        /// </summary>
        /// <param name="dateupdated">DateTime</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadByDateUpdated(DateTime dateupdated);

        /// <summary>
        /// Load SystemLog entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadByValue(string value);

        /// <summary>
        /// Load all SystemLog entities from the database.
        /// </summary>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SystemLog entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISystemLog></returns>
		IList<ISystemLog> SearchByValue(string value, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SystemLog entity to the database.
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		bool Save(ISystemLog entity);
		
        /// <summary>
        /// Update the SystemLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		bool Update(ISystemLog entity);
		
        /// <summary>
        /// Delete the SystemLog entity from the database
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		bool Delete(ISystemLog entity);
		
        /// <summary>
        /// Delete the SystemLog entity from the database using the LogID
        /// </summary>
        /// <param name="logid">int</param>
        /// <returns>bool</returns>
		bool DeleteByLogID(int logid);

		#endregion
	}
}
