
// <copyright file="Calculation.g.cs" company="MIT">
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
	/// The CalculationRepository interface that defines database functions for the Calculation table
	/// </summary>
	public partial interface ICalculationRepository : IRepository<ICalculation>
	{
		#region Load

        /// <summary>
        /// Load the Calculation entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ICalculation</returns>
		ICalculation LoadById(int id);

        /// <summary>
        /// Load Calculation entities from the database using the Name field
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> LoadByName(string name);

        /// <summary>
        /// Load Calculation entities from the database using the Expression field
        /// </summary>
        /// <param name="expression">string</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> LoadByExpression(string expression);

        /// <summary>
        /// Load Calculation entities from the database using the SettingsXml field
        /// </summary>
        /// <param name="settingsxml">string</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> LoadBySettingsXml(string settingsxml);

        /// <summary>
        /// Load Calculation entities from the database using the Active field
        /// </summary>
        /// <param name="active">bool</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> LoadByActive(bool active);

        /// <summary>
        /// Load all Calculation entities from the database.
        /// </summary>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Calculation entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> SearchByName(string name, bool caseSensitive = false);

        /// <summary>
        /// Search for Calculation entities in the database by Expression
        /// </summary>
        /// <param name="expression">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> SearchByExpression(string expression, bool caseSensitive = false);

        /// <summary>
        /// Search for Calculation entities in the database by SettingsXml
        /// </summary>
        /// <param name="settingsxml">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<ICalculation></returns>
		IList<ICalculation> SearchBySettingsXml(string settingsxml, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Calculation entity to the database.
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		bool Save(ICalculation entity);
		
        /// <summary>
        /// Update the Calculation entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		bool Update(ICalculation entity);
		
        /// <summary>
        /// Delete the Calculation entity from the database
        /// </summary>
        /// <param name="entity">ICalculation</param>
        /// <returns>bool</returns>
		bool Delete(ICalculation entity);
		
        /// <summary>
        /// Delete the Calculation entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
