﻿
// <copyright file="SectionVisibilityOutcome.g.cs" company="MIT">
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
	/// The SectionVisibilityOutcomeRepository class responsible for database functions in the SectionVisibilityOutcome table
	/// </summary>
	public partial class SectionVisibilityOutcomeRepository : UowRepository<SectionVisibilityOutcome> , ISectionVisibilityOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionVisibilityOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionVisibilityOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SectionVisibilityOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionVisibilityOutcome</returns>
		public virtual ISectionVisibilityOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SectionVisibilityOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the VisibilityOption field
        /// </summary>
        /// <param name="visibilityoption">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		public virtual IList<ISectionVisibilityOutcome> LoadByVisibilityOption(Nullable<int> visibilityoption)
		{
			return this.UnitOfWork.AllMatching<SectionVisibilityOutcome>(o => o.VisibilityOption == visibilityoption).ToList<ISectionVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the VersionSectionId field
        /// </summary>
        /// <param name="versionsectionid">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		public virtual IList<ISectionVisibilityOutcome> LoadByVersionSectionId(Nullable<int> versionsectionid)
		{
			return this.UnitOfWork.AllMatching<SectionVisibilityOutcome>(o => o.VersionSectionId == versionsectionid).ToList<ISectionVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the OutcomeEntityId field
        /// </summary>
        /// <param name="outcomeentityid">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		public virtual IList<ISectionVisibilityOutcome> LoadByOutcomeEntityId(Nullable<int> outcomeentityid)
		{
			return this.UnitOfWork.AllMatching<SectionVisibilityOutcome>(o => o.OutcomeEntityId == outcomeentityid).ToList<ISectionVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load all SectionVisibilityOutcome entities from the database.
        /// </summary>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		public virtual IList<ISectionVisibilityOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<SectionVisibilityOutcome>().ToList<ISectionVisibilityOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionVisibilityOutcome entity to the database.
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISectionVisibilityOutcome entity)
		{
			var entityToSave = new SectionVisibilityOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SectionVisibilityOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISectionVisibilityOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SectionVisibilityOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SectionVisibilityOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.VisibilityOption != entity.VisibilityOption) { entityToUpdate.VisibilityOption = entity.VisibilityOption;doUpdate = true; }
			if (entityToUpdate.VersionSectionId != entity.VersionSectionId) { entityToUpdate.VersionSectionId = entity.VersionSectionId;doUpdate = true; }
			if (entityToUpdate.OutcomeEntityId != entity.OutcomeEntityId) { entityToUpdate.OutcomeEntityId = entity.OutcomeEntityId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SectionVisibilityOutcome entity from the database
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISectionVisibilityOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionVisibilityOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionVisibilityOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SectionVisibilityOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionVisibilityOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionVisibilityOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
