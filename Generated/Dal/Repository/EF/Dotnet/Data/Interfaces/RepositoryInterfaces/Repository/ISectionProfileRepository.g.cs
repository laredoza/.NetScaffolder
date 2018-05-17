
// <copyright file="SectionProfile.g.cs" company="MIT">
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
	/// The SectionProfileRepository interface that defines database functions for the SectionProfile table
	/// </summary>
	public partial interface ISectionProfileRepository : IRepository<ISectionProfile>
	{
		#region Load

        /// <summary>
        /// Load the SectionProfile entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionProfile</returns>
		ISectionProfile LoadById(int id);

        /// <summary>
        /// Load SectionProfile entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load SectionProfile entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByUserName(string username);

        /// <summary>
        /// Load SectionProfile entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByTitle(string title);

        /// <summary>
        /// Load SectionProfile entities from the database using the isVisibleAtStart field
        /// </summary>
        /// <param name="isvisibleatstart">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByisVisibleAtStart(Nullable<bool> isvisibleatstart);

        /// <summary>
        /// Load SectionProfile entities from the database using the isQuestionsGrouped field
        /// </summary>
        /// <param name="isquestionsgrouped">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByisQuestionsGrouped(Nullable<bool> isquestionsgrouped);

        /// <summary>
        /// Load SectionProfile entities from the database using the CopiedFromSectionProfileTitle field
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle);

        /// <summary>
        /// Load SectionProfile entities from the database using the ExternalReferenceId field
        /// </summary>
        /// <param name="externalreferenceid">string</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByExternalReferenceId(string externalreferenceid);

        /// <summary>
        /// Load SectionProfile entities from the database using the PromptText field
        /// </summary>
        /// <param name="prompttext">string</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByPromptText(string prompttext);

        /// <summary>
        /// Load SectionProfile entities from the database using the isPopupWindow field
        /// </summary>
        /// <param name="ispopupwindow">Nullable<bool></param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadByisPopupWindow(Nullable<bool> ispopupwindow);

        /// <summary>
        /// Load all SectionProfile entities from the database.
        /// </summary>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for SectionProfile entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> SearchByTitle(string title, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile entities in the database by CopiedFromSectionProfileTitle
        /// </summary>
        /// <param name="copiedfromsectionprofiletitle">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> SearchByCopiedFromSectionProfileTitle(string copiedfromsectionprofiletitle, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile entities in the database by ExternalReferenceId
        /// </summary>
        /// <param name="externalreferenceid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> SearchByExternalReferenceId(string externalreferenceid, bool caseSensitive = false);

        /// <summary>
        /// Search for SectionProfile entities in the database by PromptText
        /// </summary>
        /// <param name="prompttext">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISectionProfile></returns>
		IList<ISectionProfile> SearchByPromptText(string prompttext, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionProfile entity to the database.
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		bool Save(ISectionProfile entity);
		
        /// <summary>
        /// Update the SectionProfile entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		bool Update(ISectionProfile entity);
		
        /// <summary>
        /// Delete the SectionProfile entity from the database
        /// </summary>
        /// <param name="entity">ISectionProfile</param>
        /// <returns>bool</returns>
		bool Delete(ISectionProfile entity);
		
        /// <summary>
        /// Delete the SectionProfile entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
