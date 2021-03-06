﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NHibernateOracleDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Mapping.MetaData.Model;

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
{
    // <summary>
    // Defines the default NHibernate 4.0 Sql Server driver.
    /// <summary>
    ///     The n hibernate sql server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "NHibernate 5.0")]
    [ExportMetadata("TypeIdMetaData", "04BE92C9-F4CE-4B33-95A2-AF4CD5CCFB71")]
    [ExportMetadata("NameMetaData", "NHibernate - Oracle (Default)")]
    [ExportMetadata("ValueMetaData", "04BE92C9-F4CE-4B33-95A2-AF4CD5CCFB71")]
    public class NHibernateOracleDriver : IDriver, INHibernateConfig
    {
        #region Public Properties

        public string ConfigName => "OracleClientConfiguration.Oracle10";

        /// <summary>
        ///     The configuration class.
        /// </summary>
        public string ConfigurationClass => "OracleDataClientConfiguration";

        public string ConfigurationOption { get; set; } = "Oracle10";

        /// <summary>
        ///     Gets the context attribute.
        /// </summary>
        public string ContextAttribute => string.Empty;

        /// <summary>
        ///     The driver type.
        /// </summary>
        public NhibernateDriverType DriverType { get; set; }

        /// <summary>
        ///     Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => false;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string> {"NHibernate", "NHibernate.Cfg", "FluentNHibernate.Cfg.Db", "FluentNHibernate.Cfg"};

        /// <summary>
        ///     The parent folder.
        /// </summary>
        public string ParentFolder => "NHib";

        /// <summary>
        ///     The prefix.
        /// </summary>
        public string Prefix => "Oracle";

        /// <summary>
        ///     The use schema.
        /// </summary>
        public bool UseSchema => false;

        #endregion

        /// <summary>
        ///     The driver type.
        /// </summary>
        IDriverType IDriver.DriverType =>
            DriverType ?? (DriverType = new NhibernateDriverType("NHibernateDriverType.xml"));

        #region Public Methods And Operators

        /// <summary>
        ///     The as alias.
        /// </summary>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string AsAlias(string name)
        {
            return !DriverType.UseAlias ? name : $"`{name}`";
        }

        public int CheckPrecision(Column col)
        {
            return col.Precision;
        }

        public string GenerateBulkDelete()
        {
            return "base.BulkDelete(items);";
        }

        public string GenerateBulkDeleteAsync()
        {
            return "await base.BulkDeleteAsync(items);";
        }

        public string GenerateBulkInsert()
        {
            return "base.BulkInsert(items);";
        }

        public string GenerateBulkInsertAsync()
        {
            return "await base.BulkInsertAsync(items);";
        }

        public string GenerateBulkUpdate()
        {
            return "base.BulkUpdate(items);";
        }

        public string GenerateBulkUpdateAsync()
        {
            return "await base.BulkUpdateAsync(items);";
        }

        /// <summary>
        ///     The transform index.
        /// </summary>
        /// <param name="index">
        ///     The index.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public string TransformIndex(Index index, INamingConvention nc = null)
        {
            return NhibernateDriverType.TransformIndex(index, nc);
        }

        public string InitContext()
        {
            return string.Empty;
        }

        #endregion
    }
}