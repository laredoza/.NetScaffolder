using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;
using DotNetScaffolder.Components.DataTypes.DefaultDataTypes.RepositoryDataTypes;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Repository")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4450")]
    public class RepositoryDataType : IDataType
    {
        public RepositoryDataType()
        {

        }

        public object AddConfigUI(object parameters)
        {
            Control parent = parameters as Control;
            RepositoryUserControl newControl = new RepositoryUserControl();
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
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4450"), Name = "Repository" };
        }
    }
}
