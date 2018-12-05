// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ScaffoldConfig.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Configuration
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;

    using DotNetScaffolder.Components.Common;
    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.Contract.UI;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes;

    #endregion

    /// <summary>
    ///     The scaffold config.
    /// </summary>
    public class ScaffoldConfig
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes static members of the <see cref="ScaffoldConfig" /> class.
        ///     Initializes a new instance of the <see cref="ScaffoldConfig" /> class.
        /// </summary>
        static ScaffoldConfig()
        {
            LanguageOutputs = new Lazy<ILanguageOutput, IDictionary<string, object>>[0];
            OutputGenerators = new Lazy<IOutputGenerator, IDictionary<string, object>>[0];
            SourceTypes = new Lazy<ISourceType, IDictionary<string, object>>[0];
            NamingConventions = new Lazy<INamingConvention, IDictionary<string, object>>[0];
            Drivers = new Lazy<IDriver, IDictionary<string, object>>[0];
            DataTypeUIs = new Lazy<IDataTypeUI, IDictionary<string, object>>[0];

#if DEBUG
            ModelPath = ConfigurationManager.AppSettings["ModelPath"];
            ConfigPath = @"Config\Settings.xml";
#endif
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the collection options.
        /// </summary>
        public static Lazy<ICollectionOption, IDictionary<string, object>>[] CollectionOptions { get; set; }

        /// <summary>
        ///     Gets or sets the config path.
        /// </summary>
        public static string ConfigPath { get; set; }

        /// <summary>
        ///     Gets or sets the DataTypes
        /// </summary>
        public static Lazy<IDataType, IDictionary<string, object>>[] DataTypes { get; set; }

        /// <summary>
        ///     Gets or sets the data type u is.
        /// </summary>
        public static Lazy<IDataTypeUI, IDictionary<string, object>>[] DataTypeUIs { get; set; }

        /// <summary>
        ///     Gets or sets the drivers.
        /// </summary>
        ////[ImportMany]
        public static Lazy<IDriver, IDictionary<string, object>>[] Drivers { get; set; }

        /// <summary>
        ///     Gets or sets the driver types.
        /// </summary>
        public static Lazy<IDriverType, IDictionary<string, object>>[] DriverTypes { get; set; }

        /// <summary>
        ///     Gets or sets the i driver type ui.
        /// </summary>
        public static Lazy<IDriverTypeUI, IDictionary<string, object>>[] DriverTypeUIs { get; set; }

        /// <summary>
        ///     Gets or sets the language outputs.
        /// </summary>
        public static Lazy<ILanguageOutput, IDictionary<string, object>>[] LanguageOutputs { get; set; }

        /// <summary>
        ///     Gets or sets the model path.
        /// </summary>
        public static string ModelPath { get; set; }

        /// <summary>
        ///     Gets or sets the naming conventions.
        /// </summary>
        public static Lazy<INamingConvention, IDictionary<string, object>>[] NamingConventions { get; set; }

        /// <summary>
        ///     Gets or sets the output generators.
        /// </summary>
        public static Lazy<IOutputGenerator, IDictionary<string, object>>[] OutputGenerators { get; set; }

        /// <summary>
        ///     Gets or sets the source types.
        /// </summary>
        public static Lazy<ISourceType, IDictionary<string, object>>[] SourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the driver cache types
        /// </summary>
        public static Lazy<IIDriverTypeCache, IDictionary<string, object>>[] DriverTypeCache { get; set; }
        
        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="configPath">
        /// The config Path.
        /// </param>
        public static void Load(string configPath = "")
        {
            ComponentImporter importer = new ComponentImporter();
            importer.Import(configPath);

            Drivers = importer.Drivers;
            NamingConventions = importer.NamingConventions;
            SourceTypes = importer.SourceTypes;
            LanguageOutputs = importer.LanguageOutputs;
            OutputGenerators = importer.OutputGenerators;
            DataTypes = importer.DataTypes;
            CollectionOptions = importer.CollectionOptions;
            DataTypeUIs = importer.DataTypeUIs;
            DriverTypes = importer.DriverTypes;
            DriverTypeUIs = importer.DriverTypeUI;
            DriverTypeCache = importer.DriverTypeCache;
        }

        /// <summary>
        /// Return collection option.
        /// </summary>
        /// <param name="optionId">
        /// The option id.
        /// </param>
        /// <returns>
        /// The <see cref="ICollectionOption"/>.
        /// </returns>
        public static ICollectionOption ReturnCollectionOption(Guid optionId)
        {
            if (CollectionOptions == null || !CollectionOptions.Any()) return null;

            return CollectionOptions.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == optionId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return data type.
        /// </summary>
        /// <param name="dataTypeId">
        /// The data type id.
        /// </param>
        /// <returns>
        /// The <see cref="IDataType"/>.
        /// </returns>
        public static IDataType ReturnDataType(Guid dataTypeId)
        {
            if (DataTypes == null || !DataTypes.Any()) return null;

            return DataTypes.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == dataTypeId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return data type ui.
        /// </summary>
        /// <param name="dataTypeId">
        /// The data type id.
        /// </param>
        /// <param name="displayType">
        /// The display type.
        /// </param>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        public static IDataTypeUI ReturnDataTypeUI(Guid dataTypeId, DisplayType displayType)
        {
            if (DataTypeUIs == null || !DataTypeUIs.Any()) return null;

            return DataTypeUIs.FirstOrDefault(
                d => d.Metadata["DataType"].ToString().ToLower() == dataTypeId.ToString().ToLower()
                     && d.Metadata["DisplayType"].ToString().ToLower() == displayType.ToString().ToLower()).Value;
        }

        /// <summary>
        /// Return driver.
        /// </summary>
        /// <param name="driverTypeId">
        /// </param>
        /// <returns>
        /// The <see cref="IDriver"/>.
        /// </returns>
        public static IDriver ReturnDriver(Guid driverTypeId)
        {
            if (Drivers == null || !Drivers.Any()) return null;

            return Drivers.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == driverTypeId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return driver data type ui.
        /// </summary>
        /// <param name="driverTypeId">
        /// The driver type id.
        /// </param>
        /// <param name="displayType">
        /// The display type.
        /// </param>
        /// <returns>
        /// The <see cref="IDriverTypeUI"/>.
        /// </returns>
        public static IDriverTypeUI ReturnDriverDataTypeUi(Guid driverTypeId, DisplayType displayType)
        {
            if (DriverTypeUIs == null || !DriverTypeUIs.Any()) return null;

            return DriverTypeUIs.FirstOrDefault(
                d => 
                     d.Metadata["DriverType"].ToString().ToLower() == driverTypeId.ToString().ToLower()
                     && d.Metadata["DisplayType"].ToString().ToLower() == displayType.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return driver types.
        /// </summary>
        /// <param name="driverTypeId">
        /// The driver type id.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public static List<IDriverType> ReturnDriverTypes(Guid driverTypeId)
        {
            if (DriverTypes == null || !DriverTypes.Any()) return null;

            List<IDriverType> result = new List<IDriverType>();

            foreach (Lazy<IDriverType, IDictionary<string, object>> foundDriverType in DriverTypes)
            {
                if (foundDriverType.Value.Id == driverTypeId)
                {
                    if (!result.Any(d => d.Id == foundDriverType.Value.Id))
                    {
                        result.Add(foundDriverType.Value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// The return language output.
        /// </summary>
        /// <param name="languageOutputId">
        /// The language output id.
        /// </param>
        /// <returns>
        /// The <see cref="ILanguageOutput"/>.
        /// </returns>
        public static ILanguageOutput ReturnLanguageOutput(Guid languageOutputId)
        {
            if (LanguageOutputs == null || !LanguageOutputs.Any()) return null;

            return LanguageOutputs.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == languageOutputId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// Return naming convention.
        /// </summary>
        /// <param name="conventionId">
        /// The convention id.
        /// </param>
        /// <returns>
        /// The <see cref="INamingConvention"/>.
        /// </returns>
        public static INamingConvention ReturnNamingConvention(Guid conventionId)
        {
            if (NamingConventions == null || !NamingConventions.Any()) return null;

            return NamingConventions.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == conventionId.ToString().ToLower()).Value;
        }

        /// <summary>
        /// The return source type.
        /// </summary>
        /// <param name="sourceTypeId">
        /// The source type id.
        /// </param>
        /// <returns>
        /// The <see cref="ISourceType"/>.
        /// </returns>
        public static ISourceType ReturnSourceType(Guid sourceTypeId)
        {
            if (SourceTypes == null || !SourceTypes.Any()) return null;

            //var test = SourceTypes.Where(d => d.Metadata["ValueMetaData"].ToString().ToLower() == sourceTypeId.ToString().ToLower());

            return SourceTypes.FirstOrDefault(
                d => d.Metadata["ValueMetaData"].ToString().ToLower() == sourceTypeId.ToString().ToLower()).Value;
        }

        #endregion
    }
}