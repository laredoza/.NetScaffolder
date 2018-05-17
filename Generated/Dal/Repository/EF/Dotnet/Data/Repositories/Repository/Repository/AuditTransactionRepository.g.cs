
// <copyright file="AuditTransaction.g.cs" company="MIT">
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
	/// The AuditTransactionRepository class responsible for database functions in the AuditTransaction table
	/// </summary>
	public partial class AuditTransactionRepository : UowRepository<AuditTransaction> , IAuditTransactionRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AuditTransactionRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AuditTransactionRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AuditTransaction entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>IAuditTransaction</returns>
		public virtual IAuditTransaction LoadById(Guid id)
		{
			return this.UnitOfWork.FirstOrDefault<AuditTransaction>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AuditTransaction entities from the database using the Sql field
        /// </summary>
        /// <param name="sql">string</param>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> LoadBySql(string sql)
		{
			return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.Sql == sql).ToList<IAuditTransaction>();
		}
		
        /// <summary>
        /// Load AuditTransaction entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.UserName == username).ToList<IAuditTransaction>();
		}
		
        /// <summary>
        /// Load AuditTransaction entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.Stamp == stamp).ToList<IAuditTransaction>();
		}
		
        /// <summary>
        /// Load all AuditTransaction entities from the database.
        /// </summary>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> LoadAll()
		{
			return this.UnitOfWork.GetAll<AuditTransaction>().ToList<IAuditTransaction>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AuditTransaction entities in the database by Sql
        /// </summary>
        /// <param name="sql">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> SearchBySql(string sql, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.Sql.ToLower().Contains(sql.ToLower())).ToList<IAuditTransaction>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.Sql.Contains(sql)).ToList<IAuditTransaction>();
			}
		}
		
        /// <summary>
        /// Search for AuditTransaction entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditTransaction></returns>
		public virtual IList<IAuditTransaction> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IAuditTransaction>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AuditTransaction>(o => o.UserName.Contains(username)).ToList<IAuditTransaction>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AuditTransaction entity to the database.
        /// </summary>
        /// <param name="entity">IAuditTransaction</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAuditTransaction entity)
		{
			var entityToSave = new AuditTransaction(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AuditTransaction entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAuditTransaction</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAuditTransaction entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AuditTransaction>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AuditTransaction entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Sql != entity.Sql) { entityToUpdate.Sql = entity.Sql;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AuditTransaction entity from the database
        /// </summary>
        /// <param name="entity">IAuditTransaction</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAuditTransaction entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AuditTransaction>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AuditTransaction entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AuditTransaction entity from the database using the Id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(Guid id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AuditTransaction>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AuditTransaction entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
