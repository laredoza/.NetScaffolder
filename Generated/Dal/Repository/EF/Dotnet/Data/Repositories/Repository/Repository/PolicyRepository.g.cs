
// <copyright file="Policy.g.cs" company="MIT">
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
	/// The PolicyRepository class responsible for database functions in the Policy table
	/// </summary>
	public partial class PolicyRepository : UowRepository<Policy> , IPolicyRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PolicyRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PolicyRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Policy entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPolicy</returns>
		public virtual IPolicy LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Policy>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Policy entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.Stamp == stamp).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.UserName == username).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the PolicyNumber field
        /// </summary>
        /// <param name="policynumber">Nullable<int></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByPolicyNumber(Nullable<int> policynumber)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.PolicyNumber == policynumber).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the Premium field
        /// </summary>
        /// <param name="premium">Nullable<decimal></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByPremium(Nullable<decimal> premium)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.Premium == premium).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the SumAssured field
        /// </summary>
        /// <param name="sumassured">Nullable<decimal></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadBySumAssured(Nullable<decimal> sumassured)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.SumAssured == sumassured).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the ActivationDate field
        /// </summary>
        /// <param name="activationdate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByActivationDate(Nullable<DateTime> activationdate)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.ActivationDate == activationdate).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.QuestionnaireId == questionnaireid).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.Status == status).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByExternalReferenceId(string externalreferenceid)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.ExternalReferenceId == externalreferenceid).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the ExternalReferenceLocked field
        /// </summary>
        /// <param name="externalreferencelocked">Nullable<bool></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByExternalReferenceLocked(Nullable<bool> externalreferencelocked)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.ExternalReferenceLocked == externalreferencelocked).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the AcceptedStatus field
        /// </summary>
        /// <param name="acceptedstatus">Nullable<int></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByAcceptedStatus(Nullable<int> acceptedstatus)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.AcceptedStatus == acceptedstatus).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the AcceptedDate field
        /// </summary>
        /// <param name="accepteddate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByAcceptedDate(Nullable<DateTime> accepteddate)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.AcceptedDate == accepteddate).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load Policy entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadByCustomerId(Nullable<int> customerid)
		{
			return this.UnitOfWork.AllMatching<Policy>(o => o.CustomerId == customerid).ToList<IPolicy>();
		}
		
        /// <summary>
        /// Load all Policy entities from the database.
        /// </summary>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> LoadAll()
		{
			return this.UnitOfWork.GetAll<Policy>().ToList<IPolicy>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Policy entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Policy>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Policy>(o => o.UserName.Contains(username)).ToList<IPolicy>();
			}
		}
		
        /// <summary>
        /// Search for Policy entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy></returns>
		public virtual IList<IPolicy> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Policy>(o => o.ExternalReferenceId.ToLower().Contains(externalreferenceid.ToLower())).ToList<IPolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Policy>(o => o.ExternalReferenceId.Contains(externalreferenceid)).ToList<IPolicy>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Policy entity to the database.
        /// </summary>
        /// <param name="entity">IPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicy entity)
		{
			var entityToSave = new Policy(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Policy entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicy entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Policy>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Policy entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
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

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Policy entity from the database
        /// </summary>
        /// <param name="entity">IPolicy</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicy entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Policy>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Policy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Policy entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Policy>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Policy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
