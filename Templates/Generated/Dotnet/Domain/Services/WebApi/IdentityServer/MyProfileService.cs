using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Services;

public class MyProfileService : IProfileService
{
    public MyProfileService()
    { }

    public Task GetProfileDataAsync(ProfileDataRequestContext context)
    {
        var roleClaims = context.Subject.FindAll(JwtClaimTypes.Role);
        List<string> list = context.RequestedClaimTypes.ToList();
        context.IssuedClaims.AddRange(roleClaims);
        context.IssuedClaims.AddRange(context.Subject.Claims);

        context.IssuedClaims.Add(new Claim(JwtClaimTypes.Role, "Admin"));
        context.IssuedClaims.Add(new Claim(JwtClaimTypes.Role, "Test"));
        return Task.CompletedTask;
    }

    public Task IsActiveAsync(IsActiveContext context)
    {
        // await base.IsActiveAsync(context);
        return Task.CompletedTask;

        //https://stackoverflow.com/questions/45900162/including-core-identity-role-claims-in-identity-server-4-id-token
        //https://github.com/IdentityServer/IdentityServer4/issues/1786
    }
}