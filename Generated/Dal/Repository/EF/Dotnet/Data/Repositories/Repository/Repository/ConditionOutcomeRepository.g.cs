
// <copyright file="ConditionOutcome.g.cs" company="MIT">
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
	/// The ConditionOutcomeRepository class responsible for database functions in the ConditionOutcome table
	/// </summary>
	public partial class ConditionOutcomeRepository : UowRepository<ConditionOutcome> , IConditionOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ConditionOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ConditionOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ConditionOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IConditionOutcome</returns>
		public virtual IConditionOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ConditionOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ConditionOutcome entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.Stamp == stamp).ToList<IConditionOutcome>();
		}
		
        /// <summary>
        /// Load ConditionOutcome entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.UserName == username).ToList<IConditionOutcome>();
		}
		
        /// <summary>
        /// Load ConditionOutcome entities from the database using the AnswerConditionId field
        /// </summary>
        /// <param name="answerconditionid">Nullable<int></param>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> LoadByAnswerConditionId(Nullable<int> answerconditionid)
		{
			return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.AnswerConditionId == answerconditionid).ToList<IConditionOutcome>();
		}
		
        /// <summary>
        /// Load ConditionOutcome entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.ProviderId == providerid).ToList<IConditionOutcome>();
		}
		
        /// <summary>
        /// Load all ConditionOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ConditionOutcome>().ToList<IConditionOutcome>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ConditionOutcome entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionOutcome></returns>
		public virtual IList<IConditionOutcome> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IConditionOutcome>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionOutcome>(o => o.UserName.Contains(username)).ToList<IConditionOutcome>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ConditionOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IConditionOutcome entity)
		{
			var entityToSave = new ConditionOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ConditionOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IConditionOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ConditionOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ConditionOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.AnswerConditionId != entity.AnswerConditionId) { entityToUpdate.AnswerConditionId = entity.AnswerConditionId;doUpdate = true; }
			if (entityToUpdate.ProviderId != entity.ProviderId) { entityToUpdate.ProviderId = entity.ProviderId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ConditionOutcome entity from the database
        /// </summary>
        /// <param name="entity">IConditionOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IConditionOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ConditionOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
