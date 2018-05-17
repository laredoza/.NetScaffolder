
// <copyright file="WCFLog_Audit.g.cs" company="MIT">
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
	/// The WCFLog_AuditRepository interface that defines database functions for the WCFLog_Audit table
	/// </summary>
	public partial interface IWCFLog_AuditRepository : IRepository<IWCFLog_Audit>
	{
		#region Load

        /// <summary>
        /// Load the WCFLog_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IWCFLog_Audit</returns>
		IWCFLog_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load WCFLog_Audit entities from the database using the id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadByid(int id);

        /// <summary>
        /// Load WCFLog_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadByDescription(string description);

        /// <summary>
        /// Load WCFLog_Audit entities from the database using the AdditionalDetails field
        /// </summary>
        /// <param name="additionaldetails">string</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadByAdditionalDetails(string additionaldetails);

        /// <summary>
        /// Load WCFLog_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load WCFLog_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all WCFLog_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for WCFLog_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> SearchByDescription(string description, bool caseSensitive = false);

        /// <summary>
        /// Search for WCFLog_Audit entities in the database by AdditionalDetails
        /// </summary>
        /// <param name="additionaldetails">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IWCFLog_Audit></returns>
		IList<IWCFLog_Audit> SearchByAdditionalDetails(string additionaldetails, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the WCFLog_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		bool Save(IWCFLog_Audit entity);
		
        /// <summary>
        /// Update the WCFLog_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		bool Update(IWCFLog_Audit entity);
		
        /// <summary>
        /// Delete the WCFLog_Audit entity from the database
        /// </summary>
        /// <param name="entity">IWCFLog_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IWCFLog_Audit entity);
		
        /// <summary>
        /// Delete the WCFLog_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
