// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitOfWorkDataType.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.UnitOfWorkDataTypes
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.IO;
    using System.Windows.Forms;

    using DotNetScaffolder.Components.Common.Contract;
    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    using FormControls.TreeView;

    #endregion

    /// <summary>
    ///     The unit of work data type.
    /// </summary>
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Unit of Work")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4480")]
    public class UnitOfWorkDataType : IDataType
    {
        #region Constants

        /// <summary>
        ///     The fil e_ name.
        /// </summary>
        private const string FILE_NAME = "Uow.mdl";

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets a value indicating whether enabled.
        /// </summary>
        public bool Enabled { get; set; } = false;

        /// <summary>
        ///     Gets or sets the meta data.
        /// </summary>
        public Table MetaData { get; set; }

        /// <summary>
        ///     Gets or sets the namespace.
        /// </summary>
        public string Namespace { get; set; } = "UnitOfWork";

        /// <summary>
        ///     Gets or sets the output folder.
        /// </summary>
        public string OutputFolder { get; set; } = "Uow";

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
        public IDataTypeUI<IDictionary<string, string>> CreateUI(IDictionary<string, string> parameters)
        {
            var newControl = new UnitOfWorkUserControl
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
        public IDataTypeUI<IDictionary<string, string>> CreateUI()
        {
            return CreateUI(null);
        }

        /// <summary>
        /// The load.
        /// </summary>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        public void Load(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<UnitOfWorkDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        /// <summary>
        ///     The return navigation.
        /// </summary>
        /// <returns>
        ///     The <see cref="IHierarchy" />.
        /// </returns>
        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4480"), Name = "Unit of Work" };
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
        public bool Save(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<UnitOfWorkDataType>.Save(this, filePath);
            return true;
        }

        #endregion
    }
}