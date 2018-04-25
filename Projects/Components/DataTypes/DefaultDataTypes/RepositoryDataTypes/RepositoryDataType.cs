// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    #region Usings

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using FormControls.TreeView;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    #endregion

    /// <summary>
    ///     The repository data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Repository")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4450")]
    public class RepositoryDataType : BaseDataType
    {
        public RepositoryDataType() : base("Repository.xml") { }

        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; } = false;

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "Repository";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Repository";

        public string OutputPath { get; set; }

        [XmlIgnore]
        public string RepoName
        {
            get
            {
                return MetaData != null ? NamingConvention.ApplyNamingConvention(MetaData.TableName) : string.Empty;
            }
        }

        [XmlIgnore]
        public string ModelName
        {
            get
            {
                return MetaData != null ? NamingConvention.ApplyNamingConvention(MetaData.TableName) : string.Empty;
            }
        }

        [XmlIgnore]
        public string FullNamespace
        {
            get
            {
                return $"{BaseNamespace}.{Namespace}";
            }
        }

        #endregion

        #region Public methods and operators

        /// <summary>
        /// The create ui.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="IDataTypeUI"/>.
        /// </returns>
        public override IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters)
        {
            RepositoryUserControl newControl = new RepositoryUserControl
            {
                Visible = true,
                Dock = DockStyle.Fill,
                DataType = this
            };
            return newControl;
        }

        /// <summary>
        ///     The create ui.
        /// </summary>
        /// <returns>
        ///     The <see cref="IDataTypeUI" />.
        /// </returns>
        public override IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return CreateUI(null);
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public override void Load(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FileName);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<RepositoryDataType>.Load(filePath);
                if (appService != null)
                {
                    this.Namespace = appService.Namespace;
                    this.OutputFolder = appService.OutputFolder;
                    this.OutputPath = appService.OutputPath;
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4450"), Name = "Repository" };
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
            var filePath = Path.Combine(parameters["basePath"], FileName);
            ObjectXMLSerializer<RepositoryDataType>.Save(this, filePath);
            return true;
        }

        #endregion
    }
}