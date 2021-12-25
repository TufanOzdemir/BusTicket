namespace Tufan.Common.Http
{
    public class Result<T> : IResult<T>
    {
        public ResultTypeEnum Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Result()
        {
            Data = default(T);
        }
    }
}
