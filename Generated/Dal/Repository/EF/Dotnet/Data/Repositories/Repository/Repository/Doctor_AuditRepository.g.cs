
// <copyright file="Doctor_Audit.g.cs" company="MIT">
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
	/// The Doctor_AuditRepository class responsible for database functions in the Doctor_Audit table
	/// </summary>
	public partial class Doctor_AuditRepository : UowRepository<Doctor_Audit> , IDoctor_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Doctor_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Doctor_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Doctor_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IDoctor_Audit</returns>
		public virtual IDoctor_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Doctor_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.Id == id).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.Stamp == stamp).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.UserName == username).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.Surname == surname).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the FirstName field
        /// </summary>
        /// <param name="firstname">string</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByFirstName(string firstname)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.FirstName == firstname).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the AddressId field
        /// </summary>
        /// <param name="addressid">Nullable<int></param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByAddressId(Nullable<int> addressid)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.AddressId == addressid).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the PhoneId field
        /// </summary>
        /// <param name="phoneid">Nullable<int></param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByPhoneId(Nullable<int> phoneid)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.PhoneId == phoneid).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load Doctor_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IDoctor_Audit>();
		}
		
        /// <summary>
        /// Load all Doctor_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Doctor_Audit>().ToList<IDoctor_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Doctor_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IDoctor_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.UserName.Contains(username)).ToList<IDoctor_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Doctor_Audit entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IDoctor_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.Surname.Contains(surname)).ToList<IDoctor_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Doctor_Audit entities in the database by FirstName
        /// </summary>
        /// <param name="firstname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDoctor_Audit></returns>
		public virtual IList<IDoctor_Audit> SearchByFirstName(string firstname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.FirstName.ToLower().Contains(firstname.ToLower())).ToList<IDoctor_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Doctor_Audit>(o => o.FirstName.Contains(firstname)).ToList<IDoctor_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Doctor_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IDoctor_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IDoctor_Audit entity)
		{
			var entityToSave = new Doctor_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Doctor_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IDoctor_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IDoctor_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Doctor_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Doctor_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.FirstName != entity.FirstName) { entityToUpdate.FirstName = entity.FirstName;doUpdate = true; }
			if (entityToUpdate.AddressId != entity.AddressId) { entityToUpdate.AddressId = entity.AddressId;doUpdate = true; }
			if (entityToUpdate.PhoneId != entity.PhoneId) { entityToUpdate.PhoneId = entity.PhoneId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Doctor_Audit entity from the database
        /// </summary>
        /// <param name="entity">IDoctor_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IDoctor_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Doctor_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Doctor_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Doctor_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Doctor_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Doctor_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
