
// <copyright file="AnswerOutcome_Audit.g.cs" company="MIT">
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
	/// The AnswerOutcome_AuditRepository class responsible for database functions in the AnswerOutcome_Audit table
	/// </summary>
	public partial class AnswerOutcome_AuditRepository : UowRepository<AnswerOutcome_Audit> , IAnswerOutcome_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerOutcome_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerOutcome_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerOutcome_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IAnswerOutcome_Audit</returns>
		public virtual IAnswerOutcome_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerOutcome_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.Id == id).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.Stamp == stamp).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.UserName == username).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the AnswerProfileId field
        /// </summary>
        /// <param name="answerprofileid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadByAnswerProfileId(Nullable<int> answerprofileid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.AnswerProfileId == answerprofileid).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.ProviderId == providerid).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load AnswerOutcome_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IAnswerOutcome_Audit>();
		}
		
        /// <summary>
        /// Load all AnswerOutcome_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerOutcome_Audit>().ToList<IAnswerOutcome_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerOutcome_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerOutcome_Audit></returns>
		public virtual IList<IAnswerOutcome_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswerOutcome_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerOutcome_Audit>(o => o.UserName.Contains(username)).ToList<IAnswerOutcome_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerOutcome_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerOutcome_Audit entity)
		{
			var entityToSave = new AnswerOutcome_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerOutcome_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerOutcome_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerOutcome_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.AnswerProfileId != entity.AnswerProfileId) { entityToUpdate.AnswerProfileId = entity.AnswerProfileId;doUpdate = true; }
			if (entityToUpdate.ProviderId != entity.ProviderId) { entityToUpdate.ProviderId = entity.ProviderId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerOutcome_Audit entity from the database
        /// </summary>
        /// <param name="entity">IAnswerOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerOutcome_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerOutcome_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcome_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
