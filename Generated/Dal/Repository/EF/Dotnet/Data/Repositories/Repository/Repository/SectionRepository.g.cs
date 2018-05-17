
// <copyright file="Section.g.cs" company="MIT">
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
	/// The SectionRepository class responsible for database functions in the Section table
	/// </summary>
	public partial class SectionRepository : UowRepository<Section> , ISectionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SectionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SectionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Section entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISection</returns>
		public virtual ISection LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Section>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Section entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.Stamp == stamp).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.UserName == username).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the isVisible field
        /// </summary>
        /// <param name="isvisible">Nullable<bool></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadByisVisible(Nullable<bool> isvisible)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.isVisible == isvisible).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.QuestionnaireId == questionnaireid).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadBySectionProfileId(Nullable<int> sectionprofileid)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.SectionProfileId == sectionprofileid).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the SectionVersionId field
        /// </summary>
        /// <param name="sectionversionid">Nullable<int></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadBySectionVersionId(Nullable<int> sectionversionid)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.SectionVersionId == sectionversionid).ToList<ISection>();
		}
		
        /// <summary>
        /// Load Section entities from the database using the ParentSectionId field
        /// </summary>
        /// <param name="parentsectionid">Nullable<int></param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadByParentSectionId(Nullable<int> parentsectionid)
		{
			return this.UnitOfWork.AllMatching<Section>(o => o.ParentSectionId == parentsectionid).ToList<ISection>();
		}
		
        /// <summary>
        /// Load all Section entities from the database.
        /// </summary>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> LoadAll()
		{
			return this.UnitOfWork.GetAll<Section>().ToList<ISection>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Section entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISection></returns>
		public virtual IList<ISection> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Section>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISection>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Section>(o => o.UserName.Contains(username)).ToList<ISection>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Section entity to the database.
        /// </summary>
        /// <param name="entity">ISection</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISection entity)
		{
			var entityToSave = new Section(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Section entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISection</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISection entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Section>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Section entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.isVisible != entity.isVisible) { entityToUpdate.isVisible = entity.isVisible;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.SectionProfileId != entity.SectionProfileId) { entityToUpdate.SectionProfileId = entity.SectionProfileId;doUpdate = true; }
			if (entityToUpdate.SectionVersionId != entity.SectionVersionId) { entityToUpdate.SectionVersionId = entity.SectionVersionId;doUpdate = true; }
			if (entityToUpdate.ParentSectionId != entity.ParentSectionId) { entityToUpdate.ParentSectionId = entity.ParentSectionId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Section entity from the database
        /// </summary>
        /// <param name="entity">ISection</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISection entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Section>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Section entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Section entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Section>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Section entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
