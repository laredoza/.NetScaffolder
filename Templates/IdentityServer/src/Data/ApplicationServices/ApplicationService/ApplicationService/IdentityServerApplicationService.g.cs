
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
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.ModelInterfaces.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

namespace DotNetScaffolder.Domain.ApplicationService
{
    /// <summary>
	/// The IdentityServerApplication Service 
	/// </summary>
	public partial class IdentityServerApplicationService  : IIdentityServerApplicationService
	{

        /// <summary>
        /// Gets or sets the AspNetRole Repository 
        /// </summary>
        protected IAspNetRoleRepository AspNetRoleRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetRoleClaim Repository 
        /// </summary>
        protected IAspNetRoleClaimRepository AspNetRoleClaimRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetUser Repository 
        /// </summary>
        protected IAspNetUserRepository AspNetUserRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetUserClaim Repository 
        /// </summary>
        protected IAspNetUserClaimRepository AspNetUserClaimRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetUserLogin Repository 
        /// </summary>
        protected IAspNetUserLoginRepository AspNetUserLoginRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetUserRole Repository 
        /// </summary>
        protected IAspNetUserRoleRepository AspNetUserRoleRepository { get; set; }
        /// <summary>
        /// Gets or sets the AspNetUserToken Repository 
        /// </summary>
        protected IAspNetUserTokenRepository AspNetUserTokenRepository { get; set; }

        public IdentityServerApplicationService (
                                          IAspNetRoleRepository aspNetRoleRepository,
                                                              IAspNetRoleClaimRepository aspNetRoleClaimRepository,
                                                              IAspNetUserRepository aspNetUserRepository,
                                                              IAspNetUserClaimRepository aspNetUserClaimRepository,
                                                              IAspNetUserLoginRepository aspNetUserLoginRepository,
                                                              IAspNetUserRoleRepository aspNetUserRoleRepository,
                                          IAspNetUserTokenRepository aspNetUserTokenRepository
                                     )
        {
            this.AspNetRoleRepository = aspNetRoleRepository;
            this.AspNetRoleClaimRepository = aspNetRoleClaimRepository;
            this.AspNetUserRepository = aspNetUserRepository;
            this.AspNetUserClaimRepository = aspNetUserClaimRepository;
            this.AspNetUserLoginRepository = aspNetUserLoginRepository;
            this.AspNetUserRoleRepository = aspNetUserRoleRepository;
            this.AspNetUserTokenRepository = aspNetUserTokenRepository;
        }

        #region Load

