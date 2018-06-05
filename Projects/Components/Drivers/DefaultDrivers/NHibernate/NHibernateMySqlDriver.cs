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
    [ExportMetadata("TypeIdMetaData", "27D66D81-8F2D-481A-8547-C1E5B5444569")]
    [ExportMetadata("NameMetaData", "NHibernate - MySql (Default)")]
    [ExportMetadata("ValueMetaData", "27D66D81-8F2D-481A-8547-C1E5B5444569")]
    public class NHibernateMySqlDriver : IDriver
    {
        #region Public Properties

        /// <summary>
        /// The configuration class.
        /// </summary>
        public string ConfigurationClass => "MySQLConfiguration";

        public string AsAlias(string name)
        {
            return $"`{name}`";
        }

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

        public bool UseSchema => false;

        /// <summary>
        /// Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string>
                {
                    "NHibernate",
                    "NHibernate.Cfg",
                    "FluentNHibernate.Cfg.Db",
                    "FluentNHibernate.Cfg"
                };

        /// <summary>
        /// The parent folder.
        /// </summary>
        public string ParentFolder => "NHibernate";

        /// <summary>
        /// The prefix.
        /// </summary>
        public string Prefix => "MySql";

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType =>
            this.DriverType ?? (this.DriverType = new NhibernateDriverType("NHibernateDriverType.xml"));
    }
}