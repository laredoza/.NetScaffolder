
// <copyright file="VersionCondition_Audit.g.cs" company="MIT">
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
	/// The VersionCondition_AuditRepository class responsible for database functions in the VersionCondition_Audit table
	/// </summary>
	public partial class VersionCondition_AuditRepository : UowRepository<VersionCondition_Audit> , IVersionCondition_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionCondition_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionCondition_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionCondition_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IVersionCondition_Audit</returns>
		public virtual IVersionCondition_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionCondition_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.Id == id).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.Stamp == stamp).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.UserName == username).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.Name == name).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the RunAtEnd field
        /// </summary>
        /// <param name="runatend">Nullable<bool></param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByRunAtEnd(Nullable<bool> runatend)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.RunAtEnd == runatend).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the QuestionnaireVersionId field
        /// </summary>
        /// <param name="questionnaireversionid">Nullable<int></param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByQuestionnaireVersionId(Nullable<int> questionnaireversionid)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.QuestionnaireVersionId == questionnaireversionid).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the ConditionSetContainerId field
        /// </summary>
        /// <param name="conditionsetcontainerid">Nullable<int></param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByConditionSetContainerId(Nullable<int> conditionsetcontainerid)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.ConditionSetContainerId == conditionsetcontainerid).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load VersionCondition_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IVersionCondition_Audit>();
		}
		
        /// <summary>
        /// Load all VersionCondition_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionCondition_Audit>().ToList<IVersionCondition_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for VersionCondition_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IVersionCondition_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.UserName.Contains(username)).ToList<IVersionCondition_Audit>();
			}
		}
		
        /// <summary>
        /// Search for VersionCondition_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition_Audit></returns>
		public virtual IList<IVersionCondition_Audit> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IVersionCondition_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionCondition_Audit>(o => o.Name.Contains(name)).ToList<IVersionCondition_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionCondition_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IVersionCondition_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionCondition_Audit entity)
		{
			var entityToSave = new VersionCondition_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionCondition_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionCondition_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionCondition_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionCondition_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionCondition_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.RunAtEnd != entity.RunAtEnd) { entityToUpdate.RunAtEnd = entity.RunAtEnd;doUpdate = true; }
			if (entityToUpdate.QuestionnaireVersionId != entity.QuestionnaireVersionId) { entityToUpdate.QuestionnaireVersionId = entity.QuestionnaireVersionId;doUpdate = true; }
			if (entityToUpdate.ConditionSetContainerId != entity.ConditionSetContainerId) { entityToUpdate.ConditionSetContainerId = entity.ConditionSetContainerId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionCondition_Audit entity from the database
        /// </summary>
        /// <param name="entity">IVersionCondition_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionCondition_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionCondition_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionCondition_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionCondition_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionCondition_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionCondition_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
