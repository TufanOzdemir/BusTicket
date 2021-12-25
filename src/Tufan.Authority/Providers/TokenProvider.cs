using Tufan.Common.Authentication;
using Tufan.Common.Http;

namespace Tufan.Authority.Providers
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IAuthorizedUserResolver _domainPrincipal;

        public TokenProvider(IAuthorizedUserResolver domainPrincipal)
        {
            _domainPrincipal = domainPrincipal;
        }

        public string GetScheme()
        {
            return "Basic";
        }

        public string GetToken()
        {
            //return _domainPrincipal.GetAccessToken;
            return "JEcYcEMyantZV095WVc3G2JtVjNZbWx1";
        }
    }
}