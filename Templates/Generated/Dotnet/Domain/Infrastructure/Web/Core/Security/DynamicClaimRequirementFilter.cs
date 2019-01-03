#region

using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

#endregion

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    /// <summary>
    ///     This is the Dynamic claim requirement filter
    /// </summary>
    public class DynamicClaimRequirementFilter : IAuthorizationFilter
    {
        #region Fields

        private readonly Claim _claim;
        private readonly ISecurityFilter _securityFilter;

        #endregion

        #region Constructors and Destructors

        public DynamicClaimRequirementFilter(Claim claim, ISecurityFilter securityFilter)
        {
            _claim = claim;
            _securityFilter = securityFilter;
        }

        #endregion

        #region Public Methods And Operators

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var hasClaim = _securityFilter.OnAuthorization(context, _claim);

            if (!hasClaim)
            {
                context.Result = new ForbidResult();
            }
        }

        #endregion
    }
}