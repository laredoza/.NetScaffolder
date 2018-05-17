
// <copyright file="AnswerConditionOutcomeResult.g.cs" company="MIT">
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
	/// The AnswerConditionOutcomeResultRepository class responsible for database functions in the AnswerConditionOutcomeResult table
	/// </summary>
	public partial class AnswerConditionOutcomeResultRepository : UowRepository<AnswerConditionOutcomeResult> , IAnswerConditionOutcomeResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerConditionOutcomeResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerConditionOutcomeResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerConditionOutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerConditionOutcomeResult</returns>
		public virtual IAnswerConditionOutcomeResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerConditionOutcomeResult>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.Stamp == stamp).ToList<IAnswerConditionOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.UserName == username).ToList<IAnswerConditionOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> LoadByAnswerId(Nullable<int> answerid)
		{
			return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.AnswerId == answerid).ToList<IAnswerConditionOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerConditionOutcomeResult entities from the database using the ConditionResultId field
        /// </summary>
        /// <param name="conditionresultid">Nullable<int></param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> LoadByConditionResultId(Nullable<int> conditionresultid)
		{
			return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.ConditionResultId == conditionresultid).ToList<IAnswerConditionOutcomeResult>();
		}
		
        /// <summary>
        /// Load all AnswerConditionOutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerConditionOutcomeResult>().ToList<IAnswerConditionOutcomeResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerConditionOutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerConditionOutcomeResult></returns>
		public virtual IList<IAnswerConditionOutcomeResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswerConditionOutcomeResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerConditionOutcomeResult>(o => o.UserName.Contains(username)).ToList<IAnswerConditionOutcomeResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerConditionOutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerConditionOutcomeResult entity)
		{
			var entityToSave = new AnswerConditionOutcomeResult(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerConditionOutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerConditionOutcomeResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerConditionOutcomeResult>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerConditionOutcomeResult entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.AnswerId != entity.AnswerId) { entityToUpdate.AnswerId = entity.AnswerId;doUpdate = true; }
			if (entityToUpdate.ConditionResultId != entity.ConditionResultId) { entityToUpdate.ConditionResultId = entity.ConditionResultId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IAnswerConditionOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerConditionOutcomeResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerConditionOutcomeResult>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerConditionOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerConditionOutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerConditionOutcomeResult>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerConditionOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
