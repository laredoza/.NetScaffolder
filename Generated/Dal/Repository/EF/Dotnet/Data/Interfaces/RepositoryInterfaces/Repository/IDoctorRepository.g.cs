
// <copyright file="Doctor.g.cs" company="MIT">
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
	/// The DoctorRepository interface that defines database functions for the Doctor table
	/// </summary>
	public partial interface IDoctorRepository : IRepository<IDoctor>
	{
		#region Load

        /// <summary>
        /// Load the Doctor entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IDoctor</returns>
		IDoctor LoadById(int id);

        /// <summary>
        /// Load Doctor entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Doctor entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadByUserName(string username);

        /// <summary>
        /// Load Doctor entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadBySurname(string surname);

        /// <summary>
        /// Load Doctor entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadByFirstName(string firstname);

        /// <summary>
        /// Load Doctor entities from the database using the AddressID field
        /// </summary>
        /// <param name="addressid">Nullable<int></param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadByAddressID(Nullable<int> addressid);

        /// <summary>
        /// Load Doctor entities from the database using the PhoneId field
        /// </summary>
        /// <param name="phoneid">Nullable<int></param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadByPhoneId(Nullable<int> phoneid);

        /// <summary>
        /// Load all Doctor entities from the database.
        /// </summary>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Doctor entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Doctor entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for Doctor entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor></returns>
		IList<IDoctor> SearchByFirstName(string firstname, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Doctor entity to the database.
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		bool Save(IDoctor entity);
		
        /// <summary>
        /// Update the Doctor entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		bool Update(IDoctor entity);
		
        /// <summary>
        /// Delete the Doctor entity from the database
        /// </summary>
        /// <param name="entity">IDoctor</param>
        /// <returns>bool</returns>
		bool Delete(IDoctor entity);
		
        /// <summary>
        /// Delete the Doctor entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
