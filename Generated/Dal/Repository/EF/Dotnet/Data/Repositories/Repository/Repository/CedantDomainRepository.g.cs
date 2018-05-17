
// <copyright file="CedantDomain.g.cs" company="MIT">
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
	/// The CedantDomainRepository class responsible for database functions in the CedantDomain table
	/// </summary>
	public partial class CedantDomainRepository : UowRepository<CedantDomain> , ICedantDomainRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantDomainRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantDomainRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantDomain entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantDomain</returns>
		public virtual ICedantDomain LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantDomain>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantDomain entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CedantDomain>(o => o.Stamp == stamp).ToList<ICedantDomain>();
		}
		
        /// <summary>
        /// Load CedantDomain entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantDomain>(o => o.UserName == username).ToList<ICedantDomain>();
		}
		
        /// <summary>
        /// Load CedantDomain entities from the database using the DomainId field
        /// </summary>
        /// <param name="domainid">Nullable<int></param>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> LoadByDomainId(Nullable<int> domainid)
		{
			return this.UnitOfWork.AllMatching<CedantDomain>(o => o.DomainId == domainid).ToList<ICedantDomain>();
		}
		
        /// <summary>
        /// Load CedantDomain entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantDomain>(o => o.CedantId == cedantid).ToList<ICedantDomain>();
		}
		
        /// <summary>
        /// Load all CedantDomain entities from the database.
        /// </summary>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantDomain>().ToList<ICedantDomain>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantDomain entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantDomain></returns>
		public virtual IList<ICedantDomain> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantDomain>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantDomain>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantDomain>(o => o.UserName.Contains(username)).ToList<ICedantDomain>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantDomain entity to the database.
        /// </summary>
        /// <param name="entity">ICedantDomain</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantDomain entity)
		{
			var entityToSave = new CedantDomain(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantDomain entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantDomain</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantDomain entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantDomain>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantDomain entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.DomainId != entity.DomainId) { entityToUpdate.DomainId = entity.DomainId;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantDomain entity from the database
        /// </summary>
        /// <param name="entity">ICedantDomain</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantDomain entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantDomain>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantDomain entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantDomain entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantDomain>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantDomain entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
