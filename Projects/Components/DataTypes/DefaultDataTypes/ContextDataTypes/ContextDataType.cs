using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;
using FormControls.TreeView;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Context")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4430")]

    public class ContextDataType : IDataType
    {
        public ContextDataType()
        {

        }

        public IHierarchy ReturnNavigation()
        {
            return new Hierarchy { Id = new Guid("1BC1B0C4-1E41-9146-82CF-599181CE4430"), Name = "Context" };
        }
    }
}
