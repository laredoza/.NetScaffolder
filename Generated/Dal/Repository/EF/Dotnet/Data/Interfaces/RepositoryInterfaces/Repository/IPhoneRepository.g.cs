
// <copyright file="Phone.g.cs" company="MIT">
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
	/// The PhoneRepository interface that defines database functions for the Phone table
	/// </summary>
	public partial interface IPhoneRepository : IRepository<IPhone>
	{
		#region Load

        /// <summary>
        /// Load the Phone entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPhone</returns>
		IPhone LoadById(int id);

        /// <summary>
        /// Load Phone entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Phone entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByUserName(string username);

        /// <summary>
        /// Load Phone entities from the database using the CountryCode field
        /// </summary>
        /// <param name="countrycode">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByCountryCode(Nullable<int> countrycode);

        /// <summary>
        /// Load Phone entities from the database using the AreaCode field
        /// </summary>
        /// <param name="areacode">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByAreaCode(Nullable<int> areacode);

        /// <summary>
        /// Load Phone entities from the database using the Number field
        /// </summary>
        /// <param name="number">string</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByNumber(string number);

        /// <summary>
        /// Load Phone entities from the database using the Extension field
        /// </summary>
        /// <param name="extension">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByExtension(Nullable<int> extension);

        /// <summary>
        /// Load Phone entities from the database using the FormattedNumber field
        /// </summary>
        /// <param name="formattednumber">string</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByFormattedNumber(string formattednumber);

        /// <summary>
        /// Load Phone entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByType(Nullable<int> type);

        /// <summary>
        /// Load Phone entities from the database using the DefaultPhone field
        /// </summary>
        /// <param name="defaultphone">Nullable<bool></param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadByDefaultPhone(Nullable<bool> defaultphone);

        /// <summary>
        /// Load all Phone entities from the database.
        /// </summary>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Phone entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Phone entities in the database by Number
        /// </summary>
        /// <param name="number">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> SearchByNumber(string number, bool caseSensitive = false);

        /// <summary>
        /// Search for Phone entities in the database by FormattedNumber
        /// </summary>
        /// <param name="formattednumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPhone></returns>
		IList<IPhone> SearchByFormattedNumber(string formattednumber, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Phone entity to the database.
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		bool Save(IPhone entity);
		
        /// <summary>
        /// Update the Phone entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		bool Update(IPhone entity);
		
        /// <summary>
        /// Delete the Phone entity from the database
        /// </summary>
        /// <param name="entity">IPhone</param>
        /// <returns>bool</returns>
		bool Delete(IPhone entity);
		
        /// <summary>
        /// Delete the Phone entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
