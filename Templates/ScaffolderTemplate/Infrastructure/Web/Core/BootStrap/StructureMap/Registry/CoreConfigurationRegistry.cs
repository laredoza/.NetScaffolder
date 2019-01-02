using System.Collections.Generic;
using DotNetScaffolder.Domain.Core;
using DotNetScaffolder.Domain.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using StructureMap.Pipeline;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.BootStrap.StructureMap.Registry
{
    /// <summary>
    /// The core configuration registry.
    /// </summary>
    public class CoreConfigurationRegistry : global::StructureMap.Registry
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreConfigurationRegistry"/> class.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        public CoreConfigurationRegistry(IConfiguration configuration)
        {
            this.Configuration = configuration;
            IDataConfiguration dataConfiguration = new DataConfiguration();
            List<string> connectionStrings = new List<string>
            {
                    "RepoTestEFCoreSqlServer",
                    "RepoTestEFCorePostgres",
                    "RepoTestEFCoreMySql"
            };

            dataConfiguration.Load(configuration, connectionStrings);
            this.For<IDataConfiguration>().LifecycleIs(Lifecycles.Singleton).Use(() => dataConfiguration);


            //this.For<IDatabaseManager>()
            //For<IDataConfiguration>().Use<DataConfiguration>
            //    .Ctor<string>("connectionString").Is(dataConfiguration);

            //this.For<IDataConfiguration>().LifecycleIs(Lifecycles.Singleton).Use(() => dataConfiguration);
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        public IConfiguration Configuration { get; set; }

        #endregion
    }
}
