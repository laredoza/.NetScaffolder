﻿
// <copyright file="SectionDisclosure.g.cs" company="MIT">
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
	/// The SectionDisclosureRepository interface that defines database functions for the SectionDisclosure table
	/// </summary>
	public partial interface ISectionDisclosureRepository : IRepository<ISectionDisclosure>
	{
		#region Load

        /// <summary>
        /// Load the SectionDisclosure entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionDisclosure</returns>
		ISectionDisclosure LoadById(int id);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the SectionId field
        /// </summary>
        /// <param name="sectionid">int</param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadBySectionId(int sectionid);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">int</param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadBySetupTableDataId(int setuptabledataid);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the AnswerOutcomeResultId field
        /// </summary>
        /// <param name="answeroutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadByAnswerOutcomeResultId(Nullable<int> answeroutcomeresultid);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the ConditionOutcomeResultId field
        /// </summary>
        /// <param name="conditionoutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadByConditionOutcomeResultId(Nullable<int> conditionoutcomeresultid);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the VersionOutcomeResultId field
        /// </summary>
        /// <param name="versionoutcomeresultid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadByVersionOutcomeResultId(Nullable<int> versionoutcomeresultid);

        /// <summary>
        /// Load SectionDisclosure entities from the database using the OutcomeGroupAttributeId field
        /// </summary>
        /// <param name="outcomegroupattributeid">Nullable<int></param>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadByOutcomeGroupAttributeId(Nullable<int> outcomegroupattributeid);

        /// <summary>
        /// Load all SectionDisclosure entities from the database.
        /// </summary>
        /// <returns>IList<ISectionDisclosure></returns>
		IList<ISectionDisclosure> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionDisclosure entity to the database.
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		bool Save(ISectionDisclosure entity);
		
        /// <summary>
        /// Update the SectionDisclosure entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		bool Update(ISectionDisclosure entity);
		
        /// <summary>
        /// Delete the SectionDisclosure entity from the database
        /// </summary>
        /// <param name="entity">ISectionDisclosure</param>
        /// <returns>bool</returns>
		bool Delete(ISectionDisclosure entity);
		
        /// <summary>
        /// Delete the SectionDisclosure entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
