namespace Tufan.Common.Exception
{
    public class ErrorResponse
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public ErrorResponse() : this(null, null)
        {
        }

        public ErrorResponse(string errorMessage) : this(errorMessage, null)
        {
        }

        public ErrorResponse(string errorMessage, string errorCode)
        {
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }
    }
}