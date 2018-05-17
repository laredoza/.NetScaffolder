
// <copyright file="QUIRCUser_Audit.g.cs" company="MIT">
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
	/// The QUIRCUser_AuditRepository interface that defines database functions for the QUIRCUser_Audit table
	/// </summary>
	public partial interface IQUIRCUser_AuditRepository : IRepository<IQUIRCUser_Audit>
	{
		#region Load

        /// <summary>
        /// Load the QUIRCUser_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IQUIRCUser_Audit</returns>
		IQUIRCUser_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadById(int id);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the LoginId field
        /// </summary>
        /// <param name="loginid">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByLoginId(string loginid);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the PasswordHash field
        /// </summary>
        /// <param name="passwordhash">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByPasswordHash(string passwordhash);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the PasswordSalt field
        /// </summary>
        /// <param name="passwordsalt">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByPasswordSalt(string passwordsalt);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByEmailAddress(string emailaddress);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByFirstName(string firstname);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadBySurname(string surname);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Role field
        /// </summary>
        /// <param name="role">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByRole(Nullable<int> role);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the SecurityQuestions field
        /// </summary>
        /// <param name="securityquestions">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadBySecurityQuestions(string securityquestions);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the CendantId field
        /// </summary>
        /// <param name="cendantid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByCendantId(Nullable<int> cendantid);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the CedantUserLoadingLimitId field
        /// </summary>
        /// <param name="cedantuserloadinglimitid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByCedantUserLoadingLimitId(Nullable<int> cedantuserloadinglimitid);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the LastLogin field
        /// </summary>
        /// <param name="lastlogin">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByLastLogin(Nullable<DateTime> lastlogin);

        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all QUIRCUser_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by LoginId
        /// </summary>
        /// <param name="loginid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByLoginId(string loginid, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordhash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByPasswordHash(string passwordhash, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by PasswordSalt
        /// </summary>
        /// <param name="passwordsalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByPasswordSalt(string passwordsalt, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByEmailAddress(string emailaddress, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchByFirstName(string firstname, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by SecurityQuestions
        /// </summary>
        /// <param name="securityquestions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		IList<IQUIRCUser_Audit> SearchBySecurityQuestions(string securityquestions, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUser_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		bool Save(IQUIRCUser_Audit entity);
		
        /// <summary>
        /// Update the QUIRCUser_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		bool Update(IQUIRCUser_Audit entity);
		
        /// <summary>
        /// Delete the QUIRCUser_Audit entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IQUIRCUser_Audit entity);
		
        /// <summary>
        /// Delete the QUIRCUser_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
