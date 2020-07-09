
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreTest.Filter
{
    public class MyAttributeFilter:ActionFilterAttribute
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

    }


}