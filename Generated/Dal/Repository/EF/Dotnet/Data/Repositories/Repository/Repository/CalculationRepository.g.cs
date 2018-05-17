
// <copyright file="Calculation.g.cs" company="MIT">
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
	/// The CalculationRepository class responsible for database functions in the Calculation table
	/// </summary>
	public partial class CalculationRepository : UowRepository<Calculation> , ICalculationRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CalculationRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CalculationRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the Calculation entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICalculation</returns>
		public virtual ICalculation LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<Calculation>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load Calculation entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> LoadByName(string name)
		{
			return this.UnitOfWork.AllMatching<Calculation>(o => o.Name == name).ToList<ICalculation>();
		}
		
        /// <summary>
        /// Load Calculation entities from the database using the Expression field
        /// </summary>
        /// <param name="expression">string</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> LoadByExpression(string expression)
		{
			return this.UnitOfWork.AllMatching<Calculation>(o => o.Expression == expression).ToList<ICalculation>();
		}
		
        /// <summary>
        /// Load Calculation entities from the database using the SettingsXml field
        /// </summary>
        /// <param name="settingsxml">string</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> LoadBySettingsXml(string settingsxml)
		{
			return this.UnitOfWork.AllMatching<Calculation>(o => o.SettingsXml == settingsxml).ToList<ICalculation>();
		}
		
        /// <summary>
        /// Load Calculation entities from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> LoadByActive(bool active)
		{
			return this.UnitOfWork.AllMatching<Calculation>(o => o.Active == active).ToList<ICalculation>();
		}
		
        /// <summary>
        /// Load all Calculation entities from the database.
        /// </summary>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> LoadAll()
		{
			return this.UnitOfWork.GetAll<Calculation>().ToList<ICalculation>();
		}
		
		#endregion

		#region Search
		
        /// <summary>
        /// Search for Calculation entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> SearchByName(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.Name.ToLower().Contains(name.ToLower())).ToList<ICalculation>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.Name.Contains(name)).ToList<ICalculation>();
			}
		}
		
        /// <summary>
        /// Search for Calculation entities in the database by Expression
        /// </summary>
        /// <param name="expression">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> SearchByExpression(string expression, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.Expression.ToLower().Contains(expression.ToLower())).ToList<ICalculation>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.Expression.Contains(expression)).ToList<ICalculation>();
			}
		}
		
        /// <summary>
        /// Search for Calculation entities in the database by SettingsXml
        /// </summary>
        /// <param name="settingsxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		public virtual IList<ICalculation> SearchBySettingsXml(string settingsxml, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.SettingsXml.ToLower().Contains(settingsxml.ToLower())).ToList<ICalculation>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<Calculation>(o => o.SettingsXml.Contains(settingsxml)).ToList<ICalculation>();
			}
		}
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Calculation entity to the database.
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICalculation entity)
		{
			var entityToSave = new Calculation(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the Calculation entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICalculation entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<Calculation>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The Calculation entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Name != entity.Name) { entityToUpdate.Name = entity.Name;doUpdate = true; }
			if (entityToUpdate.Expression != entity.Expression) { entityToUpdate.Expression = entity.Expression;doUpdate = true; }
			if (entityToUpdate.SettingsXml != entity.SettingsXml) { entityToUpdate.SettingsXml = entity.SettingsXml;doUpdate = true; }
			if (entityToUpdate.Active != entity.Active) { entityToUpdate.Active = entity.Active;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the Calculation entity from the database
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICalculation entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Calculation>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Calculation entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the Calculation entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<Calculation>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The Calculation entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
