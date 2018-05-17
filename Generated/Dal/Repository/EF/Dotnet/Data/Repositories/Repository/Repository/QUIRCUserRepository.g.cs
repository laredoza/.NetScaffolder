
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The QUIRCUserRepository class responsible for database functions in the QUIRCUser table
	/// </summary>
	public partial class QUIRCUserRepository : UowRepository<QUIRCUser> , IQUIRCUserRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QUIRCUserRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QUIRCUserRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QUIRCUser entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCUser</returns>
		public virtual IQUIRCUser LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QUIRCUser>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Stamp == stamp).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.UserName == username).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the LoginId field
        /// </summary>
        /// <param name="loginid">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByLoginId(string loginid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LoginId == loginid).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordHash field
        /// </summary>
        /// <param name="passwordhash">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByPasswordHash(string passwordhash)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordHash == passwordhash).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordSalt field
        /// </summary>
        /// <param name="passwordsalt">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByPasswordSalt(string passwordsalt)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordSalt == passwordsalt).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByEmailAddress(string emailaddress)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.EmailAddress == emailaddress).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByFirstName(string firstname)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.FirstName == firstname).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Surname == surname).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the Role field
        /// </summary>
        /// <param name="role">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByRole(Nullable<int> role)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Role == role).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Status == status).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the SecurityQuestions field
        /// </summary>
        /// <param name="securityquestions">string</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadBySecurityQuestions(string securityquestions)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.SecurityQuestions == securityquestions).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the CendantId field
        /// </summary>
        /// <param name="cendantid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByCendantId(Nullable<int> cendantid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.CendantId == cendantid).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the CedantUserLoadingLimitId field
        /// </summary>
        /// <param name="cedantuserloadinglimitid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByCedantUserLoadingLimitId(Nullable<int> cedantuserloadinglimitid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.CedantUserLoadingLimitId == cedantuserloadinglimitid).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the LastLogin field
        /// </summary>
        /// <param name="lastlogin">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByLastLogin(Nullable<DateTime> lastlogin)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LastLogin == lastlogin).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutenabled">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByLockoutEnabled(Nullable<bool> lockoutenabled)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LockoutEnabled == lockoutenabled).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twofactorenabled">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByTwoFactorEnabled(Nullable<bool> twofactorenabled)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.TwoFactorEnabled == twofactorenabled).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessfailedcount">Nullable<int></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByAccessFailedCount(Nullable<int> accessfailedcount)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.AccessFailedCount == accessfailedcount).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the LockoutEndDate field
        /// </summary>
        /// <param name="lockoutenddate">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByLockoutEndDate(Nullable<DateTime> lockoutenddate)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LockoutEndDate == lockoutenddate).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the PasswordResetToken field
        /// </summary>
        /// <param name="passwordresettoken">Nullable<Guid></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByPasswordResetToken(Nullable<Guid> passwordresettoken)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordResetToken == passwordresettoken).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load QUIRCUser entities from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailconfirmed">Nullable<bool></param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadByEmailConfirmed(Nullable<bool> emailconfirmed)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.EmailConfirmed == emailconfirmed).ToList<IQUIRCUser>();
		}
		
        /// <summary>
        /// Load all QUIRCUser entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> LoadAll()
		{
			return this.UnitOfWork.GetAll<QUIRCUser>().ToList<IQUIRCUser>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.UserName.Contains(username)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by LoginId
        /// </summary>
        /// <param name="loginid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByLoginId(string loginid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LoginId.ToLower().Contains(loginid.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.LoginId.Contains(loginid)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordhash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByPasswordHash(string passwordhash, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordHash.ToLower().Contains(passwordhash.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordHash.Contains(passwordhash)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by PasswordSalt
        /// </summary>
        /// <param name="passwordsalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByPasswordSalt(string passwordsalt, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordSalt.ToLower().Contains(passwordsalt.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.PasswordSalt.Contains(passwordsalt)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByEmailAddress(string emailaddress, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.EmailAddress.ToLower().Contains(emailaddress.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.EmailAddress.Contains(emailaddress)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchByFirstName(string firstname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.FirstName.ToLower().Contains(firstname.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.FirstName.Contains(firstname)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.Surname.Contains(surname)).ToList<IQUIRCUser>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser entities in the database by SecurityQuestions
        /// </summary>
        /// <param name="securityquestions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser></returns>
		public virtual IList<IQUIRCUser> SearchBySecurityQuestions(string securityquestions, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.SecurityQuestions.ToLower().Contains(securityquestions.ToLower())).ToList<IQUIRCUser>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser>(o => o.SecurityQuestions.Contains(securityquestions)).ToList<IQUIRCUser>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUser entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQUIRCUser entity)
		{
			var entityToSave = new QUIRCUser(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QUIRCUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQUIRCUser entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QUIRCUser>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QUIRCUser entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.LoginId != entity.LoginId) { entityToUpdate.LoginId = entity.LoginId;doUpdate = true; }
			if (entityToUpdate.PasswordHash != entity.PasswordHash) { entityToUpdate.PasswordHash = entity.PasswordHash;doUpdate = true; }
			if (entityToUpdate.PasswordSalt != entity.PasswordSalt) { entityToUpdate.PasswordSalt = entity.PasswordSalt;doUpdate = true; }
			if (entityToUpdate.EmailAddress != entity.EmailAddress) { entityToUpdate.EmailAddress = entity.EmailAddress;doUpdate = true; }
			if (entityToUpdate.FirstName != entity.FirstName) { entityToUpdate.FirstName = entity.FirstName;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.Role != entity.Role) { entityToUpdate.Role = entity.Role;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.SecurityQuestions != entity.SecurityQuestions) { entityToUpdate.SecurityQuestions = entity.SecurityQuestions;doUpdate = true; }
			if (entityToUpdate.CendantId != entity.CendantId) { entityToUpdate.CendantId = entity.CendantId;doUpdate = true; }
			if (entityToUpdate.CedantUserLoadingLimitId != entity.CedantUserLoadingLimitId) { entityToUpdate.CedantUserLoadingLimitId = entity.CedantUserLoadingLimitId;doUpdate = true; }
			if (entityToUpdate.LastLogin != entity.LastLogin) { entityToUpdate.LastLogin = entity.LastLogin;doUpdate = true; }
			if (entityToUpdate.LockoutEnabled != entity.LockoutEnabled) { entityToUpdate.LockoutEnabled = entity.LockoutEnabled;doUpdate = true; }
			if (entityToUpdate.TwoFactorEnabled != entity.TwoFactorEnabled) { entityToUpdate.TwoFactorEnabled = entity.TwoFactorEnabled;doUpdate = true; }
			if (entityToUpdate.AccessFailedCount != entity.AccessFailedCount) { entityToUpdate.AccessFailedCount = entity.AccessFailedCount;doUpdate = true; }
			if (entityToUpdate.LockoutEndDate != entity.LockoutEndDate) { entityToUpdate.LockoutEndDate = entity.LockoutEndDate;doUpdate = true; }
			if (entityToUpdate.PasswordResetToken != entity.PasswordResetToken) { entityToUpdate.PasswordResetToken = entity.PasswordResetToken;doUpdate = true; }
			if (entityToUpdate.EmailConfirmed != entity.EmailConfirmed) { entityToUpdate.EmailConfirmed = entity.EmailConfirmed;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QUIRCUser entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUser</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQUIRCUser entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUser>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUser entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QUIRCUser entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUser>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUser entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
