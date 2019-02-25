using System;
using DotNetScaffolder.Domain.Data.Dtos.DefaultDto.Dto;
using DotNetScaffolder.Domain.Data.Entities.DefaultEntity.Entity;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Extensions;
using DotNetScaffolder.Domain.Infrastructure.Web.Core.Filters;
using DotNetScaffolder.IdentityServer.Services.WebApi.IdentityServer.Identity4;
using IdentityServer4.AccessTokenValidation;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Identity;

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
            services.AddMvc(
                setup => { setup.Filters.AddService<UnitOfWorkFilter>(1); }
            );




            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                //.AddInMemoryClients(Config.GetClients())
                .AddClientStore<ClientStore>()
            //.AddTestUsers(Config.GetUsers())
            .AddProfileService<ProfileService>();

            ////identity server 4 cert
            //var cert = new X509Certificate2(Path.Combine(_environment.ContentRootPath, "idsrv4test.pfx"), "your_cert_password");

            ////DI DBContext inject connection string
            //services.AddScoped(_ => new YourDbContext(Configuration.GetConnectionString("DefaultConnection")));

            ////my user repository
            //services.AddScoped<IUserRepository, UserRepository>();

            ////add identity server 4
            //services.AddIdentityServer()
            //    .AddSigningCredential(cert)
            //    .AddInMemoryIdentityResources(Config.GetIdentityResources()) //check below
            //    .AddInMemoryApiResources(Config.GetApiResources())
            //    .AddInMemoryClients(Config.GetClients())
            //    .AddProfileService<ProfileService>();p

            ////Inject the classes we just created
            services.AddTransient<IResourceOwnerPasswordValidator, ResourceOwnerPasswordValidator>();
            services.AddTransient<IPasswordHasher<AspNetUserDto>, PasswordHasher<AspNetUserDto>>();
            services.AddTransient<IProfileService, ProfileService>();

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
