
// <copyright file="PolicyReference.g.cs" company="MIT">
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
	/// The PolicyReferenceRepository class responsible for database functions in the PolicyReference table
	/// </summary>
	public partial class PolicyReferenceRepository : UowRepository<PolicyReference> , IPolicyReferenceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PolicyReferenceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PolicyReferenceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PolicyReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPolicyReference</returns>
		public virtual IPolicyReference LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PolicyReference>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PolicyReference entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PolicyReference>(o => o.Stamp == stamp).ToList<IPolicyReference>();
		}
		
        /// <summary>
        /// Load PolicyReference entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PolicyReference>(o => o.UserName == username).ToList<IPolicyReference>();
		}
		
        /// <summary>
        /// Load PolicyReference entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadBySetupTableDataId(Nullable<int> setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<PolicyReference>(o => o.SetupTableDataId == setuptabledataid).ToList<IPolicyReference>();
		}
		
        /// <summary>
        /// Load PolicyReference entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadByPolicyId(Nullable<int> policyid)
		{
			return this.UnitOfWork.AllMatching<PolicyReference>(o => o.PolicyId == policyid).ToList<IPolicyReference>();
		}
		
        /// <summary>
        /// Load PolicyReference entities from the database using the Source field
        /// </summary>
        /// <param name="source">bool</param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadBySource(bool source)
		{
			return this.UnitOfWork.AllMatching<PolicyReference>(o => o.Source == source).ToList<IPolicyReference>();
		}
		
        /// <summary>
        /// Load all PolicyReference entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> LoadAll()
		{
			return this.UnitOfWork.GetAll<PolicyReference>().ToList<IPolicyReference>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PolicyReference entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicyReference></returns>
		public virtual IList<IPolicyReference> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PolicyReference>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPolicyReference>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PolicyReference>(o => o.UserName.Contains(username)).ToList<IPolicyReference>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyReference entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPolicyReference entity)
		{
			var entityToSave = new PolicyReference(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PolicyReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPolicyReference entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PolicyReference>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PolicyReference entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.Source != entity.Source) { entityToUpdate.Source = entity.Source;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PolicyReference entity from the database
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPolicyReference entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyReference>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PolicyReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PolicyReference>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PolicyReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
