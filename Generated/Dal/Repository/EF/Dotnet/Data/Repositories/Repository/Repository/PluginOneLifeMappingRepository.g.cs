
// <copyright file="PluginOneLifeMapping.g.cs" company="MIT">
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
	/// The PluginOneLifeMappingRepository class responsible for database functions in the PluginOneLifeMapping table
	/// </summary>
	public partial class PluginOneLifeMappingRepository : UowRepository<PluginOneLifeMapping> , IPluginOneLifeMappingRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeMappingRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeMappingRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeMapping entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeMapping</returns>
		public virtual IPluginOneLifeMapping LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeMapping>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Stamp == stamp).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.UserName == username).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByPluginOneLifeCedantId(Nullable<int> pluginonelifecedantid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.PluginOneLifeCedantId == pluginonelifecedantid).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the MappingID field
        /// </summary>
        /// <param name="mappingid">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByMappingID(string mappingid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.MappingID == mappingid).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Category field
        /// </summary>
        /// <param name="category">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByCategory(string category)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Category == category).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Section field
        /// </summary>
        /// <param name="section">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadBySection(string section)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Section == section).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByText(string text)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Text == text).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Min field
        /// </summary>
        /// <param name="min">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByMin(string min)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Min == min).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Max field
        /// </summary>
        /// <param name="max">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByMax(string max)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Max == max).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadBySectionProfileId(Nullable<int> sectionprofileid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.SectionProfileId == sectionprofileid).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the SectionProfile field
        /// </summary>
        /// <param name="sectionprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadBySectionProfile(string sectionprofile)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.SectionProfile == sectionprofile).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByQuestionProfileId(Nullable<int> questionprofileid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.QuestionProfileId == questionprofileid).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the QuestionProfile field
        /// </summary>
        /// <param name="questionprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByQuestionProfile(string questionprofile)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.QuestionProfile == questionprofile).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the AnswerProfileId field
        /// </summary>
        /// <param name="answerprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByAnswerProfileId(Nullable<int> answerprofileid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.AnswerProfileId == answerprofileid).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the AnswerProfile field
        /// </summary>
        /// <param name="answerprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByAnswerProfile(string answerprofile)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.AnswerProfile == answerprofile).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the ExternalRef field
        /// </summary>
        /// <param name="externalref">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByExternalRef(string externalref)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.ExternalRef == externalref).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Value == value).ToList<IPluginOneLifeMapping>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeMapping entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeMapping>().ToList<IPluginOneLifeMapping>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by MappingID
        /// </summary>
        /// <param name="mappingid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByMappingID(string mappingid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.MappingID.ToLower().Contains(mappingid.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.MappingID.Contains(mappingid)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Category
        /// </summary>
        /// <param name="category">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByCategory(string category, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Category.ToLower().Contains(category.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Category.Contains(category)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Section
        /// </summary>
        /// <param name="section">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchBySection(string section, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Section.ToLower().Contains(section.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Section.Contains(section)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByText(string text, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Text.ToLower().Contains(text.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Text.Contains(text)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Min
        /// </summary>
        /// <param name="min">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByMin(string min, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Min.ToLower().Contains(min.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Min.Contains(min)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Max
        /// </summary>
        /// <param name="max">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByMax(string max, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Max.ToLower().Contains(max.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Max.Contains(max)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by SectionProfile
        /// </summary>
        /// <param name="sectionprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchBySectionProfile(string sectionprofile, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.SectionProfile.ToLower().Contains(sectionprofile.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.SectionProfile.Contains(sectionprofile)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by QuestionProfile
        /// </summary>
        /// <param name="questionprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByQuestionProfile(string questionprofile, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.QuestionProfile.ToLower().Contains(questionprofile.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.QuestionProfile.Contains(questionprofile)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by AnswerProfile
        /// </summary>
        /// <param name="answerprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByAnswerProfile(string answerprofile, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.AnswerProfile.ToLower().Contains(answerprofile.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.AnswerProfile.Contains(answerprofile)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by ExternalRef
        /// </summary>
        /// <param name="externalref">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByExternalRef(string externalref, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.ExternalRef.ToLower().Contains(externalref.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.ExternalRef.Contains(externalref)).ToList<IPluginOneLifeMapping>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		public virtual IList<IPluginOneLifeMapping> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<IPluginOneLifeMapping>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeMapping>(o => o.Value.Contains(value)).ToList<IPluginOneLifeMapping>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeMapping entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeMapping entity)
		{
			var entityToSave = new PluginOneLifeMapping(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeMapping entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeMapping entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeMapping>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeMapping entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeCedantId != entity.PluginOneLifeCedantId) { entityToUpdate.PluginOneLifeCedantId = entity.PluginOneLifeCedantId;doUpdate = true; }
			if (entityToUpdate.MappingID != entity.MappingID) { entityToUpdate.MappingID = entity.MappingID;doUpdate = true; }
			if (entityToUpdate.Category != entity.Category) { entityToUpdate.Category = entity.Category;doUpdate = true; }
			if (entityToUpdate.Section != entity.Section) { entityToUpdate.Section = entity.Section;doUpdate = true; }
			if (entityToUpdate.Text != entity.Text) { entityToUpdate.Text = entity.Text;doUpdate = true; }
			if (entityToUpdate.Min != entity.Min) { entityToUpdate.Min = entity.Min;doUpdate = true; }
			if (entityToUpdate.Max != entity.Max) { entityToUpdate.Max = entity.Max;doUpdate = true; }
			if (entityToUpdate.SectionProfileId != entity.SectionProfileId) { entityToUpdate.SectionProfileId = entity.SectionProfileId;doUpdate = true; }
			if (entityToUpdate.SectionProfile != entity.SectionProfile) { entityToUpdate.SectionProfile = entity.SectionProfile;doUpdate = true; }
			if (entityToUpdate.QuestionProfileId != entity.QuestionProfileId) { entityToUpdate.QuestionProfileId = entity.QuestionProfileId;doUpdate = true; }
			if (entityToUpdate.QuestionProfile != entity.QuestionProfile) { entityToUpdate.QuestionProfile = entity.QuestionProfile;doUpdate = true; }
			if (entityToUpdate.AnswerProfileId != entity.AnswerProfileId) { entityToUpdate.AnswerProfileId = entity.AnswerProfileId;doUpdate = true; }
			if (entityToUpdate.AnswerProfile != entity.AnswerProfile) { entityToUpdate.AnswerProfile = entity.AnswerProfile;doUpdate = true; }
			if (entityToUpdate.ExternalRef != entity.ExternalRef) { entityToUpdate.ExternalRef = entity.ExternalRef;doUpdate = true; }
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifeMapping entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeMapping entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeMapping>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeMapping entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeMapping entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeMapping>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeMapping entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
