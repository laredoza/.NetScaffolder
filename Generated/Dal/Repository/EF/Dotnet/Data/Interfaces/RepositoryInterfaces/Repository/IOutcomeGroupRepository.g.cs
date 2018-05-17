
// <copyright file="OutcomeGroup.g.cs" company="MIT">
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
	/// The OutcomeGroupRepository interface that defines database functions for the OutcomeGroup table
	/// </summary>
	public partial interface IOutcomeGroupRepository : IRepository<IOutcomeGroup>
	{
		#region Load

        /// <summary>
        /// Load the OutcomeGroup entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IOutcomeGroup</returns>
		IOutcomeGroup LoadById(int id);

        /// <summary>
        /// Load OutcomeGroup entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load OutcomeGroup entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> LoadByUserName(string username);

        /// <summary>
        /// Load OutcomeGroup entities from the database using the OutcomeGroupUniqueId field
        /// </summary>
        /// <param name="outcomegroupuniqueid">string</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> LoadByOutcomeGroupUniqueId(string outcomegroupuniqueid);

        /// <summary>
        /// Load OutcomeGroup entities from the database using the OutcomeGroupName field
        /// </summary>
        /// <param name="outcomegroupname">string</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> LoadByOutcomeGroupName(string outcomegroupname);

        /// <summary>
        /// Load all OutcomeGroup entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for OutcomeGroup entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for OutcomeGroup entities in the database by OutcomeGroupUniqueId
        /// </summary>
        /// <param name="outcomegroupuniqueid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> SearchByOutcomeGroupUniqueId(string outcomegroupuniqueid, bool caseSensitive = false);

        /// <summary>
        /// Search for OutcomeGroup entities in the database by OutcomeGroupName
        /// </summary>
        /// <param name="outcomegroupname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeGroup></returns>
		IList<IOutcomeGroup> SearchByOutcomeGroupName(string outcomegroupname, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeGroup entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Save(IOutcomeGroup entity);
		
        /// <summary>
        /// Update the OutcomeGroup entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Update(IOutcomeGroup entity);
		
        /// <summary>
        /// Delete the OutcomeGroup entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeGroup</param>
        /// <returns>bool</returns>
		bool Delete(IOutcomeGroup entity);
		
        /// <summary>
        /// Delete the OutcomeGroup entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
