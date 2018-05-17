
// <copyright file="SetupTableData_Audit.g.cs" company="MIT">
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
	/// The SetupTableData_AuditRepository class responsible for database functions in the SetupTableData_Audit table
	/// </summary>
	public partial class SetupTableData_AuditRepository : UowRepository<SetupTableData_Audit> , ISetupTableData_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SetupTableData_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SetupTableData_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SetupTableData_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISetupTableData_Audit</returns>
		public virtual ISetupTableData_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<SetupTableData_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Id == id).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Stamp == stamp).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.UserName == username).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Title == title).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Description == description).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByCode(string code)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Code == code).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Status == status).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadBySeq(Nullable<int> seq)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Seq == seq).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the SetupTableId field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadBySetupTableId(Nullable<int> setuptableid)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.SetupTableId == setuptableid).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadByParentId(Nullable<int> parentid)
		{
			return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.ParentId == parentid).ToList<ISetupTableData_Audit>();
		}
		
        /// <summary>
        /// Load all SetupTableData_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<SetupTableData_Audit>().ToList<ISetupTableData_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISetupTableData_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.UserName.Contains(username)).ToList<ISetupTableData_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<ISetupTableData_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Title.Contains(title)).ToList<ISetupTableData_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<ISetupTableData_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Description.Contains(description)).ToList<ISetupTableData_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		public virtual IList<ISetupTableData_Audit> SearchByCode(string code, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Code.ToLower().Contains(code.ToLower())).ToList<ISetupTableData_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableData_Audit>(o => o.Code.Contains(code)).ToList<ISetupTableData_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTableData_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISetupTableData_Audit entity)
		{
			var entityToSave = new SetupTableData_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SetupTableData_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISetupTableData_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SetupTableData_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SetupTableData_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.Code != entity.Code) { entityToUpdate.Code = entity.Code;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Seq != entity.Seq) { entityToUpdate.Seq = entity.Seq;doUpdate = true; }
			if (entityToUpdate.SetupTableId != entity.SetupTableId) { entityToUpdate.SetupTableId = entity.SetupTableId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.ParentId != entity.ParentId) { entityToUpdate.ParentId = entity.ParentId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SetupTableData_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISetupTableData_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableData_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableData_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SetupTableData_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableData_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableData_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