        /// <summary>
        /// Load AspNetRole entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <returns>AspNetRoleDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
		public AspNetRoleDto LoadByAspNetRoleId(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return new AspNetRoleDto(this.AspNetRoleRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetRole Async entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <returns>AspNetRoleDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
		public async Task<AspNetRoleDto> LoadByAspNetRoleIdAsync(string id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return new AspNetRoleDto(await this.AspNetRoleRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetRole entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public IList<AspNetRoleDto> AspNetRoleLoadAll(bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(this.AspNetRoleRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetRole Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public async Task<IList<AspNetRoleDto>> AspNetRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto( await this.AspNetRoleRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetRoleClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
		public AspNetRoleClaimDto LoadByAspNetRoleClaimId(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return new AspNetRoleClaimDto(this.AspNetRoleClaimRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetRoleClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetRoleClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
		public async Task<AspNetRoleClaimDto> LoadByAspNetRoleClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return new AspNetRoleClaimDto(await this.AspNetRoleClaimRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetRoleClaim entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public IList<AspNetRoleClaimDto> AspNetRoleClaimLoadAll(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(this.AspNetRoleClaimRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetRoleClaim Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public async Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto( await this.AspNetRoleClaimRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetUser entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <returns>AspNetUserDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
		public AspNetUserDto LoadByAspNetUserId(string id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return new AspNetUserDto(this.AspNetUserRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUser Async entities from the database using the primary key
        /// </summary
        /// <param name="id">string</param>
        /// <returns>AspNetUserDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
		public async Task<AspNetUserDto> LoadByAspNetUserIdAsync(string id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return new AspNetUserDto(await this.AspNetUserRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetUser entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserLoadAll(bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetUser Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserLoadAllAsync(bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto( await this.AspNetUserRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetUserClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetUserClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
		public AspNetUserClaimDto LoadByAspNetUserClaimId(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return new AspNetUserClaimDto(this.AspNetUserClaimRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetUserClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
		public async Task<AspNetUserClaimDto> LoadByAspNetUserClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return new AspNetUserClaimDto(await this.AspNetUserClaimRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetUserClaim entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public IList<AspNetUserClaimDto> AspNetUserClaimLoadAll(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(this.AspNetUserClaimRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetUserClaim Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public async Task<IList<AspNetUserClaimDto>> AspNetUserClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto( await this.AspNetUserClaimRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetUserLogin entities from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLoginDto</returns>
		public AspNetUserLoginDto Load( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return new AspNetUserLoginDto(this.AspNetUserLoginRepository.Load( loginProvider,  providerKey, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserLogin Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>AspNetUserLoginDto</returns>
		public async Task<AspNetUserLoginDto> LoadAsync( string loginProvider,  string providerKey, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return new AspNetUserLoginDto(await this.AspNetUserLoginRepository.LoadAsync( loginProvider,  providerKey, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserLogin entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public IList<AspNetUserLoginDto> AspNetUserLoginLoadAll(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto(this.AspNetUserLoginRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetUserLogin Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public async Task<IList<AspNetUserLoginDto>> AspNetUserLoginLoadAllAsync(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto( await this.AspNetUserLoginRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetUserRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRoleDto</returns>
		public AspNetUserRoleDto Load( string userId,  string roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return new AspNetUserRoleDto(this.AspNetUserRoleRepository.Load( userId,  roleId, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserRole Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRoleDto</returns>
		public async Task<AspNetUserRoleDto> LoadAsync( string userId,  string roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return new AspNetUserRoleDto(await this.AspNetUserRoleRepository.LoadAsync( userId,  roleId, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserRole entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		public IList<AspNetUserRoleDto> AspNetUserRoleLoadAll(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return this.ConvertAspNetUserRoleEntityToDto(this.AspNetUserRoleRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetUserRole Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		public async Task<IList<AspNetUserRoleDto>> AspNetUserRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return this.ConvertAspNetUserRoleEntityToDto( await this.AspNetUserRoleRepository.LoadAllAsync(cache, includes));
        }


        /// <summary>
        /// Load AspNetUserToken entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserTokenDto</returns>
		public AspNetUserTokenDto Load( string userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return new AspNetUserTokenDto(this.AspNetUserTokenRepository.Load( userId,  loginProvider,  name, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserToken Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserTokenDto</returns>
		public async Task<AspNetUserTokenDto> LoadAsync( string userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return new AspNetUserTokenDto(await this.AspNetUserTokenRepository.LoadAsync( userId,  loginProvider,  name, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserToken entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public IList<AspNetUserTokenDto> AspNetUserTokenLoadAll(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return this.ConvertAspNetUserTokenEntityToDto(this.AspNetUserTokenRepository.LoadAll(cache, includes));
        }

        /// <summary>
        /// Load all AspNetUserToken Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public async Task<IList<AspNetUserTokenDto>> AspNetUserTokenLoadAllAsync(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return this.ConvertAspNetUserTokenEntityToDto( await this.AspNetUserTokenRepository.LoadAllAsync(cache, includes));
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for AspNetRole entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public IList<AspNetRoleDto> AspNetRoleSearchByName(string name, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(this.AspNetRoleRepository.SearchByName(name,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRole Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public async Task<IList<AspNetRoleDto>> AspNetRoleSearchByNameAsync(string name, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(await this.AspNetRoleRepository.SearchByNameAsync(name,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetRole entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public IList<AspNetRoleDto> AspNetRoleSearchByNormalizedName(string normalizedName, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(this.AspNetRoleRepository.SearchByNormalizedName(normalizedName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRole Async entities in the database by NormalizedName
        /// </summary>
        /// <param name="normalizedName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public async Task<IList<AspNetRoleDto>> AspNetRoleSearchByNormalizedNameAsync(string normalizedName, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(await this.AspNetRoleRepository.SearchByNormalizedNameAsync(normalizedName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetRole entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public IList<AspNetRoleDto> AspNetRoleSearchByConcurrencyStamp(string concurrencyStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(this.AspNetRoleRepository.SearchByConcurrencyStamp(concurrencyStamp,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRole Async entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public async Task<IList<AspNetRoleDto>> AspNetRoleSearchByConcurrencyStampAsync(string concurrencyStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return this.ConvertAspNetRoleEntityToDto(await this.AspNetRoleRepository.SearchByConcurrencyStampAsync(concurrencyStamp,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByRoleId(string roleId, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(this.AspNetRoleClaimRepository.SearchByRoleId(roleId,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRoleClaim Async entities in the database by RoleId
        /// </summary>
        /// <param name="roleId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public async Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByRoleIdAsync(string roleId, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(await this.AspNetRoleClaimRepository.SearchByRoleIdAsync(roleId,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByClaimType(string claimType, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(this.AspNetRoleClaimRepository.SearchByClaimType(claimType,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRoleClaim Async entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public async Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByClaimTypeAsync(string claimType, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(await this.AspNetRoleClaimRepository.SearchByClaimTypeAsync(claimType,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetRoleClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public IList<AspNetRoleClaimDto> AspNetRoleClaimSearchByClaimValue(string claimValue, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(this.AspNetRoleClaimRepository.SearchByClaimValue(claimValue,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetRoleClaim Async entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public async Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimSearchByClaimValueAsync(string claimValue, bool caseSensitive, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return this.ConvertAspNetRoleClaimEntityToDto(await this.AspNetRoleClaimRepository.SearchByClaimValueAsync(claimValue,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByUserName(string userName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByUserName(userName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by UserName
        /// </summary>
        /// <param name="userName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByUserNameAsync(string userName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByUserNameAsync(userName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByNormalizedUserName(string normalizedUserName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByNormalizedUserName(normalizedUserName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by NormalizedUserName
        /// </summary>
        /// <param name="normalizedUserName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByNormalizedUserNameAsync(string normalizedUserName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByNormalizedUserNameAsync(normalizedUserName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByEmail(string email, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByEmail(email,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by Email
        /// </summary>
        /// <param name="email">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByEmailAsync(string email, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByEmailAsync(email,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByNormalizedEmail(string normalizedEmail, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByNormalizedEmail(normalizedEmail,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by NormalizedEmail
        /// </summary>
        /// <param name="normalizedEmail">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByNormalizedEmailAsync(string normalizedEmail, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByNormalizedEmailAsync(normalizedEmail,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByPasswordHash(string passwordHash, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByPasswordHash(passwordHash,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by PasswordHash
        /// </summary>
        /// <param name="passwordHash">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByPasswordHashAsync(string passwordHash, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByPasswordHashAsync(passwordHash,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchBySecurityStamp(string securityStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchBySecurityStamp(securityStamp,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by SecurityStamp
        /// </summary>
        /// <param name="securityStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchBySecurityStampAsync(string securityStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchBySecurityStampAsync(securityStamp,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByConcurrencyStamp(string concurrencyStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByConcurrencyStamp(concurrencyStamp,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by ConcurrencyStamp
        /// </summary>
        /// <param name="concurrencyStamp">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByConcurrencyStampAsync(string concurrencyStamp, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByConcurrencyStampAsync(concurrencyStamp,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUser entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserSearchByPhoneNumber(string phoneNumber, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(this.AspNetUserRepository.SearchByPhoneNumber(phoneNumber,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUser Async entities in the database by PhoneNumber
        /// </summary>
        /// <param name="phoneNumber">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserSearchByPhoneNumberAsync(string phoneNumber, bool caseSensitive, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return this.ConvertAspNetUserEntityToDto(await this.AspNetUserRepository.SearchByPhoneNumberAsync(phoneNumber,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public IList<AspNetUserClaimDto> AspNetUserClaimSearchByUserId(string userId, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(this.AspNetUserClaimRepository.SearchByUserId(userId,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserClaim Async entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public async Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByUserIdAsync(string userId, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(await this.AspNetUserClaimRepository.SearchByUserIdAsync(userId,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public IList<AspNetUserClaimDto> AspNetUserClaimSearchByClaimType(string claimType, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(this.AspNetUserClaimRepository.SearchByClaimType(claimType,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserClaim Async entities in the database by ClaimType
        /// </summary>
        /// <param name="claimType">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public async Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByClaimTypeAsync(string claimType, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(await this.AspNetUserClaimRepository.SearchByClaimTypeAsync(claimType,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserClaim entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public IList<AspNetUserClaimDto> AspNetUserClaimSearchByClaimValue(string claimValue, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(this.AspNetUserClaimRepository.SearchByClaimValue(claimValue,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserClaim Async entities in the database by ClaimValue
        /// </summary>
        /// <param name="claimValue">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public async Task<IList<AspNetUserClaimDto>> AspNetUserClaimSearchByClaimValueAsync(string claimValue, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return this.ConvertAspNetUserClaimEntityToDto(await this.AspNetUserClaimRepository.SearchByClaimValueAsync(claimValue,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserLogin entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public IList<AspNetUserLoginDto> AspNetUserLoginSearchByProviderDisplayName(string providerDisplayName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto(this.AspNetUserLoginRepository.SearchByProviderDisplayName(providerDisplayName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserLogin Async entities in the database by ProviderDisplayName
        /// </summary>
        /// <param name="providerDisplayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public async Task<IList<AspNetUserLoginDto>> AspNetUserLoginSearchByProviderDisplayNameAsync(string providerDisplayName, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto(await this.AspNetUserLoginRepository.SearchByProviderDisplayNameAsync(providerDisplayName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserLogin entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public IList<AspNetUserLoginDto> AspNetUserLoginSearchByUserId(string userId, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto(this.AspNetUserLoginRepository.SearchByUserId(userId,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserLogin Async entities in the database by UserId
        /// </summary>
        /// <param name="userId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public async Task<IList<AspNetUserLoginDto>> AspNetUserLoginSearchByUserIdAsync(string userId, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            return this.ConvertAspNetUserLoginEntityToDto(await this.AspNetUserLoginRepository.SearchByUserIdAsync(userId,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for AspNetUserToken entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public IList<AspNetUserTokenDto> AspNetUserTokenSearchByValue(string value, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return this.ConvertAspNetUserTokenEntityToDto(this.AspNetUserTokenRepository.SearchByValue(value,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AspNetUserToken Async entities in the database by Value
        /// </summary>
        /// <param name="value">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public async Task<IList<AspNetUserTokenDto>> AspNetUserTokenSearchByValueAsync(string value, bool caseSensitive, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return this.ConvertAspNetUserTokenEntityToDto(await this.AspNetUserTokenRepository.SearchByValueAsync(value,caseSensitive, cache, includes));
        }

		#endregion

		#region Modifiers
		
        /// <summary>
        /// Add the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleAdd(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Add(new AspNetRole(entity, true));
        }

        /// <summary>
        /// Add the AspNetRole entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleAddAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.AddAsync(new AspNetRole(entity, true));
        }

        /// <summary>
        /// Update the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleUpdate(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Update(new AspNetRole(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleUpdateAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.UpdateAsync(new AspNetRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleDelete(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Delete(new AspNetRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleDeleteAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.DeleteAsync(new AspNetRole(entity, true));
        }

		/// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public bool AspNetRoleDelete( string id, bool cache)
        {
            return this.AspNetRoleRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleDeleteAsync( string id, bool cache)
        {
            return await this.AspNetRoleRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the AspNetRoleClaim entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimAdd(AspNetRoleClaimDto entity)
        {
            return this.AspNetRoleClaimRepository.Add(new AspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Add the AspNetRoleClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimAddAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.AddAsync(new AspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Update the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimUpdate(AspNetRoleClaimDto entity)
        {
            return this.AspNetRoleClaimRepository.Update(new AspNetRoleClaim(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetRoleClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimUpdateAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.UpdateAsync(new AspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimDelete(AspNetRoleClaimDto entity)
        {
            return this.AspNetRoleClaimRepository.Delete(new AspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimDeleteAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.DeleteAsync(new AspNetRoleClaim(entity, true));
        }

		/// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimDelete( int id, bool cache)
        {
            return this.AspNetRoleClaimRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimDeleteAsync( int id, bool cache)
        {
            return await this.AspNetRoleClaimRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the AspNetUser entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public bool AspNetUserAdd(AspNetUserDto entity)
        {
            return this.AspNetUserRepository.Add(new AspNetUser(entity, true));
        }

        /// <summary>
        /// Add the AspNetUser entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserAddAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.AddAsync(new AspNetUser(entity, true));
        }

        /// <summary>
        /// Update the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public bool AspNetUserUpdate(AspNetUserDto entity)
        {
            return this.AspNetUserRepository.Update(new AspNetUser(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUser entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserUpdateAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.UpdateAsync(new AspNetUser(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public bool AspNetUserDelete(AspNetUserDto entity)
        {
            return this.AspNetUserRepository.Delete(new AspNetUser(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserDeleteAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.DeleteAsync(new AspNetUser(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public bool AspNetUserDelete( string id, bool cache)
        {
            return this.AspNetUserRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="id">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserDeleteAsync( string id, bool cache)
        {
            return await this.AspNetUserRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the AspNetUserClaim entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimAdd(AspNetUserClaimDto entity)
        {
            return this.AspNetUserClaimRepository.Add(new AspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimAddAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.AddAsync(new AspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimUpdate(AspNetUserClaimDto entity)
        {
            return this.AspNetUserClaimRepository.Update(new AspNetUserClaim(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimUpdateAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.UpdateAsync(new AspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimDelete(AspNetUserClaimDto entity)
        {
            return this.AspNetUserClaimRepository.Delete(new AspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimDeleteAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.DeleteAsync(new AspNetUserClaim(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimDelete( int id, bool cache)
        {
            return this.AspNetUserClaimRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimDeleteAsync( int id, bool cache)
        {
            return await this.AspNetUserClaimRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the AspNetUserLogin entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginAdd(AspNetUserLoginDto entity)
        {
            return this.AspNetUserLoginRepository.Add(new AspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserLogin entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginAddAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.AddAsync(new AspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginUpdate(AspNetUserLoginDto entity)
        {
            return this.AspNetUserLoginRepository.Update(new AspNetUserLogin(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserLogin entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginUpdateAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.UpdateAsync(new AspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginDelete(AspNetUserLoginDto entity)
        {
            return this.AspNetUserLoginRepository.Delete(new AspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginDeleteAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.DeleteAsync(new AspNetUserLogin(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginDelete( string loginProvider,  string providerKey, bool cache)
        {
            return this.AspNetUserLoginRepository.Delete( loginProvider,  providerKey, cache);
        }

        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="loginProvider">string</param>
        /// <param name="providerKey">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginDeleteAsync( string loginProvider,  string providerKey, bool cache)
        {
            return await this.AspNetUserLoginRepository.DeleteAsync( loginProvider,  providerKey, cache);
        }

		
        /// <summary>
        /// Add the AspNetUserRole entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleAdd(AspNetUserRoleDto entity)
        {
            return this.AspNetUserRoleRepository.Add(new AspNetUserRole(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserRole entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleAddAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.AddAsync(new AspNetUserRole(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleUpdate(AspNetUserRoleDto entity)
        {
            return this.AspNetUserRoleRepository.Update(new AspNetUserRole(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleUpdateAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.UpdateAsync(new AspNetUserRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleDelete(AspNetUserRoleDto entity)
        {
            return this.AspNetUserRoleRepository.Delete(new AspNetUserRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleDeleteAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.DeleteAsync(new AspNetUserRole(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleDelete( string userId,  string roleId, bool cache)
        {
            return this.AspNetUserRoleRepository.Delete( userId,  roleId, cache);
        }

        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="roleId">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleDeleteAsync( string userId,  string roleId, bool cache)
        {
            return await this.AspNetUserRoleRepository.DeleteAsync( userId,  roleId, cache);
        }

		
        /// <summary>
        /// Add the AspNetUserToken entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenAdd(AspNetUserTokenDto entity)
        {
            return this.AspNetUserTokenRepository.Add(new AspNetUserToken(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserToken entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenAddAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.AddAsync(new AspNetUserToken(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserToken entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenUpdate(AspNetUserTokenDto entity)
        {
            return this.AspNetUserTokenRepository.Update(new AspNetUserToken(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserToken entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenUpdateAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.UpdateAsync(new AspNetUserToken(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenDelete(AspNetUserTokenDto entity)
        {
            return this.AspNetUserTokenRepository.Delete(new AspNetUserToken(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenDeleteAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.DeleteAsync(new AspNetUserToken(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenDelete( string userId,  string loginProvider,  string name, bool cache)
        {
            return this.AspNetUserTokenRepository.Delete( userId,  loginProvider,  name, cache);
        }

        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="userId">string</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenDeleteAsync( string userId,  string loginProvider,  string name, bool cache)
        {
            return await this.AspNetUserTokenRepository.DeleteAsync( userId,  loginProvider,  name, cache);
        }


		#endregion

        #region Aggregates
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetRoleMax<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetRoleRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetRoleMaxAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetRoleRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetRoleMin<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetRoleRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRole, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetRoleMinAsync<TResult>(Expression<Func<IAspNetRole, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetRoleRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetRoleClaimMax<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetRoleClaimRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetRoleClaimMaxAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetRoleClaimRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetRoleClaimMin<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetRoleClaimRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetRoleClaim, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetRoleClaimMinAsync<TResult>(Expression<Func<IAspNetRoleClaim, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetRoleClaimRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetUserMax<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetUserMaxAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetUserMin<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUser, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetUserMinAsync<TResult>(Expression<Func<IAspNetUser, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetUserClaimMax<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserClaimRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetUserClaimMaxAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserClaimRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetUserClaimMin<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserClaimRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserClaim, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetUserClaimMinAsync<TResult>(Expression<Func<IAspNetUserClaim, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserClaimRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetUserLoginMax<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserLoginRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetUserLoginMaxAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserLoginRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetUserLoginMin<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserLoginRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserLogin, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetUserLoginMinAsync<TResult>(Expression<Func<IAspNetUserLogin, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserLoginRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetUserRoleMax<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserRoleRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetUserRoleMaxAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserRoleRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetUserRoleMin<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserRoleRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserRole, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetUserRoleMinAsync<TResult>(Expression<Func<IAspNetUserRole, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserRoleRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AspNetUserTokenMax<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserTokenRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AspNetUserTokenMaxAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserTokenRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AspNetUserTokenMin<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
        {
		    return this.AspNetUserTokenRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAspNetUserToken, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AspNetUserTokenMinAsync<TResult>(Expression<Func<IAspNetUserToken, TResult>> maxExpression, bool cache)
        {
		    return await this.AspNetUserTokenRepository.MinAsync(maxExpression, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        /// Converts a AspNetRoleDto list to AspNetRole list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetRole> ConvertAspNetRoleDtoToEntity(IEnumerable<AspNetRoleDto> items)
	    {
            List<AspNetRole> results = new List<AspNetRole>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetRole(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetRole list to AspNetRoleDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetRoleDto> ConvertAspNetRoleEntityToDto(IEnumerable<AspNetRole> items)
	    {
            List<AspNetRoleDto> results = new List<AspNetRoleDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetRoleDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetRoleBulkDelete(IEnumerable<AspNetRoleDto> items)
		{
			this.AspNetRoleRepository.BulkDelete(this.ConvertAspNetRoleDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetRoleBulkDeleteAsync(IEnumerable<AspNetRoleDto> items)
		{
			await this.AspNetRoleRepository.BulkDeleteAsync(this.ConvertAspNetRoleDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetRoleBulkInsert(IEnumerable<AspNetRoleDto> items)
		{
			this.AspNetRoleRepository.BulkInsert(this.ConvertAspNetRoleDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetRoleBulkInsertAsync(IEnumerable<AspNetRoleDto> items)
		{
			await this.AspNetRoleRepository.BulkInsertAsync(this.ConvertAspNetRoleDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetRoleBulkUpdate(IEnumerable<AspNetRoleDto> items)
		{
			this.AspNetRoleRepository.BulkUpdate(this.ConvertAspNetRoleDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetRoleBulkUpdateAsync(IEnumerable<AspNetRoleDto> items)
		{
			await this.AspNetRoleRepository.BulkUpdateAsync(this.ConvertAspNetRoleDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetRoleClaimDto list to AspNetRoleClaim list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetRoleClaim> ConvertAspNetRoleClaimDtoToEntity(IEnumerable<AspNetRoleClaimDto> items)
	    {
            List<AspNetRoleClaim> results = new List<AspNetRoleClaim>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetRoleClaim(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetRoleClaim list to AspNetRoleClaimDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetRoleClaimDto> ConvertAspNetRoleClaimEntityToDto(IEnumerable<AspNetRoleClaim> items)
	    {
            List<AspNetRoleClaimDto> results = new List<AspNetRoleClaimDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetRoleClaimDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetRoleClaimBulkDelete(IEnumerable<AspNetRoleClaimDto> items)
		{
			this.AspNetRoleClaimRepository.BulkDelete(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetRoleClaimBulkDeleteAsync(IEnumerable<AspNetRoleClaimDto> items)
		{
			await this.AspNetRoleClaimRepository.BulkDeleteAsync(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetRoleClaimBulkInsert(IEnumerable<AspNetRoleClaimDto> items)
		{
			this.AspNetRoleClaimRepository.BulkInsert(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetRoleClaimBulkInsertAsync(IEnumerable<AspNetRoleClaimDto> items)
		{
			await this.AspNetRoleClaimRepository.BulkInsertAsync(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetRoleClaimBulkUpdate(IEnumerable<AspNetRoleClaimDto> items)
		{
			this.AspNetRoleClaimRepository.BulkUpdate(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetRoleClaimBulkUpdateAsync(IEnumerable<AspNetRoleClaimDto> items)
		{
			await this.AspNetRoleClaimRepository.BulkUpdateAsync(this.ConvertAspNetRoleClaimDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetUserDto list to AspNetUser list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUser> ConvertAspNetUserDtoToEntity(IEnumerable<AspNetUserDto> items)
	    {
            List<AspNetUser> results = new List<AspNetUser>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUser(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetUser list to AspNetUserDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserDto> ConvertAspNetUserEntityToDto(IEnumerable<AspNetUser> items)
	    {
            List<AspNetUserDto> results = new List<AspNetUserDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetUserBulkDelete(IEnumerable<AspNetUserDto> items)
		{
			this.AspNetUserRepository.BulkDelete(this.ConvertAspNetUserDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetUserBulkDeleteAsync(IEnumerable<AspNetUserDto> items)
		{
			await this.AspNetUserRepository.BulkDeleteAsync(this.ConvertAspNetUserDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserBulkInsert(IEnumerable<AspNetUserDto> items)
		{
			this.AspNetUserRepository.BulkInsert(this.ConvertAspNetUserDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserBulkInsertAsync(IEnumerable<AspNetUserDto> items)
		{
			await this.AspNetUserRepository.BulkInsertAsync(this.ConvertAspNetUserDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserBulkUpdate(IEnumerable<AspNetUserDto> items)
		{
			this.AspNetUserRepository.BulkUpdate(this.ConvertAspNetUserDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserBulkUpdateAsync(IEnumerable<AspNetUserDto> items)
		{
			await this.AspNetUserRepository.BulkUpdateAsync(this.ConvertAspNetUserDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetUserClaimDto list to AspNetUserClaim list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserClaim> ConvertAspNetUserClaimDtoToEntity(IEnumerable<AspNetUserClaimDto> items)
	    {
            List<AspNetUserClaim> results = new List<AspNetUserClaim>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserClaim(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetUserClaim list to AspNetUserClaimDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserClaimDto> ConvertAspNetUserClaimEntityToDto(IEnumerable<AspNetUserClaim> items)
	    {
            List<AspNetUserClaimDto> results = new List<AspNetUserClaimDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserClaimDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetUserClaimBulkDelete(IEnumerable<AspNetUserClaimDto> items)
		{
			this.AspNetUserClaimRepository.BulkDelete(this.ConvertAspNetUserClaimDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetUserClaimBulkDeleteAsync(IEnumerable<AspNetUserClaimDto> items)
		{
			await this.AspNetUserClaimRepository.BulkDeleteAsync(this.ConvertAspNetUserClaimDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserClaimBulkInsert(IEnumerable<AspNetUserClaimDto> items)
		{
			this.AspNetUserClaimRepository.BulkInsert(this.ConvertAspNetUserClaimDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserClaimBulkInsertAsync(IEnumerable<AspNetUserClaimDto> items)
		{
			await this.AspNetUserClaimRepository.BulkInsertAsync(this.ConvertAspNetUserClaimDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserClaimBulkUpdate(IEnumerable<AspNetUserClaimDto> items)
		{
			this.AspNetUserClaimRepository.BulkUpdate(this.ConvertAspNetUserClaimDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserClaimBulkUpdateAsync(IEnumerable<AspNetUserClaimDto> items)
		{
			await this.AspNetUserClaimRepository.BulkUpdateAsync(this.ConvertAspNetUserClaimDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetUserLoginDto list to AspNetUserLogin list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserLogin> ConvertAspNetUserLoginDtoToEntity(IEnumerable<AspNetUserLoginDto> items)
	    {
            List<AspNetUserLogin> results = new List<AspNetUserLogin>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserLogin(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetUserLogin list to AspNetUserLoginDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserLoginDto> ConvertAspNetUserLoginEntityToDto(IEnumerable<AspNetUserLogin> items)
	    {
            List<AspNetUserLoginDto> results = new List<AspNetUserLoginDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserLoginDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetUserLoginBulkDelete(IEnumerable<AspNetUserLoginDto> items)
		{
			this.AspNetUserLoginRepository.BulkDelete(this.ConvertAspNetUserLoginDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetUserLoginBulkDeleteAsync(IEnumerable<AspNetUserLoginDto> items)
		{
			await this.AspNetUserLoginRepository.BulkDeleteAsync(this.ConvertAspNetUserLoginDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserLoginBulkInsert(IEnumerable<AspNetUserLoginDto> items)
		{
			this.AspNetUserLoginRepository.BulkInsert(this.ConvertAspNetUserLoginDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserLoginBulkInsertAsync(IEnumerable<AspNetUserLoginDto> items)
		{
			await this.AspNetUserLoginRepository.BulkInsertAsync(this.ConvertAspNetUserLoginDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserLoginBulkUpdate(IEnumerable<AspNetUserLoginDto> items)
		{
			this.AspNetUserLoginRepository.BulkUpdate(this.ConvertAspNetUserLoginDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserLoginBulkUpdateAsync(IEnumerable<AspNetUserLoginDto> items)
		{
			await this.AspNetUserLoginRepository.BulkUpdateAsync(this.ConvertAspNetUserLoginDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetUserRoleDto list to AspNetUserRole list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserRole> ConvertAspNetUserRoleDtoToEntity(IEnumerable<AspNetUserRoleDto> items)
	    {
            List<AspNetUserRole> results = new List<AspNetUserRole>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserRole(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetUserRole list to AspNetUserRoleDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserRoleDto> ConvertAspNetUserRoleEntityToDto(IEnumerable<AspNetUserRole> items)
	    {
            List<AspNetUserRoleDto> results = new List<AspNetUserRoleDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserRoleDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetUserRoleBulkDelete(IEnumerable<AspNetUserRoleDto> items)
		{
			this.AspNetUserRoleRepository.BulkDelete(this.ConvertAspNetUserRoleDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetUserRoleBulkDeleteAsync(IEnumerable<AspNetUserRoleDto> items)
		{
			await this.AspNetUserRoleRepository.BulkDeleteAsync(this.ConvertAspNetUserRoleDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserRoleBulkInsert(IEnumerable<AspNetUserRoleDto> items)
		{
			this.AspNetUserRoleRepository.BulkInsert(this.ConvertAspNetUserRoleDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserRoleBulkInsertAsync(IEnumerable<AspNetUserRoleDto> items)
		{
			await this.AspNetUserRoleRepository.BulkInsertAsync(this.ConvertAspNetUserRoleDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserRoleBulkUpdate(IEnumerable<AspNetUserRoleDto> items)
		{
			this.AspNetUserRoleRepository.BulkUpdate(this.ConvertAspNetUserRoleDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserRoleBulkUpdateAsync(IEnumerable<AspNetUserRoleDto> items)
		{
			await this.AspNetUserRoleRepository.BulkUpdateAsync(this.ConvertAspNetUserRoleDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a AspNetUserTokenDto list to AspNetUserToken list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserToken> ConvertAspNetUserTokenDtoToEntity(IEnumerable<AspNetUserTokenDto> items)
	    {
            List<AspNetUserToken> results = new List<AspNetUserToken>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserToken(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AspNetUserToken list to AspNetUserTokenDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AspNetUserTokenDto> ConvertAspNetUserTokenEntityToDto(IEnumerable<AspNetUserToken> items)
	    {
            List<AspNetUserTokenDto> results = new List<AspNetUserTokenDto>();

	        foreach (var item in items)
	        {
	            results.Add(new AspNetUserTokenDto(item, true));
	        }

	        return results;
	    }

        /// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AspNetUserTokenBulkDelete(IEnumerable<AspNetUserTokenDto> items)
		{
			this.AspNetUserTokenRepository.BulkDelete(this.ConvertAspNetUserTokenDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AspNetUserTokenBulkDeleteAsync(IEnumerable<AspNetUserTokenDto> items)
		{
			await this.AspNetUserTokenRepository.BulkDeleteAsync(this.ConvertAspNetUserTokenDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserTokenBulkInsert(IEnumerable<AspNetUserTokenDto> items)
		{
			this.AspNetUserTokenRepository.BulkInsert(this.ConvertAspNetUserTokenDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserTokenBulkInsertAsync(IEnumerable<AspNetUserTokenDto> items)
		{
			await this.AspNetUserTokenRepository.BulkInsertAsync(this.ConvertAspNetUserTokenDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AspNetUserTokenBulkUpdate(IEnumerable<AspNetUserTokenDto> items)
		{
			this.AspNetUserTokenRepository.BulkUpdate(this.ConvertAspNetUserTokenDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AspNetUserTokenBulkUpdateAsync(IEnumerable<AspNetUserTokenDto> items)
		{
			await this.AspNetUserTokenRepository.BulkUpdateAsync(this.ConvertAspNetUserTokenDtoToEntity(items));
		}

        #endregion

    }
}

