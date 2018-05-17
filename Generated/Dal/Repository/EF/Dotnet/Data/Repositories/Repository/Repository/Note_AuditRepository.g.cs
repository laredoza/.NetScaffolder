
// <copyright file="Note_Audit.g.cs" company="MIT">
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
	/// The Note_AuditRepository class responsible for database functions in the Note_Audit table
	/// </summary>
	public partial class Note_AuditRepository : UowRepository<Note_Audit> , INote_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Note_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Note_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Note_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>INote_Audit</returns>
		public virtual INote_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Note_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.Id == id).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.Stamp == stamp).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.UserName == username).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.Description == description).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the AllocatedToId field
        /// </summary>
        /// <param name="allocatedtoid">Nullable<int></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByAllocatedToId(Nullable<int> allocatedtoid)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.AllocatedToId == allocatedtoid).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the ActionRequiredFlag field
        /// </summary>
        /// <param name="actionrequiredflag">Nullable<bool></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByActionRequiredFlag(Nullable<bool> actionrequiredflag)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.ActionRequiredFlag == actionrequiredflag).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the FollowUpDate field
        /// </summary>
        /// <param name="followupdate">Nullable<DateTime></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByFollowUpDate(Nullable<DateTime> followupdate)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.FollowUpDate == followupdate).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the LinkId field
        /// </summary>
        /// <param name="linkid">Nullable<int></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByLinkId(Nullable<int> linkid)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.LinkId == linkid).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the CompletedFlag field
        /// </summary>
        /// <param name="completedflag">Nullable<bool></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByCompletedFlag(Nullable<bool> completedflag)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.CompletedFlag == completedflag).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.UserId == userid).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the NoteStatusId field
        /// </summary>
        /// <param name="notestatusid">Nullable<int></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByNoteStatusId(Nullable<int> notestatusid)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.NoteStatusId == notestatusid).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the NoteLinkTypeId field
        /// </summary>
        /// <param name="notelinktypeid">Nullable<int></param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByNoteLinkTypeId(Nullable<int> notelinktypeid)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.NoteLinkTypeId == notelinktypeid).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load Note_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Note_Audit>(o => o.AuditTrailType == audittrailtype).ToList<INote_Audit>();
		}
		
        /// <summary>
        /// Load all Note_Audit entities from the database.
        /// </summary>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Note_Audit>().ToList<INote_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Note_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Note_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<INote_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Note_Audit>(o => o.UserName.Contains(username)).ToList<INote_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Note_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote_Audit></returns>
		public virtual IList<INote_Audit> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Note_Audit>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<INote_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Note_Audit>(o => o.Description.Contains(description)).ToList<INote_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Note_Audit entity to the database.
        /// </summary>
        /// <param name="entity">INote_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(INote_Audit entity)
		{
			var entityToSave = new Note_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Note_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INote_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(INote_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Note_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Note_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.AllocatedToId != entity.AllocatedToId) { entityToUpdate.AllocatedToId = entity.AllocatedToId;doUpdate = true; }
			if (entityToUpdate.ActionRequiredFlag != entity.ActionRequiredFlag) { entityToUpdate.ActionRequiredFlag = entity.ActionRequiredFlag;doUpdate = true; }
			if (entityToUpdate.FollowUpDate != entity.FollowUpDate) { entityToUpdate.FollowUpDate = entity.FollowUpDate;doUpdate = true; }
			if (entityToUpdate.LinkId != entity.LinkId) { entityToUpdate.LinkId = entity.LinkId;doUpdate = true; }
			if (entityToUpdate.CompletedFlag != entity.CompletedFlag) { entityToUpdate.CompletedFlag = entity.CompletedFlag;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.NoteStatusId != entity.NoteStatusId) { entityToUpdate.NoteStatusId = entity.NoteStatusId;doUpdate = true; }
			if (entityToUpdate.NoteLinkTypeId != entity.NoteLinkTypeId) { entityToUpdate.NoteLinkTypeId = entity.NoteLinkTypeId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Note_Audit entity from the database
        /// </summary>
        /// <param name="entity">INote_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(INote_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Note_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Note_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Note_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Note_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Note_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
