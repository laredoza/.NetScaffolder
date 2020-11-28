// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreMySqlDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Mapping.MetaData.Model;

    /// <summary>
    /// Defines the default EF Core Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("NameMetaData", "Entity Framework Core - MySql (Default)")]
    [ExportMetadata("ValueMetaData", "8A1103C5-7557-4449-825F-299CF9749AD2")]
    public class EFCoreMySqlDriver : IDriver
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
        public string ContextAttribute => string.Empty;

        /// <summary>
        /// The driver type.
        /// </summary>
        public EFCoreDriverType DriverType { get; set; }

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
                    "Microsoft.EntityFrameworkCore",
                    "Microsoft.EntityFrameworkCore.Metadata.Builders",
                    "System.Configuration"
                };

        /// <summary>
        ///     The parent folder.
        /// </summary>
        public string ParentFolder => "EFCore";

        /// <summary>
        ///     The prefix.
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
            this.DriverType ?? (this.DriverType = new EFCoreDriverType("EFCoreDriverType.xml"));

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
            return EFCoreDriverType.TransformIndex(index, nc);
        }

        public string InitContext
        {
            get
            {
                return "optionsBuilder.UseMySql(this.ConnectionString);";
            }
        }
        
        public int CheckPrecision(Column col)
        {
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