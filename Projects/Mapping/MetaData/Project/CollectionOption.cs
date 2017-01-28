namespace DotNetScaffolder.Mapping.MetaData.Project
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class CollectionOption
    {
        public string Name { get; set; }
        public string NameSpace { get; set; }


        public static List<CollectionOption> Load()
        {
            List<CollectionOption> collections = new List<CollectionOption>();

            collections.Add(new CollectionOption { Name = "ICollectionAndHashSet", NameSpace = "" });
            collections.Add(new CollectionOption { Name = "IListAndList", NameSpace = "" });
            collections.Add(new CollectionOption { Name = "ObservableCollection", NameSpace = "" });

            return collections;
        }
    }
}
