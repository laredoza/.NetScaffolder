
// <copyright file="MonitoredProductReference.g.cs" company="MIT">
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
	/// The MonitoredProductReferenceRepository class responsible for database functions in the MonitoredProductReference table
	/// </summary>
	public partial class MonitoredProductReferenceRepository : UowRepository<MonitoredProductReference> , IMonitoredProductReferenceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for MonitoredProductReferenceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public MonitoredProductReferenceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the MonitoredProductReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IMonitoredProductReference</returns>
		public virtual IMonitoredProductReference LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<MonitoredProductReference>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load MonitoredProductReference entities from the database using the State field
        /// </summary>
        /// <param name="state">Nullable<int></param>
        /// <returns>IList<IMonitoredProductReference></returns>
		public virtual IList<IMonitoredProductReference> LoadByState(Nullable<int> state)
		{
			return this.UnitOfWork.AllMatching<MonitoredProductReference>(o => o.State == state).ToList<IMonitoredProductReference>();
		}
		
        /// <summary>
        /// Load all MonitoredProductReference entities from the database.
        /// </summary>
        /// <returns>IList<IMonitoredProductReference></returns>
		public virtual IList<IMonitoredProductReference> LoadAll()
		{
			return this.UnitOfWork.GetAll<MonitoredProductReference>().ToList<IMonitoredProductReference>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the MonitoredProductReference entity to the database.
        /// </summary>
        /// <param name="entity">IMonitoredProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Save(IMonitoredProductReference entity)
		{
			var entityToSave = new MonitoredProductReference(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the MonitoredProductReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IMonitoredProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Update(IMonitoredProductReference entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<MonitoredProductReference>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The MonitoredProductReference entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.State != entity.State) { entityToUpdate.State = entity.State;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the MonitoredProductReference entity from the database
        /// </summary>
        /// <param name="entity">IMonitoredProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IMonitoredProductReference entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MonitoredProductReference>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MonitoredProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the MonitoredProductReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MonitoredProductReference>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MonitoredProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
