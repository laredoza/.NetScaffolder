
// <copyright file="AccessRestriction.g.cs" company="MIT">
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
	/// The AccessRestrictionRepository class responsible for database functions in the AccessRestriction table
	/// </summary>
	public partial class AccessRestrictionRepository : UowRepository<AccessRestriction> , IAccessRestrictionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AccessRestrictionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AccessRestrictionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AccessRestriction entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IAccessRestriction</returns>
		public virtual IAccessRestriction LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<AccessRestriction>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AccessRestriction entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.Stamp == stamp).ToList<IAccessRestriction>();
		}
		
        /// <summary>
        /// Load AccessRestriction entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.UserName == username).ToList<IAccessRestriction>();
		}
		
        /// <summary>
        /// Load AccessRestriction entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">int</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> LoadByCedantId(int cedantid)
		{
			return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.CedantId == cedantid).ToList<IAccessRestriction>();
		}
		
        /// <summary>
        /// Load AccessRestriction entities from the database using the Restriction field
        /// </summary>
        /// <param name="restriction">string</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> LoadByRestriction(string restriction)
		{
			return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.Restriction == restriction).ToList<IAccessRestriction>();
		}
		
        /// <summary>
        /// Load all AccessRestriction entities from the database.
        /// </summary>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> LoadAll()
		{
			return this.UnitOfWork.GetAll<AccessRestriction>().ToList<IAccessRestriction>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AccessRestriction entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAccessRestriction>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.UserName.Contains(username)).ToList<IAccessRestriction>();
			}
		}
		
        /// <summary>
        /// Search for AccessRestriction entities in the database by Restriction
        /// </summary>
        /// <param name="restriction">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAccessRestriction></returns>
		public virtual IList<IAccessRestriction> SearchByRestriction(string restriction, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.Restriction.ToLower().Contains(restriction.ToLower())).ToList<IAccessRestriction>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AccessRestriction>(o => o.Restriction.Contains(restriction)).ToList<IAccessRestriction>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AccessRestriction entity to the database.
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAccessRestriction entity)
		{
			var entityToSave = new AccessRestriction(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AccessRestriction entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAccessRestriction entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AccessRestriction>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AccessRestriction entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.Restriction != entity.Restriction) { entityToUpdate.Restriction = entity.Restriction;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AccessRestriction entity from the database
        /// </summary>
        /// <param name="entity">IAccessRestriction</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAccessRestriction entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AccessRestriction>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AccessRestriction entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AccessRestriction entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AccessRestriction>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AccessRestriction entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
