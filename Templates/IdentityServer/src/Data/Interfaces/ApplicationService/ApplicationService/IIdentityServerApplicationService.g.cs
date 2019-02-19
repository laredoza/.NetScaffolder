
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


        /// <summary>
        /// Load AllowedScope entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScopeDto</returns>
		AllowedScopeDto LoadByAllowedScopeId(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);

        /// <summary>
        /// Load AllowedScope Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>AllowedScopeDto</returns>
		Task<AllowedScopeDto> LoadByAllowedScopeIdAsync(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);


        /// <summary>
        /// Load all AllowedScope entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		IList<AllowedScopeDto> AllowedScopeLoadAll(bool cache, params Expression<Func<IAllowedScope, object>>[] includes);


        /// <summary>
        /// Load all AllowedScope Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		Task<IList<AllowedScopeDto>> AllowedScopeLoadAllAsync(bool cache, params Expression<Func<IAllowedScope, object>>[] includes);


        /// <summary>
        /// Load ApiResource entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResourceDto</returns>
		ApiResourceDto LoadByApiResourceId(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes);

        /// <summary>
        /// Load ApiResource Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>ApiResourceDto</returns>
		Task<ApiResourceDto> LoadByApiResourceIdAsync(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes);


        /// <summary>
        /// Load all ApiResource entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		IList<ApiResourceDto> ApiResourceLoadAll(bool cache, params Expression<Func<IApiResource, object>>[] includes);


        /// <summary>
        /// Load all ApiResource Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		Task<IList<ApiResourceDto>> ApiResourceLoadAllAsync(bool cache, params Expression<Func<IApiResource, object>>[] includes);


        /// <summary>
        /// Load Client entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>ClientDto</returns>
		ClientDto LoadByClientId(int id, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Load Client Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>ClientDto</returns>
		Task<ClientDto> LoadByClientIdAsync(int id, bool cache, params Expression<Func<IClient, object>>[] includes);


        /// <summary>
        /// Load all Client entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		IList<ClientDto> ClientLoadAll(bool cache, params Expression<Func<IClient, object>>[] includes);


        /// <summary>
        /// Load all Client Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		Task<IList<ClientDto>> ClientLoadAllAsync(bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Load ClientGrantType entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>IClientGrantType</returns>
		ClientGrantTypeDto Load( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes);

        /// <summary>
        /// Load ClientGrantType async entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>ClientGrantTypeDto</returns>
		Task<ClientGrantTypeDto> LoadAsync( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes);


        /// <summary>
        /// Load all ClientGrantType entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantTypeDto></returns>
		IList<ClientGrantTypeDto> ClientGrantTypeLoadAll(bool cache, params Expression<Func<IClientGrantType, object>>[] includes);


        /// <summary>
        /// Load all ClientGrantType Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantTypeDto></returns>
		Task<IList<ClientGrantTypeDto>> ClientGrantTypeLoadAllAsync(bool cache, params Expression<Func<IClientGrantType, object>>[] includes);


        /// <summary>
        /// Load GrantType entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>GrantTypeDto</returns>
		GrantTypeDto LoadByGrantTypeId(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes);

        /// <summary>
        /// Load GrantType Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>GrantTypeDto</returns>
		Task<GrantTypeDto> LoadByGrantTypeIdAsync(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes);


        /// <summary>
        /// Load all GrantType entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		IList<GrantTypeDto> GrantTypeLoadAll(bool cache, params Expression<Func<IGrantType, object>>[] includes);


        /// <summary>
        /// Load all GrantType Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		Task<IList<GrantTypeDto>> GrantTypeLoadAllAsync(bool cache, params Expression<Func<IGrantType, object>>[] includes);


        /// <summary>
        /// Load IdentityResource entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResourceDto</returns>
		IdentityResourceDto LoadByIdentityResourceId(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load IdentityResource Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IdentityResourceDto</returns>
		Task<IdentityResourceDto> LoadByIdentityResourceIdAsync(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);


        /// <summary>
        /// Load all IdentityResource entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		IList<IdentityResourceDto> IdentityResourceLoadAll(bool cache, params Expression<Func<IIdentityResource, object>>[] includes);


        /// <summary>
        /// Load all IdentityResource Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		Task<IList<IdentityResourceDto>> IdentityResourceLoadAllAsync(bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Load IdentityResourceClaimType entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>IIdentityResourceClaimType</returns>
		IdentityResourceClaimTypeDto Load( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes);

        /// <summary>
        /// Load IdentityResourceClaimType async entities from the database using the composite primary keys
        /// </summary
        /// <param name="cache">Enable second level caching</param>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>IdentityResourceClaimTypeDto</returns>
		Task<IdentityResourceClaimTypeDto> LoadAsync( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes);


        /// <summary>
        /// Load all IdentityResourceClaimType entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimTypeDto></returns>
		IList<IdentityResourceClaimTypeDto> IdentityResourceClaimTypeLoadAll(bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes);


        /// <summary>
        /// Load all IdentityResourceClaimType Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimTypeDto></returns>
		Task<IList<IdentityResourceClaimTypeDto>> IdentityResourceClaimTypeLoadAllAsync(bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes);


        /// <summary>
        /// Load PostLogoutRedirectUri entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>PostLogoutRedirectUriDto</returns>
		PostLogoutRedirectUriDto LoadByPostLogoutRedirectUriId(int id, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);

        /// <summary>
        /// Load PostLogoutRedirectUri Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>PostLogoutRedirectUriDto</returns>
		Task<PostLogoutRedirectUriDto> LoadByPostLogoutRedirectUriIdAsync(int id, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);


        /// <summary>
        /// Load all PostLogoutRedirectUri entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		IList<PostLogoutRedirectUriDto> PostLogoutRedirectUriLoadAll(bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);


        /// <summary>
        /// Load all PostLogoutRedirectUri Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		Task<IList<PostLogoutRedirectUriDto>> PostLogoutRedirectUriLoadAllAsync(bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);


        /// <summary>
        /// Load RedirectUri entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUriDto</returns>
		RedirectUriDto LoadByRedirectUriId(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);

        /// <summary>
        /// Load RedirectUri Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>RedirectUriDto</returns>
		Task<RedirectUriDto> LoadByRedirectUriIdAsync(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);


        /// <summary>
        /// Load all RedirectUri entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		IList<RedirectUriDto> RedirectUriLoadAll(bool cache, params Expression<Func<IRedirectUri, object>>[] includes);


        /// <summary>
        /// Load all RedirectUri Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		Task<IList<RedirectUriDto>> RedirectUriLoadAllAsync(bool cache, params Expression<Func<IRedirectUri, object>>[] includes);


        /// <summary>
        /// Load ResourceClaimType entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimTypeDto</returns>
		ResourceClaimTypeDto LoadByResourceClaimTypeId(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);

        /// <summary>
        /// Load ResourceClaimType Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>ResourceClaimTypeDto</returns>
		Task<ResourceClaimTypeDto> LoadByResourceClaimTypeIdAsync(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);


        /// <summary>
        /// Load all ResourceClaimType entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		IList<ResourceClaimTypeDto> ResourceClaimTypeLoadAll(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);


        /// <summary>
        /// Load all ResourceClaimType Async entities from the database.
        /// </summary>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		Task<IList<ResourceClaimTypeDto>> ResourceClaimTypeLoadAllAsync(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);


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


        /// <summary>
        /// Search for AllowedScope entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		IList<AllowedScopeDto> AllowedScopeSearchByResourceName(string resourceName,bool caseSensitive, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);

        /// <summary>
        /// Search for AllowedScope  Async entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		Task<IList<AllowedScopeDto>> AllowedScopeSearchByResourceNameAsync(string resourceName,bool caseSensitive, bool cache, params Expression<Func<IAllowedScope, object>>[] includes);


        /// <summary>
        /// Search for ApiResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		IList<ApiResourceDto> ApiResourceSearchByName(string name,bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes);

        /// <summary>
        /// Search for ApiResource  Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		Task<IList<ApiResourceDto>> ApiResourceSearchByNameAsync(string name,bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes);


        /// <summary>
        /// Search for ApiResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		IList<ApiResourceDto> ApiResourceSearchByDisplayName(string displayName,bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes);

        /// <summary>
        /// Search for ApiResource  Async entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		Task<IList<ApiResourceDto>> ApiResourceSearchByDisplayNameAsync(string displayName,bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes);


        /// <summary>
        /// Search for Client entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		IList<ClientDto> ClientSearchByClientId(string clientId,bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Search for Client  Async entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		Task<IList<ClientDto>> ClientSearchByClientIdAsync(string clientId,bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes);


        /// <summary>
        /// Search for Client entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		IList<ClientDto> ClientSearchByClientName(string clientName,bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes);

        /// <summary>
        /// Search for Client  Async entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		Task<IList<ClientDto>> ClientSearchByClientNameAsync(string clientName,bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes);


        /// <summary>
        /// Search for GrantType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		IList<GrantTypeDto> GrantTypeSearchByName(string name,bool caseSensitive, bool cache, params Expression<Func<IGrantType, object>>[] includes);

        /// <summary>
        /// Search for GrantType  Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		Task<IList<GrantTypeDto>> GrantTypeSearchByNameAsync(string name,bool caseSensitive, bool cache, params Expression<Func<IGrantType, object>>[] includes);


        /// <summary>
        /// Search for IdentityResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		IList<IdentityResourceDto> IdentityResourceSearchByName(string name,bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Search for IdentityResource  Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		Task<IList<IdentityResourceDto>> IdentityResourceSearchByNameAsync(string name,bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);


        /// <summary>
        /// Search for IdentityResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		IList<IdentityResourceDto> IdentityResourceSearchByDisplayName(string displayName,bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);

        /// <summary>
        /// Search for IdentityResource  Async entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		Task<IList<IdentityResourceDto>> IdentityResourceSearchByDisplayNameAsync(string displayName,bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes);


        /// <summary>
        /// Search for PostLogoutRedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		IList<PostLogoutRedirectUriDto> PostLogoutRedirectUriSearchByUri(string uri,bool caseSensitive, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);

        /// <summary>
        /// Search for PostLogoutRedirectUri  Async entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		Task<IList<PostLogoutRedirectUriDto>> PostLogoutRedirectUriSearchByUriAsync(string uri,bool caseSensitive, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes);


        /// <summary>
        /// Search for RedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		IList<RedirectUriDto> RedirectUriSearchByUri(string uri,bool caseSensitive, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);

        /// <summary>
        /// Search for RedirectUri  Async entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		Task<IList<RedirectUriDto>> RedirectUriSearchByUriAsync(string uri,bool caseSensitive, bool cache, params Expression<Func<IRedirectUri, object>>[] includes);


        /// <summary>
        /// Search for ResourceClaimType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		IList<ResourceClaimTypeDto> ResourceClaimTypeSearchByName(string name,bool caseSensitive, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);

        /// <summary>
        /// Search for ResourceClaimType  Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="cache">Enable second level caching</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		Task<IList<ResourceClaimTypeDto>> ResourceClaimTypeSearchByNameAsync(string name,bool caseSensitive, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes);

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

		
        /// <summary>
        /// Save the AllowedScope entity to the database.
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		bool AllowedScopeAdd(AllowedScopeDto entity);

        /// <summary>
        /// Save async the AllowedScope entity to the database.
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		Task<bool> AllowedScopeAddAsync(AllowedScopeDto entity);

        /// <summary>
        /// Update the AllowedScope entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		bool AllowedScopeUpdate(AllowedScopeDto entity);

        //// <summary>
        /// Update async the AllowedScope entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		Task<bool> AllowedScopeUpdateAsync(AllowedScopeDto entity);
		
        /// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		bool AllowedScopeDelete(AllowedScopeDto entity);

        /// <summary>
        /// Delete async the AllowedScope entity from the database
        /// </summary>
        /// <param name="entity">AllowedScopeDto</param>
        /// <returns>bool</returns>
		Task<bool> AllowedScopeDeleteAsync(AllowedScopeDto entity);

		/// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool AllowedScopeDelete( int id, bool cache);

        /// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> AllowedScopeDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the ApiResource entity to the database.
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		bool ApiResourceAdd(ApiResourceDto entity);

        /// <summary>
        /// Save async the ApiResource entity to the database.
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> ApiResourceAddAsync(ApiResourceDto entity);

        /// <summary>
        /// Update the ApiResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		bool ApiResourceUpdate(ApiResourceDto entity);

        //// <summary>
        /// Update async the ApiResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> ApiResourceUpdateAsync(ApiResourceDto entity);
		
        /// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		bool ApiResourceDelete(ApiResourceDto entity);

        /// <summary>
        /// Delete async the ApiResource entity from the database
        /// </summary>
        /// <param name="entity">ApiResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> ApiResourceDeleteAsync(ApiResourceDto entity);

		/// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool ApiResourceDelete( int id, bool cache);

        /// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> ApiResourceDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the Client entity to the database.
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		bool ClientAdd(ClientDto entity);

        /// <summary>
        /// Save async the Client entity to the database.
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientAddAsync(ClientDto entity);

        /// <summary>
        /// Update the Client entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		bool ClientUpdate(ClientDto entity);

        //// <summary>
        /// Update async the Client entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientUpdateAsync(ClientDto entity);
		
        /// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		bool ClientDelete(ClientDto entity);

        /// <summary>
        /// Delete async the Client entity from the database
        /// </summary>
        /// <param name="entity">ClientDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientDeleteAsync(ClientDto entity);

		/// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool ClientDelete( int id, bool cache);

        /// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> ClientDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the ClientGrantType entity to the database.
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		bool ClientGrantTypeAdd(ClientGrantTypeDto entity);

        /// <summary>
        /// Save async the ClientGrantType entity to the database.
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientGrantTypeAddAsync(ClientGrantTypeDto entity);

        /// <summary>
        /// Update the ClientGrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		bool ClientGrantTypeUpdate(ClientGrantTypeDto entity);

        //// <summary>
        /// Update async the ClientGrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientGrantTypeUpdateAsync(ClientGrantTypeDto entity);
		
        /// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		bool ClientGrantTypeDelete(ClientGrantTypeDto entity);

        /// <summary>
        /// Delete async the ClientGrantType entity from the database
        /// </summary>
        /// <param name="entity">ClientGrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ClientGrantTypeDeleteAsync(ClientGrantTypeDto entity);

		/// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		bool ClientGrantTypeDelete( int clientId,  int grantTypeId, bool cache);

        /// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		Task<bool> ClientGrantTypeDeleteAsync( int clientId,  int grantTypeId, bool cache);

		
        /// <summary>
        /// Save the GrantType entity to the database.
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		bool GrantTypeAdd(GrantTypeDto entity);

        /// <summary>
        /// Save async the GrantType entity to the database.
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> GrantTypeAddAsync(GrantTypeDto entity);

        /// <summary>
        /// Update the GrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		bool GrantTypeUpdate(GrantTypeDto entity);

        //// <summary>
        /// Update async the GrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> GrantTypeUpdateAsync(GrantTypeDto entity);
		
        /// <summary>
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		bool GrantTypeDelete(GrantTypeDto entity);

        /// <summary>
        /// Delete async the GrantType entity from the database
        /// </summary>
        /// <param name="entity">GrantTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> GrantTypeDeleteAsync(GrantTypeDto entity);

		/// <summary>
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool GrantTypeDelete( int id, bool cache);

        /// <summary>
        /// Delete the GrantType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> GrantTypeDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the IdentityResource entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceAdd(IdentityResourceDto entity);

        /// <summary>
        /// Save async the IdentityResource entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceAddAsync(IdentityResourceDto entity);

        /// <summary>
        /// Update the IdentityResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceUpdate(IdentityResourceDto entity);

        //// <summary>
        /// Update async the IdentityResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceUpdateAsync(IdentityResourceDto entity);
		
        /// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceDelete(IdentityResourceDto entity);

        /// <summary>
        /// Delete async the IdentityResource entity from the database
        /// </summary>
        /// <param name="entity">IdentityResourceDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceDeleteAsync(IdentityResourceDto entity);

		/// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool IdentityResourceDelete( int id, bool cache);

        /// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the IdentityResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceClaimTypeAdd(IdentityResourceClaimTypeDto entity);

        /// <summary>
        /// Save async the IdentityResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceClaimTypeAddAsync(IdentityResourceClaimTypeDto entity);

        /// <summary>
        /// Update the IdentityResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceClaimTypeUpdate(IdentityResourceClaimTypeDto entity);

        //// <summary>
        /// Update async the IdentityResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceClaimTypeUpdateAsync(IdentityResourceClaimTypeDto entity);
		
        /// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool IdentityResourceClaimTypeDelete(IdentityResourceClaimTypeDto entity);

        /// <summary>
        /// Delete async the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">IdentityResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceClaimTypeDeleteAsync(IdentityResourceClaimTypeDto entity);

		/// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		bool IdentityResourceClaimTypeDelete( int identityResourceId,  int resourceClaimTypeId, bool cache);

        /// <summary>
        /// Delete the IdentityResourceClaimType entity async from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		Task<bool> IdentityResourceClaimTypeDeleteAsync( int identityResourceId,  int resourceClaimTypeId, bool cache);

		
        /// <summary>
        /// Save the PostLogoutRedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		bool PostLogoutRedirectUriAdd(PostLogoutRedirectUriDto entity);

        /// <summary>
        /// Save async the PostLogoutRedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> PostLogoutRedirectUriAddAsync(PostLogoutRedirectUriDto entity);

        /// <summary>
        /// Update the PostLogoutRedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		bool PostLogoutRedirectUriUpdate(PostLogoutRedirectUriDto entity);

        //// <summary>
        /// Update async the PostLogoutRedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> PostLogoutRedirectUriUpdateAsync(PostLogoutRedirectUriDto entity);
		
        /// <summary>
        /// Delete the PostLogoutRedirectUri entity from the database
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		bool PostLogoutRedirectUriDelete(PostLogoutRedirectUriDto entity);

        /// <summary>
        /// Delete async the PostLogoutRedirectUri entity from the database
        /// </summary>
        /// <param name="entity">PostLogoutRedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> PostLogoutRedirectUriDeleteAsync(PostLogoutRedirectUriDto entity);

		/// <summary>
        /// Delete the PostLogoutRedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool PostLogoutRedirectUriDelete( int id, bool cache);

        /// <summary>
        /// Delete the PostLogoutRedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> PostLogoutRedirectUriDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the RedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		bool RedirectUriAdd(RedirectUriDto entity);

        /// <summary>
        /// Save async the RedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> RedirectUriAddAsync(RedirectUriDto entity);

        /// <summary>
        /// Update the RedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		bool RedirectUriUpdate(RedirectUriDto entity);

        //// <summary>
        /// Update async the RedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> RedirectUriUpdateAsync(RedirectUriDto entity);
		
        /// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		bool RedirectUriDelete(RedirectUriDto entity);

        /// <summary>
        /// Delete async the RedirectUri entity from the database
        /// </summary>
        /// <param name="entity">RedirectUriDto</param>
        /// <returns>bool</returns>
		Task<bool> RedirectUriDeleteAsync(RedirectUriDto entity);

		/// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool RedirectUriDelete( int id, bool cache);

        /// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> RedirectUriDeleteAsync( int id, bool cache);

		
        /// <summary>
        /// Save the ResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool ResourceClaimTypeAdd(ResourceClaimTypeDto entity);

        /// <summary>
        /// Save async the ResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ResourceClaimTypeAddAsync(ResourceClaimTypeDto entity);

        /// <summary>
        /// Update the ResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool ResourceClaimTypeUpdate(ResourceClaimTypeDto entity);

        //// <summary>
        /// Update async the ResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ResourceClaimTypeUpdateAsync(ResourceClaimTypeDto entity);
		
        /// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		bool ResourceClaimTypeDelete(ResourceClaimTypeDto entity);

        /// <summary>
        /// Delete async the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">ResourceClaimTypeDto</param>
        /// <returns>bool</returns>
		Task<bool> ResourceClaimTypeDeleteAsync(ResourceClaimTypeDto entity);

		/// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		bool ResourceClaimTypeDelete( int id, bool cache);

        /// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		Task<bool> ResourceClaimTypeDeleteAsync( int id, bool cache);


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
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult AllowedScopeMax<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AllowedScopeMaxAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult AllowedScopeMin<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> AllowedScopeMinAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ApiResourceMax<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ApiResourceMaxAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ApiResourceMin<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ApiResourceMinAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ClientMax<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ClientMaxAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ClientMin<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ClientMinAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ClientGrantTypeMax<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ClientGrantTypeMaxAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ClientGrantTypeMin<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ClientGrantTypeMinAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult GrantTypeMax<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> GrantTypeMaxAsync<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult GrantTypeMin<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> GrantTypeMinAsync<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult IdentityResourceMax<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> IdentityResourceMaxAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult IdentityResourceMin<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> IdentityResourceMinAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult IdentityResourceClaimTypeMax<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> IdentityResourceClaimTypeMaxAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult IdentityResourceClaimTypeMin<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> IdentityResourceClaimTypeMinAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult PostLogoutRedirectUriMax<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> PostLogoutRedirectUriMaxAsync<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult PostLogoutRedirectUriMin<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> PostLogoutRedirectUriMinAsync<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult RedirectUriMax<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> RedirectUriMaxAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult RedirectUriMin<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> RedirectUriMinAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache);
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
        TResult ResourceClaimTypeMax<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ResourceClaimTypeMaxAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		TResult ResourceClaimTypeMin<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <param name="cache">Enable second level caching</param>
        /// <returns></returns>
		Task<TResult> ResourceClaimTypeMinAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache);

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
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  AllowedScopeBulkDelete(IEnumerable<AllowedScopeDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AllowedScopeBulkDeleteAsync(IEnumerable<AllowedScopeDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  AllowedScopeBulkInsert(IEnumerable<AllowedScopeDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AllowedScopeBulkInsertAsync(IEnumerable<AllowedScopeDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  AllowedScopeBulkUpdate(IEnumerable<AllowedScopeDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  AllowedScopeBulkUpdateAsync(IEnumerable<AllowedScopeDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ApiResourceBulkDelete(IEnumerable<ApiResourceDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ApiResourceBulkDeleteAsync(IEnumerable<ApiResourceDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ApiResourceBulkInsert(IEnumerable<ApiResourceDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ApiResourceBulkInsertAsync(IEnumerable<ApiResourceDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ApiResourceBulkUpdate(IEnumerable<ApiResourceDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ApiResourceBulkUpdateAsync(IEnumerable<ApiResourceDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ClientBulkDelete(IEnumerable<ClientDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientBulkDeleteAsync(IEnumerable<ClientDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ClientBulkInsert(IEnumerable<ClientDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientBulkInsertAsync(IEnumerable<ClientDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ClientBulkUpdate(IEnumerable<ClientDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientBulkUpdateAsync(IEnumerable<ClientDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ClientGrantTypeBulkDelete(IEnumerable<ClientGrantTypeDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientGrantTypeBulkDeleteAsync(IEnumerable<ClientGrantTypeDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ClientGrantTypeBulkInsert(IEnumerable<ClientGrantTypeDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientGrantTypeBulkInsertAsync(IEnumerable<ClientGrantTypeDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ClientGrantTypeBulkUpdate(IEnumerable<ClientGrantTypeDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ClientGrantTypeBulkUpdateAsync(IEnumerable<ClientGrantTypeDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  GrantTypeBulkDelete(IEnumerable<GrantTypeDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  GrantTypeBulkDeleteAsync(IEnumerable<GrantTypeDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  GrantTypeBulkInsert(IEnumerable<GrantTypeDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  GrantTypeBulkInsertAsync(IEnumerable<GrantTypeDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  GrantTypeBulkUpdate(IEnumerable<GrantTypeDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  GrantTypeBulkUpdateAsync(IEnumerable<GrantTypeDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceBulkDelete(IEnumerable<IdentityResourceDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceBulkDeleteAsync(IEnumerable<IdentityResourceDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceBulkInsert(IEnumerable<IdentityResourceDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceBulkInsertAsync(IEnumerable<IdentityResourceDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceBulkUpdate(IEnumerable<IdentityResourceDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceBulkUpdateAsync(IEnumerable<IdentityResourceDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceClaimTypeBulkDelete(IEnumerable<IdentityResourceClaimTypeDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceClaimTypeBulkDeleteAsync(IEnumerable<IdentityResourceClaimTypeDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceClaimTypeBulkInsert(IEnumerable<IdentityResourceClaimTypeDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceClaimTypeBulkInsertAsync(IEnumerable<IdentityResourceClaimTypeDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  IdentityResourceClaimTypeBulkUpdate(IEnumerable<IdentityResourceClaimTypeDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  IdentityResourceClaimTypeBulkUpdateAsync(IEnumerable<IdentityResourceClaimTypeDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  PostLogoutRedirectUriBulkDelete(IEnumerable<PostLogoutRedirectUriDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  PostLogoutRedirectUriBulkDeleteAsync(IEnumerable<PostLogoutRedirectUriDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  PostLogoutRedirectUriBulkInsert(IEnumerable<PostLogoutRedirectUriDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  PostLogoutRedirectUriBulkInsertAsync(IEnumerable<PostLogoutRedirectUriDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  PostLogoutRedirectUriBulkUpdate(IEnumerable<PostLogoutRedirectUriDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  PostLogoutRedirectUriBulkUpdateAsync(IEnumerable<PostLogoutRedirectUriDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  RedirectUriBulkDelete(IEnumerable<RedirectUriDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  RedirectUriBulkDeleteAsync(IEnumerable<RedirectUriDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  RedirectUriBulkInsert(IEnumerable<RedirectUriDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  RedirectUriBulkInsertAsync(IEnumerable<RedirectUriDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  RedirectUriBulkUpdate(IEnumerable<RedirectUriDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  RedirectUriBulkUpdateAsync(IEnumerable<RedirectUriDto> items);
	
        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        void  ResourceClaimTypeBulkDelete(IEnumerable<ResourceClaimTypeDto> items);

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ResourceClaimTypeBulkDeleteAsync(IEnumerable<ResourceClaimTypeDto> items);

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        void  ResourceClaimTypeBulkInsert(IEnumerable<ResourceClaimTypeDto> items);
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ResourceClaimTypeBulkInsertAsync(IEnumerable<ResourceClaimTypeDto> items);

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        void  ResourceClaimTypeBulkUpdate(IEnumerable<ResourceClaimTypeDto> items);

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        Task  ResourceClaimTypeBulkUpdateAsync(IEnumerable<ResourceClaimTypeDto> items);

        #endregion
    }
}

