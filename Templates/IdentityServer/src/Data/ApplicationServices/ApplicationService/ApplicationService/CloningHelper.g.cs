
// <copyright file="Dto.g.cs" company="MIT">
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
using Newtonsoft.Json;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using AutoMapper;

using DotNetScaffolder.Domain.Core;

namespace DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto
{
	public partial class CloningHelper 
	{
        static CloningHelper()
	    {
	        Configure();
	    }

        private static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AllowedScope, AllowedScopeDto>();
                cfg.CreateMap<ApiResource, ApiResourceDto>();
                cfg.CreateMap<AspNetRole, AspNetRoleDto>();
                cfg.CreateMap<AspNetRoleClaim, AspNetRoleClaimDto>();
                cfg.CreateMap<AspNetUser, AspNetUserDto>();
                cfg.CreateMap<AspNetUserClaim, AspNetUserClaimDto>();
                cfg.CreateMap<AspNetUserLogin, AspNetUserLoginDto>();
                cfg.CreateMap<AspNetUserRole, AspNetUserRoleDto>();
                cfg.CreateMap<AspNetUserToken, AspNetUserTokenDto>();
                cfg.CreateMap<Client, ClientDto>();
                cfg.CreateMap<ClientGrantType, ClientGrantTypeDto>();
                cfg.CreateMap<GrantType, GrantTypeDto>();
                cfg.CreateMap<IdentityResource, IdentityResourceDto>();
                cfg.CreateMap<IdentityResourceClaimType, IdentityResourceClaimTypeDto>();
                cfg.CreateMap<PostLogoutRedirectUri, PostLogoutRedirectUriDto>();
                cfg.CreateMap<RedirectUri, RedirectUriDto>();
                cfg.CreateMap<ResourceClaimType, ResourceClaimTypeDto>();
            });
        }

		#region EntityToDto 
		
        public static AllowedScopeDto ConvertAllowedScopeToAllowedScopeDto(AllowedScope item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AllowedScope,AllowedScopeDto>(item);
        }

        public static ApiResourceDto ConvertApiResourceToApiResourceDto(ApiResource item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<ApiResource,ApiResourceDto>(item);
        }

        public static AspNetRoleDto ConvertAspNetRoleToAspNetRoleDto(AspNetRole item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetRole,AspNetRoleDto>(item);
        }

        public static AspNetRoleClaimDto ConvertAspNetRoleClaimToAspNetRoleClaimDto(AspNetRoleClaim item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetRoleClaim,AspNetRoleClaimDto>(item);
        }

        public static AspNetUserDto ConvertAspNetUserToAspNetUserDto(AspNetUser item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetUser,AspNetUserDto>(item);
        }

        public static AspNetUserClaimDto ConvertAspNetUserClaimToAspNetUserClaimDto(AspNetUserClaim item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetUserClaim,AspNetUserClaimDto>(item);
        }

        public static AspNetUserLoginDto ConvertAspNetUserLoginToAspNetUserLoginDto(AspNetUserLogin item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetUserLogin,AspNetUserLoginDto>(item);
        }

        public static AspNetUserRoleDto ConvertAspNetUserRoleToAspNetUserRoleDto(AspNetUserRole item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetUserRole,AspNetUserRoleDto>(item);
        }

        public static AspNetUserTokenDto ConvertAspNetUserTokenToAspNetUserTokenDto(AspNetUserToken item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<AspNetUserToken,AspNetUserTokenDto>(item);
        }

        public static ClientDto ConvertClientToClientDto(Client item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<Client,ClientDto>(item);
        }

        public static ClientGrantTypeDto ConvertClientGrantTypeToClientGrantTypeDto(ClientGrantType item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<ClientGrantType,ClientGrantTypeDto>(item);
        }

        public static GrantTypeDto ConvertGrantTypeToGrantTypeDto(GrantType item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<GrantType,GrantTypeDto>(item);
        }

        public static IdentityResourceDto ConvertIdentityResourceToIdentityResourceDto(IdentityResource item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<IdentityResource,IdentityResourceDto>(item);
        }

        public static IdentityResourceClaimTypeDto ConvertIdentityResourceClaimTypeToIdentityResourceClaimTypeDto(IdentityResourceClaimType item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<IdentityResourceClaimType,IdentityResourceClaimTypeDto>(item);
        }

        public static PostLogoutRedirectUriDto ConvertPostLogoutRedirectUriToPostLogoutRedirectUriDto(PostLogoutRedirectUri item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<PostLogoutRedirectUri,PostLogoutRedirectUriDto>(item);
        }

        public static RedirectUriDto ConvertRedirectUriToRedirectUriDto(RedirectUri item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<RedirectUri,RedirectUriDto>(item);
        }

        public static ResourceClaimTypeDto ConvertResourceClaimTypeToResourceClaimTypeDto(ResourceClaimType item, bool deep = false)
		{
			if(item == null)
            { 
                return null;
            }

			return Mapper.Map<ResourceClaimType,ResourceClaimTypeDto>(item);
        }

        
		#endregion

        #region DtoToEntity
        		
        public static AllowedScope ConvertAllowedScopeDtoToAllowedScope(AllowedScopeDto item, bool deep = false)
		{
			return Mapper.Map<AllowedScopeDto,AllowedScope>(item);
		}
		
		
        public static ApiResource ConvertApiResourceDtoToApiResource(ApiResourceDto item, bool deep = false)
		{
			return Mapper.Map<ApiResourceDto,ApiResource>(item);
		}
		
		
        public static AspNetRole ConvertAspNetRoleDtoToAspNetRole(AspNetRoleDto item, bool deep = false)
		{
			return Mapper.Map<AspNetRoleDto,AspNetRole>(item);
		}
		
		
        public static AspNetRoleClaim ConvertAspNetRoleClaimDtoToAspNetRoleClaim(AspNetRoleClaimDto item, bool deep = false)
		{
			return Mapper.Map<AspNetRoleClaimDto,AspNetRoleClaim>(item);
		}
		
		
        public static AspNetUser ConvertAspNetUserDtoToAspNetUser(AspNetUserDto item, bool deep = false)
		{
			return Mapper.Map<AspNetUserDto,AspNetUser>(item);
		}
		
		
        public static AspNetUserClaim ConvertAspNetUserClaimDtoToAspNetUserClaim(AspNetUserClaimDto item, bool deep = false)
		{
			return Mapper.Map<AspNetUserClaimDto,AspNetUserClaim>(item);
		}
		
		
        public static AspNetUserLogin ConvertAspNetUserLoginDtoToAspNetUserLogin(AspNetUserLoginDto item, bool deep = false)
		{
			return Mapper.Map<AspNetUserLoginDto,AspNetUserLogin>(item);
		}
		
		
        public static AspNetUserRole ConvertAspNetUserRoleDtoToAspNetUserRole(AspNetUserRoleDto item, bool deep = false)
		{
			return Mapper.Map<AspNetUserRoleDto,AspNetUserRole>(item);
		}
		
		
        public static AspNetUserToken ConvertAspNetUserTokenDtoToAspNetUserToken(AspNetUserTokenDto item, bool deep = false)
		{
			return Mapper.Map<AspNetUserTokenDto,AspNetUserToken>(item);
		}
		
		
        public static Client ConvertClientDtoToClient(ClientDto item, bool deep = false)
		{
			return Mapper.Map<ClientDto,Client>(item);
		}
		
		
        public static ClientGrantType ConvertClientGrantTypeDtoToClientGrantType(ClientGrantTypeDto item, bool deep = false)
		{
			return Mapper.Map<ClientGrantTypeDto,ClientGrantType>(item);
		}
		
		
        public static GrantType ConvertGrantTypeDtoToGrantType(GrantTypeDto item, bool deep = false)
		{
			return Mapper.Map<GrantTypeDto,GrantType>(item);
		}
		
		
        public static IdentityResource ConvertIdentityResourceDtoToIdentityResource(IdentityResourceDto item, bool deep = false)
		{
			return Mapper.Map<IdentityResourceDto,IdentityResource>(item);
		}
		
		
        public static IdentityResourceClaimType ConvertIdentityResourceClaimTypeDtoToIdentityResourceClaimType(IdentityResourceClaimTypeDto item, bool deep = false)
		{
			return Mapper.Map<IdentityResourceClaimTypeDto,IdentityResourceClaimType>(item);
		}
		
		
        public static PostLogoutRedirectUri ConvertPostLogoutRedirectUriDtoToPostLogoutRedirectUri(PostLogoutRedirectUriDto item, bool deep = false)
		{
			return Mapper.Map<PostLogoutRedirectUriDto,PostLogoutRedirectUri>(item);
		}
		
		
        public static RedirectUri ConvertRedirectUriDtoToRedirectUri(RedirectUriDto item, bool deep = false)
		{
			return Mapper.Map<RedirectUriDto,RedirectUri>(item);
		}
		
		
        public static ResourceClaimType ConvertResourceClaimTypeDtoToResourceClaimType(ResourceClaimTypeDto item, bool deep = false)
		{
			return Mapper.Map<ResourceClaimTypeDto,ResourceClaimType>(item);
		}
		
		#endregion
	}
}
