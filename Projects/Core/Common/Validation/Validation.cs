using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Core.Common.Validation
{
    public class Validation
    {
        public ValidationType ValidationType { get; set; }
        public string Description { get; set; }

        public Validation(ValidationType validationType, string description)
        {
            this.ValidationType = validationType;
            this.Description = description;
        }
    }
}
