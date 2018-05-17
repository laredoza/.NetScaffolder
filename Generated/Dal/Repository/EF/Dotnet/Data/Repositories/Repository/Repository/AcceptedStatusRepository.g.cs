
// <copyright file="AcceptedStatus.g.cs" company="MIT">
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
	/// The AcceptedStatusRepository class responsible for database functions in the AcceptedStatus table
	/// </summary>
	public partial class AcceptedStatusRepository : UowRepository<AcceptedStatus> , IAcceptedStatusRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for AcceptedStatusRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public AcceptedStatusRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the AcceptedStatus entity from the database using the AcceptedStatusID primary key
        /// </summary>
        /// <param name="acceptedstatusid">int</param>
        /// <returns>IAcceptedStatus</returns>
		public virtual IAcceptedStatus LoadByAcceptedStatusID(int acceptedstatusid)
		{
			return this.UnitOfWork.FirstOrDefault<AcceptedStatus>(o => o.AcceptedStatusID == acceptedstatusid);
		}
		
        /// <summary>
        /// Load AcceptedStatus entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IAcceptedStatus></returns>
		public virtual IList<IAcceptedStatus> LoadByDescription(string description)
		{
			return this.UnitOfWork.AllMatching<AcceptedStatus>(o => o.Description == description).ToList<IAcceptedStatus>();
		}
		
        /// <summary>
        /// Load all AcceptedStatus entities from the database.
        /// </summary>
        /// <returns>IList<IAcceptedStatus></returns>
		public virtual IList<IAcceptedStatus> LoadAll()
		{
			return this.UnitOfWork.GetAll<AcceptedStatus>().ToList<IAcceptedStatus>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for AcceptedStatus entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IAcceptedStatus></returns>
		public virtual IList<IAcceptedStatus> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<AcceptedStatus>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<IAcceptedStatus>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<AcceptedStatus>(o => o.Description.Contains(description)).ToList<IAcceptedStatus>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the AcceptedStatus entity to the database.
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		public virtual bool Save(IAcceptedStatus entity)
		{
			var entityToSave = new AcceptedStatus(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the AcceptedStatus entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		public virtual bool Update(IAcceptedStatus entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<AcceptedStatus>(o => o.AcceptedStatusID == entity.AcceptedStatusID);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The AcceptedStatus entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the AcceptedStatus entity from the database
        /// </summary>
        /// <param name="entity">IAcceptedStatus</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IAcceptedStatus entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AcceptedStatus>(o => o.AcceptedStatusID == entity.AcceptedStatusID);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AcceptedStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the AcceptedStatus entity from the database using the AcceptedStatusID
        /// </summary>
        /// <param name="acceptedstatusid">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByAcceptedStatusID(int acceptedstatusid)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<AcceptedStatus>(o => o.AcceptedStatusID == acceptedstatusid);
			
			if(entityToDelete == null)
			{
				throw new Exception("The AcceptedStatus entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
