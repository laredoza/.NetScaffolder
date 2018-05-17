
// <copyright file="Domain_Audit.g.cs" company="MIT">
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
	/// The Domain_AuditRepository class responsible for database functions in the Domain_Audit table
	/// </summary>
	public partial class Domain_AuditRepository : UowRepository<Domain_Audit> , IDomain_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for Domain_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public Domain_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Domain_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IDomain_Audit</returns>
		public virtual IDomain_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<Domain_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load Domain_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.Id == id).ToList<IDomain_Audit>();
		}
		
        /// <summary>
        /// Load Domain_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.Stamp == stamp).ToList<IDomain_Audit>();
		}
		
        /// <summary>
        /// Load Domain_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.UserName == username).ToList<IDomain_Audit>();
		}
		
        /// <summary>
        /// Load Domain_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.Name == name).ToList<IDomain_Audit>();
		}
		
        /// <summary>
        /// Load Domain_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IDomain_Audit>();
		}
		
        /// <summary>
        /// Load all Domain_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<Domain_Audit>().ToList<IDomain_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Domain_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IDomain_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.UserName.Contains(username)).ToList<IDomain_Audit>();
			}
		}
		
        /// <summary>
        /// Search for Domain_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IDomain_Audit></returns>
		public virtual IList<IDomain_Audit> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IDomain_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Domain_Audit>(o => o.Name.Contains(name)).ToList<IDomain_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Domain_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IDomain_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IDomain_Audit entity)
		{
			var entityToSave = new Domain_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Domain_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IDomain_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IDomain_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Domain_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Domain_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Domain_Audit entity from the database
        /// </summary>
        /// <param name="entity">IDomain_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IDomain_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Domain_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Domain_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Domain_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Domain_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Domain_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
