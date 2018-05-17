
// <copyright file="ProductStatusCounter_Audit.g.cs" company="MIT">
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
	/// The ProductStatusCounter_AuditRepository class responsible for database functions in the ProductStatusCounter_Audit table
	/// </summary>
	public partial class ProductStatusCounter_AuditRepository : UowRepository<ProductStatusCounter_Audit> , IProductStatusCounter_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductStatusCounter_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductStatusCounter_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductStatusCounter_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProductStatusCounter_Audit</returns>
		public virtual IProductStatusCounter_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductStatusCounter_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.Id == id).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.Stamp == stamp).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.UserName == username).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.Status == status).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the Counter field
        /// </summary>
        /// <param name="counter">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByCounter(Nullable<int> counter)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.Counter == counter).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.ProductId == productid).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load ProductStatusCounter_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IProductStatusCounter_Audit>();
		}
		
        /// <summary>
        /// Load all ProductStatusCounter_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductStatusCounter_Audit>().ToList<IProductStatusCounter_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductStatusCounter_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatusCounter_Audit></returns>
		public virtual IList<IProductStatusCounter_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProductStatusCounter_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductStatusCounter_Audit>(o => o.UserName.Contains(username)).ToList<IProductStatusCounter_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusCounter_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductStatusCounter_Audit entity)
		{
			var entityToSave = new ProductStatusCounter_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductStatusCounter_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductStatusCounter_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductStatusCounter_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductStatusCounter_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Counter != entity.Counter) { entityToUpdate.Counter = entity.Counter;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductStatusCounter_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusCounter_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductStatusCounter_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusCounter_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusCounter_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductStatusCounter_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusCounter_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusCounter_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
