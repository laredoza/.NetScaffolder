
// <copyright file="ProductReference_Audit.g.cs" company="MIT">
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
	/// The ProductReference_AuditRepository class responsible for database functions in the ProductReference_Audit table
	/// </summary>
	public partial class ProductReference_AuditRepository : UowRepository<ProductReference_Audit> , IProductReference_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductReference_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductReference_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductReference_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProductReference_Audit</returns>
		public virtual IProductReference_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductReference_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.Id == id).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.Stamp == stamp).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.UserName == username).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.SetupTableDataId == setuptabledataid).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadByProductId(Nullable<int> productid)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.ProductId == productid).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load ProductReference_Audit entities from the database using the Source field
        /// </summary>
        /// <param name="source">bool</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadBySource(bool source)
		{
			return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.Source == source).ToList<IProductReference_Audit>();
		}
		
        /// <summary>
        /// Load all ProductReference_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductReference_Audit>().ToList<IProductReference_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductReference_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductReference_Audit></returns>
		public virtual IList<IProductReference_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProductReference_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductReference_Audit>(o => o.UserName.Contains(username)).ToList<IProductReference_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductReference_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProductReference_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductReference_Audit entity)
		{
			var entityToSave = new ProductReference_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductReference_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductReference_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductReference_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductReference_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductReference_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.ProductId != entity.ProductId) { entityToUpdate.ProductId = entity.ProductId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.Source != entity.Source) { entityToUpdate.Source = entity.Source;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductReference_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProductReference_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductReference_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductReference_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductReference_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductReference_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductReference_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductReference_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
