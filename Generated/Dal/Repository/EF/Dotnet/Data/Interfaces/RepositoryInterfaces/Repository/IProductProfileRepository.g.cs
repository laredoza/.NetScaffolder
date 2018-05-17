
// <copyright file="ProductProfile.g.cs" company="MIT">
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
	/// The ProductProfileRepository interface that defines database functions for the ProductProfile table
	/// </summary>
	public partial interface IProductProfileRepository : IRepository<IProductProfile>
	{
		#region Load

        /// <summary>
        /// Load the ProductProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductProfile</returns>
		IProductProfile LoadById(int id);

        /// <summary>
        /// Load ProductProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ProductProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> LoadByUserName(string username);

        /// <summary>
        /// Load ProductProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> LoadByName(string name);

        /// <summary>
        /// Load ProductProfile entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> LoadByDescription(string description);

        /// <summary>
        /// Load all ProductProfile entities from the database.
        /// </summary>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ProductProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for ProductProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for ProductProfile entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		IList<IProductProfile> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductProfile entity to the database.
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		bool Save(IProductProfile entity);
		
        /// <summary>
        /// Update the ProductProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		bool Update(IProductProfile entity);
		
        /// <summary>
        /// Delete the ProductProfile entity from the database
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		bool Delete(IProductProfile entity);
		
        /// <summary>
        /// Delete the ProductProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
