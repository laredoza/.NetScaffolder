using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetScaffolder.Components.Common.Contract;

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.EFCore.Cache
{
    [Export(typeof(IIDriverTypeCache))]
    [ExportMetadata("NameMetaData", "EFCore Redis")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4413")]
    [ExportMetadata("DriverType", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class RedisCache : IIDriverTypeCache
    {
        public string Name { get; set; }

        public List<string> CacheNamespaces { get; set; }

        public string GenerateBeginUnitOfWork(CacheParameters parameter)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Provider = ConfigureServices.GetRedisCacheServiceProvider();");
            sb.AppendLine("             EFSecondLevelCache.Core.EFServiceProvider.ApplicationServices = Provider;");
            sb.AppendLine();
            sb.AppendLine("             container.Configure(");
            sb.AppendLine("                 config =>");
            sb.AppendLine("                 {");
            sb.AppendLine($"                    config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<{parameter.Driver.Prefix}{parameter.ContextName}>()");
            sb.AppendLine($"                         .Ctor<string>(\"connectionString\").Is(configuration.ConnectionStrings[\"{parameter.ConnectionName}\"])");
            sb.AppendLine("                         .Ctor<IServiceProvider>(\"provider\").Is(Provider);");
            sb.AppendLine("                 });");

            return sb.ToString();
        }

        public RedisCache()
        {
        }

    }
}
