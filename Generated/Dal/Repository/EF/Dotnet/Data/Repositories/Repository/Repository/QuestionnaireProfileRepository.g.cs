﻿
// <copyright file="QuestionnaireProfile.g.cs" company="MIT">
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
	/// The QuestionnaireProfileRepository class responsible for database functions in the QuestionnaireProfile table
	/// </summary>
	public partial class QuestionnaireProfileRepository : UowRepository<QuestionnaireProfile> , IQuestionnaireProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QuestionnaireProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QuestionnaireProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QuestionnaireProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQuestionnaireProfile</returns>
		public virtual IQuestionnaireProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QuestionnaireProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QuestionnaireProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.Stamp == stamp).ToList<IQuestionnaireProfile>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.UserName == username).ToList<IQuestionnaireProfile>();
		}
		
        /// <summary>
        /// Load QuestionnaireProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.Name == name).ToList<IQuestionnaireProfile>();
		}
		
        /// <summary>
        /// Load all QuestionnaireProfile entities from the database.
        /// </summary>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<QuestionnaireProfile>().ToList<IQuestionnaireProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QuestionnaireProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQuestionnaireProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.UserName.Contains(username)).ToList<IQuestionnaireProfile>();
			}
		}
		
        /// <summary>
        /// Search for QuestionnaireProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQuestionnaireProfile></returns>
		public virtual IList<IQuestionnaireProfile> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IQuestionnaireProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QuestionnaireProfile>(o => o.Name.Contains(name)).ToList<IQuestionnaireProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QuestionnaireProfile entity to the database.
        /// </summary>
        /// <param name="entity">IQuestionnaireProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQuestionnaireProfile entity)
		{
			var entityToSave = new QuestionnaireProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QuestionnaireProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQuestionnaireProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQuestionnaireProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QuestionnaireProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QuestionnaireProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QuestionnaireProfile entity from the database
        /// </summary>
        /// <param name="entity">IQuestionnaireProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQuestionnaireProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QuestionnaireProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QuestionnaireProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QuestionnaireProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
