using System.Threading.Tasks;
using Tufan.AuthorityApi.Client.Models;
using Tufan.Common.Configuration;
using Tufan.Common.Http;

namespace Tufan.AuthorityApi.Client
{
    public class AuthorityApi
    {
        private readonly HttpMethodCreator _httpMethodCreator;
        private readonly UrlConfig _urlConfig;

        public AuthorityApi(HttpMethodCreator httpMethodCreator, UrlConfig urlConfig)
        {
            _httpMethodCreator = httpMethodCreator;
            _urlConfig = urlConfig;
        }

        public async Task<string> GetSession(SessionRequest request)
        {
            return await _httpMethodCreator.Post($"{_urlConfig.AuthorityUrl}/api/session", request);
        }
    }
}