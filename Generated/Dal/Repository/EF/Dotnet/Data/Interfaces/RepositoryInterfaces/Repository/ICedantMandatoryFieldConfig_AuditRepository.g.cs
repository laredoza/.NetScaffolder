
// <copyright file="CedantMandatoryFieldConfig_Audit.g.cs" company="MIT">
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
	/// The CedantMandatoryFieldConfig_AuditRepository interface that defines database functions for the CedantMandatoryFieldConfig_Audit table
	/// </summary>
	public partial interface ICedantMandatoryFieldConfig_AuditRepository : IRepository<ICedantMandatoryFieldConfig_Audit>
	{
		#region Load

        /// <summary>
        /// Load the CedantMandatoryFieldConfig_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedantMandatoryFieldConfig_Audit</returns>
		ICedantMandatoryFieldConfig_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadById(int id);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Type field
        /// </summary>
        /// <param name="type">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByType(Nullable<int> type);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Length field
        /// </summary>
        /// <param name="length">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByLength(Nullable<int> length);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Sequence field
        /// </summary>
        /// <param name="sequence">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadBySequence(Nullable<int> sequence);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the CedantMandatoryFieldId field
        /// </summary>
        /// <param name="cedantmandatoryfieldid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByCedantMandatoryFieldId(Nullable<int> cedantmandatoryfieldid);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the ProviderId field
        /// </summary>
        /// <param name="providerid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByProviderId(Nullable<int> providerid);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the ApplicantAttributeId field
        /// </summary>
        /// <param name="applicantattributeid">Nullable<int></param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByApplicantAttributeId(Nullable<int> applicantattributeid);

        /// <summary>
        /// Load CedantMandatoryFieldConfig_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all CedantMandatoryFieldConfig_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CedantMandatoryFieldConfig_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantMandatoryFieldConfig_Audit></returns>
		IList<ICedantMandatoryFieldConfig_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantMandatoryFieldConfig_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig_Audit</param>
        /// <returns>bool</returns>
		bool Save(ICedantMandatoryFieldConfig_Audit entity);
		
        /// <summary>
        /// Update the CedantMandatoryFieldConfig_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig_Audit</param>
        /// <returns>bool</returns>
		bool Update(ICedantMandatoryFieldConfig_Audit entity);
		
        /// <summary>
        /// Delete the CedantMandatoryFieldConfig_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedantMandatoryFieldConfig_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ICedantMandatoryFieldConfig_Audit entity);
		
        /// <summary>
        /// Delete the CedantMandatoryFieldConfig_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
