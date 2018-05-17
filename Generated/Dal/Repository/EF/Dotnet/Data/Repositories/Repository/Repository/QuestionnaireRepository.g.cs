
// <copyright file="Questionnaire.g.cs" company="MIT">
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
	/// The QuestionnaireRepository class responsible for database functions in the Questionnaire table
	/// </summary>
	public partial class QuestionnaireRepository : UowRepository<Questionnaire> , IQuestionnaireRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionnaireRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionnaireRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Questionnaire entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaire</returns>
		public virtual IQuestionnaire LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Questionnaire>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.Stamp == stamp).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.UserName == username).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.Status == status).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.QuestionnaireProfileVersionId == questionnaireprofileversionid).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByRemainingChanges(Nullable<int> remainingchanges)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.RemainingChanges == remainingchanges).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.PolicyId == policyid).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load Questionnaire entities from the database using the Testing field
        /// </summary>
        /// <param name="testing">bool</param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadByTesting(bool testing)
		{
			return this.UnitOfWork.AllMatching<Questionnaire>(o => o.Testing == testing).ToList<IQuestionnaire>();
		}
		
        /// <summary>
        /// Load all Questionnaire entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> LoadAll()
		{
			return this.UnitOfWork.GetAll<Questionnaire>().ToList<IQuestionnaire>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Questionnaire entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaire></returns>
		public virtual IList<IQuestionnaire> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Questionnaire>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionnaire>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Questionnaire>(o => o.UserName.Contains(username)).ToList<IQuestionnaire>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Questionnaire entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaire entity)
		{
			var entityToSave = new Questionnaire(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Questionnaire entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaire entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Questionnaire>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Questionnaire entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.QuestionnaireProfileVersionId != entity.QuestionnaireProfileVersionId) { entityToUpdate.QuestionnaireProfileVersionId = entity.QuestionnaireProfileVersionId;doUpdate = true; }
			if (entityToUpdate.RemainingChanges != entity.RemainingChanges) { entityToUpdate.RemainingChanges = entity.RemainingChanges;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.Testing != entity.Testing) { entityToUpdate.Testing = entity.Testing;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Questionnaire entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaire</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaire entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Questionnaire>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Questionnaire entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Questionnaire entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Questionnaire>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Questionnaire entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
