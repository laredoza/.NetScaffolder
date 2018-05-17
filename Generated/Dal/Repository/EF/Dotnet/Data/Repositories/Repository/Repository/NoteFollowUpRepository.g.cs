
// <copyright file="NoteFollowUp.g.cs" company="MIT">
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
	/// The NoteFollowUpRepository class responsible for database functions in the NoteFollowUp table
	/// </summary>
	public partial class NoteFollowUpRepository : UowRepository<NoteFollowUp> , INoteFollowUpRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for NoteFollowUpRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public NoteFollowUpRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the NoteFollowUp entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>INoteFollowUp</returns>
		public virtual INoteFollowUp LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<NoteFollowUp>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load NoteFollowUp entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.Stamp == stamp).ToList<INoteFollowUp>();
		}
		
        /// <summary>
        /// Load NoteFollowUp entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.UserName == username).ToList<INoteFollowUp>();
		}
		
        /// <summary>
        /// Load NoteFollowUp entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.Description == description).ToList<INoteFollowUp>();
		}
		
        /// <summary>
        /// Load NoteFollowUp entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.UserId == userid).ToList<INoteFollowUp>();
		}
		
        /// <summary>
        /// Load NoteFollowUp entities from the database using the NoteId field
        /// </summary>
        /// <param name="noteid">Nullable<int></param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadByNoteId(Nullable<int> noteid)
		{
			return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.NoteId == noteid).ToList<INoteFollowUp>();
		}
		
        /// <summary>
        /// Load all NoteFollowUp entities from the database.
        /// </summary>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> LoadAll()
		{
			return this.UnitOfWork.GetAll<NoteFollowUp>().ToList<INoteFollowUp>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for NoteFollowUp entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<INoteFollowUp>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.UserName.Contains(username)).ToList<INoteFollowUp>();
			}
		}
		
        /// <summary>
        /// Search for NoteFollowUp entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<INoteFollowUp></returns>
		public virtual IList<INoteFollowUp> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<INoteFollowUp>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<NoteFollowUp>(o => o.Description.Contains(description)).ToList<INoteFollowUp>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the NoteFollowUp entity to the database.
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		public virtual bool Save(INoteFollowUp entity)
		{
			var entityToSave = new NoteFollowUp(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the NoteFollowUp entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		public virtual bool Update(INoteFollowUp entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<NoteFollowUp>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The NoteFollowUp entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.NoteId != entity.NoteId) { entityToUpdate.NoteId = entity.NoteId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the NoteFollowUp entity from the database
        /// </summary>
        /// <param name="entity">INoteFollowUp</param>
        /// <returns>bool</returns>
		public virtual bool Delete(INoteFollowUp entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<NoteFollowUp>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The NoteFollowUp entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the NoteFollowUp entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<NoteFollowUp>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The NoteFollowUp entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
