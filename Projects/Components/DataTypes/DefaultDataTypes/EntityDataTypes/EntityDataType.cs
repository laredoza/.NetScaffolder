// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes
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
    ///     The entity data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Entity")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]
    public class EntityDataType : BaseDataType
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="EntityDataType" /> class.
        /// </summary>
        public EntityDataType()
            : base("Entity.xml")
        {
            this.LanguageOutputDetails.Add(new LanguageOutputDetails { LanguageOutput = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410"), OutputGenerator = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4410") });
            this.LanguageOutputDetails[0].Templates.Add("EntityGenerator.ttInclude");
            this.LanguageOutputDetails[0].Templates.Add("EntityTemplate.ttInclude");
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether add inject constructor.
        /// </summary>
        public bool AddInjectConstructor { get; set; }

        /// <summary>
        ///     Gets the entity name.
        /// </summary>
        [XmlIgnore]
        public string EntityName
        {
            get
            {
                if (this.MetaData == null)
                {
                    return string.Empty;
                }

                if (this.NamingConvention == null)
                {
                    return this.MetaData.TableName;
                }

                return this.NamingConvention.ApplyNamingConvention(this.MetaData.TableName);
            }
        }

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
        ///     Gets or sets the inherit from.
        /// </summary>
        public string InheritFrom { get; set; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Entity";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Entity";

        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        ///     Gets the transform inherit from.
        /// </summary>
        [XmlIgnore]
        public string TransformInheritFrom
        {
            get
            {
                string inherit = string.Empty;

                if (!string.IsNullOrEmpty(this.InheritFrom))
                {
                    inherit = $": {this.InheritFrom}";
                }

                if (this.UseInterface)
                {
                    inherit += !string.IsNullOrEmpty(this.InheritFrom) ? ", " : ": ";
                    inherit += $"I{this.EntityName}";
                }

                return inherit;
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether use interface.
        /// </summary>
        public bool UseInterface { get; set; }

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
                var entity = ObjectXMLSerializer<EntityDataType>.Load(filePath);

                if (entity != null)
                {
                    this.Namespace = entity.Namespace;
                    this.OutputFolder = entity.OutputFolder;
                    this.OutputPath = entity.OutputPath;
                    this.InheritFrom = entity.InheritFrom;
                    this.UseInterface = entity.UseInterface;
                    this.AddInjectConstructor = entity.AddInjectConstructor;
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4440"), Name = "Entity" };
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
            ObjectXMLSerializer<EntityDataType>.Save(this, filePath);
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