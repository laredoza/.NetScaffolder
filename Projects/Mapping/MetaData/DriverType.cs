using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaData
{
    /// <summary>
    /// The driver type.
    /// </summary>
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
