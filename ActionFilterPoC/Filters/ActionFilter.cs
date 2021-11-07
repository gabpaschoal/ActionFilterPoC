using ActionFilterPoC.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterPoC.Filters;

public class ActionFilter : IActionFilter
{
    private readonly IRepository _repository;

    public ActionFilter(IRepository repository)
    {
        _repository = repository;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var all = _repository.GetAll();
        _ = all.ToList();
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        context.HttpContext.Response.StatusCode = 999;
        var newResult = context.Result as ObjectResult;
        if (newResult is not null)
            newResult.Value = "Modified by filter";
    }
}
