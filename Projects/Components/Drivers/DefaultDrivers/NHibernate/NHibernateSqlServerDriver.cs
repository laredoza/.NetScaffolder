﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EFSqlServerDriver.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate
{
    #region Usings

    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    ///     Defines the default NHibernate 4.0 Sql Server driver.
    /// </summary>
    [Export(typeof(IDriver))]
    [ExportMetadata("TypeMetaData", "NHibernate 4.0")]
    [ExportMetadata("TypeIdMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4401")]
    [ExportMetadata("NameMetaData", "NHibernate - Sql Server (Default)")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4413")]
    public class NHibernateSqlServerDriver : IDriver
    {
        /// <summary>
        /// Gets the name spaces used to generate templates.
        /// </summary>
        public List<string> NameSpaces => new List<string> { "System.Data.Entity" };


        /// <summary>
        /// The prefix.
        /// </summary>
        public string Prefix => "NHibernateSqlServer";

        /// <summary>
        /// Gets the context attribute.
        /// </summary>
        public string ContextAttribute => string.Empty;

        /// <summary>
        /// The parent folder.
        /// </summary>
        public string ParentFolder => "NHibernate";

        /// <summary>
        /// Force schema to uppercase.
        /// </summary>
        public bool ForceSchemaToUppercase => false;
    }
}