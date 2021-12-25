namespace Tufan.Authority.Domain.Exception
{
    public class ForbiddenException : UnhandledException<ForbidenExceptionCodes>
    {
        public ForbiddenException(ForbidenExceptionCodes errorCode, string message = null, System.Exception exception = null) : base(errorCode, message, exception)
        {
        }
    }
}