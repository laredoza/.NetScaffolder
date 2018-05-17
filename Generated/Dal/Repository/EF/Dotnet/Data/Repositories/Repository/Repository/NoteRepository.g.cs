
// <copyright file="Note.g.cs" company="MIT">
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
	/// The NoteRepository class responsible for database functions in the Note table
	/// </summary>
	public partial class NoteRepository : UowRepository<Note> , INoteRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for NoteRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public NoteRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Note entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INote</returns>
		public virtual INote LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Note>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Note entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.Stamp == stamp).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.UserName == username).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.Description == description).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the AllocatedToId field
        /// </summary>
        /// <param name="allocatedtoid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByAllocatedToId(Nullable<int> allocatedtoid)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.AllocatedToId == allocatedtoid).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the ActionRequiredFlag field
        /// </summary>
        /// <param name="actionrequiredflag">Nullable<bool></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByActionRequiredFlag(Nullable<bool> actionrequiredflag)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.ActionRequiredFlag == actionrequiredflag).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the FollowUpDate field
        /// </summary>
        /// <param name="followupdate">Nullable<DateTime></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByFollowUpDate(Nullable<DateTime> followupdate)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.FollowUpDate == followupdate).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the LinkId field
        /// </summary>
        /// <param name="linkid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByLinkId(Nullable<int> linkid)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.LinkId == linkid).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the CompletedFlag field
        /// </summary>
        /// <param name="completedflag">Nullable<bool></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByCompletedFlag(Nullable<bool> completedflag)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.CompletedFlag == completedflag).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.UserId == userid).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the NoteStatusId field
        /// </summary>
        /// <param name="notestatusid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByNoteStatusId(Nullable<int> notestatusid)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.NoteStatusId == notestatusid).ToList<INote>();
		}
		
        /// <summary>
        /// Load Note entities from the database using the NoteLinkTypeId field
        /// </summary>
        /// <param name="notelinktypeid">Nullable<int></param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadByNoteLinkTypeId(Nullable<int> notelinktypeid)
		{
			return this.UnitOfWork.AllMatching<Note>(o => o.NoteLinkTypeId == notelinktypeid).ToList<INote>();
		}
		
        /// <summary>
        /// Load all Note entities from the database.
        /// </summary>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> LoadAll()
		{
			return this.UnitOfWork.GetAll<Note>().ToList<INote>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Note entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Note>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<INote>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Note>(o => o.UserName.Contains(username)).ToList<INote>();
			}
		}
		
        /// <summary>
        /// Search for Note entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INote></returns>
		public virtual IList<INote> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Note>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<INote>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Note>(o => o.Description.Contains(description)).ToList<INote>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Note entity to the database.
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		public virtual bool Save(INote entity)
		{
			var entityToSave = new Note(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Note entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		public virtual bool Update(INote entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Note>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Note entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
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

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Note entity from the database
        /// </summary>
        /// <param name="entity">INote</param>
        /// <returns>bool</returns>
		public virtual bool Delete(INote entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Note>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Note entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Note entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Note>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Note entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
