
// <copyright file="SystemLogType.g.cs" company="MIT">
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
	/// The SystemLogTypeRepository class responsible for database functions in the SystemLogType table
	/// </summary>
	public partial class SystemLogTypeRepository : UowRepository<SystemLogType> , ISystemLogTypeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SystemLogTypeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SystemLogTypeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SystemLogType entity from the database using the LogTypeID primary key
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>ISystemLogType</returns>
		public virtual ISystemLogType LoadByLogTypeID(int logtypeid)
		{
			return this.UnitOfWork.FirstOrDefault<SystemLogType>(o => o.LogTypeID == logtypeid);
		}
		
        /// <summary>
        /// Load SystemLogType entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<ISystemLogType></returns>
		public virtual IList<ISystemLogType> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<SystemLogType>(o => o.Description == description).ToList<ISystemLogType>();
		}
		
        /// <summary>
        /// Load all SystemLogType entities from the database.
        /// </summary>
        /// <returns>IList<ISystemLogType></returns>
		public virtual IList<ISystemLogType> LoadAll()
		{
			return this.UnitOfWork.GetAll<SystemLogType>().ToList<ISystemLogType>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SystemLogType entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISystemLogType></returns>
		public virtual IList<ISystemLogType> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SystemLogType>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<ISystemLogType>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SystemLogType>(o => o.Description.Contains(description)).ToList<ISystemLogType>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SystemLogType entity to the database.
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISystemLogType entity)
		{
			var entityToSave = new SystemLogType(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SystemLogType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISystemLogType entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SystemLogType>(o => o.LogTypeID == entity.LogTypeID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SystemLogType entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SystemLogType entity from the database
        /// </summary>
        /// <param name="entity">ISystemLogType</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISystemLogType entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SystemLogType>(o => o.LogTypeID == entity.LogTypeID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SystemLogType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SystemLogType entity from the database using the LogTypeID
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByLogTypeID(int logtypeid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SystemLogType>(o => o.LogTypeID == logtypeid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SystemLogType entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
