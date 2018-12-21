// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataType.cs" company="DotnetScaffolder">
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
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;
    using DotNetScaffolder.Mapping.MetaData.Model;

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
            this.ApplicationServiceDatas = new List<ApplicationServiceData>();
            this.MissingApplicationServices = new List<ApplicationServiceDataError>();
            this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            this.LanguageOutputDetails[0].Templates.Add("ContextGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("ContextCoreTemplate.ttInclude");
            //this.AdditionalNamespaces.Add("RepositoryEFDotnet.ApplicationServiceDatas.EFCore.Base");
            //this.AdditionalNamespaces.Add("RepositoryEFDotnet.Core.Base");
            //this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4411"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            //this.LanguageOutputDetails[1].Templates.Add("File3.tt");
            //this.LanguageOutputDetails[1].Templates.Add("File4.tt");

        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the Application Services.
        /// </summary>
        public List<ApplicationServiceData> ApplicationServiceDatas { get; private set; }

        public List<ApplicationServiceDataError> MissingApplicationServices { get; set; }

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
                var dt = ObjectXMLSerializer<ApplicationServiceDataType>.Load(filePath);
                this.ApplicationServiceDatas = dt.ApplicationServiceData;

                this.AdditionalNamespaces.Clear();
                this.AdditionalNamespaces.AddRange(dt.AdditionalNamespaces);
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
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4431"), Name = "WebApi" };

            if (this.ApplicationServiceDatas.Any())
            {
                foreach (var context in this.ApplicationServiceDatas.Where(o => o != null))
                {
                    parent.Children.Add(
                        new Hierarchy { ParentId = parent.Id, Id = context.Id, Name = context.ApplicationServiceName });
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
            this.MissingApplicationServices.Clear();

            //foreach (var applicationServiceData in this.ApplicationServiceDatas)
            //{
            //    foreach (Table model in applicationServiceData.Models)
            //    {
            //        if (!this.DomainDefinition.Tables.Exists(t => t.TableName == model.TableName))
            //        {
            //            this.ValidationResult.Add(new Validation(ValidationType.ContextMissingModels, $"The {applicationServiceData.ContextName} Context is missing {model.TableName} Model"));
            //            this.MissingApplicationServices.Add(new ApplicationServiceDataError { TableName = model.TableName, ApplicationServiceData = applicationServiceData });
            //        }
            //    }

            //    if (string.IsNullOrEmpty(applicationServiceData.ContextName))
            //    {
            //        this.ValidationResult.Add(new Validation(ValidationType.ContextNameEmpty, $"ApplicationServiceDatas must have a name"));
            //    }

            //}

            //if (this.LanguageOutputDetails.Count == 0)
            //{
            //    this.ValidationResult.Add(new Validation(ValidationType.DataTypeLanguageMissing, "A Datatype must have at least one LanguageOption"));
            //}

            //if (this.ApplicationServiceDatas.Any() && !this.ApplicationServiceDatas.Any(o => o.IsDefault))
            //{
            //    this.ValidationResult.Add(new Validation(ValidationType.ContextIsDefaultNotSet, "Please set the default context"));
            //}

            //todo: Add back
            //if (this.ApplicationServiceDatas.Count(o => o.IsDefault) > 1)
            //{
            //    this.ValidationResult.Add(new Validation(ValidationType.ContextDuplicateIsDefaultConfig, "There is already a context set as default"));
            //}

            return this.ValidationResult;
        }

        #endregion
    }
}