
// <copyright file="LoadingOutcome.g.cs" company="MIT">
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
	/// The LoadingOutcomeRepository class responsible for database functions in the LoadingOutcome table
	/// </summary>
	public partial class LoadingOutcomeRepository : UowRepository<LoadingOutcome> , ILoadingOutcomeRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for LoadingOutcomeRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public LoadingOutcomeRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the LoadingOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ILoadingOutcome</returns>
		public virtual ILoadingOutcome LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<LoadingOutcome>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the MathOption field
        /// </summary>
        /// <param name="mathoption">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByMathOption(Nullable<int> mathoption)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.MathOption == mathoption).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the PercentageValue field
        /// </summary>
        /// <param name="percentagevalue">Nullable<decimal></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByPercentageValue(Nullable<decimal> percentagevalue)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.PercentageValue == percentagevalue).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByProductProfileId(Nullable<int> productprofileid)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.ProductProfileId == productprofileid).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByPremiumProfileId(Nullable<int> premiumprofileid)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.PremiumProfileId == premiumprofileid).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByTypeOption(int typeoption)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.TypeOption == typeoption).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the UnitValue field
        /// </summary>
        /// <param name="unitvalue">Nullable<decimal></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByUnitValue(Nullable<decimal> unitvalue)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.UnitValue == unitvalue).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the PeriodOption field
        /// </summary>
        /// <param name="periodoption">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByPeriodOption(Nullable<int> periodoption)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.PeriodOption == periodoption).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the MonthFrom field
        /// </summary>
        /// <param name="monthfrom">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByMonthFrom(Nullable<int> monthfrom)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.MonthFrom == monthfrom).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load LoadingOutcome entities from the database using the YearFrom field
        /// </summary>
        /// <param name="yearfrom">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadByYearFrom(Nullable<int> yearfrom)
		{
			return this.UnitOfWork.AllMatching<LoadingOutcome>(o => o.YearFrom == yearfrom).ToList<ILoadingOutcome>();
		}
		
        /// <summary>
        /// Load all LoadingOutcome entities from the database.
        /// </summary>
        /// <returns>IList<ILoadingOutcome></returns>
		public virtual IList<ILoadingOutcome> LoadAll()
		{
			return this.UnitOfWork.GetAll<LoadingOutcome>().ToList<ILoadingOutcome>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the LoadingOutcome entity to the database.
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Save(ILoadingOutcome entity)
		{
			var entityToSave = new LoadingOutcome(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the LoadingOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Update(ILoadingOutcome entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<LoadingOutcome>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The LoadingOutcome entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.MathOption != entity.MathOption) { entityToUpdate.MathOption = entity.MathOption;doUpdate = true; }
			if (entityToUpdate.PercentageValue != entity.PercentageValue) { entityToUpdate.PercentageValue = entity.PercentageValue;doUpdate = true; }
			if (entityToUpdate.ProductProfileId != entity.ProductProfileId) { entityToUpdate.ProductProfileId = entity.ProductProfileId;doUpdate = true; }
			if (entityToUpdate.PremiumProfileId != entity.PremiumProfileId) { entityToUpdate.PremiumProfileId = entity.PremiumProfileId;doUpdate = true; }
			if (entityToUpdate.TypeOption != entity.TypeOption) { entityToUpdate.TypeOption = entity.TypeOption;doUpdate = true; }
			if (entityToUpdate.UnitValue != entity.UnitValue) { entityToUpdate.UnitValue = entity.UnitValue;doUpdate = true; }
			if (entityToUpdate.PeriodOption != entity.PeriodOption) { entityToUpdate.PeriodOption = entity.PeriodOption;doUpdate = true; }
			if (entityToUpdate.MonthFrom != entity.MonthFrom) { entityToUpdate.MonthFrom = entity.MonthFrom;doUpdate = true; }
			if (entityToUpdate.YearFrom != entity.YearFrom) { entityToUpdate.YearFrom = entity.YearFrom;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the LoadingOutcome entity from the database
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ILoadingOutcome entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<LoadingOutcome>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The LoadingOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the LoadingOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<LoadingOutcome>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The LoadingOutcome entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
