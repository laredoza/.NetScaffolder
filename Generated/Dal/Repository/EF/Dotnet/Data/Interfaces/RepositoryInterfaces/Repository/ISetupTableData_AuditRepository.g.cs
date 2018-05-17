
// <copyright file="SetupTableData_Audit.g.cs" company="MIT">
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
	/// The SetupTableData_AuditRepository interface that defines database functions for the SetupTableData_Audit table
	/// </summary>
	public partial interface ISetupTableData_AuditRepository : IRepository<ISetupTableData_Audit>
	{
		#region Load

        /// <summary>
        /// Load the SetupTableData_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISetupTableData_Audit</returns>
		ISetupTableData_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadById(int id);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByTitle(string title);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Description field
        /// </summary>
        /// <param name="description">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByDescription(string description);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Code field
        /// </summary>
        /// <param name="code">string</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByCode(string code);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the Seq field
        /// </summary>
        /// <param name="seq">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadBySeq(Nullable<int> seq);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the SetupTableId field
        /// </summary>
        /// <param name="setuptableid">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadBySetupTableId(Nullable<int> setuptableid);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load SetupTableData_Audit entities from the database using the ParentId field
        /// </summary>
        /// <param name="parentid">Nullable<int></param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadByParentId(Nullable<int> parentid);

        /// <summary>
        /// Load all SetupTableData_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> SearchByTitle(string title, bool caseSensitive = false);

        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Description
        /// </summary>
        /// <param name="description">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> SearchByDescription(string description, bool caseSensitive = false);

        /// <summary>
        /// Search for SetupTableData_Audit entities in the database by Code
        /// </summary>
        /// <param name="code">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISetupTableData_Audit></returns>
		IList<ISetupTableData_Audit> SearchByCode(string code, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SetupTableData_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		bool Save(ISetupTableData_Audit entity);
		
        /// <summary>
        /// Update the SetupTableData_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		bool Update(ISetupTableData_Audit entity);
		
        /// <summary>
        /// Delete the SetupTableData_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISetupTableData_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ISetupTableData_Audit entity);
		
        /// <summary>
        /// Delete the SetupTableData_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
