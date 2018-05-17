
// <copyright file="CalculatedAnswerProvider.g.cs" company="MIT">
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
	/// The CalculatedAnswerProviderRepository class responsible for database functions in the CalculatedAnswerProvider table
	/// </summary>
	public partial class CalculatedAnswerProviderRepository : UowRepository<CalculatedAnswerProvider> , ICalculatedAnswerProviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CalculatedAnswerProviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CalculatedAnswerProviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the CalculatedAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICalculatedAnswerProvider</returns>
		public virtual ICalculatedAnswerProvider LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<CalculatedAnswerProvider>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the CalculatorName field
        /// </summary>
        /// <param name="calculatorname">string</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> LoadByCalculatorName(string calculatorname)
		{
			return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.CalculatorName == calculatorname).ToList<ICalculatedAnswerProvider>();
		}
		
        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the SettingsXml field
        /// </summary>
        /// <param name="settingsxml">string</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> LoadBySettingsXml(string settingsxml)
		{
			return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.SettingsXml == settingsxml).ToList<ICalculatedAnswerProvider>();
		}
		
        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the CalculatorId field
        /// </summary>
        /// <param name="calculatorid">Nullable<int></param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> LoadByCalculatorId(Nullable<int> calculatorid)
		{
			return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.CalculatorId == calculatorid).ToList<ICalculatedAnswerProvider>();
		}
		
        /// <summary>
        /// Load all CalculatedAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> LoadAll()
		{
			return this.UnitOfWork.GetAll<CalculatedAnswerProvider>().ToList<ICalculatedAnswerProvider>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for CalculatedAnswerProvider entities in the database by CalculatorName
        /// </summary>
        /// <param name="calculatorname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> SearchByCalculatorName(string calculatorname, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.CalculatorName.ToLower().Contains(calculatorname.ToLower())).ToList<ICalculatedAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.CalculatorName.Contains(calculatorname)).ToList<ICalculatedAnswerProvider>();
			}
		}
		
        /// <summary>
        /// Search for CalculatedAnswerProvider entities in the database by SettingsXml
        /// </summary>
        /// <param name="settingsxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		public virtual IList<ICalculatedAnswerProvider> SearchBySettingsXml(string settingsxml, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.SettingsXml.ToLower().Contains(settingsxml.ToLower())).ToList<ICalculatedAnswerProvider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<CalculatedAnswerProvider>(o => o.SettingsXml.Contains(settingsxml)).ToList<ICalculatedAnswerProvider>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CalculatedAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICalculatedAnswerProvider entity)
		{
			var entityToSave = new CalculatedAnswerProvider(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the CalculatedAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICalculatedAnswerProvider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CalculatedAnswerProvider>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CalculatedAnswerProvider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.CalculatorName != entity.CalculatorName) { entityToUpdate.CalculatorName = entity.CalculatorName;doUpdate = true; }
			if (entityToUpdate.SettingsXml != entity.SettingsXml) { entityToUpdate.SettingsXml = entity.SettingsXml;doUpdate = true; }
			if (entityToUpdate.CalculatorId != entity.CalculatorId) { entityToUpdate.CalculatorId = entity.CalculatorId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the CalculatedAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICalculatedAnswerProvider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CalculatedAnswerProvider>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CalculatedAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the CalculatedAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CalculatedAnswerProvider>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The CalculatedAnswerProvider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
