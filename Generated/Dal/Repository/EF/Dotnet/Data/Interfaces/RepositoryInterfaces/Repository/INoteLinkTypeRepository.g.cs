
// <copyright file="NoteLinkType.g.cs" company="MIT">
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
	/// The NoteLinkTypeRepository interface that defines database functions for the NoteLinkType table
	/// </summary>
	public partial interface INoteLinkTypeRepository : IRepository<INoteLinkType>
	{
		#region Load

        /// <summary>
        /// Load the NoteLinkType entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INoteLinkType</returns>
		INoteLinkType LoadById(int id);

        /// <summary>
        /// Load NoteLinkType entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load NoteLinkType entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> LoadByUserName(string username);

        /// <summary>
        /// Load NoteLinkType entities from the database using the LinkType field
        /// </summary>
        /// <param name="linktype">string</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> LoadByLinkType(string linktype);

        /// <summary>
        /// Load NoteLinkType entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> LoadByDescription(string description);

        /// <summary>
        /// Load all NoteLinkType entities from the database.
        /// </summary>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for NoteLinkType entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for NoteLinkType entities in the database by LinkType
        /// </summary>
        /// <param name="linktype">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> SearchByLinkType(string linktype, bool caseSensitive = false);

        /// <summary>
        /// Search for NoteLinkType entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteLinkType></returns>
		IList<INoteLinkType> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the NoteLinkType entity to the database.
        /// </summary>
        /// <param name="entity">INoteLinkType</param>
        /// <returns>bool</returns>
		bool Save(INoteLinkType entity);
		
        /// <summary>
        /// Update the NoteLinkType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INoteLinkType</param>
        /// <returns>bool</returns>
		bool Update(INoteLinkType entity);
		
        /// <summary>
        /// Delete the NoteLinkType entity from the database
        /// </summary>
        /// <param name="entity">INoteLinkType</param>
        /// <returns>bool</returns>
		bool Delete(INoteLinkType entity);
		
        /// <summary>
        /// Delete the NoteLinkType entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
