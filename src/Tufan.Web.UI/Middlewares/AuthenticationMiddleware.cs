using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Tufan.Web.UI.Services;

namespace Tufan.Web.UI.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, AuthorityService authorityService)
        {
            var token = httpContext.Session.GetString("JWToken");
            bool isTokenNotNull = !string.IsNullOrEmpty(token);

            if (isTokenNotNull)
            {
                httpContext.Request.Headers.Add("Authorization", $"Bearer {token}");
            }
            else
            {
                token = await authorityService.GetToken(new AuthorityApi.Client.Models.SessionRequest() 
                { 
                    Browser = new AuthorityApi.Client.Models.BrowserRequest()
                    {
                        Name = "Chrome",
                        Version = "47.0.0.12"
                    },
                    Connection = new AuthorityApi.Client.Models.ConnectionRequest()
                    {
                        IpAddress = "165.114.41.21",
                        Port = "5117"
                    },
                    Type = 1
                });
                httpContext.Request.Headers.Add("Authorization", $"Bearer {token}");
                httpContext.Session.SetString("JWToken", token);
            }

            await _next(httpContext);
        }
    }
}