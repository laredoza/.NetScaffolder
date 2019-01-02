// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFOracleDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EF6
{
    #region Usings

    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    #endregion

    /// <summary>
    ///     Defines the default EF 6.0 Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("NameMetaData", "Entity Framework - Oracle (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class EFOracleDriver : IDriver
    {
        #region Public Properties

        /// <summary>
        /// The configuration class.
        /// </summary>
        public string ConfigurationClass => string.Empty;

        public string ConfigurationOption { get; set; }

        /// <summary>
        ///     Gets the context attribute.
        /// </summary>
        public string ContextAttribute => "[DbConfigurationType(typeof(OracleDbConfiguration))]";

        /// <summary>
        /// The driver type.
        /// </summary>
        public EFDriverType DriverType { get; set; }

        /// <summary>
        ///     Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => true;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string>
                {
                    "System.Data.Entity",
                    "System.Data.Entity.ModelConfiguration",
                    "System.Data.Entity.Infrastructure.Annotations",
                    "Oracle.ManagedDataAccess.Client",
                    "Oracle.Config"
                };

        /// <summary>
        ///     The parent folder.
        /// </summary>
        public string ParentFolder => "EF";

        /// <summary>
        ///     The prefix.
        /// </summary>
        public string Prefix => "Oracle";

        /// <summary>
        /// The use schema.
        /// </summary>
        public bool UseSchema => true;

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType => this.DriverType ?? (this.DriverType = new EFDriverType("EFDriverType.xml"));

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
            return !this.DriverType.UseAlias ? name : $"\\\"{name}\\\"";
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
        public string TransformIndex(Index index, INamingConvention nc = null)
        {
            return EFDriverType.TransformIndex(index, nc);
        }

        public string InitContext()
        {
            return String.Empty;
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

        #endregion
    }
}