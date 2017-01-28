using MetaData.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData.Project
{
    public class Domain
    {
        public string Name { get; set; }
        public NamingConvention NamingConvention { get; set; }
        public List<CollectionOption> CollectionOptions { get; set; }
        public List<SourceType> Sources { get; set; }

        public Domain()
        {
            this.NamingConvention = NamingConvention.Unchanged;
            this.CollectionOptions = CollectionOption.Load();
            this.Sources = SourceType.Load();
        }
    }
}
