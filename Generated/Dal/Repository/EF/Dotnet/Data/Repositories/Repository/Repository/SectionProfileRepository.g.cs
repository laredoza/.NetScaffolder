
// <copyright file="SectionProfile.g.cs" company="MIT">
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
	/// The SectionProfileRepository class responsible for database functions in the SectionProfile table
	/// </summary>
	public partial class SectionProfileRepository : UowRepository<SectionProfile> , ISectionProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SectionProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionProfile</returns>
		public virtual ISectionProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SectionProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.Stamp == stamp).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.UserName == username).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.Title == title).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.isVisibleAtStart == isvisibleatstart).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the isQuestionsGrouped field
        /// </summary>
        /// <param name="isquestionsgrouped">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByisQuestionsGrouped(Nullable<bool> isquestionsgrouped)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.isQuestionsGrouped == isquestionsgrouped).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the CopiedFromSectionProfileTitle field
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.CopiedFromSectionProfileTitle == copiedfromsectionprofiletitle).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByExternalReferenceId(string externalreferenceid)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.ExternalReferenceId == externalreferenceid).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByPromptText(string prompttext)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.PromptText == prompttext).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load SectionProfile entities from the database using the isPopupWindow field
        /// </summary>
        /// <param name="ispopupwindow">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadByisPopupWindow(Nullable<bool> ispopupwindow)
		{
			return this.UnitOfWork.AllMatching<SectionProfile>(o => o.isPopupWindow == ispopupwindow).ToList<ISectionProfile>();
		}
		
        /// <summary>
        /// Load all SectionProfile entities from the database.
        /// </summary>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<SectionProfile>().ToList<ISectionProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SectionProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISectionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.UserName.Contains(username)).ToList<ISectionProfile>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<ISectionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.Title.Contains(title)).ToList<ISectionProfile>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile entities in the database by CopiedFromSectionProfileTitle
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> SearchByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.CopiedFromSectionProfileTitle.ToLower().Contains(copiedfromsectionprofiletitle.ToLower())).ToList<ISectionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.CopiedFromSectionProfileTitle.Contains(copiedfromsectionprofiletitle)).ToList<ISectionProfile>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.ExternalReferenceId.ToLower().Contains(externalreferenceid.ToLower())).ToList<ISectionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.ExternalReferenceId.Contains(externalreferenceid)).ToList<ISectionProfile>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		public virtual IList<ISectionProfile> SearchByPromptText(string prompttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.PromptText.ToLower().Contains(prompttext.ToLower())).ToList<ISectionProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile>(o => o.PromptText.Contains(prompttext)).ToList<ISectionProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionProfile entity to the database.
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISectionProfile entity)
		{
			var entityToSave = new SectionProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SectionProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISectionProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SectionProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SectionProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.isVisibleAtStart != entity.isVisibleAtStart) { entityToUpdate.isVisibleAtStart = entity.isVisibleAtStart;doUpdate = true; }
			if (entityToUpdate.isQuestionsGrouped != entity.isQuestionsGrouped) { entityToUpdate.isQuestionsGrouped = entity.isQuestionsGrouped;doUpdate = true; }
			if (entityToUpdate.CopiedFromSectionProfileTitle != entity.CopiedFromSectionProfileTitle) { entityToUpdate.CopiedFromSectionProfileTitle = entity.CopiedFromSectionProfileTitle;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceId != entity.ExternalReferenceId) { entityToUpdate.ExternalReferenceId = entity.ExternalReferenceId;doUpdate = true; }
			if (entityToUpdate.PromptText != entity.PromptText) { entityToUpdate.PromptText = entity.PromptText;doUpdate = true; }
			if (entityToUpdate.isPopupWindow != entity.isPopupWindow) { entityToUpdate.isPopupWindow = entity.isPopupWindow;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SectionProfile entity from the database
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISectionProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SectionProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
