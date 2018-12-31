using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Infrastructure.Web.Core.BootStrap.StructureMap;
using StructureMap;

namespace RepositoryEFDotnet.Infrastructure.Web.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {

        /// <summary>
        /// The build.
        /// </summary>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        /// <param name="hostingEnvironment">
        /// The hosting environment.
        /// </param>
        /// <returns>
        /// The <see cref="IServiceProvider"/>.
        /// </returns>
        public static IServiceProvider Build(
            this IServiceCollection services,
            IConfiguration configuration,
            IHostingEnvironment hostingEnvironment,
            string scanFolder, 
            string searchAssemblies
            )
        {
            var container = StructureMapRegistration.CreateAndConfigure(configuration, services, scanFolder, searchAssemblies);
            services.AddSingleton(configuration);

            // Setup identity
            //var identityManager = container.TryGetInstance<IIdentityManager>();
            //identityManager?.AddCustomizedIdentity(services, configuration, null);

            container.Configure(config => config.Populate(services));

            //IUnitOfWork unitOfWork = container.GetInstance<IDatabaseManager>().BeginUnitOfWork(
            //    container.GetInstance<IDataConfiguration>());

            //For<IDataConfiguration>().Use<DataConfiguration>
            //    .Ctor<string>("connectionString").Is(dataConfiguration);



            //container.Configure(
            //    config =>
            //        {
            //            config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use(() => unitOfWork);
            //        });

            IDatabaseManager databaseManager = container.GetInstance<IDatabaseManager>();
            IDataConfiguration dataConfiguration = container.GetInstance<IDataConfiguration>();
            databaseManager.RegisterUnitOfWork(dataConfiguration, container);

            return container.GetInstance<IServiceProvider>();
        }
    }
}
