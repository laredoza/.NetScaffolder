
// <copyright file="SystemLog.g.cs" company="MIT">
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
	/// The SystemLogRepository class responsible for database functions in the SystemLog table
	/// </summary>
	public partial class SystemLogRepository : UowRepository<SystemLog> , ISystemLogRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SystemLogRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SystemLogRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SystemLog entity from the database using the LogID primary key
        /// </summary>
        /// <param name="logid">int</param>
        /// <returns>ISystemLog</returns>
		public virtual ISystemLog LoadByLogID(int logid)
		{
			return this.UnitOfWork.FirstOrDefault<SystemLog>(o => o.LogID == logid);
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the LogTypeID field
        /// </summary>
        /// <param name="logtypeid">int</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadByLogTypeID(int logtypeid)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.LogTypeID == logtypeid).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the IsRead field
        /// </summary>
        /// <param name="isread">bool</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadByIsRead(bool isread)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.IsRead == isread).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the PrimaryID field
        /// </summary>
        /// <param name="primaryid">int</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadByPrimaryID(int primaryid)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.PrimaryID == primaryid).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the SecondaryID field
        /// </summary>
        /// <param name="secondaryid">Nullable<int></param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadBySecondaryID(Nullable<int> secondaryid)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.SecondaryID == secondaryid).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the DateUpdated field
        /// </summary>
        /// <param name="dateupdated">DateTime</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadByDateUpdated(DateTime dateupdated)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.DateUpdated == dateupdated).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load SystemLog entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadByValue(string value)
		{
			return this.UnitOfWork.AllMatching<SystemLog>(o => o.Value == value).ToList<ISystemLog>();
		}
		
        /// <summary>
        /// Load all SystemLog entities from the database.
        /// </summary>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> LoadAll()
		{
			return this.UnitOfWork.GetAll<SystemLog>().ToList<ISystemLog>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for SystemLog entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISystemLog></returns>
		public virtual IList<ISystemLog> SearchByValue(string value, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SystemLog>(o => o.Value.ToLower().Contains(value.ToLower())).ToList<ISystemLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SystemLog>(o => o.Value.Contains(value)).ToList<ISystemLog>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SystemLog entity to the database.
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISystemLog entity)
		{
			var entityToSave = new SystemLog(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SystemLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISystemLog entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SystemLog>(o => o.LogID == entity.LogID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SystemLog entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.LogTypeID != entity.LogTypeID) { entityToUpdate.LogTypeID = entity.LogTypeID;doUpdate = true; }
			if (entityToUpdate.IsRead != entity.IsRead) { entityToUpdate.IsRead = entity.IsRead;doUpdate = true; }
			if (entityToUpdate.PrimaryID != entity.PrimaryID) { entityToUpdate.PrimaryID = entity.PrimaryID;doUpdate = true; }
			if (entityToUpdate.SecondaryID != entity.SecondaryID) { entityToUpdate.SecondaryID = entity.SecondaryID;doUpdate = true; }
			if (entityToUpdate.DateUpdated != entity.DateUpdated) { entityToUpdate.DateUpdated = entity.DateUpdated;doUpdate = true; }
			if (entityToUpdate.Value != entity.Value) { entityToUpdate.Value = entity.Value;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SystemLog entity from the database
        /// </summary>
        /// <param name="entity">ISystemLog</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISystemLog entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SystemLog>(o => o.LogID == entity.LogID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SystemLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SystemLog entity from the database using the LogID
        /// </summary>
        /// <param name="logid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByLogID(int logid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SystemLog>(o => o.LogID == logid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SystemLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
