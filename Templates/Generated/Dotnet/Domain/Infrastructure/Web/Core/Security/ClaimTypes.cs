namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Security
{
    /// <summary>
    ///     Define attribute permission filtering
    /// </summary>
    public static class ClaimTypes
    {
        #region Constants

        public const string All = "All";
        public const string Generic = "Role";
        public const string Permission = "Permission";
        public const string Role = "Role";

        #endregion
    }
}