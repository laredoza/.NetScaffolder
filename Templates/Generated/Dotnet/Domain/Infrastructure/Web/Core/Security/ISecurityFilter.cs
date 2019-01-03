#region

using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Filters;

#endregion

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    public interface ISecurityFilter
    {
        #region Public Methods And Operators

        bool OnAuthorization(AuthorizationFilterContext context, Claim claim);

        #endregion
    }
}