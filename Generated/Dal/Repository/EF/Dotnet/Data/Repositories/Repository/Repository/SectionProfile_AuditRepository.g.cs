
// <copyright file="SectionProfile_Audit.g.cs" company="MIT">
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
	/// The SectionProfile_AuditRepository class responsible for database functions in the SectionProfile_Audit table
	/// </summary>
	public partial class SectionProfile_AuditRepository : UowRepository<SectionProfile_Audit> , ISectionProfile_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionProfile_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionProfile_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SectionProfile_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISectionProfile_Audit</returns>
		public virtual ISectionProfile_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<SectionProfile_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.Id == id).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.Stamp == stamp).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.UserName == username).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.Title == title).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.isVisibleAtStart == isvisibleatstart).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isQuestionsGrouped field
        /// </summary>
        /// <param name="isquestionsgrouped">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByisQuestionsGrouped(Nullable<bool> isquestionsgrouped)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.isQuestionsGrouped == isquestionsgrouped).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the CopiedFromSectionProfileTitle field
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.CopiedFromSectionProfileTitle == copiedfromsectionprofiletitle).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByPromptText(string prompttext)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.PromptText == prompttext).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isPopupWindow field
        /// </summary>
        /// <param name="ispopupwindow">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadByisPopupWindow(Nullable<bool> ispopupwindow)
		{
			return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.isPopupWindow == ispopupwindow).ToList<ISectionProfile_Audit>();
		}
		
        /// <summary>
        /// Load all SectionProfile_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<SectionProfile_Audit>().ToList<ISectionProfile_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISectionProfile_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.UserName.Contains(username)).ToList<ISectionProfile_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<ISectionProfile_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.Title.Contains(title)).ToList<ISectionProfile_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by CopiedFromSectionProfileTitle
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> SearchByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.CopiedFromSectionProfileTitle.ToLower().Contains(copiedfromsectionprofiletitle.ToLower())).ToList<ISectionProfile_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.CopiedFromSectionProfileTitle.Contains(copiedfromsectionprofiletitle)).ToList<ISectionProfile_Audit>();
			}
		}
		
        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		public virtual IList<ISectionProfile_Audit> SearchByPromptText(string prompttext, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.PromptText.ToLower().Contains(prompttext.ToLower())).ToList<ISectionProfile_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SectionProfile_Audit>(o => o.PromptText.Contains(prompttext)).ToList<ISectionProfile_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionProfile_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISectionProfile_Audit entity)
		{
			var entityToSave = new SectionProfile_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SectionProfile_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISectionProfile_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SectionProfile_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SectionProfile_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.isVisibleAtStart != entity.isVisibleAtStart) { entityToUpdate.isVisibleAtStart = entity.isVisibleAtStart;doUpdate = true; }
			if (entityToUpdate.isQuestionsGrouped != entity.isQuestionsGrouped) { entityToUpdate.isQuestionsGrouped = entity.isQuestionsGrouped;doUpdate = true; }
			if (entityToUpdate.CopiedFromSectionProfileTitle != entity.CopiedFromSectionProfileTitle) { entityToUpdate.CopiedFromSectionProfileTitle = entity.CopiedFromSectionProfileTitle;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
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
        /// Delete the SectionProfile_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISectionProfile_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionProfile_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionProfile_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SectionProfile_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SectionProfile_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SectionProfile_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
