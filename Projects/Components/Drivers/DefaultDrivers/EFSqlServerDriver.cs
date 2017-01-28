// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFSqlServerDriver.cs" company="">
//   
// </copyright>
// <summary>
//   The ef sql server driver.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Contractors.Drivers.DefaultDrivers
{
    #region Using

    using System.ComponentModel.Composition;

    using Components.Common.Contract;

    #endregion

    /// <summary>
    /// Defines the default EF 6.0 Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "Entity FrameWork 6.0")]
    [ExportMetadata("NameMetaData", "SqlServer (Microsoft Default)")]
    public class EFSqlServerDriver : IDriver
    {
    }
}