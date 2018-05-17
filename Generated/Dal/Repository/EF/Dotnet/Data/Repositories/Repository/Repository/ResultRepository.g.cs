
// <copyright file="Result.g.cs" company="MIT">
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
	/// The ResultRepository class responsible for database functions in the Result table
	/// </summary>
	public partial class ResultRepository : UowRepository<Result> , IResultRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ResultRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ResultRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Result entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IResult</returns>
		public virtual IResult LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Result>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Result entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Result>(o => o.Stamp == stamp).ToList<IResult>();
		}
		
        /// <summary>
        /// Load Result entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Result>(o => o.UserName == username).ToList<IResult>();
		}
		
        /// <summary>
        /// Load Result entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<Result>(o => o.Value == value).ToList<IResult>();
		}
		
        /// <summary>
        /// Load Result entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadByText(string text)
		{
			return this.UnitOfWork.AllMatching<Result>(o => o.Text == text).ToList<IResult>();
		}
		
        /// <summary>
        /// Load Result entities from the database using the AnswerProviderId field
        /// </summary>
        /// <param name="answerproviderid">Nullable<int></param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadByAnswerProviderId(Nullable<int> answerproviderid)
		{
			return this.UnitOfWork.AllMatching<Result>(o => o.AnswerProviderId == answerproviderid).ToList<IResult>();
		}
		
        /// <summary>
        /// Load all Result entities from the database.
        /// </summary>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> LoadAll()
		{
			return this.UnitOfWork.GetAll<Result>().ToList<IResult>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Result entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.UserName.Contains(username)).ToList<IResult>();
			}
		}
		
        /// <summary>
        /// Search for Result entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<IResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.Value.Contains(value)).ToList<IResult>();
			}
		}
		
        /// <summary>
        /// Search for Result entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IResult></returns>
		public virtual IList<IResult> SearchByText(string text, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.Text.ToLower().Contains(text.ToLower())).ToList<IResult>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Result>(o => o.Text.Contains(text)).ToList<IResult>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Result entity to the database.
        /// </summary>
        /// <param name="entity">IResult</param>
        /// <returns>bool</returns>
		public virtual bool Save(IResult entity)
		{
			var entityToSave = new Result(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Result entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IResult</param>
        /// <returns>bool</returns>
		public virtual bool Update(IResult entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Result>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Result entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }
			if (entityToUpdate.Text != entity.Text) { entityToUpdate.Text = entity.Text;doUpdate = true; }
			if (entityToUpdate.AnswerProviderId != entity.AnswerProviderId) { entityToUpdate.AnswerProviderId = entity.AnswerProviderId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Result entity from the database
        /// </summary>
        /// <param name="entity">IResult</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IResult entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Result>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Result entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Result entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Result>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Result entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
