using DotNetScaffolder.Components.Common.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.CollectionOption
{
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "List And List")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class ListAndListCollectionOption : ICollectionOption
    {
        public string ClassName {
            get
            {
                return "List";
            }
        }
    }
}
