﻿
// <copyright file="Question.g.cs" company="MIT">
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
	/// The QuestionRepository class responsible for database functions in the Question table
	/// </summary>
	public partial class QuestionRepository : UowRepository<Question> , IQuestionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Question entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestion</returns>
		public virtual IQuestion LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Question>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Question entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.Stamp == stamp).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.UserName == username).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the isAnswered field
        /// </summary>
        /// <param name="isanswered">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByisAnswered(Nullable<bool> isanswered)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.isAnswered == isanswered).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the isVisible field
        /// </summary>
        /// <param name="isvisible">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByisVisible(Nullable<bool> isvisible)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.isVisible == isvisible).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the isFlagged field
        /// </summary>
        /// <param name="isflagged">Nullable<bool></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByisFlagged(Nullable<bool> isflagged)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.isFlagged == isflagged).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByQuestionProfileId(Nullable<int> questionprofileid)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.QuestionProfileId == questionprofileid).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadBySectionId(Nullable<int> sectionid)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.SectionId == sectionid).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the PreviousQuestionId field
        /// </summary>
        /// <param name="previousquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByPreviousQuestionId(Nullable<int> previousquestionid)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.PreviousQuestionId == previousquestionid).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the PopupStartedQuestionId field
        /// </summary>
        /// <param name="popupstartedquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByPopupStartedQuestionId(Nullable<int> popupstartedquestionid)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.PopupStartedQuestionId == popupstartedquestionid).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load Question entities from the database using the NextQuestionId field
        /// </summary>
        /// <param name="nextquestionid">Nullable<int></param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadByNextQuestionId(Nullable<int> nextquestionid)
		{
			return this.UnitOfWork.AllMatching<Question>(o => o.NextQuestionId == nextquestionid).ToList<IQuestion>();
		}
		
        /// <summary>
        /// Load all Question entities from the database.
        /// </summary>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> LoadAll()
		{
			return this.UnitOfWork.GetAll<Question>().ToList<IQuestion>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Question entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestion></returns>
		public virtual IList<IQuestion> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Question>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Question>(o => o.UserName.Contains(username)).ToList<IQuestion>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Question entity to the database.
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestion entity)
		{
			var entityToSave = new Question(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Question entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestion entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Question>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Question entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.isAnswered != entity.isAnswered) { entityToUpdate.isAnswered = entity.isAnswered;doUpdate = true; }
			if (entityToUpdate.isVisible != entity.isVisible) { entityToUpdate.isVisible = entity.isVisible;doUpdate = true; }
			if (entityToUpdate.isFlagged != entity.isFlagged) { entityToUpdate.isFlagged = entity.isFlagged;doUpdate = true; }
			if (entityToUpdate.QuestionProfileId != entity.QuestionProfileId) { entityToUpdate.QuestionProfileId = entity.QuestionProfileId;doUpdate = true; }
			if (entityToUpdate.SectionId != entity.SectionId) { entityToUpdate.SectionId = entity.SectionId;doUpdate = true; }
			if (entityToUpdate.PreviousQuestionId != entity.PreviousQuestionId) { entityToUpdate.PreviousQuestionId = entity.PreviousQuestionId;doUpdate = true; }
			if (entityToUpdate.PopupStartedQuestionId != entity.PopupStartedQuestionId) { entityToUpdate.PopupStartedQuestionId = entity.PopupStartedQuestionId;doUpdate = true; }
			if (entityToUpdate.NextQuestionId != entity.NextQuestionId) { entityToUpdate.NextQuestionId = entity.NextQuestionId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Question entity from the database
        /// </summary>
        /// <param name="entity">IQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestion entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Question>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Question entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Question entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Question>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Question entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
