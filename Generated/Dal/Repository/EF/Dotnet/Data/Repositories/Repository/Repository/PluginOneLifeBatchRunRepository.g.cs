
// <copyright file="PluginOneLifeBatchRun.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunRepository class responsible for database functions in the PluginOneLifeBatchRun table
	/// </summary>
	public partial class PluginOneLifeBatchRunRepository : UowRepository<PluginOneLifeBatchRun> , IPluginOneLifeBatchRunRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for PluginOneLifeBatchRunRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public PluginOneLifeBatchRunRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the PluginOneLifeBatchRun entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRun</returns>
		public virtual IPluginOneLifeBatchRun LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRun>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.Stamp == stamp).ToList<IPluginOneLifeBatchRun>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.UserName == username).ToList<IPluginOneLifeBatchRun>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadByPluginOneLifeCedantId(Nullable<int> pluginonelifecedantid)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.PluginOneLifeCedantId == pluginonelifecedantid).ToList<IPluginOneLifeBatchRun>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the Completed field
        /// </summary>
        /// <param name="completed">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadByCompleted(Nullable<bool> completed)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.Completed == completed).ToList<IPluginOneLifeBatchRun>();
		}
		
        /// <summary>
        /// Load PluginOneLifeBatchRun entities from the database using the HasError field
        /// </summary>
        /// <param name="haserror">Nullable<bool></param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadByHasError(Nullable<bool> haserror)
		{
			return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.HasError == haserror).ToList<IPluginOneLifeBatchRun>();
		}
		
        /// <summary>
        /// Load all PluginOneLifeBatchRun entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> LoadAll()
		{
			return this.UnitOfWork.GetAll<PluginOneLifeBatchRun>().ToList<IPluginOneLifeBatchRun>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for PluginOneLifeBatchRun entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRun></returns>
		public virtual IList<IPluginOneLifeBatchRun> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IPluginOneLifeBatchRun>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<PluginOneLifeBatchRun>(o => o.UserName.Contains(username)).ToList<IPluginOneLifeBatchRun>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRun entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		public virtual bool Save(IPluginOneLifeBatchRun entity)
		{
			var entityToSave = new PluginOneLifeBatchRun(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the PluginOneLifeBatchRun entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		public virtual bool Update(IPluginOneLifeBatchRun entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRun>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The PluginOneLifeBatchRun entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.PluginOneLifeCedantId != entity.PluginOneLifeCedantId) { entityToUpdate.PluginOneLifeCedantId = entity.PluginOneLifeCedantId;doUpdate = true; }
			if (entityToUpdate.Completed != entity.Completed) { entityToUpdate.Completed = entity.Completed;doUpdate = true; }
			if (entityToUpdate.HasError != entity.HasError) { entityToUpdate.HasError = entity.HasError;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRun entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRun</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IPluginOneLifeBatchRun entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRun>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRun entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRun entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<PluginOneLifeBatchRun>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The PluginOneLifeBatchRun entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
