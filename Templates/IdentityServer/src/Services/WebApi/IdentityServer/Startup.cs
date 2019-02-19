using System;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Extensions;

namespace DotNetScaffolder.Domain.Services.WebApi.IdentityServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #region Constants

        private const string SearchAssemblies = "DotNetScaffolder";

        #endregion

        #region Fields

        /// <summary>
        ///     The hosting environment.
        /// </summary>
        private IHostingEnvironment hostingEnvironment;

        #endregion

        #region Public Properties

        public IConfiguration Configuration { get; }

        #endregion

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddTransient<IProfileService, MyProfileService>();

            services.AddIdentityServer()
            .AddDeveloperSigningCredential()
            .AddInMemoryIdentityResources(Config.GetIdentityResources())
            .AddInMemoryApiResources(Config.GetApiResources())
            .AddInMemoryClients(Config.GetClients())
            .AddTestUsers(Config.GetUsers())
            .AddProfileService<MyProfileService>();

            return services.Build(Configuration, hostingEnvironment, "./", SearchAssemblies);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            this.hostingEnvironment = hostingEnvironment;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }


    }
}
