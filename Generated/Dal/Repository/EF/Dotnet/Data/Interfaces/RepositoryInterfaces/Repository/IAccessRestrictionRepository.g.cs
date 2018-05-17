
// <copyright file="AccessRestriction.g.cs" company="MIT">
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
	/// The AccessRestrictionRepository interface that defines database functions for the AccessRestriction table
	/// </summary>
	public partial interface IAccessRestrictionRepository : IRepository<IAccessRestriction>
	{
		#region Load

        /// <summary>
        /// Load the AccessRestriction entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAccessRestriction</returns>
		IAccessRestriction LoadById(int id);

        /// <summary>
        /// Load AccessRestriction entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load AccessRestriction entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> LoadByUserName(string username);

        /// <summary>
        /// Load AccessRestriction entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">int</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> LoadByCedantId(int cedantid);

        /// <summary>
        /// Load AccessRestriction entities from the database using the Restriction field
        /// </summary>
        /// <param name="restriction">string</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> LoadByRestriction(string restriction);

        /// <summary>
        /// Load all AccessRestriction entities from the database.
        /// </summary>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AccessRestriction entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for AccessRestriction entities in the database by Restriction
        /// </summary>
        /// <param name="restriction">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAccessRestriction></returns>
		IList<IAccessRestriction> SearchByRestriction(string restriction, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AccessRestriction entity to the database.
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		bool Save(IAccessRestriction entity);
		
        /// <summary>
        /// Update the AccessRestriction entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		bool Update(IAccessRestriction entity);
		
        /// <summary>
        /// Delete the AccessRestriction entity from the database
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		bool Delete(IAccessRestriction entity);
		
        /// <summary>
        /// Delete the AccessRestriction entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
