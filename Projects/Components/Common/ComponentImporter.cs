namespace Components.Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.IO;
    using System.Reflection;

    using Components.Common.Contract;

    using global::Common.Logging;

    public class ComponentImporter
    {
        #region Static Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(string.Empty);

        #endregion

        /// <summary>
        /// Gets or sets the naming conventions.
        /// </summary>
        [ImportMany]
        public System.Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        /// Gets or sets the source types.
        /// </summary>
        [ImportMany]
        public System.Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the driver types.
        /// </summary>
        [ImportMany]
        public System.Lazy<IDriver, IDictionary<string, object>>[] DriverTypes { get; set; }

        #region Public methods and operators

        /// <summary>
        /// Import components.
        /// </summary>
        public void Import()
        {
            Logger.Trace($"Started Import()");
            this.Import(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Logger.Trace($"Completed Import()");
        }

        /// <summary>
        /// Import components.
        /// </summary>
        /// <param name="importfolder">
        /// The importfolder.
        /// </param>
        public void Import(string importfolder)
        {
            Logger.Info($"Started DoImport() - {importfolder}");

            if (string.IsNullOrEmpty(importfolder))
            {
                Logger.Error("importFolder should not be empty");
                throw new ApplicationException("importFolder should not be empty");
            }

            // An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();

            // Adds all the parts found in all assemblies in 
            // the same directory as the executing program
            catalog.Catalogs.Add(new DirectoryCatalog(importfolder));

            // Create the CompositionContainer with the parts in the catalog
            CompositionContainer container = new CompositionContainer(catalog);

            // Fill the imports of this object
            container.ComposeParts(this);
            Logger.Info($"Started DoImport() - {importfolder}");
        }

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

        #endregion
    }
}
