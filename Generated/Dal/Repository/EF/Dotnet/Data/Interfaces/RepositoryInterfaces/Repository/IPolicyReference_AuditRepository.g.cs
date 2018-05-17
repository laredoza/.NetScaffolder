
// <copyright file="PolicyReference_Audit.g.cs" company="MIT">
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
	/// The PolicyReference_AuditRepository interface that defines database functions for the PolicyReference_Audit table
	/// </summary>
	public partial interface IPolicyReference_AuditRepository : IRepository<IPolicyReference_Audit>
	{
		#region Load

        /// <summary>
        /// Load the PolicyReference_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IPolicyReference_Audit</returns>
		IPolicyReference_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadById(int id);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadBySetupTableDataId(Nullable<int> setuptabledataid);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadByPolicyId(Nullable<int> policyid);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load PolicyReference_Audit entities from the database using the Source field
        /// </summary>
        /// <param name="source">bool</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadBySource(bool source);

        /// <summary>
        /// Load all PolicyReference_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PolicyReference_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicyReference_Audit></returns>
		IList<IPolicyReference_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PolicyReference_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IPolicyReference_Audit</param>
        /// <returns>bool</returns>
		bool Save(IPolicyReference_Audit entity);
		
        /// <summary>
        /// Update the PolicyReference_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicyReference_Audit</param>
        /// <returns>bool</returns>
		bool Update(IPolicyReference_Audit entity);
		
        /// <summary>
        /// Delete the PolicyReference_Audit entity from the database
        /// </summary>
        /// <param name="entity">IPolicyReference_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IPolicyReference_Audit entity);
		
        /// <summary>
        /// Delete the PolicyReference_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
