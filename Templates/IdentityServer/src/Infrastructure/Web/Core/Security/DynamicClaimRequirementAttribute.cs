using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    public class DynamicClaimRequirementAttribute : TypeFilterAttribute
    {
        #region Constructors and Destructors

        public DynamicClaimRequirementAttribute(string claimType, string claimValue) : base(
            typeof(DynamicClaimRequirementFilter))
        {
            Arguments = new object[] {new Claim(claimType, claimValue)};
        }

        #endregion
    }
}