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
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Table")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4490")]

    public class TableDataType : IDataType
    {
        private Control tableControl;
        private Control fieldsControl;
        private Control relationshipControls;

        public  TableDataType()
        {
        }

        public object AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            TableUserControl tableControl = new TableUserControl();
            this.ConfigureControl(tableControl, parent);
            FieldUserControl fieldUsercontrol = new FieldUserControl();
            this.ConfigureControl(fieldUsercontrol, parent);
            return tableControl;
        }

        public bool SaveConfig()
        {
            return false;
        }

        public void LoadConfig(string basePath)
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
    }
}
