#region

using System;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StructureMap;

#endregion

namespace DotNetScaffolder.Domain.Services.WebApi.Default.Middleware
{
    public class DataMiddleware
    {
        #region Fields

        /// <summary>
        ///     The logger.
        /// </summary>
        private readonly ILogger<DataMiddleware> logger;

        /// <summary>
        ///     The next.
        /// </summary>
        private readonly RequestDelegate next;

        //private IUnitOfWork unitOfWork;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DataMiddleware" /> class.
        /// </summary>
        /// <param name="next">
        ///     The next.
        /// </param>
        /// <param name="configuration">
        ///     The configuration.
        /// </param>
        /// <param name="container">
        ///     The container.
        /// </param>
        /// <param name="provider">
        ///     The provider.
        /// </param>
        /// <param name="multitenancy">
        ///     The multitenancy.
        /// </param>
        /// <param name="logger">
        ///     The logger.
        /// </param>
        public DataMiddleware(
            RequestDelegate next,
            IConfiguration configuration,
            IContainer container,
            IServiceProvider provider,
            ILogger<DataMiddleware> logger
        )
        {
            this.next = next;

            Configuration = configuration;
            Container = container;
            //this.ServiceProvider = provider;
            this.logger = logger;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the configuration.
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        ///     Gets or sets the container.
        /// </summary>
        public IContainer Container { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        ///     The invoke.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                logger.LogTrace("Started Invoke()");

                BeginInvoke(context);
                await next.Invoke(context);
                EndInvoke(context);
            }
            catch (Exception ex)
            {
                logger.LogCritical($"An error occured while Invoking the page: {ex.Message}");
                throw;
            }

            logger.LogTrace("Completed Invoke()");
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     Add context.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <returns>
        ///     The <see cref="IUnitOfWork" />.
        /// </returns>
        private IUnitOfWork AddContext(HttpContext context)
        {
            var unitOfWork = Container.GetInstance<IUnitOfWork>();

            unitOfWork.StartTransaction();
            context.Items["WebUnitOfWork"] = unitOfWork;

            return unitOfWork;
        }

        /// <summary>
        ///     The begin invoke.
        ///     Application_BeginRequest
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        private void BeginInvoke(HttpContext context)
        {
            logger.LogTrace("Started BeginInvoke()");

            // Do custom work before controller execution
            var uow = AddContext(context);

            logger.LogTrace("Completed BeginInvoke()");
        }

        /// <summary>
        ///     The end invoke.
        ///     Application_EndRequest
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        private void EndInvoke(HttpContext context)
        {
            logger.LogTrace("Started EndInvoke()");

            // Do custom work after controller execution
            IUnitOfWork fullContext = context.Items["WebUnitOfWork"] as IUnitOfWork;
            if (fullContext != null)
            {
                logger.LogInformation("Commiting Context");
                //fullContext.Commit();

                // Todo: I think this is redundent as it gets called again when the DataMiddleWare is disposed. We will have to investigate this.
                //fullContext.Dispose();
                context.Items["WebUnitOfWork"] = null;
            }

            logger.LogTrace("Started EndInvoke()");
        }

        #endregion
    }
}