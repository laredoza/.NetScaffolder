using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Security;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DotNetScaffolder.Domain.Services.WebApi.Default.Security
{
    public class SecurityFilter : BaseSecurityFilter
    {
        private readonly IActionDescriptorCollectionProvider _provider;

        public SecurityFilter(IActionDescriptorCollectionProvider provider)
        {
            _provider = provider;
        }

        public override bool CheckGenericPermission(AuthorizationFilterContext context, Claim claim)
        {
            var currentUser = context.HttpContext.User;

            string controller = context.RouteData.Values["controller"].ToString();
            string action = context.RouteData.Values["action"].ToString();

            //  Checks should be done from data in a database
            //  Should probably do is logged in checks, etc

            // Quick example permission checks
            if (controller == "Values" && action == "Get")
            {
                return true;
            }
            else if (currentUser.Identity.IsAuthenticated && currentUser.HasClaim(c => c.Value == "Admin" ) && controller == "Product")
            {
                return true;
            }

            return false;
        }
    }
}