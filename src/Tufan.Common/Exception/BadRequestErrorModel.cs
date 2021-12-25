using System.Collections.Generic;

namespace Tufan.Common.Exception
{
    public class BadRequestErrorResponse : ErrorResponse
    {
        public virtual List<BadRequestErrorItemModel> Errors { get; set; }

        public BadRequestErrorResponse() { }

        public BadRequestErrorResponse(string errorMessage) : base(errorMessage) { }

        public BadRequestErrorResponse(string errorMessage, string errorCode) : base(errorMessage, errorCode) { }
    }
}