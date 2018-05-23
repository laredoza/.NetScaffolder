﻿
// <copyright file="Questionnaire_Audit.g.cs" company="MIT">
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
	/// The Questionnaire_AuditRepository class responsible for database functions in the Questionnaire_Audit table
	/// </summary>
	public partial class Questionnaire_AuditRepository : UowRepository<Questionnaire_Audit> , IQuestionnaire_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Questionnaire_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Questionnaire_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Questionnaire_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IQuestionnaire_Audit</returns>
		public virtual IQuestionnaire_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Questionnaire_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.Id == id).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.Stamp == stamp).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.UserName == username).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.Status == status).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.QuestionnaireProfileVersionId == questionnaireprofileversionid).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByRemainingChanges(Nullable<int> remainingchanges)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.RemainingChanges == remainingchanges).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.PolicyId == policyid).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load Questionnaire_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IQuestionnaire_Audit>();
		}
		
        /// <summary>
        /// Load all Questionnaire_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Questionnaire_Audit>().ToList<IQuestionnaire_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Questionnaire_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaire_Audit></returns>
		public virtual IList<IQuestionnaire_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionnaire_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Questionnaire_Audit>(o => o.UserName.Contains(username)).ToList<IQuestionnaire_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Questionnaire_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaire_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaire_Audit entity)
		{
			var entityToSave = new Questionnaire_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Questionnaire_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaire_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaire_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Questionnaire_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Questionnaire_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.QuestionnaireProfileVersionId != entity.QuestionnaireProfileVersionId) { entityToUpdate.QuestionnaireProfileVersionId = entity.QuestionnaireProfileVersionId;doUpdate = true; }
			if (entityToUpdate.RemainingChanges != entity.RemainingChanges) { entityToUpdate.RemainingChanges = entity.RemainingChanges;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Questionnaire_Audit entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaire_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaire_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Questionnaire_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Questionnaire_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Questionnaire_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Questionnaire_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Questionnaire_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}