// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScaffoldConfig.cs" company="">
//   
// </copyright>
// <summary>
//   The scaffold config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Configuration
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;

    #endregion

    /// <summary>
    /// The scaffold config.
    /// </summary>
    public class ScaffoldConfig
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaffoldConfig"/> class.
        /// </summary>
        static ScaffoldConfig()
        {
            LanguageOutputs = new Lazy<ILanguageOutput, IDictionary<string, object>>[0];
            OutputGenerators = new Lazy<IOutputGenerator, IDictionary<string, object>>[0];
            SourceTypes = new Lazy<ISourceType, IDictionary<string, object>>[0];
            NamingConventions = new Lazy<INamingConvention, IDictionary<string, object>>[0];
            Drivers = new Lazy<IDriver, IDictionary<string, object>>[0];
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the drivers.
        /// </summary>
        [ImportMany]
        public static Lazy<IDriver, IDictionary<string, object>>[] Drivers { get; set; }

        /// <summary>
        /// Gets or sets the language outputs.
        /// </summary>
        [ImportMany]
        public static Lazy<ILanguageOutput, IDictionary<string, object>>[] LanguageOutputs { get; set; }

        /// <summary>
        ///     Gets or sets the naming conventions.
        /// </summary>
        [ImportMany]
        public static Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        /// Gets or sets the output generators.
        /// </summary>
        [ImportMany]
        public static Lazy<IOutputGenerator, IDictionary<string, object>>[] OutputGenerators { get; set; }

        /// <summary>
        ///     Gets or sets the source types.
        /// </summary>
        [ImportMany]
        public static Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The load.
        /// </summary>
        public static void Load()
        {
            ComponentImporter importer = new ComponentImporter();
            importer.Import();

            Drivers = importer.Drivers;
            NamingConventions = importer.NamingConventions;
            SourceTypes = importer.SourceTypes;
            LanguageOutputs = importer.LanguageOutputs;
            OutputGenerators = importer.OutputGenerators;
        }

        #endregion
    }
}