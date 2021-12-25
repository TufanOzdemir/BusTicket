using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Tufan.Common.Authentication
{
    public interface IDomainPrincipal : IPrincipal
    {
        string AccessToken { get; }
        string DeviceId { get; }
        string SessionId { get; }
        IEnumerable<Claim> Claims { get; }
        bool IsInScheme(string schemes);
        Task<bool> Validate();
    }
}