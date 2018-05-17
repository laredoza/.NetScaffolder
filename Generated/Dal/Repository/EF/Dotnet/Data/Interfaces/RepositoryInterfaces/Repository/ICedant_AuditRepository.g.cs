
// <copyright file="Cedant_Audit.g.cs" company="MIT">
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
	/// The Cedant_AuditRepository interface that defines database functions for the Cedant_Audit table
	/// </summary>
	public partial interface ICedant_AuditRepository : IRepository<ICedant_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Cedant_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ICedant_Audit</returns>
		ICedant_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadById(int id);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByName(string name);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the TimeLimit field
        /// </summary>
        /// <param name="timelimit">Nullable<long></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByTimeLimit(Nullable<long> timelimit);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the isChangeLimited field
        /// </summary>
        /// <param name="ischangelimited">Nullable<bool></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByisChangeLimited(Nullable<bool> ischangelimited);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByRemainingChanges(Nullable<int> remainingchanges);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the LimitInternetUserOnly field
        /// </summary>
        /// <param name="limitinternetuseronly">Nullable<bool></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByLimitInternetUserOnly(Nullable<bool> limitinternetuseronly);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the BannerImage field
        /// </summary>
        /// <param name="bannerimage">byte[]</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByBannerImage(byte[] bannerimage);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the BannerImageType field
        /// </summary>
        /// <param name="bannerimagetype">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByBannerImageType(string bannerimagetype);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the TermsConditions field
        /// </summary>
        /// <param name="termsconditions">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByTermsConditions(string termsconditions);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the ReportName field
        /// </summary>
        /// <param name="reportname">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByReportName(string reportname);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the License field
        /// </summary>
        /// <param name="license">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByLicense(string license);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the Validator field
        /// </summary>
        /// <param name="validator">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByValidator(string validator);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the LicenseKey field
        /// </summary>
        /// <param name="licensekey">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByLicenseKey(string licensekey);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the LicenseSalt field
        /// </summary>
        /// <param name="licensesalt">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByLicenseSalt(string licensesalt);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the CedantUniqueIdentifier field
        /// </summary>
        /// <param name="cedantuniqueidentifier">Nullable<Guid></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByCedantUniqueIdentifier(Nullable<Guid> cedantuniqueidentifier);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the ExclusionSetupTableName field
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByExclusionSetupTableName(string exclusionsetuptablename);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the PostponementSetupTableName field
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByPostponementSetupTableName(string postponementsetuptablename);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid);

        /// <summary>
        /// Load Cedant_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all Cedant_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Cedant_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by BannerImageType
        /// </summary>
        /// <param name="bannerimagetype">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByBannerImageType(string bannerimagetype, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by TermsConditions
        /// </summary>
        /// <param name="termsconditions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByTermsConditions(string termsconditions, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by ReportName
        /// </summary>
        /// <param name="reportname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByReportName(string reportname, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by License
        /// </summary>
        /// <param name="license">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByLicense(string license, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by Validator
        /// </summary>
        /// <param name="validator">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByValidator(string validator, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by LicenseKey
        /// </summary>
        /// <param name="licensekey">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByLicenseKey(string licensekey, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by LicenseSalt
        /// </summary>
        /// <param name="licensesalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByLicenseSalt(string licensesalt, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by ExclusionSetupTableName
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByExclusionSetupTableName(string exclusionsetuptablename, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant_Audit entities in the database by PostponementSetupTableName
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant_Audit></returns>
		IList<ICedant_Audit> SearchByPostponementSetupTableName(string postponementsetuptablename, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Cedant_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		bool Save(ICedant_Audit entity);
		
        /// <summary>
        /// Update the Cedant_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		bool Update(ICedant_Audit entity);
		
        /// <summary>
        /// Delete the Cedant_Audit entity from the database
        /// </summary>
        /// <param name="entity">ICedant_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ICedant_Audit entity);
		
        /// <summary>
        /// Delete the Cedant_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
