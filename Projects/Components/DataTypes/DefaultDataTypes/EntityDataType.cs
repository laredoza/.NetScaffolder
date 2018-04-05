using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Components.Common.Contract;

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
    }
}
