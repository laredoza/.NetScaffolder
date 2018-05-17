
// <copyright file="Product_Audit.g.cs" company="MIT">
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
	/// The Product_AuditRepository class responsible for database functions in the Product_Audit table
	/// </summary>
	public partial class Product_AuditRepository : UowRepository<Product_Audit> , IProduct_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Product_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Product_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Product_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IProduct_Audit</returns>
		public virtual IProduct_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Product_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.Id == id).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.Stamp == stamp).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.UserName == username).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the SumAssured field
        /// </summary>
        /// <param name="sumassured">Nullable<decimal></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadBySumAssured(Nullable<decimal> sumassured)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.SumAssured == sumassured).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.Status == status).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the ClientIncludedProduct field
        /// </summary>
        /// <param name="clientincludedproduct">Nullable<bool></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByClientIncludedProduct(Nullable<bool> clientincludedproduct)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.ClientIncludedProduct == clientincludedproduct).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.PolicyId == policyid).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByProductProfileId(Nullable<int> productprofileid)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.ProductProfileId == productprofileid).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the ProductStatusReasonId field
        /// </summary>
        /// <param name="productstatusreasonid">Nullable<int></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByProductStatusReasonId(Nullable<int> productstatusreasonid)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.ProductStatusReasonId == productstatusreasonid).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load Product_Audit entities from the database using the UserSumAssured field
        /// </summary>
        /// <param name="usersumassured">Nullable<decimal></param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadByUserSumAssured(Nullable<decimal> usersumassured)
		{
			return this.UnitOfWork.AllMatching<Product_Audit>(o => o.UserSumAssured == usersumassured).ToList<IProduct_Audit>();
		}
		
        /// <summary>
        /// Load all Product_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Product_Audit>().ToList<IProduct_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Product_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProduct_Audit></returns>
		public virtual IList<IProduct_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Product_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProduct_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Product_Audit>(o => o.UserName.Contains(username)).ToList<IProduct_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Product_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProduct_Audit entity)
		{
			var entityToSave = new Product_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Product_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProduct_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Product_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Product_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.SumAssured != entity.SumAssured) { entityToUpdate.SumAssured = entity.SumAssured;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.ClientIncludedProduct != entity.ClientIncludedProduct) { entityToUpdate.ClientIncludedProduct = entity.ClientIncludedProduct;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.ProductProfileId != entity.ProductProfileId) { entityToUpdate.ProductProfileId = entity.ProductProfileId;doUpdate = true; }
			if (entityToUpdate.ProductStatusReasonId != entity.ProductStatusReasonId) { entityToUpdate.ProductStatusReasonId = entity.ProductStatusReasonId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }
			if (entityToUpdate.UserSumAssured != entity.UserSumAssured) { entityToUpdate.UserSumAssured = entity.UserSumAssured;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Product_Audit entity from the database
        /// </summary>
        /// <param name="entity">IProduct_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProduct_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Product_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Product_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Product_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
