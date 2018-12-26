using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFDotnet.Infrastructure.Web.Core.Extensions;

namespace RepositoryEFDotnet.Services.WebApi.Default
{
    public class Startup
    {
        #region Fields

        /// <summary>
        ///     The hosting environment.
        /// </summary>
        private IHostingEnvironment hostingEnvironment;

        #endregion

        #region Constructors and Destructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region Public Properties

        public IConfiguration Configuration { get; }

        #endregion

        #region Public Methods And Operators

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;

            if (hostingEnvironment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            app.UseMvc(routes => { routes.MapRoute("DefaultApi", "api/{controller}/{id?}"); });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2); ;
            //.AddRazorPagesOptions(options =>
            //{
            //    options.Conventions..AuthorizePage("/Contact");
            //    options.Conventions.AuthorizeFolder("/Private");
            //    options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
            //    options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
            //})
            //.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            return services.Build(Configuration, hostingEnvironment, "./", "RepositoryEFDotnet");
        }

        #endregion
    }
}