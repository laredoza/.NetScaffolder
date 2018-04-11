namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes.UnitOfWorkDataTypes
{
    #region Using

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

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Unit of Work")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4480")]
    public class UnitOfWorkDataType : IDataType
    {
        #region Constants

        private const string FILE_NAME = "Uow.mdl";

        #endregion

        #region Constructors and Destructors

        #endregion

        #region Properties

        public bool Enabled { get; set; } = false;

        public string Namespace { get; set; } = "UnitOfWork";

        public string OutputFolder { get; set; } = "Uow";

        #endregion

        #region Public methods and operators

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4480"), Name = "Unit of Work" };
        }

        public IDataTypeUI<IDictionary<string, string>, DT> AddConfigUI<DT>(object parameters)
        {
            var parent = parameters as Control;
            var newControl = new UnitOfWorkUserControl
                                 {
                                     Visible = true,
                                     Dock = DockStyle.Fill
                                 };
            newControl.BringToFront();
            parent.Controls.Add(newControl);
            return (IDataTypeUI<IDictionary<string, string>, DT>)newControl;
        }

        public bool SaveConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<UnitOfWorkDataType>.Save(this, filePath);
            return true;
        }

        public void LoadConfig(IDictionary<string, string> parameters)
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

        public Table MetaData { get; set; }

        #endregion
    }
}