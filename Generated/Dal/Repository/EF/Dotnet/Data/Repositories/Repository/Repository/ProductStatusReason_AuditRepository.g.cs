
// <copyright file="ProductStatusReason_Audit.g.cs" company="MIT">
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
	/// The ProductStatusReason_AuditRepository class responsible for database functions in the ProductStatusReason_Audit table
	/// </summary>
	public partial class ProductStatusReason_AuditRepository : UowRepository<ProductStatusReason_Audit> , IProductStatusReason_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductStatusReason_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductStatusReason_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductStatusReason_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProductStatusReason_Audit</returns>
		public virtual IProductStatusReason_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductStatusReason_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.Id == id).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.Stamp == stamp).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.UserName == username).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the DateFrom field
        /// </summary>
        /// <param name="datefrom">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByDateFrom(Nullable<DateTime> datefrom)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.DateFrom == datefrom).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the DateTo field
        /// </summary>
        /// <param name="dateto">Nullable<DateTime></param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByDateTo(Nullable<DateTime> dateto)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.DateTo == dateto).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.ProductId == productid).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the ReasonId field
        /// </summary>
        /// <param name="reasonid">Nullable<int></param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByReasonId(Nullable<int> reasonid)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.ReasonId == reasonid).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusReason_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IProductStatusReason_Audit>();
		}
		
        /// <summary>
        /// Load all ProductStatusReason_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductStatusReason_Audit>().ToList<IProductStatusReason_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductStatusReason_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatusReason_Audit></returns>
		public virtual IList<IProductStatusReason_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProductStatusReason_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductStatusReason_Audit>(o => o.UserName.Contains(username)).ToList<IProductStatusReason_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusReason_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusReason_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductStatusReason_Audit entity)
		{
			var entityToSave = new ProductStatusReason_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductStatusReason_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusReason_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductStatusReason_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductStatusReason_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductStatusReason_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.DateFrom != entity.DateFrom) { entityToUpdate.DateFrom = entity.DateFrom;doUpdate = true; }
			if (entityToUpdate.DateTo != entity.DateTo) { entityToUpdate.DateTo = entity.DateTo;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.ReasonId != entity.ReasonId) { entityToUpdate.ReasonId = entity.ReasonId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductStatusReason_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusReason_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductStatusReason_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusReason_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusReason_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductStatusReason_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusReason_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusReason_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
