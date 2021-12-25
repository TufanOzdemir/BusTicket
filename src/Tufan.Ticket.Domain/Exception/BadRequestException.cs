using System;

namespace Tufan.Ticket.Domain.Exception
{
    public class BadRequestException<T> : UnhandledException<T>
        where T : Enum
    {
        public BadRequestException(T errorCode = default, string message = null, System.Exception exception = null) : base(errorCode, message, exception)
        {
        }
    }
}