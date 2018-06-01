// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NHibernateSqlServerDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    // <summary>
    // Defines the default NHibernate 4.0 Sql Server driver.
    /// <summary>
    /// The n hibernate sql server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "NHibernate 4.0")]
    [ExportMetadata("TypeIdMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4401")]
    [ExportMetadata("NameMetaData", "NHibernate - Sql Server (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4413")]
    public class NHibernateSqlServerDriver : IDriver
    {
        #region Public Properties

        /// <summary>
        /// The configuration class.
        /// </summary>
        public string ConfigurationClass => "MsSqlConfiguration";

        /// <summary>
        /// Gets the context attribute.
        /// </summary>
        public string ContextAttribute => string.Empty;

        /// <summary>
        /// The driver type.
        /// </summary>
        public NhibernateDriverType DriverType { get; set; }

        /// <summary>
        /// Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => false;

        /// <summary>
        /// Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string> { "NHibernate", "FluentNHibernate.Cfg.Db", "FluentNHibernate.Cfg" };

        /// <summary>
        /// The parent folder.
        /// </summary>
        public string ParentFolder => "NHibernate";

        /// <summary>
        /// The prefix.
        /// </summary>
        public string Prefix => "SqlServer";

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType =>
            this.DriverType ?? (this.DriverType = new NhibernateDriverType("NHibernateDriverType.xml"));
    }
}