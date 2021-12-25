using Microsoft.AspNetCore.Http;
using Tufan.Common.Http;

namespace Tufan.Web.UI.Providers
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetToken()
        {
            return _httpContextAccessor.HttpContext.Session.GetString("JWToken");
        }

        public string GetScheme()
        {
            return "Bearer";
        }
    }
}