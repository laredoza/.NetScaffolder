
// <copyright file="WCFLog_Audit.g.cs" company="MIT">
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
	/// The WCFLog_AuditRepository class responsible for database functions in the WCFLog_Audit table
	/// </summary>
	public partial class WCFLog_AuditRepository : UowRepository<WCFLog_Audit> , IWCFLog_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for WCFLog_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public WCFLog_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the WCFLog_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IWCFLog_Audit</returns>
		public virtual IWCFLog_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<WCFLog_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load WCFLog_Audit entities from the database using the id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadByid(int id)
		{
			return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.id == id).ToList<IWCFLog_Audit>();
		}
		
        /// <summary>
        /// Load WCFLog_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.Description == description).ToList<IWCFLog_Audit>();
		}
		
        /// <summary>
        /// Load WCFLog_Audit entities from the database using the AdditionalDetails field
        /// </summary>
        /// <param name="additionaldetails">string</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadByAdditionalDetails(string additionaldetails)
		{
			return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.AdditionalDetails == additionaldetails).ToList<IWCFLog_Audit>();
		}
		
        /// <summary>
        /// Load WCFLog_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.Stamp == stamp).ToList<IWCFLog_Audit>();
		}
		
        /// <summary>
        /// Load WCFLog_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IWCFLog_Audit>();
		}
		
        /// <summary>
        /// Load all WCFLog_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<WCFLog_Audit>().ToList<IWCFLog_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for WCFLog_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IWCFLog_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.Description.Contains(description)).ToList<IWCFLog_Audit>();
			}
		}
		
        /// <summary>
        /// Search for WCFLog_Audit entities in the database by AdditionalDetails
        /// </summary>
        /// <param name="additionaldetails">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		public virtual IList<IWCFLog_Audit> SearchByAdditionalDetails(string additionaldetails, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.AdditionalDetails.ToLower().Contains(additionaldetails.ToLower())).ToList<IWCFLog_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<WCFLog_Audit>(o => o.AdditionalDetails.Contains(additionaldetails)).ToList<IWCFLog_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the WCFLog_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IWCFLog_Audit entity)
		{
			var entityToSave = new WCFLog_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the WCFLog_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IWCFLog_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<WCFLog_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The WCFLog_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.id != entity.id) { entityToUpdate.id = entity.id;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.AdditionalDetails != entity.AdditionalDetails) { entityToUpdate.AdditionalDetails = entity.AdditionalDetails;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the WCFLog_Audit entity from the database
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IWCFLog_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<WCFLog_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The WCFLog_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the WCFLog_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<WCFLog_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The WCFLog_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
