
// <copyright file="AspNetUser.g.cs" company="MIT">
//  Copyright (c) 2019 MIT
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
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces
{
	/// <summary>
	/// The AspNetUserRepository interface that defines database functions for the AspNetUser table
	/// </summary>
	public partial interface IAspNetUserRepository : IRepository<AspNetUser>
	{
		#region Load

        /// <summary>
        /// Load AspNetUser entities from the database using the composite primary keys
        /// </summary
        /// <param name="id">Guid</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUser</returns>
		AspNetUser LoadById(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the composite primary keys
        /// </summary
        /// <param name="id">Guid</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUser</returns>
		Task<AspNetUser> LoadByIdAsync(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailConfirmed">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByEmailConfirmed(bool emailConfirmed, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the EmailConfirmed field
        /// </summary>
        /// <param name="emailConfirmed">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByEmailConfirmedAsync(bool emailConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the PhoneNumberConfirmed field
        /// </summary>
        /// <param name="phoneNumberConfirmed">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByPhoneNumberConfirmed(bool phoneNumberConfirmed, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the PhoneNumberConfirmed field
        /// </summary>
        /// <param name="phoneNumberConfirmed">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByPhoneNumberConfirmedAsync(bool phoneNumberConfirmed, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twoFactorEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByTwoFactorEnabled(bool twoFactorEnabled, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the TwoFactorEnabled field
        /// </summary>
        /// <param name="twoFactorEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByTwoFactorEnabledAsync(bool twoFactorEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the LockoutEnd field
        /// </summary>
        /// <param name="lockoutEnd">Nullable<DateTimeOffset></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByLockoutEnd(Nullable<DateTimeOffset> lockoutEnd, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the LockoutEnd field
        /// </summary>
        /// <param name="lockoutEnd">Nullable<DateTimeOffset></param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByLockoutEndAsync(Nullable<DateTimeOffset> lockoutEnd, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByLockoutEnabled(bool lockoutEnabled, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the LockoutEnabled field
        /// </summary>
        /// <param name="lockoutEnabled">bool</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByLockoutEnabledAsync(bool lockoutEnabled, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser entities from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessFailedCount">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadByAccessFailedCount(int accessFailedCount, bool cache,  params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load AspNetUser entities async from the database using the AccessFailedCount field
        /// </summary>
        /// <param name="accessFailedCount">int</param
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadByAccessFailedCountAsync(int accessFailedCount, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load all AspNetUser entities from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> LoadAll( bool cache, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Load all AspNetUser entities async from the database.
        /// </summary>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="includes">params Expression<Func<AspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> LoadAllAsync(bool cache, params Expression<Func<IAspNetUser, object>>[] includes);
		
		#endregion

		#region Search

        /// <summary>
        /// Search for AspNetUser entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByUserName(string userName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByUserNameAsync(string userName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByNormalizedUserName(string normalizedUserName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByNormalizedUserNameAsync(string normalizedUserName, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByEmail(string email, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by Email
        /// </summary>
        /// <param name="email">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByEmailAsync(string email, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByNormalizedEmail(string normalizedEmail, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByNormalizedEmailAsync(string normalizedEmail, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByPasswordHash(string passwordHash, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByPasswordHashAsync(string passwordHash, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchBySecurityStamp(string securityStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchBySecurityStampAsync(string securityStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByConcurrencyStamp(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByConcurrencyStampAsync(string concurrencyStamp, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		IList<AspNetUser> SearchByPhoneNumber(string phoneNumber, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);
		
        /// <summary>
        /// Search for AspNetUser entities async in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
        /// <param name="cache">Use 2nd level caching if enabled</param>
		/// <param name="caseSensitive">bool</param
		/// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUser></returns>
		Task<IList<AspNetUser>> SearchByPhoneNumberAsync(string phoneNumber, bool cache, bool caseSensitive = false, params Expression<Func<IAspNetUser, object>>[] includes);

		#endregion
		
		#region Modifiers
		
        /// <summary>
        /// Add the AspNetUser entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		bool Add(AspNetUser entity);
		
        /// <summary>
        /// Add the AspNetUser entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		Task<bool> AddAsync(AspNetUser entity);

        /// <summary>
        /// Update the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		bool Update(AspNetUser entity);
		
        /// <summary>
        /// Update the AspNetUser entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		Task<bool> UpdateAsync(AspNetUser entity);
		
        /// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		bool Delete(AspNetUser entity);
		
        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="entity">AspNetUser</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync(AspNetUser entity);

		/// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		bool Delete( Guid id, bool cache);

		/// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="id">Guid, bool cache</param>
        /// <returns>bool</returns>
		Task<bool> DeleteAsync( Guid id, bool cache);
		
		#endregion
		
		#region Aggregates
		
		TResult Max<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
		Task<TResult> MaxAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
		TResult Min<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
		Task<TResult> MinAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
		#endregion

        #region Bulk

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete(IEnumerable<AspNetUser> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync(IEnumerable<AspNetUser> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert(IEnumerable<AspNetUser> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync(IEnumerable<AspNetUser> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate(IEnumerable<AspNetUser> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync(IEnumerable<AspNetUser> items);

        #endregion
	}
}
