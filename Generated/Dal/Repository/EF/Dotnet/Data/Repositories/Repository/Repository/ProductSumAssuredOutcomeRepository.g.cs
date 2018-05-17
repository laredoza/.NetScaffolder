
// <copyright file="ProductSumAssuredOutcome.g.cs" company="MIT">
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
	/// The ProductSumAssuredOutcomeRepository class responsible for database functions in the ProductSumAssuredOutcome table
	/// </summary>
	public partial class ProductSumAssuredOutcomeRepository : UowRepository<ProductSumAssuredOutcome> , IProductSumAssuredOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductSumAssuredOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductSumAssuredOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductSumAssuredOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductSumAssuredOutcome</returns>
		public virtual IProductSumAssuredOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductSumAssuredOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ProductSumAssuredOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">int</param>
        /// <returns>IList<IProductSumAssuredOutcome></returns>
		public virtual IList<IProductSumAssuredOutcome> LoadByProductProfileId(int productprofileid)
		{
			return this.UnitOfWork.AllMatching<ProductSumAssuredOutcome>(o => o.ProductProfileId == productprofileid).ToList<IProductSumAssuredOutcome>();
		}
		
        /// <summary>
        /// Load all ProductSumAssuredOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IProductSumAssuredOutcome></returns>
		public virtual IList<IProductSumAssuredOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductSumAssuredOutcome>().ToList<IProductSumAssuredOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductSumAssuredOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductSumAssuredOutcome entity)
		{
			var entityToSave = new ProductSumAssuredOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductSumAssuredOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductSumAssuredOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductSumAssuredOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductSumAssuredOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProductProfileId != entity.ProductProfileId) { entityToUpdate.ProductProfileId = entity.ProductProfileId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductSumAssuredOutcome entity from the database
        /// </summary>
        /// <param name="entity">IProductSumAssuredOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductSumAssuredOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductSumAssuredOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductSumAssuredOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductSumAssuredOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductSumAssuredOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductSumAssuredOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
