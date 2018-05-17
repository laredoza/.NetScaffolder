
// <copyright file="OutcomeResult.g.cs" company="MIT">
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
	/// The OutcomeResultRepository interface that defines database functions for the OutcomeResult table
	/// </summary>
	public partial interface IOutcomeResultRepository : IRepository<IOutcomeResult>
	{
		#region Load

        /// <summary>
        /// Load the OutcomeResult entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IOutcomeResult</returns>
		IOutcomeResult LoadById(int id);

        /// <summary>
        /// Load OutcomeResult entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load OutcomeResult entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByUserName(string username);

        /// <summary>
        /// Load OutcomeResult entities from the database using the HadEffect field
        /// </summary>
        /// <param name="hadeffect">Nullable<bool></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByHadEffect(Nullable<bool> hadeffect);

        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectPercentageValue field
        /// </summary>
        /// <param name="effectpercentagevalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByEffectPercentageValue(Nullable<decimal> effectpercentagevalue);

        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectDescription field
        /// </summary>
        /// <param name="effectdescription">string</param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByEffectDescription(string effectdescription);

        /// <summary>
        /// Load OutcomeResult entities from the database using the OutcomeId field
        /// </summary>
        /// <param name="outcomeid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByOutcomeId(Nullable<int> outcomeid);

        /// <summary>
        /// Load OutcomeResult entities from the database using the PremiumId field
        /// </summary>
        /// <param name="premiumid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByPremiumId(Nullable<int> premiumid);

        /// <summary>
        /// Load OutcomeResult entities from the database using the PolicyId field
        /// </summary>
        /// <param name="policyid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByPolicyId(Nullable<int> policyid);

        /// <summary>
        /// Load OutcomeResult entities from the database using the UserId field
        /// </summary>
        /// <param name="userid">Nullable<int></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByUserId(Nullable<int> userid);

        /// <summary>
        /// Load OutcomeResult entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByTypeOption(int typeoption);

        /// <summary>
        /// Load OutcomeResult entities from the database using the EffectUnitValue field
        /// </summary>
        /// <param name="effectunitvalue">Nullable<decimal></param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadByEffectUnitValue(Nullable<decimal> effectunitvalue);

        /// <summary>
        /// Load all OutcomeResult entities from the database.
        /// </summary>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for OutcomeResult entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for OutcomeResult entities in the database by EffectDescription
        /// </summary>
        /// <param name="effectdescription">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IOutcomeResult></returns>
		IList<IOutcomeResult> SearchByEffectDescription(string effectdescription, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the OutcomeResult entity to the database.
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		bool Save(IOutcomeResult entity);
		
        /// <summary>
        /// Update the OutcomeResult entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		bool Update(IOutcomeResult entity);
		
        /// <summary>
        /// Delete the OutcomeResult entity from the database
        /// </summary>
        /// <param name="entity">IOutcomeResult</param>
        /// <returns>bool</returns>
		bool Delete(IOutcomeResult entity);
		
        /// <summary>
        /// Delete the OutcomeResult entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
