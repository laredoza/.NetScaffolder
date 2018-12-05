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
    [ExportMetadata("NameMetaData", "EFCore memory")]
    [ExportMetadata("ValueMetaData", "2BC1B0C4-1E41-9146-82CF-599181CE4411")]
    public class MemoryClass : IIDriverTypeCache
    {
        public Guid Driver { get; set; } 
        public string Name { get; set; }
        public string GenerateInstantiationText(CacheParameters parameter)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Provider = Quirc.Cloud.DataAccess.Context.EFCore.SqlServer.Database.ConfigureServices.GetInMemoryCacheServiceProvider()");
            sb.AppendLine("EFSecondLevelCache.Core.EFServiceProvider.ApplicationServices = Provider");
            sb.AppendLine();
            sb.AppendLine("container.Configure(");
            sb.AppendLine("    config =>");
            sb.AppendLine("    {");
            sb.AppendLine("        config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<SqlServerFullContext>()");
            sb.AppendLine("            .Ctor<string>(\"connectionString\").Is(configuration.ConnectionStrings[\"QUIRCSqlServer\"])");
            sb.AppendLine("            .Ctor<IServiceProvider>(\"provider\").Is(Provider);");
            sb.AppendLine(")});");
            return sb.ToString();
        }

        public MemoryClass()
        {
            this.Driver = new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4417");
        }

    }
}
