
// <copyright file="CedantUserLoadingLimit_Audit.g.cs" company="MIT">
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
	/// The CedantUserLoadingLimit_AuditRepository interface that defines database functions for the CedantUserLoadingLimit_Audit table
	/// </summary>
	public partial interface ICedantUserLoadingLimit_AuditRepository : IRepository<ICedantUserLoadingLimit_Audit>
	{
		#region Load

        /// <summary>
        /// Load the CedantUserLoadingLimit_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedantUserLoadingLimit_Audit</returns>
		ICedantUserLoadingLimit_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadById(int id);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MinPercentage field
        /// </summary>
        /// <param name="minpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByMinPercentage(Nullable<decimal> minpercentage);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MaxPercentage field
        /// </summary>
        /// <param name="maxpercentage">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByMaxPercentage(Nullable<decimal> maxpercentage);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByPremiumProfileId(Nullable<int> premiumprofileid);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MinUnit field
        /// </summary>
        /// <param name="minunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByMinUnit(Nullable<decimal> minunit);

        /// <summary>
        /// Load CedantUserLoadingLimit_Audit entities from the database using the MaxUnit field
        /// </summary>
        /// <param name="maxunit">Nullable<decimal></param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadByMaxUnit(Nullable<decimal> maxunit);

        /// <summary>
        /// Load all CedantUserLoadingLimit_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CedantUserLoadingLimit_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedantUserLoadingLimit_Audit></returns>
		IList<ICedantUserLoadingLimit_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CedantUserLoadingLimit_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		bool Save(ICedantUserLoadingLimit_Audit entity);
		
        /// <summary>
        /// Update the CedantUserLoadingLimit_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		bool Update(ICedantUserLoadingLimit_Audit entity);
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedantUserLoadingLimit_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ICedantUserLoadingLimit_Audit entity);
		
        /// <summary>
        /// Delete the CedantUserLoadingLimit_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
