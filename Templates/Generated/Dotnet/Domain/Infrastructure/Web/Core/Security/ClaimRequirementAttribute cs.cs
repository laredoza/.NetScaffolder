using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimType, string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimType, claimValue) };
        }
    }
}
