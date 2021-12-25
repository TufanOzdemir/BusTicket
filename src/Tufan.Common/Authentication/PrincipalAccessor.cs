using System.Security.Claims;

namespace Tufan.Common.Authentication
{
    public class PrincipalAccessor : IPrincipalAccessor
    {
        public ClaimsPrincipal CurrentPrincipal { get; set; }
    }
}