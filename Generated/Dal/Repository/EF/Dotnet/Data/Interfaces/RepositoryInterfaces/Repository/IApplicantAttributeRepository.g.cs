
// <copyright file="ApplicantAttribute.g.cs" company="MIT">
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
	/// The ApplicantAttributeRepository interface that defines database functions for the ApplicantAttribute table
	/// </summary>
	public partial interface IApplicantAttributeRepository : IRepository<IApplicantAttribute>
	{
		#region Load

        /// <summary>
        /// Load the ApplicantAttribute entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IApplicantAttribute</returns>
		IApplicantAttribute LoadById(int id);

        /// <summary>
        /// Load ApplicantAttribute entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load ApplicantAttribute entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadByUserName(string username);

        /// <summary>
        /// Load ApplicantAttribute entities from the database using the Value field
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadByValue(string value);

        /// <summary>
        /// Load ApplicantAttribute entities from the database using the ApplicantAttributeProfileId field
        /// </summary>
        /// <param name="applicantattributeprofileid">Nullable<int></param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadByApplicantAttributeProfileId(Nullable<int> applicantattributeprofileid);

        /// <summary>
        /// Load ApplicantAttribute entities from the database using the QuestionnaireId field
        /// </summary>
        /// <param name="questionnaireid">Nullable<int></param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadByQuestionnaireId(Nullable<int> questionnaireid);

        /// <summary>
        /// Load all ApplicantAttribute entities from the database.
        /// </summary>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for ApplicantAttribute entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for ApplicantAttribute entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IApplicantAttribute></returns>
		IList<IApplicantAttribute> SearchByValue(string value, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ApplicantAttribute entity to the database.
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		bool Save(IApplicantAttribute entity);
		
        /// <summary>
        /// Update the ApplicantAttribute entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		bool Update(IApplicantAttribute entity);
		
        /// <summary>
        /// Delete the ApplicantAttribute entity from the database
        /// </summary>
        /// <param name="entity">IApplicantAttribute</param>
        /// <returns>bool</returns>
		bool Delete(IApplicantAttribute entity);
		
        /// <summary>
        /// Delete the ApplicantAttribute entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
