using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Tufan.Common.Configuration;
using Tufan.Common.Exception;
using Tufan.Ticket.Domain.Exception;

namespace Tufan.Ticket.Middlewares
{
    internal class InternalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly IStringLocalizer<ExceptionCodes> _exceptionLocalizer;
        private readonly IStringLocalizer<NotFoundExceptionCodes> _notfoundExceptionLocalizer;
        private readonly IStringLocalizer<ForbidenExceptionCodes> _forbidenExceptionLocalizer;
        private readonly ExceptionConfig _exceptionConfig;

        public InternalExceptionHandler(RequestDelegate next,
           IStringLocalizer sharedLocalizer,
           IStringLocalizer<ExceptionCodes> exceptionLocalizer,
           IStringLocalizer<NotFoundExceptionCodes> notfoundExceptionLocalizer,
           IStringLocalizer<ForbidenExceptionCodes> forbidenExceptionLocalizer,
           IConfigResolver configResolver)
        {
            _next = next;
            _sharedLocalizer = sharedLocalizer;
            _exceptionLocalizer = exceptionLocalizer;
            _notfoundExceptionLocalizer = notfoundExceptionLocalizer;
            _forbidenExceptionLocalizer = forbidenExceptionLocalizer;
            _exceptionConfig = configResolver.Resolve<ExceptionConfig>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (BadRequestException<ExceptionCodes> badRequestException)
            {
                await HandleBadRequestException(httpContext, badRequestException);
            }
            catch (UnhandledException<ExceptionCodes> unhandledException)
            {
                await HandleUnHandledException(httpContext, unhandledException);
            }
            catch (ForbiddenException forbiddenException)
            {
                await HandleForbiddenException(httpContext, forbiddenException);
            }
            catch (NotFoundException notFoundException)
            {
                await HandleNotFoundException(httpContext, notFoundException);
            }
            catch (RestRequestException ex)
            {
                await HandleExternalException(httpContext, ex);
            }
            catch (Exception ex)
            {
                await HandleGeneralException(httpContext, ex);
            }
        }

        private async Task HandleNotFoundException(HttpContext httpContext, NotFoundException notFoundException)
        {
            var message = _notfoundExceptionLocalizer[notFoundException.ErrorCode.ToString()];

            if (message.ResourceNotFound)
                message = _sharedLocalizer[_exceptionConfig.Messages.NotFoundMessage];

            var response = new ErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }

        private async Task HandleExternalException(HttpContext httpContext, RestRequestException externalException)
        {
            var message = _exceptionConfig.Messages.ExternalMessage;

            var response = new ErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }

        private async Task HandleForbiddenException(HttpContext httpContext, ForbiddenException forbiddenException)
        {
            var message = _forbidenExceptionLocalizer[forbiddenException.ErrorCode.ToString()];

            if (message.ResourceNotFound)
                message = _sharedLocalizer[_exceptionConfig.Messages.ForbiddenMessage];

            var response = new ErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }

        public async Task HandleBadRequestException(HttpContext httpContext, BadRequestException<ExceptionCodes> badRequestException)
        {
            var message = _exceptionLocalizer[badRequestException.ErrorCode.ToString()];

            if (message.ResourceNotFound)
                message = _sharedLocalizer[_exceptionConfig.Messages.BadRequestMessage];

            var response = new BadRequestErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }

        public async Task HandleUnHandledException(HttpContext httpContext, UnhandledException<ExceptionCodes> unhandledException)
        {
            var message = _exceptionLocalizer[unhandledException.ErrorCode.ToString()];
            if (message.ResourceNotFound)
            {
                message = _sharedLocalizer[_exceptionConfig.Messages.UnhandledMessage];
            }

            var response = new ErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }

        public async Task HandleGeneralException(HttpContext httpContext, Exception ex)
        {
            var message = _exceptionConfig.Messages.GeneralMessage;

            var response = new ErrorResponse(message);
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            httpContext.Response.ContentType = _exceptionConfig.ContentType;
            await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }

    internal static class InternalExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseInternalExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<InternalExceptionHandler>();
        }
    }
}