
// <copyright file="AnswerProfile.g.cs" company="MIT">
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
	/// The AnswerProfileRepository class responsible for database functions in the AnswerProfile table
	/// </summary>
	public partial class AnswerProfileRepository : UowRepository<AnswerProfile> , IAnswerProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerProfile</returns>
		public virtual IAnswerProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the DataType field
        /// </summary>
        /// <param name="datatype">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadByDataType(Nullable<int> datatype)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.DataType == datatype).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadByQuestionProfileId(Nullable<int> questionprofileid)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.QuestionProfileId == questionprofileid).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the AnswerProviderId field
        /// </summary>
        /// <param name="answerproviderid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadByAnswerProviderId(Nullable<int> answerproviderid)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.AnswerProviderId == answerproviderid).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the ApplicantAttributeId field
        /// </summary>
        /// <param name="applicantattributeid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadByApplicantAttributeId(Nullable<int> applicantattributeid)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.ApplicantAttributeId == applicantattributeid).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadBySequenceId(Nullable<int> sequenceid)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.SequenceId == sequenceid).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load AnswerProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadByPromptText(string prompttext)
		{
			return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.PromptText == prompttext).ToList<IAnswerProfile>();
		}
		
        /// <summary>
        /// Load all AnswerProfile entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerProfile>().ToList<IAnswerProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerProfile></returns>
		public virtual IList<IAnswerProfile> SearchByPromptText(string prompttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.PromptText.ToLower().Contains(prompttext.ToLower())).ToList<IAnswerProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerProfile>(o => o.PromptText.Contains(prompttext)).ToList<IAnswerProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerProfile entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerProfile entity)
		{
			var entityToSave = new AnswerProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.DataType != entity.DataType) { entityToUpdate.DataType = entity.DataType;doUpdate = true; }
			if (entityToUpdate.QuestionProfileId != entity.QuestionProfileId) { entityToUpdate.QuestionProfileId = entity.QuestionProfileId;doUpdate = true; }
			if (entityToUpdate.AnswerProviderId != entity.AnswerProviderId) { entityToUpdate.AnswerProviderId = entity.AnswerProviderId;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeId != entity.ApplicantAttributeId) { entityToUpdate.ApplicantAttributeId = entity.ApplicantAttributeId;doUpdate = true; }
			if (entityToUpdate.SequenceId != entity.SequenceId) { entityToUpdate.SequenceId = entity.SequenceId;doUpdate = true; }
			if (entityToUpdate.PromptText != entity.PromptText) { entityToUpdate.PromptText = entity.PromptText;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerProfile entity from the database
        /// </summary>
        /// <param name="entity">IAnswerProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
