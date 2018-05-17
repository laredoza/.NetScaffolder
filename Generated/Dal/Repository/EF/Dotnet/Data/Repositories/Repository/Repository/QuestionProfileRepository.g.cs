
// <copyright file="QuestionProfile.g.cs" company="MIT">
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
	/// The QuestionProfileRepository class responsible for database functions in the QuestionProfile table
	/// </summary>
	public partial class QuestionProfileRepository : UowRepository<QuestionProfile> , IQuestionProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionProfile</returns>
		public virtual IQuestionProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the Number field
        /// </summary>
        /// <param name="number">Nullable<int></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByNumber(Nullable<int> number)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Number == number).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Title == title).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the PlaintText field
        /// </summary>
        /// <param name="plainttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByPlaintText(string plainttext)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PlaintText == plainttext).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByText(string text)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Text == text).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the allowMultipleAnswers field
        /// </summary>
        /// <param name="allowmultipleanswers">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByallowMultipleAnswers(Nullable<bool> allowmultipleanswers)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.allowMultipleAnswers == allowmultipleanswers).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.isVisibleAtStart == isvisibleatstart).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the CopiedFromQuestionProfileTitle field
        /// </summary>
        /// <param name="copiedfromquestionprofiletitle">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByCopiedFromQuestionProfileTitle(string copiedfromquestionprofiletitle)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.CopiedFromQuestionProfileTitle == copiedfromquestionprofiletitle).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the PromptPlaintText field
        /// </summary>
        /// <param name="promptplainttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByPromptPlaintText(string promptplainttext)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptPlaintText == promptplainttext).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByPromptText(string prompttext)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptText == prompttext).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the PrePopulatedByService field
        /// </summary>
        /// <param name="prepopulatedbyservice">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByPrePopulatedByService(Nullable<bool> prepopulatedbyservice)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PrePopulatedByService == prepopulatedbyservice).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadBySequenceId(Nullable<int> sequenceid)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.SequenceId == sequenceid).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByExternalReferenceId(string externalreferenceid)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.ExternalReferenceId == externalreferenceid).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the AnswerRequired field
        /// </summary>
        /// <param name="answerrequired">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByAnswerRequired(bool answerrequired)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.AnswerRequired == answerrequired).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load QuestionProfile entities from the database using the DoNotDisplay field
        /// </summary>
        /// <param name="donotdisplay">Nullable<bool></param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadByDoNotDisplay(Nullable<bool> donotdisplay)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.DoNotDisplay == donotdisplay).ToList<IQuestionProfile>();
		}
		
        /// <summary>
        /// Load all QuestionProfile entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionProfile>().ToList<IQuestionProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Title.Contains(title)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by PlaintText
        /// </summary>
        /// <param name="plainttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByPlaintText(string plainttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PlaintText.ToLower().Contains(plainttext.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PlaintText.Contains(plainttext)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByText(string text, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Text.ToLower().Contains(text.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.Text.Contains(text)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by CopiedFromQuestionProfileTitle
        /// </summary>
        /// <param name="copiedfromquestionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByCopiedFromQuestionProfileTitle(string copiedfromquestionprofiletitle, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.CopiedFromQuestionProfileTitle.ToLower().Contains(copiedfromquestionprofiletitle.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.CopiedFromQuestionProfileTitle.Contains(copiedfromquestionprofiletitle)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by PromptPlaintText
        /// </summary>
        /// <param name="promptplainttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByPromptPlaintText(string promptplainttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptPlaintText.ToLower().Contains(promptplainttext.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptPlaintText.Contains(promptplainttext)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByPromptText(string prompttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptText.ToLower().Contains(prompttext.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.PromptText.Contains(prompttext)).ToList<IQuestionProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionProfile entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile></returns>
		public virtual IList<IQuestionProfile> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.ExternalReferenceId.ToLower().Contains(externalreferenceid.ToLower())).ToList<IQuestionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile>(o => o.ExternalReferenceId.Contains(externalreferenceid)).ToList<IQuestionProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionProfile entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionProfile entity)
		{
			var entityToSave = new QuestionProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Number != entity.Number) { entityToUpdate.Number = entity.Number;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.PlaintText != entity.PlaintText) { entityToUpdate.PlaintText = entity.PlaintText;doUpdate = true; }
			if (entityToUpdate.Text != entity.Text) { entityToUpdate.Text = entity.Text;doUpdate = true; }
			if (entityToUpdate.allowMultipleAnswers != entity.allowMultipleAnswers) { entityToUpdate.allowMultipleAnswers = entity.allowMultipleAnswers;doUpdate = true; }
			if (entityToUpdate.isVisibleAtStart != entity.isVisibleAtStart) { entityToUpdate.isVisibleAtStart = entity.isVisibleAtStart;doUpdate = true; }
			if (entityToUpdate.CopiedFromQuestionProfileTitle != entity.CopiedFromQuestionProfileTitle) { entityToUpdate.CopiedFromQuestionProfileTitle = entity.CopiedFromQuestionProfileTitle;doUpdate = true; }
			if (entityToUpdate.PromptPlaintText != entity.PromptPlaintText) { entityToUpdate.PromptPlaintText = entity.PromptPlaintText;doUpdate = true; }
			if (entityToUpdate.PromptText != entity.PromptText) { entityToUpdate.PromptText = entity.PromptText;doUpdate = true; }
			if (entityToUpdate.PrePopulatedByService != entity.PrePopulatedByService) { entityToUpdate.PrePopulatedByService = entity.PrePopulatedByService;doUpdate = true; }
			if (entityToUpdate.SequenceId != entity.SequenceId) { entityToUpdate.SequenceId = entity.SequenceId;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceId != entity.ExternalReferenceId) { entityToUpdate.ExternalReferenceId = entity.ExternalReferenceId;doUpdate = true; }
			if (entityToUpdate.AnswerRequired != entity.AnswerRequired) { entityToUpdate.AnswerRequired = entity.AnswerRequired;doUpdate = true; }
			if (entityToUpdate.DoNotDisplay != entity.DoNotDisplay) { entityToUpdate.DoNotDisplay = entity.DoNotDisplay;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionProfile entity from the database
        /// </summary>
        /// <param name="entity">IQuestionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
