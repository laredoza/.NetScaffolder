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
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Entity")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4440")]

    public class EntityDataType : IDataType
    {
        public EntityDataType()
        {
        }

        public object AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            EntityUserControl newControl = new EntityUserControl();
            newControl.Visible = true;
            newControl.Dock = DockStyle.Fill;
            newControl.BringToFront();
            parent.Controls.Add(newControl);
            return newControl;
        }

        public bool SaveConfig()
        {
            return false;
        }

        public void LoadConfig(string basePath)
        {
        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4440"), Name = "Entity" };
        }
    }
}
