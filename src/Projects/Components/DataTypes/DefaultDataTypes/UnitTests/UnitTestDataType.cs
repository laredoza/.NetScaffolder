// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Xml.Serialization;
using DotNetScaffolder.Components.Common.Contract;
using DotNetScaffolder.Components.Common.MetaData;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.StructureMapDataTypes;
using DotNetScaffolder.Core.Common.Serializer;
using DotNetScaffolder.Core.Common.Validation;
using FormControls.TreeView;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.UnitTests
{
    #region Usings

    #endregion

    /// <summary>
    ///     The dto data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Unit Tests")]
    [ExportMetadata("ValueMetaData", "AB2445E3-5F8D-4BEC-ADDC-0D1430E15CA1")]
    public class UnitTestDataType : BaseDataType
    {
        #region Constructors and Destructors

        public UnitTestDataType() : base("UnitTestDataType.xml")
        {
            this.LanguageOutputDetails.Add(new LanguageOutputDetails
            {
                LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"),
                OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410")
            });

            this.LanguageOutputDetails[0].Templates.Add("BaseUnitTestGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("BaseUnitTestTemplate.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("BaseUowUnitTestTemplate.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("BaseRepositoryUnitTestTemplate.ttInclude");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the full namespace.
        /// </summary>
        [XmlIgnore]
        public string FullNamespace => $"{this.BaseNamespace}.{this.Namespace}";

        public string Namespace { get; set; } = "UnitTests";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = @"OutputFolder";

        /// <summary>
        ///     Gets or sets the base test output folder.
        /// </summary>
        public string BaseTestOutputFolder { get; set; } = @"..\..\Tests\Base\DotNetScaffolder.Repository.UnitTests.Base.csproj";
        
        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; } = @"..\..\Tests\{0}\DotNetScaffolder.Repository.UnitTests.{0}.csproj";

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
            this.Loaded = true;

            if (File.Exists(filePath))
            {
                var dt = ObjectXMLSerializer<UnitTestDataType>.Load(filePath);
                if (dt != null)
                {
                    this.Namespace = dt.Namespace;
                    this.OutputFolder = dt.OutputFolder;
                    this.OutputPath = dt.OutputPath;
                    this.BaseTestOutputFolder = dt.BaseTestOutputFolder;

                    this.AdditionalNamespaces.Clear();
                    this.AdditionalNamespaces.AddRange(dt.AdditionalNamespaces);
                }
            }
        }

        /// <summary>
        /// The return navigation.
        /// </summary>
        /// <returns>
        /// The <see cref="Hierarchy"/>.
        /// </returns>
        public override Hierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("AB2445E3-5F8D-4BEC-ADDC-0D1430E15CA1"), Name = "Unit Tests" };
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
            ObjectXMLSerializer<UnitTestDataType>.Save(this, filePath);
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