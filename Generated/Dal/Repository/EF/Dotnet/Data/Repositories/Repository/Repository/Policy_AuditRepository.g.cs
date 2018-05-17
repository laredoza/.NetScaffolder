
// <copyright file="Policy_Audit.g.cs" company="MIT">
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
	/// The Policy_AuditRepository class responsible for database functions in the Policy_Audit table
	/// </summary>
	public partial class Policy_AuditRepository : UowRepository<Policy_Audit> , IPolicy_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Policy_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Policy_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Policy_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IPolicy_Audit</returns>
		public virtual IPolicy_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Policy_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.Id == id).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.Stamp == stamp).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.UserName == username).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the PolicyNumber field
        /// </summary>
        /// <param name="policynumber">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByPolicyNumber(Nullable<int> policynumber)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.PolicyNumber == policynumber).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the Premium field
        /// </summary>
        /// <param name="premium">Nullable<decimal></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByPremium(Nullable<decimal> premium)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.Premium == premium).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the SumAssured field
        /// </summary>
        /// <param name="sumassured">Nullable<decimal></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadBySumAssured(Nullable<decimal> sumassured)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.SumAssured == sumassured).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the ActivationDate field
        /// </summary>
        /// <param name="activationdate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByActivationDate(Nullable<DateTime> activationdate)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.ActivationDate == activationdate).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.QuestionnaireId == questionnaireid).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.Status == status).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByExternalReferenceId(string externalreferenceid)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.ExternalReferenceId == externalreferenceid).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the ExternalReferenceLocked field
        /// </summary>
        /// <param name="externalreferencelocked">Nullable<bool></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByExternalReferenceLocked(Nullable<bool> externalreferencelocked)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.ExternalReferenceLocked == externalreferencelocked).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the AcceptedStatus field
        /// </summary>
        /// <param name="acceptedstatus">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByAcceptedStatus(Nullable<int> acceptedstatus)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.AcceptedStatus == acceptedstatus).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the AcceptedDate field
        /// </summary>
        /// <param name="accepteddate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByAcceptedDate(Nullable<DateTime> accepteddate)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.AcceptedDate == accepteddate).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByCustomerId(Nullable<int> customerid)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.CustomerId == customerid).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load Policy_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IPolicy_Audit>();
		}
		
        /// <summary>
        /// Load all Policy_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Policy_Audit>().ToList<IPolicy_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Policy_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPolicy_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.UserName.Contains(username)).ToList<IPolicy_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Policy_Audit entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy_Audit></returns>
		public virtual IList<IPolicy_Audit> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.ExternalReferenceId.ToLower().Contains(externalreferenceid.ToLower())).ToList<IPolicy_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Policy_Audit>(o => o.ExternalReferenceId.Contains(externalreferenceid)).ToList<IPolicy_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Policy_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicy_Audit entity)
		{
			var entityToSave = new Policy_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Policy_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicy_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Policy_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Policy_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PolicyNumber != entity.PolicyNumber) { entityToUpdate.PolicyNumber = entity.PolicyNumber;doUpdate = true; }
			if (entityToUpdate.Premium != entity.Premium) { entityToUpdate.Premium = entity.Premium;doUpdate = true; }
			if (entityToUpdate.SumAssured != entity.SumAssured) { entityToUpdate.SumAssured = entity.SumAssured;doUpdate = true; }
			if (entityToUpdate.ActivationDate != entity.ActivationDate) { entityToUpdate.ActivationDate = entity.ActivationDate;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceId != entity.ExternalReferenceId) { entityToUpdate.ExternalReferenceId = entity.ExternalReferenceId;doUpdate = true; }
			if (entityToUpdate.ExternalReferenceLocked != entity.ExternalReferenceLocked) { entityToUpdate.ExternalReferenceLocked = entity.ExternalReferenceLocked;doUpdate = true; }
			if (entityToUpdate.AcceptedStatus != entity.AcceptedStatus) { entityToUpdate.AcceptedStatus = entity.AcceptedStatus;doUpdate = true; }
			if (entityToUpdate.AcceptedDate != entity.AcceptedDate) { entityToUpdate.AcceptedDate = entity.AcceptedDate;doUpdate = true; }
			if (entityToUpdate.CustomerId != entity.CustomerId) { entityToUpdate.CustomerId = entity.CustomerId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Policy_Audit entity from the database
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicy_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Policy_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Policy_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Policy_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Policy_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Policy_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
