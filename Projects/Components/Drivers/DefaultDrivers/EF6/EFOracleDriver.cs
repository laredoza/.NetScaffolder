// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFSqlServerDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     Defines the default EF 6.0 Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "Entity Framework 6.0")]
    [ExportMetadata("TypeIdMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4400")]
    [ExportMetadata("NameMetaData", "Entity Framework - Oracle (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class EFOracleDriver : IDriver
    {
    }
}