﻿
// <copyright file="PolicyReference.g.cs" company="MIT">
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
	/// The PolicyReferenceRepository interface that defines database functions for the PolicyReference table
	/// </summary>
	public partial interface IPolicyReferenceRepository : IRepository<IPolicyReference>
	{
		#region Load

        /// <summary>
        /// Load the PolicyReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPolicyReference</returns>
		IPolicyReference LoadById(int id);

        /// <summary>
        /// Load PolicyReference entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PolicyReference entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadByUserName(string username);

        /// <summary>
        /// Load PolicyReference entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadBySetupTableDataId(Nullable<int> setuptabledataid);

        /// <summary>
        /// Load PolicyReference entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadByPolicyId(Nullable<int> policyid);

        /// <summary>
        /// Load PolicyReference entities from the database using the Source field
        /// </summary>
        /// <param name="source">bool</param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadBySource(bool source);

        /// <summary>
        /// Load all PolicyReference entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PolicyReference entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicyReference></returns>
		IList<IPolicyReference> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyReference entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		bool Save(IPolicyReference entity);
		
        /// <summary>
        /// Update the PolicyReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		bool Update(IPolicyReference entity);
		
        /// <summary>
        /// Delete the PolicyReference entity from the database
        /// </summary>
        /// <param name="entity">IPolicyReference</param>
        /// <returns>bool</returns>
		bool Delete(IPolicyReference entity);
		
        /// <summary>
        /// Delete the PolicyReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
