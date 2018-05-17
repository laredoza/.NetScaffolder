
// <copyright file="Address.g.cs" company="MIT">
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
	/// The AddressRepository interface that defines database functions for the Address table
	/// </summary>
	public partial interface IAddressRepository : IRepository<IAddress>
	{
		#region Load

        /// <summary>
        /// Load the Address entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAddress</returns>
		IAddress LoadById(int id);

        /// <summary>
        /// Load Address entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Address entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByUserName(string username);

        /// <summary>
        /// Load Address entities from the database using the Line1 field
        /// </summary>
        /// <param name="line1">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByLine1(string line1);

        /// <summary>
        /// Load Address entities from the database using the Line2 field
        /// </summary>
        /// <param name="line2">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByLine2(string line2);

        /// <summary>
        /// Load Address entities from the database using the Suburb field
        /// </summary>
        /// <param name="suburb">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadBySuburb(string suburb);

        /// <summary>
        /// Load Address entities from the database using the City field
        /// </summary>
        /// <param name="city">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByCity(string city);

        /// <summary>
        /// Load Address entities from the database using the PostalCode field
        /// </summary>
        /// <param name="postalcode">string</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByPostalCode(string postalcode);

        /// <summary>
        /// Load Address entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByType(Nullable<int> type);

        /// <summary>
        /// Load Address entities from the database using the DefaultAddress field
        /// </summary>
        /// <param name="defaultaddress">Nullable<bool></param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByDefaultAddress(Nullable<bool> defaultaddress);

        /// <summary>
        /// Load Address entities from the database using the StateProvinceId field
        /// </summary>
        /// <param name="stateprovinceid">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByStateProvinceId(Nullable<int> stateprovinceid);

        /// <summary>
        /// Load Address entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadByCountryId(Nullable<int> countryid);

        /// <summary>
        /// Load all Address entities from the database.
        /// </summary>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Address entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Address entities in the database by Line1
        /// </summary>
        /// <param name="line1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchByLine1(string line1, bool caseSensitive = false);

        /// <summary>
        /// Search for Address entities in the database by Line2
        /// </summary>
        /// <param name="line2">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchByLine2(string line2, bool caseSensitive = false);

        /// <summary>
        /// Search for Address entities in the database by Suburb
        /// </summary>
        /// <param name="suburb">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchBySuburb(string suburb, bool caseSensitive = false);

        /// <summary>
        /// Search for Address entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchByCity(string city, bool caseSensitive = false);

        /// <summary>
        /// Search for Address entities in the database by PostalCode
        /// </summary>
        /// <param name="postalcode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress></returns>
		IList<IAddress> SearchByPostalCode(string postalcode, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Address entity to the database.
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		bool Save(IAddress entity);
		
        /// <summary>
        /// Update the Address entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		bool Update(IAddress entity);
		
        /// <summary>
        /// Delete the Address entity from the database
        /// </summary>
        /// <param name="entity">IAddress</param>
        /// <returns>bool</returns>
		bool Delete(IAddress entity);
		
        /// <summary>
        /// Delete the Address entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
