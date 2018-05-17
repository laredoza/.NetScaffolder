
// <copyright file="VersionSection.g.cs" company="MIT">
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
	/// The VersionSectionRepository interface that defines database functions for the VersionSection table
	/// </summary>
	public partial interface IVersionSectionRepository : IRepository<IVersionSection>
	{
		#region Load

        /// <summary>
        /// Load the VersionSection entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IVersionSection</returns>
		IVersionSection LoadById(int id);

        /// <summary>
        /// Load VersionSection entities from the database using the VersionLocked field
        /// </summary>
        /// <param name="versionlocked">Nullable<bool></param>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadByVersionLocked(Nullable<bool> versionlocked);

        /// <summary>
        /// Load VersionSection entities from the database using the ProfileVersionId field
        /// </summary>
        /// <param name="profileversionid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadByProfileVersionId(Nullable<int> profileversionid);

        /// <summary>
        /// Load VersionSection entities from the database using the SectionProfileId field
        /// </summary>
        /// <param name="sectionprofileid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadBySectionProfileId(Nullable<int> sectionprofileid);

        /// <summary>
        /// Load VersionSection entities from the database using the ParentVersionSectionId field
        /// </summary>
        /// <param name="parentversionsectionid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadByParentVersionSectionId(Nullable<int> parentversionsectionid);

        /// <summary>
        /// Load VersionSection entities from the database using the SequenceId field
        /// </summary>
        /// <param name="sequenceid">Nullable<int></param>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadBySequenceId(Nullable<int> sequenceid);

        /// <summary>
        /// Load all VersionSection entities from the database.
        /// </summary>
        /// <returns>IList<IVersionSection></returns>
		IList<IVersionSection> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the VersionSection entity to the database.
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		bool Save(IVersionSection entity);
		
        /// <summary>
        /// Update the VersionSection entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		bool Update(IVersionSection entity);
		
        /// <summary>
        /// Delete the VersionSection entity from the database
        /// </summary>
        /// <param name="entity">IVersionSection</param>
        /// <returns>bool</returns>
		bool Delete(IVersionSection entity);
		
        /// <summary>
        /// Delete the VersionSection entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
