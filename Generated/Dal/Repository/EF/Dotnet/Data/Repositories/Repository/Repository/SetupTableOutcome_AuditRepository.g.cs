
// <copyright file="SetupTableOutcome_Audit.g.cs" company="MIT">
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
	/// The SetupTableOutcome_AuditRepository class responsible for database functions in the SetupTableOutcome_Audit table
	/// </summary>
	public partial class SetupTableOutcome_AuditRepository : UowRepository<SetupTableOutcome_Audit> , ISetupTableOutcome_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SetupTableOutcome_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SetupTableOutcome_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SetupTableOutcome_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISetupTableOutcome_Audit</returns>
		public virtual ISetupTableOutcome_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<SetupTableOutcome_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.Id == id).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.Stamp == stamp).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.UserName == username).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.SetupTableDataId == setuptabledataid).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.ProviderId == providerid).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load SetupTableOutcome_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ISetupTableOutcome_Audit>();
		}
		
        /// <summary>
        /// Load all SetupTableOutcome_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<SetupTableOutcome_Audit>().ToList<ISetupTableOutcome_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SetupTableOutcome_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableOutcome_Audit></returns>
		public virtual IList<ISetupTableOutcome_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISetupTableOutcome_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTableOutcome_Audit>(o => o.UserName.Contains(username)).ToList<ISetupTableOutcome_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTableOutcome_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTableOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISetupTableOutcome_Audit entity)
		{
			var entityToSave = new SetupTableOutcome_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SetupTableOutcome_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTableOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISetupTableOutcome_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SetupTableOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SetupTableOutcome_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
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
        /// Delete the SetupTableOutcome_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISetupTableOutcome_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISetupTableOutcome_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableOutcome_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SetupTableOutcome_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableOutcome_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableOutcome_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
