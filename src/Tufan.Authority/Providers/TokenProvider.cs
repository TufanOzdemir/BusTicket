using Microsoft.AspNetCore.Http;
using Tufan.Common.Http;

namespace Tufan.Authority.Providers
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetScheme()
        {
            return "Basic";
        }

        public string GetToken()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("JWToken");
        }
    }
}