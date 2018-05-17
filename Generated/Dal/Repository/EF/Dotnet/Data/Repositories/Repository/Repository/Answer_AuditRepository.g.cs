
// <copyright file="Answer_Audit.g.cs" company="MIT">
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
	/// The Answer_AuditRepository class responsible for database functions in the Answer_Audit table
	/// </summary>
	public partial class Answer_AuditRepository : UowRepository<Answer_Audit> , IAnswer_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Answer_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Answer_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Answer_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IAnswer_Audit</returns>
		public virtual IAnswer_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Answer_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.Id == id).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.Stamp == stamp).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.UserName == username).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the QuestionId field
        /// </summary>
        /// <param name="questionid">Nullable<int></param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByQuestionId(Nullable<int> questionid)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.QuestionId == questionid).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the ResultId field
        /// </summary>
        /// <param name="resultid">Nullable<int></param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByResultId(Nullable<int> resultid)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.ResultId == resultid).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the AnswerProfileId field
        /// </summary>
        /// <param name="answerprofileid">Nullable<int></param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByAnswerProfileId(Nullable<int> answerprofileid)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.AnswerProfileId == answerprofileid).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the PreviousResultId field
        /// </summary>
        /// <param name="previousresultid">Nullable<int></param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByPreviousResultId(Nullable<int> previousresultid)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.PreviousResultId == previousresultid).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load Answer_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IAnswer_Audit>();
		}
		
        /// <summary>
        /// Load all Answer_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Answer_Audit>().ToList<IAnswer_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Answer_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAnswer_Audit></returns>
		public virtual IList<IAnswer_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAnswer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Answer_Audit>(o => o.UserName.Contains(username)).ToList<IAnswer_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Answer_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAnswer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAnswer_Audit entity)
		{
			var entityToSave = new Answer_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Answer_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAnswer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAnswer_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Answer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Answer_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.QuestionId != entity.QuestionId) { entityToUpdate.QuestionId = entity.QuestionId;doUpdate = true; }
			if (entityToUpdate.ResultId != entity.ResultId) { entityToUpdate.ResultId = entity.ResultId;doUpdate = true; }
			if (entityToUpdate.AnswerProfileId != entity.AnswerProfileId) { entityToUpdate.AnswerProfileId = entity.AnswerProfileId;doUpdate = true; }
			if (entityToUpdate.PreviousResultId != entity.PreviousResultId) { entityToUpdate.PreviousResultId = entity.PreviousResultId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Answer_Audit entity from the database
        /// </summary>
        /// <param name="entity">IAnswer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAnswer_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Answer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Answer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Answer_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Answer_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Answer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
