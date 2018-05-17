
// <copyright file="PolicyStatus.g.cs" company="MIT">
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
	/// The PolicyStatusRepository class responsible for database functions in the PolicyStatus table
	/// </summary>
	public partial class PolicyStatusRepository : UowRepository<PolicyStatus> , IPolicyStatusRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PolicyStatusRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PolicyStatusRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PolicyStatus entity from the database using the PolicyStatusID primary key
        /// </summary>
        /// <param name="policystatusid">int</param>
        /// <returns>IPolicyStatus</returns>
		public virtual IPolicyStatus LoadByPolicyStatusID(int policystatusid)
		{
			return this.UnitOfWork.FirstOrDefault<PolicyStatus>(o => o.PolicyStatusID == policystatusid);
		}
		
        /// <summary>
        /// Load PolicyStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IPolicyStatus></returns>
		public virtual IList<IPolicyStatus> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<PolicyStatus>(o => o.Description == description).ToList<IPolicyStatus>();
		}
		
        /// <summary>
        /// Load all PolicyStatus entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyStatus></returns>
		public virtual IList<IPolicyStatus> LoadAll()
		{
			return this.UnitOfWork.GetAll<PolicyStatus>().ToList<IPolicyStatus>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PolicyStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicyStatus></returns>
		public virtual IList<IPolicyStatus> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PolicyStatus>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IPolicyStatus>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PolicyStatus>(o => o.Description.Contains(description)).ToList<IPolicyStatus>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyStatus entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyStatus</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicyStatus entity)
		{
			var entityToSave = new PolicyStatus(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PolicyStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyStatus</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicyStatus entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PolicyStatus>(o => o.PolicyStatusID == entity.PolicyStatusID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PolicyStatus entity does not exist");
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
        /// Delete the PolicyStatus entity from the database
        /// </summary>
        /// <param name="entity">IPolicyStatus</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicyStatus entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatus>(o => o.PolicyStatusID == entity.PolicyStatusID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PolicyStatus entity from the database using the PolicyStatusID
        /// </summary>
        /// <param name="policystatusid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByPolicyStatusID(int policystatusid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatus>(o => o.PolicyStatusID == policystatusid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
