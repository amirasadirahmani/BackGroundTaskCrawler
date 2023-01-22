namespace BackGroundTaskCrawler.EndPoints.Api.Model;

public class BaseError
{
    public BaseError(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}
