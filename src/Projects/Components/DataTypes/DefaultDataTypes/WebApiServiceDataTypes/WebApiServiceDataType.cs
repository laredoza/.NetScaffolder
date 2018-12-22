// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiServiceDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.WebApiServiceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Linq;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.Common.MetaData;
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
            this.MissingWebApiList = new List<WebApiServiceDataError>();
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
        /// Gets or sets the missing web api list.
        /// </summary>
        public List<WebApiServiceDataError> MissingWebApiList { get; set; }

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

            if (File.Exists(filePath))
            {
                var dt = ObjectXMLSerializer<WebApiServiceDataType>.Load(filePath);
                this.WebApiDataList = dt.WebApiDataList;

                this.AdditionalNamespaces.Clear();
                this.AdditionalNamespaces.AddRange(dt.AdditionalNamespaces);
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
            this.MissingWebApiList.Clear();

            // foreach (var applicationServiceData in this.WebApiDataList)
            // {
            // foreach (Table model in applicationServiceData.Models)
            // {
            // if (!this.DomainDefinition.Tables.Exists(t => t.TableName == model.TableName))
            // {
            // this.ValidationResult.Add(new Validation(ValidationType.ContextMissingModels, $"The {applicationServiceData.WebApiName} Context is missing {model.TableName} Model"));
            // this.MissingWebApiList.Add(new ApplicationServiceDataError { TableName = model.TableName, ApplicationServiceData = applicationServiceData });
            // }
            // }

            // if (string.IsNullOrEmpty(applicationServiceData.WebApiName))
            // {
            // this.ValidationResult.Add(new Validation(ValidationType.ContextNameEmpty, $"WebApiDataList must have a name"));
            // }

            // }

            // if (this.LanguageOutputDetails.Count == 0)
            // {
            // this.ValidationResult.Add(new Validation(ValidationType.DataTypeLanguageMissing, "A Datatype must have at least one LanguageOption"));
            // }

            // if (this.WebApiDataList.Any() && !this.WebApiDataList.Any(o => o.IsDefault))
            // {
            // this.ValidationResult.Add(new Validation(ValidationType.ContextIsDefaultNotSet, "Please set the default context"));
            // }

            // todo: Add back
            // if (this.WebApiDataList.Count(o => o.IsDefault) > 1)
            // {
            // this.ValidationResult.Add(new Validation(ValidationType.ContextDuplicateIsDefaultConfig, "There is already a context set as default"));
            // }
            return this.ValidationResult;
        }

        #endregion
    }
}