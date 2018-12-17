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
    using DotNetScaffolder.Mapping.MetaData.Model;

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
                    "Microsoft.EntityFrameworkCore.Storage",
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
        public string Prefix => "SqlServer";

        /// <summary>
        /// The use schema.
        /// </summary>
        public bool UseSchema => true;

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
            return !this.DriverType.UseAlias ? name : $"[{name}]";
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
            var idxs = EFCoreDriverType.TransformIndex(index, nc);
            bool isClustered = index.IndexType == IndexType.Clustered;

            if (isClustered)
            {
                idxs = $"{idxs}.ForSqlServerIsClustered()";
            }

            return idxs;
        }

        public int CheckPrecision(Column col)
        {
            return col.Precision;
        }

        public string GenerateBulkDelete()
        {
            return "this.BulkDelete(items);";
        }

        public string GenerateBulkDeleteAsync()
        {
            return "await this.BulkDeleteAsync(items);";
        }

        public string GenerateBulkInsert()
        {
            return "this.BulkInsert(items);";
        }

        public string GenerateBulkInsertAsync()
        {
            return "await this.BulkInsertAsync(items);";
        }

        public string GenerateBulkUpdate()
        {
            return "this.BulkUpdate(items);";
        }

        public string GenerateBulkUpdateAsync()
        {
            return "await this.BulkUpdateAsync(items);";
        }

        #endregion
    }
}