using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using DotNetScaffolder.Components.Common.Contract;

namespace DotNetScaffolder.Components.Drivers.DefaultDrivers.NHibernate.Cache
{
    [Export(typeof(IIDriverTypeCache))]
    [ExportMetadata("NameMetaData", "NHibernate Memory")]
    [ExportMetadata("ValueMetaData", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    [ExportMetadata("DriverType", "BB7460EE-5C1D-4E64-8515-C0DFD3752CB6")]
    public class MemoryCache : IIDriverTypeCache
    {
        //public Guid Driver { get; set; } 
        public string Name { get; set; }

        public List<string> CacheNamespaces { get; set; }

        public string GenerateBeginUnitOfWork(CacheParameters parameter)
        {
            StringBuilder sb = new StringBuilder();

            INHibernateConfig config = parameter.Driver as INHibernateConfig;

            sb.AppendLine(
                $"var nHibConfig = {config.ConfigName}.ConnectionString(configuration.ConnectionStrings[\"{parameter.ConnectionName}\"]);");
            sb.AppendLine("             Configuration = Fluently.Configure().Database(nHibConfig)");
            sb.AppendLine(
                "               .Mappings(o => o.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()).Conventions.Add(");
            sb.AppendLine("                 FluentNHibernate.Conventions.Helpers.ConventionBuilder.Class.Always(");
            sb.AppendLine("                     z =>");
            sb.AppendLine("                         {");
            sb.AppendLine("                             z.BatchSize(512);");
            sb.AppendLine("                             z.Cache.ReadWrite();");
            sb.AppendLine("                     })");
            sb.AppendLine("                 )).Cache(");
            sb.AppendLine("                     o => o.ProviderClass<NHibernate.Caches.CoreMemoryCache.CoreMemoryCacheProvider>().UseQueryCache().UseSecondLevelCache()");
            sb.AppendLine("             ).BuildConfiguration();");


            sb.AppendLine("             Factory = Configuration.BuildSessionFactory();");
            sb.AppendLine();
            sb.AppendLine("             container.Configure(");
            sb.AppendLine("             config =>");
            sb.AppendLine("             {");
            sb.AppendLine($"                config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<{parameter.Driver.Prefix}{parameter.ContextName}>()");
            sb.AppendLine("                 .Ctor<ISessionFactory>(\"factory\").Is(Factory);");
            sb.AppendLine("             });");

            return sb.ToString();
        }
        //public string GenerateInstantiationText(CacheParameters parameter)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Provider = Quirc.Cloud.DataAccess.Context.EFCore.SqlServer.Database.ConfigureServices.GetInMemoryCacheServiceProvider()");
        //    sb.AppendLine("EFSecondLevelCache.Core.EFServiceProvider.ApplicationServices = Provider");
        //    sb.AppendLine();
        //    sb.AppendLine("container.Configure(");
        //    sb.AppendLine("    config =>");
        //    sb.AppendLine("    {");
        //    sb.AppendLine("        config.For<IUnitOfWork>().LifecycleIs(Lifecycles.Transient).Use<SqlServerFullContext>()");
        //    sb.AppendLine("            .Ctor<string>(\"connectionString\").Is(configuration.ConnectionStrings[\"QUIRCSqlServer\"])");
        //    sb.AppendLine("            .Ctor<IServiceProvider>(\"provider\").Is(Provider);");
        //    sb.AppendLine(")});");
        //    return sb.ToString();
        //}

        public MemoryCache()
        {
            //this.Driver = new Guid("2BC1B0C4-1E41-9146-82CF-599181CE4417");
        }

    }
}
