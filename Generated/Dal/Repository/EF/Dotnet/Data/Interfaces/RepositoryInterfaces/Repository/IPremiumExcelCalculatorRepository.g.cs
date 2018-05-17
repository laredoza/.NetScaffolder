
// <copyright file="PremiumExcelCalculator.g.cs" company="MIT">
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
	/// The PremiumExcelCalculatorRepository interface that defines database functions for the PremiumExcelCalculator table
	/// </summary>
	public partial interface IPremiumExcelCalculatorRepository : IRepository<IPremiumExcelCalculator>
	{
		#region Load

        /// <summary>
        /// Load the PremiumExcelCalculator entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IPremiumExcelCalculator</returns>
		IPremiumExcelCalculator LoadById(int id);

        /// <summary>
        /// Load PremiumExcelCalculator entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load PremiumExcelCalculator entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadByUserName(string username);

        /// <summary>
        /// Load PremiumExcelCalculator entities from the database using the ExcelFileName field
        /// </summary>
        /// <param name="excelfilename">string</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadByExcelFileName(string excelfilename);

        /// <summary>
        /// Load PremiumExcelCalculator entities from the database using the ExcelFolderName field
        /// </summary>
        /// <param name="excelfoldername">string</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadByExcelFolderName(string excelfoldername);

        /// <summary>
        /// Load PremiumExcelCalculator entities from the database using the ExcelCalcTypeId field
        /// </summary>
        /// <param name="excelcalctypeid">Nullable<int></param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadByExcelCalcTypeId(Nullable<int> excelcalctypeid);

        /// <summary>
        /// Load all PremiumExcelCalculator entities from the database.
        /// </summary>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for PremiumExcelCalculator entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for PremiumExcelCalculator entities in the database by ExcelFileName
        /// </summary>
        /// <param name="excelfilename">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> SearchByExcelFileName(string excelfilename, bool caseSensitive = false);

        /// <summary>
        /// Search for PremiumExcelCalculator entities in the database by ExcelFolderName
        /// </summary>
        /// <param name="excelfoldername">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IPremiumExcelCalculator></returns>
		IList<IPremiumExcelCalculator> SearchByExcelFolderName(string excelfoldername, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the PremiumExcelCalculator entity to the database.
        /// </summary>
        /// <param name="entity">IPremiumExcelCalculator</param>
        /// <returns>bool</returns>
		bool Save(IPremiumExcelCalculator entity);
		
        /// <summary>
        /// Update the PremiumExcelCalculator entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPremiumExcelCalculator</param>
        /// <returns>bool</returns>
		bool Update(IPremiumExcelCalculator entity);
		
        /// <summary>
        /// Delete the PremiumExcelCalculator entity from the database
        /// </summary>
        /// <param name="entity">IPremiumExcelCalculator</param>
        /// <returns>bool</returns>
		bool Delete(IPremiumExcelCalculator entity);
		
        /// <summary>
        /// Delete the PremiumExcelCalculator entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
