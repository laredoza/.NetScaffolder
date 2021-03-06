﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiServiceDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using DotNetScaffolder.Core.Configuration;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.MetaData;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The WebApi data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "WebApi")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4431")]
    public class WebApiServiceDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WebApiServiceDataType" /> class.
        /// </summary>
        public WebApiServiceDataType()
            : base("WebApi.xml")
        {
            this.WebApiDataList = new List<WebApiServiceData>();
            this.MissingApplicationList = new List<ApplicationServiceDataError>();
            this.LanguageOutputDetails.Add(
                new LanguageOutputDetails
                {
                    LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"),
                    OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410")
                });
            this.LanguageOutputDetails[0].Templates.Add("ContextGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("ContextCoreTemplate.ttInclude");

            // this.AdditionalNamespaces.Add("RepositoryEFDotnet.WebApiDataList.EFCore.Base");
            // this.AdditionalNamespaces.Add("RepositoryEFDotnet.Core.Base");
            // this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4411"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            // this.LanguageOutputDetails[1].Templates.Add("File3.tt");
            // this.LanguageOutputDetails[1].Templates.Add("File4.tt");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the application service data type.
        /// </summary>
        [XmlIgnore]
        public ApplicationServiceDataType ApplicationServiceDataType { get; set; }

        /// <summary>
        ///     Gets or sets the missing web api list.
        /// </summary>
        public List<ApplicationServiceDataError> MissingApplicationList { get; set; }

        /// <summary>
        ///     Gets the web api data list.
        /// </summary>
        public List<WebApiServiceData> WebApiDataList { get; private set; }

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
            if (parameters == null) return;

            if (!parameters.ContainsKey("basePath"))
            {
                return;
            }

            var filePath = Path.Combine(parameters["basePath"], this.FileName);
            this.Loaded = true;

            if (File.Exists(filePath))
            {
                var dt = ObjectXMLSerializer<WebApiServiceDataType>.Load(filePath);
                this.WebApiDataList = dt.WebApiDataList;

                this.AdditionalNamespaces.Clear();
                this.AdditionalNamespaces.AddRange(dt.AdditionalNamespaces);

                // Ensure tables are up to date

                foreach (var webApiServiceData in this.WebApiDataList)
                {
                    foreach (ApplicationServiceData applicationServiceData in webApiServiceData.Models)
                    {
                        for (int i = 0; i < applicationServiceData.Models.Count; i++)
                        {
                            var model = applicationServiceData.Models[i];
                            applicationServiceData.Models[i] = DomainDefinition.Tables.FirstOrDefault(t =>
                                t.SchemaName == model.SchemaName && t.TableName == model.TableName);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="Hierarchy" />.
        /// </returns>
        public override Hierarchy ReturnNavigation()
        {
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4431"), Name = "WebApi" };

            if (this.WebApiDataList.Any())
            {
                foreach (var webApi in this.WebApiDataList.Where(o => o != null))
                {
                    parent.Children.Add(
                        new Hierarchy { ParentId = parent.Id, Id = webApi.Id, Name = webApi.WebApiName });
                }
            }

            return parent;
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
            if (parameters == null) return false;

            if (!parameters.ContainsKey("basePath"))
            {
                return false;
            }

            var filePath = Path.Combine(parameters["basePath"], this.FileName);
            ObjectXMLSerializer<WebApiServiceDataType>.Save(this, filePath);
            return true;
        }

        /// <summary>
        /// The transform model name.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformModelName(string name)
        {
            if (this.NamingConvention == null)
            {
                return name;
            }

            return this.NamingConvention.ApplyNamingConvention(name);
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
            this.MissingApplicationList.Clear();

            if (this.ApplicationServiceDataType == null)
            {
                this.ApplicationServiceDataType =
                    ScaffoldConfig.ReturnDataType(new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4420")) as ApplicationServiceDataType;
            }

            foreach (var webApiServiceData in this.WebApiDataList)
            {
                foreach (ApplicationServiceData serviceData in webApiServiceData.Models)
                {
                    if (!this.ApplicationServiceDataType.ApplicationServiceData.Exists(t => t.Id == serviceData.Id))
                    {
                        this.ValidationResult.Add(
                            new Validation(
                                ValidationType.ApplicationServicesMissing,
                                $"The {webApiServiceData.WebApiName} WebApi is missing {serviceData.ApplicationServiceName} Application Service"));
                        this.MissingApplicationList.Add(
                            new ApplicationServiceDataError
                            {
                                ApplicationServiceName = serviceData.ApplicationServiceName,
                                ApplicationServiceData = serviceData
                            });
                    }

                    if (string.IsNullOrEmpty(webApiServiceData.WebApiName))
                    {
                        this.ValidationResult.Add(
                            new Validation(ValidationType.ContextNameEmpty, "WebApiDataList must have a name"));
                    }
                }
            }

            if (this.LanguageOutputDetails.Count == 0)
            {
                this.ValidationResult.Add(
                    new Validation(
                        ValidationType.DataTypeLanguageMissing,
                        "A Datatype must have at least one LanguageOption"));
            }

            return this.ValidationResult;
        }

        #endregion
    }
}