
// <copyright file="NoteFollowUp.g.cs" company="MIT">
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
	/// The NoteFollowUpRepository interface that defines database functions for the NoteFollowUp table
	/// </summary>
	public partial interface INoteFollowUpRepository : IRepository<INoteFollowUp>
	{
		#region Load

        /// <summary>
        /// Load the NoteFollowUp entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INoteFollowUp</returns>
		INoteFollowUp LoadById(int id);

        /// <summary>
        /// Load NoteFollowUp entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load NoteFollowUp entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadByUserName(string username);

        /// <summary>
        /// Load NoteFollowUp entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadByDescription(string description);

        /// <summary>
        /// Load NoteFollowUp entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load NoteFollowUp entities from the database using the NoteId field
        /// </summary>
        /// <param name="noteid">Nullable<int></param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadByNoteId(Nullable<int> noteid);

        /// <summary>
        /// Load all NoteFollowUp entities from the database.
        /// </summary>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for NoteFollowUp entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for NoteFollowUp entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteFollowUp></returns>
		IList<INoteFollowUp> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the NoteFollowUp entity to the database.
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		bool Save(INoteFollowUp entity);
		
        /// <summary>
        /// Update the NoteFollowUp entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		bool Update(INoteFollowUp entity);
		
        /// <summary>
        /// Delete the NoteFollowUp entity from the database
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		bool Delete(INoteFollowUp entity);
		
        /// <summary>
        /// Delete the NoteFollowUp entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
