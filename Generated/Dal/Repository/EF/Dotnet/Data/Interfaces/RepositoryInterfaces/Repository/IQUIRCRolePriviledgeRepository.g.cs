
// <copyright file="QUIRCRolePriviledge.g.cs" company="MIT">
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
	/// The QUIRCRolePriviledgeRepository interface that defines database functions for the QUIRCRolePriviledge table
	/// </summary>
	public partial interface IQUIRCRolePriviledgeRepository : IRepository<IQUIRCRolePriviledge>
	{
		#region Load

        /// <summary>
        /// Load the QUIRCRolePriviledge entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCRolePriviledge</returns>
		IQUIRCRolePriviledge LoadById(int id);

        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> LoadByUserName(string username);

        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the RoleId field
        /// </summary>
        /// <param name="roleid">int</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> LoadByRoleId(int roleid);

        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the Priviledge field
        /// </summary>
        /// <param name="priviledge">int</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> LoadByPriviledge(int priviledge);

        /// <summary>
        /// Load all QUIRCRolePriviledge entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QUIRCRolePriviledge entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		IList<IQUIRCRolePriviledge> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCRolePriviledge entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		bool Save(IQUIRCRolePriviledge entity);
		
        /// <summary>
        /// Update the QUIRCRolePriviledge entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		bool Update(IQUIRCRolePriviledge entity);
		
        /// <summary>
        /// Delete the QUIRCRolePriviledge entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		bool Delete(IQUIRCRolePriviledge entity);
		
        /// <summary>
        /// Delete the QUIRCRolePriviledge entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
