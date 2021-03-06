﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComponentImporter.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.Common
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.IO;
    using System.Reflection;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;

    using global::Common.Logging;

    #endregion

    /// <summary>
    ///     The component importer.
    /// </summary>
    public class ComponentImporter
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the collection options.
        /// </summary>
        [ImportMany]
        public Lazy<ICollectionOption, IDictionary<string, object>>[] CollectionOptions { get; set; }

        /// <summary>
        ///     Gets or sets the data types.
        /// </summary>
        [ImportMany]
        public Lazy<IDataType, IDictionary<string, object>>[] DataTypes { get; set; }

        /// <summary>
        ///     Gets or sets the data type u is.
        /// </summary>
        [ImportMany]
        public Lazy<IDataTypeUI, IDictionary<string, object>>[] DataTypeUIs { get; set; }

        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        [ImportMany]
        public Lazy<IDriver, IDictionary<string, object>>[] Drivers { get; set; }

        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        [ImportMany]
        public Lazy<IDriverType, IDictionary<string, object>>[] DriverTypes { get; set; }

        /// <summary>
        /// Gets or sets the driver type ui.
        /// </summary>
        [ImportMany]
        public Lazy<IDriverTypeUI, IDictionary<string, object>>[] DriverTypeUI { get; set; }

        /// <summary>
        ///     Gets or sets LanguageOutputs
        /// </summary>
        [ImportMany]
        public Lazy<ILanguageOutput, IDictionary<string, object>>[] LanguageOutputs { get; set; }

        /// <summary>
        ///     Gets or sets the naming conventions.
        /// </summary>
        [ImportMany]
        public Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        ///     Gets or sets the output generators.
        /// </summary>
        [ImportMany]
        public Lazy<IOutputGenerator, IDictionary<string, object>>[] OutputGenerators { get; set; }

        /// <summary>
        ///     Gets or sets the source types.
        /// </summary>
        [ImportMany]
        public Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the driver cache types
        /// </summary>
        [ImportMany]
        public Lazy<IIDriverTypeCache, IDictionary<string, object>>[] DriverTypeCache { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The apply naming convention.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="conventionName">
        /// The convention name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ApplyNamingConvention(string value, string conventionName)
        {
            foreach (var convention in this.NamingConventions)
            {
                if ((string)convention.Metadata["NameMetaData"] == conventionName)
                {
                    return convention.Value.ApplyNamingConvention(value);
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Import components.
        /// </summary>
        /// <param name="importfolder">
        /// The importfolder.
        /// </param>
        public void Import(string importfolder = "")
        {
            if (string.IsNullOrEmpty(importfolder))
            {
                importfolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }

            Logger.Info($"Started DoImport() - {importfolder}");

            // An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();

            // Adds all the parts found in all assemblies in 
            // the same directory as the executing program
            catalog.Catalogs.Add(new DirectoryCatalog(importfolder));

            // Create the CompositionContainer with the parts in the catalog
            CompositionContainer container = new CompositionContainer(catalog);

            // Fill the imports of this object
            container.ComposeParts(this);

            // foreach (var item in this.DataTypes)
            // {
            // IDataType test = item.Value;
            // var a = test.ReturnNavigation();
            // }
            Logger.Info($"Completed DoImport() - {importfolder}");
        }

        #endregion
    }
}