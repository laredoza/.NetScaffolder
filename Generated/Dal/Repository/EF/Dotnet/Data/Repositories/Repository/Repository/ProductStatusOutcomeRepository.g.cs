
// <copyright file="ProductStatusOutcome.g.cs" company="MIT">
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
	/// The ProductStatusOutcomeRepository class responsible for database functions in the ProductStatusOutcome table
	/// </summary>
	public partial class ProductStatusOutcomeRepository : UowRepository<ProductStatusOutcome> , IProductStatusOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductStatusOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductStatusOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductStatusOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductStatusOutcome</returns>
		public virtual IProductStatusOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductStatusOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ProductStatusOutcome entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductStatusOutcome></returns>
		public virtual IList<IProductStatusOutcome> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<ProductStatusOutcome>(o => o.Status == status).ToList<IProductStatusOutcome>();
		}
		
        /// <summary>
        /// Load ProductStatusOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<IProductStatusOutcome></returns>
		public virtual IList<IProductStatusOutcome> LoadByProductProfileId(Nullable<int> productprofileid)
		{
			return this.UnitOfWork.AllMatching<ProductStatusOutcome>(o => o.ProductProfileId == productprofileid).ToList<IProductStatusOutcome>();
		}
		
        /// <summary>
        /// Load all ProductStatusOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IProductStatusOutcome></returns>
		public virtual IList<IProductStatusOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductStatusOutcome>().ToList<IProductStatusOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductStatusOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IProductStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductStatusOutcome entity)
		{
			var entityToSave = new ProductStatusOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductStatusOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductStatusOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductStatusOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductStatusOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.ProductProfileId != entity.ProductProfileId) { entityToUpdate.ProductProfileId = entity.ProductProfileId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductStatusOutcome entity from the database
        /// </summary>
        /// <param name="entity">IProductStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductStatusOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductStatusOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductStatusOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
