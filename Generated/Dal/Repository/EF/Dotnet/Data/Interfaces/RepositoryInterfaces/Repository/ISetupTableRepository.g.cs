
// <copyright file="SetupTable.g.cs" company="MIT">
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
	/// The SetupTableRepository interface that defines database functions for the SetupTable table
	/// </summary>
	public partial interface ISetupTableRepository : IRepository<ISetupTable>
	{
		#region Load

        /// <summary>
        /// Load the SetupTable entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISetupTable</returns>
		ISetupTable LoadById(int id);

        /// <summary>
        /// Load SetupTable entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load SetupTable entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadByUserName(string username);

        /// <summary>
        /// Load SetupTable entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadByName(string name);

        /// <summary>
        /// Load SetupTable entities from the database using the canBeReferenced field
        /// </summary>
        /// <param name="canbereferenced">Nullable<bool></param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadBycanBeReferenced(Nullable<bool> canbereferenced);

        /// <summary>
        /// Load SetupTable entities from the database using the canBeMonitored field
        /// </summary>
        /// <param name="canbemonitored">Nullable<bool></param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadBycanBeMonitored(Nullable<bool> canbemonitored);

        /// <summary>
        /// Load all SetupTable entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SetupTable entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for SetupTable entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTable></returns>
		IList<ISetupTable> SearchByName(string name, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTable entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		bool Save(ISetupTable entity);
		
        /// <summary>
        /// Update the SetupTable entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		bool Update(ISetupTable entity);
		
        /// <summary>
        /// Delete the SetupTable entity from the database
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		bool Delete(ISetupTable entity);
		
        /// <summary>
        /// Delete the SetupTable entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
