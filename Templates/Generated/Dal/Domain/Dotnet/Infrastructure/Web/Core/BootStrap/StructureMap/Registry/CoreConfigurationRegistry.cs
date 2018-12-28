﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RepositoryEFDotnet.Core.Base;
using StructureMap.Pipeline;

namespace RepositoryEFDotnet.Infrastructure.Web.Core.BootStrap.StructureMap.Registry
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
            dataConfiguration.Load(configuration);
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