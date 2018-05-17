
// <copyright file="Section_Audit.g.cs" company="MIT">
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
	/// The Section_AuditRepository interface that defines database functions for the Section_Audit table
	/// </summary>
	public partial interface ISection_AuditRepository : IRepository<ISection_Audit>
	{
		#region Load

        /// <summary>
        /// Load the Section_Audit entity from the database using the Audit_Id primary key
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>ISection_Audit</returns>
		ISection_Audit LoadByAudit_Id(int audit_id);

        /// <summary>
        /// Load Section_Audit entities from the database using the Id field
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadById(int id);

        /// <summary>
        /// Load Section_Audit entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">DateTime</param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByStamp(DateTime stamp);

        /// <summary>
        /// Load Section_Audit entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByUserName(string username);

        /// <summary>
        /// Load Section_Audit entities from the database using the isVisible field
        /// </summary>
        /// <param name="isvisible">Nullable<bool></param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByisVisible(Nullable<bool> isvisible);

        /// <summary>
        /// Load Section_Audit entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByQuestionnaireId(Nullable<int> questionnaireid);

        /// <summary>
        /// Load Section_Audit entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadBySectionProfileId(Nullable<int> sectionprofileid);

        /// <summary>
        /// Load Section_Audit entities from the database using the SectionVersionId field
        /// </summary>
        /// <param name="sectionversionid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadBySectionVersionId(Nullable<int> sectionversionid);

        /// <summary>
        /// Load Section_Audit entities from the database using the ParentSectionId field
        /// </summary>
        /// <param name="parentsectionid">Nullable<int></param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByParentSectionId(Nullable<int> parentsectionid);

        /// <summary>
        /// Load Section_Audit entities from the database using the AuditTrailType field
        /// </summary>
        /// <param name="audittrailtype">int</param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadByAuditTrailType(int audittrailtype);

        /// <summary>
        /// Load all Section_Audit entities from the database.
        /// </summary>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Section_Audit entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISection_Audit></returns>
		IList<ISection_Audit> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Section_Audit entity to the database.
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		bool Save(ISection_Audit entity);
		
        /// <summary>
        /// Update the Section_Audit entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		bool Update(ISection_Audit entity);
		
        /// <summary>
        /// Delete the Section_Audit entity from the database
        /// </summary>
        /// <param name="entity">ISection_Audit</param>
        /// <returns>bool</returns>
		bool Delete(ISection_Audit entity);
		
        /// <summary>
        /// Delete the Section_Audit entity from the database using the Audit_Id
        /// </summary>
        /// <param name="audit_id">int</param>
        /// <returns>bool</returns>
		bool DeleteByAudit_Id(int audit_id);

		#endregion
	}
}
