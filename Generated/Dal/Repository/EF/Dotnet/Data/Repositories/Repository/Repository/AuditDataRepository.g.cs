
// <copyright file="AuditData.g.cs" company="MIT">
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
	/// The AuditDataRepository class responsible for database functions in the AuditData table
	/// </summary>
	public partial class AuditDataRepository : UowRepository<AuditData> , IAuditDataRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AuditDataRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AuditDataRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AuditData entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>IAuditData</returns>
		public virtual IAuditData LoadById(Guid id)
		{
			return this.UnitOfWork.FirstOrDefault<AuditData>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load AuditData entities from the database using the PropertyName field
        /// </summary>
        /// <param name="propertyname">string</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> LoadByPropertyName(string propertyname)
		{
			return this.UnitOfWork.AllMatching<AuditData>(o => o.PropertyName == propertyname).ToList<IAuditData>();
		}
		
        /// <summary>
        /// Load AuditData entities from the database using the PreviousValue field
        /// </summary>
        /// <param name="previousvalue">string</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> LoadByPreviousValue(string previousvalue)
		{
			return this.UnitOfWork.AllMatching<AuditData>(o => o.PreviousValue == previousvalue).ToList<IAuditData>();
		}
		
        /// <summary>
        /// Load AuditData entities from the database using the NewValue field
        /// </summary>
        /// <param name="newvalue">string</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> LoadByNewValue(string newvalue)
		{
			return this.UnitOfWork.AllMatching<AuditData>(o => o.NewValue == newvalue).ToList<IAuditData>();
		}
		
        /// <summary>
        /// Load AuditData entities from the database using the AuditId field
        /// </summary>
        /// <param name="auditid">Nullable<Guid></param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> LoadByAuditId(Nullable<Guid> auditid)
		{
			return this.UnitOfWork.AllMatching<AuditData>(o => o.AuditId == auditid).ToList<IAuditData>();
		}
		
        /// <summary>
        /// Load all AuditData entities from the database.
        /// </summary>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> LoadAll()
		{
			return this.UnitOfWork.GetAll<AuditData>().ToList<IAuditData>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AuditData entities in the database by PropertyName
        /// </summary>
        /// <param name="propertyname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> SearchByPropertyName(string propertyname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.PropertyName.ToLower().Contains(propertyname.ToLower())).ToList<IAuditData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.PropertyName.Contains(propertyname)).ToList<IAuditData>();
			}
		}
		
        /// <summary>
        /// Search for AuditData entities in the database by PreviousValue
        /// </summary>
        /// <param name="previousvalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> SearchByPreviousValue(string previousvalue, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.PreviousValue.ToLower().Contains(previousvalue.ToLower())).ToList<IAuditData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.PreviousValue.Contains(previousvalue)).ToList<IAuditData>();
			}
		}
		
        /// <summary>
        /// Search for AuditData entities in the database by NewValue
        /// </summary>
        /// <param name="newvalue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAuditData></returns>
		public virtual IList<IAuditData> SearchByNewValue(string newvalue, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.NewValue.ToLower().Contains(newvalue.ToLower())).ToList<IAuditData>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AuditData>(o => o.NewValue.Contains(newvalue)).ToList<IAuditData>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AuditData entity to the database.
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAuditData entity)
		{
			var entityToSave = new AuditData(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AuditData entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAuditData entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AuditData>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AuditData entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.PropertyName != entity.PropertyName) { entityToUpdate.PropertyName = entity.PropertyName;doUpdate = true; }
			if (entityToUpdate.PreviousValue != entity.PreviousValue) { entityToUpdate.PreviousValue = entity.PreviousValue;doUpdate = true; }
			if (entityToUpdate.NewValue != entity.NewValue) { entityToUpdate.NewValue = entity.NewValue;doUpdate = true; }
			if (entityToUpdate.AuditId != entity.AuditId) { entityToUpdate.AuditId = entity.AuditId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AuditData entity from the database
        /// </summary>
        /// <param name="entity">IAuditData</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAuditData entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AuditData>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AuditData entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AuditData entity from the database using the Id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(Guid id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AuditData>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AuditData entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
