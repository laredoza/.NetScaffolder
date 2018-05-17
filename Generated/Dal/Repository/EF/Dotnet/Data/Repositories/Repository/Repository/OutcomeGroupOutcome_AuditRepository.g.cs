
// <copyright file="OutcomeGroupOutcome_Audit.g.cs" company="MIT">
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
	/// The OutcomeGroupOutcome_AuditRepository class responsible for database functions in the OutcomeGroupOutcome_Audit table
	/// </summary>
	public partial class OutcomeGroupOutcome_AuditRepository : UowRepository<OutcomeGroupOutcome_Audit> , IOutcomeGroupOutcome_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for OutcomeGroupOutcome_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public OutcomeGroupOutcome_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the OutcomeGroupOutcome_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IOutcomeGroupOutcome_Audit</returns>
		public virtual IOutcomeGroupOutcome_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<OutcomeGroupOutcome_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.Id == id).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.Stamp == stamp).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.UserName == username).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the OutcomeGroupId field
        /// </summary>
        /// <param name="outcomegroupid">Nullable<int></param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadByOutcomeGroupId(Nullable<int> outcomegroupid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.OutcomeGroupId == outcomegroupid).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.ProviderId == providerid).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load OutcomeGroupOutcome_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IOutcomeGroupOutcome_Audit>();
		}
		
        /// <summary>
        /// Load all OutcomeGroupOutcome_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<OutcomeGroupOutcome_Audit>().ToList<IOutcomeGroupOutcome_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for OutcomeGroupOutcome_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeGroupOutcome_Audit></returns>
		public virtual IList<IOutcomeGroupOutcome_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IOutcomeGroupOutcome_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<OutcomeGroupOutcome_Audit>(o => o.UserName.Contains(username)).ToList<IOutcomeGroupOutcome_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeGroupOutcome_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeGroupOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IOutcomeGroupOutcome_Audit entity)
		{
			var entityToSave = new OutcomeGroupOutcome_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the OutcomeGroupOutcome_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeGroupOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IOutcomeGroupOutcome_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<OutcomeGroupOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The OutcomeGroupOutcome_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.OutcomeGroupId != entity.OutcomeGroupId) { entityToUpdate.OutcomeGroupId = entity.OutcomeGroupId;doUpdate = true; }
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
        /// Delete the OutcomeGroupOutcome_Audit entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeGroupOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IOutcomeGroupOutcome_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeGroupOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeGroupOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the OutcomeGroupOutcome_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<OutcomeGroupOutcome_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The OutcomeGroupOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
