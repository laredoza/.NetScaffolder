
// <copyright file="BasicAnswerProvider.g.cs" company="MIT">
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
	/// The BasicAnswerProviderRepository class responsible for database functions in the BasicAnswerProvider table
	/// </summary>
	public partial class BasicAnswerProviderRepository : UowRepository<BasicAnswerProvider> , IBasicAnswerProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for BasicAnswerProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public BasicAnswerProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the BasicAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IBasicAnswerProvider</returns>
		public virtual IBasicAnswerProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<BasicAnswerProvider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Value == value).ToList<IBasicAnswerProvider>();
		}
		
        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> LoadByText(string text)
		{
			return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Text == text).ToList<IBasicAnswerProvider>();
		}
		
        /// <summary>
        /// Load BasicAnswerProvider entities from the database using the OverrideAnswer field
        /// </summary>
        /// <param name="overrideanswer">Nullable<bool></param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> LoadByOverrideAnswer(Nullable<bool> overrideanswer)
		{
			return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.OverrideAnswer == overrideanswer).ToList<IBasicAnswerProvider>();
		}
		
        /// <summary>
        /// Load all BasicAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<BasicAnswerProvider>().ToList<IBasicAnswerProvider>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for BasicAnswerProvider entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<IBasicAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Value.Contains(value)).ToList<IBasicAnswerProvider>();
			}
		}
		
        /// <summary>
        /// Search for BasicAnswerProvider entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IBasicAnswerProvider></returns>
		public virtual IList<IBasicAnswerProvider> SearchByText(string text, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Text.ToLower().Contains(text.ToLower())).ToList<IBasicAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<BasicAnswerProvider>(o => o.Text.Contains(text)).ToList<IBasicAnswerProvider>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the BasicAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(IBasicAnswerProvider entity)
		{
			var entityToSave = new BasicAnswerProvider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the BasicAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(IBasicAnswerProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<BasicAnswerProvider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The BasicAnswerProvider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }
			if (entityToUpdate.Text != entity.Text) { entityToUpdate.Text = entity.Text;doUpdate = true; }
			if (entityToUpdate.OverrideAnswer != entity.OverrideAnswer) { entityToUpdate.OverrideAnswer = entity.OverrideAnswer;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the BasicAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">IBasicAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IBasicAnswerProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BasicAnswerProvider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BasicAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the BasicAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<BasicAnswerProvider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The BasicAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
