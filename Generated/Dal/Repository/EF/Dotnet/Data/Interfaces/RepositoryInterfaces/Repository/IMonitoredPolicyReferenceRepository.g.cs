
// <copyright file="MonitoredPolicyReference.g.cs" company="MIT">
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
	/// The MonitoredPolicyReferenceRepository interface that defines database functions for the MonitoredPolicyReference table
	/// </summary>
	public partial interface IMonitoredPolicyReferenceRepository : IRepository<IMonitoredPolicyReference>
	{
		#region Load

        /// <summary>
        /// Load the MonitoredPolicyReference entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IMonitoredPolicyReference</returns>
		IMonitoredPolicyReference LoadById(int id);

        /// <summary>
        /// Load MonitoredPolicyReference entities from the database using the State field
        /// </summary>
        /// <param name="state">Nullable<int></param>
        /// <returns>IList<IMonitoredPolicyReference></returns>
		IList<IMonitoredPolicyReference> LoadByState(Nullable<int> state);

        /// <summary>
        /// Load all MonitoredPolicyReference entities from the database.
        /// </summary>
        /// <returns>IList<IMonitoredPolicyReference></returns>
		IList<IMonitoredPolicyReference> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the MonitoredPolicyReference entity to the database.
        /// </summary>
        /// <param name="entity">IMonitoredPolicyReference</param>
        /// <returns>bool</returns>
		bool Save(IMonitoredPolicyReference entity);
		
        /// <summary>
        /// Update the MonitoredPolicyReference entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IMonitoredPolicyReference</param>
        /// <returns>bool</returns>
		bool Update(IMonitoredPolicyReference entity);
		
        /// <summary>
        /// Delete the MonitoredPolicyReference entity from the database
        /// </summary>
        /// <param name="entity">IMonitoredPolicyReference</param>
        /// <returns>bool</returns>
		bool Delete(IMonitoredPolicyReference entity);
		
        /// <summary>
        /// Delete the MonitoredPolicyReference entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
