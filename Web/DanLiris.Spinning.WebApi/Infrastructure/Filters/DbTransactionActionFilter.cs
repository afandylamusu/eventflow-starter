using Microsoft.AspNetCore.Mvc.Filters;

namespace DanLiris.Spinning.WebApi.Infrastructure.Filters
{
    public class DbTransactionActionFilter : IActionFilter
    {
        public DbTransactionActionFilter()
        {

        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
