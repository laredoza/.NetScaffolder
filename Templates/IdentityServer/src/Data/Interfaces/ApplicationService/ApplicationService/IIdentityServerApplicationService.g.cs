
// <copyright file=".g.cs" company="MIT">
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
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;

namespace DotNetScaffolder.Domain.Data.ApplicationService
{
    /// <summary>
	/// The IdentityServerApplication Service interface that defines database functions for the IdentityServer application service
	/// </summary>
	public partial interface IIdentityServerApplicationService 
	{

        #region Load

        /// <summary>
        /// Load AspNetRole entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRoleDto</returns>
		AspNetRoleDto LoadByAspNetRoleId(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Load AspNetRole Async entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>AspNetRoleDto</returns>
		Task<AspNetRoleDto> LoadByAspNetRoleIdAsync(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Load all AspNetRole entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		IList<AspNetRoleDto> AspNetRoleLoadAll(bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Load all AspNetRole Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		Task<IList<AspNetRoleDto>> AspNetRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaimDto</returns>
		AspNetRoleClaimDto LoadByAspNetRoleClaimId(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Load AspNetRoleClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>AspNetRoleClaimDto</returns>
		Task<AspNetRoleClaimDto> LoadByAspNetRoleClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Load all AspNetRoleClaim entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		IList<AspNetRoleClaimDto> AspNetRoleClaimLoadAll(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Load all AspNetRoleClaim Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Load AspNetUser entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUserDto</returns>
		AspNetUserDto LoadByAspNetUserId(string id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Load AspNetUser Async entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>AspNetUserDto</returns>
		Task<AspNetUserDto> LoadByAspNetUserIdAsync(string id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Load all AspNetUser entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserLoadAll(bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Load all AspNetUser Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserLoadAllAsync(bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Load AspNetUserClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaimDto</returns>
		AspNetUserClaimDto LoadByAspNetUserClaimId(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Load AspNetUserClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>AspNetUserClaimDto</returns>
		Task<AspNetUserClaimDto> LoadByAspNetUserClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserClaim entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		IList<AspNetUserClaimDto> AspNetUserClaimLoadAll(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserClaim Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		Task<IList<AspNetUserClaimDto>> AspNetUserClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Load AspNetUserLogin entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>IAspNetUserLogin</returns>
		AspNetUserLoginDto Load( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Load AspNetUserLogin async entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>AspNetUserLoginDto</returns>
		Task<AspNetUserLoginDto> LoadAsync( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserLogin entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		IList<AspNetUserLoginDto> AspNetUserLoginLoadAll(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserLogin Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		Task<IList<AspNetUserLoginDto>> AspNetUserLoginLoadAllAsync(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Load AspNetUserRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>IAspNetUserRole</returns>
		AspNetUserRoleDto Load( string userId,  string roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes);

        /// <summary>
        /// Load AspNetUserRole async entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>AspNetUserRoleDto</returns>
		Task<AspNetUserRoleDto> LoadAsync( string userId,  string roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserRole entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		IList<AspNetUserRoleDto> AspNetUserRoleLoadAll(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserRole Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		Task<IList<AspNetUserRoleDto>> AspNetUserRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes);

        /// <summary>
        /// Load AspNetUserToken entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>IAspNetUserToken</returns>
		AspNetUserTokenDto Load( string userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);

        /// <summary>
        /// Load AspNetUserToken async entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>AspNetUserTokenDto</returns>
		Task<AspNetUserTokenDto> LoadAsync( string userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserToken entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		IList<AspNetUserTokenDto> AspNetUserTokenLoadAll(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);


        /// <summary>
        /// Load all AspNetUserToken Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		Task<IList<AspNetUserTokenDto>> AspNetUserTokenLoadAllAsync(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);


        #endregion

        #region Search

        /// <summary>
        /// Search for AspNetRole entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		IList<AspNetRoleDto> AspNetRoleSearchByName(string name,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Search for AspNetRole  Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		Task<IList<AspNetRoleDto>> AspNetRoleSearchByNameAsync(string name,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Search for AspNetRole entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		IList<AspNetRoleDto> AspNetRoleSearchByNormalizedName(string normalizedName,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Search for AspNetRole  Async entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		Task<IList<AspNetRoleDto>> AspNetRoleSearchByNormalizedNameAsync(string normalizedName,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Search for AspNetRole entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		IList<AspNetRoleDto> AspNetRoleSearchByConcurrencyStamp(string concurrencyStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);

        /// <summary>
        /// Search for AspNetRole  Async entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		Task<IList<AspNetRoleDto>> AspNetRoleSearchByConcurrencyStampAsync(string concurrencyStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes);


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByRoleId(string roleId,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetRoleClaim  Async entities in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByRoleIdAsync(string roleId,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByClaimType(string claimType,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetRoleClaim  Async entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByClaimTypeAsync(string claimType,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByClaimValue(string claimValue,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetRoleClaim  Async entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByClaimValueAsync(string claimValue,bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByUserName(string userName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByUserNameAsync(string userName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByNormalizedUserName(string normalizedUserName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByNormalizedUserNameAsync(string normalizedUserName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByEmail(string email,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByEmailAsync(string email,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByNormalizedEmail(string normalizedEmail,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByNormalizedEmailAsync(string normalizedEmail,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByPasswordHash(string passwordHash,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByPasswordHashAsync(string passwordHash,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchBySecurityStamp(string securityStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchBySecurityStampAsync(string securityStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByConcurrencyStamp(string concurrencyStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByConcurrencyStampAsync(string concurrencyStamp,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUser entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		IList<AspNetUserDto> AspNetUserSearchByPhoneNumber(string phoneNumber,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);

        /// <summary>
        /// Search for AspNetUser  Async entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		Task<IList<AspNetUserDto>> AspNetUserSearchByPhoneNumberAsync(string phoneNumber,bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		IList<AspNetUserClaimDto> AspNetUserClaimSearchByUserId(string userId,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserClaim  Async entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByUserIdAsync(string userId,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		IList<AspNetUserClaimDto> AspNetUserClaimSearchByClaimType(string claimType,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserClaim  Async entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByClaimTypeAsync(string claimType,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		IList<AspNetUserClaimDto> AspNetUserClaimSearchByClaimValue(string claimValue,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserClaim  Async entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByClaimValueAsync(string claimValue,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserLogin entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		IList<AspNetUserLoginDto> AspNetUserLoginSearchByProviderDisplayName(string providerDisplayName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserLogin  Async entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		Task<IList<AspNetUserLoginDto>> AspNetUserLoginSearchByProviderDisplayNameAsync(string providerDisplayName,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserLogin entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		IList<AspNetUserLoginDto> AspNetUserLoginSearchByUserId(string userId,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserLogin  Async entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		Task<IList<AspNetUserLoginDto>> AspNetUserLoginSearchByUserIdAsync(string userId,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes);


        /// <summary>
        /// Search for AspNetUserToken entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		IList<AspNetUserTokenDto> AspNetUserTokenSearchByValue(string value,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);

        /// <summary>
        /// Search for AspNetUserToken  Async entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		Task<IList<AspNetUserTokenDto>> AspNetUserTokenSearchByValueAsync(string value,bool caseSensitive, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes);

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Save the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleAdd(AspNetRoleDto entity);

        /// <summary>
        /// Save async the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleAddAsync(AspNetRoleDto entity);

        /// <summary>
        /// Update the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleUpdate(AspNetRoleDto entity);

        //// <summary>
        /// Update async the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleUpdateAsync(AspNetRoleDto entity);
		
        /// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleDelete(AspNetRoleDto entity);

        /// <summary>
        /// Delete async the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleDeleteAsync(AspNetRoleDto entity);

		/// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		bool AspNetRoleDelete( string id, bool cache);

        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleDeleteAsync( string id, bool cache);

		
        /// <summary>
        /// Save the AspNetRoleClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleClaimAdd(AspNetRoleClaimDto entity);

        /// <summary>
        /// Save async the AspNetRoleClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleClaimAddAsync(AspNetRoleClaimDto entity);

        /// <summary>
        /// Update the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleClaimUpdate(AspNetRoleClaimDto entity);

        //// <summary>
        /// Update async the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleClaimUpdateAsync(AspNetRoleClaimDto entity);
		
        /// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetRoleClaimDelete(AspNetRoleClaimDto entity);

        /// <summary>
        /// Delete async the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetRoleClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleClaimDeleteAsync(AspNetRoleClaimDto entity);

		/// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool AspNetRoleClaimDelete( int id, bool cache);

        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> AspNetRoleClaimDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the AspNetUser entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		bool AspNetUserAdd(AspNetUserDto entity);

        /// <summary>
        /// Save async the AspNetUser entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserAddAsync(AspNetUserDto entity);

        /// <summary>
        /// Update the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		bool AspNetUserUpdate(AspNetUserDto entity);

        //// <summary>
        /// Update async the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserUpdateAsync(AspNetUserDto entity);
		
        /// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		bool AspNetUserDelete(AspNetUserDto entity);

        /// <summary>
        /// Delete async the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserDeleteAsync(AspNetUserDto entity);

		/// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		bool AspNetUserDelete( string id, bool cache);

        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserDeleteAsync( string id, bool cache);

		
        /// <summary>
        /// Save the AspNetUserClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetUserClaimAdd(AspNetUserClaimDto entity);

        /// <summary>
        /// Save async the AspNetUserClaim entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserClaimAddAsync(AspNetUserClaimDto entity);

        /// <summary>
        /// Update the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetUserClaimUpdate(AspNetUserClaimDto entity);

        //// <summary>
        /// Update async the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserClaimUpdateAsync(AspNetUserClaimDto entity);
		
        /// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		bool AspNetUserClaimDelete(AspNetUserClaimDto entity);

        /// <summary>
        /// Delete async the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserClaimDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserClaimDeleteAsync(AspNetUserClaimDto entity);

		/// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool AspNetUserClaimDelete( int id, bool cache);

        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserClaimDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the AspNetUserLogin entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		bool AspNetUserLoginAdd(AspNetUserLoginDto entity);

        /// <summary>
        /// Save async the AspNetUserLogin entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserLoginAddAsync(AspNetUserLoginDto entity);

        /// <summary>
        /// Update the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		bool AspNetUserLoginUpdate(AspNetUserLoginDto entity);

        //// <summary>
        /// Update async the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserLoginUpdateAsync(AspNetUserLoginDto entity);
		
        /// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		bool AspNetUserLoginDelete(AspNetUserLoginDto entity);

        /// <summary>
        /// Delete async the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserLoginDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserLoginDeleteAsync(AspNetUserLoginDto entity);

		/// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		bool AspNetUserLoginDelete( string loginProvider,  string providerKey, bool cache);

        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserLoginDeleteAsync( string loginProvider,  string providerKey, bool cache);

		
        /// <summary>
        /// Save the AspNetUserRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetUserRoleAdd(AspNetUserRoleDto entity);

        /// <summary>
        /// Save async the AspNetUserRole entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserRoleAddAsync(AspNetUserRoleDto entity);

        /// <summary>
        /// Update the AspNetUserRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetUserRoleUpdate(AspNetUserRoleDto entity);

        //// <summary>
        /// Update async the AspNetUserRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserRoleUpdateAsync(AspNetUserRoleDto entity);
		
        /// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		bool AspNetUserRoleDelete(AspNetUserRoleDto entity);

        /// <summary>
        /// Delete async the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserRoleDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserRoleDeleteAsync(AspNetUserRoleDto entity);

		/// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>bool</returns>
		bool AspNetUserRoleDelete( string userId,  string roleId, bool cache);

        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserRoleDeleteAsync( string userId,  string roleId, bool cache);

		
        /// <summary>
        /// Save the AspNetUserToken entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		bool AspNetUserTokenAdd(AspNetUserTokenDto entity);

        /// <summary>
        /// Save async the AspNetUserToken entity to the database.
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserTokenAddAsync(AspNetUserTokenDto entity);

        /// <summary>
        /// Update the AspNetUserToken entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		bool AspNetUserTokenUpdate(AspNetUserTokenDto entity);

        //// <summary>
        /// Update async the AspNetUserToken entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserTokenUpdateAsync(AspNetUserTokenDto entity);
		
        /// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		bool AspNetUserTokenDelete(AspNetUserTokenDto entity);

        /// <summary>
        /// Delete async the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="entity">AspNetUserTokenDto</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserTokenDeleteAsync(AspNetUserTokenDto entity);

		/// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		bool AspNetUserTokenDelete( string userId,  string loginProvider,  string name, bool cache);

        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		Task<bool> AspNetUserTokenDeleteAsync( string userId,  string loginProvider,  string name, bool cache);


		#endregion

        #region Aggregates

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetRoleMax<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetRoleMaxAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetRoleMin<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetRoleMinAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetRoleClaimMax<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetRoleClaimMaxAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetRoleClaimMin<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetRoleClaimMinAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetUserMax<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserMaxAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetUserMin<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserMinAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetUserClaimMax<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserClaimMaxAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetUserClaimMin<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserClaimMinAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetUserLoginMax<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserLoginMaxAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetUserLoginMin<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserLoginMinAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetUserRoleMax<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserRoleMaxAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetUserRoleMin<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserRoleMinAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AspNetUserTokenMax<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserTokenMaxAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AspNetUserTokenMin<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AspNetUserTokenMinAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache);

		#endregion

        #region Bulk
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleBulkDelete(IEnumerable<AspNetRoleDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleBulkDeleteAsync(IEnumerable<AspNetRoleDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleBulkInsert(IEnumerable<AspNetRoleDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleBulkInsertAsync(IEnumerable<AspNetRoleDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleBulkUpdate(IEnumerable<AspNetRoleDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleBulkUpdateAsync(IEnumerable<AspNetRoleDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleClaimBulkDelete(IEnumerable<AspNetRoleClaimDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleClaimBulkDeleteAsync(IEnumerable<AspNetRoleClaimDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleClaimBulkInsert(IEnumerable<AspNetRoleClaimDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleClaimBulkInsertAsync(IEnumerable<AspNetRoleClaimDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetRoleClaimBulkUpdate(IEnumerable<AspNetRoleClaimDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetRoleClaimBulkUpdateAsync(IEnumerable<AspNetRoleClaimDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserBulkDelete(IEnumerable<AspNetUserDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserBulkDeleteAsync(IEnumerable<AspNetUserDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserBulkInsert(IEnumerable<AspNetUserDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserBulkInsertAsync(IEnumerable<AspNetUserDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserBulkUpdate(IEnumerable<AspNetUserDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserBulkUpdateAsync(IEnumerable<AspNetUserDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserClaimBulkDelete(IEnumerable<AspNetUserClaimDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserClaimBulkDeleteAsync(IEnumerable<AspNetUserClaimDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserClaimBulkInsert(IEnumerable<AspNetUserClaimDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserClaimBulkInsertAsync(IEnumerable<AspNetUserClaimDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserClaimBulkUpdate(IEnumerable<AspNetUserClaimDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserClaimBulkUpdateAsync(IEnumerable<AspNetUserClaimDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserLoginBulkDelete(IEnumerable<AspNetUserLoginDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserLoginBulkDeleteAsync(IEnumerable<AspNetUserLoginDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserLoginBulkInsert(IEnumerable<AspNetUserLoginDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserLoginBulkInsertAsync(IEnumerable<AspNetUserLoginDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserLoginBulkUpdate(IEnumerable<AspNetUserLoginDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserLoginBulkUpdateAsync(IEnumerable<AspNetUserLoginDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserRoleBulkDelete(IEnumerable<AspNetUserRoleDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserRoleBulkDeleteAsync(IEnumerable<AspNetUserRoleDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserRoleBulkInsert(IEnumerable<AspNetUserRoleDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserRoleBulkInsertAsync(IEnumerable<AspNetUserRoleDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserRoleBulkUpdate(IEnumerable<AspNetUserRoleDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserRoleBulkUpdateAsync(IEnumerable<AspNetUserRoleDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserTokenBulkDelete(IEnumerable<AspNetUserTokenDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserTokenBulkDeleteAsync(IEnumerable<AspNetUserTokenDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserTokenBulkInsert(IEnumerable<AspNetUserTokenDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserTokenBulkInsertAsync(IEnumerable<AspNetUserTokenDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AspNetUserTokenBulkUpdate(IEnumerable<AspNetUserTokenDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AspNetUserTokenBulkUpdateAsync(IEnumerable<AspNetUserTokenDto> items);

        #endregion
    }
}

