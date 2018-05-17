
// <copyright file="SetupTableDataOutcomeGroup.g.cs" company="MIT">
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
	/// The SetupTableDataOutcomeGroupRepository class responsible for database functions in the SetupTableDataOutcomeGroup table
	/// </summary>
	public partial class SetupTableDataOutcomeGroupRepository : UowRepository<SetupTableDataOutcomeGroup> , ISetupTableDataOutcomeGroupRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SetupTableDataOutcomeGroupRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SetupTableDataOutcomeGroupRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the SetupTableDataOutcomeGroup entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISetupTableDataOutcomeGroup</returns>
		public virtual ISetupTableDataOutcomeGroup LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SetupTableDataOutcomeGroup>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load SetupTableDataOutcomeGroup entities from the database using the OutcomeGroupId field
        /// </summary>
        /// <param name="outcomegroupid">int</param>
        /// <returns>IList<ISetupTableDataOutcomeGroup></returns>
		public virtual IList<ISetupTableDataOutcomeGroup> LoadByOutcomeGroupId(int outcomegroupid)
		{
			return this.UnitOfWork.AllMatching<SetupTableDataOutcomeGroup>(o => o.OutcomeGroupId == outcomegroupid).ToList<ISetupTableDataOutcomeGroup>();
		}
		
        /// <summary>
        /// Load SetupTableDataOutcomeGroup entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">int</param>
        /// <returns>IList<ISetupTableDataOutcomeGroup></returns>
		public virtual IList<ISetupTableDataOutcomeGroup> LoadBySetupTableDataId(int setuptabledataid)
		{
			return this.UnitOfWork.AllMatching<SetupTableDataOutcomeGroup>(o => o.SetupTableDataId == setuptabledataid).ToList<ISetupTableDataOutcomeGroup>();
		}
		
        /// <summary>
        /// Load all SetupTableDataOutcomeGroup entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTableDataOutcomeGroup></returns>
		public virtual IList<ISetupTableDataOutcomeGroup> LoadAll()
		{
			return this.UnitOfWork.GetAll<SetupTableDataOutcomeGroup>().ToList<ISetupTableDataOutcomeGroup>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTableDataOutcomeGroup entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTableDataOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISetupTableDataOutcomeGroup entity)
		{
			var entityToSave = new SetupTableDataOutcomeGroup(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the SetupTableDataOutcomeGroup entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTableDataOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISetupTableDataOutcomeGroup entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SetupTableDataOutcomeGroup>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SetupTableDataOutcomeGroup entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.OutcomeGroupId != entity.OutcomeGroupId) { entityToUpdate.OutcomeGroupId = entity.OutcomeGroupId;doUpdate = true; }
			if (entityToUpdate.SetupTableDataId != entity.SetupTableDataId) { entityToUpdate.SetupTableDataId = entity.SetupTableDataId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SetupTableDataOutcomeGroup entity from the database
        /// </summary>
        /// <param name="entity">ISetupTableDataOutcomeGroup</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISetupTableDataOutcomeGroup entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableDataOutcomeGroup>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableDataOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the SetupTableDataOutcomeGroup entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SetupTableDataOutcomeGroup>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The SetupTableDataOutcomeGroup entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
