
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
using Core.Base;
using Banking.Models.Interfaces;

namespace Banking.Models.Interfaces
{
	/// <summary>
	/// The StandardProductReferenceRepository interface that defines database functions for the StandardProductReference table
	/// </summary>
	public partial interface IStandardProductReferenceRepository : IRepository<IStandardProductReference>
	{
		#region Load

        /// <summary>
        /// Load the StandardProductReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IStandardProductReference</returns>
		IStandardProductReference LoadById(int id);

        /// <summary>
        /// Load all StandardProductReference entities from the database.
        /// </summary>
        /// <returns>IList<IStandardProductReference></returns>
		IList<IStandardProductReference> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StandardProductReference entity to the database.
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		bool Save(IStandardProductReference entity);
		
        /// <summary>
        /// Update the StandardProductReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		bool Update(IStandardProductReference entity);
		
        /// <summary>
        /// Delete the StandardProductReference entity from the database
        /// </summary>
        /// <param name="entity">IStandardProductReference</param>
        /// <returns>bool</returns>
		bool Delete(IStandardProductReference entity);
		
        /// <summary>
        /// Delete the StandardProductReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
