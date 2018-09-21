
// <copyright file="SelfRefTAble.g.cs" company="Dot Net Scaffolder">
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
	/// The SelfRefTAbleRepository class responsible for database functions in the SelfRefTAble table
	/// </summary>
	public partial class SelfRefTAbleRepository : UowRepository<SelfRefTAble> , ISelfRefTAbleRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for SelfRefTAbleRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public SelfRefTAbleRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load SelfRefTAble entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ISelfRefTAble</returns>
		public virtual ISelfRefTAble LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<SelfRefTAble>(o => o.Id == id);
		}

        /// <summary>
        /// Load SelfRefTAble entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentId">Nullable<int></param>
        /// <returns>IList<ISelfRefTAble></returns>
		public virtual IList<ISelfRefTAble> LoadByParentId(Nullable<int> parentId)
		{
			return this.UnitOfWork.AllMatching<SelfRefTAble>(o => o.ParentId == parentId).ToList<ISelfRefTAble>();
		}

        /// <summary>
        /// Load SelfRefTAble entities from the database using the SoftwareId field
        /// </summary>
        /// <param name="softwareId">Nullable<int></param>
        /// <returns>IList<ISelfRefTAble></returns>
		public virtual IList<ISelfRefTAble> LoadBySoftwareId(Nullable<int> softwareId)
		{
			return this.UnitOfWork.AllMatching<SelfRefTAble>(o => o.SoftwareId == softwareId).ToList<ISelfRefTAble>();
		}

        /// <summary>
        /// Load all SelfRefTAble entities from the database.
        /// </summary>
        /// <returns>IList<ISelfRefTAble></returns>
		public virtual IList<ISelfRefTAble> LoadAll()
		{
			return this.UnitOfWork.GetAll<SelfRefTAble>().ToList<ISelfRefTAble>();
		}
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SelfRefTAble entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISelfRefTAble></returns>
		public virtual IList<ISelfRefTAble> SearchByDescription(string description, bool caseSensitive = false)
		{		
			if(caseSensitive) 
			{
				return this.UnitOfWork.AllMatching<SelfRefTAble>(o => o.Description.Contains(description)).ToList<ISelfRefTAble>();
			}
			else
			{
				return this.UnitOfWork.AllMatching<SelfRefTAble>(o => o.Description.ToLower().Contains(description.ToLower())).ToList<ISelfRefTAble>();
			}
		}

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SelfRefTAble entity to the database.
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		public virtual bool Save(ISelfRefTAble entity)
		{
			var entityToSave = new SelfRefTAble(entity, false);
			this.UnitOfWork.Add(entityToSave);
			bool result = this.UnitOfWork.Save();
			
			// Populate passed in entity with newly saved values
			entity.Id = entityToSave.Id;
			entity.Description = entityToSave.Description;
			entity.ParentId = entityToSave.ParentId;
			entity.SoftwareId = entityToSave.SoftwareId;
			
			return result;
		}

        /// <summary>
        /// Update the SelfRefTAble entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		public virtual bool Update(ISelfRefTAble entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<SelfRefTAble>(o =>  o.Id == entity.Id );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The SelfRefTAble entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.Description != entity.Description) { entityToUpdate.Description = entity.Description;doUpdate = true; }
			if (entityToUpdate.ParentId != entity.ParentId) { entityToUpdate.ParentId = entity.ParentId;doUpdate = true; }
			if (entityToUpdate.SoftwareId != entity.SoftwareId) { entityToUpdate.SoftwareId = entity.SoftwareId;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the SelfRefTAble entity from the database
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ISelfRefTAble entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SelfRefTAble>(o =>  o.Id == entity.Id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The SelfRefTAble entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the SelfRefTAble entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<SelfRefTAble>(o =>  o.Id == id );
			
			if(entityToDelete == null)
			{
				throw new Exception("The SelfRefTAble entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
