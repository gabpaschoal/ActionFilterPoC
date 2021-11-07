using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterPoC.Filters;

public class ActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    { }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        context.HttpContext.Response.StatusCode = 999;
        var newResult = context.Result as ObjectResult;
        if (newResult is not null)
            newResult.Value = "Modified by filter";
    }
}
