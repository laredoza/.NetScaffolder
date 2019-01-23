// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationServiceDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Xml.Serialization;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ApplicationServiceDataTypes
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
    using DotNetScaffolder.Mapping.MetaData.Model;
    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The application service data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Application Service")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]
    public class ApplicationServiceDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApplicationServiceDataType" /> class.
        /// </summary>
        public ApplicationServiceDataType()
            : base("Application.xml")
        {
            this.ApplicationServiceData = new List<ApplicationServiceData>();
            this.MissingTables = new List<ApplicationServiceDataError>();
            this.LanguageOutputDetails.Add(new LanguageOutputDetails{ LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410")});
            this.LanguageOutputDetails[0].Templates.Add("ApplicationServiceGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("ApplicationServiceInterfaceTemplate.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("ApplicationServiceTemplate.ttInclude");
            this.AdditionalNamespacesInterfaces = new List<string>();
            this.AdditionalNamespacesWeb = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the ApplicationServiceData.
        /// </summary>
        public List<ApplicationServiceData> ApplicationServiceData { get; private set; }

        public List<ApplicationServiceDataError> MissingTables { get; set; }

        public List<string> AdditionalNamespacesInterfaces { get; set; }

        public List<string> AdditionalNamespacesWeb{ get; set; }

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
                var dt = ObjectXMLSerializer<ApplicationServiceDataType>.Load(filePath);
                this.ApplicationServiceData = dt.ApplicationServiceData;

                this.AdditionalNamespaces.Clear();
                this.AdditionalNamespaces.AddRange(dt.AdditionalNamespaces);

                this.AdditionalNamespacesInterfaces.Clear();
                this.AdditionalNamespacesInterfaces.AddRange(dt.AdditionalNamespacesInterfaces);


                // Ensure tables are up to date
                foreach (ApplicationServiceData applicationServiceData in this.ApplicationServiceData)
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

        /// <summary>
        /// The return navigation.
        /// </summary>
        /// <returns>
        /// The <see cref="Hierarchy"/>.
        /// </returns>
        public override Hierarchy ReturnNavigation()
        {
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4420"), Name = "Application Service" };

            if (this.ApplicationServiceData.Any())
            {
                foreach (var applicationService in this.ApplicationServiceData.Where(o => o != null))
                {
                    parent.Children.Add(
                        new Hierarchy { ParentId = parent.Id, Id = applicationService.Id, Name = applicationService.ApplicationServiceName });
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
            ObjectXMLSerializer<ApplicationServiceDataType>.Save(this, filePath);
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
            this.MissingTables.Clear();

            foreach (var applicationServiceData in this.ApplicationServiceData)
            {
                foreach (Table model in applicationServiceData.Models)
                {
                    if (!this.DomainDefinition.Tables.Exists(t => t.TableName == model.TableName))
                    {
                        this.ValidationResult.Add(new Validation(ValidationType.ApplicationServiceMissingModels, $"The {applicationServiceData.ApplicationServiceName} Application Service is missing {model.TableName} Model"));
                        this.MissingTables.Add(new ApplicationServiceDataError { ApplicationServiceName = model.TableName, ApplicationServiceData = applicationServiceData });
                    }
                }

                if (string.IsNullOrEmpty(applicationServiceData.ApplicationServiceName))
                {
                    this.ValidationResult.Add(new Validation(ValidationType.ApplicationServiceNameEmpty, $"Application Services must have a name"));
                }

            }

            if (this.LanguageOutputDetails.Count == 0)
            {
                this.ValidationResult.Add(new Validation(ValidationType.DataTypeLanguageMissing, "A Datatype must have at least one LanguageOption"));
            }

            return this.ValidationResult;
        }

        #endregion

    }
}