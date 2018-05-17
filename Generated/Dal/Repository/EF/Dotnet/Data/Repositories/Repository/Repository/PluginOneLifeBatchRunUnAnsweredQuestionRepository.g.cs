
// <copyright file="PluginOneLifeBatchRunUnAnsweredQuestion.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunUnAnsweredQuestionRepository class responsible for database functions in the PluginOneLifeBatchRunUnAnsweredQuestion table
	/// </summary>
	public partial class PluginOneLifeBatchRunUnAnsweredQuestionRepository : UowRepository<PluginOneLifeBatchRunUnAnsweredQuestion> , IPluginOneLifeBatchRunUnAnsweredQuestionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeBatchRunUnAnsweredQuestionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeBatchRunUnAnsweredQuestionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunUnAnsweredQuestion</returns>
		public virtual IPluginOneLifeBatchRunUnAnsweredQuestion LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Stamp == stamp).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.UserName == username).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the PluginOneLifeBatchRunPolicyId field
        /// </summary>
        /// <param name="pluginonelifebatchrunpolicyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByPluginOneLifeBatchRunPolicyId(Nullable<int> pluginonelifebatchrunpolicyid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.PluginOneLifeBatchRunPolicyId == pluginonelifebatchrunpolicyid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByQuestionProfileId(Nullable<int> questionprofileid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.QuestionProfileId == questionprofileid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByText(string text)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Text == text).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByTitle(string title)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Title == title).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionId(Nullable<int> sectionid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionId == sectionid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionExtRefId field
        /// </summary>
        /// <param name="sectionextrefid">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionExtRefId(string sectionextrefid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionExtRefId == sectionextrefid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionName field
        /// </summary>
        /// <param name="sectionname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionName(string sectionname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionName == sectionname).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionExtRefId field
        /// </summary>
        /// <param name="parentsectionextrefid">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionExtRefId(string parentsectionextrefid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionExtRefId == parentsectionextrefid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionId field
        /// </summary>
        /// <param name="parentsectionid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionId(Nullable<int> parentsectionid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionId == parentsectionid).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionName field
        /// </summary>
        /// <param name="parentsectionname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionName(string parentsectionname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionName == parentsectionname).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeBatchRunUnAnsweredQuestion entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeBatchRunUnAnsweredQuestion>().ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByText(string text, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Text.ToLower().Contains(text.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Text.Contains(text)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByTitle(string title, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Title.ToLower().Contains(title.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Title.Contains(title)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by SectionExtRefId
        /// </summary>
        /// <param name="sectionextrefid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchBySectionExtRefId(string sectionextrefid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionExtRefId.ToLower().Contains(sectionextrefid.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionExtRefId.Contains(sectionextrefid)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by SectionName
        /// </summary>
        /// <param name="sectionname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchBySectionName(string sectionname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionName.ToLower().Contains(sectionname.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.SectionName.Contains(sectionname)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by ParentSectionExtRefId
        /// </summary>
        /// <param name="parentsectionextrefid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByParentSectionExtRefId(string parentsectionextrefid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionExtRefId.ToLower().Contains(parentsectionextrefid.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionExtRefId.Contains(parentsectionextrefid)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by ParentSectionName
        /// </summary>
        /// <param name="parentsectionname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		public virtual IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByParentSectionName(string parentsectionname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionName.ToLower().Contains(parentsectionname.ToLower())).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.ParentSectionName.Contains(parentsectionname)).ToList<IPluginOneLifeBatchRunUnAnsweredQuestion>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunUnAnsweredQuestion entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeBatchRunUnAnsweredQuestion entity)
		{
			var entityToSave = new PluginOneLifeBatchRunUnAnsweredQuestion(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunUnAnsweredQuestion entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeBatchRunUnAnsweredQuestion entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeBatchRunUnAnsweredQuestion entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeBatchRunPolicyId != entity.PluginOneLifeBatchRunPolicyId) { entityToUpdate.PluginOneLifeBatchRunPolicyId = entity.PluginOneLifeBatchRunPolicyId;doUpdate = true; }
			if (entityToUpdate.QuestionProfileId != entity.QuestionProfileId) { entityToUpdate.QuestionProfileId = entity.QuestionProfileId;doUpdate = true; }
			if (entityToUpdate.Text != entity.Text) { entityToUpdate.Text = entity.Text;doUpdate = true; }
			if (entityToUpdate.Title != entity.Title) { entityToUpdate.Title = entity.Title;doUpdate = true; }
			if (entityToUpdate.SectionId != entity.SectionId) { entityToUpdate.SectionId = entity.SectionId;doUpdate = true; }
			if (entityToUpdate.SectionExtRefId != entity.SectionExtRefId) { entityToUpdate.SectionExtRefId = entity.SectionExtRefId;doUpdate = true; }
			if (entityToUpdate.SectionName != entity.SectionName) { entityToUpdate.SectionName = entity.SectionName;doUpdate = true; }
			if (entityToUpdate.ParentSectionExtRefId != entity.ParentSectionExtRefId) { entityToUpdate.ParentSectionExtRefId = entity.ParentSectionExtRefId;doUpdate = true; }
			if (entityToUpdate.ParentSectionId != entity.ParentSectionId) { entityToUpdate.ParentSectionId = entity.ParentSectionId;doUpdate = true; }
			if (entityToUpdate.ParentSectionName != entity.ParentSectionName) { entityToUpdate.ParentSectionName = entity.ParentSectionName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeBatchRunUnAnsweredQuestion entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunUnAnsweredQuestion entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRunUnAnsweredQuestion>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRunUnAnsweredQuestion entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
