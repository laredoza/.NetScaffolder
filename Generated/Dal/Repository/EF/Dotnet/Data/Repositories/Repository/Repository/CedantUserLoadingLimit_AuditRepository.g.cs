
// <copyright file="CedantUserLoadingLimit_Audit.g.cs" company="MIT">
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
	/// The CedantUserLoadingLimit_AuditRepository class responsible for database functions in the CedantUserLoadingLimit_Audit table
	/// </summary>
	public partial class CedantUserLoadingLimit_AuditRepository : UowRepository<CedantUserLoadingLimit_Audit> , ICedantUserLoadingLimit_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantUserLoadingLimit_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantUserLoadingLimit_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantUserLoadingLimit_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedantUserLoadingLimit_Audit</returns>
		public virtual ICedantUserLoadingLimit_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.Id == id).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.Stamp == stamp).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.UserName == username).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MinPercentage field
        /// </summary>
        /// <param name="minpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByMinPercentage(Nullable<decimal> minpercentage)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.MinPercentage == minpercentage).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MaxPercentage field
        /// </summary>
        /// <param name="maxpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByMaxPercentage(Nullable<decimal> maxpercentage)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.MaxPercentage == maxpercentage).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.UserId == userid).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByPremiumProfileId(Nullable<int> premiumprofileid)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.PremiumProfileId == premiumprofileid).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MinUnit field
        /// </summary>
        /// <param name="minunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByMinUnit(Nullable<decimal> minunit)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.MinUnit == minunit).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MaxUnit field
        /// </summary>
        /// <param name="maxunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadByMaxUnit(Nullable<decimal> maxunit)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.MaxUnit == maxunit).ToList<ICedantUserLoadingLimit_Audit>();
		}
		
        /// <summary>
        /// Load all CedantUserLoadingLimit_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantUserLoadingLimit_Audit>().ToList<ICedantUserLoadingLimit_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantUserLoadingLimit_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		public virtual IList<ICedantUserLoadingLimit_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantUserLoadingLimit_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantUserLoadingLimit_Audit>(o => o.UserName.Contains(username)).ToList<ICedantUserLoadingLimit_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantUserLoadingLimit_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantUserLoadingLimit_Audit entity)
		{
			var entityToSave = new CedantUserLoadingLimit_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantUserLoadingLimit_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantUserLoadingLimit_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantUserLoadingLimit_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.MinPercentage != entity.MinPercentage) { entityToUpdate.MinPercentage = entity.MinPercentage;doUpdate = true; }
			if (entityToUpdate.MaxPercentage != entity.MaxPercentage) { entityToUpdate.MaxPercentage = entity.MaxPercentage;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.PremiumProfileId != entity.PremiumProfileId) { entityToUpdate.PremiumProfileId = entity.PremiumProfileId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.MinUnit != entity.MinUnit) { entityToUpdate.MinUnit = entity.MinUnit;doUpdate = true; }
			if (entityToUpdate.MaxUnit != entity.MaxUnit) { entityToUpdate.MaxUnit = entity.MaxUnit;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantUserLoadingLimit_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantUserLoadingLimit_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantUserLoadingLimit_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
