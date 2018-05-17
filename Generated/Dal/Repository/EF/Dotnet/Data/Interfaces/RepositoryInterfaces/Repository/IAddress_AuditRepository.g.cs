
// <copyright file="Address_Audit.g.cs" company="MIT">
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
	/// The Address_AuditRepository interface that defines database functions for the Address_Audit table
	/// </summary>
	public partial interface IAddress_AuditRepository : IRepository<IAddress_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Address_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IAddress_Audit</returns>
		IAddress_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Address_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadById(int id);

        /// <summary>
        /// Load Address_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Address_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Address_Audit entities from the database using the Line1 field
        /// </summary>
        /// <param name="line1">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByLine1(string line1);

        /// <summary>
        /// Load Address_Audit entities from the database using the Line2 field
        /// </summary>
        /// <param name="line2">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByLine2(string line2);

        /// <summary>
        /// Load Address_Audit entities from the database using the Suburb field
        /// </summary>
        /// <param name="suburb">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadBySuburb(string suburb);

        /// <summary>
        /// Load Address_Audit entities from the database using the City field
        /// </summary>
        /// <param name="city">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByCity(string city);

        /// <summary>
        /// Load Address_Audit entities from the database using the PostalCode field
        /// </summary>
        /// <param name="postalcode">string</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByPostalCode(string postalcode);

        /// <summary>
        /// Load Address_Audit entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByType(Nullable<int> type);

        /// <summary>
        /// Load Address_Audit entities from the database using the DefaultAddress field
        /// </summary>
        /// <param name="defaultaddress">Nullable<bool></param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByDefaultAddress(Nullable<bool> defaultaddress);

        /// <summary>
        /// Load Address_Audit entities from the database using the StateProvinceId field
        /// </summary>
        /// <param name="stateprovinceid">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByStateProvinceId(Nullable<int> stateprovinceid);

        /// <summary>
        /// Load Address_Audit entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByCountryId(Nullable<int> countryid);

        /// <summary>
        /// Load Address_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all Address_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Address_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Address_Audit entities in the database by Line1
        /// </summary>
        /// <param name="line1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchByLine1(string line1, bool caseSensitive = false);

        /// <summary>
        /// Search for Address_Audit entities in the database by Line2
        /// </summary>
        /// <param name="line2">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchByLine2(string line2, bool caseSensitive = false);

        /// <summary>
        /// Search for Address_Audit entities in the database by Suburb
        /// </summary>
        /// <param name="suburb">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchBySuburb(string suburb, bool caseSensitive = false);

        /// <summary>
        /// Search for Address_Audit entities in the database by City
        /// </summary>
        /// <param name="city">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchByCity(string city, bool caseSensitive = false);

        /// <summary>
        /// Search for Address_Audit entities in the database by PostalCode
        /// </summary>
        /// <param name="postalcode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAddress_Audit></returns>
		IList<IAddress_Audit> SearchByPostalCode(string postalcode, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Address_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		bool Save(IAddress_Audit entity);
		
        /// <summary>
        /// Update the Address_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		bool Update(IAddress_Audit entity);
		
        /// <summary>
        /// Delete the Address_Audit entity from the database
        /// </summary>
        /// <param name="entity">IAddress_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IAddress_Audit entity);
		
        /// <summary>
        /// Delete the Address_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
