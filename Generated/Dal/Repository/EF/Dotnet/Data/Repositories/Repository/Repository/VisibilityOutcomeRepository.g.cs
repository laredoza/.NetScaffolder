
// <copyright file="VisibilityOutcome.g.cs" company="MIT">
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
	/// The VisibilityOutcomeRepository class responsible for database functions in the VisibilityOutcome table
	/// </summary>
	public partial class VisibilityOutcomeRepository : UowRepository<VisibilityOutcome> , IVisibilityOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VisibilityOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VisibilityOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VisibilityOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVisibilityOutcome</returns>
		public virtual IVisibilityOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VisibilityOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VisibilityOutcome entities from the database using the VisibilityOption field
        /// </summary>
        /// <param name="visibilityoption">Nullable<int></param>
        /// <returns>IList<IVisibilityOutcome></returns>
		public virtual IList<IVisibilityOutcome> LoadByVisibilityOption(Nullable<int> visibilityoption)
		{
			return this.UnitOfWork.AllMatching<VisibilityOutcome>(o => o.VisibilityOption == visibilityoption).ToList<IVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load VisibilityOutcome entities from the database using the VersionSectionId field
        /// </summary>
        /// <param name="versionsectionid">Nullable<int></param>
        /// <returns>IList<IVisibilityOutcome></returns>
		public virtual IList<IVisibilityOutcome> LoadByVersionSectionId(Nullable<int> versionsectionid)
		{
			return this.UnitOfWork.AllMatching<VisibilityOutcome>(o => o.VersionSectionId == versionsectionid).ToList<IVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load VisibilityOutcome entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IVisibilityOutcome></returns>
		public virtual IList<IVisibilityOutcome> LoadByQuestionProfileId(Nullable<int> questionprofileid)
		{
			return this.UnitOfWork.AllMatching<VisibilityOutcome>(o => o.QuestionProfileId == questionprofileid).ToList<IVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load VisibilityOutcome entities from the database using the OutcomeEntityId field
        /// </summary>
        /// <param name="outcomeentityid">Nullable<int></param>
        /// <returns>IList<IVisibilityOutcome></returns>
		public virtual IList<IVisibilityOutcome> LoadByOutcomeEntityId(Nullable<int> outcomeentityid)
		{
			return this.UnitOfWork.AllMatching<VisibilityOutcome>(o => o.OutcomeEntityId == outcomeentityid).ToList<IVisibilityOutcome>();
		}
		
        /// <summary>
        /// Load all VisibilityOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IVisibilityOutcome></returns>
		public virtual IList<IVisibilityOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<VisibilityOutcome>().ToList<IVisibilityOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VisibilityOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVisibilityOutcome entity)
		{
			var entityToSave = new VisibilityOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VisibilityOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVisibilityOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VisibilityOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VisibilityOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.VisibilityOption != entity.VisibilityOption) { entityToUpdate.VisibilityOption = entity.VisibilityOption;doUpdate = true; }
			if (entityToUpdate.VersionSectionId != entity.VersionSectionId) { entityToUpdate.VersionSectionId = entity.VersionSectionId;doUpdate = true; }
			if (entityToUpdate.QuestionProfileId != entity.QuestionProfileId) { entityToUpdate.QuestionProfileId = entity.QuestionProfileId;doUpdate = true; }
			if (entityToUpdate.OutcomeEntityId != entity.OutcomeEntityId) { entityToUpdate.OutcomeEntityId = entity.OutcomeEntityId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VisibilityOutcome entity from the database
        /// </summary>
        /// <param name="entity">IVisibilityOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVisibilityOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VisibilityOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VisibilityOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VisibilityOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VisibilityOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VisibilityOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
