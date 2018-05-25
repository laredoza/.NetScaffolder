
// <copyright file="CompositeKeyTest.g.cs" company="MIT">
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
using RepositoryEFDotnet.Core.Base;
using System.Linq;
using Banking.Models.Interfaces;
using Banking.Models.Entity;

namespace Banking.Models.Repository
{
	/// <summary>
	/// The CompositeKeyTestRepository class responsible for database functions in the CompositeKeyTest table
	/// </summary>
	public partial class CompositeKeyTestRepository : UowRepository<CompositeKeyTest> , ICompositeKeyTestRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for CompositeKeyTestRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public CompositeKeyTestRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load

        /// <summary>
        /// Load CompositeKeyTest entities from the database using the composite primary keys
        /// </summary
        /// <param name="primaryCol1">int</param>
        /// <param name="primaryCol2">int</param>
        /// <returns>ICompositeKeyTest</returns>
		public virtual ICompositeKeyTest Load( int primaryCol1,  int primaryCol2)
		{
			return this.UnitOfWork.FirstOrDefault<CompositeKeyTest>(o =>  o.PrimaryCol1 == primaryCol1 &&  o.PrimaryCol2 == primaryCol2 );
		}

        /// <summary>
        /// Load all CompositeKeyTest entities from the database.
        /// </summary>
        /// <returns>IList<ICompositeKeyTest></returns>
		public virtual IList<ICompositeKeyTest> LoadAll()
		{
			return this.UnitOfWork.GetAll<CompositeKeyTest>().ToList<ICompositeKeyTest>();
		}
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CompositeKeyTest entity to the database.
        /// </summary>
        /// <param name="entity">ICompositeKeyTest</param>
        /// <returns>bool</returns>
		public virtual bool Save(ICompositeKeyTest entity)
		{
			var entityToSave = new CompositeKeyTest(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}

        /// <summary>
        /// Update the CompositeKeyTest entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICompositeKeyTest</param>
        /// <returns>bool</returns>
		public virtual bool Update(ICompositeKeyTest entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<CompositeKeyTest>(o =>  o.PrimaryCol1 == entity.PrimaryCol1 &&  o.PrimaryCol2 == entity.PrimaryCol2 );
			
			if (entityToUpdate == null)
			{
				throw new Exception("The CompositeKeyTest entity does not exist");
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
        /// Delete the CompositeKeyTest entity from the database
        /// </summary>
        /// <param name="entity">ICompositeKeyTest</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ICompositeKeyTest entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CompositeKeyTest>(o =>  o.PrimaryCol1 == entity.PrimaryCol1 &&  o.PrimaryCol2 == entity.PrimaryCol2 );
			
			if(entityToDelete == null)
			{
				throw new Exception("The CompositeKeyTest entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}

		/// <summary>
        /// Delete the CompositeKeyTest entity from the database
        /// </summary>
        /// <param name="primaryCol1">int</param>
        /// <param name="primaryCol2">int</param>
        /// <returns>bool</returns>
		public virtual bool Delete( int primaryCol1,  int primaryCol2)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<CompositeKeyTest>(o =>  o.PrimaryCol1 == primaryCol1 &&  o.PrimaryCol2 == primaryCol2 );
			
			if(entityToDelete == null)
			{
				throw new Exception("The CompositeKeyTest entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
