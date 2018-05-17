
// <copyright file="PluginOneLifePolicy.g.cs" company="MIT">
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
	/// The PluginOneLifePolicyRepository class responsible for database functions in the PluginOneLifePolicy table
	/// </summary>
	public partial class PluginOneLifePolicyRepository : UowRepository<PluginOneLifePolicy> , IPluginOneLifePolicyRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifePolicyRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifePolicyRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifePolicy entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifePolicy</returns>
		public virtual IPluginOneLifePolicy LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifePolicy>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Stamp == stamp).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.UserName == username).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">int</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByPluginOneLifeCedantId(int pluginonelifecedantid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.PluginOneLifeCedantId == pluginonelifecedantid).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">int</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByPolicyId(int policyid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.PolicyId == policyid).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Name == name).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the Surname field
        /// </summary>
        /// <param name="surname">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadBySurname(string surname)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Surname == surname).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load PluginOneLifePolicy entities from the database using the ExternalReference field
        /// </summary>
        /// <param name="externalreference">string</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadByExternalReference(string externalreference)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.ExternalReference == externalreference).ToList<IPluginOneLifePolicy>();
		}
		
        /// <summary>
        /// Load all PluginOneLifePolicy entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifePolicy>().ToList<IPluginOneLifePolicy>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifePolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.UserName.Contains(username)).ToList<IPluginOneLifePolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IPluginOneLifePolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Name.Contains(name)).ToList<IPluginOneLifePolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by Surname
        /// </summary>
        /// <param name="surname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> SearchBySurname(string surname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Surname.ToLower().Contains(surname.ToLower())).ToList<IPluginOneLifePolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.Surname.Contains(surname)).ToList<IPluginOneLifePolicy>();
			}
		}
		
        /// <summary>
        /// Search for PluginOneLifePolicy entities in the database by ExternalReference
        /// </summary>
        /// <param name="externalreference">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifePolicy></returns>
		public virtual IList<IPluginOneLifePolicy> SearchByExternalReference(string externalreference, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.ExternalReference.ToLower().Contains(externalreference.ToLower())).ToList<IPluginOneLifePolicy>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifePolicy>(o => o.ExternalReference.Contains(externalreference)).ToList<IPluginOneLifePolicy>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifePolicy entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifePolicy entity)
		{
			var entityToSave = new PluginOneLifePolicy(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifePolicy entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifePolicy entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifePolicy>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifePolicy entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeCedantId != entity.PluginOneLifeCedantId) { entityToUpdate.PluginOneLifeCedantId = entity.PluginOneLifeCedantId;doUpdate = true; }
			if (entityToUpdate.PolicyId != entity.PolicyId) { entityToUpdate.PolicyId = entity.PolicyId;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Surname != entity.Surname) { entityToUpdate.Surname = entity.Surname;doUpdate = true; }
			if (entityToUpdate.ExternalReference != entity.ExternalReference) { entityToUpdate.ExternalReference = entity.ExternalReference;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifePolicy entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifePolicy</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifePolicy entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifePolicy>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifePolicy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifePolicy entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifePolicy>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifePolicy entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
