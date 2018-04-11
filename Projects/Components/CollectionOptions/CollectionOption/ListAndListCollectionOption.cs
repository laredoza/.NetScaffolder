using System.ComponentModel.Composition;
using DotNetScaffolder.Components.Common.Contract;

namespace DotNetScaffolder.Components.CollectionOption
{
    [Export(typeof(ICollectionOption))]
    [ExportMetadata("NameMetaData", "List")]
    [ExportMetadata("ValueMetaData", "0BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class ListAndListCollectionOption : ICollectionOption
    {
        public string ClassName => "List";
    }
}