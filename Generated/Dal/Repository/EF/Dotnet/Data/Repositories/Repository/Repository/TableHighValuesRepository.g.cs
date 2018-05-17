
// <copyright file="TableHighValues.g.cs" company="MIT">
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
	/// The TableHighValuesRepository class responsible for database functions in the TableHighValues table
	/// </summary>
	public partial class TableHighValuesRepository : UowRepository<TableHighValues> , ITableHighValuesRepository
	{		
		#region CTOR
		
		/// <summary>
        /// The constructor for TableHighValuesRepository
        /// </summary>
        /// <param name="uow">IUnitOfWork</param>
		public TableHighValuesRepository(IUnitOfWork uow) : base(uow)
		{
		}
		
		#endregion
		
		#region Load
		
        /// <summary>
        /// Load the TableHighValues entity from the database using the TableName primary key
        /// </summary>
        /// <param name="tablename">string</param>
        /// <returns>ITableHighValues</returns>
		public virtual ITableHighValues LoadByTableName(string tablename)
		{
			return this.UnitOfWork.FirstOrDefault<TableHighValues>(o => o.TableName == tablename);
		}
		
        /// <summary>
        /// Load TableHighValues entities from the database using the NextHigh field
        /// </summary>
        /// <param name="nexthigh">long</param>
        /// <returns>IList<ITableHighValues></returns>
		public virtual IList<ITableHighValues> LoadByNextHigh(long nexthigh)
		{
			return this.UnitOfWork.AllMatching<TableHighValues>(o => o.NextHigh == nexthigh).ToList<ITableHighValues>();
		}
		
        /// <summary>
        /// Load all TableHighValues entities from the database.
        /// </summary>
        /// <returns>IList<ITableHighValues></returns>
		public virtual IList<ITableHighValues> LoadAll()
		{
			return this.UnitOfWork.GetAll<TableHighValues>().ToList<ITableHighValues>();
		}
		
		#endregion

		#region Search
		
		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the TableHighValues entity to the database.
        /// </summary>
        /// <param name="entity">ITableHighValues</param>
        /// <returns>bool</returns>
		public virtual bool Save(ITableHighValues entity)
		{
			var entityToSave = new TableHighValues(entity, false);
			return this.UnitOfWork.Add(entityToSave);
		}
		
        /// <summary>
        /// Update the TableHighValues entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ITableHighValues</param>
        /// <returns>bool</returns>
		public virtual bool Update(ITableHighValues entity)
		{
			bool doUpdate = false;
			var entityToUpdate = this.UnitOfWork.FirstOrDefault<TableHighValues>(o => o.TableName == entity.TableName);
			
			if (entityToUpdate == null)
			{
				throw new Exception("The TableHighValues entity does not exist");
			}
			
			// Optimisation: Flag if any field has changed
			if (entityToUpdate.NextHigh != entity.NextHigh) { entityToUpdate.NextHigh = entity.NextHigh;doUpdate = true; }

			// Optimisation: Only execute update if a field has changed
			if (doUpdate)
			{
				return this.UnitOfWork.Modify(entityToUpdate);
			}
			
			return false;
		}
		
        /// <summary>
        /// Delete the TableHighValues entity from the database
        /// </summary>
        /// <param name="entity">ITableHighValues</param>
        /// <returns>bool</returns>
		public virtual bool Delete(ITableHighValues entity)
		{		
			var entityToDelete = this.UnitOfWork.FirstOrDefault<TableHighValues>(o => o.TableName == entity.TableName);
			
			if(entityToDelete == null)
			{
				throw new Exception("The TableHighValues entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
        /// <summary>
        /// Delete the TableHighValues entity from the database using the TableName
        /// </summary>
        /// <param name="tablename">string</param>
        /// <returns>bool</returns>
		public virtual bool DeleteByTableName(string tablename)
		{
			var entityToDelete = this.UnitOfWork.FirstOrDefault<TableHighValues>(o => o.TableName == tablename);
			
			if(entityToDelete == null)
			{
				throw new Exception("The TableHighValues entity does not exist");
			}
			
			return this.UnitOfWork.Remove(entityToDelete);
		}
		
		#endregion
	}
}
