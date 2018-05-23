﻿
// <copyright file="SetupTable.g.cs" company="MIT">
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
	/// The SetupTableRepository class responsible for database functions in the SetupTable table
	/// </summary>
	public partial class SetupTableRepository : UowRepository<SetupTable> , ISetupTableRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SetupTableRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SetupTableRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SetupTable entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISetupTable</returns>
		public virtual ISetupTable LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SetupTable>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SetupTable entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<SetupTable>(o => o.Stamp == stamp).ToList<ISetupTable>();
		}
		
        /// <summary>
        /// Load SetupTable entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<SetupTable>(o => o.UserName == username).ToList<ISetupTable>();
		}
		
        /// <summary>
        /// Load SetupTable entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<SetupTable>(o => o.Name == name).ToList<ISetupTable>();
		}
		
        /// <summary>
        /// Load SetupTable entities from the database using the canBeReferenced field
        /// </summary>
        /// <param name="canbereferenced">Nullable<bool></param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadBycanBeReferenced(Nullable<bool> canbereferenced)
		{
			return this.UnitOfWork.AllMatching<SetupTable>(o => o.canBeReferenced == canbereferenced).ToList<ISetupTable>();
		}
		
        /// <summary>
        /// Load SetupTable entities from the database using the canBeMonitored field
        /// </summary>
        /// <param name="canbemonitored">Nullable<bool></param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadBycanBeMonitored(Nullable<bool> canbemonitored)
		{
			return this.UnitOfWork.AllMatching<SetupTable>(o => o.canBeMonitored == canbemonitored).ToList<ISetupTable>();
		}
		
        /// <summary>
        /// Load all SetupTable entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> LoadAll()
		{
			return this.UnitOfWork.GetAll<SetupTable>().ToList<ISetupTable>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SetupTable entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTable>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ISetupTable>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTable>(o => o.UserName.Contains(username)).ToList<ISetupTable>();
			}
		}
		
        /// <summary>
        /// Search for SetupTable entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTable></returns>
		public virtual IList<ISetupTable> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SetupTable>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ISetupTable>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SetupTable>(o => o.Name.Contains(name)).ToList<ISetupTable>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTable entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISetupTable entity)
		{
			var entityToSave = new SetupTable(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SetupTable entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISetupTable entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SetupTable>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SetupTable entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.canBeReferenced != entity.canBeReferenced) { entityToUpdate.canBeReferenced = entity.canBeReferenced;doUpdate = true; }
			if (entityToUpdate.canBeMonitored != entity.canBeMonitored) { entityToUpdate.canBeMonitored = entity.canBeMonitored;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SetupTable entity from the database
        /// </summary>
        /// <param name="entity">ISetupTable</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISetupTable entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTable>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTable entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SetupTable entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTable>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTable entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}