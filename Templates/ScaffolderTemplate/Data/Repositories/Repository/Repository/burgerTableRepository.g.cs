
// <copyright file="burgerTable.g.cs" company="Dot Net Scaffolder">
//  Copyright (c) 2018 MIT License
// </copyright>  

 // Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in th
// e Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, subj
// ect to the following conditions: The above copyright notice and this permission 
// notice shall be included in all copies or substantial portions of the Software. 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLI
// ED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR 
// A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYR
// IGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WIT
// H THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



// *******************************************************************
//	GENERATED CODE. DOT NOT MODIFY MANUALLY AS CHANGES CAN BE LOST!!!
//	USE A PARTIAL CLASS INSTEAD
// *******************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The burgerTableRepository class responsible for database functions in the burgerTable table
	/// </summary>
	public partial class burgerTableRepository : UowRepository<burgerTable> , IburgerTableRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for burgerTableRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public burgerTableRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load burgerTable entities from the database using the composite primary keys
        /// </summary
        /// <param name="id1">int</param>
        /// <param name="id2">int</param>
        /// <returns>IburgerTable</returns>
		public virtual IburgerTable Load( int id1,  int id2)
		{
			return this.UnitOfWork.FirstOrDefault<burgerTable>(o =>  o.Id1 == id1 &&  o.Id2 == id2 );
		}

        /// <summary>
        /// Load all burgerTable entities from the database.
        /// </summary>
        /// <returns>IList<IburgerTable></returns>
		public virtual IList<IburgerTable> LoadAll()
		{
			return this.UnitOfWork.GetAll<burgerTable>().ToList<IburgerTable>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for burgerTable entities in the database by description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IburgerTable></returns>
		public virtual IList<IburgerTable> SearchBydescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<burgerTable>(o => o.description.Contains(description)).ToList<IburgerTable>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<burgerTable>(o => o.description.ToLower().Contains(description.ToLower())).ToList<IburgerTable>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the burgerTable entity to the database.
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		public virtual bool Save(IburgerTable entity)
		{
			var entityToSave = new burgerTable(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id1 = entityToSave.Id1;
			entity.Id2 = entityToSave.Id2;
			entity.description = entityToSave.description;
			
			return result;
		}

        /// <summary>
        /// Update the burgerTable entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		public virtual bool Update(IburgerTable entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<burgerTable>(o =>  o.Id1 == entity.Id1 &&  o.Id2 == entity.Id2 );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The burgerTable entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.description != entity.description) { entityToUpdate.description = entity.description;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the burgerTable entity from the database
        /// </summary>
        /// <param name="entity">IburgerTable</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IburgerTable entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<burgerTable>(o =>  o.Id1 == entity.Id1 &&  o.Id2 == entity.Id2 );
			
			if(entityToDelete == null)
			{
				throw new Exception("The burgerTable entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the burgerTable entity from the database
        /// </summary>
        /// <param name="id1">int</param>
        /// <param name="id2">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id1,  int id2)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<burgerTable>(o =>  o.Id1 == id1 &&  o.Id2 == id2 );
			
			if(entityToDelete == null)
			{
				throw new Exception("The burgerTable entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
