
// <copyright file="QUIRCUserCedant.g.cs" company="MIT">
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
	/// The QUIRCUserCedantRepository class responsible for database functions in the QUIRCUserCedant table
	/// </summary>
	public partial class QUIRCUserCedantRepository : UowRepository<QUIRCUserCedant> , IQUIRCUserCedantRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for QUIRCUserCedantRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public QUIRCUserCedantRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the QUIRCUserCedant entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IQUIRCUserCedant</returns>
		public virtual IQUIRCUserCedant LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<QUIRCUserCedant>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.Stamp == stamp).ToList<IQUIRCUserCedant>();
		}
		
        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.UserName == username).ToList<IQUIRCUserCedant>();
		}
		
        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadByUserId(int userid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.UserId == userid).ToList<IQUIRCUserCedant>();
		}
		
        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadByCedantId(int cedantid)
		{
			return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.CedantId == cedantid).ToList<IQUIRCUserCedant>();
		}
		
        /// <summary>
        /// Load QUIRCUserCedant entities from the database using the UserRole field
        /// </summary>
        /// <param name="userrole">int</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadByUserRole(int userrole)
		{
			return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.UserRole == userrole).ToList<IQUIRCUserCedant>();
		}
		
        /// <summary>
        /// Load all QUIRCUserCedant entities from the database.
        /// </summary>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> LoadAll()
		{
			return this.UnitOfWork.GetAll<QUIRCUserCedant>().ToList<IQUIRCUserCedant>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for QUIRCUserCedant entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IQUIRCUserCedant></returns>
		public virtual IList<IQUIRCUserCedant> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IQUIRCUserCedant>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<QUIRCUserCedant>(o => o.UserName.Contains(username)).ToList<IQUIRCUserCedant>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the QUIRCUserCedant entity to the database.
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		public virtual bool Save(IQUIRCUserCedant entity)
		{
			var entityToSave = new QUIRCUserCedant(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the QUIRCUserCedant entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		public virtual bool Update(IQUIRCUserCedant entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<QUIRCUserCedant>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The QUIRCUserCedant entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.UserRole != entity.UserRole) { entityToUpdate.UserRole = entity.UserRole;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the QUIRCUserCedant entity from the database
        /// </summary>
        /// <param name="entity">IQUIRCUserCedant</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IQUIRCUserCedant entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUserCedant>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUserCedant entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the QUIRCUserCedant entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<QUIRCUserCedant>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The QUIRCUserCedant entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
