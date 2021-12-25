namespace Tufan.Common.Http
{
    public interface IResult<T> : IResult
    {
        T Data { get; set; }
    }

    public interface IResult
    {
        string Message { get; set; }
        ResultTypeEnum Status { get; set; }
    }

    public enum ResultTypeEnum
    {
        None = 0,
        Information = 1,
        Success = 2,
        Warning = 3,
        Error = 4
    };
}