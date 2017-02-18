namespace DotNetScaffolder.Mapping.MetaData.Project.Packages
{
    using System;
    using System.Collections.Generic;

    public class DataType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public static List<DataType> Load()
        {
            List<DataType> result = new List<DataType>();
            result.Add(new DataType { Id = Guid.NewGuid(), Name = "Context" });
            result.Add(new DataType { Id = Guid.NewGuid(), Name = "Entity" });
            result.Add(new DataType { Id = Guid.NewGuid(), Name = "Repository" });
            result.Add(new DataType { Id = Guid.NewGuid(), Name = "Application Service" });
            return result;
        }
    }
}
