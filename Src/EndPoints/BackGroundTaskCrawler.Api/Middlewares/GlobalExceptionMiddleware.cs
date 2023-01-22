using BackGroundTaskCrawler.EndPoints.Api.Model;
using System.Text.Json;

namespace BackGroundTaskCrawler.EndPoints.Api;

public class GlobalExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public GlobalExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (Exception e)
        {
            var response = new BaseResponse<dynamic>(400, false, new BaseError(e.Message));
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
