using BackGroundTaskCrawler.EndPoints.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BackGroundTaskCrawler.EndPoints.Api.Filters;

public class FluentValidationFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = context.ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .ToDictionary(x => x.Key, x => x.Value.Errors.Select(e => e.ErrorMessage));

            var e = errors.SelectMany(x => x.Value).First();
            context.Result = new OkObjectResult(new BaseResponse<dynamic>(400, false, null, new BaseError(e)));
            return;
        }

        await next();
    }
}
