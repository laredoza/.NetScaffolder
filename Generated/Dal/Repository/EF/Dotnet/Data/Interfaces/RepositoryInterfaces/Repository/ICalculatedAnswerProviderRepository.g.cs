
// <copyright file="CalculatedAnswerProvider.g.cs" company="MIT">
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
	/// The CalculatedAnswerProviderRepository interface that defines database functions for the CalculatedAnswerProvider table
	/// </summary>
	public partial interface ICalculatedAnswerProviderRepository : IRepository<ICalculatedAnswerProvider>
	{
		#region Load

        /// <summary>
        /// Load the CalculatedAnswerProvider entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICalculatedAnswerProvider</returns>
		ICalculatedAnswerProvider LoadById(int id);

        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the CalculatorName field
        /// </summary>
        /// <param name="calculatorname">string</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> LoadByCalculatorName(string calculatorname);

        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the SettingsXml field
        /// </summary>
        /// <param name="settingsxml">string</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> LoadBySettingsXml(string settingsxml);

        /// <summary>
        /// Load CalculatedAnswerProvider entities from the database using the CalculatorId field
        /// </summary>
        /// <param name="calculatorid">Nullable<int></param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> LoadByCalculatorId(Nullable<int> calculatorid);

        /// <summary>
        /// Load all CalculatedAnswerProvider entities from the database.
        /// </summary>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for CalculatedAnswerProvider entities in the database by CalculatorName
        /// </summary>
        /// <param name="calculatorname">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> SearchByCalculatorName(string calculatorname, bool caseSensitive = false);

        /// <summary>
        /// Search for CalculatedAnswerProvider entities in the database by SettingsXml
        /// </summary>
        /// <param name="settingsxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculatedAnswerProvider></returns>
		IList<ICalculatedAnswerProvider> SearchBySettingsXml(string settingsxml, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the CalculatedAnswerProvider entity to the database.
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		bool Save(ICalculatedAnswerProvider entity);
		
        /// <summary>
        /// Update the CalculatedAnswerProvider entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		bool Update(ICalculatedAnswerProvider entity);
		
        /// <summary>
        /// Delete the CalculatedAnswerProvider entity from the database
        /// </summary>
        /// <param name="entity">ICalculatedAnswerProvider</param>
        /// <returns>bool</returns>
		bool Delete(ICalculatedAnswerProvider entity);
		
        /// <summary>
        /// Delete the CalculatedAnswerProvider entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
