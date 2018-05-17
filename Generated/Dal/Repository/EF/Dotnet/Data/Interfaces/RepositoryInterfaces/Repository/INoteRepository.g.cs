
// <copyright file="Note.g.cs" company="MIT">
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
	/// The NoteRepository interface that defines database functions for the Note table
	/// </summary>
	public partial interface INoteRepository : IRepository<INote>
	{
		#region Load

        /// <summary>
        /// Load the Note entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INote</returns>
		INote LoadById(int id);

        /// <summary>
        /// Load Note entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Note entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByUserName(string username);

        /// <summary>
        /// Load Note entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByDescription(string description);

        /// <summary>
        /// Load Note entities from the database using the AllocatedToId field
        /// </summary>
        /// <param name="allocatedtoid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByAllocatedToId(Nullable<int> allocatedtoid);

        /// <summary>
        /// Load Note entities from the database using the ActionRequiredFlag field
        /// </summary>
        /// <param name="actionrequiredflag">Nullable<bool></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByActionRequiredFlag(Nullable<bool> actionrequiredflag);

        /// <summary>
        /// Load Note entities from the database using the FollowUpDate field
        /// </summary>
        /// <param name="followupdate">Nullable<DateTime></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByFollowUpDate(Nullable<DateTime> followupdate);

        /// <summary>
        /// Load Note entities from the database using the LinkId field
        /// </summary>
        /// <param name="linkid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByLinkId(Nullable<int> linkid);

        /// <summary>
        /// Load Note entities from the database using the CompletedFlag field
        /// </summary>
        /// <param name="completedflag">Nullable<bool></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByCompletedFlag(Nullable<bool> completedflag);

        /// <summary>
        /// Load Note entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load Note entities from the database using the NoteStatusId field
        /// </summary>
        /// <param name="notestatusid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByNoteStatusId(Nullable<int> notestatusid);

        /// <summary>
        /// Load Note entities from the database using the NoteLinkTypeId field
        /// </summary>
        /// <param name="notelinktypeid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		IList<INote> LoadByNoteLinkTypeId(Nullable<int> notelinktypeid);

        /// <summary>
        /// Load all Note entities from the database.
        /// </summary>
        /// <returns>IList<INote></returns>
		IList<INote> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Note entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote></returns>
		IList<INote> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Note entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote></returns>
		IList<INote> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Note entity to the database.
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		bool Save(INote entity);
		
        /// <summary>
        /// Update the Note entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		bool Update(INote entity);
		
        /// <summary>
        /// Delete the Note entity from the database
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		bool Delete(INote entity);
		
        /// <summary>
        /// Delete the Note entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
