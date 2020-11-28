// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFMySqlDriver.cs" company="DotnetScaffolder">
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
    [ExportMetadata("NameMetaData", "Entity Framework - Postgres (Default)")]
    [ExportMetadata("ValueMetaData", "2ED41F2A-84C9-7A41-8524-07557F37A5C1")]
    public class EFPostgresDriver : IDriver
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
        public string ContextAttribute => "";

        /// <summary>
        /// The driver type.
        /// </summary>
        public EFDriverType DriverType { get; set; }

        /// <summary>
        ///     Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => false;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string>
                {
                    "Npgsql",
                    "System.Data.Entity",
                    "System.Data.Entity.ModelConfiguration",
                    "System.Data.Entity.Infrastructure.Annotations",
                };

        /// <summary>
        ///     The parent folder.
        /// </summary>
        public string ParentFolder => "EF";

        /// <summary>
        ///     The prefix.
        /// </summary>
        public string Prefix => "Postgres";

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
            return !this.DriverType.UseAlias ? name : $"{name}";
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

        public string InitContext
        {
            get
            {
                return string.Empty;
            }
        }

        public int CheckPrecision(Column col)
        {
            if (col.DomainDataType == DomainDataType.Decimal)
            {
                if (col.Precision > 29)
                {
                    return 29;
                }
            }

            return col.Precision;
        }

        public string GenerateBulkDelete
        {
            get
            {
                return "base.BulkDelete(items);";
            }
        }
        public string GenerateBulkDeleteAsync
        {
            get
            {
                return "await base.BulkDeleteAsync(items);";
            }
        }

        public string GenerateBulkInsert
        {
            get
            {
                return "base.BulkInsert(items);";
            }
        }

        public string GenerateBulkInsertAsync
        {
            get
            {
                return "await base.BulkInsertAsync(items);";
            }
        }

        public string GenerateBulkUpdate
        {
            get
            {
                return "base.BulkUpdate(items);";
            }
        }

        public string GenerateBulkUpdateAsync
        {
            get
            {
                return "await base.BulkUpdateAsync(items);";
            }
        }

        #endregion
    }
}