using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Mapping.MetaData.Enum;

namespace DotNetScaffolder.Mapping.MetaData.Application
{
    public class ApplicationSettings : IValidate
    {
        /// <summary>
        /// Gets or sets the validation result.
        /// </summary>
        public Dictionary<ValidationType, string> ValidationResult { get; set; }

        public Dictionary<ValidationType, string> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
