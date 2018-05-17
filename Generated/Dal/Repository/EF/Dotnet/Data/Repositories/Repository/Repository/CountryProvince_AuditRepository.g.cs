
// <copyright file="CountryProvince_Audit.g.cs" company="MIT">
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
	/// The CountryProvince_AuditRepository class responsible for database functions in the CountryProvince_Audit table
	/// </summary>
	public partial class CountryProvince_AuditRepository : UowRepository<CountryProvince_Audit> , ICountryProvince_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CountryProvince_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CountryProvince_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CountryProvince_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICountryProvince_Audit</returns>
		public virtual ICountryProvince_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<CountryProvince_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Id == id).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Stamp == stamp).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.UserName == username).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByCode(string code)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Code == code).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Name == name).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Status == status).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByParentId(Nullable<int> parentid)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.ParentId == parentid).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load CountryProvince_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICountryProvince_Audit>();
		}
		
        /// <summary>
        /// Load all CountryProvince_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<CountryProvince_Audit>().ToList<ICountryProvince_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CountryProvince_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICountryProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.UserName.Contains(username)).ToList<ICountryProvince_Audit>();
			}
		}
		
        /// <summary>
        /// Search for CountryProvince_Audit entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> SearchByCode(string code, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Code.ToLower().Contains(code.ToLower())).ToList<ICountryProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Code.Contains(code)).ToList<ICountryProvince_Audit>();
			}
		}
		
        /// <summary>
        /// Search for CountryProvince_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICountryProvince_Audit></returns>
		public virtual IList<ICountryProvince_Audit> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ICountryProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CountryProvince_Audit>(o => o.Name.Contains(name)).ToList<ICountryProvince_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CountryProvince_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICountryProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICountryProvince_Audit entity)
		{
			var entityToSave = new CountryProvince_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CountryProvince_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICountryProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICountryProvince_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CountryProvince_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CountryProvince_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Code != entity.Code) { entityToUpdate.Code = entity.Code;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.ParentId != entity.ParentId) { entityToUpdate.ParentId = entity.ParentId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CountryProvince_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICountryProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICountryProvince_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CountryProvince_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CountryProvince_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CountryProvince_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CountryProvince_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CountryProvince_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
