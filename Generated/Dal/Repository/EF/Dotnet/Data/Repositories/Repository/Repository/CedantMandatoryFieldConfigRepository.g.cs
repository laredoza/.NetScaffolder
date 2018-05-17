
// <copyright file="CedantMandatoryFieldConfig.g.cs" company="MIT">
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
	/// The CedantMandatoryFieldConfigRepository class responsible for database functions in the CedantMandatoryFieldConfig table
	/// </summary>
	public partial class CedantMandatoryFieldConfigRepository : UowRepository<CedantMandatoryFieldConfig> , ICedantMandatoryFieldConfigRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantMandatoryFieldConfigRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantMandatoryFieldConfigRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantMandatoryFieldConfig entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantMandatoryFieldConfig</returns>
		public virtual ICedantMandatoryFieldConfig LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantMandatoryFieldConfig>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.Stamp == stamp).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.UserName == username).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByType(Nullable<int> type)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.Type == type).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the Length field
        /// </summary>
        /// <param name="length">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByLength(Nullable<int> length)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.Length == length).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the Sequence field
        /// </summary>
        /// <param name="sequence">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadBySequence(Nullable<int> sequence)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.Sequence == sequence).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByStatus(Nullable<int> status)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.Status == status).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the CedantMandatoryFieldId field
        /// </summary>
        /// <param name="cedantmandatoryfieldid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByCedantMandatoryFieldId(Nullable<int> cedantmandatoryfieldid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.CedantMandatoryFieldId == cedantmandatoryfieldid).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByProviderId(Nullable<int> providerid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.ProviderId == providerid).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load CedantMandatoryFieldConfig entities from the database using the ApplicantAttributeId field
        /// </summary>
        /// <param name="applicantattributeid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadByApplicantAttributeId(Nullable<int> applicantattributeid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.ApplicantAttributeId == applicantattributeid).ToList<ICedantMandatoryFieldConfig>();
		}
		
        /// <summary>
        /// Load all CedantMandatoryFieldConfig entities from the database.
        /// </summary>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantMandatoryFieldConfig>().ToList<ICedantMandatoryFieldConfig>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantMandatoryFieldConfig entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryFieldConfig></returns>
		public virtual IList<ICedantMandatoryFieldConfig> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantMandatoryFieldConfig>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryFieldConfig>(o => o.UserName.Contains(username)).ToList<ICedantMandatoryFieldConfig>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantMandatoryFieldConfig entity to the database.
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantMandatoryFieldConfig entity)
		{
			var entityToSave = new CedantMandatoryFieldConfig(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantMandatoryFieldConfig entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantMandatoryFieldConfig entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantMandatoryFieldConfig>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantMandatoryFieldConfig entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Type != entity.Type) { entityToUpdate.Type = entity.Type;doUpdate = true; }
			if (entityToUpdate.Length != entity.Length) { entityToUpdate.Length = entity.Length;doUpdate = true; }
			if (entityToUpdate.Sequence != entity.Sequence) { entityToUpdate.Sequence = entity.Sequence;doUpdate = true; }
			if (entityToUpdate.Status != entity.Status) { entityToUpdate.Status = entity.Status;doUpdate = true; }
			if (entityToUpdate.CedantMandatoryFieldId != entity.CedantMandatoryFieldId) { entityToUpdate.CedantMandatoryFieldId = entity.CedantMandatoryFieldId;doUpdate = true; }
			if (entityToUpdate.ProviderId != entity.ProviderId) { entityToUpdate.ProviderId = entity.ProviderId;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeId != entity.ApplicantAttributeId) { entityToUpdate.ApplicantAttributeId = entity.ApplicantAttributeId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantMandatoryFieldConfig entity from the database
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantMandatoryFieldConfig entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryFieldConfig>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryFieldConfig entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantMandatoryFieldConfig entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryFieldConfig>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryFieldConfig entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
