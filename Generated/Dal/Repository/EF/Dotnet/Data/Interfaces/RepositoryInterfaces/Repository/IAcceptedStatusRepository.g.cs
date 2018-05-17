
// <copyright file="AcceptedStatus.g.cs" company="MIT">
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
	/// The AcceptedStatusRepository interface that defines database functions for the AcceptedStatus table
	/// </summary>
	public partial interface IAcceptedStatusRepository : IRepository<IAcceptedStatus>
	{
		#region Load

        /// <summary>
        /// Load the AcceptedStatus entity from the database using the AcceptedStatusID primary key
        /// </summary>
        /// <param name="acceptedstatusid">int</param>
        /// <returns>IAcceptedStatus</returns>
		IAcceptedStatus LoadByAcceptedStatusID(int acceptedstatusid);

        /// <summary>
        /// Load AcceptedStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IAcceptedStatus></returns>
		IList<IAcceptedStatus> LoadByDescription(string description);

        /// <summary>
        /// Load all AcceptedStatus entities from the database.
        /// </summary>
        /// <returns>IList<IAcceptedStatus></returns>
		IList<IAcceptedStatus> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AcceptedStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAcceptedStatus></returns>
		IList<IAcceptedStatus> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AcceptedStatus entity to the database.
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		bool Save(IAcceptedStatus entity);
		
        /// <summary>
        /// Update the AcceptedStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		bool Update(IAcceptedStatus entity);
		
        /// <summary>
        /// Delete the AcceptedStatus entity from the database
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		bool Delete(IAcceptedStatus entity);
		
        /// <summary>
        /// Delete the AcceptedStatus entity from the database using the AcceptedStatusID
        /// </summary>
        /// <param name="acceptedstatusid">int</param>
        /// <returns>bool</returns>
		bool DeleteByAcceptedStatusID(int acceptedstatusid);

		#endregion
	}
}
