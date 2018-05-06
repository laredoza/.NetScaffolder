// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFSqlServerDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EF7
{
    #region Usings

    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     Defines the default EF Core Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "Entity Framework Core")]
    [ExportMetadata("TypeIdMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4402")]
    [ExportMetadata("NameMetaData", "Entity Framework Core - SqlServer (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4417")]
    public class EFCoreSqlServerDriver : IDriver
    {
    }
}