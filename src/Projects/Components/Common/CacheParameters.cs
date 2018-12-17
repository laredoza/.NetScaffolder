#region Usings

using DotNetScaffolder.Components.Common.Contract;

#endregion

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers
{
    public class CacheParameters
    {
        #region Public Properties

        public string ConnectionName { get; set; }
        public string ContextName { get; set; }
        public IDriver Driver { get; set; }

        #endregion
    }
}