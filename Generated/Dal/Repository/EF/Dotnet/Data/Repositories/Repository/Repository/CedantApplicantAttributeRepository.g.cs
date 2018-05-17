
// <copyright file="CedantApplicantAttribute.g.cs" company="MIT">
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
	/// The CedantApplicantAttributeRepository class responsible for database functions in the CedantApplicantAttribute table
	/// </summary>
	public partial class CedantApplicantAttributeRepository : UowRepository<CedantApplicantAttribute> , ICedantApplicantAttributeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantApplicantAttributeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantApplicantAttributeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantApplicantAttribute entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantApplicantAttribute</returns>
		public virtual ICedantApplicantAttribute LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantApplicantAttribute>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.Stamp == stamp).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.UserName == username).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the Selected field
        /// </summary>
        /// <param name="selected">Nullable<bool></param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadBySelected(Nullable<bool> selected)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.Selected == selected).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the DisplayOnReport field
        /// </summary>
        /// <param name="displayonreport">Nullable<bool></param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadByDisplayOnReport(Nullable<bool> displayonreport)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.DisplayOnReport == displayonreport).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.CedantId == cedantid).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load CedantApplicantAttribute entities from the database using the ApplicantAttributeProfileId field
        /// </summary>
        /// <param name="applicantattributeprofileid">Nullable<int></param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadByApplicantAttributeProfileId(Nullable<int> applicantattributeprofileid)
		{
			return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.ApplicantAttributeProfileId == applicantattributeprofileid).ToList<ICedantApplicantAttribute>();
		}
		
        /// <summary>
        /// Load all CedantApplicantAttribute entities from the database.
        /// </summary>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantApplicantAttribute>().ToList<ICedantApplicantAttribute>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantApplicantAttribute entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantApplicantAttribute></returns>
		public virtual IList<ICedantApplicantAttribute> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantApplicantAttribute>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantApplicantAttribute>(o => o.UserName.Contains(username)).ToList<ICedantApplicantAttribute>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantApplicantAttribute entity to the database.
        /// </summary>
        /// <param name="entity">ICedantApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantApplicantAttribute entity)
		{
			var entityToSave = new CedantApplicantAttribute(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantApplicantAttribute entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantApplicantAttribute entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantApplicantAttribute>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantApplicantAttribute entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.Selected != entity.Selected) { entityToUpdate.Selected = entity.Selected;doUpdate = true; }
			if (entityToUpdate.DisplayOnReport != entity.DisplayOnReport) { entityToUpdate.DisplayOnReport = entity.DisplayOnReport;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.ApplicantAttributeProfileId != entity.ApplicantAttributeProfileId) { entityToUpdate.ApplicantAttributeProfileId = entity.ApplicantAttributeProfileId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantApplicantAttribute entity from the database
        /// </summary>
        /// <param name="entity">ICedantApplicantAttribute</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantApplicantAttribute entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantApplicantAttribute>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantApplicantAttribute entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantApplicantAttribute>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantApplicantAttribute entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
