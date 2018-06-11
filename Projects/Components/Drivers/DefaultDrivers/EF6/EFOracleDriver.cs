// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFOracleDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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

        public string AsAlias(string name)
        {
            return $"\\\"{name}\\\"";
        }

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

        public bool UseSchema => true;

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

        #endregion

        /// <summary>
        /// The driver type.
        /// </summary>
        IDriverType IDriver.DriverType => this.DriverType ?? (this.DriverType = new EFDriverType("EFDriverType.xml"));

        public string TransformIndex(Index index)
        {
            return EFDriverType.TransformIndex(index);
        }
    }
}