
// <copyright file="AnswerLog.g.cs" company="MIT">
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
	/// The AnswerLogRepository class responsible for database functions in the AnswerLog table
	/// </summary>
	public partial class AnswerLogRepository : UowRepository<AnswerLog> , IAnswerLogRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AnswerLogRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AnswerLogRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AnswerLog entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAnswerLog</returns>
		public virtual IAnswerLog LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AnswerLog>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AnswerLog entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">int</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadByQuestionnaireId(int questionnaireid)
		{
			return this.UnitOfWork.AllMatching<AnswerLog>(o => o.QuestionnaireId == questionnaireid).ToList<IAnswerLog>();
		}
		
        /// <summary>
        /// Load AnswerLog entities from the database using the QuestionId field
        /// </summary>
        /// <param name="questionid">int</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadByQuestionId(int questionid)
		{
			return this.UnitOfWork.AllMatching<AnswerLog>(o => o.QuestionId == questionid).ToList<IAnswerLog>();
		}
		
        /// <summary>
        /// Load AnswerLog entities from the database using the Answer field
        /// </summary>
        /// <param name="answer">string</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadByAnswer(string answer)
		{
			return this.UnitOfWork.AllMatching<AnswerLog>(o => o.Answer == answer).ToList<IAnswerLog>();
		}
		
        /// <summary>
        /// Load AnswerLog entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<AnswerLog>(o => o.Stamp == stamp).ToList<IAnswerLog>();
		}
		
        /// <summary>
        /// Load AnswerLog entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AnswerLog>(o => o.UserName == username).ToList<IAnswerLog>();
		}
		
        /// <summary>
        /// Load all AnswerLog entities from the database.
        /// </summary>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> LoadAll()
		{
			return this.UnitOfWork.GetAll<AnswerLog>().ToList<IAnswerLog>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AnswerLog entities in the database by Answer
        /// </summary>
        /// <param name="answer">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> SearchByAnswer(string answer, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerLog>(o => o.Answer.ToLower().Contains(answer.ToLower())).ToList<IAnswerLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerLog>(o => o.Answer.Contains(answer)).ToList<IAnswerLog>();
			}
		}
		
        /// <summary>
        /// Search for AnswerLog entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswerLog></returns>
		public virtual IList<IAnswerLog> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AnswerLog>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswerLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AnswerLog>(o => o.UserName.Contains(username)).ToList<IAnswerLog>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AnswerLog entity to the database.
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswerLog entity)
		{
			var entityToSave = new AnswerLog(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AnswerLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswerLog entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AnswerLog>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AnswerLog entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }
			if (entityToUpdate.QuestionId != entity.QuestionId) { entityToUpdate.QuestionId = entity.QuestionId;doUpdate = true; }
			if (entityToUpdate.Answer != entity.Answer) { entityToUpdate.Answer = entity.Answer;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AnswerLog entity from the database
        /// </summary>
        /// <param name="entity">IAnswerLog</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswerLog entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerLog>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AnswerLog entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AnswerLog>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AnswerLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
