
// <copyright file="QuestionProfile_History.g.cs" company="MIT">
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
	/// The QuestionProfile_HistoryRepository class responsible for database functions in the QuestionProfile_History table
	/// </summary>
	public partial class QuestionProfile_HistoryRepository : UowRepository<QuestionProfile_History> , IQuestionProfile_HistoryRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionProfile_HistoryRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionProfile_HistoryRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionProfile_History entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionProfile_History</returns>
		public virtual IQuestionProfile_History LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionProfile_History>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QuestionProfile_History entities from the database using the OriginalQuestionProfileId field
        /// </summary>
        /// <param name="originalquestionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadByOriginalQuestionProfileId(Nullable<int> originalquestionprofileid)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.OriginalQuestionProfileId == originalquestionprofileid).ToList<IQuestionProfile_History>();
		}
		
        /// <summary>
        /// Load QuestionProfile_History entities from the database using the NewQuestionProfileId field
        /// </summary>
        /// <param name="newquestionprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadByNewQuestionProfileId(Nullable<int> newquestionprofileid)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.NewQuestionProfileId == newquestionprofileid).ToList<IQuestionProfile_History>();
		}
		
        /// <summary>
        /// Load QuestionProfile_History entities from the database using the NewQuestionnaireProfileId field
        /// </summary>
        /// <param name="newquestionnaireprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadByNewQuestionnaireProfileId(Nullable<int> newquestionnaireprofileid)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.NewQuestionnaireProfileId == newquestionnaireprofileid).ToList<IQuestionProfile_History>();
		}
		
        /// <summary>
        /// Load QuestionProfile_History entities from the database using the TimeStamp field
        /// </summary>
        /// <param name="timestamp">DateTime</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadByTimeStamp(DateTime timestamp)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.TimeStamp == timestamp).ToList<IQuestionProfile_History>();
		}
		
        /// <summary>
        /// Load QuestionProfile_History entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.UserName == username).ToList<IQuestionProfile_History>();
		}
		
        /// <summary>
        /// Load all QuestionProfile_History entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionProfile_History>().ToList<IQuestionProfile_History>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionProfile_History entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionProfile_History></returns>
		public virtual IList<IQuestionProfile_History> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionProfile_History>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionProfile_History>(o => o.UserName.Contains(username)).ToList<IQuestionProfile_History>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionProfile_History entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionProfile_History entity)
		{
			var entityToSave = new QuestionProfile_History(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionProfile_History entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionProfile_History entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionProfile_History>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionProfile_History entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.OriginalQuestionProfileId != entity.OriginalQuestionProfileId) { entityToUpdate.OriginalQuestionProfileId = entity.OriginalQuestionProfileId;doUpdate = true; }
			if (entityToUpdate.NewQuestionProfileId != entity.NewQuestionProfileId) { entityToUpdate.NewQuestionProfileId = entity.NewQuestionProfileId;doUpdate = true; }
			if (entityToUpdate.NewQuestionnaireProfileId != entity.NewQuestionnaireProfileId) { entityToUpdate.NewQuestionnaireProfileId = entity.NewQuestionnaireProfileId;doUpdate = true; }
			if (entityToUpdate.TimeStamp != entity.TimeStamp) { entityToUpdate.TimeStamp = entity.TimeStamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionProfile_History entity from the database
        /// </summary>
        /// <param name="entity">IQuestionProfile_History</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionProfile_History entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionProfile_History>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionProfile_History entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionProfile_History entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionProfile_History>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionProfile_History entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
