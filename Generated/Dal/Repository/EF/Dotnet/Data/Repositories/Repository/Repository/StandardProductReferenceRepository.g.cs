
// <copyright file="StandardProductReference.g.cs" company="MIT">
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
	/// The StandardProductReferenceRepository class responsible for database functions in the StandardProductReference table
	/// </summary>
	public partial class StandardProductReferenceRepository : UowRepository<StandardProductReference> , IStandardProductReferenceRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for StandardProductReferenceRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public StandardProductReferenceRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the StandardProductReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IStandardProductReference</returns>
		public virtual IStandardProductReference LoadById(int id)
		{
			return this.UnitOfWork.FirstOrDefault<StandardProductReference>(o => o.Id == id);
		}
		
        /// <summary>
        /// Load all StandardProductReference entities from the database.
        /// </summary>
        /// <returns>IList<IStandardProductReference></returns>
		public virtual IList<IStandardProductReference> LoadAll()
		{
			return this.UnitOfWork.GetAll<StandardProductReference>().ToList<IStandardProductReference>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StandardProductReference entity to the database.
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Save(IStandardProductReference entity)
		{
			var entityToSave = new StandardProductReference(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the StandardProductReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Update(IStandardProductReference entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<StandardProductReference>(o => o.Id == entity.Id);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The StandardProductReference entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the StandardProductReference entity from the database
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		public virtual bool Delete(IStandardProductReference entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StandardProductReference>(o => o.Id == entity.Id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StandardProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the StandardProductReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public virtual bool DeleteById(int id)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<StandardProductReference>(o => o.Id == id);
			
			if(entityToDelete == null)
			{
				throw new Exception("The StandardProductReference entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
