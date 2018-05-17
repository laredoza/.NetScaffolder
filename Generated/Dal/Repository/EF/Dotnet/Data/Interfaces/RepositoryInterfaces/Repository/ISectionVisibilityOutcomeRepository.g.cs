
// <copyright file="SectionVisibilityOutcome.g.cs" company="MIT">
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
	/// The SectionVisibilityOutcomeRepository interface that defines database functions for the SectionVisibilityOutcome table
	/// </summary>
	public partial interface ISectionVisibilityOutcomeRepository : IRepository<ISectionVisibilityOutcome>
	{
		#region Load

        /// <summary>
        /// Load the SectionVisibilityOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ISectionVisibilityOutcome</returns>
		ISectionVisibilityOutcome LoadById(int id);

        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the VisibilityOption field
        /// </summary>
        /// <param name="visibilityoption">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		IList<ISectionVisibilityOutcome> LoadByVisibilityOption(Nullable<int> visibilityoption);

        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the VersionSectionId field
        /// </summary>
        /// <param name="versionsectionid">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		IList<ISectionVisibilityOutcome> LoadByVersionSectionId(Nullable<int> versionsectionid);

        /// <summary>
        /// Load SectionVisibilityOutcome entities from the database using the OutcomeEntityId field
        /// </summary>
        /// <param name="outcomeentityid">Nullable<int></param>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		IList<ISectionVisibilityOutcome> LoadByOutcomeEntityId(Nullable<int> outcomeentityid);

        /// <summary>
        /// Load all SectionVisibilityOutcome entities from the database.
        /// </summary>
        /// <returns>IList<ISectionVisibilityOutcome></returns>
		IList<ISectionVisibilityOutcome> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the SectionVisibilityOutcome entity to the database.
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		bool Save(ISectionVisibilityOutcome entity);
		
        /// <summary>
        /// Update the SectionVisibilityOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		bool Update(ISectionVisibilityOutcome entity);
		
        /// <summary>
        /// Delete the SectionVisibilityOutcome entity from the database
        /// </summary>
        /// <param name="entity">ISectionVisibilityOutcome</param>
        /// <returns>bool</returns>
		bool Delete(ISectionVisibilityOutcome entity);
		
        /// <summary>
        /// Delete the SectionVisibilityOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
