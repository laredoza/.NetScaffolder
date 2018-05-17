
// <copyright file="CedantMandatoryField.g.cs" company="MIT">
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
	/// The CedantMandatoryFieldRepository class responsible for database functions in the CedantMandatoryField table
	/// </summary>
	public partial class CedantMandatoryFieldRepository : UowRepository<CedantMandatoryField> , ICedantMandatoryFieldRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantMandatoryFieldRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantMandatoryFieldRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantMandatoryField entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantMandatoryField</returns>
		public virtual ICedantMandatoryField LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantMandatoryField>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.Stamp == stamp).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.UserName == username).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the MandatoryFieldName field
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByMandatoryFieldName(string mandatoryfieldname)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.MandatoryFieldName == mandatoryfieldname).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the Selected field
        /// </summary>
        /// <param name="selected">Nullable<bool></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadBySelected(Nullable<bool> selected)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.Selected == selected).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the ValidateType field
        /// </summary>
        /// <param name="validatetype">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByValidateType(Nullable<int> validatetype)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.ValidateType == validatetype).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.CedantId == cedantid).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load CedantMandatoryField entities from the database using the MandatoryFieldId field
        /// </summary>
        /// <param name="mandatoryfieldid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadByMandatoryFieldId(Nullable<int> mandatoryfieldid)
		{
			return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.MandatoryFieldId == mandatoryfieldid).ToList<ICedantMandatoryField>();
		}
		
        /// <summary>
        /// Load all CedantMandatoryField entities from the database.
        /// </summary>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantMandatoryField>().ToList<ICedantMandatoryField>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantMandatoryField entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantMandatoryField>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.UserName.Contains(username)).ToList<ICedantMandatoryField>();
			}
		}
		
        /// <summary>
        /// Search for CedantMandatoryField entities in the database by MandatoryFieldName
        /// </summary>
        /// <param name="mandatoryfieldname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryField></returns>
		public virtual IList<ICedantMandatoryField> SearchByMandatoryFieldName(string mandatoryfieldname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.MandatoryFieldName.ToLower().Contains(mandatoryfieldname.ToLower())).ToList<ICedantMandatoryField>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantMandatoryField>(o => o.MandatoryFieldName.Contains(mandatoryfieldname)).ToList<ICedantMandatoryField>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantMandatoryField entity to the database.
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantMandatoryField entity)
		{
			var entityToSave = new CedantMandatoryField(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantMandatoryField entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantMandatoryField entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantMandatoryField>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantMandatoryField entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.MandatoryFieldName != entity.MandatoryFieldName) { entityToUpdate.MandatoryFieldName = entity.MandatoryFieldName;doUpdate = true; }
			if (entityToUpdate.Selected != entity.Selected) { entityToUpdate.Selected = entity.Selected;doUpdate = true; }
			if (entityToUpdate.ValidateType != entity.ValidateType) { entityToUpdate.ValidateType = entity.ValidateType;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.MandatoryFieldId != entity.MandatoryFieldId) { entityToUpdate.MandatoryFieldId = entity.MandatoryFieldId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantMandatoryField entity from the database
        /// </summary>
        /// <param name="entity">ICedantMandatoryField</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantMandatoryField entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryField>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryField entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantMandatoryField entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantMandatoryField>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantMandatoryField entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
