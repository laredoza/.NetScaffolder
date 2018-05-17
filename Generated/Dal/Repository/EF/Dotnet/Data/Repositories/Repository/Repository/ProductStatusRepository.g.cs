
// <copyright file="ProductStatus.g.cs" company="MIT">
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
	/// The ProductStatusRepository class responsible for database functions in the ProductStatus table
	/// </summary>
	public partial class ProductStatusRepository : UowRepository<ProductStatus> , IProductStatusRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductStatusRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductStatusRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductStatus entity from the database using the ProductStatusID primary key
        /// </summary>
        /// <param name="productstatusid">int</param>
        /// <returns>IProductStatus</returns>
		public virtual IProductStatus LoadByProductStatusID(int productstatusid)
		{
			return this.UnitOfWork.FirstOrDefault<ProductStatus>(o => o.ProductStatusID == productstatusid);
		}
		
        /// <summary>
        /// Load ProductStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IProductStatus></returns>
		public virtual IList<IProductStatus> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<ProductStatus>(o => o.Description == description).ToList<IProductStatus>();
		}
		
        /// <summary>
        /// Load all ProductStatus entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatus></returns>
		public virtual IList<IProductStatus> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductStatus>().ToList<IProductStatus>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductStatus></returns>
		public virtual IList<IProductStatus> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductStatus>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IProductStatus>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductStatus>(o => o.Description.Contains(description)).ToList<IProductStatus>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatus entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductStatus entity)
		{
			var entityToSave = new ProductStatus(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductStatus entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductStatus>(o => o.ProductStatusID == entity.ProductStatusID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductStatus entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductStatus entity from the database
        /// </summary>
        /// <param name="entity">IProductStatus</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductStatus entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatus>(o => o.ProductStatusID == entity.ProductStatusID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductStatus entity from the database using the ProductStatusID
        /// </summary>
        /// <param name="productstatusid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByProductStatusID(int productstatusid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatus>(o => o.ProductStatusID == productstatusid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
