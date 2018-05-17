
// <copyright file="PluginOneLifeMapping.g.cs" company="MIT">
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
	/// The PluginOneLifeMappingRepository interface that defines database functions for the PluginOneLifeMapping table
	/// </summary>
	public partial interface IPluginOneLifeMappingRepository : IRepository<IPluginOneLifeMapping>
	{
		#region Load

        /// <summary>
        /// Load the PluginOneLifeMapping entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPluginOneLifeMapping</returns>
		IPluginOneLifeMapping LoadById(int id);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByUserName(string username);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the PluginOneLifeCedantId field
        /// </summary>
        /// <param name="pluginonelifecedantid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByPluginOneLifeCedantId(Nullable<int> pluginonelifecedantid);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the MappingID field
        /// </summary>
        /// <param name="mappingid">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByMappingID(string mappingid);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Category field
        /// </summary>
        /// <param name="category">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByCategory(string category);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Section field
        /// </summary>
        /// <param name="section">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadBySection(string section);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Text field
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByText(string text);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Min field
        /// </summary>
        /// <param name="min">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByMin(string min);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Max field
        /// </summary>
        /// <param name="max">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByMax(string max);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadBySectionProfileId(Nullable<int> sectionprofileid);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the SectionProfile field
        /// </summary>
        /// <param name="sectionprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadBySectionProfile(string sectionprofile);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the QuestionProfileId field
        /// </summary>
        /// <param name="questionprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByQuestionProfileId(Nullable<int> questionprofileid);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the QuestionProfile field
        /// </summary>
        /// <param name="questionprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByQuestionProfile(string questionprofile);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the AnswerProfileId field
        /// </summary>
        /// <param name="answerprofileid">Nullable<int></param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByAnswerProfileId(Nullable<int> answerprofileid);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the AnswerProfile field
        /// </summary>
        /// <param name="answerprofile">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByAnswerProfile(string answerprofile);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the ExternalRef field
        /// </summary>
        /// <param name="externalref">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByExternalRef(string externalref);

        /// <summary>
        /// Load PluginOneLifeMapping entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadByValue(string value);

        /// <summary>
        /// Load all PluginOneLifeMapping entities from the database.
        /// </summary>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by MappingID
        /// </summary>
        /// <param name="mappingid">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByMappingID(string mappingid, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Category
        /// </summary>
        /// <param name="category">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByCategory(string category, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Section
        /// </summary>
        /// <param name="section">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchBySection(string section, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Text
        /// </summary>
        /// <param name="text">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByText(string text, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Min
        /// </summary>
        /// <param name="min">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByMin(string min, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Max
        /// </summary>
        /// <param name="max">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByMax(string max, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by SectionProfile
        /// </summary>
        /// <param name="sectionprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchBySectionProfile(string sectionprofile, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by QuestionProfile
        /// </summary>
        /// <param name="questionprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByQuestionProfile(string questionprofile, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by AnswerProfile
        /// </summary>
        /// <param name="answerprofile">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByAnswerProfile(string answerprofile, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by ExternalRef
        /// </summary>
        /// <param name="externalref">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByExternalRef(string externalref, bool caseSensitive = false);

        /// <summary>
        /// Search for PluginOneLifeMapping entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPluginOneLifeMapping></returns>
		IList<IPluginOneLifeMapping> SearchByValue(string value, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PluginOneLifeMapping entity to the database.
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		bool Save(IPluginOneLifeMapping entity);
		
        /// <summary>
        /// Update the PluginOneLifeMapping entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		bool Update(IPluginOneLifeMapping entity);
		
        /// <summary>
        /// Delete the PluginOneLifeMapping entity from the database
        /// </summary>
        /// <param name="entity">IPluginOneLifeMapping</param>
        /// <returns>bool</returns>
		bool Delete(IPluginOneLifeMapping entity);
		
        /// <summary>
        /// Delete the PluginOneLifeMapping entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
