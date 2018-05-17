
// <copyright file="ProductPostponeStatusOutcome.g.cs" company="MIT">
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
	/// The ProductPostponeStatusOutcomeRepository class responsible for database functions in the ProductPostponeStatusOutcome table
	/// </summary>
	public partial class ProductPostponeStatusOutcomeRepository : UowRepository<ProductPostponeStatusOutcome> , IProductPostponeStatusOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductPostponeStatusOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductPostponeStatusOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductPostponeStatusOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductPostponeStatusOutcome</returns>
		public virtual IProductPostponeStatusOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductPostponeStatusOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<ProductPostponeStatusOutcome>(o => o.Status == status).ToList<IProductPostponeStatusOutcome>();
		}
		
        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Months field
        /// </summary>
        /// <param name="months">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadByMonths(Nullable<int> months)
		{
			return this.UnitOfWork.AllMatching<ProductPostponeStatusOutcome>(o => o.Months == months).ToList<IProductPostponeStatusOutcome>();
		}
		
        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadByProductProfileId(Nullable<int> productprofileid)
		{
			return this.UnitOfWork.AllMatching<ProductPostponeStatusOutcome>(o => o.ProductProfileId == productprofileid).ToList<IProductPostponeStatusOutcome>();
		}
		
        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<ProductPostponeStatusOutcome>(o => o.SetupTableDataId == setuptabledataid).ToList<IProductPostponeStatusOutcome>();
		}
		
        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Days field
        /// </summary>
        /// <param name="days">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadByDays(Nullable<int> days)
		{
			return this.UnitOfWork.AllMatching<ProductPostponeStatusOutcome>(o => o.Days == days).ToList<IProductPostponeStatusOutcome>();
		}
		
        /// <summary>
        /// Load all ProductPostponeStatusOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		public virtual IList<IProductPostponeStatusOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductPostponeStatusOutcome>().ToList<IProductPostponeStatusOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductPostponeStatusOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductPostponeStatusOutcome entity)
		{
			var entityToSave = new ProductPostponeStatusOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductPostponeStatusOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductPostponeStatusOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductPostponeStatusOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductPostponeStatusOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Months != entity.Months) { entityToUpdate.Months = entity.Months;doUpdate = true; }
			if (entityToUpdate.ProductProfileId != entity.ProductProfileId) { entityToUpdate.ProductProfileId = entity.ProductProfileId;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.Days != entity.Days) { entityToUpdate.Days = entity.Days;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductPostponeStatusOutcome entity from the database
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductPostponeStatusOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductPostponeStatusOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductPostponeStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductPostponeStatusOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductPostponeStatusOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductPostponeStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
