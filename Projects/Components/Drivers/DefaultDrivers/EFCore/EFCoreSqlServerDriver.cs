// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFCoreSqlServerDriver.cs" company="DotnetScaffolder">
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
    [ExportMetadata("NameMetaData", "Entity Framework Core - SqlServer (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4417")]
    public class EFCoreSqlServerDriver : IDriver
    {
        #region Public Properties

        /// <summary>
        /// The configuration class.
        /// </summary>
        public string ConfigurationClass => string.Empty;

        public string AsAlias(string name)
        {
            return $"[{name}]";
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

        public bool UseSchema => true;

        /// <summary>
        ///     Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces =>
            new List<string>
                {
                    "Microsoft.EntityFrameworkCore",
                    "Microsoft.EntityFrameworkCore.Storage",
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
        public string Prefix => "SqlServer";

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

            if (isClustered)
            {
                idxs.Append(".ForSqlServerIsClustered()");
            }

            return idxs.ToString();
        }
    }
}