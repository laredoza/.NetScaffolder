
// <copyright file="ScoringOutcome.g.cs" company="MIT">
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
	/// The ScoringOutcomeRepository interface that defines database functions for the ScoringOutcome table
	/// </summary>
	public partial interface IScoringOutcomeRepository : IRepository<IScoringOutcome>
	{
		#region Load

        /// <summary>
        /// Load the ScoringOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IScoringOutcome</returns>
		IScoringOutcome LoadById(int id);

        /// <summary>
        /// Load ScoringOutcome entities from the database using the MathOption field
        /// </summary>
        /// <param name="mathoption">Nullable<int></param>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadByMathOption(Nullable<int> mathoption);

        /// <summary>
        /// Load ScoringOutcome entities from the database using the UnitValue field
        /// </summary>
        /// <param name="unitvalue">Nullable<decimal></param>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadByUnitValue(Nullable<decimal> unitvalue);

        /// <summary>
        /// Load ScoringOutcome entities from the database using the AttributeProfileId field
        /// </summary>
        /// <param name="attributeprofileid">Nullable<int></param>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadByAttributeProfileId(Nullable<int> attributeprofileid);

        /// <summary>
        /// Load ScoringOutcome entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadByTypeOption(int typeoption);

        /// <summary>
        /// Load ScoringOutcome entities from the database using the PercentageValue field
        /// </summary>
        /// <param name="percentagevalue">Nullable<decimal></param>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadByPercentageValue(Nullable<decimal> percentagevalue);

        /// <summary>
        /// Load all ScoringOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IScoringOutcome></returns>
		IList<IScoringOutcome> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ScoringOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		bool Save(IScoringOutcome entity);
		
        /// <summary>
        /// Update the ScoringOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		bool Update(IScoringOutcome entity);
		
        /// <summary>
        /// Delete the ScoringOutcome entity from the database
        /// </summary>
        /// <param name="entity">IScoringOutcome</param>
        /// <returns>bool</returns>
		bool Delete(IScoringOutcome entity);
		
        /// <summary>
        /// Delete the ScoringOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
