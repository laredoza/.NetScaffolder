
// <copyright file="OutcomeGroupAttribute.g.cs" company="MIT">
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
	/// The OutcomeGroupAttributeRepository class responsible for database functions in the OutcomeGroupAttribute table
	/// </summary>
	public partial class OutcomeGroupAttributeRepository : UowRepository<OutcomeGroupAttribute> , IOutcomeGroupAttributeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OutcomeGroupAttributeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OutcomeGroupAttributeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the OutcomeGroupAttribute entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IOutcomeGroupAttribute</returns>
		public virtual IOutcomeGroupAttribute LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<OutcomeGroupAttribute>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load OutcomeGroupAttribute entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">int</param>
        /// <returns>IList<IOutcomeGroupAttribute></returns>
		public virtual IList<IOutcomeGroupAttribute> LoadByQuestionnaireId(int questionnaireid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupAttribute>(o => o.QuestionnaireId == questionnaireid).ToList<IOutcomeGroupAttribute>();
		}
		
        /// <summary>
        /// Load OutcomeGroupAttribute entities from the database using the AnswerOutcomeResultId field
        /// </summary>
        /// <param name="answeroutcomeresultid">int</param>
        /// <returns>IList<IOutcomeGroupAttribute></returns>
		public virtual IList<IOutcomeGroupAttribute> LoadByAnswerOutcomeResultId(int answeroutcomeresultid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupAttribute>(o => o.AnswerOutcomeResultId == answeroutcomeresultid).ToList<IOutcomeGroupAttribute>();
		}
		
        /// <summary>
        /// Load OutcomeGroupAttribute entities from the database using the ApplicantAttributeProfileId field
        /// </summary>
        /// <param name="applicantattributeprofileid">int</param>
        /// <returns>IList<IOutcomeGroupAttribute></returns>
		public virtual IList<IOutcomeGroupAttribute> LoadByApplicantAttributeProfileId(int applicantattributeprofileid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupAttribute>(o => o.ApplicantAttributeProfileId == applicantattributeprofileid).ToList<IOutcomeGroupAttribute>();
		}
		
        /// <summary>
        /// Load OutcomeGroupAttribute entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">int</param>
        /// <returns>IList<IOutcomeGroupAttribute></returns>
		public virtual IList<IOutcomeGroupAttribute> LoadBySetupTableDataId(int setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupAttribute>(o => o.SetupTableDataId == setuptabledataid).ToList<IOutcomeGroupAttribute>();
		}
		
        /// <summary>
        /// Load all OutcomeGroupAttribute entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeGroupAttribute></returns>
		public virtual IList<IOutcomeGroupAttribute> LoadAll()
		{
			return this.UnitOfWork.GetAll<OutcomeGroupAttribute>().ToList<IOutcomeGroupAttribute>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeGroupAttribute entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeGroupAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Save(IOutcomeGroupAttribute entity)
		{
			var entityToSave = new OutcomeGroupAttribute(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the OutcomeGroupAttribute entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeGroupAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOutcomeGroupAttribute entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OutcomeGroupAttribute>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OutcomeGroupAttribute entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.AnswerOutcomeResultId != entity.AnswerOutcomeResultId) { entityToUpdate.AnswerOutcomeResultId = entity.AnswerOutcomeResultId;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeProfileId != entity.ApplicantAttributeProfileId) { entityToUpdate.ApplicantAttributeProfileId = entity.ApplicantAttributeProfileId;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the OutcomeGroupAttribute entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeGroupAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOutcomeGroupAttribute entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeGroupAttribute>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeGroupAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OutcomeGroupAttribute entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeGroupAttribute>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeGroupAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
