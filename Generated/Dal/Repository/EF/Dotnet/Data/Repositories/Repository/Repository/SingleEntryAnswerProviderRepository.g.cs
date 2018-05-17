
// <copyright file="SingleEntryAnswerProvider.g.cs" company="MIT">
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
	/// The SingleEntryAnswerProviderRepository class responsible for database functions in the SingleEntryAnswerProvider table
	/// </summary>
	public partial class SingleEntryAnswerProviderRepository : UowRepository<SingleEntryAnswerProvider> , ISingleEntryAnswerProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SingleEntryAnswerProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SingleEntryAnswerProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SingleEntryAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISingleEntryAnswerProvider</returns>
		public virtual ISingleEntryAnswerProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SingleEntryAnswerProvider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the WithValidation field
        /// </summary>
        /// <param name="withvalidation">Nullable<bool></param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		public virtual IList<ISingleEntryAnswerProvider> LoadByWithValidation(Nullable<bool> withvalidation)
		{
			return this.UnitOfWork.AllMatching<SingleEntryAnswerProvider>(o => o.WithValidation == withvalidation).ToList<ISingleEntryAnswerProvider>();
		}
		
        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the ValidationName field
        /// </summary>
        /// <param name="validationname">string</param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		public virtual IList<ISingleEntryAnswerProvider> LoadByValidationName(string validationname)
		{
			return this.UnitOfWork.AllMatching<SingleEntryAnswerProvider>(o => o.ValidationName == validationname).ToList<ISingleEntryAnswerProvider>();
		}
		
        /// <summary>
        /// Load SingleEntryAnswerProvider entities from the database using the OverrideAnswer field
        /// </summary>
        /// <param name="overrideanswer">Nullable<bool></param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		public virtual IList<ISingleEntryAnswerProvider> LoadByOverrideAnswer(Nullable<bool> overrideanswer)
		{
			return this.UnitOfWork.AllMatching<SingleEntryAnswerProvider>(o => o.OverrideAnswer == overrideanswer).ToList<ISingleEntryAnswerProvider>();
		}
		
        /// <summary>
        /// Load all SingleEntryAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		public virtual IList<ISingleEntryAnswerProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<SingleEntryAnswerProvider>().ToList<ISingleEntryAnswerProvider>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SingleEntryAnswerProvider entities in the database by ValidationName
        /// </summary>
        /// <param name="validationname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISingleEntryAnswerProvider></returns>
		public virtual IList<ISingleEntryAnswerProvider> SearchByValidationName(string validationname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SingleEntryAnswerProvider>(o => o.ValidationName.ToLower().Contains(validationname.ToLower())).ToList<ISingleEntryAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SingleEntryAnswerProvider>(o => o.ValidationName.Contains(validationname)).ToList<ISingleEntryAnswerProvider>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SingleEntryAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISingleEntryAnswerProvider entity)
		{
			var entityToSave = new SingleEntryAnswerProvider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SingleEntryAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISingleEntryAnswerProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SingleEntryAnswerProvider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SingleEntryAnswerProvider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.WithValidation != entity.WithValidation) { entityToUpdate.WithValidation = entity.WithValidation;doUpdate = true; }
			if (entityToUpdate.ValidationName != entity.ValidationName) { entityToUpdate.ValidationName = entity.ValidationName;doUpdate = true; }
			if (entityToUpdate.OverrideAnswer != entity.OverrideAnswer) { entityToUpdate.OverrideAnswer = entity.OverrideAnswer;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SingleEntryAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ISingleEntryAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISingleEntryAnswerProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SingleEntryAnswerProvider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SingleEntryAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SingleEntryAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SingleEntryAnswerProvider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SingleEntryAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
