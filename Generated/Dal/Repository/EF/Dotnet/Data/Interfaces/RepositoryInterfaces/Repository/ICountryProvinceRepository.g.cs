﻿
// <copyright file="CountryProvince.g.cs" company="MIT">
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
	/// The CountryProvinceRepository interface that defines database functions for the CountryProvince table
	/// </summary>
	public partial interface ICountryProvinceRepository : IRepository<ICountryProvince>
	{
		#region Load

        /// <summary>
        /// Load the CountryProvince entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICountryProvince</returns>
		ICountryProvince LoadById(int id);

        /// <summary>
        /// Load CountryProvince entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load CountryProvince entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByUserName(string username);

        /// <summary>
        /// Load CountryProvince entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByCode(string code);

        /// <summary>
        /// Load CountryProvince entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByName(string name);

        /// <summary>
        /// Load CountryProvince entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load CountryProvince entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadByParentId(Nullable<int> parentid);

        /// <summary>
        /// Load all CountryProvince entities from the database.
        /// </summary>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CountryProvince entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for CountryProvince entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> SearchByCode(string code, bool caseSensitive = false);

        /// <summary>
        /// Search for CountryProvince entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince></returns>
		IList<ICountryProvince> SearchByName(string name, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CountryProvince entity to the database.
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		bool Save(ICountryProvince entity);
		
        /// <summary>
        /// Update the CountryProvince entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		bool Update(ICountryProvince entity);
		
        /// <summary>
        /// Delete the CountryProvince entity from the database
        /// </summary>
        /// <param name="entity">ICountryProvince</param>
        /// <returns>bool</returns>
		bool Delete(ICountryProvince entity);
		
        /// <summary>
        /// Delete the CountryProvince entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
