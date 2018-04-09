using DotNetScaffolder.Components.Common.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.CollectionOption
{
    [Export(typeof(INamingConvention))]
    [ExportMetadata("NameMetaData", "Collection And Hash Set")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class CollectionAndHashSetCollectionOption : ICollectionOption
    {
        public string ClassName {
            get
            {
                return "Hashtable";
            }
        }
    }
}
