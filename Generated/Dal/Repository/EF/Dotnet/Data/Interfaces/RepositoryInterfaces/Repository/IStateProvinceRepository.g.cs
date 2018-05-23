﻿
// <copyright file="StateProvince.g.cs" company="MIT">
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
	/// The StateProvinceRepository interface that defines database functions for the StateProvince table
	/// </summary>
	public partial interface IStateProvinceRepository : IRepository<IStateProvince>
	{
		#region Load

        /// <summary>
        /// Load the StateProvince entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IStateProvince</returns>
		IStateProvince LoadById(int id);

        /// <summary>
        /// Load StateProvince entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load StateProvince entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByUserName(string username);

        /// <summary>
        /// Load StateProvince entities from the database using the StateProvinceCode field
        /// </summary>
        /// <param name="stateprovincecode">string</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByStateProvinceCode(string stateprovincecode);

        /// <summary>
        /// Load StateProvince entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByName(string name);

        /// <summary>
        /// Load StateProvince entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load StateProvince entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadByCountryId(Nullable<int> countryid);

        /// <summary>
        /// Load all StateProvince entities from the database.
        /// </summary>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for StateProvince entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for StateProvince entities in the database by StateProvinceCode
        /// </summary>
        /// <param name="stateprovincecode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> SearchByStateProvinceCode(string stateprovincecode, bool caseSensitive = false);

        /// <summary>
        /// Search for StateProvince entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince></returns>
		IList<IStateProvince> SearchByName(string name, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StateProvince entity to the database.
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		bool Save(IStateProvince entity);
		
        /// <summary>
        /// Update the StateProvince entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		bool Update(IStateProvince entity);
		
        /// <summary>
        /// Delete the StateProvince entity from the database
        /// </summary>
        /// <param name="entity">IStateProvince</param>
        /// <returns>bool</returns>
		bool Delete(IStateProvince entity);
		
        /// <summary>
        /// Delete the StateProvince entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}