
// <copyright file="ApplicantAttributeProfile.g.cs" company="MIT">
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
	/// The ApplicantAttributeProfileRepository interface that defines database functions for the ApplicantAttributeProfile table
	/// </summary>
	public partial interface IApplicantAttributeProfileRepository : IRepository<IApplicantAttributeProfile>
	{
		#region Load

        /// <summary>
        /// Load the ApplicantAttributeProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IApplicantAttributeProfile</returns>
		IApplicantAttributeProfile LoadById(int id);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByUserName(string username);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByName(string name);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByType(Nullable<int> type);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the AlsoForCustomer field
        /// </summary>
        /// <param name="alsoforcustomer">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByAlsoForCustomer(Nullable<bool> alsoforcustomer);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByStatus(Nullable<bool> status);

        /// <summary>
        /// Load ApplicantAttributeProfile entities from the database using the DisplayOnReport field
        /// </summary>
        /// <param name="displayonreport">Nullable<bool></param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadByDisplayOnReport(Nullable<bool> displayonreport);

        /// <summary>
        /// Load all ApplicantAttributeProfile entities from the database.
        /// </summary>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ApplicantAttributeProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for ApplicantAttributeProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttributeProfile></returns>
		IList<IApplicantAttributeProfile> SearchByName(string name, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ApplicantAttributeProfile entity to the database.
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		bool Save(IApplicantAttributeProfile entity);
		
        /// <summary>
        /// Update the ApplicantAttributeProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		bool Update(IApplicantAttributeProfile entity);
		
        /// <summary>
        /// Delete the ApplicantAttributeProfile entity from the database
        /// </summary>
        /// <param name="entity">IApplicantAttributeProfile</param>
        /// <returns>bool</returns>
		bool Delete(IApplicantAttributeProfile entity);
		
        /// <summary>
        /// Delete the ApplicantAttributeProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
