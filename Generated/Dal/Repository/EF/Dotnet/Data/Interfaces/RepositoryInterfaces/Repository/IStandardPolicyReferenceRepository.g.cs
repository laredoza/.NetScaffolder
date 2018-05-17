
// <copyright file="StandardPolicyReference.g.cs" company="MIT">
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
	/// The StandardPolicyReferenceRepository interface that defines database functions for the StandardPolicyReference table
	/// </summary>
	public partial interface IStandardPolicyReferenceRepository : IRepository<IStandardPolicyReference>
	{
		#region Load

        /// <summary>
        /// Load the StandardPolicyReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IStandardPolicyReference</returns>
		IStandardPolicyReference LoadById(int id);

        /// <summary>
        /// Load all StandardPolicyReference entities from the database.
        /// </summary>
        /// <returns>IList<IStandardPolicyReference></returns>
		IList<IStandardPolicyReference> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the StandardPolicyReference entity to the database.
        /// </summary>
        /// <param name="entity">IStandardPolicyReference</param>
        /// <returns>bool</returns>
		bool Save(IStandardPolicyReference entity);
		
        /// <summary>
        /// Update the StandardPolicyReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IStandardPolicyReference</param>
        /// <returns>bool</returns>
		bool Update(IStandardPolicyReference entity);
		
        /// <summary>
        /// Delete the StandardPolicyReference entity from the database
        /// </summary>
        /// <param name="entity">IStandardPolicyReference</param>
        /// <returns>bool</returns>
		bool Delete(IStandardPolicyReference entity);
		
        /// <summary>
        /// Delete the StandardPolicyReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
