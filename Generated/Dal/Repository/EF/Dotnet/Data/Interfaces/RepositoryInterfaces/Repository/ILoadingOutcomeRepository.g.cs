
// <copyright file="LoadingOutcome.g.cs" company="MIT">
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
	/// The LoadingOutcomeRepository interface that defines database functions for the LoadingOutcome table
	/// </summary>
	public partial interface ILoadingOutcomeRepository : IRepository<ILoadingOutcome>
	{
		#region Load

        /// <summary>
        /// Load the LoadingOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ILoadingOutcome</returns>
		ILoadingOutcome LoadById(int id);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the MathOption field
        /// </summary>
        /// <param name="mathoption">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByMathOption(Nullable<int> mathoption);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the PercentageValue field
        /// </summary>
        /// <param name="percentagevalue">Nullable<decimal></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByPercentageValue(Nullable<decimal> percentagevalue);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByProductProfileId(Nullable<int> productprofileid);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByPremiumProfileId(Nullable<int> premiumprofileid);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByTypeOption(int typeoption);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the UnitValue field
        /// </summary>
        /// <param name="unitvalue">Nullable<decimal></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByUnitValue(Nullable<decimal> unitvalue);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the PeriodOption field
        /// </summary>
        /// <param name="periodoption">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByPeriodOption(Nullable<int> periodoption);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the MonthFrom field
        /// </summary>
        /// <param name="monthfrom">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByMonthFrom(Nullable<int> monthfrom);

        /// <summary>
        /// Load LoadingOutcome entities from the database using the YearFrom field
        /// </summary>
        /// <param name="yearfrom">Nullable<int></param>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadByYearFrom(Nullable<int> yearfrom);

        /// <summary>
        /// Load all LoadingOutcome entities from the database.
        /// </summary>
        /// <returns>IList<ILoadingOutcome></returns>
		IList<ILoadingOutcome> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the LoadingOutcome entity to the database.
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		bool Save(ILoadingOutcome entity);
		
        /// <summary>
        /// Update the LoadingOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		bool Update(ILoadingOutcome entity);
		
        /// <summary>
        /// Delete the LoadingOutcome entity from the database
        /// </summary>
        /// <param name="entity">ILoadingOutcome</param>
        /// <returns>bool</returns>
		bool Delete(ILoadingOutcome entity);
		
        /// <summary>
        /// Delete the LoadingOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
