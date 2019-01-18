using System;
using System.IdentityModel.Tokens.Jwt;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Extensions;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Security;
using DotNetScaffolder.Domain.Services.WebApi.Default.Filter;
using DotNetScaffolder.Domain.Services.WebApi.Default.Middleware;
using DotNetScaffolder.Domain.Services.WebApi.Default.Security;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace DotNetScaffolder.Domain.Services.WebApi.Default
{
    public class Startup
    {
        #region Constants

        private const string SearchAssemblies = "DotNetScaffolder";

        #endregion

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

            app.UseMiddleware<DataMiddleware>();

            if (hostingEnvironment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();
            //app.UseAuthentication();

            app.UseMvc(routes => { routes.MapRoute("DefaultApi", "api/controller/action"); });


        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore(
                setup =>
                    {
                        setup.Filters.AddService<UnitOfWorkFilter>(1);
                    }
                ).AddJsonFormatters();

            //services.AddMvc(
            //    setup => { setup.Filters.AddService<UnitOfWorkFilter>(1); }
            //);
            //services.AddMvc();

            //services
            //    .AddMvc(setup =>
            //    {
            //        setup.Filters.AddService<UnitOfWorkFilter>(1);
            //    });

            //    .AddAuthorization()
            //    .AddJsonFormatters();

            //services.AddAuthentication("Bearer")
            //    .AddIdentityServerAuthentication(options =>
            //    {
            //        options.Authority = "http://localhost:5000";
            //        options.RequireHttpsMetadata = false;

            //        options.ApiName = "api1";
            //        options.ApiSecret = "secret";
            //    });

            services.AddTransient<ISecurityFilter, SecurityFilter>();
            //.AddRazorPagesOptions(options =>
            //{
            //    options.Conventions..AuthorizePage("/Contact");
            //    options.Conventions.AuthorizeFolder("/Private");
            //    options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
            //    options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
            //})
            //.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            return services.Build(Configuration, hostingEnvironment, "./", SearchAssemblies);
        }

        #endregion
    }
}