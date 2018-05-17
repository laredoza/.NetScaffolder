
// <copyright file="NoteStatus.g.cs" company="MIT">
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
	/// The NoteStatusRepository interface that defines database functions for the NoteStatus table
	/// </summary>
	public partial interface INoteStatusRepository : IRepository<INoteStatus>
	{
		#region Load

        /// <summary>
        /// Load the NoteStatus entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INoteStatus</returns>
		INoteStatus LoadById(int id);

        /// <summary>
        /// Load NoteStatus entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load NoteStatus entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> LoadByUserName(string username);

        /// <summary>
        /// Load NoteStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> LoadByDescription(string description);

        /// <summary>
        /// Load all NoteStatus entities from the database.
        /// </summary>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for NoteStatus entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for NoteStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteStatus></returns>
		IList<INoteStatus> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the NoteStatus entity to the database.
        /// </summary>
        /// <param name="entity">INoteStatus</param>
        /// <returns>bool</returns>
		bool Save(INoteStatus entity);
		
        /// <summary>
        /// Update the NoteStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INoteStatus</param>
        /// <returns>bool</returns>
		bool Update(INoteStatus entity);
		
        /// <summary>
        /// Delete the NoteStatus entity from the database
        /// </summary>
        /// <param name="entity">INoteStatus</param>
        /// <returns>bool</returns>
		bool Delete(INoteStatus entity);
		
        /// <summary>
        /// Delete the NoteStatus entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
