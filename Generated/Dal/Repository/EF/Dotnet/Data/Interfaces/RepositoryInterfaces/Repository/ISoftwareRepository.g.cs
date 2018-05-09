
// <copyright file="Software.g.cs" company="MIT">
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
	/// The SoftwareRepository interface that defines database functions for the Software table
	/// </summary>
	public partial interface ISoftwareRepository : IRepository
	{
		#region Load

        /// <summary>
        /// Load the Software entity from the database using the ProductId primary key
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>ISoftware</returns>
		ISoftware LoadByProductId(int productid);

        /// <summary>
        /// Load Software entities from the database using the LicenseCode field
        /// </summary>
        /// <param name="licensecode">string</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> LoadByLicenseCode(string licensecode);

        /// <summary>
        /// Load all Software entities from the database.
        /// </summary>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Software entities in the database by LicenseCode
        /// </summary>
        /// <param name="licensecode">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ISoftware></returns>
		IList<ISoftware> SearchByLicenseCode(string licensecode, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Software entity to the database.
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Save(ISoftware entity);
		
        /// <summary>
        /// Update the Software entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Update(ISoftware entity);
		
        /// <summary>
        /// Delete the Software entity from the database
        /// </summary>
        /// <param name="entity">ISoftware</param>
        /// <returns>bool</returns>
		bool Delete(ISoftware entity);
		
        /// <summary>
        /// Delete the Software entity from the database using the ProductId
        /// </summary>
        /// <param name="productid">int</param>
        /// <returns>bool</returns>
		bool DeleteByProductId(int productid);

		#endregion
	}
}
