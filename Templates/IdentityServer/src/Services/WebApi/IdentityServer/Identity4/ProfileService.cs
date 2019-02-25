using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Data.ApplicationService;
using DotNetScaffolder.Domain.Data.Interfaces.RepositoryInterfaces;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace DotNetScaffolder.IdentityServer.Services.WebApi.IdentityServer.Identity4
{
    public class ProfileService : IProfileService
    {
        private IIdentityServerApplicationService applicationService;

        public ProfileService(
            IIdentityServerApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            if (!string.IsNullOrEmpty(context.Subject.Identity.Name))
            {
                var user = await this.applicationService.ReturnUserWithClaimDetailAsync(context.Subject.Identity.Name.ToLower());

                var roleClaims = context.Subject.FindAll(JwtClaimTypes.Role);
                List<string> list = context.RequestedClaimTypes.ToList();
                context.IssuedClaims.AddRange(roleClaims);
                context.IssuedClaims.AddRange(context.Subject.Claims);

                if (user != null)
                {
                    foreach (var userRole in user.AspNetUserRole)
                    {
                        context.IssuedClaims.Add(new Claim(JwtClaimTypes.Role, userRole.AspNetRole.Name));
                    }

                    var claims = await applicationService.ReturnAspNetUserClaims(user.Id);
                    foreach (var claim in claims)
                    {
                        context.IssuedClaims.Add(new Claim(claim.ClaimType, claim.ClaimValue));
                    }

                }

                //context.IssuedClaims.Add(new Claim(JwtClaimTypes.Role, "Admin"));
                //context.IssuedClaims.Add(new Claim(JwtClaimTypes.Role, "Test"));
            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            string userName = context.Subject.Identity.Name;
            // var userId = context.Subject.Claims.FirstOrDefault(x => x.Type == "user_id");

            if (!string.IsNullOrEmpty(userName))
            {
                var user = await applicationService.ReturnUserAsync(userName);

                if (user != null)
                {
                    if (!user.LockoutEnabled && user.EmailConfirmed)
                    {
                        context.IsActive = true;
                    }
                    else
                    {
                        context.IsActive = false;
                    }
                }
            }
            else
            {
                context.IsActive = false;
            }

            // await base.IsActiveAsync(context);
            //https://stackoverflow.com/questions/45900162/including-core-identity-role-claims-in-identity-server-4-id-token
            //https://github.com/IdentityServer/IdentityServer4/issues/1786
        }
    }


    //public class ProfileService : IProfileService
    //{
    //    //services
    //    private readonly IUserRepository _userRepository;

    //    public ProfileService(IUserRepository userRepository)
    //    {
    //        _userRepository = userRepository;
    //    }

    //    //Get user profile date in terms of claims when calling /connect/userinfo
    //    public async Task GetProfileDataAsync(ProfileDataRequestContext context)
    //    {
    //        try
    //        {
    //            //depending on the scope accessing the user data.
    //            if (!string.IsNullOrEmpty(context.Subject.Identity.Name))
    //            {
    //                //get user from db (in my case this is by email)
    //                var user = await _userRepository.FindAsync(context.Subject.Identity.Name);

    //                if (user != null)
    //                {
    //                    var claims = GetUserClaims(user);

    //                    //set issued claims to return
    //                    context.IssuedClaims = claims.Where(x => context.RequestedClaimTypes.Contains(x.Type)).ToList();
    //                }
    //            }
    //            else
    //            {
    //                //get subject from context (this was set ResourceOwnerPasswordValidator.ValidateAsync),
    //                //where and subject was set to my user id.
    //                var userId = context.Subject.Claims.FirstOrDefault(x => x.Type == "sub");

    //                if (!string.IsNullOrEmpty(userId?.Value) && long.Parse(userId.Value) > 0)
    //                {
    //                    //get user from db (find user by user id)
    //                    var user = await _userRepository.FindAsync(long.Parse(userId.Value));

    //                    // issue the claims for the user
    //                    if (user != null)
    //                    {
    //                        var claims = ResourceOwnerPasswordValidator.GetUserClaims(user);

    //                        context.IssuedClaims = claims.Where(x => context.RequestedClaimTypes.Contains(x.Type)).ToList();
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            //log your error
    //        }
    //    }

    //    //check if user account is active.
    //    public async Task IsActiveAsync(IsActiveContext context)
    //    {
    //        try
    //        {
    //            //get subject from context (set in ResourceOwnerPasswordValidator.ValidateAsync),
    //            var userId = context.Subject.Claims.FirstOrDefault(x => x.Type == "user_id");

    //            if (!string.IsNullOrEmpty(userId?.Value) && long.Parse(userId.Value) > 0)
    //            {
    //                var user = await _userRepository.FindAsync(long.Parse(userId.Value));

    //                if (user != null)
    //                {
    //                    if (user.IsActive)
    //                    {
    //                        context.IsActive = user.IsActive;
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            //handle error logging
    //        }
    //    }
    //}
}