using System.Threading.Tasks;
using Tufan.AuthorityApi.Client.Models;

namespace Tufan.Web.UI.Adapters
{
    public class AuthorityAdapter
    {
        private readonly AuthorityApi.Client.AuthorityApi _authorityApi;

        public AuthorityAdapter(AuthorityApi.Client.AuthorityApi authorityApi)
        {
            _authorityApi = authorityApi;
        }

        public async Task<string> GetToken(SessionRequest sessionRequest)
        {
            return await _authorityApi.GetSession(sessionRequest);
        }
    }
}