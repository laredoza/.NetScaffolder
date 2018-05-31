using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.DataTypes.DefaultDataTypes
{
    public class ContextDataError
    {
        public string TableName { get; set; }

        public ContextData ContextData { get; set; }
    }
}
