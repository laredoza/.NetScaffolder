using DotNetScaffolder.Domain.Infrastructure.Web.Core.BootStrap.StructureMap.Registry;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.BootStrap.StructureMap
{
    /// <summary>
    ///     The structure map registration.
    /// </summary>
    public class StructureMapRegistration
    {
        #region Public Methods And Operators

        /// <summary>
        /// The create and configure.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        /// <param name="services">
        /// The services.
        /// </param>
        /// <param name="scanFolder"></param>
        /// <param name="searchAssemblies"></param>
        /// <returns>
        /// The <see cref="Container"/>.
        /// </returns>
        public static Container CreateAndConfigure(IConfiguration configuration, IServiceCollection services, string scanFolder, string searchAssemblies)
        {
            Container container = new Container();

            container.Configure(
                config => { config.AddRegistry(new CoreConfigurationRegistry(configuration)); });

            container.Configure(
                config =>
                {
                    config.Scan(
                        scanner =>
                        {
                            scanner.AssembliesAndExecutablesFromPath(scanFolder);
                            //scanner.AssembliesAndExecutablesFromPath("../../Modules");
                            scanner.AssembliesAndExecutablesFromApplicationBaseDirectory(assembly =>
                            assembly.FullName.Contains(searchAssemblies));
                            //scanner.AssembliesAndExecutablesFromApplicationBaseDirectory();
                            scanner.LookForRegistries();
                        });
                });

            return container;
        }

        #endregion
    }
}
