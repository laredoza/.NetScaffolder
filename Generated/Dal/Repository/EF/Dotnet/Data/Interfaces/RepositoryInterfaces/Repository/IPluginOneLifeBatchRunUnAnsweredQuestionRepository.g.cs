
// <copyright file="PluginOneLifeBatchRunUnAnsweredQuestion.g.cs" company="MIT">
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
	/// The PluginOneLifeBatchRunUnAnsweredQuestionRepository interface that defines database functions for the PluginOneLifeBatchRunUnAnsweredQuestion table
	/// </summary>
	public partial interface IPluginOneLifeBatchRunUnAnsweredQuestionRepository : IRepository<IPluginOneLifeBatchRunUnAnsweredQuestion>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeBatchRunUnAnsweredQuestion</returns>
		IPluginOneLifeBatchRunUnAnsweredQuestion LoadById(int id);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the PluginOneLifeBatchRunPolicyId field
        /// </summary>
        /// <param name="pluginonelifebatchrunpolicyid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByPluginOneLifeBatchRunPolicyId(Nullable<int> pluginonelifebatchrunpolicyid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByQuestionProfileId(Nullable<int> questionprofileid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByText(string text);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the Title field
        /// </summary>
        /// <param name="title">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByTitle(string title);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionId(Nullable<int> sectionid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionExtRefId field
        /// </summary>
        /// <param name="sectionextrefid">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionExtRefId(string sectionextrefid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the SectionName field
        /// </summary>
        /// <param name="sectionname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadBySectionName(string sectionname);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionExtRefId field
        /// </summary>
        /// <param name="parentsectionextrefid">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionExtRefId(string parentsectionextrefid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionId field
        /// </summary>
        /// <param name="parentsectionid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionId(Nullable<int> parentsectionid);

        /// <summary>
        /// Load PluginOneLifeBatchRunUnAnsweredQuestion entities from the database using the ParentSectionName field
        /// </summary>
        /// <param name="parentsectionname">string</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadByParentSectionName(string parentsectionname);

        /// <summary>
        /// Load all PluginOneLifeBatchRunUnAnsweredQuestion entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByText(string text, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by Title
        /// </summary>
        /// <param name="title">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByTitle(string title, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by SectionExtRefId
        /// </summary>
        /// <param name="sectionextrefid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchBySectionExtRefId(string sectionextrefid, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by SectionName
        /// </summary>
        /// <param name="sectionname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchBySectionName(string sectionname, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by ParentSectionExtRefId
        /// </summary>
        /// <param name="parentsectionextrefid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByParentSectionExtRefId(string parentsectionextrefid, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeBatchRunUnAnsweredQuestion entities in the database by ParentSectionName
        /// </summary>
        /// <param name="parentsectionname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeBatchRunUnAnsweredQuestion></returns>
		IList<IPluginOneLifeBatchRunUnAnsweredQuestion> SearchByParentSectionName(string parentsectionname, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeBatchRunUnAnsweredQuestion entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifeBatchRunUnAnsweredQuestion entity);
		
        /// <summary>
        /// Update the PluginOneLifeBatchRunUnAnsweredQuestion entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifeBatchRunUnAnsweredQuestion entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeBatchRunUnAnsweredQuestion</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifeBatchRunUnAnsweredQuestion entity);
		
        /// <summary>
        /// Delete the PluginOneLifeBatchRunUnAnsweredQuestion entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
