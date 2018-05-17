
// <copyright file="ApplicationVersion_Audit.g.cs" company="MIT">
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
	/// The ApplicationVersion_AuditRepository interface that defines database functions for the ApplicationVersion_Audit table
	/// </summary>
	public partial interface IApplicationVersion_AuditRepository : IRepository<IApplicationVersion_Audit>
	{
		#region Load

        /// <summary>
        /// Load the ApplicationVersion_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IApplicationVersion_Audit</returns>
		IApplicationVersion_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load ApplicationVersion_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadById(int id);

        /// <summary>
        /// Load ApplicationVersion_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load ApplicationVersion_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load ApplicationVersion_Audit entities from the database using the VersionNumber field
        /// </summary>
        /// <param name="versionnumber">string</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadByVersionNumber(string versionnumber);

        /// <summary>
        /// Load ApplicationVersion_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all ApplicationVersion_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ApplicationVersion_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for ApplicationVersion_Audit entities in the database by VersionNumber
        /// </summary>
        /// <param name="versionnumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicationVersion_Audit></returns>
		IList<IApplicationVersion_Audit> SearchByVersionNumber(string versionnumber, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ApplicationVersion_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IApplicationVersion_Audit</param>
        /// <returns>bool</returns>
		bool Save(IApplicationVersion_Audit entity);
		
        /// <summary>
        /// Update the ApplicationVersion_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApplicationVersion_Audit</param>
        /// <returns>bool</returns>
		bool Update(IApplicationVersion_Audit entity);
		
        /// <summary>
        /// Delete the ApplicationVersion_Audit entity from the database
        /// </summary>
        /// <param name="entity">IApplicationVersion_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IApplicationVersion_Audit entity);
		
        /// <summary>
        /// Delete the ApplicationVersion_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
