namespace DotNetScaffolder.Mapping.MetaData.Model
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    using DotNetScaffolder.Mapping.MetaData.Domain;

    public class DatabaseModel
    {
        [XmlArray("Tables")]
        [XmlArrayItem("Table")]
        public List<Table> Tables { get; set; }

        [XmlIgnore]
        public DomainDefinition Domain { get; set; }

        //public void RepairObjectParents()
        //{
        //    // Link child objects to parent for reference purposes
        //    if (Tables != null)
        //    {
        //        foreach (var tbl in Tables)
        //            tbl.RepairObjectParents(this);
        //    }

        //}

        //public MetadataTableCollectionDiff CompareToCollection(MetadataTableCollection second)
        //{
        //    return MetadataTableCollectionDiff.CompareTableCollections(this, second);
        //}

        //public static MetadataTableCollection LoadCollectionFromXmlFile(string xmlFileNameAndPath)
        //{
        //    var serializer = new XmlSerializer(typeof(MetadataTableCollection));
        //    var tableCollection = (MetadataTableCollection)serializer.Deserialize(File.OpenRead(xmlFileNameAndPath));

        //    tableCollection.RepairObjectParents();

        //    return tableCollection;
        //}

    }
}
