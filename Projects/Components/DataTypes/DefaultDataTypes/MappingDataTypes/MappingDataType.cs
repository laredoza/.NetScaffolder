// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.MappingDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.MetaData;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The repository data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Mapping")]
    [ExportMetadata("ValueMetaData", "361AC82C-8F2A-4D7C-B455-AE5EFFBA9D4A")]
    public class MappingDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MappingDataType" /> class.
        /// </summary>
        public MappingDataType()
            : base("Mapping.xml")
        {
            this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            this.LanguageOutputDetails[0].Templates.Add("MappingGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("MappingTemplate.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("MappingNHibernateTemplate.ttInclude");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the full namespace.
        /// </summary>
        [XmlIgnore]
        public string FullNamespace
        {
            get
            {
                return $"{this.BaseNamespace}.{this.Namespace}";
            }
        }

        /// <summary>
        ///     Gets the model name.
        /// </summary>
        [XmlIgnore]
        public string ModelName
        {
            get
            {
                return this.MetaData != null
                           ? this.NamingConvention.ApplyNamingConvention(this.MetaData.TableName)
                           : string.Empty;
            }
        }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Mappings";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Mappings";

        public string PostFix { get; set; } = "Map";

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public override void Load(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<MappingDataType>.Load(filePath);
                if (appService != null)
                {
                    this.Namespace = appService.Namespace;
                    this.OutputFolder = appService.OutputFolder;
                    this.PostFix = appService.PostFix;
                }
            }
        }

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="IHierarchy" />.
        /// </returns>
        public override Hierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("361AC82C-8F2A-4D7C-B455-AE5EFFBA9D4A"), Name = "Mapping" };
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool Save(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], this.FileName);
            ObjectXMLSerializer<MappingDataType>.Save(this, filePath);
            return true;
        }

        /// <summary>
        ///     The validate.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public override List<Validation> Validate()
        {
            this.ValidationResult = new List<Validation>();

            if (this.LanguageOutputDetails.Count == 0)
            {
                this.ValidationResult.Add(new Validation(ValidationType.DataTypeLanguageMissing, "A Datatype must have at least one LanguageOption"));
            }

            return this.ValidationResult;
        }

        #endregion
    }
}