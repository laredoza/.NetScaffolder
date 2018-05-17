
// <copyright file="QuestionnaireSequence.g.cs" company="MIT">
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
	/// The QuestionnaireSequenceRepository class responsible for database functions in the QuestionnaireSequence table
	/// </summary>
	public partial class QuestionnaireSequenceRepository : UowRepository<QuestionnaireSequence> , IQuestionnaireSequenceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionnaireSequenceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionnaireSequenceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionnaireSequence entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaireSequence</returns>
		public virtual IQuestionnaireSequence LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionnaireSequence>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.Stamp == stamp).ToList<IQuestionnaireSequence>();
		}
		
        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.UserName == username).ToList<IQuestionnaireSequence>();
		}
		
        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadBySeq(Nullable<int> seq)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.Seq == seq).ToList<IQuestionnaireSequence>();
		}
		
        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the ProfileVersionId field
        /// </summary>
        /// <param name="profileversionid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadByProfileVersionId(Nullable<int> profileversionid)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.ProfileVersionId == profileversionid).ToList<IQuestionnaireSequence>();
		}
		
        /// <summary>
        /// Load QuestionnaireSequence entities from the database using the SequenceEntityId field
        /// </summary>
        /// <param name="sequenceentityid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadBySequenceEntityId(Nullable<int> sequenceentityid)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.SequenceEntityId == sequenceentityid).ToList<IQuestionnaireSequence>();
		}
		
        /// <summary>
        /// Load all QuestionnaireSequence entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionnaireSequence>().ToList<IQuestionnaireSequence>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionnaireSequence entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireSequence></returns>
		public virtual IList<IQuestionnaireSequence> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionnaireSequence>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireSequence>(o => o.UserName.Contains(username)).ToList<IQuestionnaireSequence>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireSequence entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaireSequence entity)
		{
			var entityToSave = new QuestionnaireSequence(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionnaireSequence entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaireSequence entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionnaireSequence>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionnaireSequence entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Seq != entity.Seq) { entityToUpdate.Seq = entity.Seq;doUpdate = true; }
			if (entityToUpdate.ProfileVersionId != entity.ProfileVersionId) { entityToUpdate.ProfileVersionId = entity.ProfileVersionId;doUpdate = true; }
			if (entityToUpdate.SequenceEntityId != entity.SequenceEntityId) { entityToUpdate.SequenceEntityId = entity.SequenceEntityId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionnaireSequence entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireSequence</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaireSequence entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireSequence>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireSequence entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionnaireSequence entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireSequence>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireSequence entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
