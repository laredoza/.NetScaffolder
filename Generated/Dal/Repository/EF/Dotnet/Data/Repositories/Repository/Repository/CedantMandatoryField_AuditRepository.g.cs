
// <copyright file="CedantMandatoryField_Audit.g.cs" company="MIT">
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
	/// The CedantMandatoryField_AuditRepository class responsible for database functions in the CedantMandatoryField_Audit table
	/// </summary>
	public partial class CedantMandatoryField_AuditRepository : UowRepository<CedantMandatoryField_Audit> , ICedantMandatoryField_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantMandatoryField_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantMandatoryField_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantMandatoryField_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedantMandatoryField_Audit</returns>
		public virtual ICedantMandatoryField_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantMandatoryField_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.Id == id).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.Stamp == stamp).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.UserName == username).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the MandatoryFieldName field
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByMandatoryFieldName(string mandatoryfieldname)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.MandatoryFieldName == mandatoryfieldname).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the Selected field
        /// </summary>
        /// <param name="selected">Nullable<bool></param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadBySelected(Nullable<bool> selected)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.Selected == selected).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the ValidateType field
        /// </summary>
        /// <param name="validatetype">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByValidateType(Nullable<int> validatetype)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.ValidateType == validatetype).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.CedantId == cedantid).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the MandatoryFieldId field
        /// </summary>
        /// <param name="mandatoryfieldid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByMandatoryFieldId(Nullable<int> mandatoryfieldid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.MandatoryFieldId == mandatoryfieldid).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICedantMandatoryField_Audit>();
		}
		
        /// <summary>
        /// Load all CedantMandatoryField_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantMandatoryField_Audit>().ToList<ICedantMandatoryField_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantMandatoryField_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantMandatoryField_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.UserName.Contains(username)).ToList<ICedantMandatoryField_Audit>();
			}
		}
		
        /// <summary>
        /// Search for CedantMandatoryField_Audit entities in the database by MandatoryFieldName
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField_Audit></returns>
		public virtual IList<ICedantMandatoryField_Audit> SearchByMandatoryFieldName(string mandatoryfieldname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.MandatoryFieldName.ToLower().Contains(mandatoryfieldname.ToLower())).ToList<ICedantMandatoryField_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField_Audit>(o => o.MandatoryFieldName.Contains(mandatoryfieldname)).ToList<ICedantMandatoryField_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantMandatoryField_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantMandatoryField_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantMandatoryField_Audit entity)
		{
			var entityToSave = new CedantMandatoryField_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantMandatoryField_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantMandatoryField_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantMandatoryField_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantMandatoryField_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantMandatoryField_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.MandatoryFieldName != entity.MandatoryFieldName) { entityToUpdate.MandatoryFieldName = entity.MandatoryFieldName;doUpdate = true; }
			if (entityToUpdate.Selected != entity.Selected) { entityToUpdate.Selected = entity.Selected;doUpdate = true; }
			if (entityToUpdate.ValidateType != entity.ValidateType) { entityToUpdate.ValidateType = entity.ValidateType;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.MandatoryFieldId != entity.MandatoryFieldId) { entityToUpdate.MandatoryFieldId = entity.MandatoryFieldId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantMandatoryField_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedantMandatoryField_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantMandatoryField_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryField_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryField_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantMandatoryField_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryField_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryField_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
