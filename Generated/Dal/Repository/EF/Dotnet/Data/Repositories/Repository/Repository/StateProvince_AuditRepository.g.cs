
// <copyright file="StateProvince_Audit.g.cs" company="MIT">
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
	/// The StateProvince_AuditRepository class responsible for database functions in the StateProvince_Audit table
	/// </summary>
	public partial class StateProvince_AuditRepository : UowRepository<StateProvince_Audit> , IStateProvince_AuditRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for StateProvince_AuditRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public StateProvince_AuditRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the StateProvince_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IStateProvince_Audit</returns>
		public virtual IStateProvince_Audit LoadByAudit_Id(int audit_id)
		{
			return this.UnitOfWork.FirstOrDefault<StateProvince_Audit>(o => o.Audit_Id == audit_id);
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadById(int id)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Id == id).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Stamp == stamp).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.UserName == username).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the StateProvinceCode field
        /// </summary>
        /// <param name="stateprovincecode">string</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByStateProvinceCode(string stateprovincecode)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.StateProvinceCode == stateprovincecode).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Name == name).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Status == status).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the CountryId field
        /// </summary>
        /// <param name="countryid">Nullable<int></param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByCountryId(Nullable<int> countryid)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.CountryId == countryid).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load StateProvince_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadByAuditTrailType(int audittrailtype)
		{
			return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.AuditTrailType == audittrailtype).ToList<IStateProvince_Audit>();
		}
		
        /// <summary>
        /// Load all StateProvince_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> LoadAll()
		{
			return this.UnitOfWork.GetAll<StateProvince_Audit>().ToList<IStateProvince_Audit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for StateProvince_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<IStateProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.UserName.Contains(username)).ToList<IStateProvince_Audit>();
			}
		}
		
        /// <summary>
        /// Search for StateProvince_Audit entities in the database by StateProvinceCode
        /// </summary>
        /// <param name="stateprovincecode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> SearchByStateProvinceCode(string stateprovincecode, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.StateProvinceCode.ToLower().Contains(stateprovincecode.ToLower())).ToList<IStateProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.StateProvinceCode.Contains(stateprovincecode)).ToList<IStateProvince_Audit>();
			}
		}
		
        /// <summary>
        /// Search for StateProvince_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IStateProvince_Audit></returns>
		public virtual IList<IStateProvince_Audit> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<IStateProvince_Audit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<StateProvince_Audit>(o => o.Name.Contains(name)).ToList<IStateProvince_Audit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StateProvince_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IStateProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Save(IStateProvince_Audit entity)
		{
			var entityToSave = new StateProvince_Audit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the StateProvince_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStateProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Update(IStateProvince_Audit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<StateProvince_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The StateProvince_Audit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Id != entity.Id) { entityToUpdate.Id = entity.Id;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.StateProvinceCode != entity.StateProvinceCode) { entityToUpdate.StateProvinceCode = entity.StateProvinceCode;doUpdate = true; }
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.CountryId != entity.CountryId) { entityToUpdate.CountryId = entity.CountryId;doUpdate = true; }
			if (entityToUpdate.AuditTrailType != entity.AuditTrailType) { entityToUpdate.AuditTrailType = entity.AuditTrailType;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the StateProvince_Audit entity from the database
        /// </summary>
        /// <param name="entity">IStateProvince_Audit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IStateProvince_Audit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StateProvince_Audit>(o => o.Audit_Id == entity.Audit_Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StateProvince_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the StateProvince_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAudit_Id(int audit_id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StateProvince_Audit>(o => o.Audit_Id == audit_id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StateProvince_Audit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
