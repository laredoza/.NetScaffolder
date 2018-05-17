
// <copyright file="SectionProfile_Audit.g.cs" company="MIT">
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
	/// The SectionProfile_AuditRepository interface that defines database functions for the SectionProfile_Audit table
	/// </summary>
	public partial interface ISectionProfile_AuditRepository : IRepository<ISectionProfile_Audit>
	{
		#region Load

        /// <summary>
        /// Load the SectionProfile_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISectionProfile_Audit</returns>
		ISectionProfile_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadById(int id);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByTitle(string title);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isQuestionsGrouped field
        /// </summary>
        /// <param name="isquestionsgrouped">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByisQuestionsGrouped(Nullable<bool> isquestionsgrouped);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the CopiedFromSectionProfileTitle field
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByPromptText(string prompttext);

        /// <summary>
        /// Load SectionProfile_Audit entities from the database using the isPopupWindow field
        /// </summary>
        /// <param name="ispopupwindow">Nullable<bool></param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadByisPopupWindow(Nullable<bool> ispopupwindow);

        /// <summary>
        /// Load all SectionProfile_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> SearchByTitle(string title, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by CopiedFromSectionProfileTitle
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> SearchByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile_Audit entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile_Audit></returns>
		IList<ISectionProfile_Audit> SearchByPromptText(string prompttext, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionProfile_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		bool Save(ISectionProfile_Audit entity);
		
        /// <summary>
        /// Update the SectionProfile_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		bool Update(ISectionProfile_Audit entity);
		
        /// <summary>
        /// Delete the SectionProfile_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISectionProfile_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ISectionProfile_Audit entity);
		
        /// <summary>
        /// Delete the SectionProfile_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
