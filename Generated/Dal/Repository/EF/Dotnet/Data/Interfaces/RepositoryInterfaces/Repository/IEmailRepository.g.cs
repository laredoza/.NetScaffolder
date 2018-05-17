
// <copyright file="Email.g.cs" company="MIT">
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
	/// The EmailRepository interface that defines database functions for the Email table
	/// </summary>
	public partial interface IEmailRepository : IRepository<IEmail>
	{
		#region Load

        /// <summary>
        /// Load the Email entity from the database using the Id primary key
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>IEmail</returns>
		IEmail LoadById(int id);

        /// <summary>
        /// Load Email entities from the database using the Stamp field
        /// </summary>
        /// <param name="stamp">Nullable<DateTime></param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByStamp(Nullable<DateTime> stamp);

        /// <summary>
        /// Load Email entities from the database using the UserName field
        /// </summary>
        /// <param name="username">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByUserName(string username);

        /// <summary>
        /// Load Email entities from the database using the EmailFrom field
        /// </summary>
        /// <param name="emailfrom">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByEmailFrom(string emailfrom);

        /// <summary>
        /// Load Email entities from the database using the EmailTo field
        /// </summary>
        /// <param name="emailto">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByEmailTo(string emailto);

        /// <summary>
        /// Load Email entities from the database using the EmailSubject field
        /// </summary>
        /// <param name="emailsubject">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByEmailSubject(string emailsubject);

        /// <summary>
        /// Load Email entities from the database using the EmailBody field
        /// </summary>
        /// <param name="emailbody">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByEmailBody(string emailbody);

        /// <summary>
        /// Load Email entities from the database using the ProcessedDate field
        /// </summary>
        /// <param name="processeddate">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByProcessedDate(string processeddate);

        /// <summary>
        /// Load Email entities from the database using the Status field
        /// </summary>
        /// <param name="status">Nullable<int></param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByStatus(Nullable<int> status);

        /// <summary>
        /// Load Email entities from the database using the Information field
        /// </summary>
        /// <param name="information">string</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadByInformation(string information);

        /// <summary>
        /// Load all Email entities from the database.
        /// </summary>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> LoadAll();
		
		#endregion

		#region Search

        /// <summary>
        /// Search for Email entities in the database by UserName
        /// </summary>
        /// <param name="username">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByUserName(string username, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by EmailFrom
        /// </summary>
        /// <param name="emailfrom">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByEmailFrom(string emailfrom, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by EmailTo
        /// </summary>
        /// <param name="emailto">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByEmailTo(string emailto, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by EmailSubject
        /// </summary>
        /// <param name="emailsubject">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByEmailSubject(string emailsubject, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by EmailBody
        /// </summary>
        /// <param name="emailbody">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByEmailBody(string emailbody, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by ProcessedDate
        /// </summary>
        /// <param name="processeddate">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByProcessedDate(string processeddate, bool caseSensitive = false);

        /// <summary>
        /// Search for Email entities in the database by Information
        /// </summary>
        /// <param name="information">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <returns>IList<IEmail></returns>
		IList<IEmail> SearchByInformation(string information, bool caseSensitive = false);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Save the Email entity to the database.
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		bool Save(IEmail entity);
		
        /// <summary>
        /// Update the Email entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		bool Update(IEmail entity);
		
        /// <summary>
        /// Delete the Email entity from the database
        /// </summary>
        /// <param name="entity">IEmail</param>
        /// <returns>bool</returns>
		bool Delete(IEmail entity);
		
        /// <summary>
        /// Delete the Email entity from the database using the Id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool DeleteById(int id);

		#endregion
	}
}
