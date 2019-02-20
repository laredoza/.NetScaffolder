using System.Threading.Tasks;
using DotNetScaffolder.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetScaffolder.Domain.Infrastructure.Web.Core.Filters
{
    public class UnitOfWorkFilter : IAsyncActionFilter
    {
        private readonly IUnitOfWork unitOfWork;

        public UnitOfWorkFilter(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //var connection = transaction.Connection;
            //if (connection.State != ConnectionState.Open)
            //    throw new NotSupportedException("The provided connection was not open!");

            var executedContext = await next.Invoke();
            if (executedContext.Exception == null)
            {
                unitOfWork.Commit();
            }
            else
            {
                unitOfWork.Rollback();
            }

            // Do custom work after controller execution
            //if (unitOfWork != null)
            //{
            //    unitOfWork.Commit();
            //}
        }
    }
}
