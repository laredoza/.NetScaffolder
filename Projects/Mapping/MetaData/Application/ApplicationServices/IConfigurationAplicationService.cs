using DotNetScaffolder.Core.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Mapping.MetaData.Application.ApplicationServices
{
    public interface IConfigurationAplicationService : IValidate
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
