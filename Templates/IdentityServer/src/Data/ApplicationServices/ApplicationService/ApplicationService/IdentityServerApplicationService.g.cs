
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
        /// Gets or sets the AllowedScope Repository 
        /// </summary>
        protected IAllowedScopeRepository AllowedScopeRepository { get; set; }
        /// <summary>
        /// Gets or sets the ApiResource Repository 
        /// </summary>
        protected IApiResourceRepository ApiResourceRepository { get; set; }
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
        /// <summary>
        /// Gets or sets the Client Repository 
        /// </summary>
        protected IClientRepository ClientRepository { get; set; }
        /// <summary>
        /// Gets or sets the ClientGrantType Repository 
        /// </summary>
        protected IClientGrantTypeRepository ClientGrantTypeRepository { get; set; }
        /// <summary>
        /// Gets or sets the GrantType Repository 
        /// </summary>
        protected IGrantTypeRepository GrantTypeRepository { get; set; }
        /// <summary>
        /// Gets or sets the IdentityResource Repository 
        /// </summary>
        protected IIdentityResourceRepository IdentityResourceRepository { get; set; }
        /// <summary>
        /// Gets or sets the IdentityResourceClaimType Repository 
        /// </summary>
        protected IIdentityResourceClaimTypeRepository IdentityResourceClaimTypeRepository { get; set; }
        /// <summary>
        /// Gets or sets the PostLogoutRedirectUri Repository 
        /// </summary>
        protected IPostLogoutRedirectUriRepository PostLogoutRedirectUriRepository { get; set; }
        /// <summary>
        /// Gets or sets the RedirectUri Repository 
        /// </summary>
        protected IRedirectUriRepository RedirectUriRepository { get; set; }
        /// <summary>
        /// Gets or sets the ResourceClaimType Repository 
        /// </summary>
        protected IResourceClaimTypeRepository ResourceClaimTypeRepository { get; set; }

        public IdentityServerApplicationService (
                                          IAllowedScopeRepository allowedScopeRepository,
                                                              IApiResourceRepository apiResourceRepository,
                                                              IAspNetRoleRepository aspNetRoleRepository,
                                                              IAspNetRoleClaimRepository aspNetRoleClaimRepository,
                                                              IAspNetUserRepository aspNetUserRepository,
                                                              IAspNetUserClaimRepository aspNetUserClaimRepository,
                                                              IAspNetUserLoginRepository aspNetUserLoginRepository,
                                                              IAspNetUserRoleRepository aspNetUserRoleRepository,
                                                              IAspNetUserTokenRepository aspNetUserTokenRepository,
                                                              IClientRepository clientRepository,
                                                              IClientGrantTypeRepository clientGrantTypeRepository,
                                                              IGrantTypeRepository grantTypeRepository,
                                                              IIdentityResourceRepository identityResourceRepository,
                                                              IIdentityResourceClaimTypeRepository identityResourceClaimTypeRepository,
                                                              IPostLogoutRedirectUriRepository postLogoutRedirectUriRepository,
                                                              IRedirectUriRepository redirectUriRepository,
                                          IResourceClaimTypeRepository resourceClaimTypeRepository
                                     )
        {
            this.AllowedScopeRepository = allowedScopeRepository;
            this.ApiResourceRepository = apiResourceRepository;
            this.AspNetRoleRepository = aspNetRoleRepository;
            this.AspNetRoleClaimRepository = aspNetRoleClaimRepository;
            this.AspNetUserRepository = aspNetUserRepository;
            this.AspNetUserClaimRepository = aspNetUserClaimRepository;
            this.AspNetUserLoginRepository = aspNetUserLoginRepository;
            this.AspNetUserRoleRepository = aspNetUserRoleRepository;
            this.AspNetUserTokenRepository = aspNetUserTokenRepository;
            this.ClientRepository = clientRepository;
            this.ClientGrantTypeRepository = clientGrantTypeRepository;
            this.GrantTypeRepository = grantTypeRepository;
            this.IdentityResourceRepository = identityResourceRepository;
            this.IdentityResourceClaimTypeRepository = identityResourceClaimTypeRepository;
            this.PostLogoutRedirectUriRepository = postLogoutRedirectUriRepository;
            this.RedirectUriRepository = redirectUriRepository;
            this.ResourceClaimTypeRepository = resourceClaimTypeRepository;
        }

        #region Load

        /// <summary>
        /// Load AllowedScope entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AllowedScopeDto</returns>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
		public AllowedScopeDto LoadByAllowedScopeId(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            return CloningHelper.ConvertAllowedScopeToAllowedScopeDto(this.AllowedScopeRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AllowedScope Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AllowedScopeDto</returns>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
		public async Task<AllowedScopeDto> LoadByAllowedScopeIdAsync(int id, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            return CloningHelper.ConvertAllowedScopeToAllowedScopeDto(await this.AllowedScopeRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AllowedScope entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		public IList<AllowedScopeDto> AllowedScopeLoadAll(bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            var foundResults = this.AllowedScopeRepository.LoadAll(cache, includes);
            var results = new List<AllowedScopeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAllowedScopeToAllowedScopeDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AllowedScope Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		public async Task<IList<AllowedScopeDto>> AllowedScopeLoadAllAsync(bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            var foundResults = await this.AllowedScopeRepository.LoadAllAsync(cache, includes);
            var results = new List<AllowedScopeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAllowedScopeToAllowedScopeDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load ApiResource entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ApiResourceDto</returns>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
		public ApiResourceDto LoadByApiResourceId(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return CloningHelper.ConvertApiResourceToApiResourceDto(this.ApiResourceRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load ApiResource Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ApiResourceDto</returns>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
		public async Task<ApiResourceDto> LoadByApiResourceIdAsync(int id, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return CloningHelper.ConvertApiResourceToApiResourceDto(await this.ApiResourceRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all ApiResource entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public IList<ApiResourceDto> ApiResourceLoadAll(bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            var foundResults = this.ApiResourceRepository.LoadAll(cache, includes);
            var results = new List<ApiResourceDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertApiResourceToApiResourceDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all ApiResource Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public async Task<IList<ApiResourceDto>> ApiResourceLoadAllAsync(bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            var foundResults = await this.ApiResourceRepository.LoadAllAsync(cache, includes);
            var results = new List<ApiResourceDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertApiResourceToApiResourceDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetRole entities from the database using the primary key
        /// </summary
        /// <param name="id">Guid</param>
        /// <returns>AspNetRoleDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
		public AspNetRoleDto LoadByAspNetRoleId(Guid id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetRoleToAspNetRoleDto(this.AspNetRoleRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetRole Async entities from the database using the primary key
        /// </summary
        /// <param name="id">Guid</param>
        /// <returns>AspNetRoleDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
		public async Task<AspNetRoleDto> LoadByAspNetRoleIdAsync(Guid id, bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetRoleToAspNetRoleDto(await this.AspNetRoleRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetRole entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public IList<AspNetRoleDto> AspNetRoleLoadAll(bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            var foundResults = this.AspNetRoleRepository.LoadAll(cache, includes);
            var results = new List<AspNetRoleDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetRoleToAspNetRoleDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetRole Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRole, object>>[]</param>
        /// <returns>IList<AspNetRoleDto></returns>
		public async Task<IList<AspNetRoleDto>> AspNetRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetRole, object>>[] includes)
        {
            var foundResults = await this.AspNetRoleRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetRoleDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetRoleToAspNetRoleDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetRoleClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetRoleClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
		public AspNetRoleClaimDto LoadByAspNetRoleClaimId(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetRoleClaimToAspNetRoleClaimDto(this.AspNetRoleClaimRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetRoleClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetRoleClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
		public async Task<AspNetRoleClaimDto> LoadByAspNetRoleClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetRoleClaimToAspNetRoleClaimDto(await this.AspNetRoleClaimRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetRoleClaim entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public IList<AspNetRoleClaimDto> AspNetRoleClaimLoadAll(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            var foundResults = this.AspNetRoleClaimRepository.LoadAll(cache, includes);
            var results = new List<AspNetRoleClaimDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetRoleClaimToAspNetRoleClaimDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetRoleClaim Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetRoleClaim, object>>[]</param>
        /// <returns>IList<AspNetRoleClaimDto></returns>
		public async Task<IList<AspNetRoleClaimDto>> AspNetRoleClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetRoleClaim, object>>[] includes)
        {
            var foundResults = await this.AspNetRoleClaimRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetRoleClaimDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetRoleClaimToAspNetRoleClaimDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetUser entities from the database using the primary key
        /// </summary
        /// <param name="id">Guid</param>
        /// <returns>AspNetUserDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
		public AspNetUserDto LoadByAspNetUserId(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserToAspNetUserDto(this.AspNetUserRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUser Async entities from the database using the primary key
        /// </summary
        /// <param name="id">Guid</param>
        /// <returns>AspNetUserDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
		public async Task<AspNetUserDto> LoadByAspNetUserIdAsync(Guid id, bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserToAspNetUserDto(await this.AspNetUserRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetUser entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public IList<AspNetUserDto> AspNetUserLoadAll(bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            var foundResults = this.AspNetUserRepository.LoadAll(cache, includes);
            var results = new List<AspNetUserDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserToAspNetUserDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetUser Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUser, object>>[]</param>
        /// <returns>IList<AspNetUserDto></returns>
		public async Task<IList<AspNetUserDto>> AspNetUserLoadAllAsync(bool cache, params Expression<Func<IAspNetUser, object>>[] includes)
        {
            var foundResults = await this.AspNetUserRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetUserDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserToAspNetUserDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetUserClaim entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetUserClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
		public AspNetUserClaimDto LoadByAspNetUserClaimId(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(this.AspNetUserClaimRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserClaim Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>AspNetUserClaimDto</returns>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
		public async Task<AspNetUserClaimDto> LoadByAspNetUserClaimIdAsync(int id, bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(await this.AspNetUserClaimRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all AspNetUserClaim entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public IList<AspNetUserClaimDto> AspNetUserClaimLoadAll(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            var foundResults = this.AspNetUserClaimRepository.LoadAll(cache, includes);
            var results = new List<AspNetUserClaimDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetUserClaim Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserClaim, object>>[]</param>
        /// <returns>IList<AspNetUserClaimDto></returns>
		public async Task<IList<AspNetUserClaimDto>> AspNetUserClaimLoadAllAsync(bool cache, params Expression<Func<IAspNetUserClaim, object>>[] includes)
        {
            var foundResults = await this.AspNetUserClaimRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetUserClaimDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(foundResult, true));
            }

            return results;
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
            return CloningHelper.ConvertAspNetUserLoginToAspNetUserLoginDto(this.AspNetUserLoginRepository.Load( loginProvider,  providerKey, cache, includes), true);
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
            return CloningHelper.ConvertAspNetUserLoginToAspNetUserLoginDto(await this.AspNetUserLoginRepository.LoadAsync( loginProvider,  providerKey, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserLogin entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public IList<AspNetUserLoginDto> AspNetUserLoginLoadAll(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            var foundResults = this.AspNetUserLoginRepository.LoadAll(cache, includes);
            var results = new List<AspNetUserLoginDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserLoginToAspNetUserLoginDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetUserLogin Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserLogin, object>>[]</param>
        /// <returns>IList<AspNetUserLoginDto></returns>
		public async Task<IList<AspNetUserLoginDto>> AspNetUserLoginLoadAllAsync(bool cache, params Expression<Func<IAspNetUserLogin, object>>[] includes)
        {
            var foundResults = await this.AspNetUserLoginRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetUserLoginDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserLoginToAspNetUserLoginDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetUserRole entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRoleDto</returns>
		public AspNetUserRoleDto Load( Guid userId,  Guid roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserRoleToAspNetUserRoleDto(this.AspNetUserRoleRepository.Load( userId,  roleId, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserRole Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>AspNetUserRoleDto</returns>
		public async Task<AspNetUserRoleDto> LoadAsync( Guid userId,  Guid roleId, bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserRoleToAspNetUserRoleDto(await this.AspNetUserRoleRepository.LoadAsync( userId,  roleId, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserRole entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		public IList<AspNetUserRoleDto> AspNetUserRoleLoadAll(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            var foundResults = this.AspNetUserRoleRepository.LoadAll(cache, includes);
            var results = new List<AspNetUserRoleDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserRoleToAspNetUserRoleDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetUserRole Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserRole, object>>[]</param>
        /// <returns>IList<AspNetUserRoleDto></returns>
		public async Task<IList<AspNetUserRoleDto>> AspNetUserRoleLoadAllAsync(bool cache, params Expression<Func<IAspNetUserRole, object>>[] includes)
        {
            var foundResults = await this.AspNetUserRoleRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetUserRoleDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserRoleToAspNetUserRoleDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load AspNetUserToken entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserTokenDto</returns>
		public AspNetUserTokenDto Load( Guid userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserTokenToAspNetUserTokenDto(this.AspNetUserTokenRepository.Load( userId,  loginProvider,  name, cache, includes), true);
        }

        /// <summary>
        /// Load AspNetUserToken Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>AspNetUserTokenDto</returns>
		public async Task<AspNetUserTokenDto> LoadAsync( Guid userId,  string loginProvider,  string name, bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            return CloningHelper.ConvertAspNetUserTokenToAspNetUserTokenDto(await this.AspNetUserTokenRepository.LoadAsync( userId,  loginProvider,  name, cache, includes), true);
        }


        /// <summary>
        /// Load all AspNetUserToken entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public IList<AspNetUserTokenDto> AspNetUserTokenLoadAll(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            var foundResults = this.AspNetUserTokenRepository.LoadAll(cache, includes);
            var results = new List<AspNetUserTokenDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserTokenToAspNetUserTokenDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all AspNetUserToken Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IAspNetUserToken, object>>[]</param>
        /// <returns>IList<AspNetUserTokenDto></returns>
		public async Task<IList<AspNetUserTokenDto>> AspNetUserTokenLoadAllAsync(bool cache, params Expression<Func<IAspNetUserToken, object>>[] includes)
        {
            var foundResults = await this.AspNetUserTokenRepository.LoadAllAsync(cache, includes);
            var results = new List<AspNetUserTokenDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertAspNetUserTokenToAspNetUserTokenDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load Client entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ClientDto</returns>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
		public ClientDto LoadByClientId(int id, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return CloningHelper.ConvertClientToClientDto(this.ClientRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load Client Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ClientDto</returns>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
		public async Task<ClientDto> LoadByClientIdAsync(int id, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return CloningHelper.ConvertClientToClientDto(await this.ClientRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all Client entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public IList<ClientDto> ClientLoadAll(bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            var foundResults = this.ClientRepository.LoadAll(cache, includes);
            var results = new List<ClientDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertClientToClientDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all Client Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public async Task<IList<ClientDto>> ClientLoadAllAsync(bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            var foundResults = await this.ClientRepository.LoadAllAsync(cache, includes);
            var results = new List<ClientDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertClientToClientDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load ClientGrantType entities from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantTypeDto</returns>
		public ClientGrantTypeDto Load( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
        {
            return CloningHelper.ConvertClientGrantTypeToClientGrantTypeDto(this.ClientGrantTypeRepository.Load( clientId,  grantTypeId, cache, includes), true);
        }

        /// <summary>
        /// Load ClientGrantType Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>ClientGrantTypeDto</returns>
		public async Task<ClientGrantTypeDto> LoadAsync( int clientId,  int grantTypeId, bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
        {
            return CloningHelper.ConvertClientGrantTypeToClientGrantTypeDto(await this.ClientGrantTypeRepository.LoadAsync( clientId,  grantTypeId, cache, includes), true);
        }


        /// <summary>
        /// Load all ClientGrantType entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantTypeDto></returns>
		public IList<ClientGrantTypeDto> ClientGrantTypeLoadAll(bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
        {
            var foundResults = this.ClientGrantTypeRepository.LoadAll(cache, includes);
            var results = new List<ClientGrantTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertClientGrantTypeToClientGrantTypeDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all ClientGrantType Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IClientGrantType, object>>[]</param>
        /// <returns>IList<ClientGrantTypeDto></returns>
		public async Task<IList<ClientGrantTypeDto>> ClientGrantTypeLoadAllAsync(bool cache, params Expression<Func<IClientGrantType, object>>[] includes)
        {
            var foundResults = await this.ClientGrantTypeRepository.LoadAllAsync(cache, includes);
            var results = new List<ClientGrantTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertClientGrantTypeToClientGrantTypeDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load GrantType entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>GrantTypeDto</returns>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
		public GrantTypeDto LoadByGrantTypeId(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            return CloningHelper.ConvertGrantTypeToGrantTypeDto(this.GrantTypeRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load GrantType Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>GrantTypeDto</returns>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
		public async Task<GrantTypeDto> LoadByGrantTypeIdAsync(int id, bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            return CloningHelper.ConvertGrantTypeToGrantTypeDto(await this.GrantTypeRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all GrantType entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		public IList<GrantTypeDto> GrantTypeLoadAll(bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            var foundResults = this.GrantTypeRepository.LoadAll(cache, includes);
            var results = new List<GrantTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertGrantTypeToGrantTypeDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all GrantType Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		public async Task<IList<GrantTypeDto>> GrantTypeLoadAllAsync(bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            var foundResults = await this.GrantTypeRepository.LoadAllAsync(cache, includes);
            var results = new List<GrantTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertGrantTypeToGrantTypeDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load IdentityResource entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>IdentityResourceDto</returns>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
		public IdentityResourceDto LoadByIdentityResourceId(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return CloningHelper.ConvertIdentityResourceToIdentityResourceDto(this.IdentityResourceRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load IdentityResource Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>IdentityResourceDto</returns>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
		public async Task<IdentityResourceDto> LoadByIdentityResourceIdAsync(int id, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return CloningHelper.ConvertIdentityResourceToIdentityResourceDto(await this.IdentityResourceRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all IdentityResource entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public IList<IdentityResourceDto> IdentityResourceLoadAll(bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            var foundResults = this.IdentityResourceRepository.LoadAll(cache, includes);
            var results = new List<IdentityResourceDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertIdentityResourceToIdentityResourceDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all IdentityResource Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public async Task<IList<IdentityResourceDto>> IdentityResourceLoadAllAsync(bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            var foundResults = await this.IdentityResourceRepository.LoadAllAsync(cache, includes);
            var results = new List<IdentityResourceDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertIdentityResourceToIdentityResourceDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load IdentityResourceClaimType entities from the database using the composite primary keys
        /// </summary
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IdentityResourceClaimTypeDto</returns>
		public IdentityResourceClaimTypeDto Load( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
        {
            return CloningHelper.ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(this.IdentityResourceClaimTypeRepository.Load( identityResourceId,  resourceClaimTypeId, cache, includes), true);
        }

        /// <summary>
        /// Load IdentityResourceClaimType Async entities from the database using the composite primary keys
        /// </summary
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IdentityResourceClaimTypeDto</returns>
		public async Task<IdentityResourceClaimTypeDto> LoadAsync( int identityResourceId,  int resourceClaimTypeId, bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
        {
            return CloningHelper.ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(await this.IdentityResourceClaimTypeRepository.LoadAsync( identityResourceId,  resourceClaimTypeId, cache, includes), true);
        }


        /// <summary>
        /// Load all IdentityResourceClaimType entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimTypeDto></returns>
		public IList<IdentityResourceClaimTypeDto> IdentityResourceClaimTypeLoadAll(bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
        {
            var foundResults = this.IdentityResourceClaimTypeRepository.LoadAll(cache, includes);
            var results = new List<IdentityResourceClaimTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all IdentityResourceClaimType Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IIdentityResourceClaimType, object>>[]</param>
        /// <returns>IList<IdentityResourceClaimTypeDto></returns>
		public async Task<IList<IdentityResourceClaimTypeDto>> IdentityResourceClaimTypeLoadAllAsync(bool cache, params Expression<Func<IIdentityResourceClaimType, object>>[] includes)
        {
            var foundResults = await this.IdentityResourceClaimTypeRepository.LoadAllAsync(cache, includes);
            var results = new List<IdentityResourceClaimTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load PostLogoutRedirectUri entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>PostLogoutRedirectUriDto</returns>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
		public PostLogoutRedirectUriDto LoadByPostLogoutRedirectUriId(int id, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            return CloningHelper.ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(this.PostLogoutRedirectUriRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load PostLogoutRedirectUri Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>PostLogoutRedirectUriDto</returns>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
		public async Task<PostLogoutRedirectUriDto> LoadByPostLogoutRedirectUriIdAsync(int id, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            return CloningHelper.ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(await this.PostLogoutRedirectUriRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all PostLogoutRedirectUri entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		public IList<PostLogoutRedirectUriDto> PostLogoutRedirectUriLoadAll(bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            var foundResults = this.PostLogoutRedirectUriRepository.LoadAll(cache, includes);
            var results = new List<PostLogoutRedirectUriDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all PostLogoutRedirectUri Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		public async Task<IList<PostLogoutRedirectUriDto>> PostLogoutRedirectUriLoadAllAsync(bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            var foundResults = await this.PostLogoutRedirectUriRepository.LoadAllAsync(cache, includes);
            var results = new List<PostLogoutRedirectUriDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load RedirectUri entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>RedirectUriDto</returns>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
		public RedirectUriDto LoadByRedirectUriId(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            return CloningHelper.ConvertRedirectUriToRedirectUriDto(this.RedirectUriRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load RedirectUri Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>RedirectUriDto</returns>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
		public async Task<RedirectUriDto> LoadByRedirectUriIdAsync(int id, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            return CloningHelper.ConvertRedirectUriToRedirectUriDto(await this.RedirectUriRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all RedirectUri entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		public IList<RedirectUriDto> RedirectUriLoadAll(bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            var foundResults = this.RedirectUriRepository.LoadAll(cache, includes);
            var results = new List<RedirectUriDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertRedirectUriToRedirectUriDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all RedirectUri Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		public async Task<IList<RedirectUriDto>> RedirectUriLoadAllAsync(bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            var foundResults = await this.RedirectUriRepository.LoadAllAsync(cache, includes);
            var results = new List<RedirectUriDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertRedirectUriToRedirectUriDto(foundResult, true));
            }

            return results;
        }


        /// <summary>
        /// Load ResourceClaimType entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ResourceClaimTypeDto</returns>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
		public ResourceClaimTypeDto LoadByResourceClaimTypeId(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            return CloningHelper.ConvertResourceClaimTypeToResourceClaimTypeDto(this.ResourceClaimTypeRepository.LoadById(id, cache, includes), true);
        }

        /// <summary>
        /// Load ResourceClaimType Async entities from the database using the primary key
        /// </summary
        /// <param name="id">int</param>
        /// <returns>ResourceClaimTypeDto</returns>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
		public async Task<ResourceClaimTypeDto> LoadByResourceClaimTypeIdAsync(int id, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            return CloningHelper.ConvertResourceClaimTypeToResourceClaimTypeDto(await this.ResourceClaimTypeRepository.LoadByIdAsync(id, cache, includes), true);
        }

        /// <summary>
        /// Load all ResourceClaimType entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		public IList<ResourceClaimTypeDto> ResourceClaimTypeLoadAll(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            var foundResults = this.ResourceClaimTypeRepository.LoadAll(cache, includes);
            var results = new List<ResourceClaimTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertResourceClaimTypeToResourceClaimTypeDto(foundResult, true));
            }

            return results;
        }

        /// <summary>
        /// Load all ResourceClaimType Async entities from the database.
        /// </summary>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		public async Task<IList<ResourceClaimTypeDto>> ResourceClaimTypeLoadAllAsync(bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            var foundResults = await this.ResourceClaimTypeRepository.LoadAllAsync(cache, includes);
            var results = new List<ResourceClaimTypeDto>();
            
            foreach (var foundResult in foundResults)
            {
                results.Add(CloningHelper.ConvertResourceClaimTypeToResourceClaimTypeDto(foundResult, true));
            }

            return results;
        }


        #endregion

        #region Search

        /// <summary>
        /// Search for AllowedScope entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		public IList<AllowedScopeDto> AllowedScopeSearchByResourceName(string resourceName, bool caseSensitive, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            return this.ConvertAllowedScopeEntityToDto(this.AllowedScopeRepository.SearchByResourceName(resourceName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for AllowedScope Async entities in the database by ResourceName
        /// </summary>
        /// <param name="resourceName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IAllowedScope, object>>[]</param>
        /// <returns>IList<AllowedScopeDto></returns>
		public async Task<IList<AllowedScopeDto>> AllowedScopeSearchByResourceNameAsync(string resourceName, bool caseSensitive, bool cache, params Expression<Func<IAllowedScope, object>>[] includes)
        {
            return this.ConvertAllowedScopeEntityToDto(await this.AllowedScopeRepository.SearchByResourceNameAsync(resourceName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for ApiResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public IList<ApiResourceDto> ApiResourceSearchByName(string name, bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return this.ConvertApiResourceEntityToDto(this.ApiResourceRepository.SearchByName(name,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for ApiResource Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public async Task<IList<ApiResourceDto>> ApiResourceSearchByNameAsync(string name, bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return this.ConvertApiResourceEntityToDto(await this.ApiResourceRepository.SearchByNameAsync(name,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for ApiResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public IList<ApiResourceDto> ApiResourceSearchByDisplayName(string displayName, bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return this.ConvertApiResourceEntityToDto(this.ApiResourceRepository.SearchByDisplayName(displayName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for ApiResource Async entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IApiResource, object>>[]</param>
        /// <returns>IList<ApiResourceDto></returns>
		public async Task<IList<ApiResourceDto>> ApiResourceSearchByDisplayNameAsync(string displayName, bool caseSensitive, bool cache, params Expression<Func<IApiResource, object>>[] includes)
        {
            return this.ConvertApiResourceEntityToDto(await this.ApiResourceRepository.SearchByDisplayNameAsync(displayName,caseSensitive, cache, includes));
        }


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


        /// <summary>
        /// Search for Client entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public IList<ClientDto> ClientSearchByClientId(string clientId, bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return this.ConvertClientEntityToDto(this.ClientRepository.SearchByClientId(clientId,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Client Async entities in the database by ClientId
        /// </summary>
        /// <param name="clientId">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public async Task<IList<ClientDto>> ClientSearchByClientIdAsync(string clientId, bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return this.ConvertClientEntityToDto(await this.ClientRepository.SearchByClientIdAsync(clientId,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for Client entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public IList<ClientDto> ClientSearchByClientName(string clientName, bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return this.ConvertClientEntityToDto(this.ClientRepository.SearchByClientName(clientName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for Client Async entities in the database by ClientName
        /// </summary>
        /// <param name="clientName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IClient, object>>[]</param>
        /// <returns>IList<ClientDto></returns>
		public async Task<IList<ClientDto>> ClientSearchByClientNameAsync(string clientName, bool caseSensitive, bool cache, params Expression<Func<IClient, object>>[] includes)
        {
            return this.ConvertClientEntityToDto(await this.ClientRepository.SearchByClientNameAsync(clientName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for GrantType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		public IList<GrantTypeDto> GrantTypeSearchByName(string name, bool caseSensitive, bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            return this.ConvertGrantTypeEntityToDto(this.GrantTypeRepository.SearchByName(name,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for GrantType Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IGrantType, object>>[]</param>
        /// <returns>IList<GrantTypeDto></returns>
		public async Task<IList<GrantTypeDto>> GrantTypeSearchByNameAsync(string name, bool caseSensitive, bool cache, params Expression<Func<IGrantType, object>>[] includes)
        {
            return this.ConvertGrantTypeEntityToDto(await this.GrantTypeRepository.SearchByNameAsync(name,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for IdentityResource entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public IList<IdentityResourceDto> IdentityResourceSearchByName(string name, bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return this.ConvertIdentityResourceEntityToDto(this.IdentityResourceRepository.SearchByName(name,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for IdentityResource Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public async Task<IList<IdentityResourceDto>> IdentityResourceSearchByNameAsync(string name, bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return this.ConvertIdentityResourceEntityToDto(await this.IdentityResourceRepository.SearchByNameAsync(name,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for IdentityResource entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public IList<IdentityResourceDto> IdentityResourceSearchByDisplayName(string displayName, bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return this.ConvertIdentityResourceEntityToDto(this.IdentityResourceRepository.SearchByDisplayName(displayName,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for IdentityResource Async entities in the database by DisplayName
        /// </summary>
        /// <param name="displayName">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IIdentityResource, object>>[]</param>
        /// <returns>IList<IdentityResourceDto></returns>
		public async Task<IList<IdentityResourceDto>> IdentityResourceSearchByDisplayNameAsync(string displayName, bool caseSensitive, bool cache, params Expression<Func<IIdentityResource, object>>[] includes)
        {
            return this.ConvertIdentityResourceEntityToDto(await this.IdentityResourceRepository.SearchByDisplayNameAsync(displayName,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for PostLogoutRedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		public IList<PostLogoutRedirectUriDto> PostLogoutRedirectUriSearchByUri(string uri, bool caseSensitive, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            return this.ConvertPostLogoutRedirectUriEntityToDto(this.PostLogoutRedirectUriRepository.SearchByUri(uri,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for PostLogoutRedirectUri Async entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IPostLogoutRedirectUri, object>>[]</param>
        /// <returns>IList<PostLogoutRedirectUriDto></returns>
		public async Task<IList<PostLogoutRedirectUriDto>> PostLogoutRedirectUriSearchByUriAsync(string uri, bool caseSensitive, bool cache, params Expression<Func<IPostLogoutRedirectUri, object>>[] includes)
        {
            return this.ConvertPostLogoutRedirectUriEntityToDto(await this.PostLogoutRedirectUriRepository.SearchByUriAsync(uri,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for RedirectUri entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		public IList<RedirectUriDto> RedirectUriSearchByUri(string uri, bool caseSensitive, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            return this.ConvertRedirectUriEntityToDto(this.RedirectUriRepository.SearchByUri(uri,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for RedirectUri Async entities in the database by Uri
        /// </summary>
        /// <param name="uri">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IRedirectUri, object>>[]</param>
        /// <returns>IList<RedirectUriDto></returns>
		public async Task<IList<RedirectUriDto>> RedirectUriSearchByUriAsync(string uri, bool caseSensitive, bool cache, params Expression<Func<IRedirectUri, object>>[] includes)
        {
            return this.ConvertRedirectUriEntityToDto(await this.RedirectUriRepository.SearchByUriAsync(uri,caseSensitive, cache, includes));
        }


        /// <summary>
        /// Search for ResourceClaimType entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		public IList<ResourceClaimTypeDto> ResourceClaimTypeSearchByName(string name, bool caseSensitive, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            return this.ConvertResourceClaimTypeEntityToDto(this.ResourceClaimTypeRepository.SearchByName(name,caseSensitive, cache, includes));
        }

        /// <summary>
        /// Search for ResourceClaimType Async entities in the database by Name
        /// </summary>
        /// <param name="name">string</param>
		/// <param name="caseSensitive">bool</param>
        /// <param name="includes">params Expression<Func<IResourceClaimType, object>>[]</param>
        /// <returns>IList<ResourceClaimTypeDto></returns>
		public async Task<IList<ResourceClaimTypeDto>> ResourceClaimTypeSearchByNameAsync(string name, bool caseSensitive, bool cache, params Expression<Func<IResourceClaimType, object>>[] includes)
        {
            return this.ConvertResourceClaimTypeEntityToDto(await this.ResourceClaimTypeRepository.SearchByNameAsync(name,caseSensitive, cache, includes));
        }

		#endregion

#region Modifiers
		
        /// <summary>
        /// Add the AllowedScope entity to the database.
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public bool AllowedScopeAdd(AllowedScopeDto entity)
        {
            return this.AllowedScopeRepository.Add(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }

        /// <summary>
        /// Add the AllowedScope entity async to the database.
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public async Task<bool> AllowedScopeAddAsync(AllowedScopeDto entity)
        {
            return await this.AllowedScopeRepository.AddAsync(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }

        /// <summary>
        /// Update the AllowedScope entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public bool AllowedScopeUpdate(AllowedScopeDto entity)
        {
            return this.AllowedScopeRepository.Update(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }
		
        /// <summary>
        /// Update the AllowedScope entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public async Task<bool> AllowedScopeUpdateAsync(AllowedScopeDto entity)
        {
            return await this.AllowedScopeRepository.UpdateAsync(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }

        /// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public bool AllowedScopeDelete(AllowedScopeDto entity)
        {
            return this.AllowedScopeRepository.Delete(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }

        /// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="entity">IAllowedScope</param>
        /// <returns>bool</returns>
		public async Task<bool> AllowedScopeDeleteAsync(AllowedScopeDto entity)
        {
            return await this.AllowedScopeRepository.DeleteAsync(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(entity, true));
        }

		/// <summary>
        /// Delete the AllowedScope entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool AllowedScopeDelete( int id, bool cache)
        {
            return this.AllowedScopeRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AllowedScope entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> AllowedScopeDeleteAsync( int id, bool cache)
        {
            return await this.AllowedScopeRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the ApiResource entity to the database.
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public bool ApiResourceAdd(ApiResourceDto entity)
        {
            return this.ApiResourceRepository.Add(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }

        /// <summary>
        /// Add the ApiResource entity async to the database.
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public async Task<bool> ApiResourceAddAsync(ApiResourceDto entity)
        {
            return await this.ApiResourceRepository.AddAsync(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }

        /// <summary>
        /// Update the ApiResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public bool ApiResourceUpdate(ApiResourceDto entity)
        {
            return this.ApiResourceRepository.Update(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }
		
        /// <summary>
        /// Update the ApiResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public async Task<bool> ApiResourceUpdateAsync(ApiResourceDto entity)
        {
            return await this.ApiResourceRepository.UpdateAsync(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }

        /// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public bool ApiResourceDelete(ApiResourceDto entity)
        {
            return this.ApiResourceRepository.Delete(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }

        /// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="entity">IApiResource</param>
        /// <returns>bool</returns>
		public async Task<bool> ApiResourceDeleteAsync(ApiResourceDto entity)
        {
            return await this.ApiResourceRepository.DeleteAsync(CloningHelper.ConvertApiResourceDtoToApiResource(entity, true));
        }

		/// <summary>
        /// Delete the ApiResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool ApiResourceDelete( int id, bool cache)
        {
            return this.ApiResourceRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the ApiResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> ApiResourceDeleteAsync( int id, bool cache)
        {
            return await this.ApiResourceRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the AspNetRole entity to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleAdd(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Add(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }

        /// <summary>
        /// Add the AspNetRole entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleAddAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.AddAsync(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }

        /// <summary>
        /// Update the AspNetRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleUpdate(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Update(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleUpdateAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.UpdateAsync(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public bool AspNetRoleDelete(AspNetRoleDto entity)
        {
            return this.AspNetRoleRepository.Delete(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleDeleteAsync(AspNetRoleDto entity)
        {
            return await this.AspNetRoleRepository.DeleteAsync(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(entity, true));
        }

		/// <summary>
        /// Delete the AspNetRole entity from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public bool AspNetRoleDelete( Guid id, bool cache)
        {
            return this.AspNetRoleRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetRole entity async from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleDeleteAsync( Guid id, bool cache)
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
            return this.AspNetRoleClaimRepository.Add(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Add the AspNetRoleClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimAddAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.AddAsync(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Update the AspNetRoleClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimUpdate(AspNetRoleClaimDto entity)
        {
            return this.AspNetRoleClaimRepository.Update(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetRoleClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimUpdateAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.UpdateAsync(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRoleClaim entity from the database
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public bool AspNetRoleClaimDelete(AspNetRoleClaimDto entity)
        {
            return this.AspNetRoleClaimRepository.Delete(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetRoleClaim entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetRoleClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetRoleClaimDeleteAsync(AspNetRoleClaimDto entity)
        {
            return await this.AspNetRoleClaimRepository.DeleteAsync(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(entity, true));
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
            return this.AspNetUserRepository.Add(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }

        /// <summary>
        /// Add the AspNetUser entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserAddAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.AddAsync(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }

        /// <summary>
        /// Update the AspNetUser entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public bool AspNetUserUpdate(AspNetUserDto entity)
        {
            return this.AspNetUserRepository.Update(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUser entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserUpdateAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.UpdateAsync(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public bool AspNetUserDelete(AspNetUserDto entity)
        {
            return this.AspNetUserRepository.Delete(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUser</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserDeleteAsync(AspNetUserDto entity)
        {
            return await this.AspNetUserRepository.DeleteAsync(CloningHelper.ConvertAspNetUserDtoToAspNetUser(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUser entity from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public bool AspNetUserDelete( Guid id, bool cache)
        {
            return this.AspNetUserRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the AspNetUser entity async from the database
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserDeleteAsync( Guid id, bool cache)
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
            return this.AspNetUserClaimRepository.Add(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserClaim entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimAddAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.AddAsync(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserClaim entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimUpdate(AspNetUserClaimDto entity)
        {
            return this.AspNetUserClaimRepository.Update(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserClaim entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimUpdateAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.UpdateAsync(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserClaim entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public bool AspNetUserClaimDelete(AspNetUserClaimDto entity)
        {
            return this.AspNetUserClaimRepository.Delete(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserClaim entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserClaim</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserClaimDeleteAsync(AspNetUserClaimDto entity)
        {
            return await this.AspNetUserClaimRepository.DeleteAsync(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(entity, true));
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
            return this.AspNetUserLoginRepository.Add(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserLogin entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginAddAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.AddAsync(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserLogin entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginUpdate(AspNetUserLoginDto entity)
        {
            return this.AspNetUserLoginRepository.Update(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserLogin entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginUpdateAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.UpdateAsync(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserLogin entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public bool AspNetUserLoginDelete(AspNetUserLoginDto entity)
        {
            return this.AspNetUserLoginRepository.Delete(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserLogin entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserLogin</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserLoginDeleteAsync(AspNetUserLoginDto entity)
        {
            return await this.AspNetUserLoginRepository.DeleteAsync(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(entity, true));
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
            return this.AspNetUserRoleRepository.Add(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserRole entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleAddAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.AddAsync(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserRole entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleUpdate(AspNetUserRoleDto entity)
        {
            return this.AspNetUserRoleRepository.Update(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserRole entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleUpdateAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.UpdateAsync(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleDelete(AspNetUserRoleDto entity)
        {
            return this.AspNetUserRoleRepository.Delete(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserRole</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleDeleteAsync(AspNetUserRoleDto entity)
        {
            return await this.AspNetUserRoleRepository.DeleteAsync(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserRole entity from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <returns>bool</returns>
		public bool AspNetUserRoleDelete( Guid userId,  Guid roleId, bool cache)
        {
            return this.AspNetUserRoleRepository.Delete( userId,  roleId, cache);
        }

        /// <summary>
        /// Delete the AspNetUserRole entity async from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="roleId">Guid</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserRoleDeleteAsync( Guid userId,  Guid roleId, bool cache)
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
            return this.AspNetUserTokenRepository.Add(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }

        /// <summary>
        /// Add the AspNetUserToken entity async to the database.
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenAddAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.AddAsync(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }

        /// <summary>
        /// Update the AspNetUserToken entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenUpdate(AspNetUserTokenDto entity)
        {
            return this.AspNetUserTokenRepository.Update(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }
		
        /// <summary>
        /// Update the AspNetUserToken entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenUpdateAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.UpdateAsync(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenDelete(AspNetUserTokenDto entity)
        {
            return this.AspNetUserTokenRepository.Delete(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }

        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="entity">IAspNetUserToken</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenDeleteAsync(AspNetUserTokenDto entity)
        {
            return await this.AspNetUserTokenRepository.DeleteAsync(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(entity, true));
        }

		/// <summary>
        /// Delete the AspNetUserToken entity from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public bool AspNetUserTokenDelete( Guid userId,  string loginProvider,  string name, bool cache)
        {
            return this.AspNetUserTokenRepository.Delete( userId,  loginProvider,  name, cache);
        }

        /// <summary>
        /// Delete the AspNetUserToken entity async from the database
        /// </summary>
        /// <param name="userId">Guid</param>
        /// <param name="loginProvider">string</param>
        /// <param name="name">string</param>
        /// <returns>bool</returns>
		public async Task<bool> AspNetUserTokenDeleteAsync( Guid userId,  string loginProvider,  string name, bool cache)
        {
            return await this.AspNetUserTokenRepository.DeleteAsync( userId,  loginProvider,  name, cache);
        }

		
        /// <summary>
        /// Add the Client entity to the database.
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public bool ClientAdd(ClientDto entity)
        {
            return this.ClientRepository.Add(CloningHelper.ConvertClientDtoToClient(entity, true));
        }

        /// <summary>
        /// Add the Client entity async to the database.
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientAddAsync(ClientDto entity)
        {
            return await this.ClientRepository.AddAsync(CloningHelper.ConvertClientDtoToClient(entity, true));
        }

        /// <summary>
        /// Update the Client entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public bool ClientUpdate(ClientDto entity)
        {
            return this.ClientRepository.Update(CloningHelper.ConvertClientDtoToClient(entity, true));
        }
		
        /// <summary>
        /// Update the Client entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientUpdateAsync(ClientDto entity)
        {
            return await this.ClientRepository.UpdateAsync(CloningHelper.ConvertClientDtoToClient(entity, true));
        }

        /// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public bool ClientDelete(ClientDto entity)
        {
            return this.ClientRepository.Delete(CloningHelper.ConvertClientDtoToClient(entity, true));
        }

        /// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="entity">IClient</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientDeleteAsync(ClientDto entity)
        {
            return await this.ClientRepository.DeleteAsync(CloningHelper.ConvertClientDtoToClient(entity, true));
        }

		/// <summary>
        /// Delete the Client entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool ClientDelete( int id, bool cache)
        {
            return this.ClientRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the Client entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientDeleteAsync( int id, bool cache)
        {
            return await this.ClientRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the ClientGrantType entity to the database.
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public bool ClientGrantTypeAdd(ClientGrantTypeDto entity)
        {
            return this.ClientGrantTypeRepository.Add(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }

        /// <summary>
        /// Add the ClientGrantType entity async to the database.
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientGrantTypeAddAsync(ClientGrantTypeDto entity)
        {
            return await this.ClientGrantTypeRepository.AddAsync(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }

        /// <summary>
        /// Update the ClientGrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public bool ClientGrantTypeUpdate(ClientGrantTypeDto entity)
        {
            return this.ClientGrantTypeRepository.Update(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }
		
        /// <summary>
        /// Update the ClientGrantType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientGrantTypeUpdateAsync(ClientGrantTypeDto entity)
        {
            return await this.ClientGrantTypeRepository.UpdateAsync(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }

        /// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public bool ClientGrantTypeDelete(ClientGrantTypeDto entity)
        {
            return this.ClientGrantTypeRepository.Delete(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }

        /// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="entity">IClientGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientGrantTypeDeleteAsync(ClientGrantTypeDto entity)
        {
            return await this.ClientGrantTypeRepository.DeleteAsync(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(entity, true));
        }

		/// <summary>
        /// Delete the ClientGrantType entity from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		public bool ClientGrantTypeDelete( int clientId,  int grantTypeId, bool cache)
        {
            return this.ClientGrantTypeRepository.Delete( clientId,  grantTypeId, cache);
        }

        /// <summary>
        /// Delete the ClientGrantType entity async from the database
        /// </summary>
        /// <param name="clientId">int</param>
        /// <param name="grantTypeId">int</param>
        /// <returns>bool</returns>
		public async Task<bool> ClientGrantTypeDeleteAsync( int clientId,  int grantTypeId, bool cache)
        {
            return await this.ClientGrantTypeRepository.DeleteAsync( clientId,  grantTypeId, cache);
        }

		
        /// <summary>
        /// Add the GrantType entity to the database.
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public bool GrantTypeAdd(GrantTypeDto entity)
        {
            return this.GrantTypeRepository.Add(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }

        /// <summary>
        /// Add the GrantType entity async to the database.
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> GrantTypeAddAsync(GrantTypeDto entity)
        {
            return await this.GrantTypeRepository.AddAsync(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }

        /// <summary>
        /// Update the GrantType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public bool GrantTypeUpdate(GrantTypeDto entity)
        {
            return this.GrantTypeRepository.Update(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }
		
        /// <summary>
        /// Update the GrantType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> GrantTypeUpdateAsync(GrantTypeDto entity)
        {
            return await this.GrantTypeRepository.UpdateAsync(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }

        /// <summary>
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public bool GrantTypeDelete(GrantTypeDto entity)
        {
            return this.GrantTypeRepository.Delete(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }

        /// <summary>
        /// Delete the GrantType entity async from the database
        /// </summary>
        /// <param name="entity">IGrantType</param>
        /// <returns>bool</returns>
		public async Task<bool> GrantTypeDeleteAsync(GrantTypeDto entity)
        {
            return await this.GrantTypeRepository.DeleteAsync(CloningHelper.ConvertGrantTypeDtoToGrantType(entity, true));
        }

		/// <summary>
        /// Delete the GrantType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool GrantTypeDelete( int id, bool cache)
        {
            return this.GrantTypeRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the GrantType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> GrantTypeDeleteAsync( int id, bool cache)
        {
            return await this.GrantTypeRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the IdentityResource entity to the database.
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public bool IdentityResourceAdd(IdentityResourceDto entity)
        {
            return this.IdentityResourceRepository.Add(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }

        /// <summary>
        /// Add the IdentityResource entity async to the database.
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceAddAsync(IdentityResourceDto entity)
        {
            return await this.IdentityResourceRepository.AddAsync(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }

        /// <summary>
        /// Update the IdentityResource entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public bool IdentityResourceUpdate(IdentityResourceDto entity)
        {
            return this.IdentityResourceRepository.Update(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }
		
        /// <summary>
        /// Update the IdentityResource entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceUpdateAsync(IdentityResourceDto entity)
        {
            return await this.IdentityResourceRepository.UpdateAsync(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }

        /// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public bool IdentityResourceDelete(IdentityResourceDto entity)
        {
            return this.IdentityResourceRepository.Delete(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }

        /// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="entity">IIdentityResource</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceDeleteAsync(IdentityResourceDto entity)
        {
            return await this.IdentityResourceRepository.DeleteAsync(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(entity, true));
        }

		/// <summary>
        /// Delete the IdentityResource entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool IdentityResourceDelete( int id, bool cache)
        {
            return this.IdentityResourceRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the IdentityResource entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceDeleteAsync( int id, bool cache)
        {
            return await this.IdentityResourceRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the IdentityResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public bool IdentityResourceClaimTypeAdd(IdentityResourceClaimTypeDto entity)
        {
            return this.IdentityResourceClaimTypeRepository.Add(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }

        /// <summary>
        /// Add the IdentityResourceClaimType entity async to the database.
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceClaimTypeAddAsync(IdentityResourceClaimTypeDto entity)
        {
            return await this.IdentityResourceClaimTypeRepository.AddAsync(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }

        /// <summary>
        /// Update the IdentityResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public bool IdentityResourceClaimTypeUpdate(IdentityResourceClaimTypeDto entity)
        {
            return this.IdentityResourceClaimTypeRepository.Update(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }
		
        /// <summary>
        /// Update the IdentityResourceClaimType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceClaimTypeUpdateAsync(IdentityResourceClaimTypeDto entity)
        {
            return await this.IdentityResourceClaimTypeRepository.UpdateAsync(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }

        /// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public bool IdentityResourceClaimTypeDelete(IdentityResourceClaimTypeDto entity)
        {
            return this.IdentityResourceClaimTypeRepository.Delete(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }

        /// <summary>
        /// Delete the IdentityResourceClaimType entity async from the database
        /// </summary>
        /// <param name="entity">IIdentityResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceClaimTypeDeleteAsync(IdentityResourceClaimTypeDto entity)
        {
            return await this.IdentityResourceClaimTypeRepository.DeleteAsync(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(entity, true));
        }

		/// <summary>
        /// Delete the IdentityResourceClaimType entity from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		public bool IdentityResourceClaimTypeDelete( int identityResourceId,  int resourceClaimTypeId, bool cache)
        {
            return this.IdentityResourceClaimTypeRepository.Delete( identityResourceId,  resourceClaimTypeId, cache);
        }

        /// <summary>
        /// Delete the IdentityResourceClaimType entity async from the database
        /// </summary>
        /// <param name="identityResourceId">int</param>
        /// <param name="resourceClaimTypeId">int</param>
        /// <returns>bool</returns>
		public async Task<bool> IdentityResourceClaimTypeDeleteAsync( int identityResourceId,  int resourceClaimTypeId, bool cache)
        {
            return await this.IdentityResourceClaimTypeRepository.DeleteAsync( identityResourceId,  resourceClaimTypeId, cache);
        }

		
        /// <summary>
        /// Add the PostLogoutRedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public bool PostLogoutRedirectUriAdd(PostLogoutRedirectUriDto entity)
        {
            return this.PostLogoutRedirectUriRepository.Add(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }

        /// <summary>
        /// Add the PostLogoutRedirectUri entity async to the database.
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> PostLogoutRedirectUriAddAsync(PostLogoutRedirectUriDto entity)
        {
            return await this.PostLogoutRedirectUriRepository.AddAsync(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }

        /// <summary>
        /// Update the PostLogoutRedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public bool PostLogoutRedirectUriUpdate(PostLogoutRedirectUriDto entity)
        {
            return this.PostLogoutRedirectUriRepository.Update(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }
		
        /// <summary>
        /// Update the PostLogoutRedirectUri entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> PostLogoutRedirectUriUpdateAsync(PostLogoutRedirectUriDto entity)
        {
            return await this.PostLogoutRedirectUriRepository.UpdateAsync(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }

        /// <summary>
        /// Delete the PostLogoutRedirectUri entity from the database
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public bool PostLogoutRedirectUriDelete(PostLogoutRedirectUriDto entity)
        {
            return this.PostLogoutRedirectUriRepository.Delete(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }

        /// <summary>
        /// Delete the PostLogoutRedirectUri entity async from the database
        /// </summary>
        /// <param name="entity">IPostLogoutRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> PostLogoutRedirectUriDeleteAsync(PostLogoutRedirectUriDto entity)
        {
            return await this.PostLogoutRedirectUriRepository.DeleteAsync(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(entity, true));
        }

		/// <summary>
        /// Delete the PostLogoutRedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool PostLogoutRedirectUriDelete( int id, bool cache)
        {
            return this.PostLogoutRedirectUriRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the PostLogoutRedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> PostLogoutRedirectUriDeleteAsync( int id, bool cache)
        {
            return await this.PostLogoutRedirectUriRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the RedirectUri entity to the database.
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public bool RedirectUriAdd(RedirectUriDto entity)
        {
            return this.RedirectUriRepository.Add(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }

        /// <summary>
        /// Add the RedirectUri entity async to the database.
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> RedirectUriAddAsync(RedirectUriDto entity)
        {
            return await this.RedirectUriRepository.AddAsync(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }

        /// <summary>
        /// Update the RedirectUri entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public bool RedirectUriUpdate(RedirectUriDto entity)
        {
            return this.RedirectUriRepository.Update(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }
		
        /// <summary>
        /// Update the RedirectUri entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> RedirectUriUpdateAsync(RedirectUriDto entity)
        {
            return await this.RedirectUriRepository.UpdateAsync(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }

        /// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public bool RedirectUriDelete(RedirectUriDto entity)
        {
            return this.RedirectUriRepository.Delete(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }

        /// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="entity">IRedirectUri</param>
        /// <returns>bool</returns>
		public async Task<bool> RedirectUriDeleteAsync(RedirectUriDto entity)
        {
            return await this.RedirectUriRepository.DeleteAsync(CloningHelper.ConvertRedirectUriDtoToRedirectUri(entity, true));
        }

		/// <summary>
        /// Delete the RedirectUri entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool RedirectUriDelete( int id, bool cache)
        {
            return this.RedirectUriRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the RedirectUri entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> RedirectUriDeleteAsync( int id, bool cache)
        {
            return await this.RedirectUriRepository.DeleteAsync( id, cache);
        }

		
        /// <summary>
        /// Add the ResourceClaimType entity to the database.
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public bool ResourceClaimTypeAdd(ResourceClaimTypeDto entity)
        {
            return this.ResourceClaimTypeRepository.Add(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }

        /// <summary>
        /// Add the ResourceClaimType entity async to the database.
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> ResourceClaimTypeAddAsync(ResourceClaimTypeDto entity)
        {
            return await this.ResourceClaimTypeRepository.AddAsync(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }

        /// <summary>
        /// Update the ResourceClaimType entity in the database if any values have changed
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public bool ResourceClaimTypeUpdate(ResourceClaimTypeDto entity)
        {
            return this.ResourceClaimTypeRepository.Update(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }
		
        /// <summary>
        /// Update the ResourceClaimType entity async in the database if any values have changed
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> ResourceClaimTypeUpdateAsync(ResourceClaimTypeDto entity)
        {
            return await this.ResourceClaimTypeRepository.UpdateAsync(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }

        /// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public bool ResourceClaimTypeDelete(ResourceClaimTypeDto entity)
        {
            return this.ResourceClaimTypeRepository.Delete(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }

        /// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="entity">IResourceClaimType</param>
        /// <returns>bool</returns>
		public async Task<bool> ResourceClaimTypeDeleteAsync(ResourceClaimTypeDto entity)
        {
            return await this.ResourceClaimTypeRepository.DeleteAsync(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(entity, true));
        }

		/// <summary>
        /// Delete the ResourceClaimType entity from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public bool ResourceClaimTypeDelete( int id, bool cache)
        {
            return this.ResourceClaimTypeRepository.Delete( id, cache);
        }

        /// <summary>
        /// Delete the ResourceClaimType entity async from the database
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>bool</returns>
		public async Task<bool> ResourceClaimTypeDeleteAsync( int id, bool cache)
        {
            return await this.ResourceClaimTypeRepository.DeleteAsync( id, cache);
        }


		#endregion

        #region Aggregates
        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult AllowedScopeMax<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
        {
		    return this.AllowedScopeRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> AllowedScopeMaxAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
        {
		    return await this.AllowedScopeRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult AllowedScopeMin<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
        {
		    return this.AllowedScopeRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IAllowedScope, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> AllowedScopeMinAsync<TResult>(Expression<Func<IAllowedScope, TResult>> maxExpression, bool cache)
        {
		    return await this.AllowedScopeRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ApiResourceMax<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
        {
		    return this.ApiResourceRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ApiResourceMaxAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
        {
		    return await this.ApiResourceRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ApiResourceMin<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
        {
		    return this.ApiResourceRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IApiResource, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> ApiResourceMinAsync<TResult>(Expression<Func<IApiResource, TResult>> maxExpression, bool cache)
        {
		    return await this.ApiResourceRepository.MinAsync(maxExpression, cache);
        }

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

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ClientMax<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
        {
		    return this.ClientRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ClientMaxAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
        {
		    return await this.ClientRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ClientMin<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
        {
		    return this.ClientRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClient, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> ClientMinAsync<TResult>(Expression<Func<IClient, TResult>> maxExpression, bool cache)
        {
		    return await this.ClientRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ClientGrantTypeMax<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
        {
		    return this.ClientGrantTypeRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ClientGrantTypeMaxAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
        {
		    return await this.ClientGrantTypeRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ClientGrantTypeMin<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
        {
		    return this.ClientGrantTypeRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IClientGrantType, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> ClientGrantTypeMinAsync<TResult>(Expression<Func<IClientGrantType, TResult>> maxExpression, bool cache)
        {
		    return await this.ClientGrantTypeRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult GrantTypeMax<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
        {
		    return this.GrantTypeRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> GrantTypeMaxAsync<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
        {
		    return await this.GrantTypeRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult GrantTypeMin<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
        {
		    return this.GrantTypeRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IGrantType, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> GrantTypeMinAsync<TResult>(Expression<Func<IGrantType, TResult>> maxExpression, bool cache)
        {
		    return await this.GrantTypeRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult IdentityResourceMax<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
        {
		    return this.IdentityResourceRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> IdentityResourceMaxAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
        {
		    return await this.IdentityResourceRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult IdentityResourceMin<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
        {
		    return this.IdentityResourceRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResource, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> IdentityResourceMinAsync<TResult>(Expression<Func<IIdentityResource, TResult>> maxExpression, bool cache)
        {
		    return await this.IdentityResourceRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult IdentityResourceClaimTypeMax<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return this.IdentityResourceClaimTypeRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> IdentityResourceClaimTypeMaxAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return await this.IdentityResourceClaimTypeRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult IdentityResourceClaimTypeMin<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return this.IdentityResourceClaimTypeRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> IdentityResourceClaimTypeMinAsync<TResult>(Expression<Func<IIdentityResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return await this.IdentityResourceClaimTypeRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult PostLogoutRedirectUriMax<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return this.PostLogoutRedirectUriRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> PostLogoutRedirectUriMaxAsync<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return await this.PostLogoutRedirectUriRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult PostLogoutRedirectUriMin<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return this.PostLogoutRedirectUriRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> PostLogoutRedirectUriMinAsync<TResult>(Expression<Func<IPostLogoutRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return await this.PostLogoutRedirectUriRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult RedirectUriMax<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return this.RedirectUriRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> RedirectUriMaxAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return await this.RedirectUriRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult RedirectUriMin<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return this.RedirectUriRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IRedirectUri, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> RedirectUriMinAsync<TResult>(Expression<Func<IRedirectUri, TResult>> maxExpression, bool cache)
        {
		    return await this.RedirectUriRepository.MinAsync(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
        public TResult ResourceClaimTypeMax<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return this.ResourceClaimTypeRepository.Max(maxExpression, cache);
        }

        /// <summary>
        /// Returns the max value async
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
		public async Task<TResult> ResourceClaimTypeMaxAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return await this.ResourceClaimTypeRepository.MaxAsync(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</param>
        /// <returns></returns>
		public TResult ResourceClaimTypeMin<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return this.ResourceClaimTypeRepository.Min(maxExpression, cache);
        }
		
        /// <summary>
        /// Returns the min value 
        /// </summary>
        /// <typeparam name="TResult">TResult</typeparam>
        /// <param name="maxExpression">Expression<Func<IResourceClaimType, TResult>> maxExpression</pIaram>
        /// <returns></returns>
		public async Task<TResult> ResourceClaimTypeMinAsync<TResult>(Expression<Func<IResourceClaimType, TResult>> maxExpression, bool cache)
        {
		    return await this.ResourceClaimTypeRepository.MinAsync(maxExpression, cache);
        }

		#endregion

		#region Bulk

        /// <summary>
        /// Converts a AllowedScopeDto list to AllowedScope list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AllowedScope> ConvertAllowedScopeDtoToEntity(IEnumerable<AllowedScopeDto> items)
	    {
            List<AllowedScope> results = new List<AllowedScope>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertAllowedScopeDtoToAllowedScope(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a AllowedScope list to AllowedScopeDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<AllowedScopeDto> ConvertAllowedScopeEntityToDto(IEnumerable<AllowedScope> items)
	    {
            List<AllowedScopeDto> results = new List<AllowedScopeDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertAllowedScopeToAllowedScopeDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void AllowedScopeBulkDelete(IEnumerable<AllowedScopeDto> items)
		{
			this.AllowedScopeRepository.BulkDelete(this.ConvertAllowedScopeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task AllowedScopeBulkDeleteAsync(IEnumerable<AllowedScopeDto> items)
		{
			await this.AllowedScopeRepository.BulkDeleteAsync(this.ConvertAllowedScopeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  AllowedScopeBulkInsert(IEnumerable<AllowedScopeDto> items)
		{
			this.AllowedScopeRepository.BulkInsert(this.ConvertAllowedScopeDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AllowedScopeBulkInsertAsync(IEnumerable<AllowedScopeDto> items)
		{
			await this.AllowedScopeRepository.BulkInsertAsync(this.ConvertAllowedScopeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  AllowedScopeBulkUpdate(IEnumerable<AllowedScopeDto> items)
		{
			this.AllowedScopeRepository.BulkUpdate(this.ConvertAllowedScopeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  AllowedScopeBulkUpdateAsync(IEnumerable<AllowedScopeDto> items)
		{
			await this.AllowedScopeRepository.BulkUpdateAsync(this.ConvertAllowedScopeDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a ApiResourceDto list to ApiResource list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ApiResource> ConvertApiResourceDtoToEntity(IEnumerable<ApiResourceDto> items)
	    {
            List<ApiResource> results = new List<ApiResource>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertApiResourceDtoToApiResource(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a ApiResource list to ApiResourceDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ApiResourceDto> ConvertApiResourceEntityToDto(IEnumerable<ApiResource> items)
	    {
            List<ApiResourceDto> results = new List<ApiResourceDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertApiResourceToApiResourceDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ApiResourceBulkDelete(IEnumerable<ApiResourceDto> items)
		{
			this.ApiResourceRepository.BulkDelete(this.ConvertApiResourceDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ApiResourceBulkDeleteAsync(IEnumerable<ApiResourceDto> items)
		{
			await this.ApiResourceRepository.BulkDeleteAsync(this.ConvertApiResourceDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ApiResourceBulkInsert(IEnumerable<ApiResourceDto> items)
		{
			this.ApiResourceRepository.BulkInsert(this.ConvertApiResourceDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ApiResourceBulkInsertAsync(IEnumerable<ApiResourceDto> items)
		{
			await this.ApiResourceRepository.BulkInsertAsync(this.ConvertApiResourceDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  ApiResourceBulkUpdate(IEnumerable<ApiResourceDto> items)
		{
			this.ApiResourceRepository.BulkUpdate(this.ConvertApiResourceDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ApiResourceBulkUpdateAsync(IEnumerable<ApiResourceDto> items)
		{
			await this.ApiResourceRepository.BulkUpdateAsync(this.ConvertApiResourceDtoToEntity(items));
		}

        
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
	            results.Add(CloningHelper.ConvertAspNetRoleDtoToAspNetRole(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetRoleToAspNetRoleDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetRoleClaimDtoToAspNetRoleClaim(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetRoleClaimToAspNetRoleClaimDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserDtoToAspNetUser(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserToAspNetUserDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserClaimDtoToAspNetUserClaim(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserLoginDtoToAspNetUserLogin(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserLoginToAspNetUserLoginDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserRoleDtoToAspNetUserRole(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserRoleToAspNetUserRoleDto(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserTokenDtoToAspNetUserToken(item, true));
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
	            results.Add(CloningHelper.ConvertAspNetUserTokenToAspNetUserTokenDto(item, true));
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

        
        /// <summary>
        /// Converts a ClientDto list to Client list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<Client> ConvertClientDtoToEntity(IEnumerable<ClientDto> items)
	    {
            List<Client> results = new List<Client>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertClientDtoToClient(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a Client list to ClientDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ClientDto> ConvertClientEntityToDto(IEnumerable<Client> items)
	    {
            List<ClientDto> results = new List<ClientDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertClientToClientDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ClientBulkDelete(IEnumerable<ClientDto> items)
		{
			this.ClientRepository.BulkDelete(this.ConvertClientDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ClientBulkDeleteAsync(IEnumerable<ClientDto> items)
		{
			await this.ClientRepository.BulkDeleteAsync(this.ConvertClientDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ClientBulkInsert(IEnumerable<ClientDto> items)
		{
			this.ClientRepository.BulkInsert(this.ConvertClientDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ClientBulkInsertAsync(IEnumerable<ClientDto> items)
		{
			await this.ClientRepository.BulkInsertAsync(this.ConvertClientDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  ClientBulkUpdate(IEnumerable<ClientDto> items)
		{
			this.ClientRepository.BulkUpdate(this.ConvertClientDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ClientBulkUpdateAsync(IEnumerable<ClientDto> items)
		{
			await this.ClientRepository.BulkUpdateAsync(this.ConvertClientDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a ClientGrantTypeDto list to ClientGrantType list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ClientGrantType> ConvertClientGrantTypeDtoToEntity(IEnumerable<ClientGrantTypeDto> items)
	    {
            List<ClientGrantType> results = new List<ClientGrantType>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertClientGrantTypeDtoToClientGrantType(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a ClientGrantType list to ClientGrantTypeDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ClientGrantTypeDto> ConvertClientGrantTypeEntityToDto(IEnumerable<ClientGrantType> items)
	    {
            List<ClientGrantTypeDto> results = new List<ClientGrantTypeDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertClientGrantTypeToClientGrantTypeDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ClientGrantTypeBulkDelete(IEnumerable<ClientGrantTypeDto> items)
		{
			this.ClientGrantTypeRepository.BulkDelete(this.ConvertClientGrantTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ClientGrantTypeBulkDeleteAsync(IEnumerable<ClientGrantTypeDto> items)
		{
			await this.ClientGrantTypeRepository.BulkDeleteAsync(this.ConvertClientGrantTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ClientGrantTypeBulkInsert(IEnumerable<ClientGrantTypeDto> items)
		{
			this.ClientGrantTypeRepository.BulkInsert(this.ConvertClientGrantTypeDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ClientGrantTypeBulkInsertAsync(IEnumerable<ClientGrantTypeDto> items)
		{
			await this.ClientGrantTypeRepository.BulkInsertAsync(this.ConvertClientGrantTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  ClientGrantTypeBulkUpdate(IEnumerable<ClientGrantTypeDto> items)
		{
			this.ClientGrantTypeRepository.BulkUpdate(this.ConvertClientGrantTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ClientGrantTypeBulkUpdateAsync(IEnumerable<ClientGrantTypeDto> items)
		{
			await this.ClientGrantTypeRepository.BulkUpdateAsync(this.ConvertClientGrantTypeDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a GrantTypeDto list to GrantType list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<GrantType> ConvertGrantTypeDtoToEntity(IEnumerable<GrantTypeDto> items)
	    {
            List<GrantType> results = new List<GrantType>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertGrantTypeDtoToGrantType(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a GrantType list to GrantTypeDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<GrantTypeDto> ConvertGrantTypeEntityToDto(IEnumerable<GrantType> items)
	    {
            List<GrantTypeDto> results = new List<GrantTypeDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertGrantTypeToGrantTypeDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void GrantTypeBulkDelete(IEnumerable<GrantTypeDto> items)
		{
			this.GrantTypeRepository.BulkDelete(this.ConvertGrantTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task GrantTypeBulkDeleteAsync(IEnumerable<GrantTypeDto> items)
		{
			await this.GrantTypeRepository.BulkDeleteAsync(this.ConvertGrantTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  GrantTypeBulkInsert(IEnumerable<GrantTypeDto> items)
		{
			this.GrantTypeRepository.BulkInsert(this.ConvertGrantTypeDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  GrantTypeBulkInsertAsync(IEnumerable<GrantTypeDto> items)
		{
			await this.GrantTypeRepository.BulkInsertAsync(this.ConvertGrantTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  GrantTypeBulkUpdate(IEnumerable<GrantTypeDto> items)
		{
			this.GrantTypeRepository.BulkUpdate(this.ConvertGrantTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  GrantTypeBulkUpdateAsync(IEnumerable<GrantTypeDto> items)
		{
			await this.GrantTypeRepository.BulkUpdateAsync(this.ConvertGrantTypeDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a IdentityResourceDto list to IdentityResource list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<IdentityResource> ConvertIdentityResourceDtoToEntity(IEnumerable<IdentityResourceDto> items)
	    {
            List<IdentityResource> results = new List<IdentityResource>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertIdentityResourceDtoToIdentityResource(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a IdentityResource list to IdentityResourceDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<IdentityResourceDto> ConvertIdentityResourceEntityToDto(IEnumerable<IdentityResource> items)
	    {
            List<IdentityResourceDto> results = new List<IdentityResourceDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertIdentityResourceToIdentityResourceDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void IdentityResourceBulkDelete(IEnumerable<IdentityResourceDto> items)
		{
			this.IdentityResourceRepository.BulkDelete(this.ConvertIdentityResourceDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task IdentityResourceBulkDeleteAsync(IEnumerable<IdentityResourceDto> items)
		{
			await this.IdentityResourceRepository.BulkDeleteAsync(this.ConvertIdentityResourceDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  IdentityResourceBulkInsert(IEnumerable<IdentityResourceDto> items)
		{
			this.IdentityResourceRepository.BulkInsert(this.ConvertIdentityResourceDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  IdentityResourceBulkInsertAsync(IEnumerable<IdentityResourceDto> items)
		{
			await this.IdentityResourceRepository.BulkInsertAsync(this.ConvertIdentityResourceDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  IdentityResourceBulkUpdate(IEnumerable<IdentityResourceDto> items)
		{
			this.IdentityResourceRepository.BulkUpdate(this.ConvertIdentityResourceDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  IdentityResourceBulkUpdateAsync(IEnumerable<IdentityResourceDto> items)
		{
			await this.IdentityResourceRepository.BulkUpdateAsync(this.ConvertIdentityResourceDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a IdentityResourceClaimTypeDto list to IdentityResourceClaimType list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<IdentityResourceClaimType> ConvertIdentityResourceClaimTypeDtoToEntity(IEnumerable<IdentityResourceClaimTypeDto> items)
	    {
            List<IdentityResourceClaimType> results = new List<IdentityResourceClaimType>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a IdentityResourceClaimType list to IdentityResourceClaimTypeDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<IdentityResourceClaimTypeDto> ConvertIdentityResourceClaimTypeEntityToDto(IEnumerable<IdentityResourceClaimType> items)
	    {
            List<IdentityResourceClaimTypeDto> results = new List<IdentityResourceClaimTypeDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void IdentityResourceClaimTypeBulkDelete(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			this.IdentityResourceClaimTypeRepository.BulkDelete(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task IdentityResourceClaimTypeBulkDeleteAsync(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			await this.IdentityResourceClaimTypeRepository.BulkDeleteAsync(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  IdentityResourceClaimTypeBulkInsert(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			this.IdentityResourceClaimTypeRepository.BulkInsert(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  IdentityResourceClaimTypeBulkInsertAsync(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			await this.IdentityResourceClaimTypeRepository.BulkInsertAsync(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  IdentityResourceClaimTypeBulkUpdate(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			this.IdentityResourceClaimTypeRepository.BulkUpdate(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  IdentityResourceClaimTypeBulkUpdateAsync(IEnumerable<IdentityResourceClaimTypeDto> items)
		{
			await this.IdentityResourceClaimTypeRepository.BulkUpdateAsync(this.ConvertIdentityResourceClaimTypeDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a PostLogoutRedirectUriDto list to PostLogoutRedirectUri list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<PostLogoutRedirectUri> ConvertPostLogoutRedirectUriDtoToEntity(IEnumerable<PostLogoutRedirectUriDto> items)
	    {
            List<PostLogoutRedirectUri> results = new List<PostLogoutRedirectUri>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a PostLogoutRedirectUri list to PostLogoutRedirectUriDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<PostLogoutRedirectUriDto> ConvertPostLogoutRedirectUriEntityToDto(IEnumerable<PostLogoutRedirectUri> items)
	    {
            List<PostLogoutRedirectUriDto> results = new List<PostLogoutRedirectUriDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void PostLogoutRedirectUriBulkDelete(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			this.PostLogoutRedirectUriRepository.BulkDelete(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task PostLogoutRedirectUriBulkDeleteAsync(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			await this.PostLogoutRedirectUriRepository.BulkDeleteAsync(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  PostLogoutRedirectUriBulkInsert(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			this.PostLogoutRedirectUriRepository.BulkInsert(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  PostLogoutRedirectUriBulkInsertAsync(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			await this.PostLogoutRedirectUriRepository.BulkInsertAsync(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  PostLogoutRedirectUriBulkUpdate(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			this.PostLogoutRedirectUriRepository.BulkUpdate(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  PostLogoutRedirectUriBulkUpdateAsync(IEnumerable<PostLogoutRedirectUriDto> items)
		{
			await this.PostLogoutRedirectUriRepository.BulkUpdateAsync(this.ConvertPostLogoutRedirectUriDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a RedirectUriDto list to RedirectUri list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<RedirectUri> ConvertRedirectUriDtoToEntity(IEnumerable<RedirectUriDto> items)
	    {
            List<RedirectUri> results = new List<RedirectUri>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertRedirectUriDtoToRedirectUri(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a RedirectUri list to RedirectUriDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<RedirectUriDto> ConvertRedirectUriEntityToDto(IEnumerable<RedirectUri> items)
	    {
            List<RedirectUriDto> results = new List<RedirectUriDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertRedirectUriToRedirectUriDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void RedirectUriBulkDelete(IEnumerable<RedirectUriDto> items)
		{
			this.RedirectUriRepository.BulkDelete(this.ConvertRedirectUriDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task RedirectUriBulkDeleteAsync(IEnumerable<RedirectUriDto> items)
		{
			await this.RedirectUriRepository.BulkDeleteAsync(this.ConvertRedirectUriDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  RedirectUriBulkInsert(IEnumerable<RedirectUriDto> items)
		{
			this.RedirectUriRepository.BulkInsert(this.ConvertRedirectUriDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  RedirectUriBulkInsertAsync(IEnumerable<RedirectUriDto> items)
		{
			await this.RedirectUriRepository.BulkInsertAsync(this.ConvertRedirectUriDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  RedirectUriBulkUpdate(IEnumerable<RedirectUriDto> items)
		{
			this.RedirectUriRepository.BulkUpdate(this.ConvertRedirectUriDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  RedirectUriBulkUpdateAsync(IEnumerable<RedirectUriDto> items)
		{
			await this.RedirectUriRepository.BulkUpdateAsync(this.ConvertRedirectUriDtoToEntity(items));
		}

        
        /// <summary>
        /// Converts a ResourceClaimTypeDto list to ResourceClaimType list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ResourceClaimType> ConvertResourceClaimTypeDtoToEntity(IEnumerable<ResourceClaimTypeDto> items)
	    {
            List<ResourceClaimType> results = new List<ResourceClaimType>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertResourceClaimTypeDtoToResourceClaimType(item, true));
	        }

	        return results;
	    }

        /// <summary>
        /// Converts a ResourceClaimType list to ResourceClaimTypeDto list
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
	    private List<ResourceClaimTypeDto> ConvertResourceClaimTypeEntityToDto(IEnumerable<ResourceClaimType> items)
	    {
            List<ResourceClaimTypeDto> results = new List<ResourceClaimTypeDto>();

	        foreach (var item in items)
	        {
	            results.Add(CloningHelper.ConvertResourceClaimTypeToResourceClaimTypeDto(item, true));
	        }

	        return results;
	    }

/// <summary>
        ///     Bulk delete entities
        /// </summary>
        /// <param name="items"></param>
        public void ResourceClaimTypeBulkDelete(IEnumerable<ResourceClaimTypeDto> items)
		{
			this.ResourceClaimTypeRepository.BulkDelete(this.ConvertResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task ResourceClaimTypeBulkDeleteAsync(IEnumerable<ResourceClaimTypeDto> items)
		{
			await this.ResourceClaimTypeRepository.BulkDeleteAsync(this.ConvertResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <param name="items"></param>
        public void  ResourceClaimTypeBulkInsert(IEnumerable<ResourceClaimTypeDto> items)
		{
			this.ResourceClaimTypeRepository.BulkInsert(this.ConvertResourceClaimTypeDtoToEntity(items));
		}
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ResourceClaimTypeBulkInsertAsync(IEnumerable<ResourceClaimTypeDto> items)
		{
			await this.ResourceClaimTypeRepository.BulkInsertAsync(this.ConvertResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <param name="items"></param>
        public void  ResourceClaimTypeBulkUpdate(IEnumerable<ResourceClaimTypeDto> items)
		{
			this.ResourceClaimTypeRepository.BulkUpdate(this.ConvertResourceClaimTypeDtoToEntity(items));
		}

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task  ResourceClaimTypeBulkUpdateAsync(IEnumerable<ResourceClaimTypeDto> items)
		{
			await this.ResourceClaimTypeRepository.BulkUpdateAsync(this.ConvertResourceClaimTypeDtoToEntity(items));
		}

        #endregion
    }
}

