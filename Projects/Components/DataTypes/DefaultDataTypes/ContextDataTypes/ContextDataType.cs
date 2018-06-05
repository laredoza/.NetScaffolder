// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContextDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.ContextDataTypes
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
    ///     The context data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Context")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]
    public class ContextDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ContextDataType" /> class.
        /// </summary>
        public ContextDataType()
            : base("Context.xml")
        {
            this.Contexts = new List<ContextData>();
            this.MissingTables = new List<ContextDataError>();
            this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            this.LanguageOutputDetails[0].Templates.Add("ContextGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("ContextCoreTemplate.ttInclude");

            //this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4411"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            //this.LanguageOutputDetails[1].Templates.Add("File3.tt");
            //this.LanguageOutputDetails[1].Templates.Add("File4.tt");

        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the contexts.
        /// </summary>
        public List<ContextData> Contexts { get; private set; }

        public List<ContextDataError> MissingTables { get; set; }

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
                this.Contexts = ObjectXMLSerializer<List<ContextData>>.Load(filePath);
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
            var parent = new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4430"), Name = "Context" };

            if (this.Contexts.Any())
            {
                foreach (var context in this.Contexts)
                {
                    parent.Children.Add(
                        new Hierarchy { ParentId = parent.Id, Id = context.Id, Name = context.ContextName });
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
            ObjectXMLSerializer<List<ContextData>>.Save(this.Contexts, filePath);
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

            foreach (var contextData in this.Contexts)
            {
                foreach (Table model in contextData.Models)
                {
                    if (!this.DomainDefinition.Tables.Exists(t => t.TableName == model.TableName))
                    {
                        this.ValidationResult.Add(new Validation(ValidationType.ContextMissingModels, $"The {contextData.ContextName} Context is missing {model.TableName} Model"));
                        this.MissingTables.Add(new ContextDataError { TableName = model.TableName, ContextData = contextData });
                    }
                }

                if (string.IsNullOrEmpty(contextData.ContextName))
                {
                    this.ValidationResult.Add(new Validation(ValidationType.ContextNameEmpty, $"Contexts must have a name"));
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