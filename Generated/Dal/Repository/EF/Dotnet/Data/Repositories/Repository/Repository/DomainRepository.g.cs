
// <copyright file="Domain.g.cs" company="MIT">
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
	/// The DomainRepository class responsible for database functions in the Domain table
	/// </summary>
	public partial class DomainRepository : UowRepository<Domain> , IDomainRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for DomainRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public DomainRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Domain entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IDomain</returns>
		public virtual IDomain LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Domain>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Domain entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<Domain>(o => o.Stamp == stamp).ToList<IDomain>();
		}
		
        /// <summary>
        /// Load Domain entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Domain>(o => o.UserName == username).ToList<IDomain>();
		}
		
        /// <summary>
        /// Load Domain entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<Domain>(o => o.Name == name).ToList<IDomain>();
		}
		
        /// <summary>
        /// Load all Domain entities from the database.
        /// </summary>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> LoadAll()
		{
			return this.UnitOfWork.GetAll<Domain>().ToList<IDomain>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Domain entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Domain>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IDomain>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Domain>(o => o.UserName.Contains(username)).ToList<IDomain>();
			}
		}
		
        /// <summary>
        /// Search for Domain entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDomain></returns>
		public virtual IList<IDomain> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Domain>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IDomain>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Domain>(o => o.Name.Contains(name)).ToList<IDomain>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Domain entity to the database.
        /// </summary>
        /// <param name="entity">IDomain</param>
        /// <returns>bool</returns>
		public virtual bool Save(IDomain entity)
		{
			var entityToSave = new Domain(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Domain entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IDomain</param>
        /// <returns>bool</returns>
		public virtual bool Update(IDomain entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Domain>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Domain entity does not exist");
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
        /// Delete the Domain entity from the database
        /// </summary>
        /// <param name="entity">IDomain</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IDomain entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Domain>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Domain entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Domain entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Domain>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Domain entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
