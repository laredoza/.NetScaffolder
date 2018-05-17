
// <copyright file="Audit.g.cs" company="MIT">
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
	/// The AuditRepository class responsible for database functions in the Audit table
	/// </summary>
	public partial class AuditRepository : UowRepository<Audit> , IAuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Audit entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>IAudit</returns>
		public virtual IAudit LoadById(Guid id)
		{
			return this.UnitOfWork.FirstOrDefault<Audit>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Audit entities from the database using the Entity field
        /// </summary>
        /// <param name="entity">string</param>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> LoadByEntity(string entity)
		{
			return this.UnitOfWork.AllMatching<Audit>(o => o.Entity == entity).ToList<IAudit>();
		}
		
        /// <summary>
        /// Load Audit entities from the database using the EntityId field
        /// </summary>
        /// <param name="entityid">Nullable<int></param>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> LoadByEntityId(Nullable<int> entityid)
		{
			return this.UnitOfWork.AllMatching<Audit>(o => o.EntityId == entityid).ToList<IAudit>();
		}
		
        /// <summary>
        /// Load Audit entities from the database using the Action field
        /// </summary>
        /// <param name="action">Nullable<int></param>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> LoadByAction(Nullable<int> action)
		{
			return this.UnitOfWork.AllMatching<Audit>(o => o.Action == action).ToList<IAudit>();
		}
		
        /// <summary>
        /// Load Audit entities from the database using the AuditTransactionId field
        /// </summary>
        /// <param name="audittransactionid">Nullable<Guid></param>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> LoadByAuditTransactionId(Nullable<Guid> audittransactionid)
		{
			return this.UnitOfWork.AllMatching<Audit>(o => o.AuditTransactionId == audittransactionid).ToList<IAudit>();
		}
		
        /// <summary>
        /// Load all Audit entities from the database.
        /// </summary>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Audit>().ToList<IAudit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Audit entities in the database by Entity
        /// </summary>
        /// <param name="entity">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAudit></returns>
		public virtual IList<IAudit> SearchByEntity(string entity, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Audit>(o => o.Entity.ToLower().Contains(entity.ToLower())).ToList<IAudit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Audit>(o => o.Entity.Contains(entity)).ToList<IAudit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Audit entity to the database.
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAudit entity)
		{
			var entityToSave = new Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAudit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Audit>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Entity != entity.Entity) { entityToUpdate.Entity = entity.Entity;doUpdate = true; }
			if (entityToUpdate.EntityId != entity.EntityId) { entityToUpdate.EntityId = entity.EntityId;doUpdate = true; }
			if (entityToUpdate.Action != entity.Action) { entityToUpdate.Action = entity.Action;doUpdate = true; }
			if (entityToUpdate.AuditTransactionId != entity.AuditTransactionId) { entityToUpdate.AuditTransactionId = entity.AuditTransactionId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Audit entity from the database
        /// </summary>
        /// <param name="entity">IAudit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAudit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Audit>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Audit entity from the database using the Id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(Guid id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Audit>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
