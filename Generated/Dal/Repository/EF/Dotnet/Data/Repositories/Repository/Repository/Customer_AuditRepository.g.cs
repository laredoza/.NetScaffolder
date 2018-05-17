
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
using RepositoryEFDotnet.Library;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The Customer_AuditRepository class responsible for database functions in the Customer_Audit table
	/// </summary>
	public partial class Customer_AuditRepository : UowRepository<Customer_Audit> , ICustomer_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Customer_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Customer_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Customer_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICustomer_Audit</returns>
		public virtual ICustomer_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Customer_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.Id == id).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.Stamp == stamp).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.UserName == username).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the NationalID field
        /// </summary>
        /// <param name="nationalid">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByNationalID(string nationalid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.NationalID == nationalid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.Surname == surname).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByFirstName(string firstname)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.FirstName == firstname).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the DateOfBirth field
        /// </summary>
        /// <param name="dateofbirth">Nullable<DateTime></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByDateOfBirth(Nullable<DateTime> dateofbirth)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.DateOfBirth == dateofbirth).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the EmailAddress field
        /// </summary>
        /// <param name="emailaddress">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByEmailAddress(string emailaddress)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.EmailAddress == emailaddress).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.UserId == userid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the CustomerUserId field
        /// </summary>
        /// <param name="customeruserid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByCustomerUserId(Nullable<int> customeruserid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.CustomerUserId == customeruserid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByExternalReferenceId(string externalreferenceid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.ExternalReferenceId == externalreferenceid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the ExternalReferenceLocked field
        /// </summary>
        /// <param name="externalreferencelocked">Nullable<bool></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByExternalReferenceLocked(Nullable<bool> externalreferencelocked)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.ExternalReferenceLocked == externalreferencelocked).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the DoctorId field
        /// </summary>
        /// <param name="doctorid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByDoctorId(Nullable<int> doctorid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.DoctorId == doctorid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the PrimaryPhoneId field
        /// </summary>
        /// <param name="primaryphoneid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByPrimaryPhoneId(Nullable<int> primaryphoneid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.PrimaryPhoneId == primaryphoneid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the PrimaryAddressId field
        /// </summary>
        /// <param name="primaryaddressid">Nullable<int></param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByPrimaryAddressId(Nullable<int> primaryaddressid)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.PrimaryAddressId == primaryaddressid).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load Customer_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICustomer_Audit>();
		}
		
        /// <summary>
        /// Load all Customer_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Customer_Audit>().ToList<ICustomer_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.UserName.Contains(username)).ToList<ICustomer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by NationalID
        /// </summary>
        /// <param name="nationalid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchByNationalID(string nationalid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.NationalID.ToLower().Contains(nationalid.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.NationalID.Contains(nationalid)).ToList<ICustomer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.Surname.Contains(surname)).ToList<ICustomer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchByFirstName(string firstname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.FirstName.ToLower().Contains(firstname.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.FirstName.Contains(firstname)).ToList<ICustomer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by EmailAddress
        /// </summary>
        /// <param name="emailaddress">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchByEmailAddress(string emailaddress, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.EmailAddress.ToLower().Contains(emailaddress.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.EmailAddress.Contains(emailaddress)).ToList<ICustomer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Customer_Audit entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICustomer_Audit></returns>
		public virtual IList<ICustomer_Audit> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.ExternalReferenceId.ToLower().Contains(externalreferenceid.ToLower())).ToList<ICustomer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Customer_Audit>(o => o.ExternalReferenceId.Contains(externalreferenceid)).ToList<ICustomer_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Customer_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICustomer_Audit entity)
		{
			var entityToSave = new Customer_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Customer_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICustomer_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Customer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Customer_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.NationalID != entity.NationalID) { entityToUpdate.NationalID = entity.NationalID;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.FirstName != entity.FirstName) { entityToUpdate.FirstName = entity.FirstName;doUpdate = true; }
			if (entityToUpdate.DateOfBirth != entity.DateOfBirth) { entityToUpdate.DateOfBirth = entity.DateOfBirth;doUpdate = true; }
			if (entityToUpdate.EmailAddress != entity.EmailAddress) { entityToUpdate.EmailAddress = entity.EmailAddress;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.CustomerUserId != entity.CustomerUserId) { entityToUpdate.CustomerUserId = entity.CustomerUserId;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceId != entity.ExternalReferenceId) { entityToUpdate.ExternalReferenceId = entity.ExternalReferenceId;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceLocked != entity.ExternalReferenceLocked) { entityToUpdate.ExternalReferenceLocked = entity.ExternalReferenceLocked;doUpdate = true; }
			if (entityToUpdate.DoctorId != entity.DoctorId) { entityToUpdate.DoctorId = entity.DoctorId;doUpdate = true; }
			if (entityToUpdate.PrimaryPhoneId != entity.PrimaryPhoneId) { entityToUpdate.PrimaryPhoneId = entity.PrimaryPhoneId;doUpdate = true; }
			if (entityToUpdate.PrimaryAddressId != entity.PrimaryAddressId) { entityToUpdate.PrimaryAddressId = entity.PrimaryAddressId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Customer_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICustomer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICustomer_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Customer_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Customer_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Customer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
