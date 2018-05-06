// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepoInterfaceDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepoInterfaceDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.Base;
    using DotNetScaffolder.Core.Common.Serializer;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The repository data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "RepoInterface")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4451")]
    public class RepoInterfaceDataType : BaseDataType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoInterfaceDataType"/> class.
        /// </summary>
        public RepoInterfaceDataType()
            : base("RepoInterface.xml")
        {
        }

        /// <summary>
        /// Gets the full namespace.
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
        /// Gets the model name.
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
        public string Namespace { get; set; } = "Interfaces";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Repository";

        /// <summary>
        /// Gets or sets the output path.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// Gets the repo name.
        /// </summary>
        [XmlIgnore]
        public string RepoName
        {
            get
            {
                return this.MetaData != null
                           ? this.NamingConvention.ApplyNamingConvention(this.MetaData.TableName)
                           : string.Empty;
            }
        }

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
            var newControl = new RepoInterfaceUserControl { Visible = true, Dock = DockStyle.Fill, DataType = this };
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
            return this.CreateUI(null);
        }

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
                var appService = ObjectXMLSerializer<RepoInterfaceDataType>.Load(filePath);
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4451"), Name = "Repo Interfaces" };
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
            ObjectXMLSerializer<RepoInterfaceDataType>.Save(this, filePath);
            return true;
        }
    }
}