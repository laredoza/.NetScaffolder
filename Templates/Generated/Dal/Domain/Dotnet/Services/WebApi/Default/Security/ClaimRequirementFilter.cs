using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using IDesignTimeMvcBuilderConfiguration = Microsoft.AspNetCore.Mvc.IDesignTimeMvcBuilderConfiguration;

namespace RepositoryEFDotnet.Services.WebApi.Default.Security
{
    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public ClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool hasClaim = false;

            if (_claim.Type == MyClaimTypes.Permission)
            {
                hasClaim =
                    context.HttpContext.User.Claims.Any(c => c.Type == _claim.Type && c.Value == _claim.Value);
            }
            else if (_claim.Type == MyClaimTypes.Role)
            {
                hasClaim = context.HttpContext.User.IsInRole(_claim.Value);
                // You should still be able to use [Authorize(Roles = "Administrator")] on static content for roles
            }
            else if (_claim.Type == MyClaimTypes.Generic)
            {
                // This can be used to query our pages table to find the role for a controller/action combination and test it--> Same as we
                // were going to do with OnExecute as HttpContext is available
            }

            //if (!hasClaim)
            //{
            //    context.Result = new ForbidResult();
            //}
        }
    }
}
