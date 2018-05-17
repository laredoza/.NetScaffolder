
// <copyright file="CedantProduct_Audit.g.cs" company="MIT">
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
	/// The CedantProduct_AuditRepository class responsible for database functions in the CedantProduct_Audit table
	/// </summary>
	public partial class CedantProduct_AuditRepository : UowRepository<CedantProduct_Audit> , ICedantProduct_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantProduct_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantProduct_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantProduct_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedantProduct_Audit</returns>
		public virtual ICedantProduct_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantProduct_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.Id == id).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.Stamp == stamp).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.UserName == username).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.ProductId == productid).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the Flexibility field
        /// </summary>
        /// <param name="flexibility">Nullable<int></param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByFlexibility(Nullable<int> flexibility)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.Flexibility == flexibility).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the MaximumPercentage field
        /// </summary>
        /// <param name="maximumpercentage">Nullable<int></param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByMaximumPercentage(Nullable<int> maximumpercentage)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.MaximumPercentage == maximumpercentage).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.CedantId == cedantid).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.AuditTrailType == audittrailtype).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load CedantProduct_Audit entities from the database using the MaximumUnit field
        /// </summary>
        /// <param name="maximumunit">Nullable<decimal></param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadByMaximumUnit(Nullable<decimal> maximumunit)
		{
			return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.MaximumUnit == maximumunit).ToList<ICedantProduct_Audit>();
		}
		
        /// <summary>
        /// Load all CedantProduct_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantProduct_Audit>().ToList<ICedantProduct_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantProduct_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantProduct_Audit></returns>
		public virtual IList<ICedantProduct_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantProduct_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantProduct_Audit>(o => o.UserName.Contains(username)).ToList<ICedantProduct_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantProduct_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantProduct_Audit entity)
		{
			var entityToSave = new CedantProduct_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantProduct_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantProduct_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantProduct_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantProduct_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.Flexibility != entity.Flexibility) { entityToUpdate.Flexibility = entity.Flexibility;doUpdate = true; }
			if (entityToUpdate.MaximumPercentage != entity.MaximumPercentage) { entityToUpdate.MaximumPercentage = entity.MaximumPercentage;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.MaximumUnit != entity.MaximumUnit) { entityToUpdate.MaximumUnit = entity.MaximumUnit;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantProduct_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedantProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantProduct_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantProduct_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantProduct_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantProduct_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantProduct_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantProduct_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
