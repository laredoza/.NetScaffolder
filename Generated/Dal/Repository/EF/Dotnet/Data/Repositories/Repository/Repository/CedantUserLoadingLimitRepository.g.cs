
// <copyright file="CedantUserLoadingLimit.g.cs" company="MIT">
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
	/// The CedantUserLoadingLimitRepository class responsible for database functions in the CedantUserLoadingLimit table
	/// </summary>
	public partial class CedantUserLoadingLimitRepository : UowRepository<CedantUserLoadingLimit> , ICedantUserLoadingLimitRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantUserLoadingLimitRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantUserLoadingLimitRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantUserLoadingLimit entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantUserLoadingLimit</returns>
		public virtual ICedantUserLoadingLimit LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByStamp(Nullable<DateTime> stamp)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.Stamp == stamp).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByUserName(string username)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.UserName == username).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MinPercentage field
        /// </summary>
        /// <param name="minpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByMinPercentage(Nullable<decimal> minpercentage)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.MinPercentage == minpercentage).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MaxPercentage field
        /// </summary>
        /// <param name="maxpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByMaxPercentage(Nullable<decimal> maxpercentage)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.MaxPercentage == maxpercentage).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByUserId(Nullable<int> userid)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.UserId == userid).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByPremiumProfileId(Nullable<int> premiumprofileid)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.PremiumProfileId == premiumprofileid).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByCedantId(Nullable<int> cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.CedantId == cedantid).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MinUnit field
        /// </summary>
        /// <param name="minunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByMinUnit(Nullable<decimal> minunit)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.MinUnit == minunit).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load CedantUserLoadingLimit entities from the database using the MaxUnit field
        /// </summary>
        /// <param name="maxunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadByMaxUnit(Nullable<decimal> maxunit)
		{
			return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.MaxUnit == maxunit).ToList<ICedantUserLoadingLimit>();
		}
		
        /// <summary>
        /// Load all CedantUserLoadingLimit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantUserLoadingLimit>().ToList<ICedantUserLoadingLimit>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CedantUserLoadingLimit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantUserLoadingLimit></returns>
		public virtual IList<ICedantUserLoadingLimit> SearchByUserName(string username, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.UserName.ToLower().Contains(username.ToLower())).ToList<ICedantUserLoadingLimit>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CedantUserLoadingLimit>(o => o.UserName.Contains(username)).ToList<ICedantUserLoadingLimit>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantUserLoadingLimit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantUserLoadingLimit entity)
		{
			var entityToSave = new CedantUserLoadingLimit(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantUserLoadingLimit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantUserLoadingLimit entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantUserLoadingLimit entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }
			if (entityToUpdate.UserName != entity.UserName) { entityToUpdate.UserName = entity.UserName;doUpdate = true; }
			if (entityToUpdate.MinPercentage != entity.MinPercentage) { entityToUpdate.MinPercentage = entity.MinPercentage;doUpdate = true; }
			if (entityToUpdate.MaxPercentage != entity.MaxPercentage) { entityToUpdate.MaxPercentage = entity.MaxPercentage;doUpdate = true; }
			if (entityToUpdate.UserId != entity.UserId) { entityToUpdate.UserId = entity.UserId;doUpdate = true; }
			if (entityToUpdate.PremiumProfileId != entity.PremiumProfileId) { entityToUpdate.PremiumProfileId = entity.PremiumProfileId;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }
			if (entityToUpdate.MinUnit != entity.MinUnit) { entityToUpdate.MinUnit = entity.MinUnit;doUpdate = true; }
			if (entityToUpdate.MaxUnit != entity.MaxUnit) { entityToUpdate.MaxUnit = entity.MaxUnit;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit entity from the database
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantUserLoadingLimit entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantUserLoadingLimit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantUserLoadingLimit>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantUserLoadingLimit entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
