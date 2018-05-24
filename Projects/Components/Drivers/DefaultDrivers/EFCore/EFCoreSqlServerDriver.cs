// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreSqlServerDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6;

    /// <summary>
    /// Defines the default EF Core Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("NameMetaData", "Entity Framework Core - SqlServer (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4417")]
    public class EFCoreSqlServerDriver : IDriver
    {
        #region Public Properties

        /// <summary>
        ///     Gets the context attribute.
        /// </summary>
        public string ContextAttribute => string.Empty;

        /// <summary>
        ///     Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => false;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string> { "Microsoft.EntityFrameworkCore", "Microsoft.EntityFrameworkCore.Storage" };

        /// <summary>
        ///     The parent folder.
        /// </summary>
        public string ParentFolder => "EFCore";

        /// <summary>
        ///     The prefix.
        /// </summary>
        public string Prefix => "SqlServer";

        /// <summary>
        /// The driver type.
        /// </summary>
        public IDriverType DriverType => new EFCoreDriverType("EFCoreDriverType.xml");

        #endregion
    }
}