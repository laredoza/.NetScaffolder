
// <copyright file="ConditionResultContainer_Audit.g.cs" company="MIT">
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
	/// The ConditionResultContainer_AuditRepository class responsible for database functions in the ConditionResultContainer_Audit table
	/// </summary>
	public partial class ConditionResultContainer_AuditRepository : UowRepository<ConditionResultContainer_Audit> , IConditionResultContainer_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ConditionResultContainer_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ConditionResultContainer_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ConditionResultContainer_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IConditionResultContainer_Audit</returns>
		public virtual IConditionResultContainer_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<ConditionResultContainer_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load ConditionResultContainer_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.Id == id).ToList<IConditionResultContainer_Audit>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.Stamp == stamp).ToList<IConditionResultContainer_Audit>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.UserName == username).ToList<IConditionResultContainer_Audit>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer_Audit entities from the database using the ConditionResultXml field
        /// </summary>
        /// <param name="conditionresultxml">string</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadByConditionResultXml(string conditionresultxml)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.ConditionResultXml == conditionresultxml).ToList<IConditionResultContainer_Audit>();
		}
		
        /// <summary>
        /// Load ConditionResultContainer_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IConditionResultContainer_Audit>();
		}
		
        /// <summary>
        /// Load all ConditionResultContainer_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<ConditionResultContainer_Audit>().ToList<IConditionResultContainer_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for ConditionResultContainer_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IConditionResultContainer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.UserName.Contains(username)).ToList<IConditionResultContainer_Audit>();
			}
		}
		
        /// <summary>
        /// Search for ConditionResultContainer_Audit entities in the database by ConditionResultXml
        /// </summary>
        /// <param name="conditionresultxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IConditionResultContainer_Audit></returns>
		public virtual IList<IConditionResultContainer_Audit> SearchByConditionResultXml(string conditionresultxml, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.ConditionResultXml.ToLower().Contains(conditionresultxml.ToLower())).ToList<IConditionResultContainer_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<ConditionResultContainer_Audit>(o => o.ConditionResultXml.Contains(conditionresultxml)).ToList<IConditionResultContainer_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ConditionResultContainer_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IConditionResultContainer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IConditionResultContainer_Audit entity)
		{
			var entityToSave = new ConditionResultContainer_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ConditionResultContainer_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IConditionResultContainer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IConditionResultContainer_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ConditionResultContainer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ConditionResultContainer_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.ConditionResultXml != entity.ConditionResultXml) { entityToUpdate.ConditionResultXml = entity.ConditionResultXml;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ConditionResultContainer_Audit entity from the database
        /// </summary>
        /// <param name="entity">IConditionResultContainer_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IConditionResultContainer_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionResultContainer_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionResultContainer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ConditionResultContainer_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ConditionResultContainer_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ConditionResultContainer_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
