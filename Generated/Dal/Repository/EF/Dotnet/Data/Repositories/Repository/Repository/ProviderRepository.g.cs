﻿
// <copyright file="Provider.g.cs" company="MIT">
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
	/// The ProviderRepository class responsible for database functions in the Provider table
	/// </summary>
	public partial class ProviderRepository : UowRepository<Provider> , IProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Provider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProvider</returns>
		public virtual IProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Provider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Provider entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProvider></returns>
		public virtual IList<IProvider> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Provider>(o => o.Stamp == stamp).ToList<IProvider>();
		}
		
        /// <summary>
        /// Load Provider entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProvider></returns>
		public virtual IList<IProvider> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Provider>(o => o.UserName == username).ToList<IProvider>();
		}
		
        /// <summary>
        /// Load all Provider entities from the database.
        /// </summary>
        /// <returns>IList<IProvider></returns>
		public virtual IList<IProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<Provider>().ToList<IProvider>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Provider entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProvider></returns>
		public virtual IList<IProvider> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Provider>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Provider>(o => o.UserName.Contains(username)).ToList<IProvider>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Provider entity to the database.
        /// </summary>
        /// <param name="entity">IProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProvider entity)
		{
			var entityToSave = new Provider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Provider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Provider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Provider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Provider entity from the database
        /// </summary>
        /// <param name="entity">IProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Provider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Provider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Provider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Provider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Provider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}