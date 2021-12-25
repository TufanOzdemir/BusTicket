using System;

namespace Tufan.Ticket.Domain.Exception
{
    public class UnhandledException<T> : System.Exception
         where T : Enum
    {
        public T ErrorCode { get; set; }

        public UnhandledException(T errorCode = default, string message = null, System.Exception exception = null) : base(message, exception)
        {
            ErrorCode = errorCode;
        }
    }
}