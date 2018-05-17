
// <copyright file="Customer_Audit.g.cs" company="MIT">
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
	/// The Customer_AuditRepository interface that defines database functions for the Customer_Audit table
	/// </summary>
	public partial interface ICustomer_AuditRepository : IRepository<ICustomer_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Customer_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICustomer_Audit</returns>
		ICustomer_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Customer_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadById(int id);

        /// <summary>
        /// Load Customer_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Customer_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Customer_Audit entities from the database using the NationalID field
        /// </summary>
        /// <param name="nationalid">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByNationalID(string nationalid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadBySurname(string surname);

        /// <summary>
        /// Load Customer_Audit entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByFirstName(string firstname);

        /// <summary>
        /// Load Customer_Audit entities from the database using the DateOfBirth field
        /// </summary>
        /// <param name="dateofbirth">Nullable<DateTime></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByDateOfBirth(Nullable<DateTime> dateofbirth);

        /// <summary>
        /// Load Customer_Audit entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByEmailAddress(string emailaddress);

        /// <summary>
        /// Load Customer_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the CustomerUserId field
        /// </summary>
        /// <param name="customeruserid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByCustomerUserId(Nullable<int> customeruserid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByExternalReferenceId(string externalreferenceid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the ExternalReferenceLocked field
        /// </summary>
        /// <param name="externalreferencelocked">Nullable<bool></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByExternalReferenceLocked(Nullable<bool> externalreferencelocked);

        /// <summary>
        /// Load Customer_Audit entities from the database using the DoctorId field
        /// </summary>
        /// <param name="doctorid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByDoctorId(Nullable<int> doctorid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the PrimaryPhoneId field
        /// </summary>
        /// <param name="primaryphoneid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByPrimaryPhoneId(Nullable<int> primaryphoneid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the PrimaryAddressId field
        /// </summary>
        /// <param name="primaryaddressid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByPrimaryAddressId(Nullable<int> primaryaddressid);

        /// <summary>
        /// Load Customer_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all Customer_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Customer_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer_Audit entities in the database by NationalID
        /// </summary>
        /// <param name="nationalid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchByNationalID(string nationalid, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer_Audit entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer_Audit entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchByFirstName(string firstname, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer_Audit entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchByEmailAddress(string emailaddress, bool caseSensitive = false);

        /// <summary>
        /// Search for Customer_Audit entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		IList<ICustomer_Audit> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Customer_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		bool Save(ICustomer_Audit entity);
		
        /// <summary>
        /// Update the Customer_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		bool Update(ICustomer_Audit entity);
		
        /// <summary>
        /// Delete the Customer_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ICustomer_Audit entity);
		
        /// <summary>
        /// Delete the Customer_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
