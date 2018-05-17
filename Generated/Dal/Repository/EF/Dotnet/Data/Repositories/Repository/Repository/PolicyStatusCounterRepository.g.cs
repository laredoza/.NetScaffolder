
// <copyright file="PolicyStatusCounter.g.cs" company="MIT">
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
	/// The PolicyStatusCounterRepository class responsible for database functions in the PolicyStatusCounter table
	/// </summary>
	public partial class PolicyStatusCounterRepository : UowRepository<PolicyStatusCounter> , IPolicyStatusCounterRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PolicyStatusCounterRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PolicyStatusCounterRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PolicyStatusCounter entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPolicyStatusCounter</returns>
		public virtual IPolicyStatusCounter LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PolicyStatusCounter>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PolicyStatusCounter entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.Stamp == stamp).ToList<IPolicyStatusCounter>();
		}
		
        /// <summary>
        /// Load PolicyStatusCounter entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.UserName == username).ToList<IPolicyStatusCounter>();
		}
		
        /// <summary>
        /// Load PolicyStatusCounter entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.Status == status).ToList<IPolicyStatusCounter>();
		}
		
        /// <summary>
        /// Load PolicyStatusCounter entities from the database using the Counter field
        /// </summary>
        /// <param name="counter">Nullable<int></param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadByCounter(Nullable<int> counter)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.Counter == counter).ToList<IPolicyStatusCounter>();
		}
		
        /// <summary>
        /// Load PolicyStatusCounter entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.PolicyId == policyid).ToList<IPolicyStatusCounter>();
		}
		
        /// <summary>
        /// Load all PolicyStatusCounter entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> LoadAll()
		{
			return this.UnitOfWork.GetAll<PolicyStatusCounter>().ToList<IPolicyStatusCounter>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PolicyStatusCounter entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicyStatusCounter></returns>
		public virtual IList<IPolicyStatusCounter> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPolicyStatusCounter>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PolicyStatusCounter>(o => o.UserName.Contains(username)).ToList<IPolicyStatusCounter>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyStatusCounter entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyStatusCounter</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicyStatusCounter entity)
		{
			var entityToSave = new PolicyStatusCounter(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PolicyStatusCounter entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyStatusCounter</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicyStatusCounter entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PolicyStatusCounter>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PolicyStatusCounter entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.Counter != entity.Counter) { entityToUpdate.Counter = entity.Counter;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PolicyStatusCounter entity from the database
        /// </summary>
        /// <param name="entity">IPolicyStatusCounter</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicyStatusCounter entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatusCounter>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatusCounter entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PolicyStatusCounter entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyStatusCounter>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyStatusCounter entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
