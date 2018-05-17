
// <copyright file="VersionOutcome.g.cs" company="MIT">
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
	/// The VersionOutcomeRepository class responsible for database functions in the VersionOutcome table
	/// </summary>
	public partial class VersionOutcomeRepository : UowRepository<VersionOutcome> , IVersionOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionOutcome</returns>
		public virtual IVersionOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VersionOutcome entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.Stamp == stamp).ToList<IVersionOutcome>();
		}
		
        /// <summary>
        /// Load VersionOutcome entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.UserName == username).ToList<IVersionOutcome>();
		}
		
        /// <summary>
        /// Load VersionOutcome entities from the database using the VersionConditionId field
        /// </summary>
        /// <param name="versionconditionid">Nullable<int></param>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> LoadByVersionConditionId(Nullable<int> versionconditionid)
		{
			return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.VersionConditionId == versionconditionid).ToList<IVersionOutcome>();
		}
		
        /// <summary>
        /// Load VersionOutcome entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.ProviderId == providerid).ToList<IVersionOutcome>();
		}
		
        /// <summary>
        /// Load all VersionOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionOutcome>().ToList<IVersionOutcome>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for VersionOutcome entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionOutcome></returns>
		public virtual IList<IVersionOutcome> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IVersionOutcome>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionOutcome>(o => o.UserName.Contains(username)).ToList<IVersionOutcome>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IVersionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionOutcome entity)
		{
			var entityToSave = new VersionOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.VersionConditionId != entity.VersionConditionId) { entityToUpdate.VersionConditionId = entity.VersionConditionId;doUpdate = true; }
			if (entityToUpdate.ProviderId != entity.ProviderId) { entityToUpdate.ProviderId = entity.ProviderId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionOutcome entity from the database
        /// </summary>
        /// <param name="entity">IVersionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
