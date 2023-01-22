namespace BackGroundTaskCrawler.EndPoints.Api.Model;

public class BaseResponse<T>
{
    public BaseResponse(int code, bool isSuccess, T data, BaseError error = null)
    {
        Code = code;
        IsSuccess = isSuccess;
        Data = data;
        Error = error;
    }

    public int Code { get; set; }

    public bool IsSuccess { get; set; }

    public T Data { get; set; }

    public BaseError Error { get; set; }
}
