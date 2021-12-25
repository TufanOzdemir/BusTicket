namespace Tufan.Ticket.Domain.Exception
{
    public class ServerException : UnhandledException<ExceptionCodes>
    {
        public ServerException(ExceptionCodes errorCode, string message = null, System.Exception exception = null) : base(errorCode, message, exception)
        {
        }
    }
}