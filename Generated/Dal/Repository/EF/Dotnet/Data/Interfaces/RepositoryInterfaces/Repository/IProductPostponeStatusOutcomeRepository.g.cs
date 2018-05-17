
// <copyright file="ProductPostponeStatusOutcome.g.cs" company="MIT">
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
	/// The ProductPostponeStatusOutcomeRepository interface that defines database functions for the ProductPostponeStatusOutcome table
	/// </summary>
	public partial interface IProductPostponeStatusOutcomeRepository : IRepository<IProductPostponeStatusOutcome>
	{
		#region Load

        /// <summary>
        /// Load the ProductPostponeStatusOutcome entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IProductPostponeStatusOutcome</returns>
		IProductPostponeStatusOutcome LoadById(int id);

        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Months field
        /// </summary>
        /// <param name="months">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadByMonths(Nullable<int> months);

        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the ProductProfileId field
        /// </summary>
        /// <param name="productprofileid">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadByProductProfileId(Nullable<int> productprofileid);

        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the SetupTableDataId field
        /// </summary>
        /// <param name="setuptabledataid">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadBySetupTableDataId(Nullable<int> setuptabledataid);

        /// <summary>
        /// Load ProductPostponeStatusOutcome entities from the database using the Days field
        /// </summary>
        /// <param name="days">Nullable<int></param>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadByDays(Nullable<int> days);

        /// <summary>
        /// Load all ProductPostponeStatusOutcome entities from the database.
        /// </summary>
        /// <returns>IList<IProductPostponeStatusOutcome></returns>
		IList<IProductPostponeStatusOutcome> LoadAll();
		
		#endregion

		#region Search

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the ProductPostponeStatusOutcome entity to the database.
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		bool Save(IProductPostponeStatusOutcome entity);
		
        /// <summary>
        /// Update the ProductPostponeStatusOutcome entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		bool Update(IProductPostponeStatusOutcome entity);
		
        /// <summary>
        /// Delete the ProductPostponeStatusOutcome entity from the database
        /// </summary>
        /// <param name="entity">IProductPostponeStatusOutcome</param>
        /// <returns>bool</returns>
		bool Delete(IProductPostponeStatusOutcome entity);
		
        /// <summary>
        /// Delete the ProductPostponeStatusOutcome entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
