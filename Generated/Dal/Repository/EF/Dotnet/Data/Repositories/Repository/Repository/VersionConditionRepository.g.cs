
// <copyright file="VersionCondition.g.cs" company="MIT">
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
	/// The VersionConditionRepository class responsible for database functions in the VersionCondition table
	/// </summary>
	public partial class VersionConditionRepository : UowRepository<VersionCondition> , IVersionConditionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for VersionConditionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public VersionConditionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the VersionCondition entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionCondition</returns>
		public virtual IVersionCondition LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<VersionCondition>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.Stamp == stamp).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.UserName == username).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.Name == name).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the RunAtEnd field
        /// </summary>
        /// <param name="runatend">Nullable<bool></param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByRunAtEnd(Nullable<bool> runatend)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.RunAtEnd == runatend).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the QuestionnaireVersionId field
        /// </summary>
        /// <param name="questionnaireversionid">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByQuestionnaireVersionId(Nullable<int> questionnaireversionid)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.QuestionnaireVersionId == questionnaireversionid).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the ConditionSetContainerId field
        /// </summary>
        /// <param name="conditionsetcontainerid">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadByConditionSetContainerId(Nullable<int> conditionsetcontainerid)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.ConditionSetContainerId == conditionsetcontainerid).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load VersionCondition entities from the database using the SequenceNumber field
        /// </summary>
        /// <param name="sequencenumber">Nullable<int></param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadBySequenceNumber(Nullable<int> sequencenumber)
		{
			return this.UnitOfWork.AllMatching<VersionCondition>(o => o.SequenceNumber == sequencenumber).ToList<IVersionCondition>();
		}
		
        /// <summary>
        /// Load all VersionCondition entities from the database.
        /// </summary>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> LoadAll()
		{
			return this.UnitOfWork.GetAll<VersionCondition>().ToList<IVersionCondition>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for VersionCondition entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionCondition>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IVersionCondition>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionCondition>(o => o.UserName.Contains(username)).ToList<IVersionCondition>();
			}
		}
		
        /// <summary>
        /// Search for VersionCondition entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IVersionCondition></returns>
		public virtual IList<IVersionCondition> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<VersionCondition>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IVersionCondition>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<VersionCondition>(o => o.Name.Contains(name)).ToList<IVersionCondition>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionCondition entity to the database.
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		public virtual bool Save(IVersionCondition entity)
		{
			var entityToSave = new VersionCondition(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the VersionCondition entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		public virtual bool Update(IVersionCondition entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<VersionCondition>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The VersionCondition entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.RunAtEnd != entity.RunAtEnd) { entityToUpdate.RunAtEnd = entity.RunAtEnd;doUpdate = true; }
			if (entityToUpdate.QuestionnaireVersionId != entity.QuestionnaireVersionId) { entityToUpdate.QuestionnaireVersionId = entity.QuestionnaireVersionId;doUpdate = true; }
			if (entityToUpdate.ConditionSetContainerId != entity.ConditionSetContainerId) { entityToUpdate.ConditionSetContainerId = entity.ConditionSetContainerId;doUpdate = true; }
			if (entityToUpdate.SequenceNumber != entity.SequenceNumber) { entityToUpdate.SequenceNumber = entity.SequenceNumber;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the VersionCondition entity from the database
        /// </summary>
        /// <param name="entity">IVersionCondition</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IVersionCondition entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionCondition>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionCondition entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the VersionCondition entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<VersionCondition>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The VersionCondition entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
