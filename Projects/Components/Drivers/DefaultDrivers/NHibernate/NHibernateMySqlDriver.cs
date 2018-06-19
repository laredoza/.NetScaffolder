// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NHibernateMySqlDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    // <summary>
    // Defines the default NHibernate 4.0 Sql Server driver.
    /// <summary>
    /// The n hibernate sql server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "NHibernate 5.0")]
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

        public string ConfigurationOption { get; set; } = "Standard";

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
            new List<string> { "NHibernate", "NHibernate.Cfg", "FluentNHibernate.Cfg.Db", "FluentNHibernate.Cfg" };

        /// <summary>
        /// The parent folder.
        /// </summary>
        public string ParentFolder => "NHibernate";

        /// <summary>
        /// The prefix.
        /// </summary>
        public string Prefix => "MySql";

        /// <summary>
        /// The use schema.
        /// </summary>
        public bool UseSchema => false;

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType =>
            this.DriverType ?? (this.DriverType = new NhibernateDriverType("NHibernateDriverType.xml"));

        #region Public Methods And Operators

        /// <summary>
        /// The as alias.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string AsAlias(string name)
        {
            return !this.DriverType.UseAlias ? name : $"`{name}`";
        }

        /// <summary>
        /// The transform index.
        /// </summary>
        /// <param name="index">
        /// The index.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformIndex(Index index)
        {
            return NhibernateDriverType.TransformIndex(index);
        }

        #endregion
    }
}