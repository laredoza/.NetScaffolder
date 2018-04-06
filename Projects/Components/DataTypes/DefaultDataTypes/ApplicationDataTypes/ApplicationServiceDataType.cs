using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetScaffolder.Components.Common.Contract;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    [Export(typeof(IDataType))]
    [ExportMetadata("NameMetaData", "Application Service")]
    [ExportMetadata("ValueMetaData", "1BC1B0C4-1E41-9146-82CF-599181CE4420")]

    public class ApplicationServiceDataType : IDataType
    {
        public ApplicationServiceDataType()
        {

        }

        public TreeNode ReturnNavigation()
        {
            TreeNode result = new TreeNode { Text = "Application Service" };
            return result;
        }
    }
}
