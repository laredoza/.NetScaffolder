using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData.Project
{
    /// <summary>
    /// The source type.
    /// </summary>
    public class SourceType
    {
        public string Name { get; set; }

        public static List<SourceType> Load()
        {
            List<SourceType> sources = new List<SourceType>();
            sources.Add(new SourceType { Name = "Sql"});
            sources.Add(new SourceType { Name = "Oracle" });
            sources.Add(new SourceType { Name = "Edmx" });

            return sources;
        }
    }
}
