// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DtoDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.DtoDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Core.Common.Validation;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The dto data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Dto")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4490")]
    public class DtoDataType : BaseDataType
    {
        #region Constructors and Destructors

        #region Fields

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDataType"/> class. 
        ///     The table control.
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDataType"/> class.
        /// </summary>
        public DtoDataType()
            : base("Dto.xml")
        {
        }

        #endregion

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether add inject constructor.
        /// </summary>
        public bool AddInjectConstructor { get; set; }

        /// <summary>
        ///     Gets the dto name.
        /// </summary>
        [XmlIgnore]
        public string DtoName
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
        ///     Gets the dto name full.
        /// </summary>
        [XmlIgnore]
        public string DtoNameFull
        {
            get
            {
                return $"{this.DtoName}{this.PostFix}";
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
        public string Namespace { get; set; } = "Dto";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Dto";

        /// <summary>
        ///     Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        ///     Gets or sets the post fix.
        /// </summary>
        public string PostFix { get; set; } = "Dto";

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
                    inherit += $"I{this.DtoName}";
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
            var filePath = Path.Combine(parameters["basePath"], this.FileName);

            if (File.Exists(filePath))
            {
                var dto = ObjectXMLSerializer<DtoDataType>.Load(filePath);
                if (dto != null)
                {
                    this.Namespace = dto.Namespace;
                    this.OutputFolder = dto.OutputFolder;
                    this.OutputPath = dto.OutputPath;
                    this.InheritFrom = dto.InheritFrom;
                    this.UseInterface = dto.UseInterface;
                    this.AddInjectConstructor = dto.AddInjectConstructor;
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4490"), Name = "Dto" };
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
            ObjectXMLSerializer<DtoDataType>.Save(this, filePath);
            return true;
        }

        /// <summary>
        /// The transform dto type.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string TransformDtoType(string name)
        {
            string formattedName =
                this.NamingConvention != null ? this.NamingConvention.ApplyNamingConvention(name) : name;

            return this.UseInterface ? $"I{formattedName}" : $"{formattedName}{this.PostFix}";
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

            return this.ValidationResult;
        }

        #endregion
    }
}