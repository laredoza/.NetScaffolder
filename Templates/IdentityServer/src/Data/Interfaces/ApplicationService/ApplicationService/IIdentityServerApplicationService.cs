using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;

namespace DotNetScaffolder.Domain.Data.ApplicationService
{
    public partial interface IIdentityServerApplicationService
    {
        Task<ClientDto> ReturnActiveTaskAsync(string clientId);
        Task<AspNetUserDto> ReturnUserAsync(string username);
        Task<AspNetUserDto> ReturnUserWithClaimDetailAsync(string username);
        Task<List<AspNetUserClaimDto>> ReturnAspNetUserClaims(Guid userId);
    }
}
