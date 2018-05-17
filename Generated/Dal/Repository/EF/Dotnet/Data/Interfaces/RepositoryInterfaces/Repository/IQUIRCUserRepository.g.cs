
// <copyright file="QUIRCUser.g.cs" company="MIT">
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
	/// The QUIRCUserRepository interface that defines database functions for the QUIRCUser table
	/// </summary>
	public partial interface IQUIRCUserRepository : IRepository<IQUIRCUser>
	{
		#region Load

        /// <summary>
        /// Load the QUIRCUser entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCUser</returns>
		IQUIRCUser LoadById(int id);

        /// <summary>
        /// Load QUIRCUser entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load QUIRCUser entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByUserName(string username);

        /// <summary>
        /// Load QUIRCUser entities from the database using the LoginId field
        /// </summary>
        /// <param name="loginid">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByLoginId(string loginid);

        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordHash field
        /// </summary>
        /// <param name="passwordhash">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByPasswordHash(string passwordhash);

        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordSalt field
        /// </summary>
        /// <param name="passwordsalt">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByPasswordSalt(string passwordsalt);

        /// <summary>
        /// Load QUIRCUser entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByEmailAddress(string emailaddress);

        /// <summary>
        /// Load QUIRCUser entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByFirstName(string firstname);

        /// <summary>
        /// Load QUIRCUser entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadBySurname(string surname);

        /// <summary>
        /// Load QUIRCUser entities from the database using the Role field
        /// </summary>
        /// <param name="role">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByRole(Nullable<int> role);

        /// <summary>
        /// Load QUIRCUser entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load QUIRCUser entities from the database using the SecurityQuestions field
        /// </summary>
        /// <param name="securityquestions">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadBySecurityQuestions(string securityquestions);

        /// <summary>
        /// Load QUIRCUser entities from the database using the CendantId field
        /// </summary>
        /// <param name="cendantid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByCendantId(Nullable<int> cendantid);

        /// <summary>
        /// Load QUIRCUser entities from the database using the CedantUserLoadingLimitId field
        /// </summary>
        /// <param name="cedantuserloadinglimitid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByCedantUserLoadingLimitId(Nullable<int> cedantuserloadinglimitid);

        /// <summary>
        /// Load QUIRCUser entities from the database using the LastLogin field
        /// </summary>
        /// <param name="lastlogin">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByLastLogin(Nullable<DateTime> lastlogin);

        /// <summary>
        /// Load QUIRCUser entities from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutenabled">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByLockoutEnabled(Nullable<bool> lockoutenabled);

        /// <summary>
        /// Load QUIRCUser entities from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twofactorenabled">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByTwoFactorEnabled(Nullable<bool> twofactorenabled);

        /// <summary>
        /// Load QUIRCUser entities from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessfailedcount">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByAccessFailedCount(Nullable<int> accessfailedcount);

        /// <summary>
        /// Load QUIRCUser entities from the database using the LockoutEndDate field
        /// </summary>
        /// <param name="lockoutenddate">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByLockoutEndDate(Nullable<DateTime> lockoutenddate);

        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordResetToken field
        /// </summary>
        /// <param name="passwordresettoken">Nullable<Guid></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByPasswordResetToken(Nullable<Guid> passwordresettoken);

        /// <summary>
        /// Load QUIRCUser entities from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailconfirmed">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadByEmailConfirmed(Nullable<bool> emailconfirmed);

        /// <summary>
        /// Load all QUIRCUser entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for QUIRCUser entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by LoginId
        /// </summary>
        /// <param name="loginid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByLoginId(string loginid, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordhash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByPasswordHash(string passwordhash, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by PasswordSalt
        /// </summary>
        /// <param name="passwordsalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByPasswordSalt(string passwordsalt, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByEmailAddress(string emailaddress, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchByFirstName(string firstname, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchBySurname(string surname, bool caseSensitive = false);

        /// <summary>
        /// Search for QUIRCUser entities in the database by SecurityQuestions
        /// </summary>
        /// <param name="securityquestions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		IList<IQUIRCUser> SearchBySecurityQuestions(string securityquestions, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUser entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		bool Save(IQUIRCUser entity);
		
        /// <summary>
        /// Update the QUIRCUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		bool Update(IQUIRCUser entity);
		
        /// <summary>
        /// Delete the QUIRCUser entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		bool Delete(IQUIRCUser entity);
		
        /// <summary>
        /// Delete the QUIRCUser entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
