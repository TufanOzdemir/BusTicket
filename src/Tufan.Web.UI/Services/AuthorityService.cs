using System.Threading.Tasks;
using Tufan.AuthorityApi.Client.Models;
using Tufan.Common.Abstraction;
using Tufan.Web.UI.Adapters;

namespace Tufan.Web.UI.Services
{
    public class AuthorityService : IDomainService
    {
        private readonly AuthorityAdapter authorityAdapter;

        public AuthorityService(AuthorityAdapter authorityAdapter)
        {
            this.authorityAdapter = authorityAdapter;
        }

        public async Task<string> GetToken(SessionRequest sessionRequest)
        {
            return await authorityAdapter.GetToken(sessionRequest);
        }
    }
}
