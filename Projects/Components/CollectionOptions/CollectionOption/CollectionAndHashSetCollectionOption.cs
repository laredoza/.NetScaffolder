using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;

namespace DotNetScaffolder.Components.CollectionOption
{
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "Collection")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4410")]
    public class CollectionAndHashSetCollectionOption : ICollectionOption
    {
        public string ClassName => "Hashtable";
    }
}