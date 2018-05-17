﻿
// <copyright file="AnswerOutcome.g.cs" company="MIT">
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
	/// The AnswerOutcomeRepository class responsible for database functions in the AnswerOutcome table
	/// </summary>
	public partial class AnswerOutcomeRepository : UowRepository<AnswerOutcome> , IAnswerOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerOutcome</returns>
		public virtual IAnswerOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AnswerOutcome entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.Stamp == stamp).ToList<IAnswerOutcome>();
		}
		
        /// <summary>
        /// Load AnswerOutcome entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.UserName == username).ToList<IAnswerOutcome>();
		}
		
        /// <summary>
        /// Load AnswerOutcome entities from the database using the AnswerProfileId field
        /// </summary>
        /// <param name="answerprofileid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> LoadByAnswerProfileId(Nullable<int> answerprofileid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.AnswerProfileId == answerprofileid).ToList<IAnswerOutcome>();
		}
		
        /// <summary>
        /// Load AnswerOutcome entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.ProviderId == providerid).ToList<IAnswerOutcome>();
		}
		
        /// <summary>
        /// Load all AnswerOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerOutcome>().ToList<IAnswerOutcome>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerOutcome entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerOutcome></returns>
		public virtual IList<IAnswerOutcome> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswerOutcome>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerOutcome>(o => o.UserName.Contains(username)).ToList<IAnswerOutcome>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerOutcome entity)
		{
			var entityToSave = new AnswerOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.AnswerProfileId != entity.AnswerProfileId) { entityToUpdate.AnswerProfileId = entity.AnswerProfileId;doUpdate = true; }
			if (entityToUpdate.ProviderId != entity.ProviderId) { entityToUpdate.ProviderId = entity.ProviderId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerOutcome entity from the database
        /// </summary>
        /// <param name="entity">IAnswerOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
