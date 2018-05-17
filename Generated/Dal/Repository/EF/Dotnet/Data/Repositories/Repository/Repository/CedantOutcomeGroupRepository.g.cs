
// <copyright file="CedantOutcomeGroup.g.cs" company="MIT">
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
	/// The CedantOutcomeGroupRepository class responsible for database functions in the CedantOutcomeGroup table
	/// </summary>
	public partial class CedantOutcomeGroupRepository : UowRepository<CedantOutcomeGroup> , ICedantOutcomeGroupRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CedantOutcomeGroupRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CedantOutcomeGroupRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CedantOutcomeGroup entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedantOutcomeGroup</returns>
		public virtual ICedantOutcomeGroup LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CedantOutcomeGroup>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CedantOutcomeGroup entities from the database using the OutcomeGroupId field
        /// </summary>
        /// <param name="outcomegroupid">int</param>
        /// <returns>IList<ICedantOutcomeGroup></returns>
		public virtual IList<ICedantOutcomeGroup> LoadByOutcomeGroupId(int outcomegroupid)
		{
			return this.UnitOfWork.AllMatching<CedantOutcomeGroup>(o => o.OutcomeGroupId == outcomegroupid).ToList<ICedantOutcomeGroup>();
		}
		
        /// <summary>
        /// Load CedantOutcomeGroup entities from the database using the CedantId field
        /// </summary>
        /// <param name="cedantid">int</param>
        /// <returns>IList<ICedantOutcomeGroup></returns>
		public virtual IList<ICedantOutcomeGroup> LoadByCedantId(int cedantid)
		{
			return this.UnitOfWork.AllMatching<CedantOutcomeGroup>(o => o.CedantId == cedantid).ToList<ICedantOutcomeGroup>();
		}
		
        /// <summary>
        /// Load all CedantOutcomeGroup entities from the database.
        /// </summary>
        /// <returns>IList<ICedantOutcomeGroup></returns>
		public virtual IList<ICedantOutcomeGroup> LoadAll()
		{
			return this.UnitOfWork.GetAll<CedantOutcomeGroup>().ToList<ICedantOutcomeGroup>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantOutcomeGroup entity to the database.
        /// </summary>
        /// <param name="entity">ICedantOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICedantOutcomeGroup entity)
		{
			var entityToSave = new CedantOutcomeGroup(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CedantOutcomeGroup entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICedantOutcomeGroup entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CedantOutcomeGroup>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CedantOutcomeGroup entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.OutcomeGroupId != entity.OutcomeGroupId) { entityToUpdate.OutcomeGroupId = entity.OutcomeGroupId;doUpdate = true; }
			if (entityToUpdate.CedantId != entity.CedantId) { entityToUpdate.CedantId = entity.CedantId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CedantOutcomeGroup entity from the database
        /// </summary>
        /// <param name="entity">ICedantOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICedantOutcomeGroup entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantOutcomeGroup>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CedantOutcomeGroup entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CedantOutcomeGroup>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CedantOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
