
// <copyright file="SystemLogType.g.cs" company="MIT">
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
	/// The SystemLogTypeRepository interface that defines database functions for the SystemLogType table
	/// </summary>
	public partial interface ISystemLogTypeRepository : IRepository<ISystemLogType>
	{
		#region Load

        /// <summary>
        /// Load the SystemLogType entity from the database using the LogTypeID primary key
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>ISystemLogType</returns>
		ISystemLogType LoadByLogTypeID(int logtypeid);

        /// <summary>
        /// Load SystemLogType entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<ISystemLogType></returns>
		IList<ISystemLogType> LoadByDescription(string description);

        /// <summary>
        /// Load all SystemLogType entities from the database.
        /// </summary>
        /// <returns>IList<ISystemLogType></returns>
		IList<ISystemLogType> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SystemLogType entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISystemLogType></returns>
		IList<ISystemLogType> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SystemLogType entity to the database.
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		bool Save(ISystemLogType entity);
		
        /// <summary>
        /// Update the SystemLogType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		bool Update(ISystemLogType entity);
		
        /// <summary>
        /// Delete the SystemLogType entity from the database
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		bool Delete(ISystemLogType entity);
		
        /// <summary>
        /// Delete the SystemLogType entity from the database using the LogTypeID
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>bool</returns>
		bool DeleteByLogTypeID(int logtypeid);

		#endregion
	}
}
