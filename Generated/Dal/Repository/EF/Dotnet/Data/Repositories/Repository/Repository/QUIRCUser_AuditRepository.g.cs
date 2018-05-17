
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The QUIRCUser_AuditRepository class responsible for database functions in the QUIRCUser_Audit table
	/// </summary>
	public partial class QUIRCUser_AuditRepository : UowRepository<QUIRCUser_Audit> , IQUIRCUser_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QUIRCUser_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QUIRCUser_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QUIRCUser_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IQUIRCUser_Audit</returns>
		public virtual IQUIRCUser_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<QUIRCUser_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Id == id).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Stamp == stamp).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.UserName == username).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the LoginId field
        /// </summary>
        /// <param name="loginid">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByLoginId(string loginid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.LoginId == loginid).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the PasswordHash field
        /// </summary>
        /// <param name="passwordhash">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByPasswordHash(string passwordhash)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordHash == passwordhash).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the PasswordSalt field
        /// </summary>
        /// <param name="passwordsalt">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByPasswordSalt(string passwordsalt)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordSalt == passwordsalt).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByEmailAddress(string emailaddress)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.EmailAddress == emailaddress).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByFirstName(string firstname)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.FirstName == firstname).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Surname == surname).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Role field
        /// </summary>
        /// <param name="role">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByRole(Nullable<int> role)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Role == role).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Status == status).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the SecurityQuestions field
        /// </summary>
        /// <param name="securityquestions">string</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadBySecurityQuestions(string securityquestions)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.SecurityQuestions == securityquestions).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the CendantId field
        /// </summary>
        /// <param name="cendantid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByCendantId(Nullable<int> cendantid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.CendantId == cendantid).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the CedantUserLoadingLimitId field
        /// </summary>
        /// <param name="cedantuserloadinglimitid">Nullable<int></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByCedantUserLoadingLimitId(Nullable<int> cedantuserloadinglimitid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.CedantUserLoadingLimitId == cedantuserloadinglimitid).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the LastLogin field
        /// </summary>
        /// <param name="lastlogin">Nullable<DateTime></param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByLastLogin(Nullable<DateTime> lastlogin)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.LastLogin == lastlogin).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load QUIRCUser_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IQUIRCUser_Audit>();
		}
		
        /// <summary>
        /// Load all QUIRCUser_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<QUIRCUser_Audit>().ToList<IQUIRCUser_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.UserName.Contains(username)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by LoginId
        /// </summary>
        /// <param name="loginid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByLoginId(string loginid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.LoginId.ToLower().Contains(loginid.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.LoginId.Contains(loginid)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordhash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByPasswordHash(string passwordhash, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordHash.ToLower().Contains(passwordhash.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordHash.Contains(passwordhash)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by PasswordSalt
        /// </summary>
        /// <param name="passwordsalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByPasswordSalt(string passwordsalt, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordSalt.ToLower().Contains(passwordsalt.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.PasswordSalt.Contains(passwordsalt)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByEmailAddress(string emailaddress, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.EmailAddress.ToLower().Contains(emailaddress.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.EmailAddress.Contains(emailaddress)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchByFirstName(string firstname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.FirstName.ToLower().Contains(firstname.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.FirstName.Contains(firstname)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.Surname.Contains(surname)).ToList<IQUIRCUser_Audit>();
			}
		}
		
        /// <summary>
        /// Search for QUIRCUser_Audit entities in the database by SecurityQuestions
        /// </summary>
        /// <param name="securityquestions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUser_Audit></returns>
		public virtual IList<IQUIRCUser_Audit> SearchBySecurityQuestions(string securityquestions, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.SecurityQuestions.ToLower().Contains(securityquestions.ToLower())).ToList<IQUIRCUser_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUser_Audit>(o => o.SecurityQuestions.Contains(securityquestions)).ToList<IQUIRCUser_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUser_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQUIRCUser_Audit entity)
		{
			var entityToSave = new QUIRCUser_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QUIRCUser_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQUIRCUser_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QUIRCUser_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QUIRCUser_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
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
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QUIRCUser_Audit entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUser_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQUIRCUser_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUser_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUser_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QUIRCUser_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUser_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUser_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
