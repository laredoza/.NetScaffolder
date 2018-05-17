
// <copyright file="QUIRCRolePriviledge.g.cs" company="MIT">
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
	/// The QUIRCRolePriviledgeRepository class responsible for database functions in the QUIRCRolePriviledge table
	/// </summary>
	public partial class QUIRCRolePriviledgeRepository : UowRepository<QUIRCRolePriviledge> , IQUIRCRolePriviledgeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QUIRCRolePriviledgeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QUIRCRolePriviledgeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QUIRCRolePriviledge entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCRolePriviledge</returns>
		public virtual IQUIRCRolePriviledge LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QUIRCRolePriviledge>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.Stamp == stamp).ToList<IQUIRCRolePriviledge>();
		}
		
        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.UserName == username).ToList<IQUIRCRolePriviledge>();
		}
		
        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the RoleId field
        /// </summary>
        /// <param name="roleid">int</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> LoadByRoleId(int roleid)
		{
			return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.RoleId == roleid).ToList<IQUIRCRolePriviledge>();
		}
		
        /// <summary>
        /// Load QUIRCRolePriviledge entities from the database using the Priviledge field
        /// </summary>
        /// <param name="priviledge">int</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> LoadByPriviledge(int priviledge)
		{
			return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.Priviledge == priviledge).ToList<IQUIRCRolePriviledge>();
		}
		
        /// <summary>
        /// Load all QUIRCRolePriviledge entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> LoadAll()
		{
			return this.UnitOfWork.GetAll<QUIRCRolePriviledge>().ToList<IQUIRCRolePriviledge>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QUIRCRolePriviledge entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCRolePriviledge></returns>
		public virtual IList<IQUIRCRolePriviledge> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQUIRCRolePriviledge>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCRolePriviledge>(o => o.UserName.Contains(username)).ToList<IQUIRCRolePriviledge>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCRolePriviledge entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQUIRCRolePriviledge entity)
		{
			var entityToSave = new QUIRCRolePriviledge(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QUIRCRolePriviledge entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQUIRCRolePriviledge entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QUIRCRolePriviledge>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QUIRCRolePriviledge entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.RoleId != entity.RoleId) { entityToUpdate.RoleId = entity.RoleId;doUpdate = true; }
			if (entityToUpdate.Priviledge != entity.Priviledge) { entityToUpdate.Priviledge = entity.Priviledge;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QUIRCRolePriviledge entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCRolePriviledge</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQUIRCRolePriviledge entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCRolePriviledge>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCRolePriviledge entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QUIRCRolePriviledge entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCRolePriviledge>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCRolePriviledge entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
