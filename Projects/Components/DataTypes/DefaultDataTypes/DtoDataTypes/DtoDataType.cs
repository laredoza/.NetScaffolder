using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.TableDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    using System.IO;

    using DotNetScaffolder.Core.Common.Serializer;
    using DotNetScaffolder.Mapping.MetaData.Model;

    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Dto")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4490")]

    public class DtoDataType : IDataType
    {
        public string Namespace { get; set; } = "Repository";

        public string OutputFolder { get; set; } = "Repository";

        public bool Enabled { get; set; } = false;

        private const string FILE_NAME = "Repository.mdl";

        private Control tableControl;
        private Control fieldsControl;
        private Control relationshipControls;

        public DtoDataType()
        {
        }

        private void ConfigureControl(Control control, Control parent)
        {
            control.Visible = true;
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            parent.Controls.Add(control);
        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4490"), Name = "Table" };
        }

        public IDataTypeUI<IDictionary<string, string>> AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            TableUserControl tableControl = new TableUserControl();
            this.ConfigureControl(tableControl, parent);
            FieldUserControl fieldUsercontrol = new FieldUserControl();
            this.ConfigureControl(fieldUsercontrol, parent);
            return tableControl;
        }

        public bool SaveConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);
            ObjectXMLSerializer<DtoDataType>.Save(this, filePath);
            return true;
        }

        public void LoadConfig(IDictionary<string, string> parameters)
        {
            var filePath = Path.Combine(parameters["basePath"], FILE_NAME);

            if (File.Exists(filePath))
            {
                var appService = ObjectXMLSerializer<DtoDataType>.Load(filePath);
                if (appService != null)
                {
                }
            }
        }

        public Table MetaData { get; set; }
    }
}
