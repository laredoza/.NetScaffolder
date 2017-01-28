using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData
{
    public class DriverType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Load(Guid driverId)
        {
            this.Id = Guid.NewGuid();
            Name = "Microsoft Sql";
        }

    }
}
