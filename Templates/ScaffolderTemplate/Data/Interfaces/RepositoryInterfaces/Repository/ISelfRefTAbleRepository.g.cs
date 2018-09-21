
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
using Banking.Models.Interfaces;
using RepositoryEFDotnet.Core.Base;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The SelfRefTAbleRepository interface that defines database functions for the SelfRefTAble table
	/// </summary>
	public partial interface ISelfRefTAbleRepository : IRepository<ISelfRefTAble>
	{
		#region Load

        /// <summary>
        /// Load SelfRefTAble entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ISelfRefTAble</returns>
		ISelfRefTAble LoadById(int id);

        /// <summary>
        /// Load SelfRefTAble entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentId">Nullable<int></param>
        /// <returns>IList<ISelfRefTAble></returns>
		IList<ISelfRefTAble> LoadByParentId(Nullable<int> parentId);

        /// <summary>
        /// Load SelfRefTAble entities from the database using the SoftwareId field
        /// </summary>
        /// <param name="softwareId">Nullable<int></param>
        /// <returns>IList<ISelfRefTAble></returns>
		IList<ISelfRefTAble> LoadBySoftwareId(Nullable<int> softwareId);

        /// <summary>
        /// Load all SelfRefTAble entities from the database.
        /// </summary>
        /// <returns>IList<ISelfRefTAble></returns>
		IList<ISelfRefTAble> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SelfRefTAble entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISelfRefTAble></returns>
		IList<ISelfRefTAble> SearchByDescription(string description, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SelfRefTAble entity to the database.
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		bool Save(ISelfRefTAble entity);

        /// <summary>
        /// Update the SelfRefTAble entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		bool Update(ISelfRefTAble entity);
		
        /// <summary>
        /// Delete the SelfRefTAble entity from the database
        /// </summary>
        /// <param name="entity">ISelfRefTAble</param>
        /// <returns>bool</returns>
		bool Delete(ISelfRefTAble entity);

		/// <summary>
        /// Delete the SelfRefTAble entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool Delete( int id);

		#endregion
	}
}
