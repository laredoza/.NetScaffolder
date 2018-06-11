// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreMySqlDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore
{
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;
    using System.Text;

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

        public string AsAlias(string name)
        {
            return $"`{name}`";
        }

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

        public bool UseSchema => false;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string>
                {
                    "Microsoft.EntityFrameworkCore",
                    "Microsoft.EntityFrameworkCore.Metadata.Builders",
                    "RepositoryEFDotnet.Contexts.EFCore",
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

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType =>
            this.DriverType ?? (this.DriverType = new EFCoreDriverType("EFCoreDriverType.xml"));

        public string TransformIndex(Index index)
        {
            var idxs = new StringBuilder("HasIndex(i => new {");
            bool isClustered = index.IndexType == IndexType.Clustered;

            if (index.Columns != null && index.Columns.Any())
            {
                for (int i = 0; i < index.Columns.Count; i++)
                {
                    if (i > 0)
                    {
                        idxs.Append(", ");
                    }

                    idxs.Append($"i.{index.Columns[i]}");
                }
            }

            idxs.Append("})");
            idxs.Append($".IsUnique({index.IsUnique.ToString().ToLower()})");

            return idxs.ToString();
        }
    }
}