using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Tufan.Common.Configuration;
using Tufan.Common.Exception;

namespace Tufan.Web.UI.Middlewares
{
    internal class InternalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly IStringLocalizer _sharedLocalizer;
        private readonly ExceptionConfig _exceptionConfig;

        public InternalExceptionHandler(RequestDelegate next,
           IStringLocalizer sharedLocalizer,
           IConfigResolver configResolver)
        {
            _next = next;
            _sharedLocalizer = sharedLocalizer;
            _exceptionConfig = configResolver.Resolve<ExceptionConfig>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
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

        private async Task HandleExternalException(HttpContext httpContext, RestRequestException externalException)
        {
            var message = _exceptionConfig.Messages.ExternalMessage;

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