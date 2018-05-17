
// <copyright file="PolicyStatusOutcome.g.cs" company="MIT">
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
	/// The PolicyStatusOutcomeRepository class responsible for database functions in the PolicyStatusOutcome table
	/// </summary>
	public partial class PolicyStatusOutcomeRepository : UowRepository<PolicyStatusOutcome> , IPolicyStatusOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PolicyStatusOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PolicyStatusOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PolicyStatusOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPolicyStatusOutcome</returns>
		public virtual IPolicyStatusOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PolicyStatusOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PolicyStatusOutcome entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IPolicyStatusOutcome></returns>
		public virtual IList<IPolicyStatusOutcome> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusOutcome>(o => o.Status == status).ToList<IPolicyStatusOutcome>();
		}
		
        /// <summary>
        /// Load all PolicyStatusOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyStatusOutcome></returns>
		public virtual IList<IPolicyStatusOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<PolicyStatusOutcome>().ToList<IPolicyStatusOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyStatusOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicyStatusOutcome entity)
		{
			var entityToSave = new PolicyStatusOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PolicyStatusOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicyStatusOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PolicyStatusOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PolicyStatusOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PolicyStatusOutcome entity from the database
        /// </summary>
        /// <param name="entity">IPolicyStatusOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicyStatusOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatusOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PolicyStatusOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatusOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatusOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
