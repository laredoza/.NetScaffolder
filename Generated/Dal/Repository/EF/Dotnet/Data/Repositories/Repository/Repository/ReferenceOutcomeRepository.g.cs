
// <copyright file="ReferenceOutcome.g.cs" company="MIT">
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
	/// The ReferenceOutcomeRepository class responsible for database functions in the ReferenceOutcome table
	/// </summary>
	public partial class ReferenceOutcomeRepository : UowRepository<ReferenceOutcome> , IReferenceOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ReferenceOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ReferenceOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ReferenceOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IReferenceOutcome</returns>
		public virtual IReferenceOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ReferenceOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ReferenceOutcome entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IReferenceOutcome></returns>
		public virtual IList<IReferenceOutcome> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<ReferenceOutcome>(o => o.SetupTableDataId == setuptabledataid).ToList<IReferenceOutcome>();
		}
		
        /// <summary>
        /// Load all ReferenceOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IReferenceOutcome></returns>
		public virtual IList<IReferenceOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ReferenceOutcome>().ToList<IReferenceOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ReferenceOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IReferenceOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IReferenceOutcome entity)
		{
			var entityToSave = new ReferenceOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ReferenceOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IReferenceOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IReferenceOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ReferenceOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ReferenceOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ReferenceOutcome entity from the database
        /// </summary>
        /// <param name="entity">IReferenceOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IReferenceOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ReferenceOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ReferenceOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ReferenceOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ReferenceOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ReferenceOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
