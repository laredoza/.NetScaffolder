
// <copyright file="AnswerOutcomeResult.g.cs" company="MIT">
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
	/// The AnswerOutcomeResultRepository class responsible for database functions in the AnswerOutcomeResult table
	/// </summary>
	public partial class AnswerOutcomeResultRepository : UowRepository<AnswerOutcomeResult> , IAnswerOutcomeResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerOutcomeResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerOutcomeResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerOutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerOutcomeResult</returns>
		public virtual IAnswerOutcomeResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerOutcomeResult>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AnswerOutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.Stamp == stamp).ToList<IAnswerOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerOutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.UserName == username).ToList<IAnswerOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerOutcomeResult entities from the database using the AnswerId field
        /// </summary>
        /// <param name="answerid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> LoadByAnswerId(Nullable<int> answerid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.AnswerId == answerid).ToList<IAnswerOutcomeResult>();
		}
		
        /// <summary>
        /// Load AnswerOutcomeResult entities from the database using the OutcomeResultId field
        /// </summary>
        /// <param name="outcomeresultid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> LoadByOutcomeResultId(Nullable<int> outcomeresultid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.OutcomeResultId == outcomeresultid).ToList<IAnswerOutcomeResult>();
		}
		
        /// <summary>
        /// Load all AnswerOutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerOutcomeResult>().ToList<IAnswerOutcomeResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerOutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerOutcomeResult></returns>
		public virtual IList<IAnswerOutcomeResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswerOutcomeResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerOutcomeResult>(o => o.UserName.Contains(username)).ToList<IAnswerOutcomeResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerOutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerOutcomeResult entity)
		{
			var entityToSave = new AnswerOutcomeResult(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerOutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerOutcomeResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerOutcomeResult>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerOutcomeResult entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.AnswerId != entity.AnswerId) { entityToUpdate.AnswerId = entity.AnswerId;doUpdate = true; }
			if (entityToUpdate.OutcomeResultId != entity.OutcomeResultId) { entityToUpdate.OutcomeResultId = entity.OutcomeResultId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerOutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IAnswerOutcomeResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerOutcomeResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcomeResult>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerOutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcomeResult>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcomeResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
