
// <copyright file="QuestionnaireProfileVersion.g.cs" company="MIT">
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
	/// The QuestionnaireProfileVersionRepository class responsible for database functions in the QuestionnaireProfileVersion table
	/// </summary>
	public partial class QuestionnaireProfileVersionRepository : UowRepository<QuestionnaireProfileVersion> , IQuestionnaireProfileVersionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionnaireProfileVersionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionnaireProfileVersionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionnaireProfileVersion entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaireProfileVersion</returns>
		public virtual IQuestionnaireProfileVersion LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionnaireProfileVersion>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.Stamp == stamp).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.UserName == username).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the Version field
        /// </summary>
        /// <param name="version">string</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByVersion(string version)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.Version == version).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the GroupApplicantPropertyAnswers field
        /// </summary>
        /// <param name="groupapplicantpropertyanswers">Nullable<bool></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByGroupApplicantPropertyAnswers(Nullable<bool> groupapplicantpropertyanswers)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.GroupApplicantPropertyAnswers == groupapplicantpropertyanswers).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the VersionLocked field
        /// </summary>
        /// <param name="versionlocked">Nullable<bool></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByVersionLocked(Nullable<bool> versionlocked)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.VersionLocked == versionlocked).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfileVersion entities from the database using the QuestionnaireProfileId field
        /// </summary>
        /// <param name="questionnaireprofileid">Nullable<int></param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadByQuestionnaireProfileId(Nullable<int> questionnaireprofileid)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.QuestionnaireProfileId == questionnaireprofileid).ToList<IQuestionnaireProfileVersion>();
		}
		
        /// <summary>
        /// Load all QuestionnaireProfileVersion entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionnaireProfileVersion>().ToList<IQuestionnaireProfileVersion>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionnaireProfileVersion entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionnaireProfileVersion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.UserName.Contains(username)).ToList<IQuestionnaireProfileVersion>();
			}
		}
		
        /// <summary>
        /// Search for QuestionnaireProfileVersion entities in the database by Version
        /// </summary>
        /// <param name="version">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfileVersion></returns>
		public virtual IList<IQuestionnaireProfileVersion> SearchByVersion(string version, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.Version.ToLower().Contains(version.ToLower())).ToList<IQuestionnaireProfileVersion>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfileVersion>(o => o.Version.Contains(version)).ToList<IQuestionnaireProfileVersion>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireProfileVersion entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaireProfileVersion entity)
		{
			var entityToSave = new QuestionnaireProfileVersion(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionnaireProfileVersion entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaireProfileVersion entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionnaireProfileVersion>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionnaireProfileVersion entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Version != entity.Version) { entityToUpdate.Version = entity.Version;doUpdate = true; }
			if (entityToUpdate.GroupApplicantPropertyAnswers != entity.GroupApplicantPropertyAnswers) { entityToUpdate.GroupApplicantPropertyAnswers = entity.GroupApplicantPropertyAnswers;doUpdate = true; }
			if (entityToUpdate.VersionLocked != entity.VersionLocked) { entityToUpdate.VersionLocked = entity.VersionLocked;doUpdate = true; }
			if (entityToUpdate.QuestionnaireProfileId != entity.QuestionnaireProfileId) { entityToUpdate.QuestionnaireProfileId = entity.QuestionnaireProfileId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionnaireProfileVersion entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireProfileVersion</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaireProfileVersion entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireProfileVersion>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireProfileVersion entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionnaireProfileVersion entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireProfileVersion>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireProfileVersion entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
