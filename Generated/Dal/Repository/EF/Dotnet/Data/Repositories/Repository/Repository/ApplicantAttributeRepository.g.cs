
// <copyright file="ApplicantAttribute.g.cs" company="MIT">
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
	/// The ApplicantAttributeRepository class responsible for database functions in the ApplicantAttribute table
	/// </summary>
	public partial class ApplicantAttributeRepository : UowRepository<ApplicantAttribute> , IApplicantAttributeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ApplicantAttributeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ApplicantAttributeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ApplicantAttribute entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IApplicantAttribute</returns>
		public virtual IApplicantAttribute LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ApplicantAttribute>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ApplicantAttribute entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.Stamp == stamp).ToList<IApplicantAttribute>();
		}
		
        /// <summary>
        /// Load ApplicantAttribute entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.UserName == username).ToList<IApplicantAttribute>();
		}
		
        /// <summary>
        /// Load ApplicantAttribute entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.Value == value).ToList<IApplicantAttribute>();
		}
		
        /// <summary>
        /// Load ApplicantAttribute entities from the database using the ApplicantAttributeProfileId field
        /// </summary>
        /// <param name="applicantattributeprofileid">Nullable<int></param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadByApplicantAttributeProfileId(Nullable<int> applicantattributeprofileid)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.ApplicantAttributeProfileId == applicantattributeprofileid).ToList<IApplicantAttribute>();
		}
		
        /// <summary>
        /// Load ApplicantAttribute entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadByQuestionnaireId(Nullable<int> questionnaireid)
		{
			return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.QuestionnaireId == questionnaireid).ToList<IApplicantAttribute>();
		}
		
        /// <summary>
        /// Load all ApplicantAttribute entities from the database.
        /// </summary>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> LoadAll()
		{
			return this.UnitOfWork.GetAll<ApplicantAttribute>().ToList<IApplicantAttribute>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ApplicantAttribute entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IApplicantAttribute>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.UserName.Contains(username)).ToList<IApplicantAttribute>();
			}
		}
		
        /// <summary>
        /// Search for ApplicantAttribute entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttribute></returns>
		public virtual IList<IApplicantAttribute> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<IApplicantAttribute>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ApplicantAttribute>(o => o.Value.Contains(value)).ToList<IApplicantAttribute>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ApplicantAttribute entity to the database.
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Save(IApplicantAttribute entity)
		{
			var entityToSave = new ApplicantAttribute(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ApplicantAttribute entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Update(IApplicantAttribute entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ApplicantAttribute>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ApplicantAttribute entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeProfileId != entity.ApplicantAttributeProfileId) { entityToUpdate.ApplicantAttributeProfileId = entity.ApplicantAttributeProfileId;doUpdate = true; }
			if (entityToUpdate.QuestionnaireId != entity.QuestionnaireId) { entityToUpdate.QuestionnaireId = entity.QuestionnaireId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ApplicantAttribute entity from the database
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IApplicantAttribute entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApplicantAttribute>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ApplicantAttribute entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ApplicantAttribute>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
