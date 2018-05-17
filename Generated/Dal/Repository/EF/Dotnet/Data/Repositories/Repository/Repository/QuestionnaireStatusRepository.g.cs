
// <copyright file="QuestionnaireStatus.g.cs" company="MIT">
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
	/// The QuestionnaireStatusRepository class responsible for database functions in the QuestionnaireStatus table
	/// </summary>
	public partial class QuestionnaireStatusRepository : UowRepository<QuestionnaireStatus> , IQuestionnaireStatusRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionnaireStatusRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionnaireStatusRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionnaireStatus entity from the database using the QuestionnaireStatusID primary key
        /// </summary>
        /// <param name="questionnairestatusid">int</param>
        /// <returns>IQuestionnaireStatus</returns>
		public virtual IQuestionnaireStatus LoadByQuestionnaireStatusID(int questionnairestatusid)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionnaireStatus>(o => o.QuestionnaireStatusID == questionnairestatusid);
		}
		
        /// <summary>
        /// Load QuestionnaireStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IQuestionnaireStatus></returns>
		public virtual IList<IQuestionnaireStatus> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireStatus>(o => o.Description == description).ToList<IQuestionnaireStatus>();
		}
		
        /// <summary>
        /// Load all QuestionnaireStatus entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireStatus></returns>
		public virtual IList<IQuestionnaireStatus> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionnaireStatus>().ToList<IQuestionnaireStatus>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionnaireStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireStatus></returns>
		public virtual IList<IQuestionnaireStatus> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireStatus>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IQuestionnaireStatus>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireStatus>(o => o.Description.Contains(description)).ToList<IQuestionnaireStatus>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireStatus entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaireStatus entity)
		{
			var entityToSave = new QuestionnaireStatus(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionnaireStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaireStatus entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionnaireStatus>(o => o.QuestionnaireStatusID == entity.QuestionnaireStatusID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionnaireStatus entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionnaireStatus entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireStatus</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaireStatus entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireStatus>(o => o.QuestionnaireStatusID == entity.QuestionnaireStatusID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionnaireStatus entity from the database using the QuestionnaireStatusID
        /// </summary>
        /// <param name="questionnairestatusid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByQuestionnaireStatusID(int questionnairestatusid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireStatus>(o => o.QuestionnaireStatusID == questionnairestatusid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
