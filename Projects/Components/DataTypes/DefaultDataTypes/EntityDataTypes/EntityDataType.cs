using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.EntityDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Entity")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]

    public class EntityDataType : IDataType
    {
        public string Namespace { get; set; } = "Entity";

        public string OutputFolder { get; set; } = "Entity";

        public bool Enabled { get; set; } = false;

        private const string FILE_NAME = "Entity.mdl";

        private IDataType dataTypeImplementation;

        public EntityDataType()
        {
        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4440"), Name = "Entity" };
        }

        public IDataTypeUI<IDictionary<string, string>> AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            EntityUserControl newControl = new EntityUserControl
                                               {
                                                   Visible = true,
                                                   Dock = DockStyle.Fill
                                               };
            newControl.BringToFront();
            parent.Controls.Add(newControl);
            return (IDataTypeUI<IDictionary<string, string>>)newControl;
        }

        public bool SaveConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<EntityDataType>.Save(this, filePath);
            return true;
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<EntityDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        public Table MetaData { get; set; }
    }
}
