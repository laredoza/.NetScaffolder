using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    public abstract class BaseSecurityFilter : ISecurityFilter
    {
        #region Public Methods And Operators

        public abstract bool CheckGenericPermission(AuthorizationFilterContext context, Claim claim);

        public virtual bool OnAuthorization(AuthorizationFilterContext context, Claim claim)
        {
            var hasClaim = false;

            if (claim.Type == ClaimTypes.Permission)
            {
                hasClaim = CheckClaimPermission(context, claim);
            }
            else if (claim.Type == ClaimTypes.Role)
            {
                hasClaim = CheckRolePermission(context, claim);
                // You should still be able to use [Authorize(Roles = "Administrator")] on static content for roles
            }
            else if (claim.Type == ClaimTypes.Generic)
            {
                // This can be used to query our pages table to find the role for a controller/action combination and test it--> Same as we
                // were going to do with OnExecute as HttpContext is available
                hasClaim = CheckGenericPermission(context, claim);
            }
            else if (claim.Type == ClaimTypes.All)
            {
                hasClaim = CheckGenericPermission(context, claim);

                if (!hasClaim)
                {
                    hasClaim = CheckClaimPermission(context, claim);
                    if (!hasClaim) hasClaim = CheckGenericPermission(context, claim);
                }
            }

            return hasClaim;
        }

        #endregion

        #region Other Methods

        private bool CheckClaimPermission(AuthorizationFilterContext context, Claim claim)
        {
            return context.HttpContext.User.Claims.Any(c => c.Type == claim.Type && c.Value == claim.Value);
        }

        private bool CheckRolePermission(AuthorizationFilterContext context, Claim claim)
        {
            return context.HttpContext.User.IsInRole(claim.Value);
        }

        #endregion
    }
}