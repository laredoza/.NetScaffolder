
// <copyright file="softwareprovider.g.cs" company="Dot Net Scaffolder">
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
	/// The softwareproviderRepository class responsible for database functions in the softwareprovider table
	/// </summary>
	public partial class softwareproviderRepository : UowRepository<softwareprovider> , IsoftwareproviderRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for softwareproviderRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public softwareproviderRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load softwareprovider entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">long</param>
        /// <returns>Isoftwareprovider</returns>
		public virtual Isoftwareprovider LoadByid(long id)
		{
			return this.UnitOfWork.FirstOrDefault<softwareprovider>(o => o.id == id);
		}

        /// <summary>
        /// Load softwareprovider entities from the database using the ProductIdDDB field
        /// </summary>
        /// <param name="productIdDDB">int</param>
        /// <returns>IList<Isoftwareprovider></returns>
		public virtual IList<Isoftwareprovider> LoadByProductIdDDB(int productIdDDB)
		{
			return this.UnitOfWork.AllMatching<softwareprovider>(o => o.ProductIdDDB == productIdDDB).ToList<Isoftwareprovider>();
		}

        /// <summary>
        /// Load all softwareprovider entities from the database.
        /// </summary>
        /// <returns>IList<Isoftwareprovider></returns>
		public virtual IList<Isoftwareprovider> LoadAll()
		{
			return this.UnitOfWork.GetAll<softwareprovider>().ToList<Isoftwareprovider>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for softwareprovider entities in the database by name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<Isoftwareprovider></returns>
		public virtual IList<Isoftwareprovider> SearchByname(string name, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<softwareprovider>(o => o.name.Contains(name)).ToList<Isoftwareprovider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<softwareprovider>(o => o.name.ToLower().Contains(name.ToLower())).ToList<Isoftwareprovider>();
			}
		}

        /// <summary>
        /// Search for softwareprovider entities in the database by x1
        /// </summary>
        /// <param name="x1">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<Isoftwareprovider></returns>
		public virtual IList<Isoftwareprovider> SearchByx1(string x1, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<softwareprovider>(o => o.x1.Contains(x1)).ToList<Isoftwareprovider>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<softwareprovider>(o => o.x1.ToLower().Contains(x1.ToLower())).ToList<Isoftwareprovider>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the softwareprovider entity to the database.
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		public virtual bool Save(Isoftwareprovider entity)
		{
			var entityToSave = new softwareprovider(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.id = entityToSave.id;
			entity.ProductIdDDB = entityToSave.ProductIdDDB;
			entity.name = entityToSave.name;
			entity.x1 = entityToSave.x1;
			
			return result;
		}

        /// <summary>
        /// Update the softwareprovider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		public virtual bool Update(Isoftwareprovider entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<softwareprovider>(o =>  o.id == entity.id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The softwareprovider entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.ProductIdDDB != entity.ProductIdDDB) { entityToUpdate.ProductIdDDB = entity.ProductIdDDB;doUpdate = true; }
			if (entityToUpdate.name != entity.name) { entityToUpdate.name = entity.name;doUpdate = true; }
			if (entityToUpdate.x1 != entity.x1) { entityToUpdate.x1 = entity.x1;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the softwareprovider entity from the database
        /// </summary>
        /// <param name="entity">Isoftwareprovider</param>
        /// <returns>bool</returns>
		public virtual bool Delete(Isoftwareprovider entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<softwareprovider>(o =>  o.id == entity.id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The softwareprovider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the softwareprovider entity from the database
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>bool</returns>
		public virtual bool Delete( long id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<softwareprovider>(o =>  o.id == id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The softwareprovider entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
