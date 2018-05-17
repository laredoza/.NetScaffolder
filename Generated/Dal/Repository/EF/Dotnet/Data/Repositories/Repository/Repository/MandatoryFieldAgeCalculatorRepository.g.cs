
// <copyright file="MandatoryFieldAgeCalculator.g.cs" company="MIT">
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
	/// The MandatoryFieldAgeCalculatorRepository class responsible for database functions in the MandatoryFieldAgeCalculator table
	/// </summary>
	public partial class MandatoryFieldAgeCalculatorRepository : UowRepository<MandatoryFieldAgeCalculator> , IMandatoryFieldAgeCalculatorRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for MandatoryFieldAgeCalculatorRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public MandatoryFieldAgeCalculatorRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the MandatoryFieldAgeCalculator entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IMandatoryFieldAgeCalculator</returns>
		public virtual IMandatoryFieldAgeCalculator LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<MandatoryFieldAgeCalculator>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load MandatoryFieldAgeCalculator entities from the database using the CalculatorName field
        /// </summary>
        /// <param name="calculatorname">string</param>
        /// <returns>IList<IMandatoryFieldAgeCalculator></returns>
		public virtual IList<IMandatoryFieldAgeCalculator> LoadByCalculatorName(string calculatorname)
		{
			return this.UnitOfWork.AllMatching<MandatoryFieldAgeCalculator>(o => o.CalculatorName == calculatorname).ToList<IMandatoryFieldAgeCalculator>();
		}
		
        /// <summary>
        /// Load all MandatoryFieldAgeCalculator entities from the database.
        /// </summary>
        /// <returns>IList<IMandatoryFieldAgeCalculator></returns>
		public virtual IList<IMandatoryFieldAgeCalculator> LoadAll()
		{
			return this.UnitOfWork.GetAll<MandatoryFieldAgeCalculator>().ToList<IMandatoryFieldAgeCalculator>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for MandatoryFieldAgeCalculator entities in the database by CalculatorName
        /// </summary>
        /// <param name="calculatorname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IMandatoryFieldAgeCalculator></returns>
		public virtual IList<IMandatoryFieldAgeCalculator> SearchByCalculatorName(string calculatorname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<MandatoryFieldAgeCalculator>(o => o.CalculatorName.ToLower().Contains(calculatorname.ToLower())).ToList<IMandatoryFieldAgeCalculator>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<MandatoryFieldAgeCalculator>(o => o.CalculatorName.Contains(calculatorname)).ToList<IMandatoryFieldAgeCalculator>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the MandatoryFieldAgeCalculator entity to the database.
        /// </summary>
        /// <param name="entity">IMandatoryFieldAgeCalculator</param>
        /// <returns>bool</returns>
		public virtual bool Save(IMandatoryFieldAgeCalculator entity)
		{
			var entityToSave = new MandatoryFieldAgeCalculator(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the MandatoryFieldAgeCalculator entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IMandatoryFieldAgeCalculator</param>
        /// <returns>bool</returns>
		public virtual bool Update(IMandatoryFieldAgeCalculator entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<MandatoryFieldAgeCalculator>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The MandatoryFieldAgeCalculator entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CalculatorName != entity.CalculatorName) { entityToUpdate.CalculatorName = entity.CalculatorName;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the MandatoryFieldAgeCalculator entity from the database
        /// </summary>
        /// <param name="entity">IMandatoryFieldAgeCalculator</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IMandatoryFieldAgeCalculator entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MandatoryFieldAgeCalculator>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MandatoryFieldAgeCalculator entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the MandatoryFieldAgeCalculator entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<MandatoryFieldAgeCalculator>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The MandatoryFieldAgeCalculator entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
