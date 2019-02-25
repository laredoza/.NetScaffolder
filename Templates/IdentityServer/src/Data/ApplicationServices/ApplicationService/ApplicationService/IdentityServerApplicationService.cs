
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
	public partial class IdentityServerApplicationService
	{
        public async Task<ClientDto> ReturnActiveTaskAsync(string clientId)
	    {
            return CloningHelper.ConvertClientToClientDto(await this.ClientRepository.ReturnActiveTaskAsync(clientId), true);
	    }

	    public async Task<AspNetUserDto> ReturnUserAsync(string username)
	    {
	        return CloningHelper.ConvertAspNetUserToAspNetUserDto(
	            await this.AspNetUserRepository.ReturnUserAsync(username));
	    }

	    public async Task<AspNetUserDto> ReturnUserWithClaimDetailAsync(string username)
	    {
	        return CloningHelper.ConvertAspNetUserToAspNetUserDto(
	            await this.AspNetUserRepository.ReturnUserWithClaimDetailAsync(username));
        }

	    public async Task<List<AspNetUserClaimDto>> ReturnAspNetUserClaims(Guid userId)
	    {
            var claimsFound = await AspNetUserClaimRepository.LoadByUserIdAsync(userId, true);
	        var result = new List<AspNetUserClaimDto>();

	        foreach (var aspNetUserClaim in claimsFound)
	        {
                result.Add(CloningHelper.ConvertAspNetUserClaimToAspNetUserClaimDto(aspNetUserClaim));
	        }

	        return result;
	    }

	}
}

