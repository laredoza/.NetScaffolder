using DotNetScaffolder.Core.Common.Validation;
using DotNetScaffolder.Mapping.MetaData.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Mapping.ApplicationServices
{
    public interface IConfigurationApplicationService : IValidate
    {
        ApplicationSettings ApplicationSettings { get; set; }

        /// <summary>
        /// Load ProjectDefinition.
        /// </summary>
        void Load();

        /// <summary>
        /// Save ProjectDefinition.
        /// </summary>
        void Save();
    }
}
