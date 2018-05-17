
// <copyright file="Cedant.g.cs" company="MIT">
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
	/// The CedantRepository interface that defines database functions for the Cedant table
	/// </summary>
	public partial interface ICedantRepository : IRepository<ICedant>
	{
		#region Load

        /// <summary>
        /// Load the Cedant entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICedant</returns>
		ICedant LoadById(int id);

        /// <summary>
        /// Load Cedant entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Cedant entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByUserName(string username);

        /// <summary>
        /// Load Cedant entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByName(string name);

        /// <summary>
        /// Load Cedant entities from the database using the TimeLimit field
        /// </summary>
        /// <param name="timelimit">Nullable<long></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByTimeLimit(Nullable<long> timelimit);

        /// <summary>
        /// Load Cedant entities from the database using the isChangeLimited field
        /// </summary>
        /// <param name="ischangelimited">Nullable<bool></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByisChangeLimited(Nullable<bool> ischangelimited);

        /// <summary>
        /// Load Cedant entities from the database using the RemainingChanges field
        /// </summary>
        /// <param name="remainingchanges">Nullable<int></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByRemainingChanges(Nullable<int> remainingchanges);

        /// <summary>
        /// Load Cedant entities from the database using the LimitInternetUserOnly field
        /// </summary>
        /// <param name="limitinternetuseronly">Nullable<bool></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByLimitInternetUserOnly(Nullable<bool> limitinternetuseronly);

        /// <summary>
        /// Load Cedant entities from the database using the BannerImage field
        /// </summary>
        /// <param name="bannerimage">byte[]</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByBannerImage(byte[] bannerimage);

        /// <summary>
        /// Load Cedant entities from the database using the BannerImageType field
        /// </summary>
        /// <param name="bannerimagetype">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByBannerImageType(string bannerimagetype);

        /// <summary>
        /// Load Cedant entities from the database using the TermsConditions field
        /// </summary>
        /// <param name="termsconditions">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByTermsConditions(string termsconditions);

        /// <summary>
        /// Load Cedant entities from the database using the ReportName field
        /// </summary>
        /// <param name="reportname">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByReportName(string reportname);

        /// <summary>
        /// Load Cedant entities from the database using the License field
        /// </summary>
        /// <param name="license">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByLicense(string license);

        /// <summary>
        /// Load Cedant entities from the database using the Validator field
        /// </summary>
        /// <param name="validator">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByValidator(string validator);

        /// <summary>
        /// Load Cedant entities from the database using the LicenseKey field
        /// </summary>
        /// <param name="licensekey">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByLicenseKey(string licensekey);

        /// <summary>
        /// Load Cedant entities from the database using the LicenseSalt field
        /// </summary>
        /// <param name="licensesalt">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByLicenseSalt(string licensesalt);

        /// <summary>
        /// Load Cedant entities from the database using the CedantUniqueIdentifier field
        /// </summary>
        /// <param name="cedantuniqueidentifier">Nullable<Guid></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByCedantUniqueIdentifier(Nullable<Guid> cedantuniqueidentifier);

        /// <summary>
        /// Load Cedant entities from the database using the ExclusionSetupTableName field
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByExclusionSetupTableName(string exclusionsetuptablename);

        /// <summary>
        /// Load Cedant entities from the database using the PostponementSetupTableName field
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByPostponementSetupTableName(string postponementsetuptablename);

        /// <summary>
        /// Load Cedant entities from the database using the QuestionnaireProfileVersionId field
        /// </summary>
        /// <param name="questionnaireprofileversionid">Nullable<int></param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByQuestionnaireProfileVersionId(Nullable<int> questionnaireprofileversionid);

        /// <summary>
        /// Load Cedant entities from the database using the LoadingUrl field
        /// </summary>
        /// <param name="loadingurl">string</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadByLoadingUrl(string loadingurl);

        /// <summary>
        /// Load all Cedant entities from the database.
        /// </summary>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Cedant entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by BannerImageType
        /// </summary>
        /// <param name="bannerimagetype">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByBannerImageType(string bannerimagetype, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by TermsConditions
        /// </summary>
        /// <param name="termsconditions">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByTermsConditions(string termsconditions, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by ReportName
        /// </summary>
        /// <param name="reportname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByReportName(string reportname, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by License
        /// </summary>
        /// <param name="license">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByLicense(string license, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by Validator
        /// </summary>
        /// <param name="validator">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByValidator(string validator, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by LicenseKey
        /// </summary>
        /// <param name="licensekey">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByLicenseKey(string licensekey, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by LicenseSalt
        /// </summary>
        /// <param name="licensesalt">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByLicenseSalt(string licensesalt, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by ExclusionSetupTableName
        /// </summary>
        /// <param name="exclusionsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByExclusionSetupTableName(string exclusionsetuptablename, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by PostponementSetupTableName
        /// </summary>
        /// <param name="postponementsetuptablename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByPostponementSetupTableName(string postponementsetuptablename, bool caseSensitive = false);

        /// <summary>
        /// Search for Cedant entities in the database by LoadingUrl
        /// </summary>
        /// <param name="loadingurl">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICedant></returns>
		IList<ICedant> SearchByLoadingUrl(string loadingurl, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Cedant entity to the database.
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		bool Save(ICedant entity);
		
        /// <summary>
        /// Update the Cedant entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		bool Update(ICedant entity);
		
        /// <summary>
        /// Delete the Cedant entity from the database
        /// </summary>
        /// <param name="entity">ICedant</param>
        /// <returns>bool</returns>
		bool Delete(ICedant entity);
		
        /// <summary>
        /// Delete the Cedant entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
