
// <copyright file="Policy_Audit.g.cs" company="MIT">
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
	/// The Policy_AuditRepository interface that defines database functions for the Policy_Audit table
	/// </summary>
	public partial interface IPolicy_AuditRepository : IRepository<IPolicy_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Policy_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>IPolicy_Audit</returns>
		IPolicy_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Policy_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadById(int id);

        /// <summary>
        /// Load Policy_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Policy_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Policy_Audit entities from the database using the PolicyNumber field
        /// </summary>
        /// <param name="policynumber">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByPolicyNumber(Nullable<int> policynumber);

        /// <summary>
        /// Load Policy_Audit entities from the database using the Premium field
        /// </summary>
        /// <param name="premium">Nullable<decimal></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByPremium(Nullable<decimal> premium);

        /// <summary>
        /// Load Policy_Audit entities from the database using the SumAssured field
        /// </summary>
        /// <param name="sumassured">Nullable<decimal></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadBySumAssured(Nullable<decimal> sumassured);

        /// <summary>
        /// Load Policy_Audit entities from the database using the ActivationDate field
        /// </summary>
        /// <param name="activationdate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByActivationDate(Nullable<DateTime> activationdate);

        /// <summary>
        /// Load Policy_Audit entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByQuestionnaireId(Nullable<int> questionnaireid);

        /// <summary>
        /// Load Policy_Audit entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load Policy_Audit entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByExternalReferenceId(string externalreferenceid);

        /// <summary>
        /// Load Policy_Audit entities from the database using the ExternalReferenceLocked field
        /// </summary>
        /// <param name="externalreferencelocked">Nullable<bool></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByExternalReferenceLocked(Nullable<bool> externalreferencelocked);

        /// <summary>
        /// Load Policy_Audit entities from the database using the AcceptedStatus field
        /// </summary>
        /// <param name="acceptedstatus">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByAcceptedStatus(Nullable<int> acceptedstatus);

        /// <summary>
        /// Load Policy_Audit entities from the database using the AcceptedDate field
        /// </summary>
        /// <param name="accepteddate">Nullable<DateTime></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByAcceptedDate(Nullable<DateTime> accepteddate);

        /// <summary>
        /// Load Policy_Audit entities from the database using the CustomerId field
        /// </summary>
        /// <param name="customerid">Nullable<int></param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByCustomerId(Nullable<int> customerid);

        /// <summary>
        /// Load Policy_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all Policy_Audit entities from the database.
        /// </summary>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Policy_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Policy_Audit entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPolicy_Audit></returns>
		IList<IPolicy_Audit> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Policy_Audit entity to the database.
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		bool Save(IPolicy_Audit entity);
		
        /// <summary>
        /// Update the Policy_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		bool Update(IPolicy_Audit entity);
		
        /// <summary>
        /// Delete the Policy_Audit entity from the database
        /// </summary>
        /// <param name="entity">IPolicy_Audit</param>
        /// <returns>bool</returns>
		bool Delete(IPolicy_Audit entity);
		
        /// <summary>
        /// Delete the Policy_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
