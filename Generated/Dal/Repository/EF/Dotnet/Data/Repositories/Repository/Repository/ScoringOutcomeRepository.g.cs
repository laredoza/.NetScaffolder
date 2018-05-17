
// <copyright file="ScoringOutcome.g.cs" company="MIT">
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
	/// The ScoringOutcomeRepository class responsible for database functions in the ScoringOutcome table
	/// </summary>
	public partial class ScoringOutcomeRepository : UowRepository<ScoringOutcome> , IScoringOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for ScoringOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public ScoringOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the ScoringOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IScoringOutcome</returns>
		public virtual IScoringOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<ScoringOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load ScoringOutcome entities from the database using the MathOption field
        /// </summary>
        /// <param name="mathoption">Nullable<int></param>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadByMathOption(Nullable<int> mathoption)
		{
			return this.UnitOfWork.AllMatching<ScoringOutcome>(o => o.MathOption == mathoption).ToList<IScoringOutcome>();
		}
		
        /// <summary>
        /// Load ScoringOutcome entities from the database using the UnitValue field
        /// </summary>
        /// <param name="unitvalue">Nullable<decimal></param>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadByUnitValue(Nullable<decimal> unitvalue)
		{
			return this.UnitOfWork.AllMatching<ScoringOutcome>(o => o.UnitValue == unitvalue).ToList<IScoringOutcome>();
		}
		
        /// <summary>
        /// Load ScoringOutcome entities from the database using the AttributeProfileId field
        /// </summary>
        /// <param name="attributeprofileid">Nullable<int></param>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadByAttributeProfileId(Nullable<int> attributeprofileid)
		{
			return this.UnitOfWork.AllMatching<ScoringOutcome>(o => o.AttributeProfileId == attributeprofileid).ToList<IScoringOutcome>();
		}
		
        /// <summary>
        /// Load ScoringOutcome entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadByTypeOption(int typeoption)
		{
			return this.UnitOfWork.AllMatching<ScoringOutcome>(o => o.TypeOption == typeoption).ToList<IScoringOutcome>();
		}
		
        /// <summary>
        /// Load ScoringOutcome entities from the database using the PercentageValue field
        /// </summary>
        /// <param name="percentagevalue">Nullable<decimal></param>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadByPercentageValue(Nullable<decimal> percentagevalue)
		{
			return this.UnitOfWork.AllMatching<ScoringOutcome>(o => o.PercentageValue == percentagevalue).ToList<IScoringOutcome>();
		}
		
        /// <summary>
        /// Load all ScoringOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IScoringOutcome></returns>
		public virtual IList<IScoringOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<ScoringOutcome>().ToList<IScoringOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ScoringOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(IScoringOutcome entity)
		{
			var entityToSave = new ScoringOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the ScoringOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(IScoringOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<ScoringOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The ScoringOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.MathOption != entity.MathOption) { entityToUpdate.MathOption = entity.MathOption;doUpdate = true; }
			if (entityToUpdate.UnitValue != entity.UnitValue) { entityToUpdate.UnitValue = entity.UnitValue;doUpdate = true; }
			if (entityToUpdate.AttributeProfileId != entity.AttributeProfileId) { entityToUpdate.AttributeProfileId = entity.AttributeProfileId;doUpdate = true; }
			if (entityToUpdate.TypeOption != entity.TypeOption) { entityToUpdate.TypeOption = entity.TypeOption;doUpdate = true; }
			if (entityToUpdate.PercentageValue != entity.PercentageValue) { entityToUpdate.PercentageValue = entity.PercentageValue;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the ScoringOutcome entity from the database
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IScoringOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ScoringOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ScoringOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the ScoringOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<ScoringOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The ScoringOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
