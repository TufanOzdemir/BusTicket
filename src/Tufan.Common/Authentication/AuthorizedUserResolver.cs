namespace Tufan.Common.Authentication
{
    public class AuthorizedUserResolver : IAuthorizedUserResolver
    {
        private IDomainPrincipal _principal;

        public AuthorizedUserResolver(IDomainPrincipal principal)
        {
            _principal = principal;
        }

        public string GetAccessToken => _principal.AccessToken;
    }
}