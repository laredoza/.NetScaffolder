
// <copyright file="WCFLog.g.cs" company="MIT">
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
	/// The WCFLogRepository class responsible for database functions in the WCFLog table
	/// </summary>
	public partial class WCFLogRepository : UowRepository<WCFLog> , IWCFLogRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for WCFLogRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public WCFLogRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the WCFLog entity from the database using the id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IWCFLog</returns>
		public virtual IWCFLog LoadByid(int id)
		{
			return this.UnitOfWork.FirstOrDefault<WCFLog>(o => o.id == id);
		}
		
        /// <summary>
        /// Load WCFLog entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<WCFLog>(o => o.Description == description).ToList<IWCFLog>();
		}
		
        /// <summary>
        /// Load WCFLog entities from the database using the AdditionalDetails field
        /// </summary>
        /// <param name="additionaldetails">string</param>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> LoadByAdditionalDetails(string additionaldetails)
		{
			return this.UnitOfWork.AllMatching<WCFLog>(o => o.AdditionalDetails == additionaldetails).ToList<IWCFLog>();
		}
		
        /// <summary>
        /// Load WCFLog entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> LoadByStamp(DateTime stamp)
		{
			return this.UnitOfWork.AllMatching<WCFLog>(o => o.Stamp == stamp).ToList<IWCFLog>();
		}
		
        /// <summary>
        /// Load all WCFLog entities from the database.
        /// </summary>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> LoadAll()
		{
			return this.UnitOfWork.GetAll<WCFLog>().ToList<IWCFLog>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for WCFLog entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<WCFLog>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IWCFLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<WCFLog>(o => o.Description.Contains(description)).ToList<IWCFLog>();
			}
		}
		
        /// <summary>
        /// Search for WCFLog entities in the database by AdditionalDetails
        /// </summary>
        /// <param name="additionaldetails">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog></returns>
		public virtual IList<IWCFLog> SearchByAdditionalDetails(string additionaldetails, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<WCFLog>(o => o.AdditionalDetails.ToLower().Contains(additionaldetails.ToLower())).ToList<IWCFLog>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<WCFLog>(o => o.AdditionalDetails.Contains(additionaldetails)).ToList<IWCFLog>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the WCFLog entity to the database.
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		public virtual bool Save(IWCFLog entity)
		{
			var entityToSave = new WCFLog(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the WCFLog entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		public virtual bool Update(IWCFLog entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<WCFLog>(o => o.id == entity.id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The WCFLog entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.AdditionalDetails != entity.AdditionalDetails) { entityToUpdate.AdditionalDetails = entity.AdditionalDetails;doUpdate = true; }
			if (entityToUpdate.Stamp != entity.Stamp) { entityToUpdate.Stamp = entity.Stamp;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the WCFLog entity from the database
        /// </summary>
        /// <param name="entity">IWCFLog</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IWCFLog entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<WCFLog>(o => o.id == entity.id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The WCFLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the WCFLog entity from the database using the id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByid(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<WCFLog>(o => o.id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The WCFLog entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
