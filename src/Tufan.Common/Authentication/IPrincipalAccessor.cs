using System.Security.Claims;

namespace Tufan.Common.Authentication
{
    public interface IPrincipalAccessor
    {
        ClaimsPrincipal CurrentPrincipal { get; set; }
    }
}