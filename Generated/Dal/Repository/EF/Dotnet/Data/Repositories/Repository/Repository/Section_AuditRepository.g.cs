
// <copyright file="Section_Audit.g.cs" company="MIT">
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
	/// The Section_AuditRepository class responsible for database functions in the Section_Audit table
	/// </summary>
	public partial class Section_AuditRepository : UowRepository<Section_Audit> , ISection_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Section_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Section_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Section_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISection_Audit</returns>
		public virtual ISection_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Section_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.Id == id).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.Stamp == stamp).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.UserName == username).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the isVisible field
        /// </summary>
        /// <param name="isvisible">Nullable<bool></param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByisVisible(Nullable<bool> isvisible)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.isVisible == isvisible).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.QuestionnaireId == questionnaireid).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadBySectionProfileId(Nullable<int> sectionprofileid)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.SectionProfileId == sectionprofileid).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the SectionVersionId field
        /// </summary>
        /// <param name="sectionversionid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadBySectionVersionId(Nullable<int> sectionversionid)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.SectionVersionId == sectionversionid).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the ParentSectionId field
        /// </summary>
        /// <param name="parentsectionid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByParentSectionId(Nullable<int> parentsectionid)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.ParentSectionId == parentsectionid).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load Section_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Section_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ISection_Audit>();
		}
		
        /// <summary>
        /// Load all Section_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Section_Audit>().ToList<ISection_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Section_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISection_Audit></returns>
		public virtual IList<ISection_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Section_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISection_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Section_Audit>(o => o.UserName.Contains(username)).ToList<ISection_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Section_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISection_Audit entity)
		{
			var entityToSave = new Section_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Section_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISection_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Section_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Section_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.isVisible != entity.isVisible) { entityToUpdate.isVisible = entity.isVisible;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.SectionProfileId != entity.SectionProfileId) { entityToUpdate.SectionProfileId = entity.SectionProfileId;doUpdate = true; }
			if (entityToUpdate.SectionVersionId != entity.SectionVersionId) { entityToUpdate.SectionVersionId = entity.SectionVersionId;doUpdate = true; }
			if (entityToUpdate.ParentSectionId != entity.ParentSectionId) { entityToUpdate.ParentSectionId = entity.ParentSectionId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Section_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISection_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Section_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Section_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Section_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Section_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Section_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
