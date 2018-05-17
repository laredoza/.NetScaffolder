
// <copyright file="TraceLog.g.cs" company="MIT">
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
	/// The TraceLogRepository interface that defines database functions for the TraceLog table
	/// </summary>
	public partial interface ITraceLogRepository : IRepository<ITraceLog>
	{
		#region Load

        /// <summary>
        /// Load the TraceLog entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ITraceLog</returns>
		ITraceLog LoadById(int id);

        /// <summary>
        /// Load TraceLog entities from the database using the Category field
        /// </summary>
        /// <param name="category">string</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> LoadByCategory(string category);

        /// <summary>
        /// Load TraceLog entities from the database using the Message field
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> LoadByMessage(string message);

        /// <summary>
        /// Load TraceLog entities from the database using the TimeStamp field
        /// </summary>
        /// <param name="timestamp">Nullable<DateTime></param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> LoadByTimeStamp(Nullable<DateTime> timestamp);

        /// <summary>
        /// Load TraceLog entities from the database using the StringStamp field
        /// </summary>
        /// <param name="stringstamp">string</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> LoadByStringStamp(string stringstamp);

        /// <summary>
        /// Load all TraceLog entities from the database.
        /// </summary>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for TraceLog entities in the database by Category
        /// </summary>
        /// <param name="category">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> SearchByCategory(string category, bool caseSensitive = false);

        /// <summary>
        /// Search for TraceLog entities in the database by Message
        /// </summary>
        /// <param name="message">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> SearchByMessage(string message, bool caseSensitive = false);

        /// <summary>
        /// Search for TraceLog entities in the database by StringStamp
        /// </summary>
        /// <param name="stringstamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ITraceLog></returns>
		IList<ITraceLog> SearchByStringStamp(string stringstamp, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the TraceLog entity to the database.
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		bool Save(ITraceLog entity);
		
        /// <summary>
        /// Update the TraceLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		bool Update(ITraceLog entity);
		
        /// <summary>
        /// Delete the TraceLog entity from the database
        /// </summary>
        /// <param name="entity">ITraceLog</param>
        /// <returns>bool</returns>
		bool Delete(ITraceLog entity);
		
        /// <summary>
        /// Delete the TraceLog entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
