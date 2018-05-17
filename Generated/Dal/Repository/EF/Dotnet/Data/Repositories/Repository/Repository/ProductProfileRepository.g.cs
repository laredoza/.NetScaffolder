
// <copyright file="ProductProfile.g.cs" company="MIT">
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
	/// The ProductProfileRepository class responsible for database functions in the ProductProfile table
	/// </summary>
	public partial class ProductProfileRepository : UowRepository<ProductProfile> , IProductProfileRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ProductProfileRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ProductProfileRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ProductProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductProfile</returns>
		public virtual IProductProfile LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ProductProfile>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ProductProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Stamp == stamp).ToList<IProductProfile>();
		}
		
        /// <summary>
        /// Load ProductProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ProductProfile>(o => o.UserName == username).ToList<IProductProfile>();
		}
		
        /// <summary>
        /// Load ProductProfile entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Name == name).ToList<IProductProfile>();
		}
		
        /// <summary>
        /// Load ProductProfile entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Description == description).ToList<IProductProfile>();
		}
		
        /// <summary>
        /// Load all ProductProfile entities from the database.
        /// </summary>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> LoadAll()
		{
			return this.UnitOfWork.GetAll<ProductProfile>().ToList<IProductProfile>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ProductProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IProductProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.UserName.Contains(username)).ToList<IProductProfile>();
			}
		}
		
        /// <summary>
        /// Search for ProductProfile entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IProductProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Name.Contains(name)).ToList<IProductProfile>();
			}
		}
		
        /// <summary>
        /// Search for ProductProfile entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IProductProfile></returns>
		public virtual IList<IProductProfile> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IProductProfile>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ProductProfile>(o => o.Description.Contains(description)).ToList<IProductProfile>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductProfile entity to the database.
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		public virtual bool Save(IProductProfile entity)
		{
			var entityToSave = new ProductProfile(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ProductProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		public virtual bool Update(IProductProfile entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ProductProfile>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ProductProfile entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ProductProfile entity from the database
        /// </summary>
        /// <param name="entity">IProductProfile</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IProductProfile entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductProfile>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ProductProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ProductProfile>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ProductProfile entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
