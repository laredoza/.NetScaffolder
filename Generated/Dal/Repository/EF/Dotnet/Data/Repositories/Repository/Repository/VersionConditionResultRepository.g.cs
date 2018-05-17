
// <copyright file="VersionConditionResult.g.cs" company="MIT">
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
	/// The VersionConditionResultRepository class responsible for database functions in the VersionConditionResult table
	/// </summary>
	public partial class VersionConditionResultRepository : UowRepository<VersionConditionResult> , IVersionConditionResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionConditionResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionConditionResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionConditionResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionConditionResult</returns>
		public virtual IVersionConditionResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionConditionResult>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VersionConditionResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.Stamp == stamp).ToList<IVersionConditionResult>();
		}
		
        /// <summary>
        /// Load VersionConditionResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.UserName == username).ToList<IVersionConditionResult>();
		}
		
        /// <summary>
        /// Load VersionConditionResult entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.QuestionnaireId == questionnaireid).ToList<IVersionConditionResult>();
		}
		
        /// <summary>
        /// Load VersionConditionResult entities from the database using the VersionConditionId field
        /// </summary>
        /// <param name="versionconditionid">Nullable<int></param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadByVersionConditionId(Nullable<int> versionconditionid)
		{
			return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.VersionConditionId == versionconditionid).ToList<IVersionConditionResult>();
		}
		
        /// <summary>
        /// Load VersionConditionResult entities from the database using the ConditionResultId field
        /// </summary>
        /// <param name="conditionresultid">Nullable<int></param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadByConditionResultId(Nullable<int> conditionresultid)
		{
			return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.ConditionResultId == conditionresultid).ToList<IVersionConditionResult>();
		}
		
        /// <summary>
        /// Load all VersionConditionResult entities from the database.
        /// </summary>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionConditionResult>().ToList<IVersionConditionResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for VersionConditionResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionConditionResult></returns>
		public virtual IList<IVersionConditionResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IVersionConditionResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionConditionResult>(o => o.UserName.Contains(username)).ToList<IVersionConditionResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionConditionResult entity to the database.
        /// </summary>
        /// <param name="entity">IVersionConditionResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionConditionResult entity)
		{
			var entityToSave = new VersionConditionResult(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionConditionResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionConditionResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionConditionResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionConditionResult>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionConditionResult entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.VersionConditionId != entity.VersionConditionId) { entityToUpdate.VersionConditionId = entity.VersionConditionId;doUpdate = true; }
			if (entityToUpdate.ConditionResultId != entity.ConditionResultId) { entityToUpdate.ConditionResultId = entity.ConditionResultId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionConditionResult entity from the database
        /// </summary>
        /// <param name="entity">IVersionConditionResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionConditionResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionConditionResult>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionConditionResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionConditionResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionConditionResult>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionConditionResult entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
