
// <copyright file="VersionOutcomeResult.g.cs" company="MIT">
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
	/// The VersionOutcomeResultRepository class responsible for database functions in the VersionOutcomeResult table
	/// </summary>
	public partial class VersionOutcomeResultRepository : UowRepository<VersionOutcomeResult> , IVersionOutcomeResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionOutcomeResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionOutcomeResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionOutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionOutcomeResult</returns>
		public virtual IVersionOutcomeResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionOutcomeResult>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VersionOutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.Stamp == stamp).ToList<IVersionOutcomeResult>();
		}
		
        /// <summary>
        /// Load VersionOutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.UserName == username).ToList<IVersionOutcomeResult>();
		}
		
        /// <summary>
        /// Load VersionOutcomeResult entities from the database using the ConditionResultId field
        /// </summary>
        /// <param name="conditionresultid">Nullable<int></param>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> LoadByConditionResultId(Nullable<int> conditionresultid)
		{
			return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.ConditionResultId == conditionresultid).ToList<IVersionOutcomeResult>();
		}
		
        /// <summary>
        /// Load VersionOutcomeResult entities from the database using the OutcomeResultId field
        /// </summary>
        /// <param name="outcomeresultid">Nullable<int></param>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> LoadByOutcomeResultId(Nullable<int> outcomeresultid)
		{
			return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.OutcomeResultId == outcomeresultid).ToList<IVersionOutcomeResult>();
		}
		
        /// <summary>
        /// Load all VersionOutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionOutcomeResult>().ToList<IVersionOutcomeResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for VersionOutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionOutcomeResult></returns>
		public virtual IList<IVersionOutcomeResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IVersionOutcomeResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionOutcomeResult>(o => o.UserName.Contains(username)).ToList<IVersionOutcomeResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionOutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IVersionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionOutcomeResult entity)
		{
			var entityToSave = new VersionOutcomeResult(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionOutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionOutcomeResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionOutcomeResult>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionOutcomeResult entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.ConditionResultId != entity.ConditionResultId) { entityToUpdate.ConditionResultId = entity.ConditionResultId;doUpdate = true; }
			if (entityToUpdate.OutcomeResultId != entity.OutcomeResultId) { entityToUpdate.OutcomeResultId = entity.OutcomeResultId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionOutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IVersionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionOutcomeResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionOutcomeResult>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionOutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionOutcomeResult>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
