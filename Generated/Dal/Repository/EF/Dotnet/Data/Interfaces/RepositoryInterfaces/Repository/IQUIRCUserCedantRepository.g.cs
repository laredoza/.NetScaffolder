
// <copyright file="QUIRCUserCedant.g.cs" company="MIT">
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
	/// The QUIRCUserCedantRepository interface that defines database functions for the QUIRCUserCedant table
	/// </summary>
	public partial interface IQUIRCUserCedantRepository : IRepository<IQUIRCUserCedant>
	{
		#region Load

        /// <summary>
        /// Load the QUIRCUserCedant entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCUserCedant</returns>
		IQUIRCUserCedant LoadById(int id);

        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadByUserName(string username);

        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadByUserId(int userid);

        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadByCedantId(int cedantid);

        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserRole field
        /// </summary>
        /// <param name="userrole">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadByUserRole(int userrole);

        /// <summary>
        /// Load all QUIRCUserCedant entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QUIRCUserCedant entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		IList<IQUIRCUserCedant> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUserCedant entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		bool Save(IQUIRCUserCedant entity);
		
        /// <summary>
        /// Update the QUIRCUserCedant entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		bool Update(IQUIRCUserCedant entity);
		
        /// <summary>
        /// Delete the QUIRCUserCedant entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		bool Delete(IQUIRCUserCedant entity);
		
        /// <summary>
        /// Delete the QUIRCUserCedant entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
