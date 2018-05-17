
// <copyright file="RunOnceOutcomeGroup.g.cs" company="MIT">
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
	/// The RunOnceOutcomeGroupRepository class responsible for database functions in the RunOnceOutcomeGroup table
	/// </summary>
	public partial class RunOnceOutcomeGroupRepository : UowRepository<RunOnceOutcomeGroup> , IRunOnceOutcomeGroupRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for RunOnceOutcomeGroupRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public RunOnceOutcomeGroupRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the RunOnceOutcomeGroup entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IRunOnceOutcomeGroup</returns>
		public virtual IRunOnceOutcomeGroup LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<RunOnceOutcomeGroup>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.Stamp == stamp).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.UserName == username).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.QuestionnaireId == questionnaireid).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.SetupTableDataId == setuptabledataid).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the OutcomeGroupId field
        /// </summary>
        /// <param name="outcomegroupid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByOutcomeGroupId(Nullable<int> outcomegroupid)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.OutcomeGroupId == outcomegroupid).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByAnswerId(Nullable<int> answerid)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.AnswerId == answerid).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load RunOnceOutcomeGroup entities from the database using the RunOnceActiveFlag field
        /// </summary>
        /// <param name="runonceactiveflag">Nullable<bool></param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadByRunOnceActiveFlag(Nullable<bool> runonceactiveflag)
		{
			return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.RunOnceActiveFlag == runonceactiveflag).ToList<IRunOnceOutcomeGroup>();
		}
		
        /// <summary>
        /// Load all RunOnceOutcomeGroup entities from the database.
        /// </summary>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> LoadAll()
		{
			return this.UnitOfWork.GetAll<RunOnceOutcomeGroup>().ToList<IRunOnceOutcomeGroup>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for RunOnceOutcomeGroup entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IRunOnceOutcomeGroup></returns>
		public virtual IList<IRunOnceOutcomeGroup> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IRunOnceOutcomeGroup>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<RunOnceOutcomeGroup>(o => o.UserName.Contains(username)).ToList<IRunOnceOutcomeGroup>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the RunOnceOutcomeGroup entity to the database.
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Save(IRunOnceOutcomeGroup entity)
		{
			var entityToSave = new RunOnceOutcomeGroup(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the RunOnceOutcomeGroup entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Update(IRunOnceOutcomeGroup entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<RunOnceOutcomeGroup>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The RunOnceOutcomeGroup entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.OutcomeGroupId != entity.OutcomeGroupId) { entityToUpdate.OutcomeGroupId = entity.OutcomeGroupId;doUpdate = true; }
			if (entityToUpdate.AnswerId != entity.AnswerId) { entityToUpdate.AnswerId = entity.AnswerId;doUpdate = true; }
			if (entityToUpdate.RunOnceActiveFlag != entity.RunOnceActiveFlag) { entityToUpdate.RunOnceActiveFlag = entity.RunOnceActiveFlag;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the RunOnceOutcomeGroup entity from the database
        /// </summary>
        /// <param name="entity">IRunOnceOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IRunOnceOutcomeGroup entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<RunOnceOutcomeGroup>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The RunOnceOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the RunOnceOutcomeGroup entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<RunOnceOutcomeGroup>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The RunOnceOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
