using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration
{
    using System.ComponentModel.Composition;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;

    public class ScaffoldConfig
    {
        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        [ImportMany]
        public static Lazy<IDriver, IDictionary<string, object>>[] DriverTypes { get; set; }

        /// <summary>
        ///     Gets or sets the naming conventions.
        /// </summary>
        [ImportMany]
        public static Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        ///     Gets or sets the source types.
        /// </summary>
        [ImportMany]
        public static Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        [ImportMany]
        public static Lazy<ILanguageOutput, IDictionary<string, object>>[] LanguageOutputs { get; set; }

        [ImportMany]
        public static Lazy<IOutputGenerator, IDictionary<string, object>>[] OutputGenerators { get; set; }

        public static void Load()
        {
            ComponentImporter importer = new ComponentImporter();
            importer.Import();

            DriverTypes = importer.DriverTypes;
            NamingConventions = importer.NamingConventions;
            SourceTypes = importer.SourceTypes;
            LanguageOutputs = importer.LanguageOutputs;
            OutputGenerators = importer.OutputGenerators;
        }
    }
}
