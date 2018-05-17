
// <copyright file="Premium.g.cs" company="MIT">
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
	/// The PremiumRepository interface that defines database functions for the Premium table
	/// </summary>
	public partial interface IPremiumRepository : IRepository<IPremium>
	{
		#region Load

        /// <summary>
        /// Load the Premium entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPremium</returns>
		IPremium LoadById(int id);

        /// <summary>
        /// Load Premium entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Premium entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByUserName(string username);

        /// <summary>
        /// Load Premium entities from the database using the BasePremium field
        /// </summary>
        /// <param name="basepremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByBasePremium(Nullable<decimal> basepremium);

        /// <summary>
        /// Load Premium entities from the database using the FinalPremium field
        /// </summary>
        /// <param name="finalpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByFinalPremium(Nullable<decimal> finalpremium);

        /// <summary>
        /// Load Premium entities from the database using the PercentageLoading field
        /// </summary>
        /// <param name="percentageloading">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByPercentageLoading(Nullable<decimal> percentageloading);

        /// <summary>
        /// Load Premium entities from the database using the PremiumProfileId field
        /// </summary>
        /// <param name="premiumprofileid">Nullable<int></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByPremiumProfileId(Nullable<int> premiumprofileid);

        /// <summary>
        /// Load Premium entities from the database using the ProductId field
        /// </summary>
        /// <param name="productid">Nullable<int></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByProductId(Nullable<int> productid);

        /// <summary>
        /// Load Premium entities from the database using the UserPremium field
        /// </summary>
        /// <param name="userpremium">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByUserPremium(Nullable<decimal> userpremium);

        /// <summary>
        /// Load Premium entities from the database using the TypeOption field
        /// </summary>
        /// <param name="typeoption">int</param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByTypeOption(int typeoption);

        /// <summary>
        /// Load Premium entities from the database using the UnitLoading field
        /// </summary>
        /// <param name="unitloading">Nullable<decimal></param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadByUnitLoading(Nullable<decimal> unitloading);

        /// <summary>
        /// Load all Premium entities from the database.
        /// </summary>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Premium entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremium></returns>
		IList<IPremium> SearchByUserName(string username, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Premium entity to the database.
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		bool Save(IPremium entity);
		
        /// <summary>
        /// Update the Premium entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		bool Update(IPremium entity);
		
        /// <summary>
        /// Delete the Premium entity from the database
        /// </summary>
        /// <param name="entity">IPremium</param>
        /// <returns>bool</returns>
		bool Delete(IPremium entity);
		
        /// <summary>
        /// Delete the Premium entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
