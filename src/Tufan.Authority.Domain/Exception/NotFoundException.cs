namespace Tufan.Authority.Domain.Exception
{
    public class NotFoundException : UnhandledException<NotFoundExceptionCodes>
    {
        public NotFoundException(NotFoundExceptionCodes errorCode, string message = null, System.Exception exception = null) : base(errorCode, message, exception)
        {
        }
    }
}